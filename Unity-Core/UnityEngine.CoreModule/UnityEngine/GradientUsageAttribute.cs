using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000113 RID: 275
	public sealed class GradientUsageAttribute : PropertyAttribute
	{
		// Token: 0x060016B8 RID: 5816 RVA: 0x000630D8 File Offset: 0x000612D8
		// Note: this type is marked as 'beforefieldinit'.
		static GradientUsageAttribute()
		{
			Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr);
			GradientUsageAttribute.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr, "hdr");
			GradientUsageAttribute.NativeFieldInfoPtr_colorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr, "colorSpace");
			GradientUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr, 100665680);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00063144 File Offset: 0x00061344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246065, XrefRangeEnd = 1246066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientUsageAttribute(bool hdr, ColorSpace colorSpace) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientUsageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hdr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0000B676 File Offset: 0x00009876
		public GradientUsageAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0006319C File Offset: 0x0006139C
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x0000B67F File Offset: 0x0000987F
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientUsageAttribute.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientUsageAttribute.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x000631C4 File Offset: 0x000613C4
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000B69A File Offset: 0x0000989A
		public unsafe ColorSpace colorSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientUsageAttribute.NativeFieldInfoPtr_colorSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientUsageAttribute.NativeFieldInfoPtr_colorSpace)) = value;
			}
		}

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeFieldInfoPtr_colorSpace;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_ColorSpace_0;
	}
}
