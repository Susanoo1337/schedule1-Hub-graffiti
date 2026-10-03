using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200043F RID: 1087
	public class PoliceOfficer : NPC
	{
		// Token: 0x06006176 RID: 24950 RVA: 0x001CCB88 File Offset: 0x001CAD88
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceOfficer()
		{
			Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "PoliceOfficer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr);
			PoliceOfficer.NativeFieldInfoPtr_OutOfSightTimeToDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "OutOfSightTimeToDeactivate");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_COOLDOWN");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MAX_DISTANCE");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MIN_VISIBILITY");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_CHECK_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BODY_SEARCH_CHANCE_DEFAULT");
			PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MIN_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MAX_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "OnPoliceVisionEvent");
			PoliceOfficer.NativeFieldInfoPtr_Officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Officers");
			PoliceOfficer.NativeFieldInfoPtr__IgnorePlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<IgnorePlayers>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr__AssignedVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<AssignedVehicle>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "PursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "FootPatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ProxCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ProxCircle");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "SentryBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ChatterVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterVO");
			PoliceOfficer.NativeFieldInfoPtr_DeactivationBlockingBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "DeactivationBlockingBehaviours");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointDialogue");
			PoliceOfficer.NativeFieldInfoPtr_BatonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BatonPrefab");
			PoliceOfficer.NativeFieldInfoPtr_TaserPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "TaserPrefab");
			PoliceOfficer.NativeFieldInfoPtr_GunPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "GunPrefab");
			PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "AutoDeactivate");
			PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterEnabled");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchDuration");
			PoliceOfficer.NativeFieldInfoPtr__BodySearchChance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<BodySearchChance>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_belt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "belt");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceReadyToPool");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceOutOfSight");
			PoliceOfficer.NativeFieldInfoPtr_chatterCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "chatterCountDown");
			PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "currentBodySearchInvestigation");
			PoliceOfficer.NativeFieldInfoPtr_syncVar____IgnorePlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "syncVar___<IgnorePlayers>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeMethodInfoPtr_get_IgnorePlayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676096);
			PoliceOfficer.NativeMethodInfoPtr_set_IgnorePlayers_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676097);
			PoliceOfficer.NativeMethodInfoPtr_get_PursuitTarget_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676098);
			PoliceOfficer.NativeMethodInfoPtr_get_AssignedVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676099);
			PoliceOfficer.NativeMethodInfoPtr_set_AssignedVehicle_Public_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676100);
			PoliceOfficer.NativeMethodInfoPtr_get_BodySearchChance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676101);
			PoliceOfficer.NativeMethodInfoPtr_set_BodySearchChance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676102);
			PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676103);
			PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676104);
			PoliceOfficer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676105);
			PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676106);
			PoliceOfficer.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676107);
			PoliceOfficer.NativeMethodInfoPtr_UpdateVision_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676108);
			PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676109);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676110);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676111);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676112);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676113);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676114);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676115);
			PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676116);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676117);
			PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676118);
			PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676119);
			PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676120);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676121);
			PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676122);
			PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676123);
			PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676124);
			PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676125);
			PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676126);
			PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676127);
			PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676128);
			PoliceOfficer.NativeMethodInfoPtr_GetNearestOfficer_Public_Static_PoliceOfficer_Vector3_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676129);
			PoliceOfficer.NativeMethodInfoPtr_SetIgnorePlayers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676130);
			PoliceOfficer.NativeMethodInfoPtr_SetRandomAvoidancePriority_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676131);
			PoliceOfficer.NativeMethodInfoPtr_SetAvoidancePriority_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676132);
			PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676133);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676134);
			PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676135);
			PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676136);
			PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676137);
			PoliceOfficer.NativeMethodInfoPtr_BodySearchLocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676138);
			PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676139);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676140);
			PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676141);
			PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676143);
			PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__66_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676144);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676145);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676146);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676147);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676148);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_310431262_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676149);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676150);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuit_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676151);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676152);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuit_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676153);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676154);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_1834136777_Public_Virtual_New_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676155);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676156);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676157);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676158);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_1834136777_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676159);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676160);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3615296227_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676161);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676162);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676163);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676164);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676165);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676166);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676167);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676168);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_SetIgnorePlayers_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676169);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___SetIgnorePlayers_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676170);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_SetIgnorePlayers_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676171);
			PoliceOfficer.NativeMethodInfoPtr_sync___get_value__IgnorePlayers_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676172);
			PoliceOfficer.NativeMethodInfoPtr_sync___set_value__IgnorePlayers_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676173);
			PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676174);
			PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100676175);
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x001CD4DC File Offset: 0x001CB6DC
		// (set) Token: 0x06006178 RID: 24952 RVA: 0x001CD518 File Offset: 0x001CB718
		public unsafe bool IgnorePlayers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 183607, RefRangeEnd = 183609, XrefRangeStart = 183607, XrefRangeEnd = 183609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_IgnorePlayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206518, XrefRangeEnd = 206525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_set_IgnorePlayers_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06006179 RID: 24953 RVA: 0x001CD558 File Offset: 0x001CB758
		public unsafe NetworkObject PursuitTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206525, XrefRangeEnd = 206528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_PursuitTarget_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x001CD598 File Offset: 0x001CB798
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x001CD5D8 File Offset: 0x001CB7D8
		public unsafe LandVehicle AssignedVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_AssignedVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_set_AssignedVehicle_Public_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600617C RID: 24956 RVA: 0x001CD61C File Offset: 0x001CB81C
		// (set) Token: 0x0600617D RID: 24957 RVA: 0x001CD658 File Offset: 0x001CB858
		public unsafe float BodySearchChance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_BodySearchChance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_set_BodySearchChance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x001CD698 File Offset: 0x001CB898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206528, XrefRangeEnd = 206529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x001CD6D4 File Offset: 0x001CB8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206529, XrefRangeEnd = 206537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x001CD710 File Offset: 0x001CB910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206537, XrefRangeEnd = 206551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x001CD74C File Offset: 0x001CB94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206551, XrefRangeEnd = 206557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x001CD780 File Offset: 0x001CB980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206557, XrefRangeEnd = 206564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x001CD7BC File Offset: 0x001CB9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206610, RefRangeEnd = 206611, XrefRangeStart = 206564, XrefRangeEnd = 206610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVision()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateVision_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x001CD7F0 File Offset: 0x001CB9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206672, RefRangeEnd = 206673, XrefRangeStart = 206611, XrefRangeEnd = 206672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeactivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x001CD824 File Offset: 0x001CBA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206673, XrefRangeEnd = 206696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginFootPursuit_Networked(string playerCode, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x001CD880 File Offset: 0x001CBA80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 206718, RefRangeEnd = 206722, XrefRangeStart = 206696, XrefRangeEnd = 206718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFootPursuit(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x001CD8C4 File Offset: 0x001CBAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206722, XrefRangeEnd = 206746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginVehiclePursuit_Networked(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_String_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x001CD934 File Offset: 0x001CBB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206770, RefRangeEnd = 206772, XrefRangeStart = 206746, XrefRangeEnd = 206770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginVehiclePursuit(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_String_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x001CD998 File Offset: 0x001CBB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206772, XrefRangeEnd = 206794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginBodySearch_Networked(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x001CD9E8 File Offset: 0x001CBBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206816, RefRangeEnd = 206818, XrefRangeStart = 206794, XrefRangeEnd = 206816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBodySearch(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x001CDA2C File Offset: 0x001CBC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206818, XrefRangeEnd = 206840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x001CDA78 File Offset: 0x001CBC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206840, XrefRangeEnd = 206846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x001CDAAC File Offset: 0x001CBCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206850, RefRangeEnd = 206851, XrefRangeStart = 206846, XrefRangeEnd = 206850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warpToStartPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x001CDAFC File Offset: 0x001CBCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206855, RefRangeEnd = 206856, XrefRangeStart = 206851, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x001CDB50 File Offset: 0x001CBD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206856, XrefRangeEnd = 206858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToSentryLocation(SentryLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x001CDBA0 File Offset: 0x001CBDA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206860, RefRangeEnd = 206861, XrefRangeStart = 206858, XrefRangeEnd = 206860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromSentryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x001CDBD4 File Offset: 0x001CBDD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206864, RefRangeEnd = 206865, XrefRangeStart = 206861, XrefRangeEnd = 206864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x001CDC08 File Offset: 0x001CBE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206887, RefRangeEnd = 206888, XrefRangeStart = 206865, XrefRangeEnd = 206887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x001CDC3C File Offset: 0x001CBE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206893, RefRangeEnd = 206894, XrefRangeStart = 206888, XrefRangeEnd = 206893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x001CDC8C File Offset: 0x001CBE8C
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x001CDCD4 File Offset: 0x001CBED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206894, XrefRangeEnd = 206898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetNameAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x001CDD18 File Offset: 0x001CBF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206898, XrefRangeEnd = 206902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x001CDD4C File Offset: 0x001CBF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206902, XrefRangeEnd = 206908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x001CDD90 File Offset: 0x001CBF90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206932, RefRangeEnd = 206934, XrefRangeStart = 206908, XrefRangeEnd = 206932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PoliceOfficer GetNearestOfficer(Vector3 position, out float distanceToTarget, bool onlyConscious = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyConscious;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_GetNearestOfficer_Public_Static_PoliceOfficer_Vector3_byref_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x001CDDEC File Offset: 0x001CBFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206944, RefRangeEnd = 206945, XrefRangeStart = 206934, XrefRangeEnd = 206944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnorePlayers(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_SetIgnorePlayers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x001CDE2C File Offset: 0x001CC02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206948, RefRangeEnd = 206949, XrefRangeStart = 206945, XrefRangeEnd = 206948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomAvoidancePriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_SetRandomAvoidancePriority_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x001CDE60 File Offset: 0x001CC060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206949, XrefRangeEnd = 206951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvoidancePriority(int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_SetAvoidancePriority_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x001CDEA0 File Offset: 0x001CC0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206951, XrefRangeEnd = 206954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBodySearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x001CDEDC File Offset: 0x001CC0DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206958, RefRangeEnd = 206960, XrefRangeStart = 206954, XrefRangeEnd = 206958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x001CDF18 File Offset: 0x001CC118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206983, RefRangeEnd = 206984, XrefRangeStart = 206960, XrefRangeEnd = 206983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExistingInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x001CDF4C File Offset: 0x001CC14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206984, XrefRangeEnd = 207020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNewInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x001CDF80 File Offset: 0x001CC180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207020, XrefRangeEnd = 207025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBodySearchInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x001CDFB4 File Offset: 0x001CC1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207025, XrefRangeEnd = 207030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodySearchLocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BodySearchLocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x001CDFE8 File Offset: 0x001CC1E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207040, RefRangeEnd = 207042, XrefRangeStart = 207030, XrefRangeEnd = 207040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConductBodySearch(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x001CE02C File Offset: 0x001CC22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207047, RefRangeEnd = 207049, XrefRangeStart = 207042, XrefRangeEnd = 207047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigatePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x001CE07C File Offset: 0x001CC27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207049, XrefRangeEnd = 207050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x001CE0B8 File Offset: 0x001CC2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207050, XrefRangeEnd = 207055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x001CE0F8 File Offset: 0x001CC2F8
		[CallerCount(0)]
		public unsafe bool _Deactivate_b__66_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__66_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x001CE134 File Offset: 0x001CC334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207055, XrefRangeEnd = 207122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x001CE170 File Offset: 0x001CC370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207122, XrefRangeEnd = 207123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x001CE1AC File Offset: 0x001CC3AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x001CE1E8 File Offset: 0x001CC3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207123, XrefRangeEnd = 207134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x001CE238 File Offset: 0x001CC438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207178, RefRangeEnd = 207180, XrefRangeStart = 207134, XrefRangeEnd = 207178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColleagues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_310431262_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x001CE294 File Offset: 0x001CC494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207180, XrefRangeEnd = 207184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginFootPursuit_Networked_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x001CE2F8 File Offset: 0x001CC4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207184, XrefRangeEnd = 207194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginFootPursuit_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuit_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x001CE33C File Offset: 0x001CC53C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207207, RefRangeEnd = 207209, XrefRangeStart = 207194, XrefRangeEnd = 207207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginFootPursuit_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x001CE380 File Offset: 0x001CC580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207209, XrefRangeEnd = 207213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginFootPursuit_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuit_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x001CE3D0 File Offset: 0x001CC5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207213, XrefRangeEnd = 207225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_String_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x001CE434 File Offset: 0x001CC634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206770, RefRangeEnd = 206772, XrefRangeStart = 206770, XrefRangeEnd = 206772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_1834136777_Public_Virtual_New_Void_String_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x001CE4A4 File Offset: 0x001CC6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207225, XrefRangeEnd = 207230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginVehiclePursuit_Networked_1834136777(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x001CE508 File Offset: 0x001CC708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207230, XrefRangeEnd = 207242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x001CE56C File Offset: 0x001CC76C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207259, RefRangeEnd = 207262, XrefRangeStart = 207242, XrefRangeEnd = 207259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x001CE5D0 File Offset: 0x001CC7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207262, XrefRangeEnd = 207267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginVehiclePursuit_1834136777(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_1834136777_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x001CE620 File Offset: 0x001CC820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207267, XrefRangeEnd = 207277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginBodySearch_Networked_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x001CE664 File Offset: 0x001CC864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206816, RefRangeEnd = 206818, XrefRangeStart = 206816, XrefRangeEnd = 206818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginBodySearch_Networked_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3615296227_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x001CE6B4 File Offset: 0x001CC8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207277, XrefRangeEnd = 207281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginBodySearch_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x001CE718 File Offset: 0x001CC918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207281, XrefRangeEnd = 207291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginBodySearch_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x001CE75C File Offset: 0x001CC95C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207303, RefRangeEnd = 207306, XrefRangeStart = 207291, XrefRangeEnd = 207303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginBodySearch_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x001CE7A0 File Offset: 0x001CC9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207306, XrefRangeEnd = 207310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginBodySearch_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x001CE7F0 File Offset: 0x001CC9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207310, XrefRangeEnd = 207320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x001CE830 File Offset: 0x001CCA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207334, RefRangeEnd = 207336, XrefRangeStart = 207320, XrefRangeEnd = 207334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x001CE87C File Offset: 0x001CCA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207336, XrefRangeEnd = 207340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x001CE8CC File Offset: 0x001CCACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206944, RefRangeEnd = 206945, XrefRangeStart = 206944, XrefRangeEnd = 206945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIgnorePlayers_1140765316(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_SetIgnorePlayers_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x001CE90C File Offset: 0x001CCB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207340, XrefRangeEnd = 207365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIgnorePlayers_1140765316(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___SetIgnorePlayers_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x001CE94C File Offset: 0x001CCB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207365, XrefRangeEnd = 207391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIgnorePlayers_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_SetIgnorePlayers_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x001CE9B0 File Offset: 0x001CCBB0
		// (set) Token: 0x060061C3 RID: 25027 RVA: 0x001CE9EC File Offset: 0x001CCBEC
		public unsafe bool SyncAccessor_<IgnorePlayers>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 183607, RefRangeEnd = 183609, XrefRangeStart = 183607, XrefRangeEnd = 183609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___get_value__IgnorePlayers_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207391, XrefRangeEnd = 207399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___set_value__IgnorePlayers_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x001CEA38 File Offset: 0x001CCC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207399, XrefRangeEnd = 207400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Police_PoliceOfficer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x001CEAAC File Offset: 0x001CCCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207441, RefRangeEnd = 207442, XrefRangeStart = 207400, XrefRangeEnd = 207441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x0002E10E File Offset: 0x0002C30E
		public PoliceOfficer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x001CEAE8 File Offset: 0x001CCCE8
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x0002E117 File Offset: 0x0002C317
		public unsafe static float OutOfSightTimeToDeactivate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_OutOfSightTimeToDeactivate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_OutOfSightTimeToDeactivate, (void*)(&value));
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x060061C9 RID: 25033 RVA: 0x001CEB04 File Offset: 0x001CCD04
		// (set) Token: 0x060061CA RID: 25034 RVA: 0x0002E125 File Offset: 0x0002C325
		public unsafe static float INVESTIGATION_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x060061CB RID: 25035 RVA: 0x001CEB20 File Offset: 0x001CCD20
		// (set) Token: 0x060061CC RID: 25036 RVA: 0x0002E133 File Offset: 0x0002C333
		public unsafe static float INVESTIGATION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x001CEB3C File Offset: 0x001CCD3C
		// (set) Token: 0x060061CE RID: 25038 RVA: 0x0002E141 File Offset: 0x0002C341
		public unsafe static float INVESTIGATION_MIN_VISIBILITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&value));
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x001CEB58 File Offset: 0x001CCD58
		// (set) Token: 0x060061D0 RID: 25040 RVA: 0x0002E14F File Offset: 0x0002C34F
		public unsafe static float INVESTIGATION_CHECK_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x060061D1 RID: 25041 RVA: 0x001CEB74 File Offset: 0x001CCD74
		// (set) Token: 0x060061D2 RID: 25042 RVA: 0x0002E15D File Offset: 0x0002C35D
		public unsafe static float BODY_SEARCH_CHANCE_DEFAULT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x001CEB90 File Offset: 0x001CCD90
		// (set) Token: 0x060061D4 RID: 25044 RVA: 0x0002E16B File Offset: 0x0002C36B
		public unsafe static float MIN_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x001CEBAC File Offset: 0x001CCDAC
		// (set) Token: 0x060061D6 RID: 25046 RVA: 0x0002E179 File Offset: 0x0002C379
		public unsafe static float MAX_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x001CEBC8 File Offset: 0x001CCDC8
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x0002E187 File Offset: 0x0002C387
		public unsafe static Action<VisionEventReceipt> OnPoliceVisionEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisionEventReceipt>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x001CEBF0 File Offset: 0x001CCDF0
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x0002E199 File Offset: 0x0002C399
		public unsafe static List<PoliceOfficer> Officers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_Officers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_Officers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x001CEC18 File Offset: 0x001CCE18
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x0002E1AB File Offset: 0x0002C3AB
		public unsafe bool _IgnorePlayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__IgnorePlayers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__IgnorePlayers_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x001CEC40 File Offset: 0x001CCE40
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x0002E1C6 File Offset: 0x0002C3C6
		public unsafe LandVehicle _AssignedVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__AssignedVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__AssignedVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x001CEC70 File Offset: 0x001CCE70
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x0002E1E5 File Offset: 0x0002C3E5
		public unsafe PursuitBehaviour PursuitBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x001CECA0 File Offset: 0x001CCEA0
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x0002E204 File Offset: 0x0002C404
		public unsafe VehiclePursuitBehaviour VehiclePursuitBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x001CECD0 File Offset: 0x001CCED0
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x0002E223 File Offset: 0x0002C423
		public unsafe BodySearchBehaviour BodySearchBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x001CED00 File Offset: 0x001CCF00
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x0002E242 File Offset: 0x0002C442
		public unsafe CheckpointBehaviour CheckpointBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x001CED30 File Offset: 0x001CCF30
		// (set) Token: 0x060061E8 RID: 25064 RVA: 0x0002E261 File Offset: 0x0002C461
		public unsafe FootPatrolBehaviour FootPatrolBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x001CED60 File Offset: 0x001CCF60
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x0002E280 File Offset: 0x0002C480
		public unsafe ProximityCircle ProxCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProximityCircle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x001CED90 File Offset: 0x001CCF90
		// (set) Token: 0x060061EC RID: 25068 RVA: 0x0002E29F File Offset: 0x0002C49F
		public unsafe VehiclePatrolBehaviour VehiclePatrolBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x001CEDC0 File Offset: 0x001CCFC0
		// (set) Token: 0x060061EE RID: 25070 RVA: 0x0002E2BE File Offset: 0x0002C4BE
		public unsafe SentryBehaviour SentryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x060061EF RID: 25071 RVA: 0x001CEDF0 File Offset: 0x001CCFF0
		// (set) Token: 0x060061F0 RID: 25072 RVA: 0x0002E2DD File Offset: 0x0002C4DD
		public unsafe PoliceChatterVO ChatterVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceChatterVO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060061F1 RID: 25073 RVA: 0x001CEE20 File Offset: 0x001CD020
		// (set) Token: 0x060061F2 RID: 25074 RVA: 0x0002E2FC File Offset: 0x0002C4FC
		public unsafe Il2CppReferenceArray<Il2CppScheduleOne.NPCs.Behaviour.Behaviour> DeactivationBlockingBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_DeactivationBlockingBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppScheduleOne.NPCs.Behaviour.Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_DeactivationBlockingBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060061F3 RID: 25075 RVA: 0x001CEE50 File Offset: 0x001CD050
		// (set) Token: 0x060061F4 RID: 25076 RVA: 0x0002E31B File Offset: 0x0002C51B
		public unsafe DialogueContainer CheckpointDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060061F5 RID: 25077 RVA: 0x001CEE80 File Offset: 0x001CD080
		// (set) Token: 0x060061F6 RID: 25078 RVA: 0x0002E33A File Offset: 0x0002C53A
		public unsafe AvatarEquippable BatonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x001CEEB0 File Offset: 0x001CD0B0
		// (set) Token: 0x060061F8 RID: 25080 RVA: 0x0002E359 File Offset: 0x0002C559
		public unsafe AvatarEquippable TaserPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x001CEEE0 File Offset: 0x001CD0E0
		// (set) Token: 0x060061FA RID: 25082 RVA: 0x0002E378 File Offset: 0x0002C578
		public unsafe AvatarEquippable GunPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060061FB RID: 25083 RVA: 0x001CEF10 File Offset: 0x001CD110
		// (set) Token: 0x060061FC RID: 25084 RVA: 0x0002E397 File Offset: 0x0002C597
		public unsafe bool AutoDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate)) = value;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x001CEF38 File Offset: 0x001CD138
		// (set) Token: 0x060061FE RID: 25086 RVA: 0x0002E3B2 File Offset: 0x0002C5B2
		public unsafe bool ChatterEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled)) = value;
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x001CEF60 File Offset: 0x001CD160
		// (set) Token: 0x06006200 RID: 25088 RVA: 0x0002E3CD File Offset: 0x0002C5CD
		public unsafe float BodySearchDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration)) = value;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06006201 RID: 25089 RVA: 0x001CEF88 File Offset: 0x001CD188
		// (set) Token: 0x06006202 RID: 25090 RVA: 0x0002E3E8 File Offset: 0x0002C5E8
		public unsafe float _BodySearchChance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__BodySearchChance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__BodySearchChance_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06006203 RID: 25091 RVA: 0x001CEFB0 File Offset: 0x001CD1B0
		// (set) Token: 0x06006204 RID: 25092 RVA: 0x0002E403 File Offset: 0x0002C603
		public unsafe PoliceBelt belt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceBelt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x001CEFE0 File Offset: 0x001CD1E0
		// (set) Token: 0x06006206 RID: 25094 RVA: 0x0002E422 File Offset: 0x0002C622
		public unsafe float timeSinceReadyToPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool)) = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x001CF008 File Offset: 0x001CD208
		// (set) Token: 0x06006208 RID: 25096 RVA: 0x0002E43D File Offset: 0x0002C63D
		public unsafe float timeSinceOutOfSight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight)) = value;
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06006209 RID: 25097 RVA: 0x001CF030 File Offset: 0x001CD230
		// (set) Token: 0x0600620A RID: 25098 RVA: 0x0002E458 File Offset: 0x0002C658
		public unsafe float chatterCountDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown)) = value;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x001CF058 File Offset: 0x001CD258
		// (set) Token: 0x0600620C RID: 25100 RVA: 0x0002E473 File Offset: 0x0002C673
		public unsafe Investigation currentBodySearchInvestigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Investigation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x001CF088 File Offset: 0x001CD288
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x0002E492 File Offset: 0x0002C692
		public unsafe SyncVar<bool> syncVar____IgnorePlayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____IgnorePlayers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____IgnorePlayers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x001CF0B8 File Offset: 0x001CD2B8
		// (set) Token: 0x06006210 RID: 25104 RVA: 0x0002E4B1 File Offset: 0x0002C6B1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x001CF0E0 File Offset: 0x001CD2E0
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x0002E4CC File Offset: 0x0002C6CC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeFieldInfoPtr_OutOfSightTimeToDeactivate;

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_COOLDOWN;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT;

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CHATTER_INTERVAL;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CHATTER_INTERVAL;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeFieldInfoPtr_OnPoliceVisionEvent;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeFieldInfoPtr_Officers;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeFieldInfoPtr__IgnorePlayers_k__BackingField;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeFieldInfoPtr__AssignedVehicle_k__BackingField;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeFieldInfoPtr_PursuitBehaviour;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePursuitBehaviour;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchBehaviour;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointBehaviour;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeFieldInfoPtr_FootPatrolBehaviour;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeFieldInfoPtr_ProxCircle;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePatrolBehaviour;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeFieldInfoPtr_SentryBehaviour;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeFieldInfoPtr_ChatterVO;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeFieldInfoPtr_DeactivationBlockingBehaviours;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointDialogue;

		// Token: 0x0400433C RID: 17212
		private static readonly IntPtr NativeFieldInfoPtr_BatonPrefab;

		// Token: 0x0400433D RID: 17213
		private static readonly IntPtr NativeFieldInfoPtr_TaserPrefab;

		// Token: 0x0400433E RID: 17214
		private static readonly IntPtr NativeFieldInfoPtr_GunPrefab;

		// Token: 0x0400433F RID: 17215
		private static readonly IntPtr NativeFieldInfoPtr_AutoDeactivate;

		// Token: 0x04004340 RID: 17216
		private static readonly IntPtr NativeFieldInfoPtr_ChatterEnabled;

		// Token: 0x04004341 RID: 17217
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchDuration;

		// Token: 0x04004342 RID: 17218
		private static readonly IntPtr NativeFieldInfoPtr__BodySearchChance_k__BackingField;

		// Token: 0x04004343 RID: 17219
		private static readonly IntPtr NativeFieldInfoPtr_belt;

		// Token: 0x04004344 RID: 17220
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceReadyToPool;

		// Token: 0x04004345 RID: 17221
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceOutOfSight;

		// Token: 0x04004346 RID: 17222
		private static readonly IntPtr NativeFieldInfoPtr_chatterCountDown;

		// Token: 0x04004347 RID: 17223
		private static readonly IntPtr NativeFieldInfoPtr_currentBodySearchInvestigation;

		// Token: 0x04004348 RID: 17224
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IgnorePlayers_k__BackingField;

		// Token: 0x04004349 RID: 17225
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400434A RID: 17226
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400434B RID: 17227
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnorePlayers_Public_get_Boolean_0;

		// Token: 0x0400434C RID: 17228
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnorePlayers_Private_set_Void_Boolean_0;

		// Token: 0x0400434D RID: 17229
		private static readonly IntPtr NativeMethodInfoPtr_get_PursuitTarget_Public_get_NetworkObject_0;

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedVehicle_Public_get_LandVehicle_0;

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedVehicle_Public_set_Void_LandVehicle_0;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeMethodInfoPtr_get_BodySearchChance_Public_get_Single_0;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeMethodInfoPtr_set_BodySearchChance_Public_set_Void_Single_0;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04004355 RID: 17237
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04004356 RID: 17238
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1;

		// Token: 0x04004357 RID: 17239
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVision_Private_Void_0;

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeactivation_Private_Void_0;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeMethodInfoPtr_BeginFootPursuit_Private_Void_String_0;

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_String_NetworkObject_Boolean_0;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_String_NetworkObject_Boolean_0;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_String_0;

		// Token: 0x0400435E RID: 17246
		private static readonly IntPtr NativeMethodInfoPtr_BeginBodySearch_Private_Void_String_0;

		// Token: 0x0400435F RID: 17247
		private static readonly IntPtr NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04004360 RID: 17248
		private static readonly IntPtr NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0;

		// Token: 0x04004361 RID: 17249
		private static readonly IntPtr NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0;

		// Token: 0x04004362 RID: 17250
		private static readonly IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0;

		// Token: 0x04004363 RID: 17251
		private static readonly IntPtr NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0;

		// Token: 0x04004364 RID: 17252
		private static readonly IntPtr NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0;

		// Token: 0x04004365 RID: 17253
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04004366 RID: 17254
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04004367 RID: 17255
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Boolean_Player_0;

		// Token: 0x04004368 RID: 17256
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04004369 RID: 17257
		private static readonly IntPtr NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0;

		// Token: 0x0400436A RID: 17258
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChatter_Private_Void_0;

		// Token: 0x0400436B RID: 17259
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x0400436C RID: 17260
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestOfficer_Public_Static_PoliceOfficer_Vector3_byref_Single_Boolean_0;

		// Token: 0x0400436D RID: 17261
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnorePlayers_Public_Void_Boolean_0;

		// Token: 0x0400436E RID: 17262
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomAvoidancePriority_Public_Void_0;

		// Token: 0x0400436F RID: 17263
		private static readonly IntPtr NativeMethodInfoPtr_SetAvoidancePriority_Public_Void_Int32_0;

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0;

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeMethodInfoPtr_BodySearchLocalPlayer_Public_Void_0;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004379 RID: 17273
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400437A RID: 17274
		private static readonly IntPtr NativeMethodInfoPtr__Deactivate_b__66_1_Private_Boolean_0;

		// Token: 0x0400437B RID: 17275
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400437C RID: 17276
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_310431262_Private_Void_String_Boolean_0;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_310431262_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuit_3615296227_Private_Void_String_0;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_3615296227_Private_Void_String_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuit_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_String_NetworkObject_Boolean_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_1834136777_Public_Virtual_New_Void_String_NetworkObject_Boolean_0;

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_1834136777_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0;

		// Token: 0x04004388 RID: 17288
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_1834136777_Private_Void_String_NetworkObject_Boolean_0;

		// Token: 0x04004389 RID: 17289
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_1834136777_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400438A RID: 17290
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3615296227_Private_Void_String_0;

		// Token: 0x0400438B RID: 17291
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3615296227_Public_Virtual_New_Void_String_0;

		// Token: 0x0400438C RID: 17292
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3615296227_Private_Void_String_0;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3615296227_Private_Void_String_0;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004390 RID: 17296
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04004391 RID: 17297
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04004392 RID: 17298
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004393 RID: 17299
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIgnorePlayers_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004394 RID: 17300
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIgnorePlayers_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004395 RID: 17301
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIgnorePlayers_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004396 RID: 17302
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IgnorePlayers_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004397 RID: 17303
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IgnorePlayers_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004398 RID: 17304
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004399 RID: 17305
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B32 RID: 2866
		[ObfuscatedName("ScheduleOne.Police.PoliceOfficer+<<Deactivate>g__Wait|66_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E695 RID: 59029 RVA: 0x003842C4 File Offset: 0x003824C4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique()
			{
				Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<<Deactivate>g__Wait|66_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>1__state");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>2__current");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>4__this");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676176);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676177);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676178);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676179);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676180);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100676181);
			}

			// Token: 0x0600E696 RID: 59030 RVA: 0x003843A4 File Offset: 0x003825A4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E697 RID: 59031 RVA: 0x003843EC File Offset: 0x003825EC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E698 RID: 59032 RVA: 0x00384420 File Offset: 0x00382620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206501, XrefRangeEnd = 206513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004601 RID: 17921
			// (get) Token: 0x0600E699 RID: 59033 RVA: 0x0038445C File Offset: 0x0038265C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E69A RID: 59034 RVA: 0x0038449C File Offset: 0x0038269C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206513, XrefRangeEnd = 206518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004602 RID: 17922
			// (get) Token: 0x0600E69B RID: 59035 RVA: 0x003844D0 File Offset: 0x003826D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E69C RID: 59036 RVA: 0x0006CC40 File Offset: 0x0006AE40
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045FE RID: 17918
			// (get) Token: 0x0600E69D RID: 59037 RVA: 0x00384510 File Offset: 0x00382710
			// (set) Token: 0x0600E69E RID: 59038 RVA: 0x0006CC49 File Offset: 0x0006AE49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045FF RID: 17919
			// (get) Token: 0x0600E69F RID: 59039 RVA: 0x00384538 File Offset: 0x00382738
			// (set) Token: 0x0600E6A0 RID: 59040 RVA: 0x0006CC64 File Offset: 0x0006AE64
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004600 RID: 17920
			// (get) Token: 0x0600E6A1 RID: 59041 RVA: 0x00384568 File Offset: 0x00382768
			// (set) Token: 0x0600E6A2 RID: 59042 RVA: 0x0006CC83 File Offset: 0x0006AE83
			public unsafe PoliceOfficer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C8C RID: 40076
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C8D RID: 40077
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C8E RID: 40078
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C8F RID: 40079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C90 RID: 40080
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C91 RID: 40081
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C92 RID: 40082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C93 RID: 40083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C94 RID: 40084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
