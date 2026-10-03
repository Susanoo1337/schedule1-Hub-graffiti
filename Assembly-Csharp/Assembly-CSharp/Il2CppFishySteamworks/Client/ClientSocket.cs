using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000096 RID: 150
	public class ClientSocket : CommonSocket
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x000A6708 File Offset: 0x000A4908
		// Note: this type is marked as 'beforefieldinit'.
		static ClientSocket()
		{
			Il2CppClassPointerStore<ClientSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr);
			ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_onLocalConnectionStateCallback");
			ClientSocket.NativeFieldInfoPtr__hostSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_hostSteamID");
			ClientSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_socket");
			ClientSocket.NativeFieldInfoPtr__timeoutThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_timeoutThread");
			ClientSocket.NativeFieldInfoPtr__connectTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_connectTimeout");
			ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "CONNECT_TIMEOUT_DURATION");
			ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664929);
			ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664930);
			ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664931);
			ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664932);
			ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664933);
			ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664934);
			ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664935);
			ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100664936);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000A6850 File Offset: 0x000A4A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79137, XrefRangeEnd = 79168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000A6884 File Offset: 0x000A4A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79168, XrefRangeEnd = 79205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000A68F0 File Offset: 0x000A4AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79205, XrefRangeEnd = 79216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000A6938 File Offset: 0x000A4B38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 79235, RefRangeEnd = 79239, XrefRangeStart = 79216, XrefRangeEnd = 79235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000A6974 File Offset: 0x000A4B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79253, RefRangeEnd = 79254, XrefRangeStart = 79239, XrefRangeEnd = 79253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000A69A8 File Offset: 0x000A4BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79254, XrefRangeEnd = 79263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000A6A00 File Offset: 0x000A4C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79263, XrefRangeEnd = 79264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000A6A34 File Offset: 0x000A4C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79264, XrefRangeEnd = 79273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00007F76 File Offset: 0x00006176
		public ClientSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000A6A70 File Offset: 0x000A4C70
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00007F7F File Offset: 0x0000617F
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000A6AA0 File Offset: 0x000A4CA0
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00007F9E File Offset: 0x0000619E
		public unsafe CSteamID _hostSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x000A6AC8 File Offset: 0x000A4CC8
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00007FB9 File Offset: 0x000061B9
		public unsafe HSteamNetConnection _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x000A6AF0 File Offset: 0x000A4CF0
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00007FD4 File Offset: 0x000061D4
		public unsafe Thread _timeoutThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000A6B20 File Offset: 0x000A4D20
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00007FF3 File Offset: 0x000061F3
		public unsafe float _connectTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout)) = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000A6B48 File Offset: 0x000A4D48
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x0000800E File Offset: 0x0000620E
		public unsafe static float CONNECT_TIMEOUT_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&value));
			}
		}

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr__onLocalConnectionStateCallback;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr__hostSteamID;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr__timeoutThread;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr__connectTimeout;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Private_Void_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
