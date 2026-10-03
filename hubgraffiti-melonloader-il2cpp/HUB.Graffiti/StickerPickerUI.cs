using System;
using System.Runtime.CompilerServices;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HUB.Graffiti
{
	// Token: 0x0200000C RID: 12
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StickerPickerUI
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005B0C File Offset: 0x00003D0C
		internal static bool IsOpen
		{
			get
			{
				if (StickerPickerUI._canvasGo == null)
				{
					return false;
				}
				bool result;
				try
				{
					result = StickerPickerUI._canvasGo.activeSelf;
				}
				catch
				{
					StickerPickerUI._canvasGo = null;
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005B54 File Offset: 0x00003D54
		internal static void Open(Action<int> onSelected)
		{
			if (StickerManager.Count == 0)
			{
				StickerManager.Initialize();
			}
			if (StickerManager.Count == 0)
			{
				MelonLogger.Msg("[HUB - Graffiti] No stickers loaded.");
				return;
			}
			StickerPickerUI._onSelected = onSelected;
			if (StickerPickerUI._canvasGo != null)
			{
				try
				{
					Object.Destroy(StickerPickerUI._canvasGo);
				}
				catch
				{
				}
				StickerPickerUI._canvasGo = null;
			}
			StickerPickerUI.BuildUI();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005BBC File Offset: 0x00003DBC
		internal static void Close()
		{
			if (StickerPickerUI._canvasGo != null)
			{
				try
				{
					Object.Destroy(StickerPickerUI._canvasGo);
				}
				catch
				{
				}
				StickerPickerUI._canvasGo = null;
			}
			StickerPickerUI._onSelected = null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005C04 File Offset: 0x00003E04
		private static void OnStickerClicked(int index)
		{
			Action<int> onSelected = StickerPickerUI._onSelected;
			StickerPickerUI.Close();
			if (onSelected == null)
			{
				return;
			}
			onSelected(index);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005C1C File Offset: 0x00003E1C
		private static void BuildUI()
		{
			StickerPickerUI._canvasGo = new GameObject("HUB_Graffiti_StickerPicker");
			Canvas canvas = StickerPickerUI._canvasGo.AddComponent<Canvas>();
			canvas.renderMode = 0;
			canvas.sortingOrder = 200;
			CanvasScaler canvasScaler = StickerPickerUI._canvasGo.AddComponent<CanvasScaler>();
			canvasScaler.uiScaleMode = 1;
			canvasScaler.referenceResolution = new Vector2(1920f, 1080f);
			canvasScaler.matchWidthOrHeight = 0.5f;
			StickerPickerUI._canvasGo.AddComponent<GraphicRaycaster>();
			Object.DontDestroyOnLoad(StickerPickerUI._canvasGo);
			GameObject gameObject = StickerPickerUI.CreateChild(StickerPickerUI._canvasGo.transform, "Background");
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.anchorMin = Vector2.zero;
			rectTransform.anchorMax = Vector2.one;
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
			gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.8f);
			UnityEvent onClick = gameObject.AddComponent<Button>().onClick;
			Action action;
			if ((action = StickerPickerUI.<>O.<0>__Close) == null)
			{
				action = (StickerPickerUI.<>O.<0>__Close = new Action(StickerPickerUI.Close));
			}
			onClick.AddListener(action);
			GameObject gameObject2 = StickerPickerUI.CreateChild(StickerPickerUI._canvasGo.transform, "Panel");
			RectTransform rectTransform2 = gameObject2.AddComponent<RectTransform>();
			rectTransform2.anchorMin = new Vector2(0.15f, 0.08f);
			rectTransform2.anchorMax = new Vector2(0.85f, 0.92f);
			rectTransform2.offsetMin = Vector2.zero;
			rectTransform2.offsetMax = Vector2.zero;
			gameObject2.AddComponent<Image>().color = new Color(0.1f, 0.1f, 0.15f, 0.97f);
			GameObject gameObject3 = StickerPickerUI.CreateChild(gameObject2.transform, "Title");
			RectTransform rectTransform3 = gameObject3.AddComponent<RectTransform>();
			rectTransform3.anchorMin = new Vector2(0f, 0.92f);
			rectTransform3.anchorMax = new Vector2(1f, 1f);
			rectTransform3.offsetMin = new Vector2(20f, 0f);
			rectTransform3.offsetMax = new Vector2(-60f, -5f);
			Text text = gameObject3.AddComponent<Text>();
			text.text = "SELECT A STICKER";
			text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			text.fontSize = 26;
			text.fontStyle = 1;
			text.alignment = 4;
			text.color = new Color(0.7f, 0.4f, 0.9f, 1f);
			GameObject gameObject4 = StickerPickerUI.CreateChild(gameObject2.transform, "CloseBtn");
			RectTransform rectTransform4 = gameObject4.AddComponent<RectTransform>();
			rectTransform4.anchorMin = new Vector2(1f, 1f);
			rectTransform4.anchorMax = new Vector2(1f, 1f);
			rectTransform4.pivot = new Vector2(1f, 1f);
			rectTransform4.sizeDelta = new Vector2(50f, 50f);
			rectTransform4.anchoredPosition = new Vector2(-5f, -5f);
			gameObject4.AddComponent<Image>().color = new Color(0.8f, 0.2f, 0.2f, 0.9f);
			UnityEvent onClick2 = gameObject4.AddComponent<Button>().onClick;
			Action action2;
			if ((action2 = StickerPickerUI.<>O.<0>__Close) == null)
			{
				action2 = (StickerPickerUI.<>O.<0>__Close = new Action(StickerPickerUI.Close));
			}
			onClick2.AddListener(action2);
			GameObject gameObject5 = StickerPickerUI.CreateChild(gameObject4.transform, "X");
			RectTransform rectTransform5 = gameObject5.AddComponent<RectTransform>();
			rectTransform5.anchorMin = Vector2.zero;
			rectTransform5.anchorMax = Vector2.one;
			rectTransform5.offsetMin = Vector2.zero;
			rectTransform5.offsetMax = Vector2.zero;
			Text text2 = gameObject5.AddComponent<Text>();
			text2.text = "X";
			text2.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			text2.fontSize = 24;
			text2.fontStyle = 1;
			text2.alignment = 4;
			text2.color = Color.white;
			GameObject gameObject6 = StickerPickerUI.CreateChild(gameObject2.transform, "Hint");
			RectTransform rectTransform6 = gameObject6.AddComponent<RectTransform>();
			rectTransform6.anchorMin = new Vector2(0f, 0f);
			rectTransform6.anchorMax = new Vector2(1f, 0.05f);
			rectTransform6.offsetMin = new Vector2(20f, 5f);
			rectTransform6.offsetMax = new Vector2(-20f, 0f);
			Text text3 = gameObject6.AddComponent<Text>();
			text3.text = "Click a sticker to apply  |  X to close";
			text3.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			text3.fontSize = 14;
			text3.alignment = 4;
			text3.color = new Color(0.6f, 0.6f, 0.65f, 1f);
			GameObject gameObject7 = StickerPickerUI.CreateChild(gameObject2.transform, "ScrollView");
			RectTransform rectTransform7 = gameObject7.AddComponent<RectTransform>();
			rectTransform7.anchorMin = new Vector2(0.02f, 0.06f);
			rectTransform7.anchorMax = new Vector2(0.98f, 0.91f);
			rectTransform7.offsetMin = Vector2.zero;
			rectTransform7.offsetMax = Vector2.zero;
			ScrollRect scrollRect = gameObject7.AddComponent<ScrollRect>();
			scrollRect.horizontal = false;
			scrollRect.vertical = true;
			scrollRect.movementType = 2;
			scrollRect.scrollSensitivity = 30f;
			GameObject gameObject8 = StickerPickerUI.CreateChild(gameObject7.transform, "Viewport");
			RectTransform rectTransform8 = gameObject8.AddComponent<RectTransform>();
			rectTransform8.anchorMin = Vector2.zero;
			rectTransform8.anchorMax = Vector2.one;
			rectTransform8.offsetMin = Vector2.zero;
			rectTransform8.offsetMax = Vector2.zero;
			gameObject8.AddComponent<RectMask2D>();
			GameObject gameObject9 = StickerPickerUI.CreateChild(gameObject8.transform, "Content");
			RectTransform rectTransform9 = gameObject9.AddComponent<RectTransform>();
			rectTransform9.anchorMin = new Vector2(0f, 1f);
			rectTransform9.anchorMax = new Vector2(1f, 1f);
			rectTransform9.pivot = new Vector2(0.5f, 1f);
			rectTransform9.sizeDelta = new Vector2(0f, 300f);
			GridLayoutGroup gridLayoutGroup = gameObject9.AddComponent<GridLayoutGroup>();
			gridLayoutGroup.cellSize = new Vector2(110f, 130f);
			gridLayoutGroup.spacing = new Vector2(12f, 12f);
			gridLayoutGroup.padding = new RectOffset(15, 15, 15, 15);
			gridLayoutGroup.constraint = 0;
			gridLayoutGroup.childAlignment = 1;
			gameObject9.AddComponent<ContentSizeFitter>().verticalFit = 2;
			scrollRect.viewport = rectTransform8;
			scrollRect.content = rectTransform9;
			for (int i = 0; i < StickerManager.Count; i++)
			{
				StickerData sticker = StickerManager.GetSticker(i);
				if (sticker != null)
				{
					StickerPickerUI.CreateStickerCell(gameObject9.transform, sticker, i);
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000623B File Offset: 0x0000443B
		private static GameObject CreateChild(Transform parent, string name)
		{
			GameObject gameObject = new GameObject(name);
			gameObject.transform.SetParent(parent, false);
			return gameObject;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006250 File Offset: 0x00004450
		private static void CreateStickerCell(Transform parent, StickerData sticker, int index)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Sticker_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(index);
			GameObject gameObject = StickerPickerUI.CreateChild(parent, defaultInterpolatedStringHandler.ToStringAndClear());
			gameObject.AddComponent<Image>().color = new Color(0.18f, 0.18f, 0.24f, 1f);
			Button button = gameObject.AddComponent<Button>();
			ColorBlock colors = button.colors;
			colors.normalColor = new Color(0.18f, 0.18f, 0.24f, 1f);
			colors.highlightedColor = new Color(0.3f, 0.2f, 0.45f, 1f);
			colors.pressedColor = new Color(0.5f, 0.25f, 0.7f, 1f);
			button.colors = colors;
			int idx = index;
			button.onClick.AddListener(delegate()
			{
				StickerPickerUI.OnStickerClicked(idx);
			});
			GameObject gameObject2 = StickerPickerUI.CreateChild(gameObject.transform, "Image");
			RectTransform rectTransform = gameObject2.AddComponent<RectTransform>();
			rectTransform.anchorMin = new Vector2(0.08f, 0.22f);
			rectTransform.anchorMax = new Vector2(0.92f, 0.95f);
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
			Image image = gameObject2.AddComponent<Image>();
			if (sticker.Sprite != null)
			{
				image.sprite = sticker.Sprite;
				image.preserveAspect = true;
			}
			else
			{
				image.color = new Color(0.4f, 0.2f, 0.6f, 0.5f);
			}
			GameObject gameObject3 = StickerPickerUI.CreateChild(gameObject.transform, "Label");
			RectTransform rectTransform2 = gameObject3.AddComponent<RectTransform>();
			rectTransform2.anchorMin = new Vector2(0f, 0f);
			rectTransform2.anchorMax = new Vector2(1f, 0.2f);
			rectTransform2.offsetMin = new Vector2(2f, 2f);
			rectTransform2.offsetMax = new Vector2(-2f, 0f);
			Text text = gameObject3.AddComponent<Text>();
			text.text = sticker.Name;
			text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			text.fontSize = 11;
			text.alignment = 4;
			text.color = new Color(0.8f, 0.8f, 0.85f, 1f);
			text.horizontalOverflow = 0;
		}

		// Token: 0x04000021 RID: 33
		[Nullable(2)]
		private static GameObject _canvasGo;

		// Token: 0x04000022 RID: 34
		[Nullable(2)]
		private static Action<int> _onSelected;

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000042 RID: 66
			[Nullable(0)]
			public static Action <0>__Close;
		}
	}
}
