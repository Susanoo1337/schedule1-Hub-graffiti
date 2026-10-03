using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Server
{
	// Token: 0x02000094 RID: 148
	public class ServerSocket : CommonSocket
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x000A593C File Offset: 0x000A3B3C
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSocket()
		{
			Il2CppClassPointerStore<ServerSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Server", "ServerSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr);
			ServerSocket.NativeFieldInfoPtr__steamConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamConnections");
			ServerSocket.NativeFieldInfoPtr__steamIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamIds");
			ServerSocket.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_maximumClients");
			ServerSocket.NativeFieldInfoPtr__nextConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_nextConnectionId");
			ServerSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_socket");
			ServerSocket.NativeFieldInfoPtr__clientHostIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostIncoming");
			ServerSocket.NativeFieldInfoPtr__clientHostStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostStarted");
			ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_onRemoteConnectionStateCallback");
			ServerSocket.NativeFieldInfoPtr__cachedConnectionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_cachedConnectionIds");
			ServerSocket.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHost");
			ServerSocket.NativeFieldInfoPtr__iteratingConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_iteratingConnections");
			ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_pendingConnectionChanges");
			ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664898);
			ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664899);
			ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664900);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664901);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664902);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664903);
			ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664904);
			ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664905);
			ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664906);
			ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664907);
			ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664908);
			ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664909);
			ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664910);
			ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664911);
			ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664912);
			ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664913);
			ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664914);
			ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664915);
			ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664916);
			ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100664917);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x000A5BEC File Offset: 0x000A3DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78739, XrefRangeEnd = 78743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000A5C38 File Offset: 0x000A3E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78743, XrefRangeEnd = 78749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInvalidSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000A5C6C File Offset: 0x000A3E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78783, RefRangeEnd = 78784, XrefRangeStart = 78749, XrefRangeEnd = 78783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, int maximumClients, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumClients;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x000A5CE4 File Offset: 0x000A3EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78784, XrefRangeEnd = 78800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000A5D20 File Offset: 0x000A3F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78800, XrefRangeEnd = 78811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x000A5D6C File Offset: 0x000A3F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78811, XrefRangeEnd = 78821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId, HSteamNetConnection socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000A5DC4 File Offset: 0x000A3FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78821, XrefRangeEnd = 78842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoteConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000A5E0C File Offset: 0x000A400C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78859, RefRangeEnd = 78860, XrefRangeStart = 78842, XrefRangeEnd = 78859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConnection(int connectionId, HSteamNetConnection steamConnection, CSteamID steamId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000A5E68 File Offset: 0x000A4068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78877, RefRangeEnd = 78878, XrefRangeStart = 78860, XrefRangeEnd = 78877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000A5EA8 File Offset: 0x000A40A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78878, XrefRangeEnd = 78900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000A5EDC File Offset: 0x000A40DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78933, RefRangeEnd = 78934, XrefRangeStart = 78900, XrefRangeEnd = 78933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000A5F10 File Offset: 0x000A4110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78956, RefRangeEnd = 78958, XrefRangeStart = 78934, XrefRangeEnd = 78956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPendingConnectionChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000A5F44 File Offset: 0x000A4144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78977, RefRangeEnd = 78978, XrefRangeStart = 78958, XrefRangeEnd = 78977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000A5FA8 File Offset: 0x000A41A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78978, XrefRangeEnd = 78991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000A5FEC File Offset: 0x000A41EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78991, XrefRangeEnd = 78995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000A602C File Offset: 0x000A422C
		[CallerCount(0)]
		public unsafe int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000A6068 File Offset: 0x000A4268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78995, XrefRangeEnd = 78996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClientHostSocket(ClientHostSocket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000A60AC File Offset: 0x000A42AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79019, RefRangeEnd = 79021, XrefRangeStart = 78996, XrefRangeEnd = 79019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClientHostState(bool started)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref started;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000A60EC File Offset: 0x000A42EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79021, XrefRangeEnd = 79024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromClientHost(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000A6134 File Offset: 0x000A4334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79024, XrefRangeEnd = 79073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00007DC6 File Offset: 0x00005FC6
		public ServerSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000A6170 File Offset: 0x000A4370
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00007DCF File Offset: 0x00005FCF
		public unsafe BidirectionalDictionary<HSteamNetConnection, int> _steamConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<HSteamNetConnection, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000A61A0 File Offset: 0x000A43A0
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00007DEE File Offset: 0x00005FEE
		public unsafe BidirectionalDictionary<CSteamID, int> _steamIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<CSteamID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000A61D0 File Offset: 0x000A43D0
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00007E0D File Offset: 0x0000600D
		public unsafe int _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000A61F8 File Offset: 0x000A43F8
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00007E28 File Offset: 0x00006028
		public unsafe int _nextConnectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000A6220 File Offset: 0x000A4420
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00007E43 File Offset: 0x00006043
		public unsafe HSteamListenSocket _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000A6248 File Offset: 0x000A4448
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe Queue<LocalPacket> _clientHostIncoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000A6278 File Offset: 0x000A4478
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00007E7D File Offset: 0x0000607D
		public unsafe bool _clientHostStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000A62A0 File Offset: 0x000A44A0
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00007E98 File Offset: 0x00006098
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000A62D0 File Offset: 0x000A44D0
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00007EB7 File Offset: 0x000060B7
		public unsafe Queue<int> _cachedConnectionIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000A6300 File Offset: 0x000A4500
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00007ED6 File Offset: 0x000060D6
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000A6330 File Offset: 0x000A4530
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00007EF5 File Offset: 0x000060F5
		public unsafe bool _iteratingConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000A6358 File Offset: 0x000A4558
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00007F10 File Offset: 0x00006110
		public unsafe List<ServerSocket.ConnectionChange> _pendingConnectionChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServerSocket.ConnectionChange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr__steamConnections;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr__steamIds;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr__nextConnectionId;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr__clientHostIncoming;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr__clientHostStarted;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr__onRemoteConnectionStateCallback;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr__cachedConnectionIds;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr__iteratingConnections;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr__pendingConnectionChanges;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008AB RID: 2219
		[StructLayout(2)]
		public struct ConnectionChange
		{
			// Token: 0x0600D3F6 RID: 54262 RVA: 0x0034D2FC File Offset: 0x0034B4FC
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChange()
			{
				Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "ConnectionChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr);
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_ConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "ConnectionId");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamConnection");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamId");
				ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100664918);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100664919);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100664920);
			}

			// Token: 0x17004086 RID: 16518
			// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x0034D3A0 File Offset: 0x0034B5A0
			public unsafe bool IsConnect
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78731, XrefRangeEnd = 78735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D3F8 RID: 54264 RVA: 0x0034D3D0 File Offset: 0x0034B5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78735, XrefRangeEnd = 78739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChange(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3F9 RID: 54265 RVA: 0x0034D404 File Offset: 0x0034B604
			[CallerCount(0)]
			public unsafe ConnectionChange(int id, HSteamNetConnection steamConnection, CSteamID steamId)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3FA RID: 54266 RVA: 0x000643E4 File Offset: 0x000625E4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, ref this));
			}

			// Token: 0x04009055 RID: 36949
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionId;

			// Token: 0x04009056 RID: 36950
			private static readonly IntPtr NativeFieldInfoPtr_SteamConnection;

			// Token: 0x04009057 RID: 36951
			private static readonly IntPtr NativeFieldInfoPtr_SteamId;

			// Token: 0x04009058 RID: 36952
			private static readonly IntPtr NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0;

			// Token: 0x04009059 RID: 36953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400905A RID: 36954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0;

			// Token: 0x0400905B RID: 36955
			[FieldOffset(0)]
			public int ConnectionId;

			// Token: 0x0400905C RID: 36956
			[FieldOffset(4)]
			public HSteamNetConnection SteamConnection;

			// Token: 0x0400905D RID: 36957
			[FieldOffset(8)]
			public CSteamID SteamId;
		}
	}
}
