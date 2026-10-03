using System;
using Il2CppFishNet.Authenticating;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Managing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000297 RID: 663
	public class HostAuthenticator : Authenticator
	{
		// Token: 0x0600325C RID: 12892 RVA: 0x00121570 File Offset: 0x0011F770
		// Note: this type is marked as 'beforefieldinit'.
		static HostAuthenticator()
		{
			Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "HostAuthenticator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr);
			HostAuthenticator.NativeFieldInfoPtr__hostHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, "_hostHash");
			HostAuthenticator.NativeFieldInfoPtr__allowHostAuthentication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, "_allowHostAuthentication");
			HostAuthenticator.NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669571);
			HostAuthenticator.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669572);
			HostAuthenticator.NativeMethodInfoPtr_ServerManager_OnServerConnectionState_Private_Void_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669573);
			HostAuthenticator.NativeMethodInfoPtr_OnHostPasswordBroadcast_Private_Void_NetworkConnection_HostPasswordBroadcast_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669574);
			HostAuthenticator.NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Abstract_Virtual_New_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669575);
			HostAuthenticator.NativeMethodInfoPtr_SetHostHash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669576);
			HostAuthenticator.NativeMethodInfoPtr_AuthenticateAsHost_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669577);
			HostAuthenticator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr, 100669578);
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00121668 File Offset: 0x0011F868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136572, XrefRangeEnd = 136590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeOnce(NetworkManager networkManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HostAuthenticator.NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x001216B8 File Offset: 0x0011F8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136590, XrefRangeEnd = 136610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HostAuthenticator.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x001216F4 File Offset: 0x0011F8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136610, XrefRangeEnd = 136611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HostAuthenticator.NativeMethodInfoPtr_ServerManager_OnServerConnectionState_Private_Void_ServerConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00121734 File Offset: 0x0011F934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136611, XrefRangeEnd = 136618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHostPasswordBroadcast(NetworkConnection conn, HostPasswordBroadcast hpb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hpb));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HostAuthenticator.NativeMethodInfoPtr_OnHostPasswordBroadcast_Private_Void_NetworkConnection_HostPasswordBroadcast_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00121790 File Offset: 0x0011F990
		[CallerCount(0)]
		public unsafe virtual void OnHostAuthenticationResult(NetworkConnection conn, bool authenticated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref authenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HostAuthenticator.NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Abstract_Virtual_New_Void_NetworkConnection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x001217EC File Offset: 0x0011F9EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136653, RefRangeEnd = 136654, XrefRangeStart = 136618, XrefRangeEnd = 136653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHostHash(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HostAuthenticator.NativeMethodInfoPtr_SetHostHash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0012182C File Offset: 0x0011FA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136654, XrefRangeEnd = 136668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AuthenticateAsHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HostAuthenticator.NativeMethodInfoPtr_AuthenticateAsHost_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00121868 File Offset: 0x0011FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136668, XrefRangeEnd = 136669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HostAuthenticator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HostAuthenticator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HostAuthenticator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00019FFA File Offset: 0x000181FA
		public HostAuthenticator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x001218A4 File Offset: 0x0011FAA4
		// (set) Token: 0x06003267 RID: 12903 RVA: 0x0001A003 File Offset: 0x00018203
		public unsafe static string _hostHash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HostAuthenticator.NativeFieldInfoPtr__hostHash, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HostAuthenticator.NativeFieldInfoPtr__hostHash, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x001218C4 File Offset: 0x0011FAC4
		// (set) Token: 0x06003269 RID: 12905 RVA: 0x0001A015 File Offset: 0x00018215
		public unsafe bool _allowHostAuthentication
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HostAuthenticator.NativeFieldInfoPtr__allowHostAuthentication);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HostAuthenticator.NativeFieldInfoPtr__allowHostAuthentication)) = value;
			}
		}

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeFieldInfoPtr__hostHash;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeFieldInfoPtr__allowHostAuthentication;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_ServerManager_OnServerConnectionState_Private_Void_ServerConnectionStateArgs_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_OnHostPasswordBroadcast_Private_Void_NetworkConnection_HostPasswordBroadcast_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Abstract_Virtual_New_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_SetHostHash_Private_Void_Int32_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsHost_Protected_Boolean_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
