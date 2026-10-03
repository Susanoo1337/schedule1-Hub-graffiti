using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000316 RID: 790
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		// Token: 0x06003DE4 RID: 15844 RVA: 0x0014BD84 File Offset: 0x00149F84
		// Note: this type is marked as 'beforefieldinit'.
		static BrandishingWeapon()
		{
			Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "BrandishingWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr);
			BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, "<CrimeName>k__BackingField");
			BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100671192);
			BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100671193);
			BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100671194);
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x0014BE04 File Offset: 0x0014A004
		// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x0014BE48 File Offset: 0x0014A048
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x0014BE98 File Offset: 0x0014A098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152367, RefRangeEnd = 152369, XrefRangeStart = 152358, XrefRangeEnd = 152367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrandishingWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x0001EC52 File Offset: 0x0001CE52
		public BrandishingWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x0014BED4 File Offset: 0x0014A0D4
		// (set) Token: 0x06003DEA RID: 15850 RVA: 0x0001EC5B File Offset: 0x0001CE5B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
