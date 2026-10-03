using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E6 RID: 742
	public class NumberField : ConfigField
	{
		// Token: 0x06003AC9 RID: 15049 RVA: 0x00140D78 File Offset: 0x0013EF78
		// Note: this type is marked as 'beforefieldinit'.
		static NumberField()
		{
			Il2CppClassPointerStore<NumberField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NumberField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberField>.NativeClassPtr);
			NumberField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<Value>k__BackingField");
			NumberField.NativeFieldInfoPtr__MinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MinValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MaxValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<WholeNumbers>k__BackingField");
			NumberField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "onItemChanged");
			NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670819);
			NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670820);
			NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670821);
			NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670822);
			NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670823);
			NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670824);
			NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670825);
			NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670826);
			NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670827);
			NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670828);
			NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670829);
			NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670830);
			NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670831);
			NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100670832);
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x00140F24 File Offset: 0x0013F124
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x00140F60 File Offset: 0x0013F160
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 149236, RefRangeEnd = 149240, XrefRangeStart = 149236, XrefRangeEnd = 149236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00140FA0 File Offset: 0x0013F1A0
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x00140FDC File Offset: 0x0013F1DC
		public unsafe float MinValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 29110, RefRangeEnd = 29119, XrefRangeStart = 29110, XrefRangeEnd = 29119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0014101C File Offset: 0x0013F21C
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00141058 File Offset: 0x0013F258
		public unsafe float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x00141098 File Offset: 0x0013F298
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x001410D4 File Offset: 0x0013F2D4
		public unsafe bool WholeNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00141114 File Offset: 0x0013F314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149248, RefRangeEnd = 149250, XrefRangeStart = 149240, XrefRangeEnd = 149248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00141160 File Offset: 0x0013F360
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 149254, RefRangeEnd = 149259, XrefRangeStart = 149250, XrefRangeEnd = 149254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x001411AC File Offset: 0x0013F3AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149259, RefRangeEnd = 149261, XrefRangeStart = 149259, XrefRangeEnd = 149259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeNumbers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00141208 File Offset: 0x0013F408
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00141250 File Offset: 0x0013F450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149265, RefRangeEnd = 149267, XrefRangeStart = 149261, XrefRangeEnd = 149265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr3) : null;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00141290 File Offset: 0x0013F490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149271, RefRangeEnd = 149274, XrefRangeStart = 149267, XrefRangeEnd = 149271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NumberFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x0001D74B File Offset: 0x0001B94B
		public NumberField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x001412D4 File Offset: 0x0013F4D4
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x0001D754 File Offset: 0x0001B954
		public unsafe float _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x001412FC File Offset: 0x0013F4FC
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x0001D76F File Offset: 0x0001B96F
		public unsafe float _MinValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x00141324 File Offset: 0x0013F524
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x0001D78A File Offset: 0x0001B98A
		public unsafe float _MaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x0014134C File Offset: 0x0013F54C
		// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x0001D7A5 File Offset: 0x0001B9A5
		public unsafe bool _WholeNumbers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField)) = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x00141374 File Offset: 0x0013F574
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		public unsafe UnityEvent<float> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeFieldInfoPtr__MinValue_k__BackingField;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeFieldInfoPtr__WholeNumbers_k__BackingField;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_get_Single_0;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NumberFieldData_0;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0;
	}
}
