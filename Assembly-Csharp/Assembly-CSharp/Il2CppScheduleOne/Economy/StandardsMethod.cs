using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200039A RID: 922
	public static class StandardsMethod : Object
	{
		// Token: 0x06005386 RID: 21382 RVA: 0x0019C4DC File Offset: 0x0019A6DC
		// Note: this type is marked as 'beforefieldinit'.
		static StandardsMethod()
		{
			Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "StandardsMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr);
			StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674257);
			StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674258);
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x0019C534 File Offset: 0x0019A734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186530, RefRangeEnd = 186532, XrefRangeStart = 186523, XrefRangeEnd = 186530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x0019C56C File Offset: 0x0019A76C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 186532, RefRangeEnd = 186543, XrefRangeStart = 186532, XrefRangeEnd = 186532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00027898 File Offset: 0x00025A98
		public StandardsMethod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0;
	}
}
