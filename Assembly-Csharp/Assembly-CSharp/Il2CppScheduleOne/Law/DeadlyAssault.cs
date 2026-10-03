using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000313 RID: 787
	[Serializable]
	public class DeadlyAssault : Crime
	{
		// Token: 0x06003DCF RID: 15823 RVA: 0x0014B91C File Offset: 0x00149B1C
		// Note: this type is marked as 'beforefieldinit'.
		static DeadlyAssault()
		{
			Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DeadlyAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr);
			DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100671183);
			DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100671184);
			DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100671185);
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0014B99C File Offset: 0x00149B9C
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x0014B9E0 File Offset: 0x00149BE0
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x0014BA30 File Offset: 0x00149C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152335, RefRangeEnd = 152336, XrefRangeStart = 152326, XrefRangeEnd = 152335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadlyAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x0001EBDA File Offset: 0x0001CDDA
		public DeadlyAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0014BA6C File Offset: 0x00149C6C
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x0001EBE3 File Offset: 0x0001CDE3
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
