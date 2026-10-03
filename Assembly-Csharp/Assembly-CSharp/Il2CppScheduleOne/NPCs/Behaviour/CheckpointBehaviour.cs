using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000659 RID: 1625
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x06009B2A RID: 39722 RVA: 0x00297A4C File Offset: 0x00295C4C
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointBehaviour()
		{
			Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CheckpointBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr);
			CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "LOOK_TIME");
			CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<AssignedCheckpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Checkpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<CurrentSearchedVehicle>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Initiator>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "currentLookTime");
			CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "trunkOpened");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683492);
			CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683493);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683494);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683495);
			CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683496);
			CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683497);
			CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683498);
			CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683499);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683500);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683501);
			CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683502);
			CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683503);
			CheckpointBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683504);
			CheckpointBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683505);
			CheckpointBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683506);
			CheckpointBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683507);
			CheckpointBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683508);
			CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683509);
			CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683510);
			CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683511);
			CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683512);
			CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683513);
			CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683514);
			CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683515);
			CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683516);
			CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683517);
			CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683518);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683519);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683520);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683521);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683522);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683523);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683524);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683525);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683526);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683527);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683528);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683529);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683530);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683531);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683532);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683533);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683534);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683535);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683536);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683537);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683538);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683539);
			CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100683540);
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x00297F18 File Offset: 0x00296118
		// (set) Token: 0x06009B2C RID: 39724 RVA: 0x00297F54 File Offset: 0x00296154
		public unsafe CheckpointManager.ECheckpointLocation AssignedCheckpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009B2D RID: 39725 RVA: 0x00297F94 File Offset: 0x00296194
		// (set) Token: 0x06009B2E RID: 39726 RVA: 0x00297FD4 File Offset: 0x002961D4
		public unsafe RoadCheckpoint Checkpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x00298018 File Offset: 0x00296218
		// (set) Token: 0x06009B30 RID: 39728 RVA: 0x00298054 File Offset: 0x00296254
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009B31 RID: 39729 RVA: 0x00298094 File Offset: 0x00296294
		// (set) Token: 0x06009B32 RID: 39730 RVA: 0x002980D4 File Offset: 0x002962D4
		public unsafe LandVehicle CurrentSearchedVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009B33 RID: 39731 RVA: 0x00298118 File Offset: 0x00296318
		// (set) Token: 0x06009B34 RID: 39732 RVA: 0x00298158 File Offset: 0x00296358
		public unsafe Player Initiator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x0029819C File Offset: 0x0029639C
		public unsafe Transform standPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 276291, RefRangeEnd = 276294, XrefRangeStart = 276286, XrefRangeEnd = 276291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x06009B36 RID: 39734 RVA: 0x002981DC File Offset: 0x002963DC
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276294, XrefRangeEnd = 276295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x0029821C File Offset: 0x0029641C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276295, XrefRangeEnd = 276320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x00298258 File Offset: 0x00296458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276320, XrefRangeEnd = 276345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x00298294 File Offset: 0x00296494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276345, XrefRangeEnd = 276369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x002982D0 File Offset: 0x002964D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276369, XrefRangeEnd = 276385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0029830C File Offset: 0x0029650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276385, XrefRangeEnd = 276469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x00298348 File Offset: 0x00296548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276489, RefRangeEnd = 276490, XrefRangeStart = 276469, XrefRangeEnd = 276489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x00298388 File Offset: 0x00296588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276490, XrefRangeEnd = 276515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInitiator(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x002983CC File Offset: 0x002965CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276538, RefRangeEnd = 276540, XrefRangeStart = 276515, XrefRangeEnd = 276538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x00298420 File Offset: 0x00296620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276561, RefRangeEnd = 276563, XrefRangeStart = 276540, XrefRangeEnd = 276561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x00298454 File Offset: 0x00296654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276585, RefRangeEnd = 276587, XrefRangeStart = 276563, XrefRangeEnd = 276585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSearching(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x00298494 File Offset: 0x00296694
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276592, RefRangeEnd = 276595, XrefRangeStart = 276587, XrefRangeEnd = 276592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetSearchPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x002984D0 File Offset: 0x002966D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276595, XrefRangeEnd = 276616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcludeSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x00298504 File Offset: 0x00296704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276662, RefRangeEnd = 276663, XrefRangeStart = 276616, XrefRangeEnd = 276662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesVehicleContainIllicitItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x00298540 File Offset: 0x00296740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276663, XrefRangeEnd = 276718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerWalkedThroughCheckPoint(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x00298584 File Offset: 0x00296784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x002985C0 File Offset: 0x002967C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276718, XrefRangeEnd = 276757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x002985FC File Offset: 0x002967FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276757, XrefRangeEnd = 276758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x00298638 File Offset: 0x00296838
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x00298674 File Offset: 0x00296874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276758, XrefRangeEnd = 276768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x002986B4 File Offset: 0x002968B4
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x002986F4 File Offset: 0x002968F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276768, XrefRangeEnd = 276771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00298744 File Offset: 0x00296944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276771, XrefRangeEnd = 276781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x00298788 File Offset: 0x00296988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276781, XrefRangeEnd = 276786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x002987CC File Offset: 0x002969CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276786, XrefRangeEnd = 276793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x0029881C File Offset: 0x00296A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276793, XrefRangeEnd = 276804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x00298870 File Offset: 0x00296A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276842, RefRangeEnd = 276844, XrefRangeStart = 276804, XrefRangeEnd = 276842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x002988C4 File Offset: 0x00296AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276844, XrefRangeEnd = 276849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x00298928 File Offset: 0x00296B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276849, XrefRangeEnd = 276858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x0029895C File Offset: 0x00296B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276871, RefRangeEnd = 276873, XrefRangeStart = 276858, XrefRangeEnd = 276871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x00298990 File Offset: 0x00296B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276873, XrefRangeEnd = 276876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x002989F4 File Offset: 0x00296BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276876, XrefRangeEnd = 276886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x00298A34 File Offset: 0x00296C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276891, RefRangeEnd = 276893, XrefRangeStart = 276886, XrefRangeEnd = 276891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x00298A74 File Offset: 0x00296C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276893, XrefRangeEnd = 276896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x00298AC4 File Offset: 0x00296CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276896, XrefRangeEnd = 276905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x00298AF8 File Offset: 0x00296CF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 276966, RefRangeEnd = 276971, XrefRangeStart = 276905, XrefRangeEnd = 276966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x00298B2C File Offset: 0x00296D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276971, XrefRangeEnd = 276974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x00298B7C File Offset: 0x00296D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x000482EB File Offset: 0x000464EB
		public CheckpointBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x06009B5D RID: 39773 RVA: 0x00298BB8 File Offset: 0x00296DB8
		// (set) Token: 0x06009B5E RID: 39774 RVA: 0x000482F4 File Offset: 0x000464F4
		public unsafe static float LOOK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x00298BD4 File Offset: 0x00296DD4
		// (set) Token: 0x06009B60 RID: 39776 RVA: 0x00048302 File Offset: 0x00046502
		public unsafe CheckpointManager.ECheckpointLocation _AssignedCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x00298BFC File Offset: 0x00296DFC
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x0004831D File Offset: 0x0004651D
		public unsafe RoadCheckpoint _Checkpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x00298C2C File Offset: 0x00296E2C
		// (set) Token: 0x06009B64 RID: 39780 RVA: 0x0004833C File Offset: 0x0004653C
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00298C54 File Offset: 0x00296E54
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x00048357 File Offset: 0x00046557
		public unsafe LandVehicle _CurrentSearchedVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x00298C84 File Offset: 0x00296E84
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x00048376 File Offset: 0x00046576
		public unsafe Player _Initiator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x00298CB4 File Offset: 0x00296EB4
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x00048395 File Offset: 0x00046595
		public unsafe float currentLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime)) = value;
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x00298CDC File Offset: 0x00296EDC
		// (set) Token: 0x06009B6C RID: 39788 RVA: 0x000483B0 File Offset: 0x000465B0
		public unsafe bool trunkOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened)) = value;
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x00298D04 File Offset: 0x00296F04
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x000483CB File Offset: 0x000465CB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x00298D2C File Offset: 0x00296F2C
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x000483E6 File Offset: 0x000465E6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006AA3 RID: 27299
		private static readonly IntPtr NativeFieldInfoPtr_LOOK_TIME;

		// Token: 0x04006AA4 RID: 27300
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField;

		// Token: 0x04006AA5 RID: 27301
		private static readonly IntPtr NativeFieldInfoPtr__Checkpoint_k__BackingField;

		// Token: 0x04006AA6 RID: 27302
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04006AA7 RID: 27303
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField;

		// Token: 0x04006AA8 RID: 27304
		private static readonly IntPtr NativeFieldInfoPtr__Initiator_k__BackingField;

		// Token: 0x04006AA9 RID: 27305
		private static readonly IntPtr NativeFieldInfoPtr_currentLookTime;

		// Token: 0x04006AAA RID: 27306
		private static readonly IntPtr NativeFieldInfoPtr_trunkOpened;

		// Token: 0x04006AAB RID: 27307
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006AAC RID: 27308
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006AAD RID: 27309
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0;

		// Token: 0x04006AAE RID: 27310
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0;

		// Token: 0x04006AAF RID: 27311
		private static readonly IntPtr NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04006AB0 RID: 27312
		private static readonly IntPtr NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04006AB1 RID: 27313
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04006AB2 RID: 27314
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04006AB3 RID: 27315
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0;

		// Token: 0x04006AB4 RID: 27316
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04006AB5 RID: 27317
		private static readonly IntPtr NativeMethodInfoPtr_get_Initiator_Public_get_Player_0;

		// Token: 0x04006AB6 RID: 27318
		private static readonly IntPtr NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0;

		// Token: 0x04006AB7 RID: 27319
		private static readonly IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x04006AB8 RID: 27320
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04006AB9 RID: 27321
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006ABA RID: 27322
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006ABB RID: 27323
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006ABC RID: 27324
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006ABD RID: 27325
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006ABE RID: 27326
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0;

		// Token: 0x04006ABF RID: 27327
		private static readonly IntPtr NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0;

		// Token: 0x04006AC0 RID: 27328
		private static readonly IntPtr NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04006AC1 RID: 27329
		private static readonly IntPtr NativeMethodInfoPtr_StopSearch_Public_Void_0;

		// Token: 0x04006AC2 RID: 27330
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0;

		// Token: 0x04006AC3 RID: 27331
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0;

		// Token: 0x04006AC4 RID: 27332
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Private_Void_0;

		// Token: 0x04006AC5 RID: 27333
		private static readonly IntPtr NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0;

		// Token: 0x04006AC6 RID: 27334
		private static readonly IntPtr NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0;

		// Token: 0x04006AC7 RID: 27335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006AC8 RID: 27336
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006AC9 RID: 27337
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006ACA RID: 27338
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006ACB RID: 27339
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04006ACC RID: 27340
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0;

		// Token: 0x04006ACD RID: 27341
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006ACE RID: 27342
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006ACF RID: 27343
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04006AD0 RID: 27344
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006AD1 RID: 27345
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04006AD2 RID: 27346
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04006AD3 RID: 27347
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006AD4 RID: 27348
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0;

		// Token: 0x04006AD5 RID: 27349
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0;

		// Token: 0x04006AD6 RID: 27350
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006AD7 RID: 27351
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0;

		// Token: 0x04006AD8 RID: 27352
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0;

		// Token: 0x04006AD9 RID: 27353
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006ADA RID: 27354
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04006ADB RID: 27355
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04006ADC RID: 27356
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006ADD RID: 27357
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C43 RID: 3139
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.CheckpointBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EF8A RID: 61322 RVA: 0x0039DED4 File Offset: 0x0039C0D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr);
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9");
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9__39_0");
				CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100683542);
				CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100683543);
			}

			// Token: 0x0600EF8B RID: 61323 RVA: 0x0039DF50 File Offset: 0x0039C150
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF8C RID: 61324 RVA: 0x0039DF8C File Offset: 0x0039C18C
			[CallerCount(0)]
			public unsafe ItemInstance _DoesVehicleContainIllicitItems_b__39_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}

			// Token: 0x0600EF8D RID: 61325 RVA: 0x00071101 File Offset: 0x0006F301
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700489D RID: 18589
			// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x0039DFDC File Offset: 0x0039C1DC
			// (set) Token: 0x0600EF8F RID: 61327 RVA: 0x0007110A File Offset: 0x0006F30A
			public unsafe static CheckpointBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700489E RID: 18590
			// (get) Token: 0x0600EF90 RID: 61328 RVA: 0x0039E004 File Offset: 0x0039C204
			// (set) Token: 0x0600EF91 RID: 61329 RVA: 0x0007111C File Offset: 0x0006F31C
			public unsafe static Func<ItemSlot, ItemInstance> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, ItemInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A22C RID: 41516
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A22D RID: 41517
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x0400A22E RID: 41518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A22F RID: 41519
			private static readonly IntPtr NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0;
		}
	}
}
