using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000317 RID: 791
	[Serializable]
	public class DischargeFirearm : Crime
	{
		// Token: 0x06003DEB RID: 15851 RVA: 0x0014BEFC File Offset: 0x0014A0FC
		// Note: this type is marked as 'beforefieldinit'.
		static DischargeFirearm()
		{
			Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DischargeFirearm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr);
			DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, "<CrimeName>k__BackingField");
			DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100671195);
			DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100671196);
			DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100671197);
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0014BF7C File Offset: 0x0014A17C
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x0014BFC0 File Offset: 0x0014A1C0
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x0014C010 File Offset: 0x0014A210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152378, RefRangeEnd = 152380, XrefRangeStart = 152369, XrefRangeEnd = 152378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DischargeFirearm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x0001EC7A File Offset: 0x0001CE7A
		public DischargeFirearm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0014C04C File Offset: 0x0014A24C
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0001EC83 File Offset: 0x0001CE83
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
