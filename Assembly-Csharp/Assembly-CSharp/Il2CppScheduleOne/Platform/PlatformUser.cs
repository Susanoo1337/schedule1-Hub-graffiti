using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A7 RID: 423
	public static class PlatformUser : Object
	{
		// Token: 0x06002A67 RID: 10855 RVA: 0x001070E8 File Offset: 0x001052E8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformUser()
		{
			Il2CppClassPointerStore<PlatformUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUser>.NativeClassPtr);
			PlatformUser.NativeMethodInfoPtr_GetUserID_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUser>.NativeClassPtr, 100668711);
			PlatformUser.NativeMethodInfoPtr_GetPublicPersonaName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUser>.NativeClassPtr, 100668712);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00107140 File Offset: 0x00105340
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 124253, RefRangeEnd = 124260, XrefRangeStart = 124243, XrefRangeEnd = 124253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetUserID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUser.NativeMethodInfoPtr_GetUserID_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0010716C File Offset: 0x0010536C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124269, RefRangeEnd = 124270, XrefRangeStart = 124260, XrefRangeEnd = 124269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPublicPersonaName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUser.NativeMethodInfoPtr_GetPublicPersonaName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0001621A File Offset: 0x0001441A
		public PlatformUser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_GetUserID_Public_Static_String_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicPersonaName_Public_Static_String_0;
	}
}
