using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000110 RID: 272
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x0600169C RID: 5788 RVA: 0x00062CA8 File Offset: 0x00060EA8
		// Note: this type is marked as 'beforefieldinit'.
		static MultilineAttribute()
		{
			Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MultilineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr);
			MultilineAttribute.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, "lines");
			MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100665676);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00062D00 File Offset: 0x00060F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246062, XrefRangeEnd = 1246063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultilineAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000B568 File Offset: 0x00009768
		public MultilineAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00062D3C File Offset: 0x00060F3C
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0000B571 File Offset: 0x00009771
		public unsafe int lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines)) = value;
			}
		}

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeFieldInfoPtr_lines;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
