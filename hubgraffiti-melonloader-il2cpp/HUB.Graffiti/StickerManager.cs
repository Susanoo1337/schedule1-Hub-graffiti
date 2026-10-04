using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>The sticker library: every PNG in UserData/HUB_Graffiti, loaded at native resolution.</summary>
	internal static class StickerManager
	{
		private const int MaxInitAttempts = 5;
		private const int DefaultStickerSize = 256;

		internal static readonly string StickerFolder = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti");

		private static readonly List<StickerData> _stickers = new List<StickerData>();
		private static bool _initialized;
		private static int _initAttempts;

		internal static IReadOnlyList<StickerData> Stickers => _stickers;

		internal static int Count => _stickers.Count;

		internal static void Initialize()
		{
			if (_initialized && _stickers.Count > 0)
			{
				return;
			}
			if (_initAttempts >= MaxInitAttempts)
			{
				return;
			}
			_initAttempts++;
			try
			{
				Directory.CreateDirectory(StickerFolder);
				string[] files = Directory.GetFiles(StickerFolder, "*.png");
				if (files.Length == 0)
				{
					GenerateDefaultStickers();
					files = Directory.GetFiles(StickerFolder, "*.png");
				}

				UnloadAll();
				foreach (string filePath in files.OrderBy(f => Path.GetFileNameWithoutExtension(f), StringComparer.OrdinalIgnoreCase))
				{
					LoadSticker(filePath);
				}

				if (_stickers.Count > 0)
				{
					_initialized = true;
					MelonLogger.Msg("[HUB - Graffiti] Loaded " + _stickers.Count + " stickers");
					for (int i = 0; i < _stickers.Count; i++)
					{
						StickerData s = _stickers[i];
						DebugLog.Log("Stickers", "  [" + i + "] '" + s.Name + "' " + s.Texture.width + "x" + s.Texture.height);
					}
				}
				else
				{
					MelonLogger.Warning("[HUB - Graffiti] Sticker loading returned 0 stickers, will retry...");
				}
			}
			catch (Exception ex)
			{
				MelonLogger.Error("[HUB - Graffiti] Sticker init error (attempt " + _initAttempts + "): " + ex.Message);
			}
		}

		internal static void Reload()
		{
			UnloadAll();
			_initialized = false;
			_initAttempts = 0;
			Initialize();
		}

		internal static StickerData GetSticker(int index)
		{
			if (index < 0 || index >= _stickers.Count)
			{
				return null;
			}
			return _stickers[index];
		}

		internal static StickerData FindByFileName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			foreach (StickerData sticker in _stickers)
			{
				if (string.Equals(sticker.Name, name, StringComparison.OrdinalIgnoreCase))
				{
					return sticker;
				}
			}
			return null;
		}

		private static void LoadSticker(string filePath)
		{
			try
			{
				byte[] bytes = File.ReadAllBytes(filePath);
				// Mipmaps keep the small previews in the menus from aliasing on large PNGs.
				Texture2D texture = new Texture2D(2, 2, TextureFormat.RGBA32, true);
				Il2CppStructArray<byte> data = bytes;
				if (!ImageConversion.LoadImage(texture, data))
				{
					Object.Destroy(texture);
					DebugLog.Log("Stickers", "Failed to decode image: " + filePath);
					return;
				}
				string name = Path.GetFileNameWithoutExtension(filePath);
				texture.name = "HUB_Sticker_" + name;
				texture.filterMode = FilterMode.Bilinear;
				texture.wrapMode = TextureWrapMode.Clamp;
				texture.hideFlags = HideFlags.DontUnloadUnusedAsset;
				Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
				sprite.hideFlags = HideFlags.DontUnloadUnusedAsset;
				_stickers.Add(new StickerData
				{
					Name = name,
					FilePath = filePath,
					Texture = texture,
					Sprite = sprite
				});
			}
			catch (Exception ex)
			{
				MelonLogger.Warning("[HUB - Graffiti] Failed to load sticker: " + Path.GetFileName(filePath) + " - " + ex.Message);
			}
		}

		// Placed decals keep their own baked copies, so the library textures can go at any time.
		private static void UnloadAll()
		{
			foreach (StickerData sticker in _stickers)
			{
				try
				{
					if (sticker.Sprite != null)
					{
						Object.Destroy(sticker.Sprite);
					}
					if (sticker.Texture != null)
					{
						Object.Destroy(sticker.Texture);
					}
				}
				catch
				{
				}
			}
			_stickers.Clear();
		}

		// ---- Default stickers, written once when the folder has no PNGs ----

		private static void GenerateDefaultStickers()
		{
			Gen("01_HUB_Logo", DrawHubLogo);
			Gen("02_Smiley", DrawSmiley);
			Gen("03_Skull", DrawSkull);
			Gen("04_Crown", DrawCrown);
			Gen("05_Heart", DrawHeart);
		}

		private static void Gen(string name, Action<Texture2D> drawFunc)
		{
			Texture2D texture = null;
			try
			{
				texture = new Texture2D(DefaultStickerSize, DefaultStickerSize, TextureFormat.RGBA32, false);
				texture.SetPixels32(new Color32[DefaultStickerSize * DefaultStickerSize]);
				drawFunc(texture);
				texture.Apply();
				Il2CppStructArray<byte> png = ImageConversion.EncodeToPNG(texture);
				byte[] bytes = new byte[png.Length];
				for (int i = 0; i < png.Length; i++)
				{
					bytes[i] = png[i];
				}
				File.WriteAllBytes(Path.Combine(StickerFolder, name + ".png"), bytes);
			}
			catch (Exception ex)
			{
				MelonLogger.Warning("[HUB - Graffiti] Failed to generate sticker: " + name + " - " + ex.Message);
			}
			finally
			{
				if (texture != null)
				{
					Object.Destroy(texture);
				}
			}
		}

		private static void FillCircle(Texture2D tex, int cx, int cy, int r, Color col)
		{
			int r2 = r * r;
			for (int y = cy - r; y <= cy + r; y++)
			{
				for (int x = cx - r; x <= cx + r; x++)
				{
					if (x < 0 || x >= tex.width || y < 0 || y >= tex.height)
					{
						continue;
					}
					int dx = x - cx;
					int dy = y - cy;
					if (dx * dx + dy * dy <= r2)
					{
						tex.SetPixel(x, y, col);
					}
				}
			}
		}

		private static void Line(Texture2D tex, int x0, int y0, int x1, int y1, int thickness, Color col)
		{
			int dx = Math.Abs(x1 - x0);
			int dy = Math.Abs(y1 - y0);
			int sx = x0 < x1 ? 1 : -1;
			int sy = y0 < y1 ? 1 : -1;
			int err = dx - dy;
			while (true)
			{
				FillCircle(tex, x0, y0, thickness / 2, col);
				if (x0 == x1 && y0 == y1)
				{
					break;
				}
				int e2 = 2 * err;
				if (e2 > -dy)
				{
					err -= dy;
					x0 += sx;
				}
				if (e2 < dx)
				{
					err += dx;
					y0 += sy;
				}
			}
		}

		private static void FillRect(Texture2D tex, int x1, int y1, int x2, int y2, Color col)
		{
			for (int y = Math.Max(0, y1); y < Math.Min(tex.height, y2); y++)
			{
				for (int x = Math.Max(0, x1); x < Math.Min(tex.width, x2); x++)
				{
					tex.SetPixel(x, y, col);
				}
			}
		}

		private static void DrawHubLogo(Texture2D tex)
		{
			Color purple = new Color(0.45f, 0.18f, 0.55f, 1f);
			Color white = new Color(1f, 1f, 1f, 0.95f);
			Color dark = new Color(0.3f, 0.1f, 0.4f, 1f);
			const int c = 128;
			FillCircle(tex, c, c, 120, purple);
			FillCircle(tex, c, c, 105, dark);
			FillCircle(tex, c, c, 100, purple);
			const int t = 14;
			Line(tex, 70, 70, 70, 190, t, white);
			Line(tex, 186, 70, 186, 190, t, white);
			Line(tex, 70, 190, 128, 140, t, white);
			Line(tex, 186, 190, 128, 140, t, white);
			FillCircle(tex, 108, 55, 4, white);
			FillCircle(tex, 128, 55, 4, white);
			FillCircle(tex, 148, 55, 4, white);
		}

		private static void DrawSmiley(Texture2D tex)
		{
			Color yellow = new Color(1f, 0.85f, 0f, 1f);
			Color dark = new Color(0.1f, 0.1f, 0.1f, 1f);
			const int c = 128;
			FillCircle(tex, c, c, 110, yellow);
			FillCircle(tex, 90, 155, 16, dark);
			FillCircle(tex, 166, 155, 16, dark);
			for (int deg = -140; deg <= -40; deg++)
			{
				double rad = deg * Math.PI / 180.0;
				FillCircle(tex, c + (int)(65.0 * Math.Cos(rad)), c + (int)(65.0 * Math.Sin(rad)), 6, dark);
			}
		}

		private static void DrawSkull(Texture2D tex)
		{
			Color bone = new Color(0.95f, 0.95f, 0.9f, 1f);
			Color dark = new Color(0.15f, 0.15f, 0.2f, 1f);
			const int cx = 128;
			FillCircle(tex, cx, 150, 70, bone);
			FillRect(tex, 70, 80, 186, 150, bone);
			FillRect(tex, 85, 68, 171, 90, bone);
			FillCircle(tex, 110, 72, 20, bone);
			FillCircle(tex, 146, 72, 20, bone);
			FillCircle(tex, 102, 158, 20, dark);
			FillCircle(tex, 154, 158, 20, dark);
			FillCircle(tex, 128, 130, 8, dark);
			FillCircle(tex, 120, 125, 6, dark);
			for (int i = 0; i < 5; i++)
			{
				int x = 92 + i * 18;
				FillRect(tex, x, 80, x + 12, 100, bone);
				FillRect(tex, x + 2, 82, x + 10, 98, dark);
			}
			Line(tex, 30, 30, 226, 230, 12, bone);
			Line(tex, 226, 30, 30, 230, 12, bone);
			FillCircle(tex, 30, 30, 14, bone);
			FillCircle(tex, 226, 30, 14, bone);
			FillCircle(tex, 30, 230, 14, bone);
			FillCircle(tex, 226, 230, 14, bone);
		}

		private static void DrawCrown(Texture2D tex)
		{
			Color gold = new Color(1f, 0.8f, 0f, 1f);
			Color darkGold = new Color(0.85f, 0.6f, 0f, 1f);
			Color ruby = new Color(0.8f, 0.1f, 0.15f, 1f);
			// Band.
			FillRect(tex, 40, 60, 216, 100, gold);
			// Points: fill each column up to the zig-zag outline (the old version filled a solid block here).
			int[] px = { 40, 80, 128, 176, 216 };
			int[] py = { 180, 140, 210, 140, 180 };
			for (int x = 40; x <= 216; x++)
			{
				int seg = 0;
				while (seg < px.Length - 2 && x > px[seg + 1])
				{
					seg++;
				}
				float f = (float)(x - px[seg]) / (px[seg + 1] - px[seg]);
				int top = (int)(py[seg] + f * (py[seg + 1] - py[seg]));
				FillRect(tex, x, 100, x + 1, top, gold);
			}
			for (int i = 0; i < px.Length - 1; i++)
			{
				Line(tex, px[i], py[i], px[i + 1], py[i + 1], 6, darkGold);
			}
			FillCircle(tex, 40, 180, 9, gold);
			FillCircle(tex, 128, 210, 9, gold);
			FillCircle(tex, 216, 180, 9, gold);
			FillCircle(tex, 80, 80, 10, ruby);
			FillCircle(tex, 128, 80, 10, ruby);
			FillCircle(tex, 176, 80, 10, ruby);
			Line(tex, 40, 60, 216, 60, 6, darkGold);
			Line(tex, 40, 100, 216, 100, 4, darkGold);
		}

		private static void DrawHeart(Texture2D tex)
		{
			Color red = new Color(0.9f, 0.1f, 0.2f, 1f);
			const int c = 128;
			FillCircle(tex, 90, 165, 55, red);
			FillCircle(tex, 166, 165, 55, red);
			for (int y = 50; y <= 165; y++)
			{
				float f = (165f - y) / 115f;
				int half = (int)(110f * (1f - f));
				FillRect(tex, c - half, y, c + half, y + 1, red);
			}
		}
	}
}
