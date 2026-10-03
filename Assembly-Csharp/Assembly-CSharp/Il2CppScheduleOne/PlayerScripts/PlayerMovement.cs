using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200032B RID: 811
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x06004426 RID: 17446 RVA: 0x00164320 File Offset: 0x00162520
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMovement()
		{
			Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr);
			PlayerMovement.NativeFieldInfoPtr_DevSprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DevSprintMultiplier");
			PlayerMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "WalkSpeed");
			PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaticMoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_InputSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "InputSensitivity");
			PlayerMovement.NativeFieldInfoPtr_InputDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "InputDeadZone");
			PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlipperyMovementMultiplier");
			PlayerMovement.NativeFieldInfoPtr_GroundedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GroundedThreshold");
			PlayerMovement.NativeFieldInfoPtr_SlopeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlopeThreshold");
			PlayerMovement.NativeFieldInfoPtr_SlopeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlopeForce");
			PlayerMovement.NativeFieldInfoPtr_SlopeForceRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlopeForceRayLength");
			PlayerMovement.NativeFieldInfoPtr_ControllerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ControllerRadius");
			PlayerMovement.NativeFieldInfoPtr_DefaultCharacterControllerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DefaultCharacterControllerHeight");
			PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchHeightMultiplier");
			PlayerMovement.NativeFieldInfoPtr_CrouchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchTime");
			PlayerMovement.NativeFieldInfoPtr_CrouchSpeedMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchSpeedMultipler");
			PlayerMovement.NativeFieldInfoPtr_CrouchedVigIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchedVigIntensity");
			PlayerMovement.NativeFieldInfoPtr_CrouchedVigSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchedVigSmoothness");
			PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintingRequiresStamina");
			PlayerMovement.NativeFieldInfoPtr_SprintChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintChangeRate");
			PlayerMovement.NativeFieldInfoPtr_SprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaDrainRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreDelay");
			PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaReserveMax");
			PlayerMovement.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "JumpForce");
			PlayerMovement.NativeFieldInfoPtr_JumpMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "JumpMultiplier");
			PlayerMovement.NativeFieldInfoPtr_GravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GravityMultiplier");
			PlayerMovement.NativeFieldInfoPtr_BaseGravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "BaseGravityMultiplier");
			PlayerMovement.NativeFieldInfoPtr_VerticalLadderSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "VerticalLadderSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_LateralLadderSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "LateralLadderSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_LadderTopBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "LadderTopBuffer");
			PlayerMovement.NativeFieldInfoPtr_LadderPitchAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "LadderPitchAdjustment");
			PlayerMovement.NativeFieldInfoPtr_DismountForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DismountForce");
			PlayerMovement.NativeFieldInfoPtr_DismountForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DismountForceDuration");
			PlayerMovement.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Player");
			PlayerMovement.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Controller");
			PlayerMovement.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GroundDetectionMask");
			PlayerMovement.NativeFieldInfoPtr__CanJump_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CanJump>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__IsJumping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsJumping>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__TimeAirborne_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<TimeAirborne>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__TimeGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<TimeGrounded>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsGrounded>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__IsCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsCrouched>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__StandingScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<StandingScale>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__IsRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsRagdolled>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__IsSprinting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsSprinting>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__ForceSprint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<ForceSprint>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentStaminaReserve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentStaminaReserve>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentSprintMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentVehicle>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentLadder>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplierStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MoveSpeedMultiplierStack");
			PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onStaminaReserveChanged");
			PlayerMovement.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onJump");
			PlayerMovement.NativeFieldInfoPtr_onLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onLand");
			PlayerMovement.NativeFieldInfoPtr_onCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onCrouch");
			PlayerMovement.NativeFieldInfoPtr_onUncrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onUncrouch");
			PlayerMovement.NativeFieldInfoPtr__canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "_canMove");
			PlayerMovement.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movement");
			PlayerMovement.NativeFieldInfoPtr_lastFrameMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastFrameMovement");
			PlayerMovement.NativeFieldInfoPtr_movementY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementY");
			PlayerMovement.NativeFieldInfoPtr_timeOnLadderDismount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeOnLadderDismount");
			PlayerMovement.NativeFieldInfoPtr_ladderDismountDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ladderDismountDir");
			PlayerMovement.NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "horizontalAxis");
			PlayerMovement.NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "verticalAxis");
			PlayerMovement.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementEvents");
			PlayerMovement.NativeFieldInfoPtr_movementEventKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementEventKeys");
			PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeSinceStaminaDrain");
			PlayerMovement.NativeFieldInfoPtr_sprintActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintActive");
			PlayerMovement.NativeFieldInfoPtr_sprintReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintReleased");
			PlayerMovement.NativeFieldInfoPtr_sprintBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintBlockers");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDirection");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityForce");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDuration");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityTimeRemaining");
			PlayerMovement.NativeFieldInfoPtr_teleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleport");
			PlayerMovement.NativeFieldInfoPtr_teleportPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleportPosition");
			PlayerMovement.NativeFieldInfoPtr_playerLadderYPosOnLastClimbSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "playerLadderYPosOnLastClimbSound");
			PlayerMovement.NativeFieldInfoPtr__slope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "_slope");
			PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "playerRotCoroutine");
			PlayerMovement.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672151);
			PlayerMovement.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672152);
			PlayerMovement.NativeMethodInfoPtr_get_CanJump_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672153);
			PlayerMovement.NativeMethodInfoPtr_set_CanJump_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672154);
			PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672155);
			PlayerMovement.NativeMethodInfoPtr_get_IsJumping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672156);
			PlayerMovement.NativeMethodInfoPtr_set_IsJumping_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672157);
			PlayerMovement.NativeMethodInfoPtr_get_TimeAirborne_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672158);
			PlayerMovement.NativeMethodInfoPtr_set_TimeAirborne_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672159);
			PlayerMovement.NativeMethodInfoPtr_get_TimeGrounded_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672160);
			PlayerMovement.NativeMethodInfoPtr_set_TimeGrounded_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672161);
			PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672162);
			PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672163);
			PlayerMovement.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672164);
			PlayerMovement.NativeMethodInfoPtr_set_IsCrouched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672165);
			PlayerMovement.NativeMethodInfoPtr_get_StandingScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672166);
			PlayerMovement.NativeMethodInfoPtr_set_StandingScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672167);
			PlayerMovement.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672168);
			PlayerMovement.NativeMethodInfoPtr_set_IsRagdolled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672169);
			PlayerMovement.NativeMethodInfoPtr_get_IsSprinting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672170);
			PlayerMovement.NativeMethodInfoPtr_set_IsSprinting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672171);
			PlayerMovement.NativeMethodInfoPtr_get_ForceSprint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672172);
			PlayerMovement.NativeMethodInfoPtr_set_ForceSprint_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672173);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentStaminaReserve_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672174);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentStaminaReserve_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672175);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672176);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672177);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672178);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672179);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672180);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentLadder_Public_set_Void_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672181);
			PlayerMovement.NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672182);
			PlayerMovement.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672183);
			PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672184);
			PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672185);
			PlayerMovement.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672186);
			PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672187);
			PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672188);
			PlayerMovement.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672189);
			PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672190);
			PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672191);
			PlayerMovement.NativeMethodInfoPtr_GetIsGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672192);
			PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672193);
			PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672194);
			PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672195);
			PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672196);
			PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672197);
			PlayerMovement.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672198);
			PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672199);
			PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672200);
			PlayerMovement.NativeMethodInfoPtr_CanStand_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672201);
			PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672202);
			PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672203);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672204);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672205);
			PlayerMovement.NativeMethodInfoPtr_SetPlayerRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672206);
			PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672207);
			PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672208);
			PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672209);
			PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672210);
			PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672211);
			PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672212);
			PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672213);
			PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672214);
			PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672215);
			PlayerMovement.NativeMethodInfoPtr_MountLadder_Public_Void_Ladder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672216);
			PlayerMovement.NativeMethodInfoPtr_DismountLadder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672217);
			PlayerMovement.NativeMethodInfoPtr_LadderMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672218);
			PlayerMovement.NativeMethodInfoPtr_PlayLadderClimbSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672219);
			PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672220);
			PlayerMovement.NativeMethodInfoPtr__Start_b__131_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672222);
			PlayerMovement.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100672223);
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x00164F30 File Offset: 0x00163130
		// (set) Token: 0x06004428 RID: 17448 RVA: 0x00164F6C File Offset: 0x0016316C
		public unsafe bool CanMove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x00164FAC File Offset: 0x001631AC
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x00164FE8 File Offset: 0x001631E8
		public unsafe bool CanJump
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CanJump_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CanJump_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x00165028 File Offset: 0x00163228
		public unsafe Vector3 Movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x00165064 File Offset: 0x00163264
		// (set) Token: 0x0600442D RID: 17453 RVA: 0x001650A0 File Offset: 0x001632A0
		public unsafe bool IsJumping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsJumping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsJumping_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x001650E0 File Offset: 0x001632E0
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x0016511C File Offset: 0x0016331C
		public unsafe float TimeAirborne
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_TimeAirborne_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44937, RefRangeEnd = 44940, XrefRangeStart = 44937, XrefRangeEnd = 44940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_TimeAirborne_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x0016515C File Offset: 0x0016335C
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x00165198 File Offset: 0x00163398
		public unsafe float TimeGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_TimeGrounded_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_TimeGrounded_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x001651D8 File Offset: 0x001633D8
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x00165214 File Offset: 0x00163414
		public unsafe bool IsGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x00165254 File Offset: 0x00163454
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x00165290 File Offset: 0x00163490
		public unsafe bool IsCrouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsCrouched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x001652D0 File Offset: 0x001634D0
		// (set) Token: 0x06004437 RID: 17463 RVA: 0x0016530C File Offset: 0x0016350C
		public unsafe float StandingScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29137, RefRangeEnd = 29138, XrefRangeStart = 29137, XrefRangeEnd = 29138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_StandingScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_StandingScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x0016534C File Offset: 0x0016354C
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x00165388 File Offset: 0x00163588
		public unsafe bool IsRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsRagdolled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x001653C8 File Offset: 0x001635C8
		// (set) Token: 0x0600443B RID: 17467 RVA: 0x00165404 File Offset: 0x00163604
		public unsafe bool IsSprinting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsSprinting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 46699, RefRangeEnd = 46708, XrefRangeStart = 46699, XrefRangeEnd = 46708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsSprinting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00165444 File Offset: 0x00163644
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x00165480 File Offset: 0x00163680
		public unsafe bool ForceSprint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_ForceSprint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_ForceSprint_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x001654C0 File Offset: 0x001636C0
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x001654FC File Offset: 0x001636FC
		public unsafe float CurrentStaminaReserve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentStaminaReserve_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentStaminaReserve_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x0016553C File Offset: 0x0016373C
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x00165578 File Offset: 0x00163778
		public unsafe float CurrentSprintMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x001655B8 File Offset: 0x001637B8
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x001655F8 File Offset: 0x001637F8
		public unsafe LandVehicle CurrentVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x0016563C File Offset: 0x0016383C
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x0016567C File Offset: 0x0016387C
		public unsafe Ladder CurrentLadder
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentLadder_Public_set_Void_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x001656C0 File Offset: 0x001638C0
		public unsafe bool IsOnLadder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163678, XrefRangeEnd = 163682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x001656FC File Offset: 0x001638FC
		public unsafe float MoveSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00165738 File Offset: 0x00163938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163682, XrefRangeEnd = 163687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00165774 File Offset: 0x00163974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163687, XrefRangeEnd = 163717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x001657B0 File Offset: 0x001639B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163717, XrefRangeEnd = 163743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x001657E4 File Offset: 0x001639E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163743, XrefRangeEnd = 163762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00165818 File Offset: 0x00163A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163762, XrefRangeEnd = 163766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x0016584C File Offset: 0x00163A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163840, RefRangeEnd = 163841, XrefRangeStart = 163766, XrefRangeEnd = 163840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00165880 File Offset: 0x00163A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163841, XrefRangeEnd = 163846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x001658B4 File Offset: 0x00163AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163846, XrefRangeEnd = 163855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x001658F0 File Offset: 0x00163AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163861, RefRangeEnd = 163862, XrefRangeStart = 163855, XrefRangeEnd = 163861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_GetIsGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x0016592C File Offset: 0x00163B2C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 163881, RefRangeEnd = 163890, XrefRangeStart = 163862, XrefRangeEnd = 163881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Vector3 position, bool alignFeetToPosition = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignFeetToPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00165978 File Offset: 0x00163B78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163891, RefRangeEnd = 163894, XrefRangeStart = 163890, XrefRangeEnd = 163891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResidualVelocity(Vector3 dir, float force, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x001659D4 File Offset: 0x00163BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163923, RefRangeEnd = 163925, XrefRangeStart = 163894, XrefRangeEnd = 163923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh(bool clearVelocity = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearVelocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00165A14 File Offset: 0x00163C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163941, RefRangeEnd = 163942, XrefRangeStart = 163925, XrefRangeEnd = 163941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHorizontalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00165A48 File Offset: 0x00163C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163958, RefRangeEnd = 163959, XrefRangeStart = 163942, XrefRangeEnd = 163958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerticalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00165A7C File Offset: 0x00163C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163966, RefRangeEnd = 163967, XrefRangeStart = 163959, XrefRangeEnd = 163966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00165AB0 File Offset: 0x00163CB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163978, RefRangeEnd = 163981, XrefRangeStart = 163967, XrefRangeEnd = 163978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00165AF0 File Offset: 0x00163CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163984, RefRangeEnd = 163985, XrefRangeStart = 163981, XrefRangeEnd = 163984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToggleCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00165B24 File Offset: 0x00163D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164002, RefRangeEnd = 164003, XrefRangeStart = 163985, XrefRangeEnd = 164002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_CanStand_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00165B60 File Offset: 0x00163D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164019, RefRangeEnd = 164020, XrefRangeStart = 164003, XrefRangeEnd = 164019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCrouchVignetteEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00165B94 File Offset: 0x00163D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164020, XrefRangeEnd = 164026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00165BC8 File Offset: 0x00163DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164035, RefRangeEnd = 164036, XrefRangeStart = 164026, XrefRangeEnd = 164035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00165C14 File Offset: 0x00163E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164036, XrefRangeEnd = 164041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endRotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00165C70 File Offset: 0x00163E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164041, XrefRangeEnd = 164049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerRotation(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetPlayerRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00165CB0 File Offset: 0x00163EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164049, XrefRangeEnd = 164052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00165CF4 File Offset: 0x00163EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164052, XrefRangeEnd = 164055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00165D38 File Offset: 0x00163F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164077, RefRangeEnd = 164079, XrefRangeStart = 164055, XrefRangeEnd = 164077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00165D88 File Offset: 0x00163F88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164111, RefRangeEnd = 164113, XrefRangeStart = 164079, XrefRangeEnd = 164111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00165DCC File Offset: 0x00163FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164138, RefRangeEnd = 164139, XrefRangeStart = 164113, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00165E00 File Offset: 0x00164000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164140, RefRangeEnd = 164143, XrefRangeStart = 164139, XrefRangeEnd = 164140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeStamina(float change, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00165E4C File Offset: 0x0016404C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164147, RefRangeEnd = 164151, XrefRangeStart = 164143, XrefRangeEnd = 164147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStamina(float value, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00165E98 File Offset: 0x00164098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164157, RefRangeEnd = 164158, XrefRangeStart = 164151, XrefRangeEnd = 164157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00165EDC File Offset: 0x001640DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164164, RefRangeEnd = 164166, XrefRangeStart = 164158, XrefRangeEnd = 164164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00165F20 File Offset: 0x00164120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164191, RefRangeEnd = 164192, XrefRangeStart = 164166, XrefRangeEnd = 164191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MountLadder(Ladder ladder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ladder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_MountLadder_Public_Void_Ladder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00165F64 File Offset: 0x00164164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164205, RefRangeEnd = 164206, XrefRangeStart = 164192, XrefRangeEnd = 164205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DismountLadder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_DismountLadder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x00165F98 File Offset: 0x00164198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164261, RefRangeEnd = 164262, XrefRangeStart = 164206, XrefRangeEnd = 164261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LadderMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LadderMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00165FCC File Offset: 0x001641CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164267, RefRangeEnd = 164268, XrefRangeStart = 164262, XrefRangeEnd = 164267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLadderClimbSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_PlayLadderClimbSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00166000 File Offset: 0x00164200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164268, XrefRangeEnd = 164311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x0016603C File Offset: 0x0016423C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164311, XrefRangeEnd = 164319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__131_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__Start_b__131_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00166070 File Offset: 0x00164270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164319, XrefRangeEnd = 164324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00021277 File Offset: 0x0001F477
		public PlayerMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x001660B0 File Offset: 0x001642B0
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x00021280 File Offset: 0x0001F480
		public unsafe static float DevSprintMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DevSprintMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DevSprintMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x001660CC File Offset: 0x001642CC
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x0002128E File Offset: 0x0001F48E
		public unsafe static float WalkSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x001660E8 File Offset: 0x001642E8
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x0002129C File Offset: 0x0001F49C
		public unsafe static float StaticMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x00166104 File Offset: 0x00164304
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x000212AA File Offset: 0x0001F4AA
		public unsafe static float InputSensitivity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_InputSensitivity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_InputSensitivity, (void*)(&value));
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x00166120 File Offset: 0x00164320
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public unsafe static float InputDeadZone
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_InputDeadZone, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_InputDeadZone, (void*)(&value));
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x0016613C File Offset: 0x0016433C
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x000212C6 File Offset: 0x0001F4C6
		public unsafe static float SlipperyMovementMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x00166158 File Offset: 0x00164358
		// (set) Token: 0x0600447D RID: 17533 RVA: 0x000212D4 File Offset: 0x0001F4D4
		public unsafe static float GroundedThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_GroundedThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_GroundedThreshold, (void*)(&value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x00166174 File Offset: 0x00164374
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x000212E2 File Offset: 0x0001F4E2
		public unsafe static float SlopeThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SlopeThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SlopeThreshold, (void*)(&value));
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x00166190 File Offset: 0x00164390
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x000212F0 File Offset: 0x0001F4F0
		public unsafe static float SlopeForce
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SlopeForce, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SlopeForce, (void*)(&value));
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x001661AC File Offset: 0x001643AC
		// (set) Token: 0x06004483 RID: 17539 RVA: 0x000212FE File Offset: 0x0001F4FE
		public unsafe static float SlopeForceRayLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SlopeForceRayLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SlopeForceRayLength, (void*)(&value));
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06004484 RID: 17540 RVA: 0x001661C8 File Offset: 0x001643C8
		// (set) Token: 0x06004485 RID: 17541 RVA: 0x0002130C File Offset: 0x0001F50C
		public unsafe static float ControllerRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&value));
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x001661E4 File Offset: 0x001643E4
		// (set) Token: 0x06004487 RID: 17543 RVA: 0x0002131A File Offset: 0x0001F51A
		public unsafe static float DefaultCharacterControllerHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DefaultCharacterControllerHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DefaultCharacterControllerHeight, (void*)(&value));
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x00166200 File Offset: 0x00164400
		// (set) Token: 0x06004489 RID: 17545 RVA: 0x00021328 File Offset: 0x0001F528
		public unsafe static float CrouchHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x0016621C File Offset: 0x0016441C
		// (set) Token: 0x0600448B RID: 17547 RVA: 0x00021336 File Offset: 0x0001F536
		public unsafe static float CrouchTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&value));
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x00166238 File Offset: 0x00164438
		// (set) Token: 0x0600448D RID: 17549 RVA: 0x00021344 File Offset: 0x0001F544
		public unsafe static float CrouchSpeedMultipler
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchSpeedMultipler, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchSpeedMultipler, (void*)(&value));
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x00166254 File Offset: 0x00164454
		// (set) Token: 0x0600448F RID: 17551 RVA: 0x00021352 File Offset: 0x0001F552
		public unsafe static float CrouchedVigIntensity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchedVigIntensity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchedVigIntensity, (void*)(&value));
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x00166270 File Offset: 0x00164470
		// (set) Token: 0x06004491 RID: 17553 RVA: 0x00021360 File Offset: 0x0001F560
		public unsafe static float CrouchedVigSmoothness
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchedVigSmoothness, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchedVigSmoothness, (void*)(&value));
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x0016628C File Offset: 0x0016448C
		// (set) Token: 0x06004493 RID: 17555 RVA: 0x0002136E File Offset: 0x0001F56E
		public unsafe static bool SprintingRequiresStamina
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina, (void*)(&value));
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06004494 RID: 17556 RVA: 0x001662A8 File Offset: 0x001644A8
		// (set) Token: 0x06004495 RID: 17557 RVA: 0x0002137C File Offset: 0x0001F57C
		public unsafe static float SprintChangeRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&value));
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x001662C4 File Offset: 0x001644C4
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x0002138A File Offset: 0x0001F58A
		public unsafe static float SprintMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x001662E0 File Offset: 0x001644E0
		// (set) Token: 0x06004499 RID: 17561 RVA: 0x00021398 File Offset: 0x0001F598
		public unsafe static float StaminaDrainRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&value));
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x001662FC File Offset: 0x001644FC
		// (set) Token: 0x0600449B RID: 17563 RVA: 0x000213A6 File Offset: 0x0001F5A6
		public unsafe static float StaminaRestoreRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x00166318 File Offset: 0x00164518
		// (set) Token: 0x0600449D RID: 17565 RVA: 0x000213B4 File Offset: 0x0001F5B4
		public unsafe static float StaminaRestoreDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&value));
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x00166334 File Offset: 0x00164534
		// (set) Token: 0x0600449F RID: 17567 RVA: 0x000213C2 File Offset: 0x0001F5C2
		public unsafe static float StaminaReserveMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&value));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x00166350 File Offset: 0x00164550
		// (set) Token: 0x060044A1 RID: 17569 RVA: 0x000213D0 File Offset: 0x0001F5D0
		public unsafe static float JumpForce
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_JumpForce, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_JumpForce, (void*)(&value));
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x0016636C File Offset: 0x0016456C
		// (set) Token: 0x060044A3 RID: 17571 RVA: 0x000213DE File Offset: 0x0001F5DE
		public unsafe static float JumpMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x00166388 File Offset: 0x00164588
		// (set) Token: 0x060044A5 RID: 17573 RVA: 0x000213EC File Offset: 0x0001F5EC
		public unsafe static float GravityMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_GravityMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_GravityMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x001663A4 File Offset: 0x001645A4
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x000213FA File Offset: 0x0001F5FA
		public unsafe static float BaseGravityMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_BaseGravityMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_BaseGravityMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x001663C0 File Offset: 0x001645C0
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x00021408 File Offset: 0x0001F608
		public unsafe static float VerticalLadderSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_VerticalLadderSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_VerticalLadderSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x001663DC File Offset: 0x001645DC
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x00021416 File Offset: 0x0001F616
		public unsafe static float LateralLadderSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_LateralLadderSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_LateralLadderSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x001663F8 File Offset: 0x001645F8
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x00021424 File Offset: 0x0001F624
		public unsafe static float LadderTopBuffer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_LadderTopBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_LadderTopBuffer, (void*)(&value));
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x00166414 File Offset: 0x00164614
		// (set) Token: 0x060044AF RID: 17583 RVA: 0x00021432 File Offset: 0x0001F632
		public unsafe static float LadderPitchAdjustment
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_LadderPitchAdjustment, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_LadderPitchAdjustment, (void*)(&value));
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x00166430 File Offset: 0x00164630
		// (set) Token: 0x060044B1 RID: 17585 RVA: 0x00021440 File Offset: 0x0001F640
		public unsafe static float DismountForce
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DismountForce, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DismountForce, (void*)(&value));
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x0016644C File Offset: 0x0016464C
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x0002144E File Offset: 0x0001F64E
		public unsafe static float DismountForceDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DismountForceDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DismountForceDuration, (void*)(&value));
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x00166468 File Offset: 0x00164668
		// (set) Token: 0x060044B5 RID: 17589 RVA: 0x0002145C File Offset: 0x0001F65C
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x00166498 File Offset: 0x00164698
		// (set) Token: 0x060044B7 RID: 17591 RVA: 0x0002147B File Offset: 0x0001F67B
		public unsafe CharacterController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x001664C8 File Offset: 0x001646C8
		// (set) Token: 0x060044B9 RID: 17593 RVA: 0x0002149A File Offset: 0x0001F69A
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x001664F0 File Offset: 0x001646F0
		// (set) Token: 0x060044BB RID: 17595 RVA: 0x000214B5 File Offset: 0x0001F6B5
		public unsafe bool _CanJump_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CanJump_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CanJump_k__BackingField)) = value;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x00166518 File Offset: 0x00164718
		// (set) Token: 0x060044BD RID: 17597 RVA: 0x000214D0 File Offset: 0x0001F6D0
		public unsafe bool _IsJumping_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsJumping_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsJumping_k__BackingField)) = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x00166540 File Offset: 0x00164740
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x000214EB File Offset: 0x0001F6EB
		public unsafe float _TimeAirborne_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__TimeAirborne_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__TimeAirborne_k__BackingField)) = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x00166568 File Offset: 0x00164768
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x00021506 File Offset: 0x0001F706
		public unsafe float _TimeGrounded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__TimeGrounded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__TimeGrounded_k__BackingField)) = value;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x00166590 File Offset: 0x00164790
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x00021521 File Offset: 0x0001F721
		public unsafe bool _IsGrounded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField)) = value;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x001665B8 File Offset: 0x001647B8
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x0002153C File Offset: 0x0001F73C
		public unsafe bool _IsCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x001665E0 File Offset: 0x001647E0
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x00021557 File Offset: 0x0001F757
		public unsafe float _StandingScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__StandingScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__StandingScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x00166608 File Offset: 0x00164808
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x00021572 File Offset: 0x0001F772
		public unsafe bool _IsRagdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x00166630 File Offset: 0x00164830
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x0002158D File Offset: 0x0001F78D
		public unsafe bool _IsSprinting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsSprinting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsSprinting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x00166658 File Offset: 0x00164858
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x000215A8 File Offset: 0x0001F7A8
		public unsafe bool _ForceSprint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__ForceSprint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__ForceSprint_k__BackingField)) = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x00166680 File Offset: 0x00164880
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x000215C3 File Offset: 0x0001F7C3
		public unsafe float _CurrentStaminaReserve_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentStaminaReserve_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentStaminaReserve_k__BackingField)) = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x001666A8 File Offset: 0x001648A8
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x000215DE File Offset: 0x0001F7DE
		public unsafe float _CurrentSprintMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x001666D0 File Offset: 0x001648D0
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x000215F9 File Offset: 0x0001F7F9
		public unsafe LandVehicle _CurrentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x00166700 File Offset: 0x00164900
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x00021618 File Offset: 0x0001F818
		public unsafe Ladder _CurrentLadder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ladder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentLadder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00166730 File Offset: 0x00164930
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x00021637 File Offset: 0x0001F837
		public unsafe FloatStack MoveSpeedMultiplierStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplierStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplierStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x00166760 File Offset: 0x00164960
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x00021656 File Offset: 0x0001F856
		public unsafe Action<float> onStaminaReserveChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x00166790 File Offset: 0x00164990
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x00021675 File Offset: 0x0001F875
		public unsafe Action onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x001667C0 File Offset: 0x001649C0
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x00021694 File Offset: 0x0001F894
		public unsafe Action onLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x001667F0 File Offset: 0x001649F0
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x000216B3 File Offset: 0x0001F8B3
		public unsafe Action onCrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x00166820 File Offset: 0x00164A20
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x000216D2 File Offset: 0x0001F8D2
		public unsafe Action onUncrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x00166850 File Offset: 0x00164A50
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x000216F1 File Offset: 0x0001F8F1
		public unsafe bool _canMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__canMove)) = value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00166878 File Offset: 0x00164A78
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0002170C File Offset: 0x0001F90C
		public unsafe Vector3 movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement)) = value;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x001668A0 File Offset: 0x00164AA0
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x00021727 File Offset: 0x0001F927
		public unsafe Vector3 lastFrameMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement)) = value;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x001668C8 File Offset: 0x00164AC8
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x00021742 File Offset: 0x0001F942
		public unsafe float movementY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY)) = value;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x001668F0 File Offset: 0x00164AF0
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x0002175D File Offset: 0x0001F95D
		public unsafe float timeOnLadderDismount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeOnLadderDismount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeOnLadderDismount)) = value;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x00166918 File Offset: 0x00164B18
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x00021778 File Offset: 0x0001F978
		public unsafe Vector3 ladderDismountDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_ladderDismountDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_ladderDismountDir)) = value;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x00166940 File Offset: 0x00164B40
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x00021793 File Offset: 0x0001F993
		public unsafe float horizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis)) = value;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x00166968 File Offset: 0x00164B68
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x000217AE File Offset: 0x0001F9AE
		public unsafe float verticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis)) = value;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00166990 File Offset: 0x00164B90
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x000217C9 File Offset: 0x0001F9C9
		public unsafe Dictionary<int, MotionEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MotionEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x001669C0 File Offset: 0x00164BC0
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x000217E8 File Offset: 0x0001F9E8
		public unsafe List<int> movementEventKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEventKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEventKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x001669F0 File Offset: 0x00164BF0
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x00021807 File Offset: 0x0001FA07
		public unsafe float timeSinceStaminaDrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain)) = value;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x00166A18 File Offset: 0x00164C18
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x00021822 File Offset: 0x0001FA22
		public unsafe bool sprintActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive)) = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x00166A40 File Offset: 0x00164C40
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x0002183D File Offset: 0x0001FA3D
		public unsafe bool sprintReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased)) = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x00166A68 File Offset: 0x00164C68
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x00021858 File Offset: 0x0001FA58
		public unsafe List<string> sprintBlockers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x00166A98 File Offset: 0x00164C98
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x00021877 File Offset: 0x0001FA77
		public unsafe Vector3 residualVelocityDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection)) = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x00166AC0 File Offset: 0x00164CC0
		// (set) Token: 0x06004501 RID: 17665 RVA: 0x00021892 File Offset: 0x0001FA92
		public unsafe float residualVelocityForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce)) = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x00166AE8 File Offset: 0x00164CE8
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x000218AD File Offset: 0x0001FAAD
		public unsafe float residualVelocityDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration)) = value;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x00166B10 File Offset: 0x00164D10
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x000218C8 File Offset: 0x0001FAC8
		public unsafe float residualVelocityTimeRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining)) = value;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x00166B38 File Offset: 0x00164D38
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x000218E3 File Offset: 0x0001FAE3
		public unsafe bool teleport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport)) = value;
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x00166B60 File Offset: 0x00164D60
		// (set) Token: 0x06004509 RID: 17673 RVA: 0x000218FE File Offset: 0x0001FAFE
		public unsafe Vector3 teleportPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition)) = value;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x00166B88 File Offset: 0x00164D88
		// (set) Token: 0x0600450B RID: 17675 RVA: 0x00021919 File Offset: 0x0001FB19
		public unsafe float playerLadderYPosOnLastClimbSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerLadderYPosOnLastClimbSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerLadderYPosOnLastClimbSound)) = value;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x00166BB0 File Offset: 0x00164DB0
		// (set) Token: 0x0600450D RID: 17677 RVA: 0x00021934 File Offset: 0x0001FB34
		public unsafe float _slope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__slope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__slope)) = value;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x00166BD8 File Offset: 0x00164DD8
		// (set) Token: 0x0600450F RID: 17679 RVA: 0x0002194F File Offset: 0x0001FB4F
		public unsafe Coroutine playerRotCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_DevSprintMultiplier;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr_StaticMoveSpeedMultiplier;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_InputSensitivity;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeFieldInfoPtr_InputDeadZone;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyMovementMultiplier;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeFieldInfoPtr_GroundedThreshold;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeFieldInfoPtr_SlopeThreshold;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeFieldInfoPtr_SlopeForce;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeFieldInfoPtr_SlopeForceRayLength;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr_ControllerRadius;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCharacterControllerHeight;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr_CrouchHeightMultiplier;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeFieldInfoPtr_CrouchTime;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeFieldInfoPtr_CrouchSpeedMultipler;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeFieldInfoPtr_CrouchedVigIntensity;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr_CrouchedVigSmoothness;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeFieldInfoPtr_SprintingRequiresStamina;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeFieldInfoPtr_SprintChangeRate;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeFieldInfoPtr_SprintMultiplier;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr_StaminaDrainRate;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreRate;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreDelay;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeFieldInfoPtr_StaminaReserveMax;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeFieldInfoPtr_JumpMultiplier;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeFieldInfoPtr_GravityMultiplier;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr_BaseGravityMultiplier;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeFieldInfoPtr_VerticalLadderSpeedMultiplier;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeFieldInfoPtr_LateralLadderSpeedMultiplier;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeFieldInfoPtr_LadderTopBuffer;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeFieldInfoPtr_LadderPitchAdjustment;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeFieldInfoPtr_DismountForce;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeFieldInfoPtr_DismountForceDuration;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeFieldInfoPtr__CanJump_k__BackingField;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeFieldInfoPtr__IsJumping_k__BackingField;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeFieldInfoPtr__TimeAirborne_k__BackingField;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeFieldInfoPtr__TimeGrounded_k__BackingField;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeFieldInfoPtr__IsGrounded_k__BackingField;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeFieldInfoPtr__IsCrouched_k__BackingField;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeFieldInfoPtr__StandingScale_k__BackingField;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeFieldInfoPtr__IsRagdolled_k__BackingField;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeFieldInfoPtr__IsSprinting_k__BackingField;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeFieldInfoPtr__ForceSprint_k__BackingField;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStaminaReserve_k__BackingField;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeFieldInfoPtr__CurrentVehicle_k__BackingField;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLadder_k__BackingField;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedMultiplierStack;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeFieldInfoPtr_onStaminaReserveChanged;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeFieldInfoPtr_onLand;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeFieldInfoPtr_onCrouch;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeFieldInfoPtr_onUncrouch;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeFieldInfoPtr__canMove;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameMovement;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeFieldInfoPtr_movementY;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLadderDismount;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeFieldInfoPtr_ladderDismountDir;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAxis;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeFieldInfoPtr_verticalAxis;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeFieldInfoPtr_movementEventKeys;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStaminaDrain;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeFieldInfoPtr_sprintActive;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_sprintReleased;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_sprintBlockers;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDirection;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityForce;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDuration;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityTimeRemaining;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_teleport;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_teleportPosition;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeFieldInfoPtr_playerLadderYPosOnLastClimbSound;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr__slope;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeFieldInfoPtr_playerRotCoroutine;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeMethodInfoPtr_get_CanJump_Public_get_Boolean_0;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr_set_CanJump_Public_set_Void_Boolean_0;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0;

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeMethodInfoPtr_get_IsJumping_Public_get_Boolean_0;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeMethodInfoPtr_set_IsJumping_Private_set_Void_Boolean_0;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeAirborne_Public_get_Single_0;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeAirborne_Private_set_Void_Single_0;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeGrounded_Public_get_Single_0;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeGrounded_Private_set_Void_Single_0;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCrouched_Private_set_Void_Boolean_0;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeMethodInfoPtr_get_StandingScale_Public_get_Single_0;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeMethodInfoPtr_set_StandingScale_Private_set_Void_Single_0;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRagdolled_Private_set_Void_Boolean_0;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSprinting_Public_get_Boolean_0;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSprinting_Private_set_Void_Boolean_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceSprint_Public_get_Boolean_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_set_ForceSprint_Public_set_Void_Boolean_0;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStaminaReserve_Public_get_Single_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStaminaReserve_Private_set_Void_Single_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSprintMultiplier_Private_set_Void_Single_0;

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0;

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLadder_Public_get_Ladder_0;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLadder_Public_set_Void_Ladder_0;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnLadder_Public_get_Boolean_0;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeMethodInfoPtr_ClampMovement_Private_Void_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceAngle_Private_Single_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_GetIsGrounded_Private_Boolean_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Vector3_Boolean_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_Boolean_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHorizontalAxis_Private_Void_0;

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerticalAxis_Private_Void_0;

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeMethodInfoPtr_CanStand_Private_Boolean_0;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerRotation_Public_Void_Quaternion_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0;

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr_MountLadder_Public_Void_Ladder_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_DismountLadder_Public_Void_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_LadderMove_Private_Void_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_PlayLadderClimbSound_Private_Void_0;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__131_0_Private_Void_0;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A5F RID: 2655
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<<Jump>g__JumpRoutine|144_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E08A RID: 57482 RVA: 0x0037335C File Offset: 0x0037155C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique()
			{
				Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<<Jump>g__JumpRoutine|144_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, "<>1__state");
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, "<>2__current");
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, "<>4__this");
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr__savedSlopeLimit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, "<savedSlopeLimit>5__2");
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672224);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672225);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672226);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672227);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672228);
				PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr, 100672229);
			}

			// Token: 0x0600E08B RID: 57483 RVA: 0x00373450 File Offset: 0x00371650
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E08C RID: 57484 RVA: 0x00373498 File Offset: 0x00371698
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E08D RID: 57485 RVA: 0x003734CC File Offset: 0x003716CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163636, XrefRangeEnd = 163655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700445A RID: 17498
			// (get) Token: 0x0600E08E RID: 57486 RVA: 0x00373508 File Offset: 0x00371708
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E08F RID: 57487 RVA: 0x00373548 File Offset: 0x00371748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163655, XrefRangeEnd = 163660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700445B RID: 17499
			// (get) Token: 0x0600E090 RID: 57488 RVA: 0x0037357C File Offset: 0x0037177C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E091 RID: 57489 RVA: 0x00069CDD File Offset: 0x00067EDD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004456 RID: 17494
			// (get) Token: 0x0600E092 RID: 57490 RVA: 0x003735BC File Offset: 0x003717BC
			// (set) Token: 0x0600E093 RID: 57491 RVA: 0x00069CE6 File Offset: 0x00067EE6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004457 RID: 17495
			// (get) Token: 0x0600E094 RID: 57492 RVA: 0x003735E4 File Offset: 0x003717E4
			// (set) Token: 0x0600E095 RID: 57493 RVA: 0x00069D01 File Offset: 0x00067F01
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004458 RID: 17496
			// (get) Token: 0x0600E096 RID: 57494 RVA: 0x00373614 File Offset: 0x00371814
			// (set) Token: 0x0600E097 RID: 57495 RVA: 0x00069D20 File Offset: 0x00067F20
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004459 RID: 17497
			// (get) Token: 0x0600E098 RID: 57496 RVA: 0x00373644 File Offset: 0x00371844
			// (set) Token: 0x0600E099 RID: 57497 RVA: 0x00069D3F File Offset: 0x00067F3F
			public unsafe float _savedSlopeLimit_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr__savedSlopeLimit_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlSiObObUnique.NativeFieldInfoPtr__savedSlopeLimit_5__2)) = value;
				}
			}

			// Token: 0x040098D5 RID: 39125
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040098D6 RID: 39126
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040098D7 RID: 39127
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098D8 RID: 39128
			private static readonly IntPtr NativeFieldInfoPtr__savedSlopeLimit_5__2;

			// Token: 0x040098D9 RID: 39129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098DA RID: 39130
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098DB RID: 39131
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040098DC RID: 39132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040098DD RID: 39133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098DE RID: 39134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A60 RID: 2656
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<LerpPlayerRotation_Process>d__152")]
		public sealed class _LerpPlayerRotation_Process_d__152 : Il2CppSystem.Object
		{
			// Token: 0x0600E09A RID: 57498 RVA: 0x0037366C File Offset: 0x0037186C
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpPlayerRotation_Process_d__152()
			{
				Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<LerpPlayerRotation_Process>d__152");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "<>1__state");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "<>2__current");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "<>4__this");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_endRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "endRotation");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "lerpTime");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "<startRot>5__2");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, "<i>5__3");
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672230);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672231);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672232);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672233);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672234);
				PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr, 100672235);
			}

			// Token: 0x0600E09B RID: 57499 RVA: 0x0037379C File Offset: 0x0037199C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpPlayerRotation_Process_d__152(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__152>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E09C RID: 57500 RVA: 0x003737E4 File Offset: 0x003719E4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E09D RID: 57501 RVA: 0x00373818 File Offset: 0x00371A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163660, XrefRangeEnd = 163673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004463 RID: 17507
			// (get) Token: 0x0600E09E RID: 57502 RVA: 0x00373854 File Offset: 0x00371A54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E09F RID: 57503 RVA: 0x00373894 File Offset: 0x00371A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163673, XrefRangeEnd = 163678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004464 RID: 17508
			// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x003738C8 File Offset: 0x00371AC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0A1 RID: 57505 RVA: 0x00069D5A File Offset: 0x00067F5A
			public _LerpPlayerRotation_Process_d__152(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445C RID: 17500
			// (get) Token: 0x0600E0A2 RID: 57506 RVA: 0x00373908 File Offset: 0x00371B08
			// (set) Token: 0x0600E0A3 RID: 57507 RVA: 0x00069D63 File Offset: 0x00067F63
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700445D RID: 17501
			// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x00373930 File Offset: 0x00371B30
			// (set) Token: 0x0600E0A5 RID: 57509 RVA: 0x00069D7E File Offset: 0x00067F7E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445E RID: 17502
			// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x00373960 File Offset: 0x00371B60
			// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x00069D9D File Offset: 0x00067F9D
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445F RID: 17503
			// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x00373990 File Offset: 0x00371B90
			// (set) Token: 0x0600E0A9 RID: 57513 RVA: 0x00069DBC File Offset: 0x00067FBC
			public unsafe Quaternion endRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_endRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_endRotation)) = value;
				}
			}

			// Token: 0x17004460 RID: 17504
			// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x003739B8 File Offset: 0x00371BB8
			// (set) Token: 0x0600E0AB RID: 57515 RVA: 0x00069DD7 File Offset: 0x00067FD7
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004461 RID: 17505
			// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x003739E0 File Offset: 0x00371BE0
			// (set) Token: 0x0600E0AD RID: 57517 RVA: 0x00069DF2 File Offset: 0x00067FF2
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17004462 RID: 17506
			// (get) Token: 0x0600E0AE RID: 57518 RVA: 0x00373A08 File Offset: 0x00371C08
			// (set) Token: 0x0600E0AF RID: 57519 RVA: 0x00069E0D File Offset: 0x0006800D
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__152.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040098DF RID: 39135
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040098E0 RID: 39136
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040098E1 RID: 39137
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098E2 RID: 39138
			private static readonly IntPtr NativeFieldInfoPtr_endRotation;

			// Token: 0x040098E3 RID: 39139
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040098E4 RID: 39140
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x040098E5 RID: 39141
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040098E6 RID: 39142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098E7 RID: 39143
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098E8 RID: 39144
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040098E9 RID: 39145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040098EA RID: 39146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098EB RID: 39147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
