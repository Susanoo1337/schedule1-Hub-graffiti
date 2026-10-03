using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000306 RID: 774
	[Serializable]
	public class Crime : Object
	{
		// Token: 0x06003D74 RID: 15732 RVA: 0x0014A604 File Offset: 0x00148804
		// Note: this type is marked as 'beforefieldinit'.
		static Crime()
		{
			Il2CppClassPointerStore<Crime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Crime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crime>.NativeClassPtr);
			Crime.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crime>.NativeClassPtr, "<CrimeName>k__BackingField");
			Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100671144);
			Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100671145);
			Crime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100671146);
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x0014A684 File Offset: 0x00148884
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x0014A6C8 File Offset: 0x001488C8
		public unsafe virtual string CrimeName
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0014A718 File Offset: 0x00148918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152196, RefRangeEnd = 152197, XrefRangeStart = 152191, XrefRangeEnd = 152196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0001E9D2 File Offset: 0x0001CBD2
		public Crime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x0014A754 File Offset: 0x00148954
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x0001E9DB File Offset: 0x0001CBDB
		public unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
