using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Managing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Platform;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000296 RID: 662
	public sealed class FishNetSteamAuthenticator : HostAuthenticator
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x00120E68 File Offset: 0x0011F068
		// Note: this type is marked as 'beforefieldinit'.
		static FishNetSteamAuthenticator()
		{
			Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "FishNetSteamAuthenticator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr);
			FishNetSteamAuthenticator.NativeFieldInfoPtr_FriendCheckTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "FriendCheckTimeout");
			FishNetSteamAuthenticator.NativeFieldInfoPtr_OnAuthenticationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "OnAuthenticationResult");
			FishNetSteamAuthenticator.NativeFieldInfoPtr_OnLocalAuthenticationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "OnLocalAuthenticationResult");
			FishNetSteamAuthenticator.NativeFieldInfoPtr__authMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "_authMode");
			FishNetSteamAuthenticator.NativeFieldInfoPtr__authenticatedConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "_authenticatedConnections");
			FishNetSteamAuthenticator.NativeMethodInfoPtr_add_OnAuthenticationResult_Public_Virtual_add_Void_Action_2_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669542);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_remove_OnAuthenticationResult_Public_Virtual_rem_Void_Action_2_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669543);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_add_OnLocalAuthenticationResult_Public_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669544);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_remove_OnLocalAuthenticationResult_Public_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669545);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_SetAuthMode_Public_Void_ESteamAuthMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669546);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669547);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669548);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_ClientManager_OnClientConnectionState_Private_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669549);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_ServerManager_OnRemoteConnectionState_Private_Void_NetworkConnection_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669550);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_OnSteamAuthBroadcast_Private_Void_NetworkConnection_SteamSessionAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669551);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_IsSteamUserPermittedToJoinSession_Private_Void_CSteamID_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669552);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_OnResponseBroadcast_Private_Void_ResponseBroadcast_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669553);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_SendAuthenticationResponse_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669554);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Virtual_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669555);
			FishNetSteamAuthenticator.NativeMethodInfoPtr_OnFriendCheckRequested_Private_Void_CheckIfUserIsFriendBroadcast_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669556);
			FishNetSteamAuthenticator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, 100669557);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0012103C File Offset: 0x0011F23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136209, XrefRangeEnd = 136214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnAuthenticationResult(Action<NetworkConnection, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_add_OnAuthenticationResult_Public_Virtual_add_Void_Action_2_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00121080 File Offset: 0x0011F280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136214, XrefRangeEnd = 136219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnAuthenticationResult(Action<NetworkConnection, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_remove_OnAuthenticationResult_Public_Virtual_rem_Void_Action_2_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x001210C4 File Offset: 0x0011F2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136224, RefRangeEnd = 136225, XrefRangeStart = 136219, XrefRangeEnd = 136224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLocalAuthenticationResult(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_add_OnLocalAuthenticationResult_Public_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00121108 File Offset: 0x0011F308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136230, RefRangeEnd = 136231, XrefRangeStart = 136225, XrefRangeEnd = 136230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLocalAuthenticationResult(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_remove_OnLocalAuthenticationResult_Public_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0012114C File Offset: 0x0011F34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136231, XrefRangeEnd = 136241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAuthMode(FishNetSteamAuthenticator.ESteamAuthMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_SetAuthMode_Public_Void_ESteamAuthMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0012118C File Offset: 0x0011F38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136241, XrefRangeEnd = 136300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeOnce(NetworkManager networkManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x001211D0 File Offset: 0x0011F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136300, XrefRangeEnd = 136365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00121204 File Offset: 0x0011F404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136365, XrefRangeEnd = 136393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClientManager_OnClientConnectionState(ClientConnectionStateArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_ClientManager_OnClientConnectionState_Private_Void_ClientConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00121244 File Offset: 0x0011F444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136393, XrefRangeEnd = 136419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerManager_OnRemoteConnectionState(NetworkConnection conn, RemoteConnectionStateArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_ServerManager_OnRemoteConnectionState_Private_Void_NetworkConnection_RemoteConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00121294 File Offset: 0x0011F494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136419, XrefRangeEnd = 136474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSteamAuthBroadcast(NetworkConnection conn, SteamSessionAuthTicket auth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(auth));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_OnSteamAuthBroadcast_Private_Void_NetworkConnection_SteamSessionAuthTicket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x001212F0 File Offset: 0x0011F4F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136490, RefRangeEnd = 136491, XrefRangeStart = 136474, XrefRangeEnd = 136490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IsSteamUserPermittedToJoinSession(CSteamID steamId, Action<bool> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref steamId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_IsSteamUserPermittedToJoinSession_Private_Void_CSteamID_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x00121340 File Offset: 0x0011F540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136491, XrefRangeEnd = 136508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnResponseBroadcast(ResponseBroadcast rb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_OnResponseBroadcast_Private_Void_ResponseBroadcast_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00121380 File Offset: 0x0011F580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136522, RefRangeEnd = 136524, XrefRangeStart = 136508, XrefRangeEnd = 136522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAuthenticationResponse(NetworkConnection conn, bool authenticated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref authenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_SendAuthenticationResponse_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x001213D0 File Offset: 0x0011F5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136524, XrefRangeEnd = 136539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHostAuthenticationResult(NetworkConnection conn, bool authenticated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref authenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Virtual_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00121420 File Offset: 0x0011F620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136539, XrefRangeEnd = 136561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFriendCheckRequested(CheckIfUserIsFriendBroadcast friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref friend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr_OnFriendCheckRequested_Private_Void_CheckIfUserIsFriendBroadcast_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00121460 File Offset: 0x0011F660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136561, XrefRangeEnd = 136572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishNetSteamAuthenticator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00019F6B File Offset: 0x0001816B
		public FishNetSteamAuthenticator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x0012149C File Offset: 0x0011F69C
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x00019F74 File Offset: 0x00018174
		public unsafe static float FriendCheckTimeout
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FishNetSteamAuthenticator.NativeFieldInfoPtr_FriendCheckTimeout, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishNetSteamAuthenticator.NativeFieldInfoPtr_FriendCheckTimeout, (void*)(&value));
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x001214B8 File Offset: 0x0011F6B8
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x00019F82 File Offset: 0x00018182
		public unsafe Action<NetworkConnection, bool> OnAuthenticationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr_OnAuthenticationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NetworkConnection, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr_OnAuthenticationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x001214E8 File Offset: 0x0011F6E8
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x00019FA1 File Offset: 0x000181A1
		public unsafe Action<bool> OnLocalAuthenticationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr_OnLocalAuthenticationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr_OnLocalAuthenticationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x00121518 File Offset: 0x0011F718
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x00019FC0 File Offset: 0x000181C0
		public unsafe FishNetSteamAuthenticator.ESteamAuthMode _authMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr__authMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr__authMode)) = value;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x00121540 File Offset: 0x0011F740
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x00019FDB File Offset: 0x000181DB
		public unsafe Dictionary<NetworkConnection, CSteamID> _authenticatedConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr__authenticatedConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NetworkConnection, CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.NativeFieldInfoPtr__authenticatedConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeFieldInfoPtr_FriendCheckTimeout;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeFieldInfoPtr_OnAuthenticationResult;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeFieldInfoPtr_OnLocalAuthenticationResult;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeFieldInfoPtr__authMode;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeFieldInfoPtr__authenticatedConnections;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAuthenticationResult_Public_Virtual_add_Void_Action_2_NetworkConnection_Boolean_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAuthenticationResult_Public_Virtual_rem_Void_Action_2_NetworkConnection_Boolean_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLocalAuthenticationResult_Public_add_Void_Action_1_Boolean_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLocalAuthenticationResult_Public_rem_Void_Action_1_Boolean_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_SetAuthMode_Public_Void_ESteamAuthMode_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Public_Virtual_Void_NetworkManager_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_ClientManager_OnClientConnectionState_Private_Void_ClientConnectionStateArgs_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_ServerManager_OnRemoteConnectionState_Private_Void_NetworkConnection_RemoteConnectionStateArgs_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_OnSteamAuthBroadcast_Private_Void_NetworkConnection_SteamSessionAuthTicket_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamUserPermittedToJoinSession_Private_Void_CSteamID_Action_1_Boolean_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_OnResponseBroadcast_Private_Void_ResponseBroadcast_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_SendAuthenticationResponse_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_OnHostAuthenticationResult_Protected_Virtual_Void_NetworkConnection_Boolean_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_OnFriendCheckRequested_Private_Void_CheckIfUserIsFriendBroadcast_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F7 RID: 2551
		[OriginalName("Assembly-CSharp.dll", "", "ESteamAuthMode")]
		public enum ESteamAuthMode
		{
			// Token: 0x040096C1 RID: 38593
			Anyone,
			// Token: 0x040096C2 RID: 38594
			FriendOfHost,
			// Token: 0x040096C3 RID: 38595
			FriendOfAnyExistingPlayer
		}

		// Token: 0x020009F8 RID: 2552
		[ObfuscatedName("ScheduleOne.Networking.FishNetSteamAuthenticator+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600DD1F RID: 56607 RVA: 0x00369C20 File Offset: 0x00367E20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr);
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_auth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, "auth");
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, "conn");
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, 100669558);
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, 100669559);
				FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr, 100669560);
			}

			// Token: 0x0600DD20 RID: 56608 RVA: 0x00369CC4 File Offset: 0x00367EC4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD21 RID: 56609 RVA: 0x00369D00 File Offset: 0x00367F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136100, XrefRangeEnd = 136127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool accepted)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref accepted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD22 RID: 56610 RVA: 0x00369D40 File Offset: 0x00367F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136127, XrefRangeEnd = 136129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x00068101 File Offset: 0x00066301
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600DD24 RID: 56612 RVA: 0x00369D74 File Offset: 0x00367F74
			// (set) Token: 0x0600DD25 RID: 56613 RVA: 0x0006810A File Offset: 0x0006630A
			public SteamSessionAuthTicket auth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_auth);
					return new SteamSessionAuthTicket(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_auth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x00369DA4 File Offset: 0x00367FA4
			// (set) Token: 0x0600DD27 RID: 56615 RVA: 0x00068138 File Offset: 0x00066338
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x00369DD4 File Offset: 0x00367FD4
			// (set) Token: 0x0600DD29 RID: 56617 RVA: 0x00068157 File Offset: 0x00066357
			public unsafe FishNetSteamAuthenticator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096C4 RID: 38596
			private static readonly IntPtr NativeFieldInfoPtr_auth;

			// Token: 0x040096C5 RID: 38597
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040096C6 RID: 38598
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096C7 RID: 38599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096C8 RID: 38600
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

			// Token: 0x040096C9 RID: 38601
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020009F9 RID: 2553
		[ObfuscatedName("ScheduleOne.Networking.FishNetSteamAuthenticator+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600DD2A RID: 56618 RVA: 0x00369E04 File Offset: 0x00368004
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr);
				FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_steamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, "steamId");
				FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, "result");
				FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, 100669561);
				FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, 100669562);
			}

			// Token: 0x0600DD2B RID: 56619 RVA: 0x00369E94 File Offset: 0x00368094
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD2C RID: 56620 RVA: 0x00369ED0 File Offset: 0x003680D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136178, XrefRangeEnd = 136183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD2D RID: 56621 RVA: 0x00068176 File Offset: 0x00066376
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x00369F10 File Offset: 0x00368110
			// (set) Token: 0x0600DD2F RID: 56623 RVA: 0x0006817F File Offset: 0x0006637F
			public unsafe FishNetSteamAuthenticator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600DD30 RID: 56624 RVA: 0x00369F40 File Offset: 0x00368140
			// (set) Token: 0x0600DD31 RID: 56625 RVA: 0x0006819E File Offset: 0x0006639E
			public unsafe CSteamID steamId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_steamId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_steamId)) = value;
				}
			}

			// Token: 0x1700435D RID: 17245
			// (get) Token: 0x0600DD32 RID: 56626 RVA: 0x00369F68 File Offset: 0x00368168
			// (set) Token: 0x0600DD33 RID: 56627 RVA: 0x000681B9 File Offset: 0x000663B9
			public unsafe Action<bool> result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_result);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096CA RID: 38602
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096CB RID: 38603
			private static readonly IntPtr NativeFieldInfoPtr_steamId;

			// Token: 0x040096CC RID: 38604
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040096CD RID: 38605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096CE RID: 38606
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DBD RID: 3517
			[ObfuscatedName("ScheduleOne.Networking.FishNetSteamAuthenticator+<>c__DisplayClass16_0+<<IsSteamUserPermittedToJoinSession>g__WaitForFriendCheckResponse|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Object
			{
				// Token: 0x0600FE23 RID: 65059 RVA: 0x003C7C30 File Offset: 0x003C5E30
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0>.NativeClassPtr, "<<IsSteamUserPermittedToJoinSession>g__WaitForFriendCheckResponse|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>8__1");
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<elapsedTime>5__2");
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669563);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669564);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669565);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669566);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669567);
					FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669568);
				}

				// Token: 0x0600FE24 RID: 65060 RVA: 0x003C7D38 File Offset: 0x003C5F38
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE25 RID: 65061 RVA: 0x003C7D80 File Offset: 0x003C5F80
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE26 RID: 65062 RVA: 0x003C7DB4 File Offset: 0x003C5FB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136129, XrefRangeEnd = 136173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D4F RID: 19791
				// (get) Token: 0x0600FE27 RID: 65063 RVA: 0x003C7DF0 File Offset: 0x003C5FF0
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE28 RID: 65064 RVA: 0x003C7E30 File Offset: 0x003C6030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136173, XrefRangeEnd = 136178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D50 RID: 19792
				// (get) Token: 0x0600FE29 RID: 65065 RVA: 0x003C7E64 File Offset: 0x003C6064
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE2A RID: 65066 RVA: 0x00078692 File Offset: 0x00076892
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D4A RID: 19786
				// (get) Token: 0x0600FE2B RID: 65067 RVA: 0x003C7EA4 File Offset: 0x003C60A4
				// (set) Token: 0x0600FE2C RID: 65068 RVA: 0x0007869B File Offset: 0x0007689B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D4B RID: 19787
				// (get) Token: 0x0600FE2D RID: 65069 RVA: 0x003C7ECC File Offset: 0x003C60CC
				// (set) Token: 0x0600FE2E RID: 65070 RVA: 0x000786B6 File Offset: 0x000768B6
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D4C RID: 19788
				// (get) Token: 0x0600FE2F RID: 65071 RVA: 0x003C7EFC File Offset: 0x003C60FC
				// (set) Token: 0x0600FE30 RID: 65072 RVA: 0x000786D5 File Offset: 0x000768D5
				public unsafe FishNetSteamAuthenticator.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D4D RID: 19789
				// (get) Token: 0x0600FE31 RID: 65073 RVA: 0x003C7F2C File Offset: 0x003C612C
				// (set) Token: 0x0600FE32 RID: 65074 RVA: 0x000786F4 File Offset: 0x000768F4
				public unsafe FishNetSteamAuthenticator.__c__DisplayClass16_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator.__c__DisplayClass16_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D4E RID: 19790
				// (get) Token: 0x0600FE33 RID: 65075 RVA: 0x003C7F5C File Offset: 0x003C615C
				// (set) Token: 0x0600FE34 RID: 65076 RVA: 0x00078713 File Offset: 0x00076913
				public unsafe float _elapsedTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__elapsedTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
					}
				}

				// Token: 0x0400AB4C RID: 43852
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB4D RID: 43853
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB4E RID: 43854
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB4F RID: 43855
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400AB50 RID: 43856
				private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

				// Token: 0x0400AB51 RID: 43857
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB52 RID: 43858
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB53 RID: 43859
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB54 RID: 43860
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB55 RID: 43861
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB56 RID: 43862
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009FA RID: 2554
		[ObfuscatedName("ScheduleOne.Networking.FishNetSteamAuthenticator+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : Object
		{
			// Token: 0x0600DD34 RID: 56628 RVA: 0x00369F98 File Offset: 0x00368198
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FishNetSteamAuthenticator>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr);
				FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_friendOfAnyExistingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr, "friendOfAnyExistingPlayer");
				FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr, "CS$<>8__locals1");
				FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr, 100669569);
				FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_FriendCheckResponseBroadcast_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr, 100669570);
			}

			// Token: 0x0600DD35 RID: 56629 RVA: 0x0036A014 File Offset: 0x00368214
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishNetSteamAuthenticator.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD36 RID: 56630 RVA: 0x0036A050 File Offset: 0x00368250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136183, XrefRangeEnd = 136209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NetworkConnection_FriendCheckResponseBroadcast_PDM_0(NetworkConnection conn, FriendCheckResponseBroadcast response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_FriendCheckResponseBroadcast_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD37 RID: 56631 RVA: 0x000681D8 File Offset: 0x000663D8
			public __c__DisplayClass16_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435E RID: 17246
			// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x0036A0A0 File Offset: 0x003682A0
			// (set) Token: 0x0600DD39 RID: 56633 RVA: 0x000681E1 File Offset: 0x000663E1
			public unsafe bool friendOfAnyExistingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_friendOfAnyExistingPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_friendOfAnyExistingPlayer)) = value;
				}
			}

			// Token: 0x1700435F RID: 17247
			// (get) Token: 0x0600DD3A RID: 56634 RVA: 0x0036A0C8 File Offset: 0x003682C8
			// (set) Token: 0x0600DD3B RID: 56635 RVA: 0x000681FC File Offset: 0x000663FC
			public unsafe FishNetSteamAuthenticator.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishNetSteamAuthenticator.__c__DisplayClass16_1.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096CF RID: 38607
			private static readonly IntPtr NativeFieldInfoPtr_friendOfAnyExistingPlayer;

			// Token: 0x040096D0 RID: 38608
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x040096D1 RID: 38609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096D2 RID: 38610
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_FriendCheckResponseBroadcast_PDM_0;
		}
	}
}
