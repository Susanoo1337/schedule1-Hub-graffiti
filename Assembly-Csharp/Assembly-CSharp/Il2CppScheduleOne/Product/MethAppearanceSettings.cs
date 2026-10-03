using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000553 RID: 1363
	[Serializable]
	public class MethAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007C0A RID: 31754 RVA: 0x00223DD0 File Offset: 0x00221FD0
		// Note: this type is marked as 'beforefieldinit'.
		static MethAppearanceSettings()
		{
			Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr);
			MethAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "MainColor");
			MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679226);
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679227);
			MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679228);
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00223E64 File Offset: 0x00222064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x00223EBC File Offset: 0x002220BC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x00223EF8 File Offset: 0x002220F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 235898, RefRangeEnd = 235903, XrefRangeStart = 235898, XrefRangeEnd = 235903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x0003B10F File Offset: 0x0003930F
		public MethAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06007C0F RID: 31759 RVA: 0x00223F34 File Offset: 0x00222134
		// (set) Token: 0x06007C10 RID: 31760 RVA: 0x0003B118 File Offset: 0x00039318
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x06007C11 RID: 31761 RVA: 0x00223F5C File Offset: 0x0022215C
		// (set) Token: 0x06007C12 RID: 31762 RVA: 0x0003B133 File Offset: 0x00039333
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x04005499 RID: 21657
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x0400549A RID: 21658
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x0400549B RID: 21659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x0400549C RID: 21660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400549D RID: 21661
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
