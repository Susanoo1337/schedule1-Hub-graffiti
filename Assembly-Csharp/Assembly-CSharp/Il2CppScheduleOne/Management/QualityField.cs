using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E9 RID: 745
	public class QualityField : ConfigField
	{
		// Token: 0x06003B09 RID: 15113 RVA: 0x00141B84 File Offset: 0x0013FD84
		// Note: this type is marked as 'beforefieldinit'.
		static QualityField()
		{
			Il2CppClassPointerStore<QualityField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "QualityField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityField>.NativeClassPtr);
			QualityField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "<Value>k__BackingField");
			QualityField.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "onValueChanged");
			QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670847);
			QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670848);
			QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670849);
			QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670850);
			QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670851);
			QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670852);
			QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100670853);
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x00141C68 File Offset: 0x0013FE68
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x00141CA4 File Offset: 0x0013FEA4
		public unsafe EQuality Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00141CE4 File Offset: 0x0013FEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149632, RefRangeEnd = 149633, XrefRangeStart = 149624, XrefRangeEnd = 149632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00141D30 File Offset: 0x0013FF30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 149637, RefRangeEnd = 149642, XrefRangeStart = 149633, XrefRangeEnd = 149637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(EQuality value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00141D7C File Offset: 0x0013FF7C
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00141DC4 File Offset: 0x0013FFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149646, RefRangeEnd = 149647, XrefRangeStart = 149642, XrefRangeEnd = 149646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr3) : null;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00141E04 File Offset: 0x00140004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149651, RefRangeEnd = 149653, XrefRangeStart = 149647, XrefRangeEnd = 149651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(QualityFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0001D91F File Offset: 0x0001BB1F
		public QualityField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x00141E48 File Offset: 0x00140048
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x0001D928 File Offset: 0x0001BB28
		public unsafe EQuality _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x00141E70 File Offset: 0x00140070
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x0001D943 File Offset: 0x0001BB43
		public unsafe UnityEvent<EQuality> onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_EQuality_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_QualityFieldData_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0;
	}
}
