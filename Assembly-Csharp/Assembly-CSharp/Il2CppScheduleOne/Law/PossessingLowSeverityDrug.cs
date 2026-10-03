using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000308 RID: 776
	[Serializable]
	public class PossessingLowSeverityDrug : Crime
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x0014A8F4 File Offset: 0x00148AF4
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingLowSeverityDrug()
		{
			Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingLowSeverityDrug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr);
			PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingLowSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100671150);
			PossessingLowSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100671151);
			PossessingLowSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100671152);
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x0014A974 File Offset: 0x00148B74
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x0014A9B8 File Offset: 0x00148BB8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingLowSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingLowSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x0014AA08 File Offset: 0x00148C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152216, RefRangeEnd = 152217, XrefRangeStart = 152207, XrefRangeEnd = 152216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingLowSeverityDrug() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingLowSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x0001EA22 File Offset: 0x0001CC22
		public PossessingLowSeverityDrug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x0014AA44 File Offset: 0x00148C44
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x0001EA2B File Offset: 0x0001CC2B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
