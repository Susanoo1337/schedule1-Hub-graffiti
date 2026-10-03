using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000309 RID: 777
	[Serializable]
	public class PossessingModerateSeverityDrug : Crime
	{
		// Token: 0x06003D89 RID: 15753 RVA: 0x0014AA6C File Offset: 0x00148C6C
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingModerateSeverityDrug()
		{
			Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingModerateSeverityDrug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr);
			PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingModerateSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100671153);
			PossessingModerateSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100671154);
			PossessingModerateSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100671155);
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x0014AAEC File Offset: 0x00148CEC
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x0014AB30 File Offset: 0x00148D30
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingModerateSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingModerateSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0014AB80 File Offset: 0x00148D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152226, RefRangeEnd = 152227, XrefRangeStart = 152217, XrefRangeEnd = 152226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingModerateSeverityDrug() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingModerateSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0001EA4A File Offset: 0x0001CC4A
		public PossessingModerateSeverityDrug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x0014ABBC File Offset: 0x00148DBC
		// (set) Token: 0x06003D8F RID: 15759 RVA: 0x0001EA53 File Offset: 0x0001CC53
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
