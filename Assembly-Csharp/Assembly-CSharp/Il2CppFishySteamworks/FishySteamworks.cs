using System;
using Il2CppFishNet.Managing;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x02000093 RID: 147
	public class FishySteamworks : Transport
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x000A43D8 File Offset: 0x000A25D8
		// Note: this type is marked as 'beforefieldinit'.
		static FishySteamworks()
		{
			Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "FishySteamworks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr);
			FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "LocalUserSteamID");
			FishySteamworks.NativeFieldInfoPtr__serverBindAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_serverBindAddress");
			FishySteamworks.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_port");
			FishySteamworks.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_maximumClients");
			FishySteamworks.NativeFieldInfoPtr__peerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_peerToPeer");
			FishySteamworks.NativeFieldInfoPtr__clientAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientAddress");
			FishySteamworks.NativeFieldInfoPtr__mtus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_mtus");
			FishySteamworks.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_client");
			FishySteamworks.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientHost");
			FishySteamworks.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_server");
			FishySteamworks.NativeFieldInfoPtr__shutdownCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_shutdownCalled");
			FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "CLIENT_HOST_ID");
			FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnRemoteConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientReceivedData");
			FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerReceivedData");
			FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664853);
			FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664854);
			FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664855);
			FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664856);
			FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664857);
			FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664858);
			FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664859);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664860);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664861);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664862);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664863);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664864);
			FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664865);
			FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664866);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664867);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664868);
			FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664869);
			FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664870);
			FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664871);
			FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664872);
			FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664873);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664874);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664875);
			FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664876);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664877);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664878);
			FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664879);
			FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664880);
			FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664881);
			FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664882);
			FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664883);
			FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664884);
			FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664885);
			FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664886);
			FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664887);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664888);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664889);
			FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664890);
			FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664891);
			FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664892);
			FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664893);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664894);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664895);
			FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664896);
			FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100664897);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000A48E0 File Offset: 0x000A2AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78456, XrefRangeEnd = 78459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000A491C File Offset: 0x000A2B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78459, XrefRangeEnd = 78539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(NetworkManager networkManager, int transportIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transportIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000A4978 File Offset: 0x000A2B78
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000A49AC File Offset: 0x000A2BAC
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000A49E0 File Offset: 0x000A2BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78539, XrefRangeEnd = 78545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChannelData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000A4A14 File Offset: 0x000A2C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78549, RefRangeEnd = 78550, XrefRangeStart = 78545, XrefRangeEnd = 78549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InitializeRelayNetworkAccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000A4A50 File Offset: 0x000A2C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78552, RefRangeEnd = 78554, XrefRangeStart = 78550, XrefRangeEnd = 78552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNetworkAccessAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000A4A8C File Offset: 0x000A2C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78554, XrefRangeEnd = 78567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000A4ADC File Offset: 0x000A2CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78567, XrefRangeEnd = 78572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000A4B2C File Offset: 0x000A2D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78572, XrefRangeEnd = 78577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000A4B7C File Offset: 0x000A2D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78577, XrefRangeEnd = 78582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000A4BCC File Offset: 0x000A2DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78582, XrefRangeEnd = 78587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000A4C1C File Offset: 0x000A2E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78587, XrefRangeEnd = 78592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000A4C6C File Offset: 0x000A2E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78592, XrefRangeEnd = 78597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000A4CBC File Offset: 0x000A2EBC
		[CallerCount(0)]
		public unsafe override LocalConnectionState GetConnectionState(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000A4D10 File Offset: 0x000A2F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78597, XrefRangeEnd = 78601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000A4D64 File Offset: 0x000A2F64
		[CallerCount(0)]
		public unsafe override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000A4DB0 File Offset: 0x000A2FB0
		[CallerCount(0)]
		public unsafe override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000A4DFC File Offset: 0x000A2FFC
		[CallerCount(0)]
		public unsafe override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000A4E48 File Offset: 0x000A3048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78601, XrefRangeEnd = 78619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateIncoming(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000A4E94 File Offset: 0x000A3094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78619, XrefRangeEnd = 78620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateOutgoing(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000A4EE0 File Offset: 0x000A30E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78620, XrefRangeEnd = 78625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000A4F30 File Offset: 0x000A3130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78625, XrefRangeEnd = 78630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000A4F80 File Offset: 0x000A3180
		[CallerCount(0)]
		public unsafe override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000A4FD4 File Offset: 0x000A31D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78630, XrefRangeEnd = 78635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000A5024 File Offset: 0x000A3224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78635, XrefRangeEnd = 78640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000A5074 File Offset: 0x000A3274
		[CallerCount(0)]
		public unsafe override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000A50C8 File Offset: 0x000A32C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78640, XrefRangeEnd = 78668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000A5128 File Offset: 0x000A3328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78668, XrefRangeEnd = 78669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000A5198 File Offset: 0x000A3398
		[CallerCount(0)]
		public unsafe override int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000A51E0 File Offset: 0x000A33E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78669, XrefRangeEnd = 78673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000A522C File Offset: 0x000A342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78673, XrefRangeEnd = 78674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetClientAddress(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000A527C File Offset: 0x000A347C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetServerBindAddress(string address, IPAddressType addressType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addressType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000A52D8 File Offset: 0x000A34D8
		[CallerCount(0)]
		public unsafe override void SetPort(ushort port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000A5324 File Offset: 0x000A3524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78674, XrefRangeEnd = 78676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StartConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000A5378 File Offset: 0x000A3578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78676, XrefRangeEnd = 78678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000A53CC File Offset: 0x000A35CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78678, XrefRangeEnd = 78689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000A5430 File Offset: 0x000A3630
		[CallerCount(0)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000A546C File Offset: 0x000A366C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78702, RefRangeEnd = 78703, XrefRangeStart = 78689, XrefRangeEnd = 78702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000A54A8 File Offset: 0x000A36A8
		[CallerCount(0)]
		public unsafe bool StopServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000A54E4 File Offset: 0x000A36E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78708, RefRangeEnd = 78709, XrefRangeStart = 78703, XrefRangeEnd = 78708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartClient(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000A5534 File Offset: 0x000A3734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78709, XrefRangeEnd = 78711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000A5570 File Offset: 0x000A3770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78711, XrefRangeEnd = 78722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000A55C8 File Offset: 0x000A37C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78722, XrefRangeEnd = 78725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMTU(byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000A561C File Offset: 0x000A381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78725, XrefRangeEnd = 78731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishySteamworks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00007BD3 File Offset: 0x00005DD3
		public FishySteamworks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000A5658 File Offset: 0x000A3858
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00007BDC File Offset: 0x00005DDC
		public unsafe ulong LocalUserSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000A5680 File Offset: 0x000A3880
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00007BF7 File Offset: 0x00005DF7
		public unsafe string _serverBindAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000A56A8 File Offset: 0x000A38A8
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00007C16 File Offset: 0x00005E16
		public unsafe ushort _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000A56D0 File Offset: 0x000A38D0
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00007C31 File Offset: 0x00005E31
		public unsafe ushort _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000A56F8 File Offset: 0x000A38F8
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00007C4C File Offset: 0x00005E4C
		public unsafe bool _peerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000A5720 File Offset: 0x000A3920
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00007C67 File Offset: 0x00005E67
		public unsafe string _clientAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000A5748 File Offset: 0x000A3948
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00007C86 File Offset: 0x00005E86
		public unsafe Il2CppStructArray<int> _mtus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x000A5778 File Offset: 0x000A3978
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public unsafe ClientSocket _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000A57A8 File Offset: 0x000A39A8
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00007CC4 File Offset: 0x00005EC4
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000A57D8 File Offset: 0x000A39D8
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00007CE3 File Offset: 0x00005EE3
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000A5808 File Offset: 0x000A3A08
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00007D02 File Offset: 0x00005F02
		public unsafe bool _shutdownCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000A5830 File Offset: 0x000A3A30
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00007D1D File Offset: 0x00005F1D
		public unsafe static int CLIENT_HOST_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000A584C File Offset: 0x000A3A4C
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00007D2B File Offset: 0x00005F2B
		public unsafe Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000A587C File Offset: 0x000A3A7C
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00007D4A File Offset: 0x00005F4A
		public unsafe Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000A58AC File Offset: 0x000A3AAC
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00007D69 File Offset: 0x00005F69
		public unsafe Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemoteConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000A58DC File Offset: 0x000A3ADC
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00007D88 File Offset: 0x00005F88
		public unsafe Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000A590C File Offset: 0x000A3B0C
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00007DA7 File Offset: 0x00005FA7
		public unsafe Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeFieldInfoPtr_LocalUserSteamID;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr__serverBindAddress;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr__peerToPeer;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr__clientAddress;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr__mtus;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr__shutdownCalled;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_CLIENT_HOST_ID;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_OnClientConnectionState;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_OnServerConnectionState;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_OnRemoteConnectionState;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_OnClientReceivedData;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_OnServerReceivedData;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_CreateChannelData_Private_Void_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_StartServer_Private_Boolean_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_StopServer_Private_Boolean_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_StartClient_Private_Boolean_String_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
