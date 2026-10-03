using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000067 RID: 103
	public class PlatformHelper : Il2CppSystem.Object
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x0008FF98 File Offset: 0x0008E198
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664096);
			PlatformHelper.NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664097);
			PlatformHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664098);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00090004 File Offset: 0x0008E204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72031, XrefRangeEnd = 72038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentPlatformSuffix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00090030 File Offset: 0x0008E230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72038, XrefRangeEnd = 72041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPlatformSuffix(RuntimePlatform platform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref platform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00090068 File Offset: 0x0008E268
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00005457 File Offset: 0x00003657
		public PlatformHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
