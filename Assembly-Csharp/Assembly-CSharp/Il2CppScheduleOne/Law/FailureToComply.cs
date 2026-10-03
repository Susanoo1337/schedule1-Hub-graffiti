using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200030E RID: 782
	[Serializable]
	public class FailureToComply : Crime
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x0014B1C4 File Offset: 0x001493C4
		// Note: this type is marked as 'beforefieldinit'.
		static FailureToComply()
		{
			Il2CppClassPointerStore<FailureToComply>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "FailureToComply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr);
			FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, "<CrimeName>k__BackingField");
			FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100671168);
			FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100671169);
			FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100671170);
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x0014B244 File Offset: 0x00149444
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x0014B288 File Offset: 0x00149488
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x0014B2D8 File Offset: 0x001494D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152279, RefRangeEnd = 152280, XrefRangeStart = 152270, XrefRangeEnd = 152279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailureToComply() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x0001EB12 File Offset: 0x0001CD12
		public FailureToComply(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x0014B314 File Offset: 0x00149514
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x0001EB1B File Offset: 0x0001CD1B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
