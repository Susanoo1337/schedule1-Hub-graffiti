using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005D9 RID: 1497
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x060092CF RID: 37583 RVA: 0x0027BD34 File Offset: 0x00279F34
		// Note: this type is marked as 'beforefieldinit'.
		static NPCMovement()
		{
			Il2CppClassPointerStore<NPCMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr);
			NPCMovement.NativeFieldInfoPtr_VehicleRunoverSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VehicleRunoverSpeed");
			NPCMovement.NativeFieldInfoPtr_VehicleRunoverRelativeVelocityThreshold_Sqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VehicleRunoverRelativeVelocityThreshold_Sqr");
			NPCMovement.NativeFieldInfoPtr_VehicleImpactCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VehicleImpactCooldown");
			NPCMovement.NativeFieldInfoPtr_VehicleImpactForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VehicleImpactForceMultiplier");
			NPCMovement.NativeFieldInfoPtr_SkateboardRunoverSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SkateboardRunoverSpeed");
			NPCMovement.NativeFieldInfoPtr_SkateboardImpactForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SkateboardImpactForceMultiplier");
			NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_ANNOYED_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "USE_PATH_CACHE");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_DURATION");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_FORCE");
			NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "OBSTACLE_AVOIDANCE_RANGE");
			NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "OBSTACLE_AVOIDANCE_RANGE_SQR");
			NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "PLAYER_DIST_IMPACT_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestReachablePoints");
			NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestPointKeys");
			NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET");
			NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyModeMultiplier");
			NPCMovement.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DEBUG");
			NPCMovement.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<MoveSpeedMultiplier>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_ObstacleAvoidanceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ObstacleAvoidanceEnabled");
			NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DefaultObstacleAvoidanceType");
			NPCMovement.NativeFieldInfoPtr__SlipperyMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<SlipperyMode>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "Agent");
			NPCMovement.NativeFieldInfoPtr_SpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SpeedController");
			NPCMovement.NativeFieldInfoPtr_CapsuleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "CapsuleCollider");
			NPCMovement.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "Animation");
			NPCMovement.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VelocityCalculator");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggable");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggableCollider");
			NPCMovement.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "npc");
			NPCMovement.NativeFieldInfoPtr__HasDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<HasDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<IsPaused>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Stance>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__TimeSinceHitByCar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<TimeSinceHitByCar>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__CurrentLadderSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentLadderSpeed>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentLadder>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_ragdollStaticTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollStaticTime");
			NPCMovement.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onHitByCar");
			NPCMovement.NativeFieldInfoPtr_onRagdollStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollStart");
			NPCMovement.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollEnd");
			NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<PathCache>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_cacheNextPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cacheNextPath");
			NPCMovement.NativeFieldInfoPtr_walkResultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "walkResultCallback");
			NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentMaxDistanceForSuccess");
			NPCMovement.NativeFieldInfoPtr_forceIsMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "forceIsMoving");
			NPCMovement.NativeFieldInfoPtr_faceDirectionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "faceDirectionRoutine");
			NPCMovement.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollForceComponents");
			NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Disoriented>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeUntilNextStumble");
			NPCMovement.NativeFieldInfoPtr_timeSinceStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceStumble");
			NPCMovement.NativeFieldInfoPtr_stumbleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "stumbleDirection");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistory");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistoryLength");
			NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityHistorySpacing");
			NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceLastVelocityHistoryRecord");
			NPCMovement.NativeFieldInfoPtr_agentCurrentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "agentCurrentPath");
			NPCMovement.NativeFieldInfoPtr_agentCurrentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "agentCurrentSpeed");
			NPCMovement.NativeFieldInfoPtr_agentCurrentPathCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "agentCurrentPathCorners");
			NPCMovement.NativeFieldInfoPtr_ladderClimbRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ladderClimbRoutine");
			NPCMovement.NativeFieldInfoPtr__defaultAngularSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "_defaultAngularSpeed");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682459);
			NPCMovement.NativeMethodInfoPtr_get_RunSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682460);
			NPCMovement.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682461);
			NPCMovement.NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682462);
			NPCMovement.NativeMethodInfoPtr_get_SlipperyMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682463);
			NPCMovement.NativeMethodInfoPtr_set_SlipperyMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682464);
			NPCMovement.NativeMethodInfoPtr_get_HasDestination_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682465);
			NPCMovement.NativeMethodInfoPtr_set_HasDestination_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682466);
			NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682467);
			NPCMovement.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682468);
			NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682469);
			NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682470);
			NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682471);
			NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682472);
			NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682473);
			NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682474);
			NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682475);
			NPCMovement.NativeMethodInfoPtr_get_TimeSinceHitByCar_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682476);
			NPCMovement.NativeMethodInfoPtr_set_TimeSinceHitByCar_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682477);
			NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682478);
			NPCMovement.NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682479);
			NPCMovement.NativeMethodInfoPtr_get_CurrentLadderSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682480);
			NPCMovement.NativeMethodInfoPtr_set_CurrentLadderSpeed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682481);
			NPCMovement.NativeMethodInfoPtr_get_IsClimbingUpwards_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682482);
			NPCMovement.NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682483);
			NPCMovement.NativeMethodInfoPtr_set_CurrentLadder_Protected_set_Void_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682484);
			NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682485);
			NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682486);
			NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682487);
			NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682488);
			NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682489);
			NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682490);
			NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682491);
			NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682492);
			NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682493);
			NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682494);
			NPCMovement.NativeMethodInfoPtr_SetAgentEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682495);
			NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682496);
			NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682497);
			NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682498);
			NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682499);
			NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682500);
			NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682501);
			NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682502);
			NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682503);
			NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682504);
			NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682505);
			NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682506);
			NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682507);
			NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682508);
			NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682509);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682510);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682511);
			NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682512);
			NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682513);
			NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682514);
			NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682515);
			NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682516);
			NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682517);
			NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682518);
			NPCMovement.NativeMethodInfoPtr_SetAngularSpeedMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682519);
			NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682520);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682521);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682522);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682523);
			NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682524);
			NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682525);
			NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682526);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682527);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682528);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682529);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682530);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682531);
			NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682532);
			NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682533);
			NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682534);
			NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682535);
			NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682536);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682537);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682538);
			NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682539);
			NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682540);
			NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682541);
			NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682542);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682543);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682544);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682545);
			NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682546);
			NPCMovement.NativeMethodInfoPtr_TraverseLadder_Public_Void_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682547);
			NPCMovement.NativeMethodInfoPtr_CancelTraverseLadder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682548);
			NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682549);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682551);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682552);
			NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682553);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682554);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682555);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682556);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682557);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682558);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2690242654_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682559);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682560);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682561);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682562);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682563);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682564);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682565);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682566);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682567);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682568);
			NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100682569);
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x0027CB74 File Offset: 0x0027AD74
		public unsafe float WalkSpeed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 269145, RefRangeEnd = 269147, XrefRangeStart = 269144, XrefRangeEnd = 269145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x0027CBB0 File Offset: 0x0027ADB0
		public unsafe float RunSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269147, XrefRangeEnd = 269148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_RunSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x0027CBEC File Offset: 0x0027ADEC
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x0027CC28 File Offset: 0x0027AE28
		public unsafe float MoveSpeedMultiplier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x0027CC68 File Offset: 0x0027AE68
		// (set) Token: 0x060092D5 RID: 37589 RVA: 0x0027CCA4 File Offset: 0x0027AEA4
		public unsafe bool SlipperyMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_SlipperyMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_SlipperyMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x060092D6 RID: 37590 RVA: 0x0027CCE4 File Offset: 0x0027AEE4
		// (set) Token: 0x060092D7 RID: 37591 RVA: 0x0027CD20 File Offset: 0x0027AF20
		public unsafe bool HasDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_HasDestination_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_HasDestination_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x060092D8 RID: 37592 RVA: 0x0027CD60 File Offset: 0x0027AF60
		public unsafe bool IsMoving
		{
			[CallerCount(72)]
			[CachedScanResults(RefRangeStart = 269151, RefRangeEnd = 269223, XrefRangeStart = 269148, XrefRangeEnd = 269151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x060092D9 RID: 37593 RVA: 0x0027CD9C File Offset: 0x0027AF9C
		public unsafe Vector3 Velocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 269223, RefRangeEnd = 269224, XrefRangeStart = 269223, XrefRangeEnd = 269223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x060092DA RID: 37594 RVA: 0x0027CDD8 File Offset: 0x0027AFD8
		// (set) Token: 0x060092DB RID: 37595 RVA: 0x0027CE14 File Offset: 0x0027B014
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x060092DC RID: 37596 RVA: 0x0027CE54 File Offset: 0x0027B054
		public unsafe Vector3 FootPosition
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 101087, RefRangeEnd = 101108, XrefRangeStart = 101087, XrefRangeEnd = 101108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x0027CE90 File Offset: 0x0027B090
		// (set) Token: 0x060092DE RID: 37598 RVA: 0x0027CECC File Offset: 0x0027B0CC
		public unsafe float GravityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x060092DF RID: 37599 RVA: 0x0027CF0C File Offset: 0x0027B10C
		// (set) Token: 0x060092E0 RID: 37600 RVA: 0x0027CF48 File Offset: 0x0027B148
		public unsafe NPCMovement.EStance Stance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 269224, RefRangeEnd = 269226, XrefRangeStart = 269224, XrefRangeEnd = 269224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x0027CF88 File Offset: 0x0027B188
		// (set) Token: 0x060092E2 RID: 37602 RVA: 0x0027CFC4 File Offset: 0x0027B1C4
		public unsafe float TimeSinceHitByCar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_TimeSinceHitByCar_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_TimeSinceHitByCar_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x0027D004 File Offset: 0x0027B204
		public unsafe bool FaceDirectionInProgress
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 269226, RefRangeEnd = 269229, XrefRangeStart = 269226, XrefRangeEnd = 269226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x0027D040 File Offset: 0x0027B240
		public unsafe bool IsOnLadder
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 269233, RefRangeEnd = 269239, XrefRangeStart = 269229, XrefRangeEnd = 269233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x0027D07C File Offset: 0x0027B27C
		// (set) Token: 0x060092E6 RID: 37606 RVA: 0x0027D0B8 File Offset: 0x0027B2B8
		public unsafe float CurrentLadderSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentLadderSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentLadderSpeed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x0027D0F8 File Offset: 0x0027B2F8
		public unsafe bool IsClimbingUpwards
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsClimbingUpwards_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x060092E8 RID: 37608 RVA: 0x0027D134 File Offset: 0x0027B334
		// (set) Token: 0x060092E9 RID: 37609 RVA: 0x0027D174 File Offset: 0x0027B374
		public unsafe Ladder CurrentLadder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ladder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentLadder_Protected_set_Void_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x0027D1B8 File Offset: 0x0027B3B8
		// (set) Token: 0x060092EB RID: 37611 RVA: 0x0027D1F4 File Offset: 0x0027B3F4
		public unsafe Vector3 CurrentDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x060092EC RID: 37612 RVA: 0x0027D234 File Offset: 0x0027B434
		// (set) Token: 0x060092ED RID: 37613 RVA: 0x0027D274 File Offset: 0x0027B474
		public unsafe NPCPathCache PathCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x060092EE RID: 37614 RVA: 0x0027D2B8 File Offset: 0x0027B4B8
		// (set) Token: 0x060092EF RID: 37615 RVA: 0x0027D2F4 File Offset: 0x0027B4F4
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0027D334 File Offset: 0x0027B534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269239, XrefRangeEnd = 269240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x0027D370 File Offset: 0x0027B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269240, XrefRangeEnd = 269265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x0027D3A4 File Offset: 0x0027B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269265, XrefRangeEnd = 269269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x0027D3E0 File Offset: 0x0027B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269269, XrefRangeEnd = 269351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x0027D41C File Offset: 0x0027B61C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 269366, RefRangeEnd = 269380, XrefRangeStart = 269351, XrefRangeEnd = 269366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAgentEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAgentEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x0027D45C File Offset: 0x0027B65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269380, XrefRangeEnd = 269401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x0027D490 File Offset: 0x0027B690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269401, XrefRangeEnd = 269411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x0027D4C4 File Offset: 0x0027B6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269418, RefRangeEnd = 269419, XrefRangeStart = 269411, XrefRangeEnd = 269418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x0027D4F8 File Offset: 0x0027B6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269419, XrefRangeEnd = 269473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x0027D534 File Offset: 0x0027B734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269495, RefRangeEnd = 269496, XrefRangeStart = 269473, XrefRangeEnd = 269495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x0027D568 File Offset: 0x0027B768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269496, XrefRangeEnd = 269503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x0027D59C File Offset: 0x0027B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269503, XrefRangeEnd = 269505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x0027D5D0 File Offset: 0x0027B7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269505, XrefRangeEnd = 269514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlippery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FD RID: 37629 RVA: 0x0027D604 File Offset: 0x0027B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269514, XrefRangeEnd = 269522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x0027D638 File Offset: 0x0027B838
		[CallerCount(0)]
		public unsafe bool CanRecoverFromRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x0027D674 File Offset: 0x0027B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269522, XrefRangeEnd = 269527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x0027D6A8 File Offset: 0x0027B8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269527, XrefRangeEnd = 269530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x0027D6EC File Offset: 0x0027B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269530, XrefRangeEnd = 269536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x0027D730 File Offset: 0x0027B930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269616, RefRangeEnd = 269618, XrefRangeStart = 269536, XrefRangeEnd = 269616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint, Collision collision = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCollision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x0027D7B4 File Offset: 0x0027B9B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269620, RefRangeEnd = 269622, XrefRangeStart = 269618, XrefRangeEnd = 269620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x0027D7F8 File Offset: 0x0027B9F8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 269675, RefRangeEnd = 269698, XrefRangeStart = 269622, XrefRangeEnd = 269675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x0027D838 File Offset: 0x0027BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269698, XrefRangeEnd = 269710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveWarp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x0027D878 File Offset: 0x0027BA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269710, XrefRangeEnd = 269713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibilityChange(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x0027D8B8 File Offset: 0x0027BAB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 269715, RefRangeEnd = 269723, XrefRangeStart = 269713, XrefRangeEnd = 269715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x0027D8F4 File Offset: 0x0027BAF4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 269737, RefRangeEnd = 269745, XrefRangeStart = 269723, XrefRangeEnd = 269737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAgentType(NPCMovement.EAgentType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x0027D934 File Offset: 0x0027BB34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269754, RefRangeEnd = 269757, XrefRangeStart = 269745, XrefRangeEnd = 269754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x0027D978 File Offset: 0x0027BB78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269224, RefRangeEnd = 269226, XrefRangeStart = 269224, XrefRangeEnd = 269226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStance(NPCMovement.EStance stance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x0027D9B8 File Offset: 0x0027BBB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269780, RefRangeEnd = 269783, XrefRangeStart = 269757, XrefRangeEnd = 269780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x0027D9F8 File Offset: 0x0027BBF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269785, RefRangeEnd = 269787, XrefRangeStart = 269783, XrefRangeEnd = 269785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngularSpeedMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAngularSpeedMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x0027DA38 File Offset: 0x0027BC38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 269796, RefRangeEnd = 269801, XrefRangeStart = 269787, XrefRangeEnd = 269796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdollDraggable(bool draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref draggable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x0027DA78 File Offset: 0x0027BC78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269808, RefRangeEnd = 269810, XrefRangeStart = 269801, XrefRangeEnd = 269808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x0027DAAC File Offset: 0x0027BCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269810, XrefRangeEnd = 269813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll_Server(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x0027DB08 File Offset: 0x0027BD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269815, RefRangeEnd = 269817, XrefRangeStart = 269813, XrefRangeEnd = 269815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x0027DB64 File Offset: 0x0027BD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269817, XrefRangeEnd = 269819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x0027DBC0 File Offset: 0x0027BDC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269840, RefRangeEnd = 269843, XrefRangeStart = 269819, XrefRangeEnd = 269840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x0027DBF4 File Offset: 0x0027BDF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269853, RefRangeEnd = 269855, XrefRangeStart = 269843, XrefRangeEnd = 269853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x0027DC78 File Offset: 0x0027BE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269855, XrefRangeEnd = 269857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009315 RID: 37653 RVA: 0x0027DCBC File Offset: 0x0027BEBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269858, RefRangeEnd = 269864, XrefRangeStart = 269857, XrefRangeEnd = 269858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x0027DCFC File Offset: 0x0027BEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269864, XrefRangeEnd = 269870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x0027DD40 File Offset: 0x0027BF40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269871, RefRangeEnd = 269873, XrefRangeStart = 269870, XrefRangeEnd = 269871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumDistanceForSuccess;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x0027DDAC File Offset: 0x0027BFAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 270019, RefRangeEnd = 270024, XrefRangeStart = 269873, XrefRangeEnd = 270019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptExistingCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successThreshold;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x0027DE28 File Offset: 0x0027C028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270025, RefRangeEnd = 270026, XrefRangeStart = 270024, XrefRangeEnd = 270025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x0027DE74 File Offset: 0x0027C074
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 270040, RefRangeEnd = 270046, XrefRangeStart = 270026, XrefRangeEnd = 270040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSetDestination(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x0027DEB4 File Offset: 0x0027C0B4
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 270057, RefRangeEnd = 270093, XrefRangeStart = 270046, XrefRangeEnd = 270057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x0027DEE8 File Offset: 0x0027C0E8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x0027DF1C File Offset: 0x0027C11C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 270113, RefRangeEnd = 270123, XrefRangeStart = 270093, XrefRangeEnd = 270113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x0027DF68 File Offset: 0x0027C168
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 270146, RefRangeEnd = 270166, XrefRangeStart = 270123, XrefRangeEnd = 270146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x0027DFB4 File Offset: 0x0027C1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270166, XrefRangeEnd = 270171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0027E010 File Offset: 0x0027C210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270171, XrefRangeEnd = 270175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x0027E044 File Offset: 0x0027C244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270177, RefRangeEnd = 270178, XrefRangeStart = 270175, XrefRangeEnd = 270177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x0027E078 File Offset: 0x0027C278
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 270195, RefRangeEnd = 270215, XrefRangeStart = 270178, XrefRangeEnd = 270195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x0027E0D0 File Offset: 0x0027C2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270241, RefRangeEnd = 270243, XrefRangeStart = 270215, XrefRangeEnd = 270241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x0027E128 File Offset: 0x0027C328
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 270244, RefRangeEnd = 270263, XrefRangeStart = 270243, XrefRangeEnd = 270244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x0027E180 File Offset: 0x0027C380
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 270275, RefRangeEnd = 270281, XrefRangeStart = 270263, XrefRangeEnd = 270275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x0027E1DC File Offset: 0x0027C3DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270304, RefRangeEnd = 270307, XrefRangeStart = 270281, XrefRangeEnd = 270304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			path = ((intPtr4 == 0) ? null : new NavMeshPath(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x0027E258 File Offset: 0x0027C458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270334, RefRangeEnd = 270335, XrefRangeStart = 270307, XrefRangeEnd = 270334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x0027E2B4 File Offset: 0x0027C4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270335, XrefRangeEnd = 270353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TraverseLadder(Ladder ladder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ladder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_TraverseLadder_Public_Void_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x0027E2F8 File Offset: 0x0027C4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270356, RefRangeEnd = 270357, XrefRangeStart = 270353, XrefRangeEnd = 270356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelTraverseLadder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CancelTraverseLadder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x0027E32C File Offset: 0x0027C52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270357, XrefRangeEnd = 270381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x0027E368 File Offset: 0x0027C568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270381, XrefRangeEnd = 270413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x0027E3A4 File Offset: 0x0027C5A4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x0027E3E0 File Offset: 0x0027C5E0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x0027E41C File Offset: 0x0027C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x0027E45C File Offset: 0x0027C65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270429, RefRangeEnd = 270430, XrefRangeStart = 270413, XrefRangeEnd = 270429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x0027E49C File Offset: 0x0027C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270430, XrefRangeEnd = 270435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009331 RID: 37681 RVA: 0x0027E4EC File Offset: 0x0027C6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270451, RefRangeEnd = 270453, XrefRangeStart = 270435, XrefRangeEnd = 270451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ActivateRagdoll_Server_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009332 RID: 37682 RVA: 0x0027E548 File Offset: 0x0027C748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269815, RefRangeEnd = 269817, XrefRangeStart = 269815, XrefRangeEnd = 269817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_Server_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x0027E5A4 File Offset: 0x0027C7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270453, XrefRangeEnd = 270464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ActivateRagdoll_Server_2690242654(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2690242654_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x0027E608 File Offset: 0x0027C808
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 270480, RefRangeEnd = 270485, XrefRangeStart = 270464, XrefRangeEnd = 270480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x0027E664 File Offset: 0x0027C864
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 270527, RefRangeEnd = 270533, XrefRangeStart = 270485, XrefRangeEnd = 270527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x0027E6C0 File Offset: 0x0027C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270533, XrefRangeEnd = 270543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0027E710 File Offset: 0x0027C910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270559, RefRangeEnd = 270560, XrefRangeStart = 270543, XrefRangeEnd = 270559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x0027E76C File Offset: 0x0027C96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270560, XrefRangeEnd = 270561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x0027E7C8 File Offset: 0x0027C9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270561, XrefRangeEnd = 270571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0027E818 File Offset: 0x0027CA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270571, XrefRangeEnd = 270580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x0027E84C File Offset: 0x0027CA4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 270617, RefRangeEnd = 270621, XrefRangeStart = 270580, XrefRangeEnd = 270617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x0027E880 File Offset: 0x0027CA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270621, XrefRangeEnd = 270624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x0027E8D0 File Offset: 0x0027CAD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270668, RefRangeEnd = 270669, XrefRangeStart = 270624, XrefRangeEnd = 270668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00044DBB File Offset: 0x00042FBB
		public NPCMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x0027E90C File Offset: 0x0027CB0C
		// (set) Token: 0x06009340 RID: 37696 RVA: 0x00044DC4 File Offset: 0x00042FC4
		public unsafe static float VehicleRunoverSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VehicleRunoverSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VehicleRunoverSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x0027E928 File Offset: 0x0027CB28
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x00044DD2 File Offset: 0x00042FD2
		public unsafe static float VehicleRunoverRelativeVelocityThreshold_Sqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VehicleRunoverRelativeVelocityThreshold_Sqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VehicleRunoverRelativeVelocityThreshold_Sqr, (void*)(&value));
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x0027E944 File Offset: 0x0027CB44
		// (set) Token: 0x06009344 RID: 37700 RVA: 0x00044DE0 File Offset: 0x00042FE0
		public unsafe static float VehicleImpactCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VehicleImpactCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VehicleImpactCooldown, (void*)(&value));
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x0027E960 File Offset: 0x0027CB60
		// (set) Token: 0x06009346 RID: 37702 RVA: 0x00044DEE File Offset: 0x00042FEE
		public unsafe static float VehicleImpactForceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VehicleImpactForceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VehicleImpactForceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x0027E97C File Offset: 0x0027CB7C
		// (set) Token: 0x06009348 RID: 37704 RVA: 0x00044DFC File Offset: 0x00042FFC
		public unsafe static float SkateboardRunoverSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SkateboardRunoverSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SkateboardRunoverSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x0027E998 File Offset: 0x0027CB98
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x00044E0A File Offset: 0x0004300A
		public unsafe static float SkateboardImpactForceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SkateboardImpactForceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SkateboardImpactForceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x0027E9B4 File Offset: 0x0027CBB4
		// (set) Token: 0x0600934C RID: 37708 RVA: 0x00044E18 File Offset: 0x00043018
		public unsafe static float LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x0027E9D0 File Offset: 0x0027CBD0
		// (set) Token: 0x0600934E RID: 37710 RVA: 0x00044E26 File Offset: 0x00043026
		public unsafe static float HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x0027E9EC File Offset: 0x0027CBEC
		// (set) Token: 0x06009350 RID: 37712 RVA: 0x00044E34 File Offset: 0x00043034
		public unsafe static float RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x0027EA08 File Offset: 0x0027CC08
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x00044E42 File Offset: 0x00043042
		public unsafe static float MOMENTUM_ANNOYED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x0027EA24 File Offset: 0x0027CC24
		// (set) Token: 0x06009354 RID: 37716 RVA: 0x00044E50 File Offset: 0x00043050
		public unsafe static float MOMENTUM_LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x0027EA40 File Offset: 0x0027CC40
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x00044E5E File Offset: 0x0004305E
		public unsafe static float MOMENTUM_HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x06009357 RID: 37719 RVA: 0x0027EA5C File Offset: 0x0027CC5C
		// (set) Token: 0x06009358 RID: 37720 RVA: 0x00044E6C File Offset: 0x0004306C
		public unsafe static float MOMENTUM_RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x0027EA78 File Offset: 0x0027CC78
		// (set) Token: 0x0600935A RID: 37722 RVA: 0x00044E7A File Offset: 0x0004307A
		public unsafe static bool USE_PATH_CACHE
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&value));
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600935B RID: 37723 RVA: 0x0027EA94 File Offset: 0x0027CC94
		// (set) Token: 0x0600935C RID: 37724 RVA: 0x00044E88 File Offset: 0x00043088
		public unsafe static float STUMBLE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600935D RID: 37725 RVA: 0x0027EAB0 File Offset: 0x0027CCB0
		// (set) Token: 0x0600935E RID: 37726 RVA: 0x00044E96 File Offset: 0x00043096
		public unsafe static float STUMBLE_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&value));
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600935F RID: 37727 RVA: 0x0027EACC File Offset: 0x0027CCCC
		// (set) Token: 0x06009360 RID: 37728 RVA: 0x00044EA4 File Offset: 0x000430A4
		public unsafe static float OBSTACLE_AVOIDANCE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x0027EAE8 File Offset: 0x0027CCE8
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x00044EB2 File Offset: 0x000430B2
		public unsafe static float OBSTACLE_AVOIDANCE_RANGE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE_SQR, (void*)(&value));
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x0027EB04 File Offset: 0x0027CD04
		// (set) Token: 0x06009364 RID: 37732 RVA: 0x00044EC0 File Offset: 0x000430C0
		public unsafe static float PLAYER_DIST_IMPACT_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x0027EB20 File Offset: 0x0027CD20
		// (set) Token: 0x06009366 RID: 37734 RVA: 0x00044ECE File Offset: 0x000430CE
		public unsafe static Dictionary<Vector3, Vector3> cachedClosestReachablePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x0027EB48 File Offset: 0x0027CD48
		// (set) Token: 0x06009368 RID: 37736 RVA: 0x00044EE0 File Offset: 0x000430E0
		public unsafe static List<Vector3> cachedClosestPointKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x06009369 RID: 37737 RVA: 0x0027EB70 File Offset: 0x0027CD70
		// (set) Token: 0x0600936A RID: 37738 RVA: 0x00044EF2 File Offset: 0x000430F2
		public unsafe static float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x0027EB8C File Offset: 0x0027CD8C
		// (set) Token: 0x0600936C RID: 37740 RVA: 0x00044F00 File Offset: 0x00043100
		public unsafe static float SlipperyModeMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600936D RID: 37741 RVA: 0x0027EBA8 File Offset: 0x0027CDA8
		// (set) Token: 0x0600936E RID: 37742 RVA: 0x00044F0E File Offset: 0x0004310E
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x0027EBD0 File Offset: 0x0027CDD0
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x00044F29 File Offset: 0x00043129
		public unsafe float _MoveSpeedMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x0027EBF8 File Offset: 0x0027CDF8
		// (set) Token: 0x06009372 RID: 37746 RVA: 0x00044F44 File Offset: 0x00043144
		public unsafe bool ObstacleAvoidanceEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ObstacleAvoidanceEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ObstacleAvoidanceEnabled)) = value;
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x06009373 RID: 37747 RVA: 0x0027EC20 File Offset: 0x0027CE20
		// (set) Token: 0x06009374 RID: 37748 RVA: 0x00044F5F File Offset: 0x0004315F
		public unsafe ObstacleAvoidanceType DefaultObstacleAvoidanceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType)) = value;
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06009375 RID: 37749 RVA: 0x0027EC48 File Offset: 0x0027CE48
		// (set) Token: 0x06009376 RID: 37750 RVA: 0x00044F7A File Offset: 0x0004317A
		public unsafe bool _SlipperyMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__SlipperyMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__SlipperyMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x06009377 RID: 37751 RVA: 0x0027EC70 File Offset: 0x0027CE70
		// (set) Token: 0x06009378 RID: 37752 RVA: 0x00044F95 File Offset: 0x00043195
		public unsafe NavMeshAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x06009379 RID: 37753 RVA: 0x0027ECA0 File Offset: 0x0027CEA0
		// (set) Token: 0x0600937A RID: 37754 RVA: 0x00044FB4 File Offset: 0x000431B4
		public unsafe NPCSpeedController SpeedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600937B RID: 37755 RVA: 0x0027ECD0 File Offset: 0x0027CED0
		// (set) Token: 0x0600937C RID: 37756 RVA: 0x00044FD3 File Offset: 0x000431D3
		public unsafe CapsuleCollider CapsuleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_CapsuleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_CapsuleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600937D RID: 37757 RVA: 0x0027ED00 File Offset: 0x0027CF00
		// (set) Token: 0x0600937E RID: 37758 RVA: 0x00044FF2 File Offset: 0x000431F2
		public unsafe NPCAnimation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600937F RID: 37759 RVA: 0x0027ED30 File Offset: 0x0027CF30
		// (set) Token: 0x06009380 RID: 37760 RVA: 0x00045011 File Offset: 0x00043211
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06009381 RID: 37761 RVA: 0x0027ED60 File Offset: 0x0027CF60
		// (set) Token: 0x06009382 RID: 37762 RVA: 0x00045030 File Offset: 0x00043230
		public unsafe Draggable RagdollDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06009383 RID: 37763 RVA: 0x0027ED90 File Offset: 0x0027CF90
		// (set) Token: 0x06009384 RID: 37764 RVA: 0x0004504F File Offset: 0x0004324F
		public unsafe Collider RagdollDraggableCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x06009385 RID: 37765 RVA: 0x0027EDC0 File Offset: 0x0027CFC0
		// (set) Token: 0x06009386 RID: 37766 RVA: 0x0004506E File Offset: 0x0004326E
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x06009387 RID: 37767 RVA: 0x0027EDF0 File Offset: 0x0027CFF0
		// (set) Token: 0x06009388 RID: 37768 RVA: 0x0004508D File Offset: 0x0004328D
		public unsafe bool _HasDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__HasDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__HasDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06009389 RID: 37769 RVA: 0x0027EE18 File Offset: 0x0027D018
		// (set) Token: 0x0600938A RID: 37770 RVA: 0x000450A8 File Offset: 0x000432A8
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600938B RID: 37771 RVA: 0x0027EE40 File Offset: 0x0027D040
		// (set) Token: 0x0600938C RID: 37772 RVA: 0x000450C3 File Offset: 0x000432C3
		public unsafe float _GravityMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600938D RID: 37773 RVA: 0x0027EE68 File Offset: 0x0027D068
		// (set) Token: 0x0600938E RID: 37774 RVA: 0x000450DE File Offset: 0x000432DE
		public unsafe NPCMovement.EStance _Stance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600938F RID: 37775 RVA: 0x0027EE90 File Offset: 0x0027D090
		// (set) Token: 0x06009390 RID: 37776 RVA: 0x000450F9 File Offset: 0x000432F9
		public unsafe float _TimeSinceHitByCar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__TimeSinceHitByCar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__TimeSinceHitByCar_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06009391 RID: 37777 RVA: 0x0027EEB8 File Offset: 0x0027D0B8
		// (set) Token: 0x06009392 RID: 37778 RVA: 0x00045114 File Offset: 0x00043314
		public unsafe float _CurrentLadderSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentLadderSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentLadderSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06009393 RID: 37779 RVA: 0x0027EEE0 File Offset: 0x0027D0E0
		// (set) Token: 0x06009394 RID: 37780 RVA: 0x0004512F File Offset: 0x0004332F
		public unsafe Ladder _CurrentLadder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ladder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06009395 RID: 37781 RVA: 0x0027EF10 File Offset: 0x0027D110
		// (set) Token: 0x06009396 RID: 37782 RVA: 0x0004514E File Offset: 0x0004334E
		public unsafe float ragdollStaticTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime)) = value;
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06009397 RID: 37783 RVA: 0x0027EF38 File Offset: 0x0027D138
		// (set) Token: 0x06009398 RID: 37784 RVA: 0x00045169 File Offset: 0x00043369
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x06009399 RID: 37785 RVA: 0x0027EF68 File Offset: 0x0027D168
		// (set) Token: 0x0600939A RID: 37786 RVA: 0x00045188 File Offset: 0x00043388
		public unsafe UnityEvent onRagdollStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x0027EF98 File Offset: 0x0027D198
		// (set) Token: 0x0600939C RID: 37788 RVA: 0x000451A7 File Offset: 0x000433A7
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x0027EFC8 File Offset: 0x0027D1C8
		// (set) Token: 0x0600939E RID: 37790 RVA: 0x000451C6 File Offset: 0x000433C6
		public unsafe Vector3 _CurrentDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x0027EFF0 File Offset: 0x0027D1F0
		// (set) Token: 0x060093A0 RID: 37792 RVA: 0x000451E1 File Offset: 0x000433E1
		public unsafe NPCPathCache _PathCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x060093A1 RID: 37793 RVA: 0x0027F020 File Offset: 0x0027D220
		// (set) Token: 0x060093A2 RID: 37794 RVA: 0x00045200 File Offset: 0x00043400
		public unsafe bool cacheNextPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath)) = value;
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x060093A3 RID: 37795 RVA: 0x0027F048 File Offset: 0x0027D248
		// (set) Token: 0x060093A4 RID: 37796 RVA: 0x0004521B File Offset: 0x0004341B
		public unsafe Action<NPCMovement.WalkResult> walkResultCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCMovement.WalkResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x060093A5 RID: 37797 RVA: 0x0027F078 File Offset: 0x0027D278
		// (set) Token: 0x060093A6 RID: 37798 RVA: 0x0004523A File Offset: 0x0004343A
		public unsafe float currentMaxDistanceForSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess)) = value;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x060093A7 RID: 37799 RVA: 0x0027F0A0 File Offset: 0x0027D2A0
		// (set) Token: 0x060093A8 RID: 37800 RVA: 0x00045255 File Offset: 0x00043455
		public unsafe bool forceIsMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving)) = value;
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x060093A9 RID: 37801 RVA: 0x0027F0C8 File Offset: 0x0027D2C8
		// (set) Token: 0x060093AA RID: 37802 RVA: 0x00045270 File Offset: 0x00043470
		public unsafe Coroutine faceDirectionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_faceDirectionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_faceDirectionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x060093AB RID: 37803 RVA: 0x0027F0F8 File Offset: 0x0027D2F8
		// (set) Token: 0x060093AC RID: 37804 RVA: 0x0004528F File Offset: 0x0004348F
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x060093AD RID: 37805 RVA: 0x0027F128 File Offset: 0x0027D328
		// (set) Token: 0x060093AE RID: 37806 RVA: 0x000452AE File Offset: 0x000434AE
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x060093AF RID: 37807 RVA: 0x0027F150 File Offset: 0x0027D350
		// (set) Token: 0x060093B0 RID: 37808 RVA: 0x000452C9 File Offset: 0x000434C9
		public unsafe float timeUntilNextStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble)) = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x060093B1 RID: 37809 RVA: 0x0027F178 File Offset: 0x0027D378
		// (set) Token: 0x060093B2 RID: 37810 RVA: 0x000452E4 File Offset: 0x000434E4
		public unsafe float timeSinceStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble)) = value;
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x0027F1A0 File Offset: 0x0027D3A0
		// (set) Token: 0x060093B4 RID: 37812 RVA: 0x000452FF File Offset: 0x000434FF
		public unsafe Vector3 stumbleDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection)) = value;
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x0027F1C8 File Offset: 0x0027D3C8
		// (set) Token: 0x060093B6 RID: 37814 RVA: 0x0004531A File Offset: 0x0004351A
		public unsafe CircularQueue<Vector3> desiredVelocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircularQueue<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x060093B7 RID: 37815 RVA: 0x0027F1F8 File Offset: 0x0027D3F8
		// (set) Token: 0x060093B8 RID: 37816 RVA: 0x00045339 File Offset: 0x00043539
		public unsafe int desiredVelocityHistoryLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength)) = value;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x060093B9 RID: 37817 RVA: 0x0027F220 File Offset: 0x0027D420
		// (set) Token: 0x060093BA RID: 37818 RVA: 0x00045354 File Offset: 0x00043554
		public unsafe float velocityHistorySpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing)) = value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x060093BB RID: 37819 RVA: 0x0027F248 File Offset: 0x0027D448
		// (set) Token: 0x060093BC RID: 37820 RVA: 0x0004536F File Offset: 0x0004356F
		public unsafe float timeSinceLastVelocityHistoryRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord)) = value;
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x0027F270 File Offset: 0x0027D470
		// (set) Token: 0x060093BE RID: 37822 RVA: 0x0004538A File Offset: 0x0004358A
		public unsafe NavMeshPath agentCurrentPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x0027F2A0 File Offset: 0x0027D4A0
		// (set) Token: 0x060093C0 RID: 37824 RVA: 0x000453A9 File Offset: 0x000435A9
		public unsafe float agentCurrentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentSpeed)) = value;
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x0027F2C8 File Offset: 0x0027D4C8
		// (set) Token: 0x060093C2 RID: 37826 RVA: 0x000453C4 File Offset: 0x000435C4
		public unsafe Il2CppStructArray<Vector3> agentCurrentPathCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentPathCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_agentCurrentPathCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x0027F2F8 File Offset: 0x0027D4F8
		// (set) Token: 0x060093C4 RID: 37828 RVA: 0x000453E3 File Offset: 0x000435E3
		public unsafe Coroutine ladderClimbRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ladderClimbRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ladderClimbRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x0027F328 File Offset: 0x0027D528
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00045402 File Offset: 0x00043602
		public unsafe float _defaultAngularSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__defaultAngularSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__defaultAngularSpeed)) = value;
			}
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x0027F350 File Offset: 0x0027D550
		// (set) Token: 0x060093C8 RID: 37832 RVA: 0x0004541D File Offset: 0x0004361D
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x0027F378 File Offset: 0x0027D578
		// (set) Token: 0x060093CA RID: 37834 RVA: 0x00045438 File Offset: 0x00043638
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006514 RID: 25876
		private static readonly IntPtr NativeFieldInfoPtr_VehicleRunoverSpeed;

		// Token: 0x04006515 RID: 25877
		private static readonly IntPtr NativeFieldInfoPtr_VehicleRunoverRelativeVelocityThreshold_Sqr;

		// Token: 0x04006516 RID: 25878
		private static readonly IntPtr NativeFieldInfoPtr_VehicleImpactCooldown;

		// Token: 0x04006517 RID: 25879
		private static readonly IntPtr NativeFieldInfoPtr_VehicleImpactForceMultiplier;

		// Token: 0x04006518 RID: 25880
		private static readonly IntPtr NativeFieldInfoPtr_SkateboardRunoverSpeed;

		// Token: 0x04006519 RID: 25881
		private static readonly IntPtr NativeFieldInfoPtr_SkateboardImpactForceMultiplier;

		// Token: 0x0400651A RID: 25882
		private static readonly IntPtr NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x0400651B RID: 25883
		private static readonly IntPtr NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x0400651C RID: 25884
		private static readonly IntPtr NativeFieldInfoPtr_RAGDOLL_THRESHOLD;

		// Token: 0x0400651D RID: 25885
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD;

		// Token: 0x0400651E RID: 25886
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x0400651F RID: 25887
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x04006520 RID: 25888
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD;

		// Token: 0x04006521 RID: 25889
		private static readonly IntPtr NativeFieldInfoPtr_USE_PATH_CACHE;

		// Token: 0x04006522 RID: 25890
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_DURATION;

		// Token: 0x04006523 RID: 25891
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_FORCE;

		// Token: 0x04006524 RID: 25892
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE;

		// Token: 0x04006525 RID: 25893
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE_SQR;

		// Token: 0x04006526 RID: 25894
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD;

		// Token: 0x04006527 RID: 25895
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestReachablePoints;

		// Token: 0x04006528 RID: 25896
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestPointKeys;

		// Token: 0x04006529 RID: 25897
		private static readonly IntPtr NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET;

		// Token: 0x0400652A RID: 25898
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyModeMultiplier;

		// Token: 0x0400652B RID: 25899
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x0400652C RID: 25900
		private static readonly IntPtr NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField;

		// Token: 0x0400652D RID: 25901
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleAvoidanceEnabled;

		// Token: 0x0400652E RID: 25902
		private static readonly IntPtr NativeFieldInfoPtr_DefaultObstacleAvoidanceType;

		// Token: 0x0400652F RID: 25903
		private static readonly IntPtr NativeFieldInfoPtr__SlipperyMode_k__BackingField;

		// Token: 0x04006530 RID: 25904
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x04006531 RID: 25905
		private static readonly IntPtr NativeFieldInfoPtr_SpeedController;

		// Token: 0x04006532 RID: 25906
		private static readonly IntPtr NativeFieldInfoPtr_CapsuleCollider;

		// Token: 0x04006533 RID: 25907
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04006534 RID: 25908
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04006535 RID: 25909
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggable;

		// Token: 0x04006536 RID: 25910
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggableCollider;

		// Token: 0x04006537 RID: 25911
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04006538 RID: 25912
		private static readonly IntPtr NativeFieldInfoPtr__HasDestination_k__BackingField;

		// Token: 0x04006539 RID: 25913
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x0400653A RID: 25914
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x0400653B RID: 25915
		private static readonly IntPtr NativeFieldInfoPtr__Stance_k__BackingField;

		// Token: 0x0400653C RID: 25916
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceHitByCar_k__BackingField;

		// Token: 0x0400653D RID: 25917
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLadderSpeed_k__BackingField;

		// Token: 0x0400653E RID: 25918
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLadder_k__BackingField;

		// Token: 0x0400653F RID: 25919
		private static readonly IntPtr NativeFieldInfoPtr_ragdollStaticTime;

		// Token: 0x04006540 RID: 25920
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x04006541 RID: 25921
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollStart;

		// Token: 0x04006542 RID: 25922
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x04006543 RID: 25923
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDestination_k__BackingField;

		// Token: 0x04006544 RID: 25924
		private static readonly IntPtr NativeFieldInfoPtr__PathCache_k__BackingField;

		// Token: 0x04006545 RID: 25925
		private static readonly IntPtr NativeFieldInfoPtr_cacheNextPath;

		// Token: 0x04006546 RID: 25926
		private static readonly IntPtr NativeFieldInfoPtr_walkResultCallback;

		// Token: 0x04006547 RID: 25927
		private static readonly IntPtr NativeFieldInfoPtr_currentMaxDistanceForSuccess;

		// Token: 0x04006548 RID: 25928
		private static readonly IntPtr NativeFieldInfoPtr_forceIsMoving;

		// Token: 0x04006549 RID: 25929
		private static readonly IntPtr NativeFieldInfoPtr_faceDirectionRoutine;

		// Token: 0x0400654A RID: 25930
		private static readonly IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x0400654B RID: 25931
		private static readonly IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x0400654C RID: 25932
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextStumble;

		// Token: 0x0400654D RID: 25933
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStumble;

		// Token: 0x0400654E RID: 25934
		private static readonly IntPtr NativeFieldInfoPtr_stumbleDirection;

		// Token: 0x0400654F RID: 25935
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistory;

		// Token: 0x04006550 RID: 25936
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistoryLength;

		// Token: 0x04006551 RID: 25937
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistorySpacing;

		// Token: 0x04006552 RID: 25938
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord;

		// Token: 0x04006553 RID: 25939
		private static readonly IntPtr NativeFieldInfoPtr_agentCurrentPath;

		// Token: 0x04006554 RID: 25940
		private static readonly IntPtr NativeFieldInfoPtr_agentCurrentSpeed;

		// Token: 0x04006555 RID: 25941
		private static readonly IntPtr NativeFieldInfoPtr_agentCurrentPathCorners;

		// Token: 0x04006556 RID: 25942
		private static readonly IntPtr NativeFieldInfoPtr_ladderClimbRoutine;

		// Token: 0x04006557 RID: 25943
		private static readonly IntPtr NativeFieldInfoPtr__defaultAngularSpeed;

		// Token: 0x04006558 RID: 25944
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006559 RID: 25945
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400655A RID: 25946
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x0400655B RID: 25947
		private static readonly IntPtr NativeMethodInfoPtr_get_RunSpeed_Public_get_Single_0;

		// Token: 0x0400655C RID: 25948
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0;

		// Token: 0x0400655D RID: 25949
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0;

		// Token: 0x0400655E RID: 25950
		private static readonly IntPtr NativeMethodInfoPtr_get_SlipperyMode_Public_get_Boolean_0;

		// Token: 0x0400655F RID: 25951
		private static readonly IntPtr NativeMethodInfoPtr_set_SlipperyMode_Public_set_Void_Boolean_0;

		// Token: 0x04006560 RID: 25952
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDestination_Public_get_Boolean_0;

		// Token: 0x04006561 RID: 25953
		private static readonly IntPtr NativeMethodInfoPtr_set_HasDestination_Protected_set_Void_Boolean_0;

		// Token: 0x04006562 RID: 25954
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x04006563 RID: 25955
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x04006564 RID: 25956
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04006565 RID: 25957
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x04006566 RID: 25958
		private static readonly IntPtr NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0;

		// Token: 0x04006567 RID: 25959
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0;

		// Token: 0x04006568 RID: 25960
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0;

		// Token: 0x04006569 RID: 25961
		private static readonly IntPtr NativeMethodInfoPtr_get_Stance_Public_get_EStance_0;

		// Token: 0x0400656A RID: 25962
		private static readonly IntPtr NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0;

		// Token: 0x0400656B RID: 25963
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceHitByCar_Public_get_Single_0;

		// Token: 0x0400656C RID: 25964
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceHitByCar_Protected_set_Void_Single_0;

		// Token: 0x0400656D RID: 25965
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0;

		// Token: 0x0400656E RID: 25966
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0;

		// Token: 0x0400656F RID: 25967
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLadderSpeed_Public_get_Single_0;

		// Token: 0x04006570 RID: 25968
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLadderSpeed_Protected_set_Void_Single_0;

		// Token: 0x04006571 RID: 25969
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClimbingUpwards_Public_get_Boolean_0;

		// Token: 0x04006572 RID: 25970
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0;

		// Token: 0x04006573 RID: 25971
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLadder_Protected_set_Void_Ladder_0;

		// Token: 0x04006574 RID: 25972
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0;

		// Token: 0x04006575 RID: 25973
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0;

		// Token: 0x04006576 RID: 25974
		private static readonly IntPtr NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0;

		// Token: 0x04006577 RID: 25975
		private static readonly IntPtr NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0;

		// Token: 0x04006578 RID: 25976
		private static readonly IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x04006579 RID: 25977
		private static readonly IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x0400657A RID: 25978
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400657B RID: 25979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400657C RID: 25980
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400657D RID: 25981
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400657E RID: 25982
		private static readonly IntPtr NativeMethodInfoPtr_SetAgentEnabled_Public_Void_Boolean_0;

		// Token: 0x0400657F RID: 25983
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0;

		// Token: 0x04006580 RID: 25984
		private static readonly IntPtr NativeMethodInfoPtr_Stumble_Private_Void_0;

		// Token: 0x04006581 RID: 25985
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x04006582 RID: 25986
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04006583 RID: 25987
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStumble_Private_Void_0;

		// Token: 0x04006584 RID: 25988
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Private_Void_0;

		// Token: 0x04006585 RID: 25989
		private static readonly IntPtr NativeMethodInfoPtr_RecordVelocity_Private_Void_0;

		// Token: 0x04006586 RID: 25990
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlippery_Private_Void_0;

		// Token: 0x04006587 RID: 25991
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCache_Private_Void_0;

		// Token: 0x04006588 RID: 25992
		private static readonly IntPtr NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0;

		// Token: 0x04006589 RID: 25993
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0;

		// Token: 0x0400658A RID: 25994
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x0400658B RID: 25995
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x0400658C RID: 25996
		private static readonly IntPtr NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_Collision_0;

		// Token: 0x0400658D RID: 25997
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Transform_0;

		// Token: 0x0400658E RID: 25998
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Vector3_0;

		// Token: 0x0400658F RID: 25999
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0;

		// Token: 0x04006590 RID: 26000
		private static readonly IntPtr NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0;

		// Token: 0x04006591 RID: 26001
		private static readonly IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

		// Token: 0x04006592 RID: 26002
		private static readonly IntPtr NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0;

		// Token: 0x04006593 RID: 26003
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04006594 RID: 26004
		private static readonly IntPtr NativeMethodInfoPtr_SetStance_Public_Void_EStance_0;

		// Token: 0x04006595 RID: 26005
		private static readonly IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x04006596 RID: 26006
		private static readonly IntPtr NativeMethodInfoPtr_SetAngularSpeedMultiplier_Public_Void_Single_0;

		// Token: 0x04006597 RID: 26007
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0;

		// Token: 0x04006598 RID: 26008
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0;

		// Token: 0x04006599 RID: 26009
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400659A RID: 26010
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400659B RID: 26011
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400659C RID: 26012
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0;

		// Token: 0x0400659D RID: 26013
		private static readonly IntPtr NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0;

		// Token: 0x0400659E RID: 26014
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Transform_0;

		// Token: 0x0400659F RID: 26015
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0;

		// Token: 0x040065A0 RID: 26016
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0;

		// Token: 0x040065A1 RID: 26017
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0;

		// Token: 0x040065A2 RID: 26018
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0;

		// Token: 0x040065A3 RID: 26019
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x040065A4 RID: 26020
		private static readonly IntPtr NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0;

		// Token: 0x040065A5 RID: 26021
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040065A6 RID: 26022
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x040065A7 RID: 26023
		private static readonly IntPtr NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0;

		// Token: 0x040065A8 RID: 26024
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0;

		// Token: 0x040065A9 RID: 26025
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0;

		// Token: 0x040065AA RID: 26026
		private static readonly IntPtr NativeMethodInfoPtr_PauseMovement_Public_Void_0;

		// Token: 0x040065AB RID: 26027
		private static readonly IntPtr NativeMethodInfoPtr_ResumeMovement_Public_Void_0;

		// Token: 0x040065AC RID: 26028
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0;

		// Token: 0x040065AD RID: 26029
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x040065AE RID: 26030
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0;

		// Token: 0x040065AF RID: 26031
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0;

		// Token: 0x040065B0 RID: 26032
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0;

		// Token: 0x040065B1 RID: 26033
		private static readonly IntPtr NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0;

		// Token: 0x040065B2 RID: 26034
		private static readonly IntPtr NativeMethodInfoPtr_TraverseLadder_Public_Void_Ladder_0;

		// Token: 0x040065B3 RID: 26035
		private static readonly IntPtr NativeMethodInfoPtr_CancelTraverseLadder_Private_Void_0;

		// Token: 0x040065B4 RID: 26036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040065B5 RID: 26037
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040065B6 RID: 26038
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040065B7 RID: 26039
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040065B8 RID: 26040
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x040065B9 RID: 26041
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x040065BA RID: 26042
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x040065BB RID: 26043
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065BC RID: 26044
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065BD RID: 26045
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2690242654_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040065BE RID: 26046
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065BF RID: 26047
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065C0 RID: 26048
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x040065C1 RID: 26049
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065C2 RID: 26050
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x040065C3 RID: 26051
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x040065C4 RID: 26052
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0;

		// Token: 0x040065C5 RID: 26053
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0;

		// Token: 0x040065C6 RID: 26054
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040065C7 RID: 26055
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000C26 RID: 3110
		[OriginalName("Assembly-CSharp.dll", "", "EAgentType")]
		public enum EAgentType
		{
			// Token: 0x0400A19C RID: 41372
			Humanoid,
			// Token: 0x0400A19D RID: 41373
			BigHumanoid,
			// Token: 0x0400A19E RID: 41374
			IgnoreCosts
		}

		// Token: 0x02000C27 RID: 3111
		[OriginalName("Assembly-CSharp.dll", "", "EStance")]
		public enum EStance
		{
			// Token: 0x0400A1A0 RID: 41376
			None,
			// Token: 0x0400A1A1 RID: 41377
			Stanced
		}

		// Token: 0x02000C28 RID: 3112
		[OriginalName("Assembly-CSharp.dll", "", "WalkResult")]
		public enum WalkResult
		{
			// Token: 0x0400A1A3 RID: 41379
			Failed,
			// Token: 0x0400A1A4 RID: 41380
			Interrupted,
			// Token: 0x0400A1A5 RID: 41381
			Stopped,
			// Token: 0x0400A1A6 RID: 41382
			Partial,
			// Token: 0x0400A1A7 RID: 41383
			Success
		}

		// Token: 0x02000C29 RID: 3113
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass179_0")]
		public sealed class __c__DisplayClass179_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EEBC RID: 61116 RVA: 0x0039B988 File Offset: 0x00399B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass179_0()
			{
				Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c__DisplayClass179_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr);
				NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, "<>4__this");
				NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr_ladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, "ladder");
				NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, 100682570);
				NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, 100682571);
				NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, 100682572);
			}

			// Token: 0x0600EEBD RID: 61117 RVA: 0x0039BA18 File Offset: 0x00399C18
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass179_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEBE RID: 61118 RVA: 0x0039BA54 File Offset: 0x00399C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269103, XrefRangeEnd = 269108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EEBF RID: 61119 RVA: 0x0039BA94 File Offset: 0x00399C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269108, XrefRangeEnd = 269113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EEC0 RID: 61120 RVA: 0x00070B0E File Offset: 0x0006ED0E
			public __c__DisplayClass179_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004860 RID: 18528
			// (get) Token: 0x0600EEC1 RID: 61121 RVA: 0x0039BAD4 File Offset: 0x00399CD4
			// (set) Token: 0x0600EEC2 RID: 61122 RVA: 0x00070B17 File Offset: 0x0006ED17
			public unsafe NPCMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004861 RID: 18529
			// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x0039BB04 File Offset: 0x00399D04
			// (set) Token: 0x0600EEC4 RID: 61124 RVA: 0x00070B36 File Offset: 0x0006ED36
			public unsafe Ladder ladder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr_ladder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ladder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.NativeFieldInfoPtr_ladder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1A8 RID: 41384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A1A9 RID: 41385
			private static readonly IntPtr NativeFieldInfoPtr_ladder;

			// Token: 0x0400A1AA RID: 41386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1AB RID: 41387
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A1AC RID: 41388
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000DFC RID: 3580
			[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass179_0+<<TraverseLadder>g__OverrideLookDirection|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060101F4 RID: 66036 RVA: 0x003D3980 File Offset: 0x003D1B80
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, "<<TraverseLadder>g__OverrideLookDirection|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682573);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682574);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682575);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682576);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682577);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682578);
				}

				// Token: 0x060101F5 RID: 66037 RVA: 0x003D3A60 File Offset: 0x003D1C60
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101F6 RID: 66038 RVA: 0x003D3AA8 File Offset: 0x003D1CA8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101F7 RID: 66039 RVA: 0x003D3ADC File Offset: 0x003D1CDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268994, XrefRangeEnd = 269004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EB4 RID: 20148
				// (get) Token: 0x060101F8 RID: 66040 RVA: 0x003D3B18 File Offset: 0x003D1D18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101F9 RID: 66041 RVA: 0x003D3B58 File Offset: 0x003D1D58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269004, XrefRangeEnd = 269009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EB5 RID: 20149
				// (get) Token: 0x060101FA RID: 66042 RVA: 0x003D3B8C File Offset: 0x003D1D8C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101FB RID: 66043 RVA: 0x0007A3F3 File Offset: 0x000785F3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EB1 RID: 20145
				// (get) Token: 0x060101FC RID: 66044 RVA: 0x003D3BCC File Offset: 0x003D1DCC
				// (set) Token: 0x060101FD RID: 66045 RVA: 0x0007A3FC File Offset: 0x000785FC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EB2 RID: 20146
				// (get) Token: 0x060101FE RID: 66046 RVA: 0x003D3BF4 File Offset: 0x003D1DF4
				// (set) Token: 0x060101FF RID: 66047 RVA: 0x0007A417 File Offset: 0x00078617
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EB3 RID: 20147
				// (get) Token: 0x06010200 RID: 66048 RVA: 0x003D3C24 File Offset: 0x003D1E24
				// (set) Token: 0x06010201 RID: 66049 RVA: 0x0007A436 File Offset: 0x00078636
				public unsafe NPCMovement.__c__DisplayClass179_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement.__c__DisplayClass179_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ADAF RID: 44463
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADB0 RID: 44464
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADB1 RID: 44465
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADB2 RID: 44466
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ADB3 RID: 44467
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADB4 RID: 44468
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ADB5 RID: 44469
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ADB6 RID: 44470
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADB7 RID: 44471
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000DFD RID: 3581
			[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass179_0+<<TraverseLadder>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010202 RID: 66050 RVA: 0x003D3C54 File Offset: 0x003D1E54
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique()
				{
					Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0>.NativeClassPtr, "<<TraverseLadder>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<>1__state");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<>2__current");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<>4__this");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startFromTop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<startFromTop>5__2");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startLadderPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<startLadderPos>5__3");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endLadderPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<endLadderPos>5__4");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__ladderRot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<ladderRot>5__5");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCPos_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<startNPCPos>5__6");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCRot_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<startNPCRot>5__7");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endNPCPos_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<endNPCPos>5__8");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endPlayerRot_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<endPlayerRot>5__9");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__mountLerpTime_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<mountLerpTime>5__10");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__climbLerpTime_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<climbLerpTime>5__11");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__dismountLerpTime_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<dismountLerpTime>5__12");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__timeUntilClimbSoundPlays_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<timeUntilClimbSoundPlays>5__13");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__t_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, "<t>5__14");
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682579);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682580);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682581);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682582);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682583);
					NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr, 100682584);
				}

				// Token: 0x06010203 RID: 66051 RVA: 0x003D3E38 File Offset: 0x003D2038
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010204 RID: 66052 RVA: 0x003D3E80 File Offset: 0x003D2080
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010205 RID: 66053 RVA: 0x003D3EB4 File Offset: 0x003D20B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269009, XrefRangeEnd = 269098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EC6 RID: 20166
				// (get) Token: 0x06010206 RID: 66054 RVA: 0x003D3EF0 File Offset: 0x003D20F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010207 RID: 66055 RVA: 0x003D3F30 File Offset: 0x003D2130
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269098, XrefRangeEnd = 269103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EC7 RID: 20167
				// (get) Token: 0x06010208 RID: 66056 RVA: 0x003D3F64 File Offset: 0x003D2164
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010209 RID: 66057 RVA: 0x0007A455 File Offset: 0x00078655
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EB6 RID: 20150
				// (get) Token: 0x0601020A RID: 66058 RVA: 0x003D3FA4 File Offset: 0x003D21A4
				// (set) Token: 0x0601020B RID: 66059 RVA: 0x0007A45E File Offset: 0x0007865E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EB7 RID: 20151
				// (get) Token: 0x0601020C RID: 66060 RVA: 0x003D3FCC File Offset: 0x003D21CC
				// (set) Token: 0x0601020D RID: 66061 RVA: 0x0007A479 File Offset: 0x00078679
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EB8 RID: 20152
				// (get) Token: 0x0601020E RID: 66062 RVA: 0x003D3FFC File Offset: 0x003D21FC
				// (set) Token: 0x0601020F RID: 66063 RVA: 0x0007A498 File Offset: 0x00078698
				public unsafe NPCMovement.__c__DisplayClass179_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement.__c__DisplayClass179_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EB9 RID: 20153
				// (get) Token: 0x06010210 RID: 66064 RVA: 0x003D402C File Offset: 0x003D222C
				// (set) Token: 0x06010211 RID: 66065 RVA: 0x0007A4B7 File Offset: 0x000786B7
				public unsafe bool _startFromTop_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startFromTop_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startFromTop_5__2)) = value;
					}
				}

				// Token: 0x17004EBA RID: 20154
				// (get) Token: 0x06010212 RID: 66066 RVA: 0x003D4054 File Offset: 0x003D2254
				// (set) Token: 0x06010213 RID: 66067 RVA: 0x0007A4D2 File Offset: 0x000786D2
				public unsafe Vector3 _startLadderPos_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startLadderPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startLadderPos_5__3)) = value;
					}
				}

				// Token: 0x17004EBB RID: 20155
				// (get) Token: 0x06010214 RID: 66068 RVA: 0x003D407C File Offset: 0x003D227C
				// (set) Token: 0x06010215 RID: 66069 RVA: 0x0007A4ED File Offset: 0x000786ED
				public unsafe Vector3 _endLadderPos_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endLadderPos_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endLadderPos_5__4)) = value;
					}
				}

				// Token: 0x17004EBC RID: 20156
				// (get) Token: 0x06010216 RID: 66070 RVA: 0x003D40A4 File Offset: 0x003D22A4
				// (set) Token: 0x06010217 RID: 66071 RVA: 0x0007A508 File Offset: 0x00078708
				public unsafe Quaternion _ladderRot_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__ladderRot_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__ladderRot_5__5)) = value;
					}
				}

				// Token: 0x17004EBD RID: 20157
				// (get) Token: 0x06010218 RID: 66072 RVA: 0x003D40CC File Offset: 0x003D22CC
				// (set) Token: 0x06010219 RID: 66073 RVA: 0x0007A523 File Offset: 0x00078723
				public unsafe Vector3 _startNPCPos_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCPos_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCPos_5__6)) = value;
					}
				}

				// Token: 0x17004EBE RID: 20158
				// (get) Token: 0x0601021A RID: 66074 RVA: 0x003D40F4 File Offset: 0x003D22F4
				// (set) Token: 0x0601021B RID: 66075 RVA: 0x0007A53E File Offset: 0x0007873E
				public unsafe Quaternion _startNPCRot_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCRot_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__startNPCRot_5__7)) = value;
					}
				}

				// Token: 0x17004EBF RID: 20159
				// (get) Token: 0x0601021C RID: 66076 RVA: 0x003D411C File Offset: 0x003D231C
				// (set) Token: 0x0601021D RID: 66077 RVA: 0x0007A559 File Offset: 0x00078759
				public unsafe Vector3 _endNPCPos_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endNPCPos_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endNPCPos_5__8)) = value;
					}
				}

				// Token: 0x17004EC0 RID: 20160
				// (get) Token: 0x0601021E RID: 66078 RVA: 0x003D4144 File Offset: 0x003D2344
				// (set) Token: 0x0601021F RID: 66079 RVA: 0x0007A574 File Offset: 0x00078774
				public unsafe Quaternion _endPlayerRot_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endPlayerRot_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__endPlayerRot_5__9)) = value;
					}
				}

				// Token: 0x17004EC1 RID: 20161
				// (get) Token: 0x06010220 RID: 66080 RVA: 0x003D416C File Offset: 0x003D236C
				// (set) Token: 0x06010221 RID: 66081 RVA: 0x0007A58F File Offset: 0x0007878F
				public unsafe float _mountLerpTime_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__mountLerpTime_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__mountLerpTime_5__10)) = value;
					}
				}

				// Token: 0x17004EC2 RID: 20162
				// (get) Token: 0x06010222 RID: 66082 RVA: 0x003D4194 File Offset: 0x003D2394
				// (set) Token: 0x06010223 RID: 66083 RVA: 0x0007A5AA File Offset: 0x000787AA
				public unsafe float _climbLerpTime_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__climbLerpTime_5__11);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__climbLerpTime_5__11)) = value;
					}
				}

				// Token: 0x17004EC3 RID: 20163
				// (get) Token: 0x06010224 RID: 66084 RVA: 0x003D41BC File Offset: 0x003D23BC
				// (set) Token: 0x06010225 RID: 66085 RVA: 0x0007A5C5 File Offset: 0x000787C5
				public unsafe float _dismountLerpTime_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__dismountLerpTime_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__dismountLerpTime_5__12)) = value;
					}
				}

				// Token: 0x17004EC4 RID: 20164
				// (get) Token: 0x06010226 RID: 66086 RVA: 0x003D41E4 File Offset: 0x003D23E4
				// (set) Token: 0x06010227 RID: 66087 RVA: 0x0007A5E0 File Offset: 0x000787E0
				public unsafe float _timeUntilClimbSoundPlays_5__13
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__timeUntilClimbSoundPlays_5__13);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__timeUntilClimbSoundPlays_5__13)) = value;
					}
				}

				// Token: 0x17004EC5 RID: 20165
				// (get) Token: 0x06010228 RID: 66088 RVA: 0x003D420C File Offset: 0x003D240C
				// (set) Token: 0x06010229 RID: 66089 RVA: 0x0007A5FB File Offset: 0x000787FB
				public unsafe float _t_5__14
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__t_5__14);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass179_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoVeQuVeSiQuSiObUnique.NativeFieldInfoPtr__t_5__14)) = value;
					}
				}

				// Token: 0x0400ADB8 RID: 44472
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADB9 RID: 44473
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADBA RID: 44474
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADBB RID: 44475
				private static readonly IntPtr NativeFieldInfoPtr__startFromTop_5__2;

				// Token: 0x0400ADBC RID: 44476
				private static readonly IntPtr NativeFieldInfoPtr__startLadderPos_5__3;

				// Token: 0x0400ADBD RID: 44477
				private static readonly IntPtr NativeFieldInfoPtr__endLadderPos_5__4;

				// Token: 0x0400ADBE RID: 44478
				private static readonly IntPtr NativeFieldInfoPtr__ladderRot_5__5;

				// Token: 0x0400ADBF RID: 44479
				private static readonly IntPtr NativeFieldInfoPtr__startNPCPos_5__6;

				// Token: 0x0400ADC0 RID: 44480
				private static readonly IntPtr NativeFieldInfoPtr__startNPCRot_5__7;

				// Token: 0x0400ADC1 RID: 44481
				private static readonly IntPtr NativeFieldInfoPtr__endNPCPos_5__8;

				// Token: 0x0400ADC2 RID: 44482
				private static readonly IntPtr NativeFieldInfoPtr__endPlayerRot_5__9;

				// Token: 0x0400ADC3 RID: 44483
				private static readonly IntPtr NativeFieldInfoPtr__mountLerpTime_5__10;

				// Token: 0x0400ADC4 RID: 44484
				private static readonly IntPtr NativeFieldInfoPtr__climbLerpTime_5__11;

				// Token: 0x0400ADC5 RID: 44485
				private static readonly IntPtr NativeFieldInfoPtr__dismountLerpTime_5__12;

				// Token: 0x0400ADC6 RID: 44486
				private static readonly IntPtr NativeFieldInfoPtr__timeUntilClimbSoundPlays_5__13;

				// Token: 0x0400ADC7 RID: 44487
				private static readonly IntPtr NativeFieldInfoPtr__t_5__14;

				// Token: 0x0400ADC8 RID: 44488
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ADC9 RID: 44489
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADCA RID: 44490
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ADCB RID: 44491
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ADCC RID: 44492
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADCD RID: 44493
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C2A RID: 3114
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<FaceDirection_Process>d__170")]
		public sealed class _FaceDirection_Process_d__170 : Il2CppSystem.Object
		{
			// Token: 0x0600EEC5 RID: 61125 RVA: 0x0039BB34 File Offset: 0x00399D34
			// Note: this type is marked as 'beforefieldinit'.
			static _FaceDirection_Process_d__170()
			{
				Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<FaceDirection_Process>d__170");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr);
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "<>1__state");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "<>2__current");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "lerpTime");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "<>4__this");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "forward");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "<startRot>5__2");
				NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, "<i>5__3");
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682585);
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682586);
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682587);
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682588);
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682589);
				NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr, 100682590);
			}

			// Token: 0x0600EEC6 RID: 61126 RVA: 0x0039BC64 File Offset: 0x00399E64
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FaceDirection_Process_d__170(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__170>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC7 RID: 61127 RVA: 0x0039BCAC File Offset: 0x00399EAC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC8 RID: 61128 RVA: 0x0039BCE0 File Offset: 0x00399EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269113, XrefRangeEnd = 269139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004869 RID: 18537
			// (get) Token: 0x0600EEC9 RID: 61129 RVA: 0x0039BD1C File Offset: 0x00399F1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EECA RID: 61130 RVA: 0x0039BD5C File Offset: 0x00399F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269139, XrefRangeEnd = 269144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700486A RID: 18538
			// (get) Token: 0x0600EECB RID: 61131 RVA: 0x0039BD90 File Offset: 0x00399F90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EECC RID: 61132 RVA: 0x00070B55 File Offset: 0x0006ED55
			public _FaceDirection_Process_d__170(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004862 RID: 18530
			// (get) Token: 0x0600EECD RID: 61133 RVA: 0x0039BDD0 File Offset: 0x00399FD0
			// (set) Token: 0x0600EECE RID: 61134 RVA: 0x00070B5E File Offset: 0x0006ED5E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004863 RID: 18531
			// (get) Token: 0x0600EECF RID: 61135 RVA: 0x0039BDF8 File Offset: 0x00399FF8
			// (set) Token: 0x0600EED0 RID: 61136 RVA: 0x00070B79 File Offset: 0x0006ED79
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004864 RID: 18532
			// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x0039BE28 File Offset: 0x0039A028
			// (set) Token: 0x0600EED2 RID: 61138 RVA: 0x00070B98 File Offset: 0x0006ED98
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004865 RID: 18533
			// (get) Token: 0x0600EED3 RID: 61139 RVA: 0x0039BE50 File Offset: 0x0039A050
			// (set) Token: 0x0600EED4 RID: 61140 RVA: 0x00070BB3 File Offset: 0x0006EDB3
			public unsafe NPCMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004866 RID: 18534
			// (get) Token: 0x0600EED5 RID: 61141 RVA: 0x0039BE80 File Offset: 0x0039A080
			// (set) Token: 0x0600EED6 RID: 61142 RVA: 0x00070BD2 File Offset: 0x0006EDD2
			public unsafe Vector3 forward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_forward);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr_forward)) = value;
				}
			}

			// Token: 0x17004867 RID: 18535
			// (get) Token: 0x0600EED7 RID: 61143 RVA: 0x0039BEA8 File Offset: 0x0039A0A8
			// (set) Token: 0x0600EED8 RID: 61144 RVA: 0x00070BED File Offset: 0x0006EDED
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17004868 RID: 18536
			// (get) Token: 0x0600EED9 RID: 61145 RVA: 0x0039BED0 File Offset: 0x0039A0D0
			// (set) Token: 0x0600EEDA RID: 61146 RVA: 0x00070C08 File Offset: 0x0006EE08
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__170.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A1AD RID: 41389
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A1AE RID: 41390
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A1AF RID: 41391
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400A1B0 RID: 41392
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A1B1 RID: 41393
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x0400A1B2 RID: 41394
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x0400A1B3 RID: 41395
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A1B4 RID: 41396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A1B5 RID: 41397
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A1B6 RID: 41398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A1B7 RID: 41399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A1B8 RID: 41400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A1B9 RID: 41401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
