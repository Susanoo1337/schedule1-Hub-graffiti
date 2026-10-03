using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000200 RID: 512
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06002D8E RID: 11662 RVA: 0x001133F8 File Offset: 0x001115F8
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessData()
		{
			Il2CppClassPointerStore<BusinessData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BusinessData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessData>.NativeClassPtr);
			BusinessData.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, "LaunderingOperations");
			BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, 100669314);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00113450 File Offset: 0x00111650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134330, RefRangeEnd = 134331, XrefRangeStart = 134323, XrefRangeEnd = 134330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates, Il2CppReferenceArray<DynamicSaveData> employees, Il2CppReferenceArray<DynamicSaveData> objects, Il2CppReferenceArray<LaunderOperationData> launderingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employees);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(launderingOperations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00017011 File Offset: 0x00015211
		public BusinessData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00113508 File Offset: 0x00111708
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x0001701A File Offset: 0x0001521A
		public unsafe Il2CppReferenceArray<LaunderOperationData> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LaunderOperationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0;
	}
}
