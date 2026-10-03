using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

namespace HUB.Graffiti
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StickerManager
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004D2A File Offset: 0x00002F2A
		internal static IReadOnlyList<StickerData> Stickers
		{
			get
			{
				return StickerManager._stickers;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004D31 File Offset: 0x00002F31
		internal static int Count
		{
			get
			{
				return StickerManager._stickers.Count;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004D40 File Offset: 0x00002F40
		internal static void Initialize()
		{
			if (StickerManager._initialized && StickerManager._stickers.Count > 0)
			{
				return;
			}
			if (StickerManager._initAttempts >= 5)
			{
				return;
			}
			StickerManager._initAttempts++;
			try
			{
				if (!Directory.Exists(StickerManager.StickerFolder))
				{
					Directory.CreateDirectory(StickerManager.StickerFolder);
				}
				string[] files = Directory.GetFiles(StickerManager.StickerFolder, "*.png");
				if (files.Length == 0)
				{
					StickerManager.GenerateDefaultStickers();
					files = Directory.GetFiles(StickerManager.StickerFolder, "*.png");
				}
				StickerManager._stickers.Clear();
				foreach (string filePath in from f in files
				orderby Path.GetFileNameWithoutExtension(f)
				select f)
				{
					StickerManager.LoadSticker(filePath);
				}
				if (StickerManager._stickers.Count > 0)
				{
					StickerManager._initialized = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[HUB - Graffiti] Loaded ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(StickerManager._stickers.Count);
					defaultInterpolatedStringHandler.AppendLiteral(" stickers");
					MelonLogger.Msg(defaultInterpolatedStringHandler.ToStringAndClear());
					for (int i = 0; i < StickerManager._stickers.Count; i++)
					{
						string category = "Stickers";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 3);
						defaultInterpolatedStringHandler2.AppendLiteral("  [");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(i);
						defaultInterpolatedStringHandler2.AppendLiteral("] '");
						defaultInterpolatedStringHandler2.AppendFormatted(StickerManager._stickers[i].Name);
						defaultInterpolatedStringHandler2.AppendLiteral("' tex=");
						defaultInterpolatedStringHandler2.AppendFormatted<bool>(StickerManager._stickers[i].Texture != null);
						DebugLog.Log(category, defaultInterpolatedStringHandler2.ToStringAndClear());
					}
				}
				else
				{
					MelonLogger.Warning("[HUB - Graffiti] Sticker loading returned 0 stickers, will retry...");
				}
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(48, 2);
				defaultInterpolatedStringHandler3.AppendLiteral("[HUB - Graffiti] Sticker init error (attempt ");
				defaultInterpolatedStringHandler3.AppendFormatted<int>(StickerManager._initAttempts);
				defaultInterpolatedStringHandler3.AppendLiteral("): ");
				defaultInterpolatedStringHandler3.AppendFormatted(ex.Message);
				MelonLogger.Error(defaultInterpolatedStringHandler3.ToStringAndClear());
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004F84 File Offset: 0x00003184
		internal static void Reload()
		{
			StickerManager._stickers.Clear();
			StickerManager._initialized = false;
			StickerManager._initAttempts = 0;
			StickerManager.Initialize();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004FA1 File Offset: 0x000031A1
		[NullableContext(2)]
		internal static StickerData GetSticker(int index)
		{
			if (index < 0 || index >= StickerManager._stickers.Count)
			{
				return null;
			}
			return StickerManager._stickers[index];
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004FC4 File Offset: 0x000031C4
		[return: Nullable(2)]
		internal static StickerData FindByFileName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			for (int i = 0; i < StickerManager._stickers.Count; i++)
			{
				StickerData stickerData = StickerManager._stickers[i];
				if (string.Equals(stickerData.Name, name, StringComparison.OrdinalIgnoreCase))
				{
					return stickerData;
				}
			}
			DebugLog.Log("Stickers", "FindByFileName('" + name + "') failed. Loaded names:");
			for (int j = 0; j < StickerManager._stickers.Count; j++)
			{
				string category = "Stickers";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
				defaultInterpolatedStringHandler.AppendLiteral("  [");
				defaultInterpolatedStringHandler.AppendFormatted<int>(j);
				defaultInterpolatedStringHandler.AppendLiteral("] Name='");
				defaultInterpolatedStringHandler.AppendFormatted(StickerManager._stickers[j].Name);
				defaultInterpolatedStringHandler.AppendLiteral("' HasTex=");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(StickerManager._stickers[j].Texture != null);
				DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000050BC File Offset: 0x000032BC
		private static void LoadSticker(string filePath)
		{
			try
			{
				byte[] array = File.ReadAllBytes(filePath);
				Texture2D texture2D = new Texture2D(2, 2, 4, false);
				Il2CppStructArray<byte> il2CppStructArray = new Il2CppStructArray<byte>((long)array.Length);
				for (int i = 0; i < array.Length; i++)
				{
					il2CppStructArray[i] = array[i];
				}
				if (!ImageConversion.LoadImage(texture2D, il2CppStructArray))
				{
					DebugLog.Log("Stickers", "Failed to decode image: " + filePath);
				}
				else
				{
					texture2D.filterMode = 1;
					texture2D.wrapMode = 1;
					texture2D.hideFlags = 32;
					Sprite sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f);
					sprite.hideFlags = 32;
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
					StickerManager._stickers.Add(new StickerData
					{
						Name = fileNameWithoutExtension,
						FilePath = filePath,
						Texture = texture2D,
						Sprite = sprite
					});
				}
			}
			catch (Exception ex)
			{
				MelonLogger.Warning("[HUB - Graffiti] Failed to load sticker: " + Path.GetFileName(filePath) + " - " + ex.Message);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000051E8 File Offset: 0x000033E8
		private static void GenerateDefaultStickers()
		{
			string name = "01_HUB_Logo";
			Action<Texture2D> drawFunc;
			if ((drawFunc = StickerManager.<>O.<0>__DrawHubLogo) == null)
			{
				drawFunc = (StickerManager.<>O.<0>__DrawHubLogo = new Action<Texture2D>(StickerManager.DrawHubLogo));
			}
			StickerManager.Gen(name, drawFunc, Color.white);
			string name2 = "02_Smiley";
			Action<Texture2D> drawFunc2;
			if ((drawFunc2 = StickerManager.<>O.<1>__DrawSmiley) == null)
			{
				drawFunc2 = (StickerManager.<>O.<1>__DrawSmiley = new Action<Texture2D>(StickerManager.DrawSmiley));
			}
			StickerManager.Gen(name2, drawFunc2, new Color(1f, 0.85f, 0f, 1f));
			string name3 = "03_Skull";
			Action<Texture2D> drawFunc3;
			if ((drawFunc3 = StickerManager.<>O.<2>__DrawSkull) == null)
			{
				drawFunc3 = (StickerManager.<>O.<2>__DrawSkull = new Action<Texture2D>(StickerManager.DrawSkull));
			}
			StickerManager.Gen(name3, drawFunc3, Color.white);
			string name4 = "04_Crown";
			Action<Texture2D> drawFunc4;
			if ((drawFunc4 = StickerManager.<>O.<3>__DrawCrown) == null)
			{
				drawFunc4 = (StickerManager.<>O.<3>__DrawCrown = new Action<Texture2D>(StickerManager.DrawCrown));
			}
			StickerManager.Gen(name4, drawFunc4, new Color(1f, 0.8f, 0f, 1f));
			string name5 = "05_Heart";
			Action<Texture2D> drawFunc5;
			if ((drawFunc5 = StickerManager.<>O.<4>__DrawHeart) == null)
			{
				drawFunc5 = (StickerManager.<>O.<4>__DrawHeart = new Action<Texture2D>(StickerManager.DrawHeart));
			}
			StickerManager.Gen(name5, drawFunc5, new Color(0.9f, 0.1f, 0.2f, 1f));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005304 File Offset: 0x00003504
		private static void Gen(string name, Action<Texture2D> drawFunc, Color _unused)
		{
			try
			{
				Texture2D texture2D = new Texture2D(256, 256, 4, false);
				texture2D.SetPixels32(new Color32[65536]);
				drawFunc(texture2D);
				texture2D.Apply();
				Il2CppStructArray<byte> il2CppStructArray = ImageConversion.EncodeToPNG(texture2D);
				byte[] array = new byte[il2CppStructArray.Length];
				for (int i = 0; i < il2CppStructArray.Length; i++)
				{
					array[i] = il2CppStructArray[i];
				}
				File.WriteAllBytes(Path.Combine(StickerManager.StickerFolder, name + ".png"), array);
			}
			catch (Exception ex)
			{
				MelonLogger.Warning("[HUB - Graffiti] Failed to generate sticker: " + name + " - " + ex.Message);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000053C0 File Offset: 0x000035C0
		private static void FillCircle(Texture2D tex, int cx, int cy, int r, Color col)
		{
			int num = r * r;
			for (int i = cy - r; i <= cy + r; i++)
			{
				for (int j = cx - r; j <= cx + r; j++)
				{
					if (j >= 0 && j < tex.width && i >= 0 && i < tex.height)
					{
						int num2 = j - cx;
						int num3 = i - cy;
						if (num2 * num2 + num3 * num3 <= num)
						{
							tex.SetPixel(j, i, col);
						}
					}
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005425 File Offset: 0x00003625
		private static void Ring(Texture2D tex, int cx, int cy, int outer, int inner, Color col)
		{
			StickerManager.FillCircle(tex, cx, cy, outer, col);
			StickerManager.FillCircle(tex, cx, cy, inner, Color.clear);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005444 File Offset: 0x00003644
		private static void Line(Texture2D tex, int x0, int y0, int x1, int y1, int t, Color col)
		{
			int num = Math.Abs(x1 - x0);
			int num2 = Math.Abs(y1 - y0);
			int num3 = (x0 < x1) ? 1 : -1;
			int num4 = (y0 < y1) ? 1 : -1;
			int num5 = num - num2;
			for (;;)
			{
				StickerManager.FillCircle(tex, x0, y0, t / 2, col);
				if (x0 == x1 && y0 == y1)
				{
					break;
				}
				int num6 = 2 * num5;
				if (num6 > -num2)
				{
					num5 -= num2;
					x0 += num3;
				}
				if (num6 < num)
				{
					num5 += num;
					y0 += num4;
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000054B8 File Offset: 0x000036B8
		private static void FillRect(Texture2D tex, int x1, int y1, int x2, int y2, Color col)
		{
			for (int i = Math.Max(0, y1); i < Math.Min(tex.height, y2); i++)
			{
				for (int j = Math.Max(0, x1); j < Math.Min(tex.width, x2); j++)
				{
					tex.SetPixel(j, i, col);
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000550C File Offset: 0x0000370C
		private static void DrawHubLogo(Texture2D tex)
		{
			Color col;
			col..ctor(0.45f, 0.18f, 0.55f, 1f);
			Color col2;
			col2..ctor(1f, 1f, 1f, 0.95f);
			Color col3;
			col3..ctor(0.3f, 0.1f, 0.4f, 1f);
			int num = 128;
			StickerManager.FillCircle(tex, num, num, 120, col);
			StickerManager.FillCircle(tex, num, num, 105, col3);
			StickerManager.FillCircle(tex, num, num, 100, col);
			int t = 14;
			StickerManager.Line(tex, 70, 70, 70, 190, t, col2);
			StickerManager.Line(tex, 186, 70, 186, 190, t, col2);
			StickerManager.Line(tex, 70, 190, 128, 140, t, col2);
			StickerManager.Line(tex, 186, 190, 128, 140, t, col2);
			StickerManager.FillCircle(tex, 108, 55, 4, col2);
			StickerManager.FillCircle(tex, 128, 55, 4, col2);
			StickerManager.FillCircle(tex, 148, 55, 4, col2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005624 File Offset: 0x00003824
		private static void DrawSmiley(Texture2D tex)
		{
			Color col;
			col..ctor(1f, 0.85f, 0f, 1f);
			Color col2;
			col2..ctor(0.1f, 0.1f, 0.1f, 1f);
			int num = 128;
			StickerManager.FillCircle(tex, num, num, 110, col);
			StickerManager.FillCircle(tex, 90, 155, 16, col2);
			StickerManager.FillCircle(tex, 166, 155, 16, col2);
			for (int i = -140; i <= -40; i++)
			{
				double num2 = (double)i * 3.141592653589793 / 180.0;
				int cx = num + (int)(65.0 * Math.Cos(num2));
				int cy = num + (int)(65.0 * Math.Sin(num2));
				StickerManager.FillCircle(tex, cx, cy, 6, col2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000056FC File Offset: 0x000038FC
		private static void DrawSkull(Texture2D tex)
		{
			Color col;
			col..ctor(0.95f, 0.95f, 0.9f, 1f);
			Color col2;
			col2..ctor(0.15f, 0.15f, 0.2f, 1f);
			int cx = 128;
			StickerManager.FillCircle(tex, cx, 150, 70, col);
			StickerManager.FillRect(tex, 70, 80, 186, 150, col);
			StickerManager.FillRect(tex, 85, 68, 171, 90, col);
			StickerManager.FillCircle(tex, 110, 72, 20, col);
			StickerManager.FillCircle(tex, 146, 72, 20, col);
			StickerManager.FillCircle(tex, 102, 158, 20, col2);
			StickerManager.FillCircle(tex, 154, 158, 20, col2);
			StickerManager.FillCircle(tex, 128, 130, 8, col2);
			StickerManager.FillCircle(tex, 120, 125, 6, col2);
			for (int i = 0; i < 5; i++)
			{
				int num = 92 + i * 18;
				StickerManager.FillRect(tex, num, 80, num + 12, 100, col);
				StickerManager.FillRect(tex, num + 2, 82, num + 10, 98, col2);
			}
			StickerManager.Line(tex, 30, 30, 226, 230, 12, col);
			StickerManager.Line(tex, 226, 30, 30, 230, 12, col);
			StickerManager.FillCircle(tex, 30, 30, 14, col);
			StickerManager.FillCircle(tex, 226, 30, 14, col);
			StickerManager.FillCircle(tex, 30, 230, 14, col);
			StickerManager.FillCircle(tex, 226, 230, 14, col);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005884 File Offset: 0x00003A84
		private static void DrawCrown(Texture2D tex)
		{
			Color color;
			color..ctor(1f, 0.8f, 0f, 1f);
			Color col;
			col..ctor(0.85f, 0.6f, 0f, 1f);
			Color col2;
			col2..ctor(0.8f, 0.1f, 0.15f, 1f);
			int t = 10;
			StickerManager.FillRect(tex, 40, 60, 216, 100, color);
			StickerManager.Line(tex, 40, 100, 40, 180, t, color);
			StickerManager.Line(tex, 216, 100, 216, 180, t, color);
			StickerManager.Line(tex, 40, 180, 80, 140, t, color);
			StickerManager.Line(tex, 80, 140, 128, 210, t, color);
			StickerManager.Line(tex, 128, 210, 176, 140, t, color);
			StickerManager.Line(tex, 176, 140, 216, 180, t, color);
			for (int i = 100; i < 210; i++)
			{
				for (int j = 40; j < 216; j++)
				{
					float num = (float)(i - 100) / 110f;
					int num2 = 40;
					int num3 = 216;
					if (i > 140)
					{
						float num4 = ((float)i - 140f) / 70f;
					}
					if (j >= num2 && j <= num3 && i >= 60)
					{
						tex.SetPixel(j, i, color);
					}
				}
			}
			StickerManager.FillCircle(tex, 80, 80, 10, col2);
			StickerManager.FillCircle(tex, 128, 80, 10, col2);
			StickerManager.FillCircle(tex, 176, 80, 10, col2);
			StickerManager.Line(tex, 40, 60, 216, 60, 6, col);
			StickerManager.Line(tex, 40, 100, 216, 100, 4, col);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005A58 File Offset: 0x00003C58
		private static void DrawHeart(Texture2D tex)
		{
			Color col;
			col..ctor(0.9f, 0.1f, 0.2f, 1f);
			int num = 128;
			StickerManager.FillCircle(tex, 90, 165, 55, col);
			StickerManager.FillCircle(tex, 166, 165, 55, col);
			for (int i = 50; i <= 165; i++)
			{
				float num2 = (165f - (float)i) / 115f;
				int num3 = (int)(110f * (1f - num2));
				StickerManager.FillRect(tex, num - num3, i, num + num3, i + 1, col);
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly string StickerFolder = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti");

		// Token: 0x0400001C RID: 28
		private static readonly List<StickerData> _stickers = new List<StickerData>();

		// Token: 0x0400001D RID: 29
		private static bool _initialized;

		// Token: 0x0400001E RID: 30
		private static int _initAttempts;

		// Token: 0x0400001F RID: 31
		private const int MAX_INIT_ATTEMPTS = 5;

		// Token: 0x04000020 RID: 32
		private const int S = 256;

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400003B RID: 59
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<Texture2D> <0>__DrawHubLogo;

			// Token: 0x0400003C RID: 60
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<Texture2D> <1>__DrawSmiley;

			// Token: 0x0400003D RID: 61
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<Texture2D> <2>__DrawSkull;

			// Token: 0x0400003E RID: 62
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<Texture2D> <3>__DrawCrown;

			// Token: 0x0400003F RID: 63
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<Texture2D> <4>__DrawHeart;
		}
	}
}
