using System;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x02000091 RID: 145
	public class CommonSocket : Object
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x000A3D34 File Offset: 0x000A1F34
		// Note: this type is marked as 'beforefieldinit'.
		static CommonSocket()
		{
			Il2CppClassPointerStore<CommonSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "CommonSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr);
			CommonSocket.NativeFieldInfoPtr__connectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "_connectionState");
			CommonSocket.NativeFieldInfoPtr_PeerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "PeerToPeer");
			CommonSocket.NativeFieldInfoPtr_Transport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "Transport");
			CommonSocket.NativeFieldInfoPtr_MessagePointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MessagePointers");
			CommonSocket.NativeFieldInfoPtr_InboundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "InboundBuffer");
			CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MAX_MESSAGES");
			CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664843);
			CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664844);
			CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664845);
			CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664846);
			CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664847);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664848);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664849);
			CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664850);
			CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100664851);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000A3E90 File Offset: 0x000A2090
		[CallerCount(0)]
		public unsafe LocalConnectionState GetLocalConnectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000A3ECC File Offset: 0x000A20CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78351, RefRangeEnd = 78354, XrefRangeStart = 78350, XrefRangeEnd = 78351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000A3F24 File Offset: 0x000A2124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78354, XrefRangeEnd = 78364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Transport t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000A3F74 File Offset: 0x000A2174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78372, RefRangeEnd = 78374, XrefRangeStart = 78364, XrefRangeEnd = 78372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetIPBytes(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000A3FC4 File Offset: 0x000A21C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78406, RefRangeEnd = 78409, XrefRangeStart = 78374, XrefRangeEnd = 78406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000A4034 File Offset: 0x000A2234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78409, XrefRangeEnd = 78417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000A4078 File Offset: 0x000A2278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78417, XrefRangeEnd = 78426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(Queue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000A40BC File Offset: 0x000A22BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78438, RefRangeEnd = 78439, XrefRangeStart = 78426, XrefRangeEnd = 78438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMessage(IntPtr ptr, Il2CppStructArray<byte> buffer, out ArraySegment<byte> segment, out byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr3 = &intPtr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &channel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			segment = ((intPtr4 == 0) ? null : new ArraySegment<byte>(intPtr4));
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000A413C File Offset: 0x000A233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78439, XrefRangeEnd = 78444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00007AB9 File Offset: 0x00005CB9
		public CommonSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000A4178 File Offset: 0x000A2378
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public unsafe LocalConnectionState _connectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000A41A0 File Offset: 0x000A23A0
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00007ADD File Offset: 0x00005CDD
		public unsafe bool PeerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x000A41C8 File Offset: 0x000A23C8
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public unsafe Transport Transport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000A41F8 File Offset: 0x000A23F8
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00007B17 File Offset: 0x00005D17
		public unsafe Il2CppStructArray<IntPtr> MessagePointers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000A4228 File Offset: 0x000A2428
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00007B36 File Offset: 0x00005D36
		public unsafe Il2CppStructArray<byte> InboundBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000A4258 File Offset: 0x000A2458
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00007B55 File Offset: 0x00005D55
		public unsafe static int MAX_MESSAGES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&value));
			}
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr__connectionState;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_PeerToPeer;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_Transport;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_MessagePointers;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_InboundBuffer;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGES;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
