using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000209 RID: 521
	[Serializable]
	public class GenericSaveablesData : SaveData
	{
		// Token: 0x06002E05 RID: 11781 RVA: 0x001149B4 File Offset: 0x00112BB4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesData()
		{
			Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveablesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr);
			GenericSaveablesData.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, "Saveables");
			GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, 100669337);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00114A0C File Offset: 0x00112C0C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesData(Il2CppReferenceArray<GenericSaveData> saveables) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000174D6 File Offset: 0x000156D6
		public GenericSaveablesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00114A58 File Offset: 0x00112C58
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x000174DF File Offset: 0x000156DF
		public unsafe Il2CppReferenceArray<GenericSaveData> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GenericSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0;
	}
}
