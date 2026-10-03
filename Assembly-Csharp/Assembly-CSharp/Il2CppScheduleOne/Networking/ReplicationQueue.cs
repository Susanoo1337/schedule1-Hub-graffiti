using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029E RID: 670
	public class ReplicationQueue : NetworkSingleton<ReplicationQueue>
	{
		// Token: 0x060032CB RID: 13003 RVA: 0x001231DC File Offset: 0x001213DC
		// Note: this type is marked as 'beforefieldinit'.
		static ReplicationQueue()
		{
			Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "ReplicationQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr);
			ReplicationQueue.NativeFieldInfoPtr_RATE_LIMIT_BYTES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "RATE_LIMIT_BYTES_PER_SECOND");
			ReplicationQueue.NativeFieldInfoPtr_MAX_REPLICATION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "MAX_REPLICATION_DURATION");
			ReplicationQueue.NativeFieldInfoPtr__ReplicationDoneForLocalPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "<ReplicationDoneForLocalPlayer>k__BackingField");
			ReplicationQueue.NativeFieldInfoPtr__CurrentReplicationTask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "<CurrentReplicationTask>k__BackingField");
			ReplicationQueue.NativeFieldInfoPtr_requestsByConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "requestsByConnection");
			ReplicationQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "queue");
			ReplicationQueue.NativeFieldInfoPtr_currentByteBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "currentByteBudget");
			ReplicationQueue.NativeFieldInfoPtr_timeOnLastReplicationTaskRPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "timeOnLastReplicationTaskRPC");
			ReplicationQueue.NativeFieldInfoPtr_timeOnReplicationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "timeOnReplicationStart");
			ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted");
			ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted");
			ReplicationQueue.NativeMethodInfoPtr_get_ReplicationDoneForLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669645);
			ReplicationQueue.NativeMethodInfoPtr_set_ReplicationDoneForLocalPlayer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669646);
			ReplicationQueue.NativeMethodInfoPtr_get_LocalPlayerReplicationTimedOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669647);
			ReplicationQueue.NativeMethodInfoPtr_get_CurrentReplicationTask_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669648);
			ReplicationQueue.NativeMethodInfoPtr_set_CurrentReplicationTask_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669649);
			ReplicationQueue.NativeMethodInfoPtr_Enqueue_Public_Static_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669650);
			ReplicationQueue.NativeMethodInfoPtr_GetReplicationDuration_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669651);
			ReplicationQueue.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669652);
			ReplicationQueue.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669653);
			ReplicationQueue.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669654);
			ReplicationQueue.NativeMethodInfoPtr_SetReplicationDone_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669655);
			ReplicationQueue.NativeMethodInfoPtr_SetReplicationTask_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669656);
			ReplicationQueue.NativeMethodInfoPtr_Enqueue__Private_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669657);
			ReplicationQueue.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669658);
			ReplicationQueue.NativeMethodInfoPtr_NotifyActiveReplicationTask_Private_Void_ReplicationRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669659);
			ReplicationQueue.NativeMethodInfoPtr_GetRequestsForConnection_Public_List_1_ReplicationRequest_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669660);
			ReplicationQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669661);
			ReplicationQueue.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669662);
			ReplicationQueue.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669663);
			ReplicationQueue.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669664);
			ReplicationQueue.NativeMethodInfoPtr_RpcWriter___Target_SetReplicationDone_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669665);
			ReplicationQueue.NativeMethodInfoPtr_RpcLogic___SetReplicationDone_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669666);
			ReplicationQueue.NativeMethodInfoPtr_RpcReader___Target_SetReplicationDone_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669667);
			ReplicationQueue.NativeMethodInfoPtr_RpcWriter___Target_SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669668);
			ReplicationQueue.NativeMethodInfoPtr_RpcLogic___SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669669);
			ReplicationQueue.NativeMethodInfoPtr_RpcReader___Target_SetReplicationTask_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669670);
			ReplicationQueue.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, 100669671);
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x00123504 File Offset: 0x00121704
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00123540 File Offset: 0x00121740
		public unsafe bool ReplicationDoneForLocalPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_get_ReplicationDoneForLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_set_ReplicationDoneForLocalPlayer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x00123580 File Offset: 0x00121780
		public unsafe bool LocalPlayerReplicationTimedOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137038, XrefRangeEnd = 137039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_get_LocalPlayerReplicationTimedOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x001235BC File Offset: 0x001217BC
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x001235F4 File Offset: 0x001217F4
		public unsafe string CurrentReplicationTask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_get_CurrentReplicationTask_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_set_CurrentReplicationTask_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00123638 File Offset: 0x00121838
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 137044, RefRangeEnd = 137054, XrefRangeStart = 137039, XrefRangeEnd = 137044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enqueue(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(taskName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref approximateSizeBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_Enqueue_Public_Static_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x001236A0 File Offset: 0x001218A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137054, RefRangeEnd = 137059, XrefRangeStart = 137054, XrefRangeEnd = 137054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetReplicationDuration(int approximateSizeBytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref approximateSizeBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_GetReplicationDuration_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001236E0 File Offset: 0x001218E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137059, XrefRangeEnd = 137060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0012371C File Offset: 0x0012191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137060, XrefRangeEnd = 137062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00123758 File Offset: 0x00121958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137062, XrefRangeEnd = 137076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x001237A8 File Offset: 0x001219A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137076, XrefRangeEnd = 137085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReplicationDone(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_SetReplicationDone_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001237EC File Offset: 0x001219EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137085, XrefRangeEnd = 137095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReplicationTask(NetworkConnection conn, string task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_SetReplicationTask_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00123840 File Offset: 0x00121A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137127, RefRangeEnd = 137128, XrefRangeStart = 137095, XrefRangeEnd = 137127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue_(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(taskName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref approximateSizeBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_Enqueue__Private_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x001238B4 File Offset: 0x00121AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137128, XrefRangeEnd = 137158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x001238E8 File Offset: 0x00121AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137181, RefRangeEnd = 137182, XrefRangeStart = 137158, XrefRangeEnd = 137181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyActiveReplicationTask(ReplicationQueue.ReplicationRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_NotifyActiveReplicationTask_Private_Void_ReplicationRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x0012392C File Offset: 0x00121B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137182, XrefRangeEnd = 137191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ReplicationQueue.ReplicationRequest> GetRequestsForConnection(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_GetRequestsForConnection_Public_List_1_ReplicationRequest_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ReplicationQueue.ReplicationRequest>>(intPtr3) : null;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0012397C File Offset: 0x00121B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137191, XrefRangeEnd = 137211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplicationQueue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x001239B8 File Offset: 0x00121BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137211, XrefRangeEnd = 137227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x001239F4 File Offset: 0x00121BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137227, XrefRangeEnd = 137230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00123A30 File Offset: 0x00121C30
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00123A6C File Offset: 0x00121C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetReplicationDone_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcWriter___Target_SetReplicationDone_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00123AB0 File Offset: 0x00121CB0
		[CallerCount(0)]
		public unsafe void RpcLogic___SetReplicationDone_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcLogic___SetReplicationDone_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00123AF4 File Offset: 0x00121CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137230, XrefRangeEnd = 137232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetReplicationDone_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcReader___Target_SetReplicationDone_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00123B44 File Offset: 0x00121D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetReplicationTask_2971853958(NetworkConnection conn, string task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcWriter___Target_SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00123B98 File Offset: 0x00121D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137232, XrefRangeEnd = 137233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetReplicationTask_2971853958(NetworkConnection conn, string task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcLogic___SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00123BEC File Offset: 0x00121DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137233, XrefRangeEnd = 137237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetReplicationTask_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.NativeMethodInfoPtr_RpcReader___Target_SetReplicationTask_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00123C3C File Offset: 0x00121E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137237, XrefRangeEnd = 137240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplicationQueue.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0001A15C File Offset: 0x0001835C
		public ReplicationQueue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x00123C78 File Offset: 0x00121E78
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x0001A165 File Offset: 0x00018365
		public unsafe static int RATE_LIMIT_BYTES_PER_SECOND
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ReplicationQueue.NativeFieldInfoPtr_RATE_LIMIT_BYTES_PER_SECOND, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReplicationQueue.NativeFieldInfoPtr_RATE_LIMIT_BYTES_PER_SECOND, (void*)(&value));
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x00123C94 File Offset: 0x00121E94
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x0001A173 File Offset: 0x00018373
		public unsafe static int MAX_REPLICATION_DURATION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ReplicationQueue.NativeFieldInfoPtr_MAX_REPLICATION_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReplicationQueue.NativeFieldInfoPtr_MAX_REPLICATION_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x00123CB0 File Offset: 0x00121EB0
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x0001A181 File Offset: 0x00018381
		public unsafe bool _ReplicationDoneForLocalPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr__ReplicationDoneForLocalPlayer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr__ReplicationDoneForLocalPlayer_k__BackingField)) = value;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00123CD8 File Offset: 0x00121ED8
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0001A19C File Offset: 0x0001839C
		public unsafe string _CurrentReplicationTask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr__CurrentReplicationTask_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr__CurrentReplicationTask_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00123D00 File Offset: 0x00121F00
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x0001A1BB File Offset: 0x000183BB
		public unsafe Dictionary<NetworkConnection, List<ReplicationQueue.ReplicationRequest>> requestsByConnection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_requestsByConnection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NetworkConnection, List<ReplicationQueue.ReplicationRequest>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_requestsByConnection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00123D30 File Offset: 0x00121F30
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x0001A1DA File Offset: 0x000183DA
		public unsafe List<ReplicationQueue.ReplicationRequest> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReplicationQueue.ReplicationRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x00123D60 File Offset: 0x00121F60
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0001A1F9 File Offset: 0x000183F9
		public unsafe int currentByteBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_currentByteBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_currentByteBudget)) = value;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00123D88 File Offset: 0x00121F88
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0001A214 File Offset: 0x00018414
		public unsafe float timeOnLastReplicationTaskRPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_timeOnLastReplicationTaskRPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_timeOnLastReplicationTaskRPC)) = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00123DB0 File Offset: 0x00121FB0
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x0001A22F File Offset: 0x0001842F
		public unsafe float timeOnReplicationStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_timeOnReplicationStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_timeOnReplicationStart)) = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x00123DD8 File Offset: 0x00121FD8
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x0001A24A File Offset: 0x0001844A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00123E00 File Offset: 0x00122000
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x0001A265 File Offset: 0x00018465
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeFieldInfoPtr_RATE_LIMIT_BYTES_PER_SECOND;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeFieldInfoPtr_MAX_REPLICATION_DURATION;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeFieldInfoPtr__ReplicationDoneForLocalPlayer_k__BackingField;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeFieldInfoPtr__CurrentReplicationTask_k__BackingField;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr_requestsByConnection;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr_currentByteBudget;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastReplicationTaskRPC;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeFieldInfoPtr_timeOnReplicationStart;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplicationDoneForLocalPlayer_Public_get_Boolean_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_set_ReplicationDoneForLocalPlayer_Private_set_Void_Boolean_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerReplicationTimedOut_Public_get_Boolean_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentReplicationTask_Public_get_String_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentReplicationTask_Private_set_Void_String_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Static_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_GetReplicationDuration_Public_Static_Single_Int32_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_SetReplicationDone_Private_Void_NetworkConnection_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_SetReplicationTask_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue__Private_Void_String_NetworkConnection_Action_1_NetworkConnection_Int32_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_NotifyActiveReplicationTask_Private_Void_ReplicationRequest_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestsForConnection_Public_List_1_ReplicationRequest_NetworkConnection_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetReplicationDone_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetReplicationDone_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetReplicationDone_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetReplicationTask_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetReplicationTask_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009FC RID: 2556
		public class ReplicationRequest : Object
		{
			// Token: 0x0600DD3C RID: 56636 RVA: 0x0036A0F8 File Offset: 0x003682F8
			// Note: this type is marked as 'beforefieldinit'.
			static ReplicationRequest()
			{
				Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "ReplicationRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr);
				ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_TaskName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, "TaskName");
				ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, "Target");
				ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, "Callback");
				ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_ApproximateSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, "ApproximateSizeBytes");
				ReplicationQueue.ReplicationRequest.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, 100669672);
				ReplicationQueue.ReplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr, 100669673);
			}

			// Token: 0x0600DD3D RID: 56637 RVA: 0x0036A19C File Offset: 0x0036839C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137006, RefRangeEnd = 137007, XrefRangeStart = 137004, XrefRangeEnd = 137006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.ReplicationRequest.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD3E RID: 56638 RVA: 0x0036A1D8 File Offset: 0x003683D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReplicationRequest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplicationQueue.ReplicationRequest>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.ReplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD3F RID: 56639 RVA: 0x0006821B File Offset: 0x0006641B
			public ReplicationRequest(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0600DD40 RID: 56640 RVA: 0x0036A214 File Offset: 0x00368414
			// (set) Token: 0x0600DD41 RID: 56641 RVA: 0x00068224 File Offset: 0x00066424
			public unsafe string TaskName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_TaskName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_TaskName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004361 RID: 17249
			// (get) Token: 0x0600DD42 RID: 56642 RVA: 0x0036A23C File Offset: 0x0036843C
			// (set) Token: 0x0600DD43 RID: 56643 RVA: 0x00068243 File Offset: 0x00066443
			public unsafe NetworkConnection Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004362 RID: 17250
			// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x0036A26C File Offset: 0x0036846C
			// (set) Token: 0x0600DD45 RID: 56645 RVA: 0x00068262 File Offset: 0x00066462
			public unsafe Action<NetworkConnection> Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NetworkConnection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004363 RID: 17251
			// (get) Token: 0x0600DD46 RID: 56646 RVA: 0x0036A29C File Offset: 0x0036849C
			// (set) Token: 0x0600DD47 RID: 56647 RVA: 0x00068281 File Offset: 0x00066481
			public unsafe int ApproximateSizeBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_ApproximateSizeBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.ReplicationRequest.NativeFieldInfoPtr_ApproximateSizeBytes)) = value;
				}
			}

			// Token: 0x040096D6 RID: 38614
			private static readonly IntPtr NativeFieldInfoPtr_TaskName;

			// Token: 0x040096D7 RID: 38615
			private static readonly IntPtr NativeFieldInfoPtr_Target;

			// Token: 0x040096D8 RID: 38616
			private static readonly IntPtr NativeFieldInfoPtr_Callback;

			// Token: 0x040096D9 RID: 38617
			private static readonly IntPtr NativeFieldInfoPtr_ApproximateSizeBytes;

			// Token: 0x040096DA RID: 38618
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

			// Token: 0x040096DB RID: 38619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009FD RID: 2557
		[ObfuscatedName("ScheduleOne.Networking.ReplicationQueue+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600DD48 RID: 56648 RVA: 0x0036A2C4 File Offset: 0x003684C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplicationQueue>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr);
				ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, "connection");
				ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, 100669674);
				ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, 100669675);
				ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, 100669676);
				ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__OnSpawnServer_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, 100669677);
			}

			// Token: 0x0600DD49 RID: 56649 RVA: 0x0036A368 File Offset: 0x00368568
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD4A RID: 56650 RVA: 0x0036A3A4 File Offset: 0x003685A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137025, XrefRangeEnd = 137030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD4B RID: 56651 RVA: 0x0036A3E4 File Offset: 0x003685E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137030, XrefRangeEnd = 137034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD4C RID: 56652 RVA: 0x0036A420 File Offset: 0x00368620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137034, XrefRangeEnd = 137038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.NativeMethodInfoPtr__OnSpawnServer_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD4D RID: 56653 RVA: 0x0006829C File Offset: 0x0006649C
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004364 RID: 17252
			// (get) Token: 0x0600DD4E RID: 56654 RVA: 0x0036A45C File Offset: 0x0036865C
			// (set) Token: 0x0600DD4F RID: 56655 RVA: 0x000682A5 File Offset: 0x000664A5
			public unsafe ReplicationQueue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplicationQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004365 RID: 17253
			// (get) Token: 0x0600DD50 RID: 56656 RVA: 0x0036A48C File Offset: 0x0036868C
			// (set) Token: 0x0600DD51 RID: 56657 RVA: 0x000682C4 File Offset: 0x000664C4
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096DC RID: 38620
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096DD RID: 38621
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x040096DE RID: 38622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096DF RID: 38623
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040096E0 RID: 38624
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0;

			// Token: 0x040096E1 RID: 38625
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__2_Internal_Boolean_0;

			// Token: 0x02000DBE RID: 3518
			[ObfuscatedName("ScheduleOne.Networking.ReplicationQueue+<>c__DisplayClass22_0+<<OnSpawnServer>g__WaitForReplicationComplete|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600FE35 RID: 65077 RVA: 0x003C7F84 File Offset: 0x003C6184
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0>.NativeClassPtr, "<<OnSpawnServer>g__WaitForReplicationComplete|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669678);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669679);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669680);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669681);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669682);
					ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669683);
				}

				// Token: 0x0600FE36 RID: 65078 RVA: 0x003C8064 File Offset: 0x003C6264
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE37 RID: 65079 RVA: 0x003C80AC File Offset: 0x003C62AC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE38 RID: 65080 RVA: 0x003C80E0 File Offset: 0x003C62E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137007, XrefRangeEnd = 137020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D54 RID: 19796
				// (get) Token: 0x0600FE39 RID: 65081 RVA: 0x003C811C File Offset: 0x003C631C
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE3A RID: 65082 RVA: 0x003C815C File Offset: 0x003C635C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137020, XrefRangeEnd = 137025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D55 RID: 19797
				// (get) Token: 0x0600FE3B RID: 65083 RVA: 0x003C8190 File Offset: 0x003C6390
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE3C RID: 65084 RVA: 0x0007872E File Offset: 0x0007692E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D51 RID: 19793
				// (get) Token: 0x0600FE3D RID: 65085 RVA: 0x003C81D0 File Offset: 0x003C63D0
				// (set) Token: 0x0600FE3E RID: 65086 RVA: 0x00078737 File Offset: 0x00076937
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D52 RID: 19794
				// (get) Token: 0x0600FE3F RID: 65087 RVA: 0x003C81F8 File Offset: 0x003C63F8
				// (set) Token: 0x0600FE40 RID: 65088 RVA: 0x00078752 File Offset: 0x00076952
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D53 RID: 19795
				// (get) Token: 0x0600FE41 RID: 65089 RVA: 0x003C8228 File Offset: 0x003C6428
				// (set) Token: 0x0600FE42 RID: 65090 RVA: 0x00078771 File Offset: 0x00076971
				public unsafe ReplicationQueue.__c__DisplayClass22_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplicationQueue.__c__DisplayClass22_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplicationQueue.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB57 RID: 43863
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB58 RID: 43864
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB59 RID: 43865
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB5A RID: 43866
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB5B RID: 43867
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB5C RID: 43868
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB5D RID: 43869
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB5E RID: 43870
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB5F RID: 43871
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
