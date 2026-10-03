using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HUB.Graffiti.Network;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Graffiti;
using Il2CppScheduleOne.UI;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace HUB.Graffiti
{
	// Token: 0x02000009 RID: 9
	[NullableContext(1)]
	[Nullable(0)]
	internal static class GraffitiPlacer
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003234 File Offset: 0x00001434
		internal static void Update()
		{
			if (!GraffitiPlacer._sceneReady)
			{
				return;
			}
			if (GraffitiPlacer._cachedMenu == null)
			{
				try
				{
					GraffitiPlacer._cachedMenu = Singleton<GraffitiMenu>.Instance;
				}
				catch
				{
					return;
				}
				if (GraffitiPlacer._cachedMenu == null)
				{
					return;
				}
			}
			if (GraffitiPlacer._cachedCanvas == null)
			{
				try
				{
					GraffitiPlacer._cachedCanvas = GraffitiPlacer._cachedMenu.Canvas;
				}
				catch
				{
					GraffitiPlacer._cachedMenu = null;
					return;
				}
				if (GraffitiPlacer._cachedCanvas == null)
				{
					return;
				}
			}
			bool enabled;
			try
			{
				enabled = GraffitiPlacer._cachedCanvas.enabled;
			}
			catch
			{
				GraffitiPlacer._cachedMenu = null;
				GraffitiPlacer._cachedCanvas = null;
				return;
			}
			if (enabled && !GraffitiPlacer._wasMenuOpen)
			{
				GraffitiPlacer._wasMenuOpen = true;
				GraffitiPlacer.InjectButton(GraffitiPlacer._cachedMenu);
				return;
			}
			if (!enabled && GraffitiPlacer._wasMenuOpen)
			{
				GraffitiPlacer._wasMenuOpen = false;
				GraffitiPlacer._savedSurface = null;
				GraffitiPlacer.CleanupButton();
				return;
			}
			if (enabled && GraffitiPlacer._stickerButton == null)
			{
				GraffitiPlacer.InjectButton(GraffitiPlacer._cachedMenu);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003344 File Offset: 0x00001544
		internal static void OnSceneLoaded(string sceneName)
		{
			GraffitiPlacer._sceneReady = (sceneName == "Main");
			GraffitiPlacer._cachedMenu = null;
			GraffitiPlacer._cachedCanvas = null;
			GraffitiPlacer.CleanupButton();
			GraffitiPlacer._wasMenuOpen = false;
			GraffitiPlacer._savedSurface = null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003374 File Offset: 0x00001574
		private static void CleanupButton()
		{
			if (GraffitiPlacer._stickerButton != null)
			{
				try
				{
					Object.Destroy(GraffitiPlacer._stickerButton);
				}
				catch
				{
				}
				GraffitiPlacer._stickerButton = null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033B4 File Offset: 0x000015B4
		private static void InjectButton(GraffitiMenu menu)
		{
			if (GraffitiPlacer._stickerButton != null)
			{
				return;
			}
			try
			{
				Button doneButton = menu.DoneButton;
				if (!(doneButton == null))
				{
					GameObject gameObject = doneButton.gameObject;
					Transform parent = gameObject.transform.parent;
					RectTransform component = gameObject.GetComponent<RectTransform>();
					GraffitiPlacer._stickerButton = new GameObject("HUB_StickerButton");
					GraffitiPlacer._stickerButton.transform.SetParent(parent, false);
					RectTransform rectTransform = GraffitiPlacer._stickerButton.AddComponent<RectTransform>();
					if (component != null)
					{
						rectTransform.anchorMin = component.anchorMin;
						rectTransform.anchorMax = component.anchorMax;
						rectTransform.pivot = component.pivot;
						rectTransform.sizeDelta = component.sizeDelta;
						Vector2 anchoredPosition = component.anchoredPosition;
						rectTransform.anchoredPosition = new Vector2(anchoredPosition.x, anchoredPosition.y + component.sizeDelta.y + 10f);
					}
					GraffitiPlacer._stickerButton.AddComponent<LayoutElement>().ignoreLayout = true;
					Image image = GraffitiPlacer._stickerButton.AddComponent<Image>();
					image.color = new Color(0.55f, 0.25f, 0.7f, 1f);
					image.raycastTarget = true;
					Button button = GraffitiPlacer._stickerButton.AddComponent<Button>();
					button.interactable = true;
					button.targetGraphic = image;
					ColorBlock colors = button.colors;
					colors.normalColor = new Color(0.55f, 0.25f, 0.7f, 1f);
					colors.highlightedColor = new Color(0.65f, 0.35f, 0.8f, 1f);
					colors.pressedColor = new Color(0.45f, 0.15f, 0.6f, 1f);
					colors.disabledColor = new Color(0.3f, 0.3f, 0.3f, 1f);
					button.colors = colors;
					UnityEvent onClick = button.onClick;
					Action action;
					if ((action = GraffitiPlacer.<>O.<0>__OnStickerButtonClicked) == null)
					{
						action = (GraffitiPlacer.<>O.<0>__OnStickerButtonClicked = new Action(GraffitiPlacer.OnStickerButtonClicked));
					}
					onClick.AddListener(action);
					try
					{
						TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>();
						if (componentInChildren != null)
						{
							GameObject gameObject2 = Object.Instantiate<GameObject>(componentInChildren.gameObject, GraffitiPlacer._stickerButton.transform);
							gameObject2.name = "Text";
							TextMeshProUGUI component2 = gameObject2.GetComponent<TextMeshProUGUI>();
							if (component2 != null)
							{
								component2.text = "STICKER";
								component2.raycastTarget = false;
							}
						}
						else
						{
							GameObject gameObject3 = new GameObject("Text");
							gameObject3.transform.SetParent(GraffitiPlacer._stickerButton.transform, false);
							RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
							rectTransform2.anchorMin = Vector2.zero;
							rectTransform2.anchorMax = Vector2.one;
							rectTransform2.offsetMin = Vector2.zero;
							rectTransform2.offsetMax = Vector2.zero;
							Text text = gameObject3.AddComponent<Text>();
							text.text = "STICKER";
							text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
							text.fontSize = 14;
							text.fontStyle = 1;
							text.alignment = 4;
							text.color = Color.white;
							text.raycastTarget = false;
						}
					}
					catch (Exception ex)
					{
						DebugLog.Log("Placer", "Button text error: " + ex.Message);
					}
					GraffitiPlacer._stickerButton.SetActive(true);
					DebugLog.Log("Placer", "STICKER button injected");
				}
			}
			catch (Exception ex2)
			{
				DebugLog.Log("Placer", "InjectButton error: " + ex2.Message);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000373C File Offset: 0x0000193C
		private static void OnStickerButtonClicked()
		{
			DebugLog.Log("Placer", "STICKER button clicked");
			try
			{
				GraffitiMenu cachedMenu = GraffitiPlacer._cachedMenu;
				GraffitiPlacer._savedSurface = ((cachedMenu != null) ? cachedMenu.activeSurface : null);
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
			Action<int> onSelected;
			if ((onSelected = GraffitiPlacer.<>O.<1>__OnStickerSelected) == null)
			{
				onSelected = (GraffitiPlacer.<>O.<1>__OnStickerSelected = new Action<int>(GraffitiPlacer.OnStickerSelected));
			}
			StickerPickerUI.Open(onSelected);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000037DC File Offset: 0x000019DC
		private static void OnStickerSelected(int stickerIndex)
		{
			string category = "Placer";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Sticker selected: index=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(stickerIndex);
			DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
			try
			{
				StickerData sticker = StickerManager.GetSticker(stickerIndex);
				if (((sticker != null) ? sticker.Texture : null) == null)
				{
					DebugLog.Log("Placer", "Sticker or texture null, aborting");
				}
				else
				{
					SpraySurface spraySurface;
					if ((spraySurface = GraffitiPlacer._savedSurface) == null)
					{
						GraffitiMenu cachedMenu = GraffitiPlacer._cachedMenu;
						spraySurface = ((cachedMenu != null) ? cachedMenu.activeSurface : null);
					}
					SpraySurface spraySurface2 = spraySurface;
					if (spraySurface2 == null)
					{
						MelonLogger.Error("[HUB - Graffiti] No spray surface found!");
					}
					else
					{
						Texture2D drawTex = GraffitiPlacer.CreateDrawingTexture(spraySurface2, sticker.Texture);
						GraffitiPlacer.SetGameState(spraySurface2, drawTex);
						try
						{
							spraySurface2.OnEditingFinished();
						}
						catch (Exception ex)
						{
							DebugLog.Log("Placer", "OnEditingFinished error: " + ex.Message);
						}
						WorldSpraySurface worldSpraySurface = spraySurface2.TryCast<WorldSpraySurface>();
						if (worldSpraySurface != null)
						{
							string text = "";
							try
							{
								text = (worldSpraySurface.GUID.ToString() ?? "");
							}
							catch
							{
							}
							bool flag = !string.IsNullOrEmpty(text) && GraffitiPlacer._stickeredSurfaces.Contains(text);
							try
							{
								worldSpraySurface._HasEverBeenMarkedByPlayer_k__BackingField = true;
							}
							catch
							{
							}
							try
							{
								worldSpraySurface.SetFinalized();
							}
							catch (Exception ex2)
							{
								DebugLog.Log("Placer", "SetFinalized error: " + ex2.Message);
							}
							try
							{
								worldSpraySurface.RpcLogic___SetFinalized_2166136261();
							}
							catch (Exception ex3)
							{
								DebugLog.Log("Placer", "RpcLogic error: " + ex3.Message);
							}
							try
							{
								worldSpraySurface.MarkDrawingFinalized();
							}
							catch (Exception ex4)
							{
								DebugLog.Log("Placer", "MarkDrawingFinalized error: " + ex4.Message);
							}
							if (!flag)
							{
								try
								{
									worldSpraySurface.Reward();
								}
								catch (Exception ex5)
								{
									DebugLog.Log("Placer", "Reward error: " + ex5.Message);
								}
								if (!string.IsNullOrEmpty(text))
								{
									GraffitiPlacer._stickeredSurfaces.Add(text);
								}
							}
							try
							{
								spraySurface2.Editable = false;
							}
							catch
							{
							}
							GraffitiPlacer.HideSurfaceOutline(worldSpraySurface);
							if (!string.IsNullOrEmpty(text))
							{
								StickerSaveManager.RecordPlacement(text, sticker.Name);
								GraffitiSync.NotifyPlacement(text, sticker.Name);
							}
						}
						GraffitiPlacer.ReapplySticker(spraySurface2, drawTex);
						try
						{
							Drawing drawing = spraySurface2.drawing;
							if (drawing != null)
							{
								drawing._PaintedPixelCount_k__BackingField = 5000;
								drawing.PaintedPixelCount = 5000;
							}
							spraySurface2.DrawingPaintedPixelCount = 5000;
						}
						catch
						{
						}
						try
						{
							GraffitiMenu graffitiMenu = GraffitiPlacer._cachedMenu ?? Singleton<GraffitiMenu>.Instance;
							if (graffitiMenu != null)
							{
								try
								{
									graffitiMenu.CancelClicked();
								}
								catch
								{
									try
									{
										graffitiMenu.Close();
									}
									catch
									{
									}
								}
								try
								{
									graffitiMenu.ClearActiveSurface();
								}
								catch
								{
								}
							}
						}
						catch (Exception ex6)
						{
							DebugLog.Log("Placer", "Menu exit error: " + ex6.Message);
						}
						try
						{
							if (worldSpraySurface != null)
							{
								worldSpraySurface.Region.ToString();
							}
						}
						catch
						{
						}
						if (GraffitiMod.SpotsTagged != null)
						{
							MelonPreferences_Entry<int> spotsTagged = GraffitiMod.SpotsTagged;
							int value = spotsTagged.Value;
							spotsTagged.Value = value + 1;
							MelonPreferences.Save();
						}
						CustomUI.RefreshUI();
					}
				}
			}
			catch (Exception ex7)
			{
				DebugLog.Log("Placer", "OnStickerSelected error: " + ex7.Message + "\n" + ex7.StackTrace);
				MelonLogger.Error("[HUB - Graffiti] Apply error: " + ex7.Message);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003CA4 File Offset: 0x00001EA4
		private static Texture2D CreateDrawingTexture(SpraySurface surface, Texture2D stickerTex)
		{
			int num = 512;
			int num2 = 512;
			try
			{
				surface.EnsureDrawingExists();
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					if (drawing.TextureWidth > 0)
					{
						num = drawing.TextureWidth;
					}
					if (drawing.TextureHeight > 0)
					{
						num2 = drawing.TextureHeight;
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "Drawing size error: " + ex.Message);
			}
			Texture2D texture2D = new Texture2D(num, num2, 4, false);
			texture2D.name = "HUB_StickerDrawing";
			texture2D.filterMode = 1;
			texture2D.wrapMode = 1;
			Color32[] array = new Color32[num * num2];
			texture2D.SetPixels32(array);
			float num3 = 0.5f;
			float num4 = 0.5f;
			float num5 = 0.5f;
			float num6 = 0.5f;
			try
			{
				DecalProjector projector = surface.Projector;
				Transform bottomLeftPoint = surface.BottomLeftPoint;
				if (projector != null && bottomLeftPoint != null)
				{
					Vector3 size = projector.size;
					float pixel_SIZE = SpraySurface.PIXEL_SIZE;
					float num7 = (float)surface.Width * pixel_SIZE;
					float num8 = (float)surface.Height * pixel_SIZE;
					Vector3 vector = projector.transform.InverseTransformPoint(bottomLeftPoint.position);
					float num9 = vector.x / size.x + 0.5f;
					float num10 = vector.y / size.y + 0.5f;
					num5 = num7 / size.x;
					num6 = num8 / size.y;
					num3 = num9 + num5 * 0.5f;
					num4 = num10 + num6 * 0.5f;
					string category = "Placer";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 6);
					defaultInterpolatedStringHandler.AppendLiteral("Geometry: projSize=(");
					defaultInterpolatedStringHandler.AppendFormatted<float>(size.x, "F2");
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<float>(size.y, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("), surfWorld=(");
					defaultInterpolatedStringHandler.AppendFormatted<float>(num7, "F2");
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<float>(num8, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("), centerUV=(");
					defaultInterpolatedStringHandler.AppendFormatted<float>(num3, "F3");
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<float>(num4, "F3");
					defaultInterpolatedStringHandler.AppendLiteral(")");
					DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex2)
			{
				DebugLog.Log("Placer", "Geometry calc error: " + ex2.Message);
			}
			float num11 = (float)Math.Max(1, (int)(num5 * (float)num * 0.8f));
			int num12 = Math.Max(1, (int)(num6 * (float)num2 * 0.8f));
			float num13 = Math.Min(num11 / (float)stickerTex.width, (float)num12 / (float)stickerTex.height);
			int num14 = Math.Max(1, (int)((float)stickerTex.width * num13));
			int num15 = Math.Max(1, (int)((float)stickerTex.height * num13));
			int num16 = (int)(num3 * (float)num) - num14 / 2;
			int num17 = (int)(num4 * (float)num2) - num15 / 2;
			int num18 = Math.Max(0, num16);
			int num19 = Math.Max(0, num17);
			int num20 = Math.Min(num, num16 + num14);
			int num21 = Math.Min(num2, num17 + num15);
			Color[] array2 = stickerTex.GetPixels();
			int width = stickerTex.width;
			int height = stickerTex.height;
			Color32[] array3 = texture2D.GetPixels32();
			float num22 = 1f / (float)num14;
			float num23 = 1f / (float)num15;
			for (int i = num19; i < num21; i++)
			{
				int num24 = (int)((float)(i - num17) * num23 * (float)height);
				if (num24 >= height)
				{
					num24 = height - 1;
				}
				int num25 = num24 * width;
				int num26 = i * num;
				for (int j = num18; j < num20; j++)
				{
					int num27 = (int)((float)(j - num16) * num22 * (float)width);
					if (num27 >= width)
					{
						num27 = width - 1;
					}
					Color color = array2[num25 + num27];
					if (color.a >= 0.01f)
					{
						array3[num26 + j] = new Color32((byte)(color.r * 255f), (byte)(color.g * 255f), (byte)(color.b * 255f), (byte)(color.a * 255f));
					}
				}
			}
			texture2D.SetPixels32(array3);
			texture2D.Apply();
			GraffitiPlacer._lastStickerTex = texture2D;
			return texture2D;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004128 File Offset: 0x00002328
		private static void SetGameState(SpraySurface surface, Texture2D drawTex)
		{
			try
			{
				surface.EnsureDrawingExists();
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					try
					{
						drawing.OutputTexture = drawTex;
					}
					catch
					{
					}
					try
					{
						drawing._OutputTexture_k__BackingField = drawTex;
					}
					catch
					{
					}
					try
					{
						drawing.PaintedPixelCount = 5000;
					}
					catch
					{
					}
					try
					{
						drawing._PaintedPixelCount_k__BackingField = 5000;
					}
					catch
					{
					}
				}
				try
				{
					surface.DrawingPaintedPixelCount = 5000;
				}
				catch
				{
				}
				if (drawing != null)
				{
					try
					{
						UShort2 @ushort = default(UShort2);
						@ushort.X = 100;
						@ushort.Y = 100;
						UShort2 ushort2 = default(UShort2);
						ushort2.X = 101;
						ushort2.Y = 101;
						SprayStroke sprayStroke = new SprayStroke(@ushort, ushort2, 1, 1);
						drawing.AddStroke(sprayStroke);
					}
					catch (Exception ex)
					{
						DebugLog.Log("Placer", "Fake stroke error: " + ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				DebugLog.Log("Placer", "SetGameState error: " + ex2.Message);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004274 File Offset: 0x00002474
		private static void ReapplySticker(SpraySurface surface, Texture2D drawTex)
		{
			try
			{
				try
				{
					surface.EnsureDrawingExists();
					Drawing drawing = surface.drawing;
					if (drawing != null)
					{
						try
						{
							drawing.OutputTexture = drawTex;
						}
						catch
						{
						}
						try
						{
							drawing._OutputTexture_k__BackingField = drawTex;
						}
						catch
						{
						}
						try
						{
							drawing.PaintedPixelCount = 5000;
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
					surface.DrawingPaintedPixelCount = 5000;
				}
				catch
				{
				}
				DecalProjector projector = surface.Projector;
				if (projector == null)
				{
					DebugLog.Log("Placer", "ReapplySticker: Projector is NULL");
				}
				else
				{
					projector.enabled = true;
					Material material = projector.material;
					Material material2 = new Material(material);
					material2.name = "HUB_StickerDecal";
					material2.SetTexture("_Base_Map", drawTex);
					material2.mainTexture = drawTex;
					Shader shader = material.shader;
					if (shader != null)
					{
						try
						{
							int propertyCount = shader.GetPropertyCount();
							for (int i = 0; i < propertyCount; i++)
							{
								try
								{
									if (shader.GetPropertyType(i) == 4)
									{
										string propertyName = shader.GetPropertyName(i);
										if (!propertyName.StartsWith("unity_") && !(propertyName == "_Normal_Map"))
										{
											material2.SetTexture(propertyName, drawTex);
										}
									}
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
					projector.material = material2;
					projector.enabled = false;
					projector.enabled = true;
					try
					{
						surface.CacheDrawing();
					}
					catch
					{
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "ReapplySticker error: " + ex.Message);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000044B8 File Offset: 0x000026B8
		internal static void ApplyAllStickers()
		{
			IReadOnlyList<StickerPlacement> placements = StickerSaveManager.Placements;
			string category = "Restore";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral("ApplyAllStickers: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(placements.Count);
			defaultInterpolatedStringHandler.AppendLiteral(" placements, ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(StickerManager.Count);
			defaultInterpolatedStringHandler.AppendLiteral(" stickers loaded");
			DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
			if (placements.Count == 0)
			{
				return;
			}
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}
			if (StickerManager.Count == 0)
			{
				DebugLog.Log("Restore", "No stickers loaded — cannot restore");
				return;
			}
			try
			{
				WorldSpraySurface[] array = null;
				try
				{
					Il2CppArrayBase<WorldSpraySurface> il2CppArrayBase = Object.FindObjectsOfType<WorldSpraySurface>();
					if (il2CppArrayBase != null)
					{
						array = new WorldSpraySurface[il2CppArrayBase.Count];
						for (int i = 0; i < il2CppArrayBase.Count; i++)
						{
							array[i] = il2CppArrayBase[i];
						}
					}
				}
				catch (Exception ex)
				{
					DebugLog.Log("Restore", "FindObjectsOfType<WorldSpraySurface> failed: " + ex.Message);
				}
				if (array == null || array.Length == 0)
				{
					DebugLog.Log("Restore", "No WorldSpraySurfaces found in scene");
				}
				else
				{
					string category2 = "Restore";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(25, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("Found ");
					defaultInterpolatedStringHandler2.AppendFormatted<int>(array.Length);
					defaultInterpolatedStringHandler2.AppendLiteral(" WorldSpraySurfaces");
					DebugLog.Log(category2, defaultInterpolatedStringHandler2.ToStringAndClear());
					Dictionary<string, WorldSpraySurface> dictionary = new Dictionary<string, WorldSpraySurface>(StringComparer.OrdinalIgnoreCase);
					foreach (WorldSpraySurface worldSpraySurface in array)
					{
						try
						{
							if (!(worldSpraySurface == null))
							{
								string text = worldSpraySurface.GUID.ToString() ?? "";
								if (!string.IsNullOrEmpty(text))
								{
									dictionary[text] = worldSpraySurface;
								}
							}
						}
						catch (Exception ex2)
						{
							DebugLog.Log("Restore", "GUID read error: " + ex2.Message);
						}
					}
					string category3 = "Restore";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(24, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("Built lookup with ");
					defaultInterpolatedStringHandler3.AppendFormatted<int>(dictionary.Count);
					defaultInterpolatedStringHandler3.AppendLiteral(" GUIDs");
					DebugLog.Log(category3, defaultInterpolatedStringHandler3.ToStringAndClear());
					if (dictionary.Count > 0)
					{
						int num = 0;
						foreach (KeyValuePair<string, WorldSpraySurface> keyValuePair in dictionary)
						{
							DebugLog.Log("Restore", "  Surface GUID sample: '" + keyValuePair.Key + "'");
							if (++num >= 3)
							{
								break;
							}
						}
					}
					int num2 = 0;
					foreach (StickerPlacement stickerPlacement in placements)
					{
						string category4 = "Restore";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler4.AppendLiteral("Looking for GUID='");
						defaultInterpolatedStringHandler4.AppendFormatted(stickerPlacement.SurfaceGuid);
						defaultInterpolatedStringHandler4.AppendLiteral("', Sticker='");
						defaultInterpolatedStringHandler4.AppendFormatted(stickerPlacement.StickerFileName);
						defaultInterpolatedStringHandler4.AppendLiteral("'");
						DebugLog.Log(category4, defaultInterpolatedStringHandler4.ToStringAndClear());
						WorldSpraySurface worldSurface;
						if (!dictionary.TryGetValue(stickerPlacement.SurfaceGuid, out worldSurface))
						{
							string category5 = "Restore";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(29, 1);
							defaultInterpolatedStringHandler5.AppendLiteral("  GUID not found in ");
							defaultInterpolatedStringHandler5.AppendFormatted<int>(dictionary.Count);
							defaultInterpolatedStringHandler5.AppendLiteral(" surfaces");
							DebugLog.Log(category5, defaultInterpolatedStringHandler5.ToStringAndClear());
						}
						else
						{
							StickerData stickerData = StickerManager.FindByFileName(stickerPlacement.StickerFileName);
							if (stickerData == null)
							{
								string category6 = "Restore";
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(42, 2);
								defaultInterpolatedStringHandler6.AppendLiteral("  Sticker '");
								defaultInterpolatedStringHandler6.AppendFormatted(stickerPlacement.StickerFileName);
								defaultInterpolatedStringHandler6.AppendLiteral("' not found in ");
								defaultInterpolatedStringHandler6.AppendFormatted<int>(StickerManager.Count);
								defaultInterpolatedStringHandler6.AppendLiteral(" loaded stickers");
								DebugLog.Log(category6, defaultInterpolatedStringHandler6.ToStringAndClear());
							}
							else if (stickerData.Texture == null)
							{
								DebugLog.Log("Restore", "  Sticker '" + stickerPlacement.StickerFileName + "' found but texture is null (unloaded by Unity)");
							}
							else
							{
								try
								{
									GraffitiPlacer.RestoreStickerOnSurface(worldSurface, stickerData);
									num2++;
									DebugLog.Log("Restore", "  Applied '" + stickerPlacement.StickerFileName + "' to surface");
								}
								catch (Exception ex3)
								{
									DebugLog.Log("Restore", "  Restore error: " + ex3.Message + "\n" + ex3.StackTrace);
								}
							}
						}
					}
					string category7 = "Restore";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler7.AppendLiteral("Result: ");
					defaultInterpolatedStringHandler7.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler7.AppendLiteral("/");
					defaultInterpolatedStringHandler7.AppendFormatted<int>(placements.Count);
					defaultInterpolatedStringHandler7.AppendLiteral(" stickers restored");
					DebugLog.Log(category7, defaultInterpolatedStringHandler7.ToStringAndClear());
					if (num2 > 0)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler8 = new DefaultInterpolatedStringHandler(35, 1);
						defaultInterpolatedStringHandler8.AppendLiteral("[HUB - Graffiti] Restored ");
						defaultInterpolatedStringHandler8.AppendFormatted<int>(num2);
						defaultInterpolatedStringHandler8.AppendLiteral(" stickers");
						MelonLogger.Msg(defaultInterpolatedStringHandler8.ToStringAndClear());
					}
				}
			}
			catch (Exception ex4)
			{
				DebugLog.Log("Restore", "ApplyAllStickers error: " + ex4.Message + "\n" + ex4.StackTrace);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004A60 File Offset: 0x00002C60
		private static void RestoreStickerOnSurface(WorldSpraySurface worldSurface, StickerData sticker)
		{
			Texture2D drawTex = GraffitiPlacer.CreateDrawingTexture(worldSurface, sticker.Texture);
			GraffitiPlacer.ReapplySticker(worldSurface, drawTex);
			GraffitiPlacer.HideSurfaceOutline(worldSurface);
			string text = "";
			try
			{
				text = worldSurface.GUID.ToString();
			}
			catch
			{
			}
			if (!string.IsNullOrEmpty(text))
			{
				GraffitiPlacer._stickeredSurfaces.Add(text);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004ACC File Offset: 0x00002CCC
		private static void HideSurfaceOutline(WorldSpraySurface worldSurface)
		{
			try
			{
				GameObject gameObject = worldSurface.gameObject;
				if (!(gameObject == null))
				{
					Transform transform = gameObject.transform;
					int childCount = transform.childCount;
					for (int i = 0; i < childCount; i++)
					{
						try
						{
							Transform child = transform.GetChild(i);
							if (!(child == null))
							{
								GameObject gameObject2 = child.gameObject;
								if (!(gameObject2.name == "Projector"))
								{
									gameObject2.SetActive(false);
								}
							}
						}
						catch
						{
						}
					}
					Il2CppArrayBase<Renderer> componentsInChildren = gameObject.GetComponentsInChildren<Renderer>(true);
					if (componentsInChildren != null)
					{
						for (int j = 0; j < componentsInChildren.Count; j++)
						{
							try
							{
								Renderer renderer = componentsInChildren[j];
								if (!(renderer == null) && !(renderer.gameObject.name == "Projector"))
								{
									renderer.enabled = false;
								}
							}
							catch
							{
							}
						}
					}
					Il2CppArrayBase<Canvas> componentsInChildren2 = gameObject.GetComponentsInChildren<Canvas>(true);
					if (componentsInChildren2 != null)
					{
						for (int k = 0; k < componentsInChildren2.Count; k++)
						{
							try
							{
								Canvas canvas = componentsInChildren2[k];
								if (canvas != null)
								{
									canvas.enabled = false;
								}
							}
							catch
							{
							}
						}
					}
					try
					{
						DecalProjector projector = worldSurface.Projector;
						if (projector != null)
						{
							projector.enabled = true;
							projector.fadeFactor = 1f;
						}
					}
					catch
					{
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Placer", "HideSurfaceOutline error: " + ex.Message);
			}
		}

		// Token: 0x0400000F RID: 15
		[Nullable(2)]
		private static GameObject _stickerButton;

		// Token: 0x04000010 RID: 16
		private static bool _wasMenuOpen;

		// Token: 0x04000011 RID: 17
		private static bool _sceneReady;

		// Token: 0x04000012 RID: 18
		[Nullable(2)]
		private static SpraySurface _savedSurface;

		// Token: 0x04000013 RID: 19
		[Nullable(2)]
		private static Texture2D _lastStickerTex;

		// Token: 0x04000014 RID: 20
		private static readonly HashSet<string> _stickeredSurfaces = new HashSet<string>();

		// Token: 0x04000015 RID: 21
		[Nullable(2)]
		private static GraffitiMenu _cachedMenu;

		// Token: 0x04000016 RID: 22
		[Nullable(2)]
		private static Canvas _cachedCanvas;

		// Token: 0x02000015 RID: 21
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000039 RID: 57
			[Nullable(0)]
			public static Action <0>__OnStickerButtonClicked;

			// Token: 0x0400003A RID: 58
			[Nullable(0)]
			public static Action<int> <1>__OnStickerSelected;
		}
	}
}
