using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000265 RID: 613
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x060030C1 RID: 12481 RVA: 0x0011CA90 File Offset: 0x0011AC90
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyData()
		{
			Il2CppClassPointerStore<PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PropertyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyData>.NativeClassPtr);
			PropertyData.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "PropertyCode");
			PropertyData.NativeFieldInfoPtr_IsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "IsOwned");
			PropertyData.NativeFieldInfoPtr_SwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "SwitchStates");
			PropertyData.NativeFieldInfoPtr_ToggleableStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "ToggleableStates");
			PropertyData.NativeFieldInfoPtr_Employees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "Employees");
			PropertyData.NativeFieldInfoPtr_Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "Objects");
			PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, 100669453);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0011CB4C File Offset: 0x0011AD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135261, RefRangeEnd = 135262, XrefRangeStart = 135255, XrefRangeEnd = 135261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates, Il2CppReferenceArray<DynamicSaveData> employees, Il2CppReferenceArray<DynamicSaveData> objects) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employees);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00019101 File Offset: 0x00017301
		public PropertyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x0011CBF0 File Offset: 0x0011ADF0
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x0001910A File Offset: 0x0001730A
		public unsafe string PropertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x0011CC18 File Offset: 0x0011AE18
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x00019129 File Offset: 0x00017329
		public unsafe bool IsOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned)) = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x0011CC40 File Offset: 0x0011AE40
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x00019144 File Offset: 0x00017344
		public unsafe Il2CppStructArray<bool> SwitchStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x0011CC70 File Offset: 0x0011AE70
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x00019163 File Offset: 0x00017363
		public unsafe Il2CppStructArray<bool> ToggleableStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x0011CCA0 File Offset: 0x0011AEA0
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x00019182 File Offset: 0x00017382
		public unsafe Il2CppReferenceArray<DynamicSaveData> Employees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Employees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Employees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x0011CCD0 File Offset: 0x0011AED0
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x000191A1 File Offset: 0x000173A1
		public unsafe Il2CppReferenceArray<DynamicSaveData> Objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeFieldInfoPtr_IsOwned;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeFieldInfoPtr_SwitchStates;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeFieldInfoPtr_ToggleableStates;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeFieldInfoPtr_Employees;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeFieldInfoPtr_Objects;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0;
	}
}
