using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000310 RID: 784
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x0014B4B4 File Offset: 0x001496B4
		// Note: this type is marked as 'beforefieldinit'.
		static ViolatingCurfew()
		{
			Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "ViolatingCurfew");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr);
			ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, "<CrimeName>k__BackingField");
			ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100671174);
			ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100671175);
			ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100671176);
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x0014B534 File Offset: 0x00149734
		// (set) Token: 0x06003DBC RID: 15804 RVA: 0x0014B578 File Offset: 0x00149778
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x0014B5C8 File Offset: 0x001497C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152303, RefRangeEnd = 152304, XrefRangeStart = 152290, XrefRangeEnd = 152303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViolatingCurfew() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x0001EB62 File Offset: 0x0001CD62
		public ViolatingCurfew(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x0014B604 File Offset: 0x00149804
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x0001EB6B File Offset: 0x0001CD6B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
