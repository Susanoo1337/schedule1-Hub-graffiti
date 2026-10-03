using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000315 RID: 789
	[Serializable]
	public class Theft : Crime
	{
		// Token: 0x06003DDD RID: 15837 RVA: 0x0014BC0C File Offset: 0x00149E0C
		// Note: this type is marked as 'beforefieldinit'.
		static Theft()
		{
			Il2CppClassPointerStore<Theft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Theft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Theft>.NativeClassPtr);
			Theft.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theft>.NativeClassPtr, "<CrimeName>k__BackingField");
			Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100671189);
			Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100671190);
			Theft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100671191);
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0014BC8C File Offset: 0x00149E8C
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x0014BCD0 File Offset: 0x00149ED0
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0014BD20 File Offset: 0x00149F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152355, RefRangeEnd = 152358, XrefRangeStart = 152346, XrefRangeEnd = 152355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Theft() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Theft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Theft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0001EC2A File Offset: 0x0001CE2A
		public Theft(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0014BD5C File Offset: 0x00149F5C
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x0001EC33 File Offset: 0x0001CE33
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
