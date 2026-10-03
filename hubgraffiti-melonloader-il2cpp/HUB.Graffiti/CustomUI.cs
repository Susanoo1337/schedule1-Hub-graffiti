using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MelonLoader;
using ModHub.Core;
using UnityEngine;
using UnityEngine.UI;

namespace HUB.Graffiti
{
	// Token: 0x02000006 RID: 6
	[NullableContext(1)]
	[Nullable(0)]
	internal static class CustomUI
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020A0 File Offset: 0x000002A0
		internal static void RenderContent(Transform contentParent, Font font)
		{
			CustomUI._contentParent = contentParent;
			CustomUI._font = font;
			try
			{
				CustomUI.BuildUI(contentParent, font);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("[HUB - Graffiti] UI Error: " + ex.Message);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020EC File Offset: 0x000002EC
		private static void BuildUI(Transform parent, Font font)
		{
			ModHubUI.InitSprites();
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}
			CustomUI.CreateSectionHeader(parent, "GRAFFITI", font, 15);
			ModHubUI.CreateSeparator(parent, 3f, new Color?(ModHubUI.Purple));
			CustomUI.AddSpacer(parent, 8f);
			GameObject gameObject = ModHubUI.CreateCard("EnableRow", parent, 42f, new Color?(ModHubUI.CardBg));
			RectTransform component = ModHubUI.CreateText("Enable Mod", gameObject.transform, font, 14, 1).GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(0.6f, 1f);
			component.offsetMin = new Vector2(14f, 0f);
			component.offsetMax = new Vector2(0f, 0f);
			MelonPreferences_Entry<bool> enableMod = GraffitiMod.EnableMod;
			bool initialValue = enableMod == null || enableMod.Value;
			GameObject item = ModHubUI.CreateToggle(gameObject.transform, font, initialValue, 0.3f, delegate(bool v)
			{
				if (GraffitiMod.EnableMod != null)
				{
					GraffitiMod.EnableMod.Value = v;
					MelonPreferences.Save();
				}
			}).Item1;
			item.GetComponent<RectTransform>().anchoredPosition = new Vector2(-14f, 0f);
			CustomUI.AddSpacer(parent, 6f);
			CustomUI.CreateInfoText(parent, "Equip spray can, interact with wall, click STICKER", font, 11, new Color?(ModHubUI.TextMuted));
			CustomUI.AddSpacer(parent, 10f);
			ModHubUI.CreateSeparator(parent, 2f, null);
			CustomUI.AddSpacer(parent, 10f);
			CustomUI.CreateSectionHeader(parent, "STATS", font, 13);
			CustomUI.AddSpacer(parent, 4f);
			MelonPreferences_Entry<int> spotsTagged = GraffitiMod.SpotsTagged;
			int value = (spotsTagged != null) ? spotsTagged.Value : 0;
			int count = StickerManager.Count;
			GameObject gameObject2 = ModHubUI.CreateCard("StatsCard", parent, 68f, new Color?(ModHubUI.CardBg));
			Text text = ModHubUI.CreateText("Spots Tagged", gameObject2.transform, font, 12, 0);
			text.color = ModHubUI.TextGray;
			RectTransform component2 = text.GetComponent<RectTransform>();
			component2.anchorMin = new Vector2(0f, 0.55f);
			component2.anchorMax = new Vector2(0.5f, 1f);
			component2.offsetMin = new Vector2(14f, 0f);
			component2.offsetMax = new Vector2(0f, 0f);
			Text text2 = ModHubUI.CreateText(value.ToString(), gameObject2.transform, font, 14, 1);
			text2.color = ModHubUI.Purple;
			text2.alignment = 5;
			RectTransform component3 = text2.GetComponent<RectTransform>();
			component3.anchorMin = new Vector2(0.5f, 0.55f);
			component3.anchorMax = new Vector2(1f, 1f);
			component3.offsetMin = new Vector2(0f, 0f);
			component3.offsetMax = new Vector2(-14f, 0f);
			Text text3 = ModHubUI.CreateText("Stickers Loaded", gameObject2.transform, font, 12, 0);
			text3.color = ModHubUI.TextGray;
			RectTransform component4 = text3.GetComponent<RectTransform>();
			component4.anchorMin = new Vector2(0f, 0f);
			component4.anchorMax = new Vector2(0.5f, 0.45f);
			component4.offsetMin = new Vector2(14f, 0f);
			component4.offsetMax = new Vector2(0f, 0f);
			Text text4 = ModHubUI.CreateText(count.ToString(), gameObject2.transform, font, 14, 1);
			text4.color = ModHubUI.Green;
			text4.alignment = 5;
			RectTransform component5 = text4.GetComponent<RectTransform>();
			component5.anchorMin = new Vector2(0.5f, 0f);
			component5.anchorMax = new Vector2(1f, 0.45f);
			component5.offsetMin = new Vector2(0f, 0f);
			component5.offsetMax = new Vector2(-14f, 0f);
			CustomUI.AddSpacer(parent, 10f);
			ModHubUI.CreateSeparator(parent, 2f, null);
			CustomUI.AddSpacer(parent, 10f);
			CustomUI.CreateSectionHeader(parent, "STICKER LIBRARY", font, 13);
			CustomUI.AddSpacer(parent, 4f);
			if (StickerManager.Count == 0)
			{
				CustomUI.CreateInfoText(parent, "No stickers loaded.", font, 13, null);
				CustomUI.CreateInfoText(parent, "Add PNG files to UserData/HUB_Graffiti/", font, 11, new Color?(ModHubUI.TextMuted));
			}
			else
			{
				int num = 3;
				float num2 = (float)((int)Math.Ceiling((double)((float)StickerManager.Count / (float)num)));
				float num3 = 80f;
				float num4 = 6f;
				float height = num2 * (num3 + num4) + num4;
				GameObject gameObject3 = ModHubUI.CreateCard("StickerGrid", parent, height, new Color?(new Color(0.1f, 0.1f, 0.14f, 1f)));
				GameObject gameObject4 = new GameObject("GridContent");
				gameObject4.transform.SetParent(gameObject3.transform, false);
				RectTransform rectTransform = gameObject4.AddComponent<RectTransform>();
				rectTransform.anchorMin = Vector2.zero;
				rectTransform.anchorMax = Vector2.one;
				rectTransform.offsetMin = new Vector2(num4, num4);
				rectTransform.offsetMax = new Vector2(-num4, -num4);
				GridLayoutGroup gridLayoutGroup = gameObject4.AddComponent<GridLayoutGroup>();
				gridLayoutGroup.cellSize = new Vector2(num3, num3);
				gridLayoutGroup.spacing = new Vector2(num4, num4);
				gridLayoutGroup.childAlignment = 1;
				gridLayoutGroup.constraint = 1;
				gridLayoutGroup.constraintCount = num;
				for (int i = 0; i < StickerManager.Count; i++)
				{
					StickerData sticker = StickerManager.GetSticker(i);
					if (sticker != null)
					{
						CustomUI.CreateStickerPreview(gameObject4.transform, font, sticker);
					}
				}
			}
			CustomUI.AddSpacer(parent, 10f);
			GameObject gameObject5 = ModHubUI.CreateCard("ReloadRow", parent, 42f, new Color?(ModHubUI.CardBg));
			ValueTuple<GameObject, Button, Text> valueTuple = ModHubUI.CreateButton("Reload Stickers", gameObject5.transform, font, 13, new Color?(ModHubUI.Purple));
			GameObject item2 = valueTuple.Item1;
			Button item3 = valueTuple.Item2;
			RectTransform component6 = item2.GetComponent<RectTransform>();
			component6.anchorMin = new Vector2(0.15f, 0.12f);
			component6.anchorMax = new Vector2(0.85f, 0.88f);
			component6.offsetMin = Vector2.zero;
			component6.offsetMax = Vector2.zero;
			item3.onClick.AddListener(delegate()
			{
				StickerManager.Reload();
				CustomUI.RefreshUI();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(35, 1);
				defaultInterpolatedStringHandler3.AppendLiteral("[HUB - Graffiti] Reloaded ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(StickerManager.Count);
				defaultInterpolatedStringHandler3.AppendLiteral(" stickers");
				MelonLogger.Msg(defaultInterpolatedStringHandler3.ToStringAndClear());
			});
			CustomUI.AddSpacer(parent, 6f);
			CustomUI.CreateInfoText(parent, "Drop custom PNGs into UserData/HUB_Graffiti/", font, 10, new Color?(ModHubUI.TextMuted));
			CustomUI.AddSpacer(parent, 10f);
			ModHubUI.CreateSeparator(parent, 2f, null);
			CustomUI.AddSpacer(parent, 10f);
			CustomUI.CreateSectionHeader(parent, "STATUS", font, 13);
			ModHubUI.CreateSeparator(parent, 3f, new Color?(ModHubUI.Purple));
			CustomUI.AddSpacer(parent, 4f);
			GameObject gameObject6 = ModHubUI.CreateCard("StatusCard", parent, 80f, new Color?(ModHubUI.CardBg));
			MelonPreferences_Entry<bool> enableMod2 = GraffitiMod.EnableMod;
			bool flag = enableMod2 != null && enableMod2.Value;
			Text text5 = ModHubUI.CreateText("Mod: " + (flag ? "Active" : "Inactive"), gameObject6.transform, font, 12, 1);
			text5.color = (flag ? ModHubUI.Green : new Color(0.8f, 0.3f, 0.3f, 1f));
			RectTransform component7 = text5.GetComponent<RectTransform>();
			component7.anchorMin = new Vector2(0f, 0.66f);
			component7.anchorMax = new Vector2(1f, 1f);
			component7.offsetMin = new Vector2(14f, 0f);
			component7.offsetMax = new Vector2(-14f, 0f);
			text5.alignment = 3;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Stickers Loaded: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			Text text6 = ModHubUI.CreateText(defaultInterpolatedStringHandler.ToStringAndClear(), gameObject6.transform, font, 12, 1);
			text6.color = ((count > 0) ? ModHubUI.Green : new Color(0.8f, 0.3f, 0.3f, 1f));
			RectTransform component8 = text6.GetComponent<RectTransform>();
			component8.anchorMin = new Vector2(0f, 0.33f);
			component8.anchorMax = new Vector2(1f, 0.66f);
			component8.offsetMin = new Vector2(14f, 0f);
			component8.offsetMax = new Vector2(-14f, 0f);
			text6.alignment = 3;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("Spots Tagged: ");
			defaultInterpolatedStringHandler2.AppendFormatted<int>(value);
			Text text7 = ModHubUI.CreateText(defaultInterpolatedStringHandler2.ToStringAndClear(), gameObject6.transform, font, 12, 1);
			text7.color = ModHubUI.Green;
			RectTransform component9 = text7.GetComponent<RectTransform>();
			component9.anchorMin = new Vector2(0f, 0f);
			component9.anchorMax = new Vector2(1f, 0.33f);
			component9.offsetMin = new Vector2(14f, 0f);
			component9.offsetMax = new Vector2(-14f, 0f);
			text7.alignment = 3;
			ModHubUI.CreateSeparator(parent, 3f, new Color?(ModHubUI.Purple));
			CustomUI.AddSpacer(parent, 8f);
			GameObject gameObject7 = ModHubUI.CreateCard("LogRow", parent, 42f, new Color?(ModHubUI.CardBg));
			ValueTuple<GameObject, Button, Text> valueTuple2 = ModHubUI.CreateButton("Open Log Folder (Bug Reports)", gameObject7.transform, font, 13, new Color?(ModHubUI.Purple));
			GameObject item4 = valueTuple2.Item1;
			Button item5 = valueTuple2.Item2;
			RectTransform component10 = item4.GetComponent<RectTransform>();
			component10.anchorMin = new Vector2(0.08f, 0.12f);
			component10.anchorMax = new Vector2(0.92f, 0.88f);
			component10.offsetMin = Vector2.zero;
			component10.offsetMax = Vector2.zero;
			item5.onClick.AddListener(delegate()
			{
				try
				{
					DebugLog.Flush();
					Process.Start("explorer.exe", DebugLog.LogFolder);
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[HUB - Graffiti] Could not open log folder: " + ex.Message);
				}
			});
			CustomUI.AddSpacer(parent, 10f);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002AD0 File Offset: 0x00000CD0
		private static void CreateStickerPreview(Transform parent, Font font, StickerData sticker)
		{
			GameObject gameObject = new GameObject("Preview_" + sticker.Name);
			gameObject.transform.SetParent(parent, false);
			Image image = gameObject.AddComponent<Image>();
			image.color = new Color(0.18f, 0.18f, 0.24f, 1f);
			if (ModHubUI.CardSprite != null)
			{
				image.sprite = ModHubUI.CardSprite;
				image.type = 1;
			}
			GameObject gameObject2 = new GameObject("Image");
			gameObject2.transform.SetParent(gameObject.transform, false);
			RectTransform rectTransform = gameObject2.AddComponent<RectTransform>();
			rectTransform.anchorMin = new Vector2(0.1f, 0.3f);
			rectTransform.anchorMax = new Vector2(0.9f, 0.95f);
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
			Image image2 = gameObject2.AddComponent<Image>();
			if (sticker.Sprite != null)
			{
				image2.sprite = sticker.Sprite;
				image2.preserveAspect = true;
			}
			GameObject gameObject3 = new GameObject("Label");
			gameObject3.transform.SetParent(gameObject.transform, false);
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.anchorMin = new Vector2(0f, 0f);
			rectTransform2.anchorMax = new Vector2(1f, 0.28f);
			rectTransform2.offsetMin = new Vector2(2f, 0f);
			rectTransform2.offsetMax = new Vector2(-2f, 0f);
			Text text = gameObject3.AddComponent<Text>();
			text.text = sticker.Name;
			text.font = font;
			text.fontSize = 8;
			text.alignment = 4;
			text.color = ModHubUI.TextGray;
			text.horizontalOverflow = 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002C7C File Offset: 0x00000E7C
		private static void CreateSectionHeader(Transform parent, string title, Font font, int fontSize = 15)
		{
			GameObject gameObject = ModHubUI.CreateCard("Header_" + title, parent, 32f, new Color?(new Color(0.12f, 0.12f, 0.16f, 0.8f)));
			Text text = ModHubUI.CreateText(title, gameObject.transform, font, fontSize, 1);
			text.color = ModHubUI.Purple;
			text.alignment = 3;
			text.GetComponent<RectTransform>().offsetMin = new Vector2(12f, 0f);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002CF8 File Offset: 0x00000EF8
		private static void CreateInfoText(Transform parent, string text, Font font, int fontSize = 13, Color? color = null)
		{
			GameObject gameObject = ModHubUI.CreateCard("Info", parent, 30f, new Color?(new Color(0.12f, 0.12f, 0.16f, 0.5f)));
			Text text2 = ModHubUI.CreateText(text, gameObject.transform, font, fontSize, 0);
			text2.color = (color ?? ModHubUI.TextGray);
			text2.alignment = 4;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D69 File Offset: 0x00000F69
		private static void AddSpacer(Transform parent, float height)
		{
			GameObject gameObject = new GameObject("Spacer");
			gameObject.transform.SetParent(parent, false);
			gameObject.AddComponent<RectTransform>();
			LayoutElement layoutElement = gameObject.AddComponent<LayoutElement>();
			layoutElement.minHeight = height;
			layoutElement.preferredHeight = height;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D9C File Offset: 0x00000F9C
		internal static void RefreshUI()
		{
			if (CustomUI._contentParent == null || CustomUI._font == null)
			{
				return;
			}
			for (int i = CustomUI._contentParent.childCount - 1; i >= 0; i--)
			{
				Object.DestroyImmediate(CustomUI._contentParent.GetChild(i).gameObject);
			}
			CustomUI.RenderContent(CustomUI._contentParent, CustomUI._font);
		}

		// Token: 0x04000004 RID: 4
		[Nullable(2)]
		private static Transform _contentParent;

		// Token: 0x04000005 RID: 5
		[Nullable(2)]
		private static Font _font;
	}
}
