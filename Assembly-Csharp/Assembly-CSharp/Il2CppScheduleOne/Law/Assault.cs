using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000312 RID: 786
	[Serializable]
	public class Assault : Crime
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x0014B7A4 File Offset: 0x001499A4
		// Note: this type is marked as 'beforefieldinit'.
		static Assault()
		{
			Il2CppClassPointerStore<Assault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Assault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assault>.NativeClassPtr);
			Assault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assault>.NativeClassPtr, "<CrimeName>k__BackingField");
			Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100671180);
			Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100671181);
			Assault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100671182);
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x0014B824 File Offset: 0x00149A24
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x0014B868 File Offset: 0x00149A68
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0014B8B8 File Offset: 0x00149AB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152323, RefRangeEnd = 152326, XrefRangeStart = 152314, XrefRangeEnd = 152323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x0001EBB2 File Offset: 0x0001CDB2
		public Assault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x0014B8F4 File Offset: 0x00149AF4
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x0001EBBB File Offset: 0x0001CDBB
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
