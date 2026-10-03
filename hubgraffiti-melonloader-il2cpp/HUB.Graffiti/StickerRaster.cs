using System;
using UnityEngine;

namespace HUB.Graffiti
{
	/// <summary>
	/// Managed pixel helpers used to bake sticker PNGs into decal textures.
	/// Buffers are row-major with row 0 at the bottom, matching Texture2D.GetPixels32/SetPixels32.
	/// </summary>
	internal static class StickerRaster
	{
		/// <summary>
		/// Draws <paramref name="src"/> into <paramref name="dst"/> scaled to the destination rectangle
		/// (x, y, w, h), in destination pixels. Upscaling is bilinear; downscaling supersamples the source
		/// footprint so large PNGs don't alias. Filtering happens in premultiplied alpha so transparent
		/// pixels don't bleed dark fringes into the sticker's edges. Destination pixels the sticker
		/// doesn't cover are left untouched.
		/// </summary>
		internal static void DrawScaled(Color32[] src, int srcW, int srcH, Color32[] dst, int dstW, int dstH, float x, float y, float w, float h)
		{
			if (src == null || dst == null || srcW <= 0 || srcH <= 0 || w <= 0f || h <= 0f)
			{
				return;
			}
			if (src.Length < srcW * srcH || dst.Length < dstW * dstH)
			{
				throw new ArgumentException("Pixel buffer is smaller than its stated dimensions");
			}

			float scaleX = srcW / w;
			float scaleY = srcH / h;
			int tapsX = Math.Max(1, (int)Math.Ceiling(scaleX));
			int tapsY = Math.Max(1, (int)Math.Ceiling(scaleY));
			float invTaps = 1f / (tapsX * tapsY);

			int x0 = Math.Max(0, (int)Math.Floor(x));
			int y0 = Math.Max(0, (int)Math.Floor(y));
			int x1 = Math.Min(dstW, (int)Math.Ceiling(x + w));
			int y1 = Math.Min(dstH, (int)Math.Ceiling(y + h));

			for (int dy = y0; dy < y1; dy++)
			{
				int rowOffset = dy * dstW;
				for (int dx = x0; dx < x1; dx++)
				{
					float r = 0f, g = 0f, b = 0f, a = 0f;
					for (int ty = 0; ty < tapsY; ty++)
					{
						float sy = (dy + (ty + 0.5f) / tapsY - y) * scaleY - 0.5f;
						for (int tx = 0; tx < tapsX; tx++)
						{
							float sx = (dx + (tx + 0.5f) / tapsX - x) * scaleX - 0.5f;
							SampleBilinear(src, srcW, srcH, sx, sy, ref r, ref g, ref b, ref a);
						}
					}

					a *= invTaps;
					if (a < 0.5f / 255f)
					{
						continue;
					}
					r *= invTaps;
					g *= invTaps;
					b *= invTaps;
					dst[rowOffset + dx] = new Color32(ToByte(r / a), ToByte(g / a), ToByte(b / a), ToByte(a));
				}
			}
		}

		/// <summary>
		/// Gives fully transparent pixels the average colour of the visible ones. Mipmapping averages
		/// RGB without regard to alpha, so leaving transparent pixels black would darken the sticker's
		/// outline when it's seen from a distance.
		/// </summary>
		internal static void FillTransparentWithAverage(Color32[] pixels)
		{
			long r = 0, g = 0, b = 0, weight = 0;
			for (int i = 0; i < pixels.Length; i++)
			{
				Color32 c = pixels[i];
				if (c.a == 0)
				{
					continue;
				}
				r += c.r * c.a;
				g += c.g * c.a;
				b += c.b * c.a;
				weight += c.a;
			}
			if (weight == 0)
			{
				return;
			}
			Color32 fill = new Color32((byte)(r / weight), (byte)(g / weight), (byte)(b / weight), 0);
			for (int i = 0; i < pixels.Length; i++)
			{
				if (pixels[i].a == 0)
				{
					pixels[i] = fill;
				}
			}
		}

		// Accumulates one bilinear sample (premultiplied). Texels outside the source count as transparent,
		// which gives the sticker's rectangle a clean anti-aliased border instead of smeared edge pixels.
		private static void SampleBilinear(Color32[] src, int srcW, int srcH, float sx, float sy, ref float r, ref float g, ref float b, ref float a)
		{
			int ix = (int)Math.Floor(sx);
			int iy = (int)Math.Floor(sy);
			float fx = sx - ix;
			float fy = sy - iy;
			Accumulate(src, srcW, srcH, ix, iy, (1f - fx) * (1f - fy), ref r, ref g, ref b, ref a);
			Accumulate(src, srcW, srcH, ix + 1, iy, fx * (1f - fy), ref r, ref g, ref b, ref a);
			Accumulate(src, srcW, srcH, ix, iy + 1, (1f - fx) * fy, ref r, ref g, ref b, ref a);
			Accumulate(src, srcW, srcH, ix + 1, iy + 1, fx * fy, ref r, ref g, ref b, ref a);
		}

		private static void Accumulate(Color32[] src, int srcW, int srcH, int px, int py, float weight, ref float r, ref float g, ref float b, ref float a)
		{
			if (weight <= 0f || px < 0 || py < 0 || px >= srcW || py >= srcH)
			{
				return;
			}
			Color32 c = src[py * srcW + px];
			float ca = c.a * (1f / 255f) * weight;
			r += c.r * (1f / 255f) * ca;
			g += c.g * (1f / 255f) * ca;
			b += c.b * (1f / 255f) * ca;
			a += ca;
		}

		private static byte ToByte(float v)
		{
			if (v <= 0f)
			{
				return 0;
			}
			if (v >= 1f)
			{
				return 255;
			}
			return (byte)(v * 255f + 0.5f);
		}
	}
}
