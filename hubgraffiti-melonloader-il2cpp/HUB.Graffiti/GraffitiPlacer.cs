using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HUB.Graffiti.Network;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Graffiti;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>
	/// Adds the STICKER button to the game's graffiti menu, applies the chosen sticker to the surface,
	/// and keeps the world's surfaces in line with the stored placements.
	/// </summary>
	internal static class GraffitiPlacer
	{
		private const int FakePaintedPixels = 5000;
		private const float FallbackButtonGap = 12f;

		private static readonly Color ButtonNormal = new Color(0.55f, 0.25f, 0.7f, 1f);
		private static readonly Color ButtonHighlighted = new Color(0.65f, 0.35f, 0.8f, 1f);
		private static readonly Color ButtonPressed = new Color(0.45f, 0.15f, 0.6f, 1f);
		private static readonly Color ButtonDisabled = new Color(0.3f, 0.3f, 0.3f, 1f);

		private static GameObject _stickerButton;
		private static bool _wasMenuOpen;
		private static bool _sceneReady;
		private static SpraySurface _savedSurface;
		private static GraffitiMenu _cachedMenu;
		private static Canvas _cachedCanvas;

		/// <summary>Surfaces already rewarded this session, so replacing a sticker doesn't pay out twice.</summary>
		private static readonly HashSet<string> _rewardedSurfaces = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		/// <summary>Menu buttons nudged to keep the row centred, with their original positions.</summary>
		private static readonly List<KeyValuePair<RectTransform, Vector2>> _shiftedButtons = new List<KeyValuePair<RectTransform, Vector2>>();

		internal static void Update()
		{
			if (!_sceneReady)
			{
				return;
			}
			if (_cachedMenu == null)
			{
				try
				{
					_cachedMenu = Singleton<GraffitiMenu>.Instance;
				}
				catch
				{
					return;
				}
				if (_cachedMenu == null)
				{
					return;
				}
			}
			if (_cachedCanvas == null)
			{
				try
				{
					_cachedCanvas = _cachedMenu.Canvas;
				}
				catch
				{
					_cachedMenu = null;
					return;
				}
				if (_cachedCanvas == null)
				{
					return;
				}
			}

			bool open;
			try
			{
				open = _cachedCanvas.enabled;
			}
			catch
			{
				_cachedMenu = null;
				_cachedCanvas = null;
				return;
			}

			if (open && !_wasMenuOpen)
			{
				_wasMenuOpen = true;
			}
			else if (!open && _wasMenuOpen)
			{
				_wasMenuOpen = false;
				_savedSurface = null;
				StickerPickerUI.Close();
			}
			// The button lives as long as the menu does; it's only rebuilt if something destroyed it.
			if (open && _stickerButton == null)
			{
				InjectButton(_cachedMenu);
			}
		}

		internal static void OnSceneLoaded(string sceneName)
		{
			_sceneReady = sceneName == "Main";
			CleanupButton();
			_cachedMenu = null;
			_cachedCanvas = null;
			_wasMenuOpen = false;
			_savedSurface = null;
			_rewardedSurfaces.Clear();
			SurfaceDecals.ResetAll();
		}

		// ---- STICKER button ----

		private static void CleanupButton()
		{
			foreach (KeyValuePair<RectTransform, Vector2> shifted in _shiftedButtons)
			{
				try
				{
					if (shifted.Key != null)
					{
						shifted.Key.anchoredPosition = shifted.Value;
					}
				}
				catch
				{
				}
			}
			_shiftedButtons.Clear();
			if (_stickerButton != null)
			{
				try
				{
					Object.Destroy(_stickerButton);
				}
				catch
				{
				}
			}
			_stickerButton = null;
		}

		private static void InjectButton(GraffitiMenu menu)
		{
			CleanupButton();
			try
			{
				Button doneButton = menu.DoneButton;
				if (doneButton == null)
				{
					return;
				}
				GameObject doneGo = doneButton.gameObject;
				RectTransform doneRect = doneGo.GetComponent<RectTransform>();
				Transform parent = doneGo.transform.parent;
				if (doneRect == null || parent == null)
				{
					return;
				}

				// Measure the row before our button joins it.
				List<RectTransform> row = FindButtonRow(parent, doneRect);

				_stickerButton = new GameObject("HUB_StickerButton");
				_stickerButton.transform.SetParent(parent, false);
				RectTransform rect = _stickerButton.AddComponent<RectTransform>();
				rect.anchorMin = doneRect.anchorMin;
				rect.anchorMax = doneRect.anchorMax;
				rect.pivot = doneRect.pivot;
				rect.sizeDelta = doneRect.sizeDelta;
				rect.localScale = doneRect.localScale;

				// Borrow the game button's sprite so the corners and size match UNDO / RESTART / DONE.
				Image image = _stickerButton.AddComponent<Image>();
				Image doneImage = doneGo.GetComponent<Image>();
				if (doneImage != null && doneImage.sprite != null)
				{
					image.sprite = doneImage.sprite;
					image.type = doneImage.type;
					image.pixelsPerUnitMultiplier = doneImage.pixelsPerUnitMultiplier;
				}
				image.color = Color.white;
				image.raycastTarget = true;

				Button button = _stickerButton.AddComponent<Button>();
				button.interactable = true;
				button.targetGraphic = image;
				ColorBlock colors = button.colors;
				colors.normalColor = ButtonNormal;
				colors.highlightedColor = ButtonHighlighted;
				colors.selectedColor = ButtonNormal;
				colors.pressedColor = ButtonPressed;
				colors.disabledColor = ButtonDisabled;
				button.colors = colors;
				button.onClick.AddListener(new Action(OnStickerButtonClicked));

				CreateButtonLabel(doneGo);

				if (parent.GetComponent<HorizontalLayoutGroup>() != null || parent.GetComponent<GridLayoutGroup>() != null)
				{
					// The row is laid out by Unity: become the next item after DONE with the same size.
					LayoutElement element = _stickerButton.AddComponent<LayoutElement>();
					LayoutElement doneElement = doneGo.GetComponent<LayoutElement>();
					if (doneElement != null)
					{
						element.minWidth = doneElement.minWidth;
						element.minHeight = doneElement.minHeight;
						element.preferredWidth = doneElement.preferredWidth;
						element.preferredHeight = doneElement.preferredHeight;
						element.flexibleWidth = doneElement.flexibleWidth;
						element.flexibleHeight = doneElement.flexibleHeight;
					}
					else
					{
						element.preferredWidth = doneRect.rect.width;
						element.preferredHeight = doneRect.rect.height;
					}
					_stickerButton.transform.SetSiblingIndex(doneGo.transform.GetSiblingIndex() + 1);
					LayoutRebuilder.MarkLayoutForRebuild(parent.GetComponent<RectTransform>());
				}
				else
				{
					_stickerButton.AddComponent<LayoutElement>().ignoreLayout = true;
					PlaceInRow(rect, doneRect, row);
				}

				_stickerButton.SetActive(true);
				DebugLog.Log("Placer", "STICKER button injected (row of " + row.Count + ")");
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "InjectButton error: " + ex.Message);
			}
		}

		/// <summary>Buttons sharing DONE's parent and vertical position, left to right.</summary>
		private static List<RectTransform> FindButtonRow(Transform parent, RectTransform doneRect)
		{
			List<RectTransform> row = new List<RectTransform>();
			float rowY = doneRect.localPosition.y;
			float tolerance = Math.Max(4f, doneRect.rect.height * 0.5f);
			for (int i = 0; i < parent.childCount; i++)
			{
				Transform child = parent.GetChild(i);
				if (child == null || !child.gameObject.activeSelf || child.GetComponent<Button>() == null)
				{
					continue;
				}
				RectTransform childRect = child.GetComponent<RectTransform>();
				if (childRect != null && Math.Abs(childRect.localPosition.y - rowY) <= tolerance)
				{
					row.Add(childRect);
				}
			}
			return row.OrderBy(r => r.localPosition.x).ToList();
		}

		/// <summary>
		/// Manual layout: put the button one step right of the last button in the row (same spacing as the
		/// existing ones), then shift the whole row half a step left so it stays centred.
		/// </summary>
		private static void PlaceInRow(RectTransform rect, RectTransform doneRect, List<RectTransform> row)
		{
			float step;
			float rightmostX;
			if (row.Count >= 2)
			{
				step = (row[row.Count - 1].localPosition.x - row[0].localPosition.x) / (row.Count - 1);
				rightmostX = row[row.Count - 1].localPosition.x;
			}
			else
			{
				step = doneRect.rect.width + FallbackButtonGap;
				rightmostX = doneRect.localPosition.x;
			}
			if (step <= 1f)
			{
				step = doneRect.rect.width + FallbackButtonGap;
			}

			// Same anchors as DONE, so a local-space offset from DONE maps 1:1 onto anchoredPosition.
			rect.anchoredPosition = doneRect.anchoredPosition + new Vector2(rightmostX + step - doneRect.localPosition.x, 0f);

			// Only re-centre when we really found the game's row; moving DONE on its own would overlap RESTART.
			if (row.Count >= 2)
			{
				Vector2 shift = new Vector2(-step * 0.5f, 0f);
				foreach (RectTransform button in row)
				{
					_shiftedButtons.Add(new KeyValuePair<RectTransform, Vector2>(button, button.anchoredPosition));
					button.anchoredPosition += shift;
				}
				rect.anchoredPosition += shift;
			}
		}

		private static void CreateButtonLabel(GameObject doneGo)
		{
			try
			{
				TextMeshProUGUI doneText = doneGo.GetComponentInChildren<TextMeshProUGUI>();
				if (doneText != null)
				{
					GameObject textGo = Object.Instantiate<GameObject>(doneText.gameObject, _stickerButton.transform);
					textGo.name = "Text";
					RectTransform textRect = textGo.GetComponent<RectTransform>();
					if (textRect != null)
					{
						// DONE's label may be offset to make room for its check-mark icon; ours has no icon.
						textRect.anchorMin = Vector2.zero;
						textRect.anchorMax = Vector2.one;
						textRect.offsetMin = Vector2.zero;
						textRect.offsetMax = Vector2.zero;
						textRect.localScale = Vector3.one;
					}
					TextMeshProUGUI text = textGo.GetComponent<TextMeshProUGUI>();
					if (text != null)
					{
						text.text = "STICKER";
						text.alignment = TextAlignmentOptions.Center;
						text.raycastTarget = false;
					}
					return;
				}

				GameObject fallback = new GameObject("Text");
				fallback.transform.SetParent(_stickerButton.transform, false);
				RectTransform fallbackRect = fallback.AddComponent<RectTransform>();
				fallbackRect.anchorMin = Vector2.zero;
				fallbackRect.anchorMax = Vector2.one;
				fallbackRect.offsetMin = Vector2.zero;
				fallbackRect.offsetMax = Vector2.zero;
				Text label = fallback.AddComponent<Text>();
				label.text = "STICKER";
				label.font = UiFonts.Builtin;
				label.fontSize = 14;
				label.fontStyle = FontStyle.Bold;
				label.alignment = TextAnchor.MiddleCenter;
				label.color = Color.white;
				label.raycastTarget = false;
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "Button text error: " + ex.Message);
			}
		}

		// ---- Placing ----

		private static void OnStickerButtonClicked()
		{
			DebugLog.Log("Placer", "STICKER button clicked");
			try
			{
				_savedSurface = _cachedMenu != null ? _cachedMenu.activeSurface : null;
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "Error saving surface: " + ex.Message);
			}
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}
			if (StickerManager.Count == 0)
			{
				MelonLogger.Msg("[HUB - Graffiti] No stickers loaded.");
				return;
			}
			StickerPickerUI.Open(OnStickerSelected);
		}

		private static void OnStickerSelected(int stickerIndex)
		{
			DebugLog.Log("Placer", "Sticker selected: index=" + stickerIndex);
			try
			{
				StickerData sticker = StickerManager.GetSticker(stickerIndex);
				if (sticker == null || sticker.Texture == null)
				{
					DebugLog.Log("Placer", "Sticker or texture null, aborting");
					return;
				}

				SpraySurface surface = _savedSurface;
				if (surface == null && _cachedMenu != null)
				{
					surface = _cachedMenu.activeSurface;
				}
				if (surface == null)
				{
					MelonLogger.Error("[HUB - Graffiti] No spray surface found!");
					return;
				}

				WorldSpraySurface world = surface.TryCast<WorldSpraySurface>();
				string guid = world != null ? GetGuid(world) : "";
				// Surfaces without a GUID (not world surfaces) still get the visual, keyed by instance.
				string key = !string.IsNullOrEmpty(guid) ? guid : "instance:" + surface.GetInstanceID();
				bool replacing = !string.IsNullOrEmpty(guid) && StickerSaveManager.Has(guid);

				bool alreadyMarked = false;
				if (world != null)
				{
					try
					{
						alreadyMarked = world._HasEverBeenMarkedByPlayer_k__BackingField;
					}
					catch
					{
					}
				}

				// Visual first so the game's finish-editing logic sees the sticker as the drawing output.
				if (!SurfaceDecals.Apply(surface, key, sticker))
				{
					MelonLogger.Error("[HUB - Graffiti] Could not apply sticker '" + sticker.Name + "'");
					return;
				}
				SetGameState(surface);
				try
				{
					surface.OnEditingFinished();
				}
				catch (Exception ex)
				{
					DebugLog.Log("Placer", "OnEditingFinished error: " + ex.Message);
				}

				if (world != null)
				{
					FinalizeWorldSurface(world, guid, alreadyMarked);
				}

				// The game's finalize may have touched the projector; put the sticker back on top.
				SurfaceDecals.Apply(surface, key, sticker);
				SetPaintedPixelCount(surface);

				if (!string.IsNullOrEmpty(guid))
				{
					StickerSaveManager.RecordPlacement(guid, sticker.Name);
					GraffitiSync.NotifyPlacement(guid, sticker.Name);
				}

				CloseMenu();
				MelonCoroutines.Start(ReassertAfterMenuClosed(GraffitiMod.SceneToken));

				if (!replacing && GraffitiMod.SpotsTagged != null)
				{
					GraffitiMod.SpotsTagged.Value = GraffitiMod.SpotsTagged.Value + 1;
					MelonPreferences.Save();
				}
				CustomUI.RequestRefresh();
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "OnStickerSelected error: " + ex.Message + "\n" + ex.StackTrace);
				MelonLogger.Error("[HUB - Graffiti] Apply error: " + ex.Message);
			}
		}

		private static void FinalizeWorldSurface(WorldSpraySurface world, string guid, bool alreadyMarked)
		{
			try
			{
				world._HasEverBeenMarkedByPlayer_k__BackingField = true;
			}
			catch
			{
			}
			try
			{
				world.SetFinalized();
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "SetFinalized error: " + ex.Message);
			}
			try
			{
				world.RpcLogic___SetFinalized_2166136261();
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "RpcLogic error: " + ex.Message);
			}
			try
			{
				world.MarkDrawingFinalized();
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "MarkDrawingFinalized error: " + ex.Message);
			}

			// Pay out once per surface, like spraying it by hand. The game's own flag survives reloads;
			// the session set covers replacing a sticker before the flag was ever saved.
			bool rewarded = alreadyMarked || (!string.IsNullOrEmpty(guid) && _rewardedSurfaces.Contains(guid));
			if (!rewarded)
			{
				try
				{
					world.Reward();
				}
				catch (Exception ex)
				{
					DebugLog.Log("Placer", "Reward error: " + ex.Message);
				}
			}
			if (!string.IsNullOrEmpty(guid))
			{
				_rewardedSurfaces.Add(guid);
			}

			try
			{
				world.Editable = false;
			}
			catch
			{
			}
		}

		/// <summary>
		/// Makes the game treat the surface as painted: a non-trivial pixel count and one stroke, so it
		/// passes the "drawing not empty" checks and gets saved as finished graffiti.
		/// </summary>
		private static void SetGameState(SpraySurface surface)
		{
			try
			{
				surface.EnsureDrawingExists();
				SetPaintedPixelCount(surface);
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					try
					{
						UShort2 start = default(UShort2);
						start.X = 100;
						start.Y = 100;
						UShort2 end = default(UShort2);
						end.X = 101;
						end.Y = 101;
						drawing.AddStroke(new SprayStroke(start, end, 1, 1));
					}
					catch (Exception ex)
					{
						DebugLog.Log("Placer", "Fake stroke error: " + ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "SetGameState error: " + ex.Message);
			}
		}

		private static void SetPaintedPixelCount(SpraySurface surface)
		{
			try
			{
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					try
					{
						drawing.PaintedPixelCount = FakePaintedPixels;
					}
					catch
					{
					}
					try
					{
						drawing._PaintedPixelCount_k__BackingField = FakePaintedPixels;
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				surface.DrawingPaintedPixelCount = FakePaintedPixels;
			}
			catch
			{
			}
		}

		private static void CloseMenu()
		{
			try
			{
				GraffitiMenu menu = _cachedMenu ?? Singleton<GraffitiMenu>.Instance;
				if (menu == null)
				{
					return;
				}
				try
				{
					menu.CancelClicked();
				}
				catch
				{
					try
					{
						menu.Close();
					}
					catch
					{
					}
				}
				try
				{
					menu.ClearActiveSurface();
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "Menu exit error: " + ex.Message);
			}
		}

		// Closing the menu can reset the surface's projector; re-apply shortly after it settles.
		private static IEnumerator ReassertAfterMenuClosed(int sceneToken)
		{
			yield return null;
			yield return new WaitForSeconds(0.5f);
			if (sceneToken != GraffitiMod.SceneToken)
			{
				yield break;
			}
			SurfaceDecals.ReassertAll();
			yield return new WaitForSeconds(2f);
			if (sceneToken != GraffitiMod.SceneToken)
			{
				yield break;
			}
			SurfaceDecals.ReassertAll();
		}

		// ---- Keeping the world in sync with the stored placements ----

		/// <summary>
		/// Makes the world match <see cref="StickerSaveManager.Placements"/>: applies missing or changed
		/// stickers and removes ones that are no longer listed (e.g. removed by the host).
		/// </summary>
		internal static void SyncWorldToPlacements(bool rebuild = false)
		{
			foreach (bool _ in SyncSteps(rebuild))
			{
			}
		}

		/// <summary>
		/// Same as <see cref="SyncWorldToPlacements"/>, but yields after each sticker so a coroutine can
		/// spread baking many high-resolution stickers over several frames instead of one long hitch.
		/// </summary>
		internal static IEnumerable<bool> SyncSteps(bool rebuild = false)
		{
			IReadOnlyList<StickerPlacement> placements = StickerSaveManager.Placements;
			DebugLog.Log("Restore", "Sync: " + placements.Count + " placements, " + StickerManager.Count + " stickers loaded");

			HashSet<string> wanted = new HashSet<string>(placements.Select(p => p.SurfaceGuid), StringComparer.OrdinalIgnoreCase);
			foreach (string key in SurfaceDecals.AppliedKeys)
			{
				if (!key.StartsWith("instance:") && !wanted.Contains(key))
				{
					SurfaceDecals.Remove(key, true);
				}
			}

			if (placements.Count == 0)
			{
				yield break;
			}
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}
			if (StickerManager.Count == 0)
			{
				DebugLog.Log("Restore", "No stickers loaded - cannot restore");
				yield break;
			}

			Dictionary<string, WorldSpraySurface> surfaces = FindWorldSurfaces();
			if (surfaces.Count == 0)
			{
				DebugLog.Log("Restore", "No WorldSpraySurfaces found in scene");
				yield break;
			}

			int applied = 0;
			foreach (StickerPlacement placement in placements.ToList())
			{
				if (!surfaces.TryGetValue(placement.SurfaceGuid, out WorldSpraySurface surface))
				{
					DebugLog.Log("Restore", "  Surface '" + placement.SurfaceGuid + "' not found in " + surfaces.Count + " surfaces");
					continue;
				}
				StickerData sticker = StickerManager.FindByFileName(placement.StickerFileName);
				if (sticker == null || sticker.Texture == null)
				{
					DebugLog.Log("Restore", "  Sticker '" + placement.StickerFileName + "' is not in the sticker folder");
					continue;
				}
				// Skip the yield when nothing was baked, so already-applied surfaces don't cost a frame each.
				bool baked = rebuild || !SurfaceDecals.IsApplied(placement.SurfaceGuid);
				try
				{
					if (SurfaceDecals.Apply(surface, placement.SurfaceGuid, sticker, rebuild))
					{
						applied++;
						_rewardedSurfaces.Add(placement.SurfaceGuid);
					}
				}
				catch (Exception ex)
				{
					DebugLog.Log("Restore", "  Restore error: " + ex.Message + "\n" + ex.StackTrace);
				}
				if (baked)
				{
					yield return true;
				}
			}
			DebugLog.Log("Restore", "Result: " + applied + "/" + placements.Count + " stickers shown");
		}

		/// <summary>Removes the sticker from a surface: stored placement, visual, and (if hosting) other players.</summary>
		internal static void RemovePlacement(string surfaceGuid, bool fromNetwork = false)
		{
			bool removedData = StickerSaveManager.RemovePlacement(surfaceGuid);
			bool removedVisual = SurfaceDecals.Remove(surfaceGuid, true);
			if (!removedVisual && removedData)
			{
				// The sticker wasn't showing (e.g. its PNG is missing), but the game may still hold the
				// surface as finished from an earlier session; release it so it can be sprayed again.
				if (FindWorldSurfaces().TryGetValue(surfaceGuid, out WorldSpraySurface surface))
				{
					SurfaceDecals.ResetGameSurface(surface);
				}
			}
			if (!removedData && !removedVisual)
			{
				return;
			}
			DebugLog.Log("Placer", "Removed sticker from " + surfaceGuid + (fromNetwork ? " (network)" : ""));
			if (!fromNetwork)
			{
				GraffitiSync.NotifyRemoval(surfaceGuid);
			}
			CustomUI.RequestRefresh();
		}

		internal static void RemoveAllPlacements()
		{
			foreach (StickerPlacement placement in StickerSaveManager.Placements.ToList())
			{
				RemovePlacement(placement.SurfaceGuid);
			}
		}

		private static Dictionary<string, WorldSpraySurface> FindWorldSurfaces()
		{
			Dictionary<string, WorldSpraySurface> result = new Dictionary<string, WorldSpraySurface>(StringComparer.OrdinalIgnoreCase);
			try
			{
				Il2CppArrayBase<WorldSpraySurface> found = Object.FindObjectsOfType<WorldSpraySurface>();
				if (found == null)
				{
					return result;
				}
				for (int i = 0; i < found.Count; i++)
				{
					WorldSpraySurface surface = found[i];
					if (surface == null)
					{
						continue;
					}
					string guid = GetGuid(surface);
					if (!string.IsNullOrEmpty(guid))
					{
						result[guid] = surface;
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Restore", "FindObjectsOfType<WorldSpraySurface> failed: " + ex.Message);
			}
			return result;
		}

		private static string GetGuid(WorldSpraySurface surface)
		{
			try
			{
				return surface.GUID.ToString() ?? "";
			}
			catch
			{
				return "";
			}
		}
	}
}
