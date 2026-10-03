using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200030B RID: 779
	[Serializable]
	public class Evading : Crime
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x0014AD5C File Offset: 0x00148F5C
		// Note: this type is marked as 'beforefieldinit'.
		static Evading()
		{
			Il2CppClassPointerStore<Evading>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Evading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evading>.NativeClassPtr);
			Evading.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evading>.NativeClassPtr, "<CrimeName>k__BackingField");
			Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100671159);
			Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100671160);
			Evading.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100671161);
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x0014ADDC File Offset: 0x00148FDC
		// (set) Token: 0x06003D99 RID: 15769 RVA: 0x0014AE20 File Offset: 0x00149020
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x0014AE70 File Offset: 0x00149070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152246, RefRangeEnd = 152247, XrefRangeStart = 152237, XrefRangeEnd = 152246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evading() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evading>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evading.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x0001EA9A File Offset: 0x0001CC9A
		public Evading(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x0014AEAC File Offset: 0x001490AC
		// (set) Token: 0x06003D9D RID: 15773 RVA: 0x0001EAA3 File Offset: 0x0001CCA3
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
