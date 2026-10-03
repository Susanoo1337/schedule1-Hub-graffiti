using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000564 RID: 1380
	[Serializable]
	public class ShroomAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007E52 RID: 32338 RVA: 0x0022D8F8 File Offset: 0x0022BAF8
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomAppearanceSettings()
		{
			Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ShroomAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr);
			ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultPrimaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "DefaultPrimaryColor");
			ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "DefaultSecondaryColor");
			ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSpotsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "DefaultSpotsColor");
			ShroomAppearanceSettings.NativeFieldInfoPtr__PrimaryColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "<PrimaryColor>k__BackingField");
			ShroomAppearanceSettings.NativeFieldInfoPtr__SecondaryColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "<SecondaryColor>k__BackingField");
			ShroomAppearanceSettings.NativeFieldInfoPtr__HasSpots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "<HasSpots>k__BackingField");
			ShroomAppearanceSettings.NativeFieldInfoPtr__SpotsColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, "<SpotsColor>k__BackingField");
			ShroomAppearanceSettings.NativeMethodInfoPtr_get_PrimaryColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679598);
			ShroomAppearanceSettings.NativeMethodInfoPtr_set_PrimaryColor_Private_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679599);
			ShroomAppearanceSettings.NativeMethodInfoPtr_get_SecondaryColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679600);
			ShroomAppearanceSettings.NativeMethodInfoPtr_set_SecondaryColor_Private_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679601);
			ShroomAppearanceSettings.NativeMethodInfoPtr_get_HasSpots_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679602);
			ShroomAppearanceSettings.NativeMethodInfoPtr_set_HasSpots_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679603);
			ShroomAppearanceSettings.NativeMethodInfoPtr_get_SpotsColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679604);
			ShroomAppearanceSettings.NativeMethodInfoPtr_set_SpotsColor_Private_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679605);
			ShroomAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679606);
			ShroomAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679607);
			ShroomAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr, 100679608);
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06007E53 RID: 32339 RVA: 0x0022DA90 File Offset: 0x0022BC90
		// (set) Token: 0x06007E54 RID: 32340 RVA: 0x0022DACC File Offset: 0x0022BCCC
		public unsafe Color32 PrimaryColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_get_PrimaryColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_set_PrimaryColor_Private_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06007E55 RID: 32341 RVA: 0x0022DB0C File Offset: 0x0022BD0C
		// (set) Token: 0x06007E56 RID: 32342 RVA: 0x0022DB48 File Offset: 0x0022BD48
		public unsafe Color32 SecondaryColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_get_SecondaryColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 168968, RefRangeEnd = 168976, XrefRangeStart = 168968, XrefRangeEnd = 168976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_set_SecondaryColor_Private_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x0022DB88 File Offset: 0x0022BD88
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x0022DBC4 File Offset: 0x0022BDC4
		public unsafe bool HasSpots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_get_HasSpots_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 192743, RefRangeEnd = 192745, XrefRangeStart = 192743, XrefRangeEnd = 192745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_set_HasSpots_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x0022DC04 File Offset: 0x0022BE04
		// (set) Token: 0x06007E5A RID: 32346 RVA: 0x0022DC40 File Offset: 0x0022BE40
		public unsafe Color32 SpotsColor
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_get_SpotsColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_set_SpotsColor_Private_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x0022DC80 File Offset: 0x0022BE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241898, XrefRangeEnd = 241899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomAppearanceSettings(Color32 primary, Color32 secondary, bool hasSpots, Color32 spotsColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref primary;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondary;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasSpots;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotsColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Boolean_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x0022DCF4 File Offset: 0x0022BEF4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0022DD30 File Offset: 0x0022BF30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 235898, RefRangeEnd = 235903, XrefRangeStart = 235898, XrefRangeEnd = 235903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0003BF6D File Offset: 0x0003A16D
		public ShroomAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x0022DD6C File Offset: 0x0022BF6C
		// (set) Token: 0x06007E60 RID: 32352 RVA: 0x0003BF76 File Offset: 0x0003A176
		public unsafe static Color32 DefaultPrimaryColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultPrimaryColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultPrimaryColor, (void*)(&value));
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x0022DD88 File Offset: 0x0022BF88
		// (set) Token: 0x06007E62 RID: 32354 RVA: 0x0003BF84 File Offset: 0x0003A184
		public unsafe static Color32 DefaultSecondaryColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSecondaryColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSecondaryColor, (void*)(&value));
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0022DDA4 File Offset: 0x0022BFA4
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x0003BF92 File Offset: 0x0003A192
		public unsafe static Color32 DefaultSpotsColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSpotsColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomAppearanceSettings.NativeFieldInfoPtr_DefaultSpotsColor, (void*)(&value));
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0022DDC0 File Offset: 0x0022BFC0
		// (set) Token: 0x06007E66 RID: 32358 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
		public unsafe Color32 _PrimaryColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__PrimaryColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__PrimaryColor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x0022DDE8 File Offset: 0x0022BFE8
		// (set) Token: 0x06007E68 RID: 32360 RVA: 0x0003BFBB File Offset: 0x0003A1BB
		public unsafe Color32 _SecondaryColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__SecondaryColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__SecondaryColor_k__BackingField)) = value;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x0022DE10 File Offset: 0x0022C010
		// (set) Token: 0x06007E6A RID: 32362 RVA: 0x0003BFD6 File Offset: 0x0003A1D6
		public unsafe bool _HasSpots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__HasSpots_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__HasSpots_k__BackingField)) = value;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0022DE38 File Offset: 0x0022C038
		// (set) Token: 0x06007E6C RID: 32364 RVA: 0x0003BFF1 File Offset: 0x0003A1F1
		public unsafe Color32 _SpotsColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__SpotsColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomAppearanceSettings.NativeFieldInfoPtr__SpotsColor_k__BackingField)) = value;
			}
		}

		// Token: 0x04005644 RID: 22084
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPrimaryColor;

		// Token: 0x04005645 RID: 22085
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSecondaryColor;

		// Token: 0x04005646 RID: 22086
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSpotsColor;

		// Token: 0x04005647 RID: 22087
		private static readonly IntPtr NativeFieldInfoPtr__PrimaryColor_k__BackingField;

		// Token: 0x04005648 RID: 22088
		private static readonly IntPtr NativeFieldInfoPtr__SecondaryColor_k__BackingField;

		// Token: 0x04005649 RID: 22089
		private static readonly IntPtr NativeFieldInfoPtr__HasSpots_k__BackingField;

		// Token: 0x0400564A RID: 22090
		private static readonly IntPtr NativeFieldInfoPtr__SpotsColor_k__BackingField;

		// Token: 0x0400564B RID: 22091
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryColor_Public_get_Color32_0;

		// Token: 0x0400564C RID: 22092
		private static readonly IntPtr NativeMethodInfoPtr_set_PrimaryColor_Private_set_Void_Color32_0;

		// Token: 0x0400564D RID: 22093
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondaryColor_Public_get_Color32_0;

		// Token: 0x0400564E RID: 22094
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondaryColor_Private_set_Void_Color32_0;

		// Token: 0x0400564F RID: 22095
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpots_Public_get_Boolean_0;

		// Token: 0x04005650 RID: 22096
		private static readonly IntPtr NativeMethodInfoPtr_set_HasSpots_Private_set_Void_Boolean_0;

		// Token: 0x04005651 RID: 22097
		private static readonly IntPtr NativeMethodInfoPtr_get_SpotsColor_Public_get_Color32_0;

		// Token: 0x04005652 RID: 22098
		private static readonly IntPtr NativeMethodInfoPtr_set_SpotsColor_Private_set_Void_Color32_0;

		// Token: 0x04005653 RID: 22099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Boolean_Color32_0;

		// Token: 0x04005654 RID: 22100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005655 RID: 22101
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
