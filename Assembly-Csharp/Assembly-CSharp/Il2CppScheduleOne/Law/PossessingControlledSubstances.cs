using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000307 RID: 775
	[Serializable]
	public class PossessingControlledSubstances : Crime
	{
		// Token: 0x06003D7B RID: 15739 RVA: 0x0014A77C File Offset: 0x0014897C
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingControlledSubstances()
		{
			Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingControlledSubstances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr);
			PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100671147);
			PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100671148);
			PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100671149);
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x0014A7FC File Offset: 0x001489FC
		// (set) Token: 0x06003D7D RID: 15741 RVA: 0x0014A840 File Offset: 0x00148A40
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x0014A890 File Offset: 0x00148A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152206, RefRangeEnd = 152207, XrefRangeStart = 152197, XrefRangeEnd = 152206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingControlledSubstances() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0001E9FA File Offset: 0x0001CBFA
		public PossessingControlledSubstances(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x0014A8CC File Offset: 0x00148ACC
		// (set) Token: 0x06003D81 RID: 15745 RVA: 0x0001EA03 File Offset: 0x0001CC03
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
