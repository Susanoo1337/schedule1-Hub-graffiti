using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000849 RID: 2121
	public class __JobReflectionRegistrationOutput__1745505670 : Object
	{
		// Token: 0x0600CF4A RID: 53066 RVA: 0x003420B8 File Offset: 0x003402B8
		// Note: this type is marked as 'beforefieldinit'.
		static __JobReflectionRegistrationOutput__1745505670()
		{
			Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1745505670>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "__JobReflectionRegistrationOutput__1745505670");
			__JobReflectionRegistrationOutput__1745505670.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1745505670>.NativeClassPtr, 100690077);
			__JobReflectionRegistrationOutput__1745505670.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1745505670>.NativeClassPtr, 100690078);
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x00342108 File Offset: 0x00340308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341696, RefRangeEnd = 341697, XrefRangeStart = 341678, XrefRangeEnd = 341696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateJobReflectionData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1745505670.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x00342130 File Offset: 0x00340330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341697, XrefRangeEnd = 341698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EarlyInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1745505670.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x00062113 File Offset: 0x00060313
		public __JobReflectionRegistrationOutput__1745505670(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008D60 RID: 36192
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;

		// Token: 0x04008D61 RID: 36193
		private static readonly IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;
	}
}
