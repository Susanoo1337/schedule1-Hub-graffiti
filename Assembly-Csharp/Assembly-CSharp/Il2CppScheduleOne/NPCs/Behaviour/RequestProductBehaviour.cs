using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000683 RID: 1667
	public class RequestProductBehaviour : Behaviour
	{
		// Token: 0x0600A191 RID: 41361 RVA: 0x002B0A00 File Offset: 0x002AEC00
		// Note: this type is marked as 'beforefieldinit'.
		static RequestProductBehaviour()
		{
			Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "RequestProductBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr);
			RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "CONVERSATION_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "FOLLOW_MAX_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_TicksBeforeAskAgain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "TicksBeforeAskAgain");
			RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<State>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr_ticksSinceLastRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "ticksSinceLastRequest");
			RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "requestGreeting");
			RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "acceptRequestChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_followChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "followChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "rejectChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684661);
			RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684662);
			RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684663);
			RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684664);
			RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684665);
			RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684666);
			RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684667);
			RequestProductBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684668);
			RequestProductBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684669);
			RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684670);
			RequestProductBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684671);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684672);
			RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684673);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684674);
			RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684675);
			RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684676);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684677);
			RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684678);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684679);
			RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684680);
			RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684681);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684682);
			RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684683);
			RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684684);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684685);
			RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684686);
			RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684687);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684688);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684689);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684690);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684691);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684692);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684693);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684694);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684695);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684696);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684697);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684698);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684699);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684700);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684701);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684702);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684703);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684704);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684705);
			RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100684706);
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x002B0EB8 File Offset: 0x002AF0B8
		// (set) Token: 0x0600A193 RID: 41363 RVA: 0x002B0EF8 File Offset: 0x002AF0F8
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x002B0F3C File Offset: 0x002AF13C
		// (set) Token: 0x0600A195 RID: 41365 RVA: 0x002B0F78 File Offset: 0x002AF178
		public unsafe RequestProductBehaviour.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x002B0FB8 File Offset: 0x002AF1B8
		public unsafe Customer customer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285140, RefRangeEnd = 285141, XrefRangeStart = 285135, XrefRangeEnd = 285140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr3) : null;
			}
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x002B0FF8 File Offset: 0x002AF1F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285171, RefRangeEnd = 285172, XrefRangeStart = 285141, XrefRangeEnd = 285171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignTarget(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x002B103C File Offset: 0x002AF23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285172, XrefRangeEnd = 285173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x002B1078 File Offset: 0x002AF278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285173, XrefRangeEnd = 285215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x002B10B4 File Offset: 0x002AF2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285215, XrefRangeEnd = 285223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x002B10F0 File Offset: 0x002AF2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x002B112C File Offset: 0x002AF32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285223, XrefRangeEnd = 285289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x002B1168 File Offset: 0x002AF368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285302, RefRangeEnd = 285303, XrefRangeStart = 285289, XrefRangeEnd = 285302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetDestinationValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x002B11A4 File Offset: 0x002AF3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285317, RefRangeEnd = 285318, XrefRangeStart = 285303, XrefRangeEnd = 285317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNewDestination(out Vector3 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x002B11F0 File Offset: 0x002AF3F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285323, RefRangeEnd = 285325, XrefRangeStart = 285318, XrefRangeEnd = 285323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTargetValid(Player player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x002B1234 File Offset: 0x002AF434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285350, RefRangeEnd = 285352, XrefRangeStart = 285325, XrefRangeEnd = 285350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x002B1270 File Offset: 0x002AF470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285452, RefRangeEnd = 285453, XrefRangeStart = 285352, XrefRangeEnd = 285452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002B12A4 File Offset: 0x002AF4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285453, XrefRangeEnd = 285474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x002B12D8 File Offset: 0x002AF4D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285495, RefRangeEnd = 285499, XrefRangeStart = 285474, XrefRangeEnd = 285495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x002B130C File Offset: 0x002AF50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285499, XrefRangeEnd = 285520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x002B1340 File Offset: 0x002AF540
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285541, RefRangeEnd = 285544, XrefRangeStart = 285520, XrefRangeEnd = 285541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x002B1374 File Offset: 0x002AF574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285544, XrefRangeEnd = 285550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DialogueActive(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x002B13C0 File Offset: 0x002AF5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285550, XrefRangeEnd = 285575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x002B13F4 File Offset: 0x002AF5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285575, XrefRangeEnd = 285649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x002B1454 File Offset: 0x002AF654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285649, XrefRangeEnd = 285666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Follow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x002B1488 File Offset: 0x002AF688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285666, XrefRangeEnd = 285673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x002B14BC File Offset: 0x002AF6BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestProductBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x002B14F8 File Offset: 0x002AF6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285673, XrefRangeEnd = 285678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x002B1538 File Offset: 0x002AF738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285678, XrefRangeEnd = 285711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x002B1574 File Offset: 0x002AF774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279316, RefRangeEnd = 279318, XrefRangeStart = 279316, XrefRangeEnd = 279318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x002B15B0 File Offset: 0x002AF7B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x002B15EC File Offset: 0x002AF7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285711, XrefRangeEnd = 285721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x002B1630 File Offset: 0x002AF830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285721, XrefRangeEnd = 285731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x002B1674 File Offset: 0x002AF874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285731, XrefRangeEnd = 285743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x002B16C4 File Offset: 0x002AF8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285743, XrefRangeEnd = 285752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x002B16F8 File Offset: 0x002AF8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285752, XrefRangeEnd = 285753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x002B172C File Offset: 0x002AF92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285753, XrefRangeEnd = 285756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x002B1790 File Offset: 0x002AF990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285756, XrefRangeEnd = 285765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x002B17C4 File Offset: 0x002AF9C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285784, RefRangeEnd = 285786, XrefRangeStart = 285765, XrefRangeEnd = 285784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x002B17F8 File Offset: 0x002AF9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285786, XrefRangeEnd = 285789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x002B1848 File Offset: 0x002AFA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285789, XrefRangeEnd = 285798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x002B187C File Offset: 0x002AFA7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285541, RefRangeEnd = 285544, XrefRangeStart = 285541, XrefRangeEnd = 285544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x002B18B0 File Offset: 0x002AFAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285798, XrefRangeEnd = 285801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x002B1914 File Offset: 0x002AFB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285801, XrefRangeEnd = 285810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x002B1948 File Offset: 0x002AFB48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285829, RefRangeEnd = 285832, XrefRangeStart = 285810, XrefRangeEnd = 285829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x002B197C File Offset: 0x002AFB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285832, XrefRangeEnd = 285835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x002B19CC File Offset: 0x002AFBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x0004A2DC File Offset: 0x000484DC
		public RequestProductBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x002B1A08 File Offset: 0x002AFC08
		// (set) Token: 0x0600A1C2 RID: 41410 RVA: 0x0004A2E5 File Offset: 0x000484E5
		public unsafe static float CONVERSATION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600A1C3 RID: 41411 RVA: 0x002B1A24 File Offset: 0x002AFC24
		// (set) Token: 0x0600A1C4 RID: 41412 RVA: 0x0004A2F3 File Offset: 0x000484F3
		public unsafe static float FOLLOW_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600A1C5 RID: 41413 RVA: 0x002B1A40 File Offset: 0x002AFC40
		// (set) Token: 0x0600A1C6 RID: 41414 RVA: 0x0004A301 File Offset: 0x00048501
		public unsafe static int TicksBeforeAskAgain
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_TicksBeforeAskAgain, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_TicksBeforeAskAgain, (void*)(&value));
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600A1C7 RID: 41415 RVA: 0x002B1A5C File Offset: 0x002AFC5C
		// (set) Token: 0x0600A1C8 RID: 41416 RVA: 0x0004A30F File Offset: 0x0004850F
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600A1C9 RID: 41417 RVA: 0x002B1A8C File Offset: 0x002AFC8C
		// (set) Token: 0x0600A1CA RID: 41418 RVA: 0x0004A32E File Offset: 0x0004852E
		public unsafe RequestProductBehaviour.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600A1CB RID: 41419 RVA: 0x002B1AB4 File Offset: 0x002AFCB4
		// (set) Token: 0x0600A1CC RID: 41420 RVA: 0x0004A349 File Offset: 0x00048549
		public unsafe int ticksSinceLastRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_ticksSinceLastRequest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_ticksSinceLastRequest)) = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x002B1ADC File Offset: 0x002AFCDC
		// (set) Token: 0x0600A1CE RID: 41422 RVA: 0x0004A364 File Offset: 0x00048564
		public unsafe DialogueController.GreetingOverride requestGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600A1CF RID: 41423 RVA: 0x002B1B0C File Offset: 0x002AFD0C
		// (set) Token: 0x0600A1D0 RID: 41424 RVA: 0x0004A383 File Offset: 0x00048583
		public unsafe DialogueController.DialogueChoice acceptRequestChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600A1D1 RID: 41425 RVA: 0x002B1B3C File Offset: 0x002AFD3C
		// (set) Token: 0x0600A1D2 RID: 41426 RVA: 0x0004A3A2 File Offset: 0x000485A2
		public unsafe DialogueController.DialogueChoice followChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x002B1B6C File Offset: 0x002AFD6C
		// (set) Token: 0x0600A1D4 RID: 41428 RVA: 0x0004A3C1 File Offset: 0x000485C1
		public unsafe DialogueController.DialogueChoice rejectChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x002B1B9C File Offset: 0x002AFD9C
		// (set) Token: 0x0600A1D6 RID: 41430 RVA: 0x0004A3E0 File Offset: 0x000485E0
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x002B1BC4 File Offset: 0x002AFDC4
		// (set) Token: 0x0600A1D8 RID: 41432 RVA: 0x0004A3FB File Offset: 0x000485FB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F93 RID: 28563
		private static readonly IntPtr NativeFieldInfoPtr_CONVERSATION_RANGE;

		// Token: 0x04006F94 RID: 28564
		private static readonly IntPtr NativeFieldInfoPtr_FOLLOW_MAX_RANGE;

		// Token: 0x04006F95 RID: 28565
		private static readonly IntPtr NativeFieldInfoPtr_TicksBeforeAskAgain;

		// Token: 0x04006F96 RID: 28566
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04006F97 RID: 28567
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04006F98 RID: 28568
		private static readonly IntPtr NativeFieldInfoPtr_ticksSinceLastRequest;

		// Token: 0x04006F99 RID: 28569
		private static readonly IntPtr NativeFieldInfoPtr_requestGreeting;

		// Token: 0x04006F9A RID: 28570
		private static readonly IntPtr NativeFieldInfoPtr_acceptRequestChoice;

		// Token: 0x04006F9B RID: 28571
		private static readonly IntPtr NativeFieldInfoPtr_followChoice;

		// Token: 0x04006F9C RID: 28572
		private static readonly IntPtr NativeFieldInfoPtr_rejectChoice;

		// Token: 0x04006F9D RID: 28573
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F9E RID: 28574
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F9F RID: 28575
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04006FA0 RID: 28576
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0;

		// Token: 0x04006FA1 RID: 28577
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04006FA2 RID: 28578
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_EState_0;

		// Token: 0x04006FA3 RID: 28579
		private static readonly IntPtr NativeMethodInfoPtr_get_customer_Private_get_Customer_0;

		// Token: 0x04006FA4 RID: 28580
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0;

		// Token: 0x04006FA5 RID: 28581
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006FA6 RID: 28582
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006FA7 RID: 28583
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006FA8 RID: 28584
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04006FA9 RID: 28585
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006FAA RID: 28586
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0;

		// Token: 0x04006FAB RID: 28587
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0;

		// Token: 0x04006FAC RID: 28588
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0;

		// Token: 0x04006FAD RID: 28589
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0;

		// Token: 0x04006FAE RID: 28590
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04006FAF RID: 28591
		private static readonly IntPtr NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0;

		// Token: 0x04006FB0 RID: 28592
		private static readonly IntPtr NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0;

		// Token: 0x04006FB1 RID: 28593
		private static readonly IntPtr NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0;

		// Token: 0x04006FB2 RID: 28594
		private static readonly IntPtr NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0;

		// Token: 0x04006FB3 RID: 28595
		private static readonly IntPtr NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0;

		// Token: 0x04006FB4 RID: 28596
		private static readonly IntPtr NativeMethodInfoPtr_RequestAccepted_Private_Void_0;

		// Token: 0x04006FB5 RID: 28597
		private static readonly IntPtr NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04006FB6 RID: 28598
		private static readonly IntPtr NativeMethodInfoPtr_Follow_Private_Void_0;

		// Token: 0x04006FB7 RID: 28599
		private static readonly IntPtr NativeMethodInfoPtr_RequestRejected_Private_Void_0;

		// Token: 0x04006FB8 RID: 28600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FB9 RID: 28601
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006FBA RID: 28602
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FBB RID: 28603
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FBC RID: 28604
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FBD RID: 28605
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006FBE RID: 28606
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04006FBF RID: 28607
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FC0 RID: 28608
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC1 RID: 28609
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC2 RID: 28610
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FC3 RID: 28611
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC4 RID: 28612
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC5 RID: 28613
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FC6 RID: 28614
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC7 RID: 28615
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FC8 RID: 28616
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FC9 RID: 28617
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FCA RID: 28618
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04006FCB RID: 28619
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FCC RID: 28620
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C6B RID: 3179
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400A36C RID: 41836
			InitialApproach,
			// Token: 0x0400A36D RID: 41837
			FollowPlayer
		}

		// Token: 0x02000C6C RID: 3180
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.RequestProductBehaviour+<<HandoverClosed>g__Wait|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F16A RID: 61802 RVA: 0x003A3B98 File Offset: 0x003A1D98
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
			{
				Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<<HandoverClosed>g__Wait|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684707);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684708);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684709);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684710);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684711);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100684712);
			}

			// Token: 0x0600F16B RID: 61803 RVA: 0x003A3C78 File Offset: 0x003A1E78
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F16C RID: 61804 RVA: 0x003A3CC0 File Offset: 0x003A1EC0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F16D RID: 61805 RVA: 0x003A3CF4 File Offset: 0x003A1EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285125, XrefRangeEnd = 285130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004949 RID: 18761
			// (get) Token: 0x0600F16E RID: 61806 RVA: 0x003A3D30 File Offset: 0x003A1F30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F16F RID: 61807 RVA: 0x003A3D70 File Offset: 0x003A1F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285130, XrefRangeEnd = 285135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700494A RID: 18762
			// (get) Token: 0x0600F170 RID: 61808 RVA: 0x003A3DA4 File Offset: 0x003A1FA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F171 RID: 61809 RVA: 0x00071EFF File Offset: 0x000700FF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004946 RID: 18758
			// (get) Token: 0x0600F172 RID: 61810 RVA: 0x003A3DE4 File Offset: 0x003A1FE4
			// (set) Token: 0x0600F173 RID: 61811 RVA: 0x00071F08 File Offset: 0x00070108
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004947 RID: 18759
			// (get) Token: 0x0600F174 RID: 61812 RVA: 0x003A3E0C File Offset: 0x003A200C
			// (set) Token: 0x0600F175 RID: 61813 RVA: 0x00071F23 File Offset: 0x00070123
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004948 RID: 18760
			// (get) Token: 0x0600F176 RID: 61814 RVA: 0x003A3E3C File Offset: 0x003A203C
			// (set) Token: 0x0600F177 RID: 61815 RVA: 0x00071F42 File Offset: 0x00070142
			public unsafe RequestProductBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A36E RID: 41838
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A36F RID: 41839
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A370 RID: 41840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A371 RID: 41841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A372 RID: 41842
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A373 RID: 41843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A374 RID: 41844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A375 RID: 41845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A376 RID: 41846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
