using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000311 RID: 785
	[Serializable]
	public class AttemptingToSell : Crime
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x0014B62C File Offset: 0x0014982C
		// Note: this type is marked as 'beforefieldinit'.
		static AttemptingToSell()
		{
			Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "AttemptingToSell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr);
			AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, "<CrimeName>k__BackingField");
			AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100671177);
			AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100671178);
			AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100671179);
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x0014B6AC File Offset: 0x001498AC
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x0014B6F0 File Offset: 0x001498F0
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x0014B740 File Offset: 0x00149940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152313, RefRangeEnd = 152314, XrefRangeStart = 152304, XrefRangeEnd = 152313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttemptingToSell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x0001EB8A File Offset: 0x0001CD8A
		public AttemptingToSell(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x0014B77C File Offset: 0x0014997C
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x0001EB93 File Offset: 0x0001CD93
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
