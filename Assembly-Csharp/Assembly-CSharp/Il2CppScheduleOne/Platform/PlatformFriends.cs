using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A6 RID: 422
	public class PlatformFriends : Il2CppSystem.Object
	{
		// Token: 0x06002A62 RID: 10850 RVA: 0x00106FB8 File Offset: 0x001051B8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformFriends()
		{
			Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformFriends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr);
			PlatformFriends.NativeMethodInfoPtr_GetAvatarTexture_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100668708);
			PlatformFriends.NativeMethodInfoPtr_IsLocalPlayerFriendsWith_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100668709);
			PlatformFriends.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100668710);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00107024 File Offset: 0x00105224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124238, RefRangeEnd = 124239, XrefRangeStart = 124222, XrefRangeEnd = 124238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetAvatarTexture(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_GetAvatarTexture_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00107068 File Offset: 0x00105268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124242, RefRangeEnd = 124243, XrefRangeStart = 124239, XrefRangeEnd = 124242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLocalPlayerFriendsWith(string otherPlayerID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(otherPlayerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_IsLocalPlayerFriendsWith_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x001070AC File Offset: 0x001052AC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformFriends() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00016211 File Offset: 0x00014411
		public PlatformFriends(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatarTexture_Public_Static_Texture2D_String_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalPlayerFriendsWith_Public_Static_Boolean_String_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
