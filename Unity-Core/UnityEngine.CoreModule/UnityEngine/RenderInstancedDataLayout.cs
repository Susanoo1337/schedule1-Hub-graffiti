using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A0 RID: 160
	[StructLayout(2)]
	public struct RenderInstancedDataLayout
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x00035F48 File Offset: 0x00034148
		// Note: this type is marked as 'beforefieldinit'.
		static RenderInstancedDataLayout()
		{
			Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderInstancedDataLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr);
			RenderInstancedDataLayout.NativeFieldInfoPtr__size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<size>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetObjectToWorld>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetPrevObjectToWorld>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetRenderingLayerMask>k__BackingField");
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0000623A File Offset: 0x0000443A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, ref this));
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0000624C File Offset: 0x0000444C
		public int size
		{
			get
			{
				return this._size_k__BackingField;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00006254 File Offset: 0x00004454
		public int offsetObjectToWorld
		{
			get
			{
				return this._offsetObjectToWorld_k__BackingField;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0000625C File Offset: 0x0000445C
		public int offsetPrevObjectToWorld
		{
			get
			{
				return this._offsetPrevObjectToWorld_k__BackingField;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00006264 File Offset: 0x00004464
		public int offsetRenderingLayerMask
		{
			get
			{
				return this._offsetRenderingLayerMask_k__BackingField;
			}
		}

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr__size_k__BackingField;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField;

		// Token: 0x04000786 RID: 1926
		[FieldOffset(0)]
		public readonly int _size_k__BackingField;

		// Token: 0x04000787 RID: 1927
		[FieldOffset(4)]
		public readonly int _offsetObjectToWorld_k__BackingField;

		// Token: 0x04000788 RID: 1928
		[FieldOffset(8)]
		public readonly int _offsetPrevObjectToWorld_k__BackingField;

		// Token: 0x04000789 RID: 1929
		[FieldOffset(12)]
		public readonly int _offsetRenderingLayerMask_k__BackingField;
	}
}
