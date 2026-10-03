using System;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000095 RID: 149
	public class ClientHostSocket : CommonSocket
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x000A6388 File Offset: 0x000A4588
		// Note: this type is marked as 'beforefieldinit'.
		static ClientHostSocket()
		{
			Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientHostSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr);
			ClientHostSocket.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_server");
			ClientHostSocket.NativeFieldInfoPtr__incoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_incoming");
			ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664921);
			ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664922);
			ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664923);
			ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664924);
			ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664925);
			ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664926);
			ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664927);
			ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100664928);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000A6480 File Offset: 0x000A4680
		[CallerCount(0)]
		public unsafe void CheckSetStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000A64B4 File Offset: 0x000A46B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79073, XrefRangeEnd = 79075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(ServerSocket serverSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverSocket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000A6504 File Offset: 0x000A4704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79075, XrefRangeEnd = 79079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000A655C File Offset: 0x000A475C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79089, RefRangeEnd = 79091, XrefRangeStart = 79079, XrefRangeEnd = 79089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000A6598 File Offset: 0x000A4798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79091, XrefRangeEnd = 79107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000A65CC File Offset: 0x000A47CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79107, XrefRangeEnd = 79110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromLocalServer(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000A6614 File Offset: 0x000A4814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79110, XrefRangeEnd = 79125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000A666C File Offset: 0x000A486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79125, XrefRangeEnd = 79137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientHostSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00007F2F File Offset: 0x0000612F
		public ClientHostSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000A66A8 File Offset: 0x000A48A8
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00007F38 File Offset: 0x00006138
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000A66D8 File Offset: 0x000A48D8
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00007F57 File Offset: 0x00006157
		public unsafe Queue<LocalPacket> _incoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr__incoming;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
