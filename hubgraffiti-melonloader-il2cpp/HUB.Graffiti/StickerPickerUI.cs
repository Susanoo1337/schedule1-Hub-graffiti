using System;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>Full-screen overlay listing the sticker library; opened from the STICKER button.</summary>
	internal static class StickerPickerUI
	{
		private static GameObject _canvasGo;
		private static Action<int> _onSelected;

		internal static bool IsOpen
		{
			get
			{
				if (_canvasGo == null)
				{
					return false;
				}
				try
				{
					return _canvasGo.activeSelf;
				}
				catch
				{
					_canvasGo = null;
					return false;
				}
			}
		}

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
			DestroyCanvas();
			_onSelected = onSelected;
			BuildUI();
		}

		internal static void Close()
		{
			DestroyCanvas();
			_onSelected = null;
		}

		private static void DestroyCanvas()
		{
			if (_canvasGo != null)
			{
				try
				{
					Object.Destroy(_canvasGo);
				}
				catch
				{
				}
			}
			_canvasGo = null;
		}

		private static void OnStickerClicked(int index)
		{
			Action<int> onSelected = _onSelected;
			Close();
			onSelected?.Invoke(index);
		}

		private static void BuildUI()
		{
			Font font = UiFonts.Builtin;

			_canvasGo = new GameObject("HUB_Graffiti_StickerPicker");
			Canvas canvas = _canvasGo.AddComponent<Canvas>();
			canvas.renderMode = RenderMode.ScreenSpaceOverlay;
			canvas.sortingOrder = 200;
			CanvasScaler scaler = _canvasGo.AddComponent<CanvasScaler>();
			scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
			scaler.referenceResolution = new Vector2(1920f, 1080f);
			scaler.matchWidthOrHeight = 0.5f;
			_canvasGo.AddComponent<GraphicRaycaster>();

			GameObject background = CreateChild(_canvasGo.transform, "Background");
			Stretch(background.AddComponent<RectTransform>());
			background.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.8f);
			background.AddComponent<Button>().onClick.AddListener(new Action(Close));

			GameObject panel = CreateChild(_canvasGo.transform, "Panel");
			RectTransform panelRect = panel.AddComponent<RectTransform>();
			panelRect.anchorMin = new Vector2(0.15f, 0.08f);
			panelRect.anchorMax = new Vector2(0.85f, 0.92f);
			panelRect.offsetMin = Vector2.zero;
			panelRect.offsetMax = Vector2.zero;
			panel.AddComponent<Image>().color = new Color(0.1f, 0.1f, 0.15f, 0.97f);

			GameObject title = CreateChild(panel.transform, "Title");
			RectTransform titleRect = title.AddComponent<RectTransform>();
			titleRect.anchorMin = new Vector2(0f, 0.92f);
			titleRect.anchorMax = new Vector2(1f, 1f);
			titleRect.offsetMin = new Vector2(20f, 0f);
			titleRect.offsetMax = new Vector2(-60f, -5f);
			AddText(title, "SELECT A STICKER", font, 26, FontStyle.Bold, new Color(0.7f, 0.4f, 0.9f, 1f));

			GameObject closeBtn = CreateChild(panel.transform, "CloseBtn");
			RectTransform closeRect = closeBtn.AddComponent<RectTransform>();
			closeRect.anchorMin = new Vector2(1f, 1f);
			closeRect.anchorMax = new Vector2(1f, 1f);
			closeRect.pivot = new Vector2(1f, 1f);
			closeRect.sizeDelta = new Vector2(50f, 50f);
			closeRect.anchoredPosition = new Vector2(-5f, -5f);
			closeBtn.AddComponent<Image>().color = new Color(0.8f, 0.2f, 0.2f, 0.9f);
			closeBtn.AddComponent<Button>().onClick.AddListener(new Action(Close));
			GameObject closeLabel = CreateChild(closeBtn.transform, "X");
			Stretch(closeLabel.AddComponent<RectTransform>());
			AddText(closeLabel, "X", font, 24, FontStyle.Bold, Color.white);

			GameObject hint = CreateChild(panel.transform, "Hint");
			RectTransform hintRect = hint.AddComponent<RectTransform>();
			hintRect.anchorMin = new Vector2(0f, 0f);
			hintRect.anchorMax = new Vector2(1f, 0.05f);
			hintRect.offsetMin = new Vector2(20f, 5f);
			hintRect.offsetMax = new Vector2(-20f, 0f);
			AddText(hint, "Click a sticker to apply  |  X to close", font, 14, FontStyle.Normal, new Color(0.6f, 0.6f, 0.65f, 1f));

			GameObject scrollView = CreateChild(panel.transform, "ScrollView");
			RectTransform scrollRectTransform = scrollView.AddComponent<RectTransform>();
			scrollRectTransform.anchorMin = new Vector2(0.02f, 0.06f);
			scrollRectTransform.anchorMax = new Vector2(0.98f, 0.91f);
			scrollRectTransform.offsetMin = Vector2.zero;
			scrollRectTransform.offsetMax = Vector2.zero;
			ScrollRect scrollRect = scrollView.AddComponent<ScrollRect>();
			scrollRect.horizontal = false;
			scrollRect.vertical = true;
			scrollRect.movementType = ScrollRect.MovementType.Clamped;
			scrollRect.scrollSensitivity = 30f;

			GameObject viewport = CreateChild(scrollView.transform, "Viewport");
			RectTransform viewportRect = viewport.AddComponent<RectTransform>();
			Stretch(viewportRect);
			viewport.AddComponent<RectMask2D>();

			GameObject content = CreateChild(viewport.transform, "Content");
			RectTransform contentRect = content.AddComponent<RectTransform>();
			contentRect.anchorMin = new Vector2(0f, 1f);
			contentRect.anchorMax = new Vector2(1f, 1f);
			contentRect.pivot = new Vector2(0.5f, 1f);
			contentRect.sizeDelta = new Vector2(0f, 300f);
			GridLayoutGroup grid = content.AddComponent<GridLayoutGroup>();
			grid.cellSize = new Vector2(110f, 130f);
			grid.spacing = new Vector2(12f, 12f);
			grid.padding = new RectOffset(15, 15, 15, 15);
			grid.constraint = GridLayoutGroup.Constraint.Flexible;
			grid.childAlignment = TextAnchor.UpperCenter;
			content.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			scrollRect.viewport = viewportRect;
			scrollRect.content = contentRect;

			for (int i = 0; i < StickerManager.Count; i++)
			{
				StickerData sticker = StickerManager.GetSticker(i);
				if (sticker != null)
				{
					CreateStickerCell(content.transform, sticker, i, font);
				}
			}
		}

		private static void CreateStickerCell(Transform parent, StickerData sticker, int index, Font font)
		{
			GameObject cell = CreateChild(parent, "Sticker_" + index);
			cell.AddComponent<Image>().color = Color.white;
			Button button = cell.AddComponent<Button>();
			ColorBlock colors = button.colors;
			colors.normalColor = new Color(0.18f, 0.18f, 0.24f, 1f);
			colors.highlightedColor = new Color(0.3f, 0.2f, 0.45f, 1f);
			colors.selectedColor = new Color(0.18f, 0.18f, 0.24f, 1f);
			colors.pressedColor = new Color(0.5f, 0.25f, 0.7f, 1f);
			button.colors = colors;
			int idx = index;
			button.onClick.AddListener(new Action(() => OnStickerClicked(idx)));

			GameObject imageGo = CreateChild(cell.transform, "Image");
			RectTransform imageRect = imageGo.AddComponent<RectTransform>();
			imageRect.anchorMin = new Vector2(0.08f, 0.22f);
			imageRect.anchorMax = new Vector2(0.92f, 0.95f);
			imageRect.offsetMin = Vector2.zero;
			imageRect.offsetMax = Vector2.zero;
			Image image = imageGo.AddComponent<Image>();
			image.raycastTarget = false;
			if (sticker.Sprite != null)
			{
				image.sprite = sticker.Sprite;
				image.preserveAspect = true;
			}
			else
			{
				image.color = new Color(0.4f, 0.2f, 0.6f, 0.5f);
			}

			GameObject label = CreateChild(cell.transform, "Label");
			RectTransform labelRect = label.AddComponent<RectTransform>();
			labelRect.anchorMin = new Vector2(0f, 0f);
			labelRect.anchorMax = new Vector2(1f, 0.2f);
			labelRect.offsetMin = new Vector2(2f, 2f);
			labelRect.offsetMax = new Vector2(-2f, 0f);
			Text text = AddText(label, sticker.Name, font, 11, FontStyle.Normal, new Color(0.8f, 0.8f, 0.85f, 1f));
			text.horizontalOverflow = HorizontalWrapMode.Wrap;
		}

		private static GameObject CreateChild(Transform parent, string name)
		{
			GameObject go = new GameObject(name);
			go.transform.SetParent(parent, false);
			return go;
		}

		private static void Stretch(RectTransform rect)
		{
			rect.anchorMin = Vector2.zero;
			rect.anchorMax = Vector2.one;
			rect.offsetMin = Vector2.zero;
			rect.offsetMax = Vector2.zero;
		}

		private static Text AddText(GameObject go, string value, Font font, int size, FontStyle style, Color color)
		{
			Text text = go.AddComponent<Text>();
			text.text = value;
			text.font = font;
			text.fontSize = size;
			text.fontStyle = style;
			text.alignment = TextAnchor.MiddleCenter;
			text.color = color;
			text.raycastTarget = false;
			return text;
		}
	}
}
