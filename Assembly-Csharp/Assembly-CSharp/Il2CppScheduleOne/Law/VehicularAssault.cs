using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200030C RID: 780
	[Serializable]
	public class VehicularAssault : Crime
	{
		// Token: 0x06003D9E RID: 15774 RVA: 0x0014AED4 File Offset: 0x001490D4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicularAssault()
		{
			Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehicularAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr);
			VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100671162);
			VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100671163);
			VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100671164);
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x0014AF54 File Offset: 0x00149154
		// (set) Token: 0x06003DA0 RID: 15776 RVA: 0x0014AF98 File Offset: 0x00149198
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x0014AFE8 File Offset: 0x001491E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 152256, RefRangeEnd = 152260, XrefRangeStart = 152247, XrefRangeEnd = 152256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicularAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x0001EAC2 File Offset: 0x0001CCC2
		public VehicularAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x0014B024 File Offset: 0x00149224
		// (set) Token: 0x06003DA4 RID: 15780 RVA: 0x0001EACB File Offset: 0x0001CCCB
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
