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
	// Token: 0x020001CF RID: 463
	[Serializable]
	public class PlayerEditorConnectionEvents : Object
	{
		// Token: 0x0600210C RID: 8460 RVA: 0x000865E4 File Offset: 0x000847E4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEditorConnectionEvents()
		{
			Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerEditorConnectionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "messageTypeSubscribers");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "connectionEvent");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "disconnectionEvent");
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100666898);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100666899);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100666900);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100666901);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000866A0 File Offset: 0x000848A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287098, RefRangeEnd = 1287099, XrefRangeStart = 1287047, XrefRangeEnd = 1287098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeMessageIdSubscribers(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00086700 File Offset: 0x00084900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287135, RefRangeEnd = 1287136, XrefRangeStart = 1287099, XrefRangeEnd = 1287135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Events.UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<MessageEventArgs>>(intPtr3) : null;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0008674C File Offset: 0x0008494C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287136, XrefRangeEnd = 1287155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0008679C File Offset: 0x0008499C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287155, XrefRangeEnd = 1287176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEditorConnectionEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0000F485 File Offset: 0x0000D685
		public PlayerEditorConnectionEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000867D8 File Offset: 0x000849D8
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000F48E File Offset: 0x0000D68E
		public unsafe List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00086808 File Offset: 0x00084A08
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000F4AD File Offset: 0x0000D6AD
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00086838 File Offset: 0x00084A38
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_messageTypeSubscribers;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_connectionEvent;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_disconnectionEvent;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABC RID: 2748
		[Serializable]
		public class MessageEvent : UnityEngine.Events.UnityEvent<MessageEventArgs>
		{
			// Token: 0x06003E50 RID: 15952 RVA: 0x000182D7 File Offset: 0x000164D7
			// Note: this type is marked as 'beforefieldinit'.
			static MessageEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr, 100666902);
			}

			// Token: 0x06003E51 RID: 15953 RVA: 0x000B47B0 File Offset: 0x000B29B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287032, XrefRangeEnd = 1287035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E52 RID: 15954 RVA: 0x0001830B File Offset: 0x0001650B
			public MessageEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04002BB6 RID: 11190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ABD RID: 2749
		[Serializable]
		public class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
		{
			// Token: 0x06003E53 RID: 15955 RVA: 0x00018314 File Offset: 0x00016514
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChangeEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "ConnectionChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr, 100666903);
			}

			// Token: 0x06003E54 RID: 15956 RVA: 0x000B47EC File Offset: 0x000B29EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287035, XrefRangeEnd = 1287038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChangeEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E55 RID: 15957 RVA: 0x00018348 File Offset: 0x00016548
			public ConnectionChangeEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04002BB7 RID: 11191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ABE RID: 2750
		[Serializable]
		public class MessageTypeSubscribers : Object
		{
			// Token: 0x06003E56 RID: 15958 RVA: 0x000B4828 File Offset: 0x000B2A28
			// Note: this type is marked as 'beforefieldinit'.
			static MessageTypeSubscribers()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageTypeSubscribers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "m_messageTypeId");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "subscriberCount");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "messageCallback");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100666904);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100666905);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100666906);
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000B48CC File Offset: 0x000B2ACC
			// (set) Token: 0x06003E58 RID: 15960 RVA: 0x000B4908 File Offset: 0x000B2B08
			public unsafe Guid MessageTypeId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287038, XrefRangeEnd = 1287039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E59 RID: 15961 RVA: 0x000B4948 File Offset: 0x000B2B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287039, XrefRangeEnd = 1287047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageTypeSubscribers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E5A RID: 15962 RVA: 0x00018351 File Offset: 0x00016551
			public MessageTypeSubscribers(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06003E5B RID: 15963 RVA: 0x000B4984 File Offset: 0x000B2B84
			// (set) Token: 0x06003E5C RID: 15964 RVA: 0x0001835A File Offset: 0x0001655A
			public unsafe string m_messageTypeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06003E5D RID: 15965 RVA: 0x000B49AC File Offset: 0x000B2BAC
			// (set) Token: 0x06003E5E RID: 15966 RVA: 0x00018379 File Offset: 0x00016579
			public unsafe int subscriberCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount)) = value;
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06003E5F RID: 15967 RVA: 0x000B49D4 File Offset: 0x000B2BD4
			// (set) Token: 0x06003E60 RID: 15968 RVA: 0x00018394 File Offset: 0x00016594
			public unsafe PlayerEditorConnectionEvents.MessageEvent messageCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.MessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BB8 RID: 11192
			private static readonly IntPtr NativeFieldInfoPtr_m_messageTypeId;

			// Token: 0x04002BB9 RID: 11193
			private static readonly IntPtr NativeFieldInfoPtr_subscriberCount;

			// Token: 0x04002BBA RID: 11194
			private static readonly IntPtr NativeFieldInfoPtr_messageCallback;

			// Token: 0x04002BBB RID: 11195
			private static readonly IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;

			// Token: 0x04002BBC RID: 11196
			private static readonly IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;

			// Token: 0x04002BBD RID: 11197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ABF RID: 2751
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06003E61 RID: 15969 RVA: 0x000B4A04 File Offset: 0x000B2C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100666907);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100666908);
			}

			// Token: 0x06003E62 RID: 15970 RVA: 0x000B4A6C File Offset: 0x000B2C6C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E63 RID: 15971 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InvokeMessageIdSubscribers_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E64 RID: 15972 RVA: 0x000183B3 File Offset: 0x000165B3
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x06003E65 RID: 15973 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
			// (set) Token: 0x06003E66 RID: 15974 RVA: 0x000183BC File Offset: 0x000165BC
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002BBE RID: 11198
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002BBF RID: 11199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BC0 RID: 11200
			private static readonly IntPtr NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000AC0 RID: 2752
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06003E67 RID: 15975 RVA: 0x000B4B20 File Offset: 0x000B2D20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100666909);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100666910);
			}

			// Token: 0x06003E68 RID: 15976 RVA: 0x000B4B88 File Offset: 0x000B2D88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E69 RID: 15977 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAndCreate_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E6A RID: 15978 RVA: 0x000183D7 File Offset: 0x000165D7
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x06003E6B RID: 15979 RVA: 0x000B4C14 File Offset: 0x000B2E14
			// (set) Token: 0x06003E6C RID: 15980 RVA: 0x000183E0 File Offset: 0x000165E0
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002BC1 RID: 11201
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002BC2 RID: 11202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BC3 RID: 11203
			private static readonly IntPtr NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000AC1 RID: 2753
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06003E6D RID: 15981 RVA: 0x000B4C3C File Offset: 0x000B2E3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100666911);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100666912);
			}

			// Token: 0x06003E6E RID: 15982 RVA: 0x000B4CA4 File Offset: 0x000B2EA4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E6F RID: 15983 RVA: 0x000B4CE0 File Offset: 0x000B2EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnregisterManagedCallback_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E70 RID: 15984 RVA: 0x000183FB File Offset: 0x000165FB
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06003E71 RID: 15985 RVA: 0x000B4D30 File Offset: 0x000B2F30
			// (set) Token: 0x06003E72 RID: 15986 RVA: 0x00018404 File Offset: 0x00016604
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002BC4 RID: 11204
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002BC5 RID: 11205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BC6 RID: 11206
			private static readonly IntPtr NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000AC2 RID: 2754
		public sealed class <>c__DisplayClass6_0
		{
		}

		// Token: 0x02000AC3 RID: 2755
		public sealed class <>c__DisplayClass7_0
		{
		}

		// Token: 0x02000AC4 RID: 2756
		public sealed class <>c__DisplayClass8_0
		{
		}
	}
}
