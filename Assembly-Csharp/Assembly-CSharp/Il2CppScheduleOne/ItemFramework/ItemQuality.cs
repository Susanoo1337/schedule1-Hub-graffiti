using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000354 RID: 852
	public static class ItemQuality : Il2CppSystem.Object
	{
		// Token: 0x06004837 RID: 18487 RVA: 0x00170A58 File Offset: 0x0016EC58
		// Note: this type is marked as 'beforefieldinit'.
		static ItemQuality()
		{
			Il2CppClassPointerStore<ItemQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr);
			ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Threshold");
			ItemQuality.NativeFieldInfoPtr_Premium_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Threshold");
			ItemQuality.NativeFieldInfoPtr_Standard_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Threshold");
			ItemQuality.NativeFieldInfoPtr_Poor_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Threshold");
			ItemQuality.NativeFieldInfoPtr_Heavenly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Color");
			ItemQuality.NativeFieldInfoPtr_Premium_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Color");
			ItemQuality.NativeFieldInfoPtr_Standard_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Color");
			ItemQuality.NativeFieldInfoPtr_Poor_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Color");
			ItemQuality.NativeFieldInfoPtr_Trash_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Trash_Color");
			ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100672549);
			ItemQuality.NativeMethodInfoPtr_ShiftQuality_Public_Static_EQuality_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100672550);
			ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100672551);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00170B78 File Offset: 0x0016ED78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167638, RefRangeEnd = 167641, XrefRangeStart = 167638, XrefRangeEnd = 167638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetQuality(float qualityScalar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qualityScalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00170BB8 File Offset: 0x0016EDB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167652, RefRangeEnd = 167655, XrefRangeStart = 167641, XrefRangeEnd = 167652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality ShiftQuality(EQuality baseQuality, int shiftAmount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref baseQuality;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_ShiftQuality_Public_Static_EQuality_EQuality_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x00170C04 File Offset: 0x0016EE04
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 167662, RefRangeEnd = 167671, XrefRangeStart = 167655, XrefRangeEnd = 167662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x000232C7 File Offset: 0x000214C7
		public ItemQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x00170C44 File Offset: 0x0016EE44
		// (set) Token: 0x0600483D RID: 18493 RVA: 0x000232D0 File Offset: 0x000214D0
		public unsafe static float Heavenly_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x00170C60 File Offset: 0x0016EE60
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x000232DE File Offset: 0x000214DE
		public unsafe static float Premium_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x00170C7C File Offset: 0x0016EE7C
		// (set) Token: 0x06004841 RID: 18497 RVA: 0x000232EC File Offset: 0x000214EC
		public unsafe static float Standard_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x00170C98 File Offset: 0x0016EE98
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x000232FA File Offset: 0x000214FA
		public unsafe static float Poor_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x00170CB4 File Offset: 0x0016EEB4
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x00023308 File Offset: 0x00021508
		public unsafe static Color Heavenly_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&value));
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x00170CD0 File Offset: 0x0016EED0
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x00023316 File Offset: 0x00021516
		public unsafe static Color Premium_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&value));
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x00170CEC File Offset: 0x0016EEEC
		// (set) Token: 0x06004849 RID: 18505 RVA: 0x00023324 File Offset: 0x00021524
		public unsafe static Color Standard_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&value));
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x00170D08 File Offset: 0x0016EF08
		// (set) Token: 0x0600484B RID: 18507 RVA: 0x00023332 File Offset: 0x00021532
		public unsafe static Color Poor_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&value));
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x00170D24 File Offset: 0x0016EF24
		// (set) Token: 0x0600484D RID: 18509 RVA: 0x00023340 File Offset: 0x00021540
		public unsafe static Color Trash_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&value));
			}
		}

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Threshold;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Threshold;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Threshold;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Threshold;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Color;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Color;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Color;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Color;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeFieldInfoPtr_Trash_Color;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeMethodInfoPtr_ShiftQuality_Public_Static_EQuality_EQuality_Int32_0;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0;
	}
}
