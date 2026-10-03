using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000314 RID: 788
	[Serializable]
	public class Vandalism : Crime
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x0014BA94 File Offset: 0x00149C94
		// Note: this type is marked as 'beforefieldinit'.
		static Vandalism()
		{
			Il2CppClassPointerStore<Vandalism>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Vandalism");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vandalism>.NativeClassPtr);
			Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, "<CrimeName>k__BackingField");
			Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100671186);
			Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100671187);
			Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100671188);
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x0014BB14 File Offset: 0x00149D14
		// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x0014BB58 File Offset: 0x00149D58
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0014BBA8 File Offset: 0x00149DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152345, RefRangeEnd = 152346, XrefRangeStart = 152336, XrefRangeEnd = 152345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vandalism() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vandalism>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x0001EC02 File Offset: 0x0001CE02
		public Vandalism(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x0014BBE4 File Offset: 0x00149DE4
		// (set) Token: 0x06003DDC RID: 15836 RVA: 0x0001EC0B File Offset: 0x0001CE0B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
