using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HUB.Graffiti.Network;
using MelonLoader;
using ModHub.Core;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>The mod's page in the ModHub menu.</summary>
	internal static class CustomUI
	{
		private static readonly Color Danger = new Color(0.75f, 0.22f, 0.22f, 1f);
		private static readonly Color DangerText = new Color(0.8f, 0.3f, 0.3f, 1f);
		private static readonly Color Warning = new Color(0.9f, 0.65f, 0.2f, 1f);
		private static readonly int[] ResolutionSteps = { 1024, 2048, 4096 };

		private static Transform _contentParent;
		private static Font _font;
		private static bool _refreshRequested;

		/// <summary>Rebuild on the next frame. Never rebuild inside a button's own click handler.</summary>
		internal static void RequestRefresh()
		{
			_refreshRequested = true;
		}

		/// <summary>Called every frame from <see cref="GraffitiMod.OnUpdate"/>.</summary>
		internal static void Tick()
		{
			if (!_refreshRequested)
			{
				return;
			}
			_refreshRequested = false;
			RefreshUI();
		}

		internal static void RenderContent(Transform contentParent, Font font)
		{
			_contentParent = contentParent;
			_font = font;
			try
			{
				BuildUI(contentParent, font);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("[HUB - Graffiti] UI Error: " + ex.Message);
			}
		}

		private static void RefreshUI()
		{
			if (_contentParent == null || _font == null)
			{
				return;
			}
			for (int i = _contentParent.childCount - 1; i >= 0; i--)
			{
				Object.DestroyImmediate(_contentParent.GetChild(i).gameObject);
			}
			RenderContent(_contentParent, _font);
		}

		private static void BuildUI(Transform parent, Font font)
		{
			ModHubUI.InitSprites();
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}

			CreateSectionHeader(parent, "GRAFFITI", font, 15);
			ModHubUI.CreateSeparator(parent, 3f, ModHubUI.Purple);
			AddSpacer(parent, 8f);
			BuildEnableRow(parent, font);
			AddSpacer(parent, 6f);
			CreateInfoText(parent, "Equip spray can, interact with wall, click STICKER", font, 11, ModHubUI.TextMuted);

			AddSection(parent, "THIS SAVE", font);
			BuildSaveSection(parent, font);

			AddSection(parent, "STATS", font);
			BuildStatsCard(parent, font);

			AddSection(parent, "STICKER LIBRARY", font);
			BuildLibrary(parent, font);

			AddSection(parent, "STATUS", font);
			BuildStatus(parent, font);
			AddSpacer(parent, 10f);
		}

		private static void AddSection(Transform parent, string title, Font font)
		{
			AddSpacer(parent, 10f);
			ModHubUI.CreateSeparator(parent, 2f, null);
			AddSpacer(parent, 10f);
			CreateSectionHeader(parent, title, font, 13);
			AddSpacer(parent, 4f);
		}

		private static void BuildEnableRow(Transform parent, Font font)
		{
			GameObject row = ModHubUI.CreateCard("EnableRow", parent, 42f, ModHubUI.CardBg);
			PlaceLeftText(ModHubUI.CreateText("Enable Mod", row.transform, font, 14, FontStyle.Bold), 0.6f);
			bool enabled = GraffitiMod.EnableMod == null || GraffitiMod.EnableMod.Value;
			GameObject toggle = ModHubUI.CreateToggle(row.transform, font, enabled, 0.3f, v =>
			{
				if (GraffitiMod.EnableMod != null)
				{
					GraffitiMod.EnableMod.Value = v;
					MelonPreferences.Save();
				}
			}).Item1;
			toggle.GetComponent<RectTransform>().anchoredPosition = new Vector2(-14f, 0f);
		}

		// ---- THIS SAVE: which save is loaded, its placements, and delete buttons ----

		private static void BuildSaveSection(Transform parent, Font font)
		{
			IReadOnlyList<StickerPlacement> placements = StickerSaveManager.Placements;
			string saveLine;
			Color saveColor = ModHubUI.Green;
			switch (StickerSaveManager.Mode)
			{
				case StickerSaveManager.StorageMode.Save:
					saveLine = "Save: " + StickerSaveManager.SaveLabel;
					break;
				case StickerSaveManager.StorageMode.Client:
					saveLine = "Multiplayer - stickers are saved by the host";
					break;
				case StickerSaveManager.StorageMode.Unresolved:
					saveLine = "Save slot unknown - stickers won't be saved";
					saveColor = DangerText;
					break;
				default:
					saveLine = StickerSaveManager.IsLoaded ? "No save loaded" : "Load a save to manage its stickers";
					saveColor = ModHubUI.TextGray;
					break;
			}

			GameObject card = ModHubUI.CreateCard("SaveCard", parent, 52f, ModHubUI.CardBg);
			Text title = ModHubUI.CreateText(saveLine, card.transform, font, 12, FontStyle.Bold);
			title.color = saveColor;
			title.alignment = TextAnchor.MiddleLeft;
			SetAnchors(title.GetComponent<RectTransform>(), 0f, 0.5f, 1f, 1f, 14f, -14f);
			Text count = ModHubUI.CreateText(placements.Count + (placements.Count == 1 ? " sticker placed" : " stickers placed"), card.transform, font, 11, FontStyle.Normal);
			count.color = ModHubUI.TextGray;
			count.alignment = TextAnchor.MiddleLeft;
			SetAnchors(count.GetComponent<RectTransform>(), 0f, 0f, 1f, 0.5f, 14f, -14f);

			if (!string.IsNullOrEmpty(StickerSaveManager.ArchivedStaleFile))
			{
				AddSpacer(parent, 4f);
				CreateInfoText(parent, "Old stickers from an earlier game in this slot were archived", font, 10, Warning);
			}

			BuildLegacyImport(parent, font);

			if (placements.Count > 0)
			{
				AddSpacer(parent, 6f);
				foreach (StickerPlacement placement in placements.ToList())
				{
					BuildPlacementRow(parent, font, placement);
					AddSpacer(parent, 4f);
				}
				AddSpacer(parent, 2f);
				GameObject removeAllRow = ModHubUI.CreateCard("RemoveAllRow", parent, 42f, ModHubUI.CardBg);
				AddConfirmButton(removeAllRow.transform, font, "Remove All Stickers In This Save", 0.08f, 0.92f, GraffitiPlacer.RemoveAllPlacements);
			}
		}

		private static void BuildPlacementRow(Transform parent, Font font, StickerPlacement placement)
		{
			GameObject card = ModHubUI.CreateCard("Placement_" + placement.SurfaceGuid, parent, 48f, ModHubUI.CardBg);

			StickerData sticker = StickerManager.FindByFileName(placement.StickerFileName);
			GameObject thumb = new GameObject("Thumb");
			thumb.transform.SetParent(card.transform, false);
			RectTransform thumbRect = thumb.AddComponent<RectTransform>();
			thumbRect.anchorMin = new Vector2(0f, 0.5f);
			thumbRect.anchorMax = new Vector2(0f, 0.5f);
			thumbRect.pivot = new Vector2(0f, 0.5f);
			thumbRect.sizeDelta = new Vector2(38f, 38f);
			thumbRect.anchoredPosition = new Vector2(8f, 0f);
			Image thumbImage = thumb.AddComponent<Image>();
			thumbImage.raycastTarget = false;
			if (sticker != null && sticker.Sprite != null)
			{
				thumbImage.sprite = sticker.Sprite;
				thumbImage.preserveAspect = true;
			}
			else
			{
				thumbImage.color = new Color(0.4f, 0.2f, 0.6f, 0.4f);
			}

			Text name = ModHubUI.CreateText(placement.StickerFileName + (sticker == null ? " (missing PNG)" : ""), card.transform, font, 12, FontStyle.Bold);
			name.color = sticker == null ? Warning : Color.white;
			name.alignment = TextAnchor.MiddleLeft;
			name.horizontalOverflow = HorizontalWrapMode.Wrap;
			SetAnchors(name.GetComponent<RectTransform>(), 0f, 0.5f, 0.66f, 1f, 54f, 0f);

			bool isVehicle = SurfaceKeys.IsVehicleKey(placement.SurfaceGuid);
			string location = SurfaceDecals.GetLocation(placement.SurfaceGuid);
			if (string.IsNullOrEmpty(location))
			{
				location = isVehicle ? "Vehicle" : "";
			}
			if (GraffitiPlacer.IsSurfaceMissing(placement.SurfaceGuid))
			{
				location += isVehicle ? " (not in world - sold or not spawned yet)" : " (surface not found)";
			}
			// Show the start of the GUID (the vehicle's GUID for vehicle panels) to tell entries apart.
			string id = isVehicle ? placement.SurfaceGuid.Substring("vehicle:".Length) : placement.SurfaceGuid;
			id = id.Length > 8 ? id.Substring(0, 8) : id;
			Text detail = ModHubUI.CreateText((string.IsNullOrEmpty(location) ? "" : location.Trim() + "  |  ") + "#" + id, card.transform, font, 10, FontStyle.Normal);
			detail.color = ModHubUI.TextMuted;
			detail.alignment = TextAnchor.MiddleLeft;
			SetAnchors(detail.GetComponent<RectTransform>(), 0f, 0f, 0.66f, 0.5f, 54f, 0f);

			string surfaceGuid = placement.SurfaceGuid;
			AddConfirmButton(card.transform, font, "Remove", 0.68f, 0.96f, () => GraffitiPlacer.RemovePlacement(surfaceGuid));
		}

		private static void BuildLegacyImport(Transform parent, Font font)
		{
			if (!StickerSaveManager.CanPersist)
			{
				return;
			}
			int legacyCount = StickerSaveManager.LegacyPlacementCount;
			if (legacyCount == 0)
			{
				return;
			}
			AddSpacer(parent, 6f);
			CreateInfoText(parent, "Found " + legacyCount + " stickers saved by v1.2 (shared by all saves)", font, 11, Warning);
			GameObject row = ModHubUI.CreateCard("LegacyRow", parent, 42f, ModHubUI.CardBg);
			(GameObject importGo, Button importButton, Text _) = ModHubUI.CreateButton("Import Into This Save", row.transform, font, 12, ModHubUI.Purple);
			SetAnchors(importGo.GetComponent<RectTransform>(), 0.04f, 0.12f, 0.6f, 0.88f, 0f, 0f);
			importButton.onClick.AddListener(new Action(() =>
			{
				StickerSaveManager.ImportLegacy();
				GraffitiPlacer.SyncWorldToPlacements();
				GraffitiSync.NotifyStateChanged();
				RequestRefresh();
			}));
			AddConfirmButton(row.transform, font, "Discard", 0.64f, 0.96f, () =>
			{
				StickerSaveManager.DismissLegacy();
				RequestRefresh();
			});
		}

		/// <summary>A red button that needs two clicks: the first arms it, the second runs <paramref name="action"/>.</summary>
		private static void AddConfirmButton(Transform parent, Font font, string label, float xMin, float xMax, Action action)
		{
			(GameObject go, Button button, Text text) = ModHubUI.CreateButton(label, parent, font, 12, Danger);
			SetAnchors(go.GetComponent<RectTransform>(), xMin, 0.12f, xMax, 0.88f, 0f, 0f);
			bool armed = false;
			button.onClick.AddListener(new Action(() =>
			{
				if (!armed)
				{
					armed = true;
					if (text != null)
					{
						text.text = "Click again to confirm";
					}
					return;
				}
				try
				{
					action();
				}
				catch (Exception ex)
				{
					MelonLogger.Error("[HUB - Graffiti] " + label + " failed: " + ex.Message);
				}
				RequestRefresh();
			}));
		}

		// ---- STATS ----

		private static void BuildStatsCard(Transform parent, Font font)
		{
			int tagged = GraffitiMod.SpotsTagged != null ? GraffitiMod.SpotsTagged.Value : 0;
			GameObject card = ModHubUI.CreateCard("StatsCard", parent, 68f, ModHubUI.CardBg);
			AddStatRow(card.transform, font, "Spots Tagged (all saves)", tagged.ToString(), ModHubUI.Purple, 0.55f, 1f);
			AddStatRow(card.transform, font, "Stickers Loaded", StickerManager.Count.ToString(), ModHubUI.Green, 0f, 0.45f);
		}

		private static void AddStatRow(Transform card, Font font, string label, string value, Color valueColor, float yMin, float yMax)
		{
			Text labelText = ModHubUI.CreateText(label, card, font, 12, FontStyle.Normal);
			labelText.color = ModHubUI.TextGray;
			SetAnchors(labelText.GetComponent<RectTransform>(), 0f, yMin, 0.6f, yMax, 14f, 0f);
			Text valueText = ModHubUI.CreateText(value, card, font, 14, FontStyle.Bold);
			valueText.color = valueColor;
			valueText.alignment = TextAnchor.MiddleRight;
			SetAnchors(valueText.GetComponent<RectTransform>(), 0.6f, yMin, 1f, yMax, 0f, -14f);
		}

		// ---- STICKER LIBRARY ----

		private static void BuildLibrary(Transform parent, Font font)
		{
			if (StickerManager.Count == 0)
			{
				CreateInfoText(parent, "No stickers loaded.", font, 13, null);
				CreateInfoText(parent, "Add PNG files to UserData/HUB_Graffiti/", font, 11, ModHubUI.TextMuted);
			}
			else
			{
				const float cell = 80f;
				const float gap = 6f;
				int columns = GridColumns(parent, cell, gap);
				int rows = (int)Math.Ceiling(StickerManager.Count / (double)columns);
				GameObject gridCard = ModHubUI.CreateCard("StickerGrid", parent, rows * (cell + gap) + gap, new Color(0.1f, 0.1f, 0.14f, 1f));
				GameObject gridContent = new GameObject("GridContent");
				gridContent.transform.SetParent(gridCard.transform, false);
				RectTransform gridRect = gridContent.AddComponent<RectTransform>();
				gridRect.anchorMin = Vector2.zero;
				gridRect.anchorMax = Vector2.one;
				gridRect.offsetMin = new Vector2(gap, gap);
				gridRect.offsetMax = new Vector2(-gap, -gap);
				GridLayoutGroup grid = gridContent.AddComponent<GridLayoutGroup>();
				grid.cellSize = new Vector2(cell, cell);
				grid.spacing = new Vector2(gap, gap);
				grid.childAlignment = TextAnchor.UpperCenter;
				grid.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
				grid.constraintCount = columns;
				foreach (StickerData sticker in StickerManager.Stickers)
				{
					CreateStickerPreview(gridContent.transform, font, sticker);
				}
			}

			AddSpacer(parent, 10f);
			GameObject reloadRow = ModHubUI.CreateCard("ReloadRow", parent, 42f, ModHubUI.CardBg);
			(GameObject reloadGo, Button reloadButton, Text _) = ModHubUI.CreateButton("Reload Stickers", reloadRow.transform, font, 13, ModHubUI.Purple);
			SetAnchors(reloadGo.GetComponent<RectTransform>(), 0.15f, 0.12f, 0.85f, 0.88f, 0f, 0f);
			reloadButton.onClick.AddListener(new Action(() =>
			{
				StickerPickerUI.Close();
				StickerManager.Reload();
				GraffitiPlacer.SyncWorldToPlacements();
				RequestRefresh();
				MelonLogger.Msg("[HUB - Graffiti] Reloaded " + StickerManager.Count + " stickers");
			}));

			AddSpacer(parent, 6f);
			GameObject resolutionRow = ModHubUI.CreateCard("ResolutionRow", parent, 42f, ModHubUI.CardBg);
			Text resolutionLabel = ModHubUI.CreateText("Sticker Resolution", resolutionRow.transform, font, 12, FontStyle.Normal);
			resolutionLabel.color = ModHubUI.TextGray;
			SetAnchors(resolutionLabel.GetComponent<RectTransform>(), 0f, 0f, 0.55f, 1f, 14f, 0f);
			(GameObject resGo, Button resButton, Text _) = ModHubUI.CreateButton(GraffitiMod.MaxStickerResolution + " px", resolutionRow.transform, font, 12, ModHubUI.Purple);
			SetAnchors(resGo.GetComponent<RectTransform>(), 0.58f, 0.12f, 0.95f, 0.88f, 0f, 0f);
			resButton.onClick.AddListener(new Action(() =>
			{
				int current = GraffitiMod.MaxStickerResolution;
				int next = ResolutionSteps.FirstOrDefault(step => step > current);
				GraffitiMod.StickerResolution.Value = next == 0 ? ResolutionSteps[0] : next;
				MelonPreferences.Save();
				GraffitiPlacer.SyncWorldToPlacements(true);
				RequestRefresh();
			}));
			AddSpacer(parent, 4f);
			CreateInfoText(parent, "Drop custom PNGs into UserData/HUB_Graffiti/ (higher res = sharper)", font, 10, ModHubUI.TextMuted);
		}

		/// <summary>
		/// As many cells as fit across the menu, so the library doesn't turn into a long 3-wide strip on a wide
		/// panel. The card height is computed up front from the row count, so this must be decided at build time.
		/// </summary>
		private static int GridColumns(Transform parent, float cell, float gap)
		{
			const int fallbackColumns = 8;
			const float cardInset = 24f; // card padding plus the grid's own gap margins
			float width = 0f;
			try
			{
				RectTransform rect = parent.GetComponent<RectTransform>();
				width = rect != null ? rect.rect.width : 0f;
			}
			catch
			{
			}
			if (width <= cell)
			{
				return fallbackColumns;
			}
			int fit = (int)((width - cardInset + gap) / (cell + gap));
			return Math.Max(3, Math.Min(fit, 16));
		}

		private static void CreateStickerPreview(Transform parent, Font font, StickerData sticker)
		{
			GameObject cell = new GameObject("Preview_" + sticker.Name);
			cell.transform.SetParent(parent, false);
			Image background = cell.AddComponent<Image>();
			background.color = new Color(0.18f, 0.18f, 0.24f, 1f);
			if (ModHubUI.CardSprite != null)
			{
				background.sprite = ModHubUI.CardSprite;
				background.type = Image.Type.Sliced;
			}

			GameObject imageGo = new GameObject("Image");
			imageGo.transform.SetParent(cell.transform, false);
			RectTransform imageRect = imageGo.AddComponent<RectTransform>();
			imageRect.anchorMin = new Vector2(0.1f, 0.3f);
			imageRect.anchorMax = new Vector2(0.9f, 0.95f);
			imageRect.offsetMin = Vector2.zero;
			imageRect.offsetMax = Vector2.zero;
			Image image = imageGo.AddComponent<Image>();
			if (sticker.Sprite != null)
			{
				image.sprite = sticker.Sprite;
				image.preserveAspect = true;
			}

			GameObject labelGo = new GameObject("Label");
			labelGo.transform.SetParent(cell.transform, false);
			RectTransform labelRect = labelGo.AddComponent<RectTransform>();
			labelRect.anchorMin = new Vector2(0f, 0f);
			labelRect.anchorMax = new Vector2(1f, 0.28f);
			labelRect.offsetMin = new Vector2(2f, 0f);
			labelRect.offsetMax = new Vector2(-2f, 0f);
			Text label = labelGo.AddComponent<Text>();
			label.text = sticker.Name;
			label.font = font;
			label.fontSize = 8;
			label.alignment = TextAnchor.MiddleCenter;
			label.color = ModHubUI.TextGray;
			label.horizontalOverflow = HorizontalWrapMode.Wrap;
		}

		// ---- STATUS ----

		private static void BuildStatus(Transform parent, Font font)
		{
			GameObject card = ModHubUI.CreateCard("StatusCard", parent, 54f, ModHubUI.CardBg);
			bool active = GraffitiMod.EnableMod != null && GraffitiMod.EnableMod.Value;
			Text mod = ModHubUI.CreateText("Mod: " + (active ? "Active" : "Inactive"), card.transform, font, 12, FontStyle.Bold);
			mod.color = active ? ModHubUI.Green : DangerText;
			mod.alignment = TextAnchor.MiddleLeft;
			SetAnchors(mod.GetComponent<RectTransform>(), 0f, 0.5f, 1f, 1f, 14f, -14f);
			string syncText = GraffitiSync.IsRunning ? "Multiplayer sync: on (" + (NetworkHelper.IsHost ? "host" : "client") + ")" : "Multiplayer sync: off";
			Text sync = ModHubUI.CreateText(syncText, card.transform, font, 12, FontStyle.Normal);
			sync.color = ModHubUI.TextGray;
			sync.alignment = TextAnchor.MiddleLeft;
			SetAnchors(sync.GetComponent<RectTransform>(), 0f, 0f, 1f, 0.5f, 14f, -14f);

			AddSpacer(parent, 8f);
			GameObject logRow = ModHubUI.CreateCard("LogRow", parent, 42f, ModHubUI.CardBg);
			(GameObject logGo, Button logButton, Text _) = ModHubUI.CreateButton("Open Log Folder (Bug Reports)", logRow.transform, font, 13, ModHubUI.Purple);
			SetAnchors(logGo.GetComponent<RectTransform>(), 0.08f, 0.12f, 0.92f, 0.88f, 0f, 0f);
			logButton.onClick.AddListener(new Action(() =>
			{
				try
				{
					DebugLog.Flush();
					Process.Start("explorer.exe", "\"" + DebugLog.LogFolder + "\"");
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[HUB - Graffiti] Could not open log folder: " + ex.Message);
				}
			}));
		}

		// ---- helpers ----

		private static void PlaceLeftText(Text text, float xMax)
		{
			SetAnchors(text.GetComponent<RectTransform>(), 0f, 0f, xMax, 1f, 14f, 0f);
		}

		private static void SetAnchors(RectTransform rect, float xMin, float yMin, float xMax, float yMax, float left, float right)
		{
			rect.anchorMin = new Vector2(xMin, yMin);
			rect.anchorMax = new Vector2(xMax, yMax);
			rect.offsetMin = new Vector2(left, 0f);
			rect.offsetMax = new Vector2(right, 0f);
		}

		private static void CreateSectionHeader(Transform parent, string title, Font font, int fontSize = 15)
		{
			GameObject card = ModHubUI.CreateCard("Header_" + title, parent, 32f, new Color(0.12f, 0.12f, 0.16f, 0.8f));
			Text text = ModHubUI.CreateText(title, card.transform, font, fontSize, FontStyle.Bold);
			text.color = ModHubUI.Purple;
			text.alignment = TextAnchor.MiddleLeft;
			text.GetComponent<RectTransform>().offsetMin = new Vector2(12f, 0f);
		}

		private static void CreateInfoText(Transform parent, string text, Font font, int fontSize = 13, Color? color = null)
		{
			GameObject card = ModHubUI.CreateCard("Info", parent, 30f, new Color(0.12f, 0.12f, 0.16f, 0.5f));
			Text label = ModHubUI.CreateText(text, card.transform, font, fontSize, FontStyle.Normal);
			label.color = color ?? ModHubUI.TextGray;
			label.alignment = TextAnchor.MiddleCenter;
		}

		private static void AddSpacer(Transform parent, float height)
		{
			GameObject spacer = new GameObject("Spacer");
			spacer.transform.SetParent(parent, false);
			spacer.AddComponent<RectTransform>();
			LayoutElement element = spacer.AddComponent<LayoutElement>();
			element.minHeight = height;
			element.preferredHeight = height;
		}
	}
}
