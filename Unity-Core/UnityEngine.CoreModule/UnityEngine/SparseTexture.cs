using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020002F3 RID: 755
	public sealed class SparseTexture : Texture
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x00013ECF File Offset: 0x000120CF
		public int tileWidth
		{
			get
			{
				return SparseTexture.get_tileWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00013EE1 File Offset: 0x000120E1
		public int tileHeight
		{
			get
			{
				return SparseTexture.get_tileHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x00013EF3 File Offset: 0x000120F3
		public bool isCreated
		{
			get
			{
				return SparseTexture.get_isCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00013F05 File Offset: 0x00012105
		public static void Internal_Create(SparseTexture mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, int mipCount)
		{
			SparseTexture.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), width, height, format, colorSpace, mipCount);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00013F1E File Offset: 0x0001211E
		public void UpdateTile(int tileX, int tileY, int miplevel, Il2CppStructArray<Color32> data)
		{
			SparseTexture.UpdateTileDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00013F3A File Offset: 0x0001213A
		public void UpdateTileRaw(int tileX, int tileY, int miplevel, Il2CppStructArray<byte> data)
		{
			SparseTexture.UpdateTileRawDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00013F56 File Offset: 0x00012156
		public void UnloadTile(int tileX, int tileY, int miplevel)
		{
			this.UpdateTileRaw(tileX, tileY, miplevel, null);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000ABFD8 File Offset: 0x000AA1D8
		public bool ValidateFormat(TextureFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = TextureFormat.PVRTC_RGB2 <= format && format <= TextureFormat.PVRTC_RGBA4;
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000AC044 File Offset: 0x000AA244
		public bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format, UnityEngine.Experimental.Rendering.FormatUsage.Sparse);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPVRTCFormat(format);
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000AC0A8 File Offset: 0x000AA2A8
		public bool ValidateSize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			bool flag = (ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockSize(format) * (ulong)((long)width / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockWidth(format))) * (ulong)((long)height / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockHeight(format))) < 65536UL;
			bool result;
			if (flag)
			{
				Debug.LogError("SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", this);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000AC0F8 File Offset: 0x000AA2F8
		public static void ValidateIsNotCrunched(TextureFormat textureFormat)
		{
			bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCrunchFormat(textureFormat);
			if (flag)
			{
				throw new ArgumentException("Crunched SparseTexture is not supported.");
			}
		}

		// Token: 0x040027D4 RID: 10196
		private static readonly SparseTexture.get_tileWidthDelegate get_tileWidthDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileWidthDelegate>("UnityEngine.SparseTexture::get_tileWidth");

		// Token: 0x040027D5 RID: 10197
		private static readonly SparseTexture.get_tileHeightDelegate get_tileHeightDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileHeightDelegate>("UnityEngine.SparseTexture::get_tileHeight");

		// Token: 0x040027D6 RID: 10198
		private static readonly SparseTexture.get_isCreatedDelegate get_isCreatedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_isCreatedDelegate>("UnityEngine.SparseTexture::get_isCreated");

		// Token: 0x040027D7 RID: 10199
		private static readonly SparseTexture.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<SparseTexture.Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");

		// Token: 0x040027D8 RID: 10200
		private static readonly SparseTexture.UpdateTileDelegate UpdateTileDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileDelegate>("UnityEngine.SparseTexture::UpdateTile");

		// Token: 0x040027D9 RID: 10201
		private static readonly SparseTexture.UpdateTileRawDelegate UpdateTileRawDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileRawDelegate>("UnityEngine.SparseTexture::UpdateTileRaw");

		// Token: 0x02000CB5 RID: 3253
		// (Invoke) Token: 0x06004207 RID: 16903
		private delegate int get_tileWidthDelegate(IntPtr @this);

		// Token: 0x02000CB6 RID: 3254
		// (Invoke) Token: 0x06004209 RID: 16905
		private delegate int get_tileHeightDelegate(IntPtr @this);

		// Token: 0x02000CB7 RID: 3255
		// (Invoke) Token: 0x0600420B RID: 16907
		private delegate bool get_isCreatedDelegate(IntPtr @this);

		// Token: 0x02000CB8 RID: 3256
		// (Invoke) Token: 0x0600420D RID: 16909
		private delegate void Internal_CreateDelegate(IntPtr mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, int mipCount);

		// Token: 0x02000CB9 RID: 3257
		// (Invoke) Token: 0x0600420F RID: 16911
		private delegate void UpdateTileDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);

		// Token: 0x02000CBA RID: 3258
		// (Invoke) Token: 0x06004211 RID: 16913
		private delegate void UpdateTileRawDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);
	}
}
