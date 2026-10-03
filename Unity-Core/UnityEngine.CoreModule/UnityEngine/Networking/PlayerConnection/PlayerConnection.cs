using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001CE RID: 462
	[Serializable]
	public class PlayerConnection : ScriptableObject
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x00085DF8 File Offset: 0x00083FF8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnection()
		{
			Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr);
			PlayerConnection.NativeFieldInfoPtr_connectionNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "connectionNative");
			PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_PlayerEditorConnectionEvents");
			PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_connectedPlayers");
			PlayerConnection.NativeFieldInfoPtr_m_IsInitilized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_IsInitilized");
			PlayerConnection.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "s_Instance");
			PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666873);
			PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666874);
			PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666875);
			PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666876);
			PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666877);
			PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666878);
			PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666879);
			PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666880);
			PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666881);
			PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666882);
			PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666883);
			PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666884);
			PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666885);
			PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666886);
			PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666887);
			PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666888);
			PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666889);
			PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666890);
			PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100666891);
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x00086008 File Offset: 0x00084208
		public unsafe static PlayerConnection instance
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1286761, RefRangeEnd = 1286766, XrefRangeStart = 1286745, XrefRangeEnd = 1286761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0008603C File Offset: 0x0008423C
		public unsafe bool isConnected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286766, XrefRangeEnd = 1286776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00086078 File Offset: 0x00084278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286776, XrefRangeEnd = 1286786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerConnection CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000860AC File Offset: 0x000842AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286786, XrefRangeEnd = 1286790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000860E0 File Offset: 0x000842E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1286796, RefRangeEnd = 1286799, XrefRangeStart = 1286790, XrefRangeEnd = 1286796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr3) : null;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00086120 File Offset: 0x00084320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286832, RefRangeEnd = 1286833, XrefRangeStart = 1286799, XrefRangeEnd = 1286832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Register(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00086170 File Offset: 0x00084370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286869, RefRangeEnd = 1286870, XrefRangeStart = 1286833, XrefRangeEnd = 1286869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000861C0 File Offset: 0x000843C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286870, XrefRangeEnd = 1286887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00086204 File Offset: 0x00084404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286887, XrefRangeEnd = 1286891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00086248 File Offset: 0x00084448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286891, XrefRangeEnd = 1286895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0008628C File Offset: 0x0008448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286895, XrefRangeEnd = 1286899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000862D0 File Offset: 0x000844D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286899, XrefRangeEnd = 1286911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00086320 File Offset: 0x00084520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286911, XrefRangeEnd = 1286923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TrySend(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0008637C File Offset: 0x0008457C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286923, XrefRangeEnd = 1286958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000863D4 File Offset: 0x000845D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286958, XrefRangeEnd = 1286968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00086408 File Offset: 0x00084608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286968, XrefRangeEnd = 1286979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00086468 File Offset: 0x00084668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286979, XrefRangeEnd = 1286990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectedCallbackInternal(int playerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0008649C File Offset: 0x0008469C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286990, XrefRangeEnd = 1286999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectedCallback(int playerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000864D0 File Offset: 0x000846D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286999, XrefRangeEnd = 1287032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0000F3FF File Offset: 0x0000D5FF
		public PlayerConnection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0008650C File Offset: 0x0008470C
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0000F408 File Offset: 0x0000D608
		public unsafe static IPlayerEditorConnectionNative connectionNative
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00086534 File Offset: 0x00084734
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000F41A File Offset: 0x0000D61A
		public unsafe PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00086564 File Offset: 0x00084764
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000F439 File Offset: 0x0000D639
		public unsafe List<int> m_connectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00086594 File Offset: 0x00084794
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000F458 File Offset: 0x0000D658
		public unsafe bool m_IsInitilized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000865BC File Offset: 0x000847BC
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000F473 File Offset: 0x0000D673
		public unsafe static PlayerConnection s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_connectionNative;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerEditorConnectionEvents;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_m_connectedPlayers;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInitilized;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB6 RID: 2742
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06003E3E RID: 15934 RVA: 0x000B4468 File Offset: 0x000B2668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100666892);
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100666893);
			}

			// Token: 0x06003E3F RID: 15935 RVA: 0x000B44D0 File Offset: 0x000B26D0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E40 RID: 15936 RVA: 0x000B450C File Offset: 0x000B270C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286743, XrefRangeEnd = 1286745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Register_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E41 RID: 15937 RVA: 0x0001826B File Offset: 0x0001646B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06003E42 RID: 15938 RVA: 0x000B455C File Offset: 0x000B275C
			// (set) Token: 0x06003E43 RID: 15939 RVA: 0x00018274 File Offset: 0x00016474
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002BAD RID: 11181
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002BAE RID: 11182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BAF RID: 11183
			private static readonly IntPtr NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000AB7 RID: 2743
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06003E44 RID: 15940 RVA: 0x000B4584 File Offset: 0x000B2784
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100666894);
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100666895);
			}

			// Token: 0x06003E45 RID: 15941 RVA: 0x000B45EC File Offset: 0x000B27EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E46 RID: 15942 RVA: 0x000B4628 File Offset: 0x000B2828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Unregister_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E47 RID: 15943 RVA: 0x0001828F File Offset: 0x0001648F
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06003E48 RID: 15944 RVA: 0x000B4678 File Offset: 0x000B2878
			// (set) Token: 0x06003E49 RID: 15945 RVA: 0x00018298 File Offset: 0x00016498
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002BB0 RID: 11184
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002BB1 RID: 11185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BB2 RID: 11186
			private static readonly IntPtr NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000AB8 RID: 2744
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06003E4A RID: 15946 RVA: 0x000B46A0 File Offset: 0x000B28A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, "msgReceived");
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100666896);
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100666897);
			}

			// Token: 0x06003E4B RID: 15947 RVA: 0x000B4708 File Offset: 0x000B2908
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4C RID: 15948 RVA: 0x000B4744 File Offset: 0x000B2944
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 53144, RefRangeEnd = 53148, XrefRangeStart = 53144, XrefRangeEnd = 53148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BlockUntilRecvMsg_b__0(MessageEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E4D RID: 15949 RVA: 0x000182B3 File Offset: 0x000164B3
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06003E4E RID: 15950 RVA: 0x000B4788 File Offset: 0x000B2988
			// (set) Token: 0x06003E4F RID: 15951 RVA: 0x000182BC File Offset: 0x000164BC
			public unsafe bool msgReceived
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived)) = value;
				}
			}

			// Token: 0x04002BB3 RID: 11187
			private static readonly IntPtr NativeFieldInfoPtr_msgReceived;

			// Token: 0x04002BB4 RID: 11188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BB5 RID: 11189
			private static readonly IntPtr NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0;
		}

		// Token: 0x02000AB9 RID: 2745
		public sealed class <>c__DisplayClass12_0
		{
		}

		// Token: 0x02000ABA RID: 2746
		public sealed class <>c__DisplayClass13_0
		{
		}

		// Token: 0x02000ABB RID: 2747
		public sealed class <>c__DisplayClass20_0
		{
		}
	}
}
