using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000549 RID: 1353
	[Serializable]
	public class CocaineAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007BBB RID: 31675 RVA: 0x00222BDC File Offset: 0x00220DDC
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineAppearanceSettings()
		{
			Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr);
			CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "MainColor");
			CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679186);
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679187);
			CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679188);
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00222C70 File Offset: 0x00220E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235897, XrefRangeEnd = 235898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00222CC8 File Offset: 0x00220EC8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00222D04 File Offset: 0x00220F04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 235898, RefRangeEnd = 235903, XrefRangeStart = 235898, XrefRangeEnd = 235898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x0003AF61 File Offset: 0x00039161
		public CocaineAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x00222D40 File Offset: 0x00220F40
		// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x0003AF6A File Offset: 0x0003916A
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x00222D68 File Offset: 0x00220F68
		// (set) Token: 0x06007BC3 RID: 31683 RVA: 0x0003AF85 File Offset: 0x00039185
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x0400544E RID: 21582
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x0400544F RID: 21583
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x04005450 RID: 21584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x04005451 RID: 21585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005452 RID: 21586
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
