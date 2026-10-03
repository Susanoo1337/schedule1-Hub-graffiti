using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x020000E2 RID: 226
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x060015E2 RID: 5602 RVA: 0x000C4374 File Offset: 0x000C2574
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleColors()
		{
			Il2CppClassPointerStore<VehicleColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleColors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr);
			VehicleColors.NativeFieldInfoPtr_colorLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "colorLibrary");
			VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100666359);
			VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100666360);
			VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100666361);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000C43F4 File Offset: 0x000C25F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95254, XrefRangeEnd = 95267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColorName(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x000C4438 File Offset: 0x000C2638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95267, XrefRangeEnd = 95280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetColorUIColor(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000C4484 File Offset: 0x000C2684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95280, XrefRangeEnd = 95290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleColors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0000BFE6 File Offset: 0x0000A1E6
		public VehicleColors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000C44C0 File Offset: 0x000C26C0
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000BFEF File Offset: 0x0000A1EF
		public unsafe List<VehicleColors.VehicleColorData> colorLibrary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleColors.VehicleColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeFieldInfoPtr_colorLibrary;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000922 RID: 2338
		[Serializable]
		public class VehicleColorData : Il2CppSystem.Object
		{
			// Token: 0x0600D758 RID: 55128 RVA: 0x0035981C File Offset: 0x00357A1C
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleColorData()
			{
				Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "VehicleColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr);
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "color");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "colorName");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_MaterialColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "MaterialColor");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "UIColor");
				VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, 100666362);
			}

			// Token: 0x0600D759 RID: 55129 RVA: 0x003598AC File Offset: 0x00357AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95252, XrefRangeEnd = 95254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D75A RID: 55130 RVA: 0x000652CD File Offset: 0x000634CD
			public VehicleColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C4 RID: 16836
			// (get) Token: 0x0600D75B RID: 55131 RVA: 0x003598E8 File Offset: 0x00357AE8
			// (set) Token: 0x0600D75C RID: 55132 RVA: 0x000652D6 File Offset: 0x000634D6
			public unsafe EVehicleColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170041C5 RID: 16837
			// (get) Token: 0x0600D75D RID: 55133 RVA: 0x00359910 File Offset: 0x00357B10
			// (set) Token: 0x0600D75E RID: 55134 RVA: 0x000652F1 File Offset: 0x000634F1
			public unsafe string colorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041C6 RID: 16838
			// (get) Token: 0x0600D75F RID: 55135 RVA: 0x00359938 File Offset: 0x00357B38
			// (set) Token: 0x0600D760 RID: 55136 RVA: 0x00065310 File Offset: 0x00063510
			public unsafe Color MaterialColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_MaterialColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_MaterialColor)) = value;
				}
			}

			// Token: 0x170041C7 RID: 16839
			// (get) Token: 0x0600D761 RID: 55137 RVA: 0x00359960 File Offset: 0x00357B60
			// (set) Token: 0x0600D762 RID: 55138 RVA: 0x0006532B File Offset: 0x0006352B
			public unsafe Color32 UIColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor)) = value;
				}
			}

			// Token: 0x040092CD RID: 37581
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040092CE RID: 37582
			private static readonly IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x040092CF RID: 37583
			private static readonly IntPtr NativeFieldInfoPtr_MaterialColor;

			// Token: 0x040092D0 RID: 37584
			private static readonly IntPtr NativeFieldInfoPtr_UIColor;

			// Token: 0x040092D1 RID: 37585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000923 RID: 2339
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D763 RID: 55139 RVA: 0x00359988 File Offset: 0x00357B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100666363);
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100666364);
			}

			// Token: 0x0600D764 RID: 55140 RVA: 0x003599F0 File Offset: 0x00357BF0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D765 RID: 55141 RVA: 0x00359A2C File Offset: 0x00357C2C
			[CallerCount(0)]
			public unsafe bool _GetColorName_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D766 RID: 55142 RVA: 0x00065346 File Offset: 0x00063546
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C8 RID: 16840
			// (get) Token: 0x0600D767 RID: 55143 RVA: 0x00359A7C File Offset: 0x00357C7C
			// (set) Token: 0x0600D768 RID: 55144 RVA: 0x0006534F File Offset: 0x0006354F
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x040092D2 RID: 37586
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040092D3 RID: 37587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092D4 RID: 37588
			private static readonly IntPtr NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D769 RID: 55145 RVA: 0x00359AA4 File Offset: 0x00357CA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100666365);
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100666366);
			}

			// Token: 0x0600D76A RID: 55146 RVA: 0x00359B0C File Offset: 0x00357D0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D76B RID: 55147 RVA: 0x00359B48 File Offset: 0x00357D48
			[CallerCount(0)]
			public unsafe bool _GetColorUIColor_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D76C RID: 55148 RVA: 0x0006536A File Offset: 0x0006356A
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C9 RID: 16841
			// (get) Token: 0x0600D76D RID: 55149 RVA: 0x00359B98 File Offset: 0x00357D98
			// (set) Token: 0x0600D76E RID: 55150 RVA: 0x00065373 File Offset: 0x00063573
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x040092D5 RID: 37589
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040092D6 RID: 37590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092D7 RID: 37591
			private static readonly IntPtr NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0;
		}
	}
}
