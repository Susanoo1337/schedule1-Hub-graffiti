using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200056D RID: 1389
	[Serializable]
	public class WeedAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007EC8 RID: 32456 RVA: 0x0022F48C File Offset: 0x0022D68C
		// Note: this type is marked as 'beforefieldinit'.
		static WeedAppearanceSettings()
		{
			Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr);
			WeedAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "MainColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "LeafColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_StemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "StemColor");
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679669);
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679670);
			WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679671);
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x0022F548 File Offset: 0x0022D748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242460, RefRangeEnd = 242461, XrefRangeStart = 242459, XrefRangeEnd = 242460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stemColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x0022F5BC File Offset: 0x0022D7BC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x0022F5F8 File Offset: 0x0022D7F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242461, RefRangeEnd = 242462, XrefRangeStart = 242461, XrefRangeEnd = 242461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x0003C1F9 File Offset: 0x0003A3F9
		public WeedAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x06007ECD RID: 32461 RVA: 0x0022F634 File Offset: 0x0022D834
		// (set) Token: 0x06007ECE RID: 32462 RVA: 0x0003C202 File Offset: 0x0003A402
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x06007ECF RID: 32463 RVA: 0x0022F65C File Offset: 0x0022D85C
		// (set) Token: 0x06007ED0 RID: 32464 RVA: 0x0003C21D File Offset: 0x0003A41D
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06007ED1 RID: 32465 RVA: 0x0022F684 File Offset: 0x0022D884
		// (set) Token: 0x06007ED2 RID: 32466 RVA: 0x0003C238 File Offset: 0x0003A438
		public unsafe Color32 LeafColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor)) = value;
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06007ED3 RID: 32467 RVA: 0x0022F6AC File Offset: 0x0022D8AC
		// (set) Token: 0x06007ED4 RID: 32468 RVA: 0x0003C253 File Offset: 0x0003A453
		public unsafe Color32 StemColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor)) = value;
			}
		}

		// Token: 0x04005693 RID: 22163
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x04005694 RID: 22164
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x04005695 RID: 22165
		private static readonly IntPtr NativeFieldInfoPtr_LeafColor;

		// Token: 0x04005696 RID: 22166
		private static readonly IntPtr NativeFieldInfoPtr_StemColor;

		// Token: 0x04005697 RID: 22167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0;

		// Token: 0x04005698 RID: 22168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005699 RID: 22169
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;

		// Token: 0x02000BE4 RID: 3044
		[OriginalName("Assembly-CSharp.dll", "", "EWeedAppearanceType")]
		public enum EWeedAppearanceType
		{
			// Token: 0x0400A01F RID: 40991
			Main,
			// Token: 0x0400A020 RID: 40992
			Secondary,
			// Token: 0x0400A021 RID: 40993
			Leaf,
			// Token: 0x0400A022 RID: 40994
			Stem
		}
	}
}
