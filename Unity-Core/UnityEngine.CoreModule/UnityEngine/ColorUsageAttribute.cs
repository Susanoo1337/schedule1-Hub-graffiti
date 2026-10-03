using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000112 RID: 274
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		// Token: 0x060016A8 RID: 5800 RVA: 0x00062E78 File Offset: 0x00061078
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUsageAttribute()
		{
			Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr);
			ColorUsageAttribute.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "showAlpha");
			ColorUsageAttribute.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "hdr");
			ColorUsageAttribute.NativeFieldInfoPtr_minBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minExposureValue");
			ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxExposureValue");
			ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100665678);
			ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100665679);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00062F48 File Offset: 0x00061148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246063, XrefRangeEnd = 1246064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorUsageAttribute(bool showAlpha) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00062F90 File Offset: 0x00061190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246064, XrefRangeEnd = 1246065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorUsageAttribute(bool showAlpha, bool hdr) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showAlpha;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0000B5CB File Offset: 0x000097CB
		public ColorUsageAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00062FE8 File Offset: 0x000611E8
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x0000B5D4 File Offset: 0x000097D4
		public unsafe bool showAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha)) = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00063010 File Offset: 0x00061210
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x0000B5EF File Offset: 0x000097EF
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00063038 File Offset: 0x00061238
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x0000B60A File Offset: 0x0000980A
		public unsafe float minBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00063060 File Offset: 0x00061260
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000B625 File Offset: 0x00009825
		public unsafe float maxBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00063088 File Offset: 0x00061288
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000B640 File Offset: 0x00009840
		public unsafe float minExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000630B0 File Offset: 0x000612B0
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0000B65B File Offset: 0x0000985B
		public unsafe float maxExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue)) = value;
			}
		}

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeFieldInfoPtr_minBrightness;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_maxBrightness;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_minExposureValue;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_maxExposureValue;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;
	}
}
