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
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Experimental;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x0200012C RID: 300
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x06001CDE RID: 7390 RVA: 0x000DADAC File Offset: 0x000D8FAC
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard()
		{
			Il2CppClassPointerStore<Skateboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard>.NativeClassPtr);
			Skateboard.NativeFieldInfoPtr_JumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpCooldown");
			Skateboard.NativeFieldInfoPtr_JumpForceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceMin");
			Skateboard.NativeFieldInfoPtr_JumpForceBuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceBuildTime");
			Skateboard.NativeFieldInfoPtr_PushCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushCooldown");
			Skateboard.NativeFieldInfoPtr_PushStaminaConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushStaminaConsumption");
			Skateboard.NativeFieldInfoPtr_PitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PitchLimit");
			Skateboard.NativeFieldInfoPtr_RollLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RollLimit");
			Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CurrentSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<CurrentSteerInput>k__BackingField");
			Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr__Rider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<Rider>k__BackingField");
			Skateboard.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Rb");
			Skateboard.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CoM");
			Skateboard.NativeFieldInfoPtr_HoverPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverPoints");
			Skateboard.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxlePosition");
			Skateboard.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxlePosition");
			Skateboard.NativeFieldInfoPtr_PlayerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PlayerContainer");
			Skateboard.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Animation");
			Skateboard.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "VelocityCalculator");
			Skateboard.NativeFieldInfoPtr_Accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Accelerometer");
			Skateboard.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Equippable");
			Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "IKAlignmentsContainer");
			Skateboard.NativeFieldInfoPtr__defaultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "_defaultData");
			Skateboard.NativeFieldInfoPtr__rainOverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "_rainOverrideData");
			Skateboard.NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForce");
			Skateboard.NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnChangeRate");
			Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnReturnToRestRate");
			Skateboard.NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnSpeedBoost");
			Skateboard.NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForceMap");
			Skateboard.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Gravity");
			Skateboard.NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "BrakeForce");
			Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "ReverseTopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundDetectionMask");
			Skateboard.NativeFieldInfoPtr_MainColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "MainColliders");
			Skateboard.NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RotationClampForce");
			Skateboard.NativeFieldInfoPtr_SlowOnTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "SlowOnTerrain");
			Skateboard.NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrictionEnabled");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionCurve");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionMultiplier");
			Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LateralFrictionForceMultiplier");
			Skateboard.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForce");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Min");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Max");
			Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardForceCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardBoost");
			Skateboard.NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverForce");
			Skateboard.NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverRayLength");
			Skateboard.NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverHeight");
			Skateboard.NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_P");
			Skateboard.NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_I");
			Skateboard.NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_D");
			Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplier");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplierMap");
			Skateboard.NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceDuration");
			Skateboard.NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushDelay");
			Skateboard.NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceCurve");
			Skateboard.NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementEnabled");
			Skateboard.NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementForce");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionDuration");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionCurve");
			Skateboard.NativeFieldInfoPtr_OnPushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnPushStart");
			Skateboard.NativeFieldInfoPtr_OnJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnJump");
			Skateboard.NativeFieldInfoPtr_OnLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnLand");
			Skateboard.NativeFieldInfoPtr_horizontalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "horizontalInput");
			Skateboard.NativeFieldInfoPtr_jumpReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpReleased");
			Skateboard.NativeFieldInfoPtr_timeSinceLastJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSinceLastJump");
			Skateboard.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeGrounded");
			Skateboard.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeAirborne");
			Skateboard.NativeFieldInfoPtr_jumpHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpHeldTime");
			Skateboard.NativeFieldInfoPtr_frontAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "frontAxleForce");
			Skateboard.NativeFieldInfoPtr_rearAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "rearAxleForce");
			Skateboard.NativeFieldInfoPtr_jumpForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpForwardForce");
			Skateboard.NativeFieldInfoPtr_hoverPIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "hoverPIDs");
			Skateboard.NativeFieldInfoPtr_pushQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "pushQueued");
			Skateboard.NativeFieldInfoPtr_isPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "isPushing");
			Skateboard.NativeFieldInfoPtr_thisFramePushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "thisFramePushForce");
			Skateboard.NativeFieldInfoPtr_timeSincePushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSincePushStart");
			Skateboard.NativeFieldInfoPtr_braking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "braking");
			Skateboard.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "_settings");
			Skateboard.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<ScheduleOne.Core.Weather.IWeatherEntity.WeatherVolume>k__BackingField");
			Skateboard.NativeFieldInfoPtr__IsUnderCover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<IsUnderCover>k__BackingField");
			Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "syncVar___<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667127);
			Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667128);
			Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667129);
			Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667130);
			Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667131);
			Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667132);
			Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667133);
			Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667134);
			Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667135);
			Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667136);
			Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667137);
			Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667138);
			Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667139);
			Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667140);
			Skateboard.NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667141);
			Skateboard.NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667142);
			Skateboard.NativeMethodInfoPtr_get_CurentSettings_Public_get_SkateboardSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667143);
			Skateboard.NativeMethodInfoPtr_get_DefaultSettings_Public_get_SkateboardSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667144);
			Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667145);
			Skateboard.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667146);
			Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667147);
			Skateboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667148);
			Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667149);
			Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667150);
			Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667151);
			Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667152);
			Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667153);
			Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667154);
			Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667155);
			Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667156);
			Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667157);
			Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667158);
			Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667159);
			Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667160);
			Skateboard.NativeMethodInfoPtr_Push_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667161);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667162);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667163);
			Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667164);
			Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667165);
			Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667166);
			Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667167);
			Skateboard.NativeMethodInfoPtr_IsOnTerrain_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667168);
			Skateboard.NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667169);
			Skateboard.NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667170);
			Skateboard.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667171);
			Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667172);
			Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667173);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667174);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667175);
			Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667176);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667177);
			Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667178);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667179);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667180);
			Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667181);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667182);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667183);
			Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667184);
			Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667185);
			Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667186);
			Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667187);
			Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667188);
			Skateboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667189);
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000DB994 File Offset: 0x000D9B94
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x000DB9D0 File Offset: 0x000D9BD0
		public unsafe float CurrentSteerInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000DBA10 File Offset: 0x000D9C10
		public unsafe bool IsPushing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000DBA4C File Offset: 0x000D9C4C
		public unsafe float TimeSincePushStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000DBA88 File Offset: 0x000D9C88
		public unsafe bool isGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000DBAC4 File Offset: 0x000D9CC4
		public unsafe float AirTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x000DBB00 File Offset: 0x000D9D00
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x000DBB3C File Offset: 0x000D9D3C
		public unsafe float JumpBuildAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75486, RefRangeEnd = 75489, XrefRangeStart = 75486, XrefRangeEnd = 75489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103981, XrefRangeEnd = 103993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x000DBB7C File Offset: 0x000D9D7C
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x000DBBBC File Offset: 0x000D9DBC
		public unsafe Player Rider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103993, XrefRangeEnd = 103994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x000DBC00 File Offset: 0x000D9E00
		public unsafe float TopSpeed_Ms
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 103994, RefRangeEnd = 103995, XrefRangeStart = 103994, XrefRangeEnd = 103994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000DBC3C File Offset: 0x000D9E3C
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x000DBC74 File Offset: 0x000D9E74
		public unsafe virtual string WeatherVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103995, XrefRangeEnd = 103996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000DBCB8 File Offset: 0x000D9EB8
		public unsafe virtual Transform Transform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103996, XrefRangeEnd = 104001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000DBCF8 File Offset: 0x000D9EF8
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x000DBD34 File Offset: 0x000D9F34
		public unsafe virtual bool IsUnderCover
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000DBD74 File Offset: 0x000D9F74
		public unsafe SkateboardSettings CurentSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_CurentSettings_Public_get_SkateboardSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000DBDB4 File Offset: 0x000D9FB4
		public unsafe SkateboardSettings DefaultSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 104001, RefRangeEnd = 104002, XrefRangeStart = 104001, XrefRangeEnd = 104001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_DefaultSettings_Public_get_SkateboardSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000DBDF4 File Offset: 0x000D9FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104002, XrefRangeEnd = 104003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000DBE30 File Offset: 0x000DA030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104003, XrefRangeEnd = 104004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000DBE64 File Offset: 0x000DA064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104004, XrefRangeEnd = 104015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000DBEA0 File Offset: 0x000DA0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104015, XrefRangeEnd = 104018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000DBED4 File Offset: 0x000DA0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104085, RefRangeEnd = 104086, XrefRangeStart = 104018, XrefRangeEnd = 104085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000DBF08 File Offset: 0x000DA108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104086, XrefRangeEnd = 104101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000DBF3C File Offset: 0x000DA13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104101, XrefRangeEnd = 104103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000DBF70 File Offset: 0x000DA170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104151, RefRangeEnd = 104152, XrefRangeStart = 104103, XrefRangeEnd = 104151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000DBFA4 File Offset: 0x000DA1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104179, RefRangeEnd = 104180, XrefRangeStart = 104152, XrefRangeEnd = 104179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLateralFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000DBFD8 File Offset: 0x000DA1D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104225, RefRangeEnd = 104226, XrefRangeStart = 104180, XrefRangeEnd = 104225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000DC00C File Offset: 0x000DA20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104226, XrefRangeEnd = 104235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGravity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000DC040 File Offset: 0x000DA240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104237, RefRangeEnd = 104238, XrefRangeStart = 104235, XrefRangeEnd = 104237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000DC074 File Offset: 0x000DA274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104264, RefRangeEnd = 104265, XrefRangeStart = 104238, XrefRangeEnd = 104264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000DC0A8 File Offset: 0x000DA2A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104298, RefRangeEnd = 104300, XrefRangeStart = 104265, XrefRangeEnd = 104298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJump(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000DC0E8 File Offset: 0x000DA2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104322, RefRangeEnd = 104324, XrefRangeStart = 104300, XrefRangeEnd = 104322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveJump(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000DC128 File Offset: 0x000DA328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104324, XrefRangeEnd = 104335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000DC15C File Offset: 0x000DA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104335, XrefRangeEnd = 104343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Push_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000DC190 File Offset: 0x000DA390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104344, RefRangeEnd = 104345, XrefRangeStart = 104343, XrefRangeEnd = 104344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000DC1CC File Offset: 0x000DA3CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 104364, RefRangeEnd = 104369, XrefRangeStart = 104345, XrefRangeEnd = 104364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000DC218 File Offset: 0x000DA418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104371, RefRangeEnd = 104372, XrefRangeStart = 104369, XrefRangeEnd = 104371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000DC258 File Offset: 0x000DA458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104403, RefRangeEnd = 104404, XrefRangeStart = 104372, XrefRangeEnd = 104403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000DC28C File Offset: 0x000DA48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104411, RefRangeEnd = 104413, XrefRangeStart = 104404, XrefRangeEnd = 104411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPlayerScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000DC2C0 File Offset: 0x000DA4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104413, XrefRangeEnd = 104420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceSmoothness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000DC2FC File Offset: 0x000DA4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104427, RefRangeEnd = 104428, XrefRangeStart = 104420, XrefRangeEnd = 104427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnTerrain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsOnTerrain_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000DC338 File Offset: 0x000DA538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104428, XrefRangeEnd = 104432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnWeatherChange(WeatherConditions newConditions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newConditions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000DC37C File Offset: 0x000DA57C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateWeatherEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000DC3B0 File Offset: 0x000DA5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104432, XrefRangeEnd = 104433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000DC3E4 File Offset: 0x000DA5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104433, XrefRangeEnd = 104441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000DC420 File Offset: 0x000DA620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104441, XrefRangeEnd = 104446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000DC460 File Offset: 0x000DA660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104446, XrefRangeEnd = 104482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000DC49C File Offset: 0x000DA69C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000DC4D8 File Offset: 0x000DA6D8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000DC514 File Offset: 0x000DA714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000DC554 File Offset: 0x000DA754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104482, XrefRangeEnd = 104489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000DC594 File Offset: 0x000DA794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104489, XrefRangeEnd = 104499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000DC5F8 File Offset: 0x000DA7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104499, XrefRangeEnd = 104511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x000DC638 File Offset: 0x000DA838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104322, RefRangeEnd = 104324, XrefRangeStart = 104322, XrefRangeEnd = 104324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000DC678 File Offset: 0x000DA878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104511, XrefRangeEnd = 104516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000DC6DC File Offset: 0x000DA8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104516, XrefRangeEnd = 104526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000DC71C File Offset: 0x000DA91C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104530, RefRangeEnd = 104533, XrefRangeStart = 104526, XrefRangeEnd = 104530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000DC75C File Offset: 0x000DA95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104533, XrefRangeEnd = 104537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000DC7AC File Offset: 0x000DA9AC
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000DC7E8 File Offset: 0x000DA9E8
		public unsafe float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75486, RefRangeEnd = 75489, XrefRangeStart = 75486, XrefRangeEnd = 75489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104537, XrefRangeEnd = 104545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000DC834 File Offset: 0x000DAA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104545, XrefRangeEnd = 104546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Skating_Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x000DC8A8 File Offset: 0x000DAAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104580, RefRangeEnd = 104581, XrefRangeStart = 104546, XrefRangeEnd = 104580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0000F796 File Offset: 0x0000D996
		public Skateboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000DC8DC File Offset: 0x000DAADC
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000F79F File Offset: 0x0000D99F
		public unsafe static float JumpCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000DC8F8 File Offset: 0x000DAAF8
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000F7AD File Offset: 0x0000D9AD
		public unsafe static float JumpForceMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000DC914 File Offset: 0x000DAB14
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000F7BB File Offset: 0x0000D9BB
		public unsafe static float JumpForceBuildTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000DC930 File Offset: 0x000DAB30
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000F7C9 File Offset: 0x0000D9C9
		public unsafe static float PushCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000DC94C File Offset: 0x000DAB4C
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000F7D7 File Offset: 0x0000D9D7
		public unsafe static float PushStaminaConsumption
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000DC968 File Offset: 0x000DAB68
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000F7E5 File Offset: 0x0000D9E5
		public unsafe static float PitchLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000DC984 File Offset: 0x000DAB84
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000F7F3 File Offset: 0x0000D9F3
		public unsafe static float RollLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000DC9A0 File Offset: 0x000DABA0
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000F801 File Offset: 0x0000DA01
		public unsafe float CurrentSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000DC9C8 File Offset: 0x000DABC8
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000F81C File Offset: 0x0000DA1C
		public unsafe float _CurrentSteerInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x000DC9F0 File Offset: 0x000DABF0
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000F837 File Offset: 0x0000DA37
		public unsafe float _JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x000DCA18 File Offset: 0x000DAC18
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000F852 File Offset: 0x0000DA52
		public unsafe Player _Rider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000DCA48 File Offset: 0x000DAC48
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000F871 File Offset: 0x0000DA71
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000DCA78 File Offset: 0x000DAC78
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000F890 File Offset: 0x0000DA90
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x000DCAA8 File Offset: 0x000DACA8
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000F8AF File Offset: 0x0000DAAF
		public unsafe Il2CppReferenceArray<Transform> HoverPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x000DCAD8 File Offset: 0x000DACD8
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0000F8CE File Offset: 0x0000DACE
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x000DCB08 File Offset: 0x000DAD08
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0000F8ED File Offset: 0x0000DAED
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000DCB38 File Offset: 0x000DAD38
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000F90C File Offset: 0x0000DB0C
		public unsafe Transform PlayerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x000DCB68 File Offset: 0x000DAD68
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000F92B File Offset: 0x0000DB2B
		public unsafe SkateboardAnimation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x000DCB98 File Offset: 0x000DAD98
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000F94A File Offset: 0x0000DB4A
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x000DCBC8 File Offset: 0x000DADC8
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0000F969 File Offset: 0x0000DB69
		public unsafe AverageAcceleration Accelerometer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x000DCBF8 File Offset: 0x000DADF8
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0000F988 File Offset: 0x0000DB88
		public unsafe Skateboard_Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x000DCC28 File Offset: 0x000DAE28
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0000F9A7 File Offset: 0x0000DBA7
		public unsafe Transform IKAlignmentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x000DCC58 File Offset: 0x000DAE58
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x0000F9C6 File Offset: 0x0000DBC6
		public unsafe SkateboardData _defaultData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__defaultData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__defaultData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x000DCC88 File Offset: 0x000DAE88
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0000F9E5 File Offset: 0x0000DBE5
		public unsafe SkateboardOverrideData _rainOverrideData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__rainOverrideData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardOverrideData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__rainOverrideData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000DCCB8 File Offset: 0x000DAEB8
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0000FA04 File Offset: 0x0000DC04
		public unsafe float TurnForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce)) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000DCCE0 File Offset: 0x000DAEE0
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x0000FA1F File Offset: 0x0000DC1F
		public unsafe float TurnChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000DCD08 File Offset: 0x000DAF08
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x0000FA3A File Offset: 0x0000DC3A
		public unsafe float TurnReturnToRestRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x000DCD30 File Offset: 0x000DAF30
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0000FA55 File Offset: 0x0000DC55
		public unsafe float TurnSpeedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost)) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x000DCD58 File Offset: 0x000DAF58
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0000FA70 File Offset: 0x0000DC70
		public unsafe AnimationCurve TurnForceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x000DCD88 File Offset: 0x000DAF88
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0000FA8F File Offset: 0x0000DC8F
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x000DCDB0 File Offset: 0x000DAFB0
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0000FAAA File Offset: 0x0000DCAA
		public unsafe float BrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce)) = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000DCDD8 File Offset: 0x000DAFD8
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0000FAC5 File Offset: 0x0000DCC5
		public unsafe float ReverseTopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x000DCE00 File Offset: 0x000DB000
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x000DCE28 File Offset: 0x000DB028
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0000FAFB File Offset: 0x0000DCFB
		public unsafe Il2CppReferenceArray<Collider> MainColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000DCE58 File Offset: 0x000DB058
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0000FB1A File Offset: 0x0000DD1A
		public unsafe float RotationClampForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce)) = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x000DCE80 File Offset: 0x000DB080
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0000FB35 File Offset: 0x0000DD35
		public unsafe bool SlowOnTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_SlowOnTerrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_SlowOnTerrain)) = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x000DCEA8 File Offset: 0x000DB0A8
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0000FB50 File Offset: 0x0000DD50
		public unsafe bool FrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled)) = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x000DCED0 File Offset: 0x000DB0D0
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0000FB6B File Offset: 0x0000DD6B
		public unsafe AnimationCurve LongitudinalFrictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x000DCF00 File Offset: 0x000DB100
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0000FB8A File Offset: 0x0000DD8A
		public unsafe float LongitudinalFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x000DCF28 File Offset: 0x000DB128
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0000FBA5 File Offset: 0x0000DDA5
		public unsafe float LateralFrictionForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000DCF50 File Offset: 0x000DB150
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000DCF78 File Offset: 0x000DB178
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0000FBDB File Offset: 0x0000DDDB
		public unsafe float JumpDuration_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x000DCFA0 File Offset: 0x000DB1A0
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000FBF6 File Offset: 0x0000DDF6
		public unsafe float JumpDuration_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max)) = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x000DCFC8 File Offset: 0x000DB1C8
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000FC11 File Offset: 0x0000DE11
		public unsafe AnimationCurve FrontAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000DCFF8 File Offset: 0x000DB1F8
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0000FC30 File Offset: 0x0000DE30
		public unsafe AnimationCurve RearAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000DD028 File Offset: 0x000DB228
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0000FC4F File Offset: 0x0000DE4F
		public unsafe AnimationCurve JumpForwardForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000DD058 File Offset: 0x000DB258
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0000FC6E File Offset: 0x0000DE6E
		public unsafe float JumpForwardBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000DD080 File Offset: 0x000DB280
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0000FC89 File Offset: 0x0000DE89
		public unsafe float HoverForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce)) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x000DD0A8 File Offset: 0x000DB2A8
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public unsafe float HoverRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000DD0D0 File Offset: 0x000DB2D0
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0000FCBF File Offset: 0x0000DEBF
		public unsafe float HoverHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight)) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000DD0F8 File Offset: 0x000DB2F8
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0000FCDA File Offset: 0x0000DEDA
		public unsafe float Hover_P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x000DD120 File Offset: 0x000DB320
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0000FCF5 File Offset: 0x0000DEF5
		public unsafe float Hover_I
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x000DD148 File Offset: 0x000DB348
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x0000FD10 File Offset: 0x0000DF10
		public unsafe float Hover_D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D)) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x000DD170 File Offset: 0x000DB370
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x0000FD2B File Offset: 0x0000DF2B
		public unsafe float TopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000DD198 File Offset: 0x000DB398
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0000FD46 File Offset: 0x0000DF46
		public unsafe float PushForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier)) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000DD1C0 File Offset: 0x000DB3C0
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0000FD61 File Offset: 0x0000DF61
		public unsafe AnimationCurve PushForceMultiplierMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000DD1F0 File Offset: 0x000DB3F0
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0000FD80 File Offset: 0x0000DF80
		public unsafe float PushForceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration)) = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000DD218 File Offset: 0x000DB418
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0000FD9B File Offset: 0x0000DF9B
		public unsafe float PushDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay)) = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x000DD240 File Offset: 0x000DB440
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000FDB6 File Offset: 0x0000DFB6
		public unsafe AnimationCurve PushForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000DD270 File Offset: 0x000DB470
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000FDD5 File Offset: 0x0000DFD5
		public unsafe bool AirMovementEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled)) = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000DD298 File Offset: 0x000DB498
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		public unsafe float AirMovementForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce)) = value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000DD2C0 File Offset: 0x000DB4C0
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000FE0B File Offset: 0x0000E00B
		public unsafe float AirMovementJumpReductionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000DD2E8 File Offset: 0x000DB4E8
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000FE26 File Offset: 0x0000E026
		public unsafe AnimationCurve AirMovementJumpReductionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000DD318 File Offset: 0x000DB518
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000FE45 File Offset: 0x0000E045
		public unsafe UnityEvent OnPushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x000DD348 File Offset: 0x000DB548
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000FE64 File Offset: 0x0000E064
		public unsafe UnityEvent<float> OnJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000DD378 File Offset: 0x000DB578
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0000FE83 File Offset: 0x0000E083
		public unsafe UnityEvent OnLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000DD3A8 File Offset: 0x000DB5A8
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
		public unsafe float horizontalInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput)) = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000DD3D0 File Offset: 0x000DB5D0
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0000FEBD File Offset: 0x0000E0BD
		public unsafe bool jumpReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased)) = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000DD3F8 File Offset: 0x000DB5F8
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public unsafe float timeSinceLastJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump)) = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000DD420 File Offset: 0x000DB620
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0000FEF3 File Offset: 0x0000E0F3
		public unsafe float timeGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x000DD448 File Offset: 0x000DB648
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000FF0E File Offset: 0x0000E10E
		public unsafe float timeAirborne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000DD470 File Offset: 0x000DB670
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000FF29 File Offset: 0x0000E129
		public unsafe float jumpHeldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime)) = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000DD498 File Offset: 0x000DB698
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000FF44 File Offset: 0x0000E144
		public unsafe float frontAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce)) = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x000DD4C0 File Offset: 0x000DB6C0
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000FF5F File Offset: 0x0000E15F
		public unsafe float rearAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce)) = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x000DD4E8 File Offset: 0x000DB6E8
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0000FF7A File Offset: 0x0000E17A
		public unsafe float jumpForwardForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce)) = value;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000DD510 File Offset: 0x000DB710
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0000FF95 File Offset: 0x0000E195
		public unsafe List<PID> hoverPIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000DD540 File Offset: 0x000DB740
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public unsafe bool pushQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued)) = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000DD568 File Offset: 0x000DB768
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0000FFCF File Offset: 0x0000E1CF
		public unsafe bool isPushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing)) = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000DD590 File Offset: 0x000DB790
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000FFEA File Offset: 0x0000E1EA
		public unsafe float thisFramePushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce)) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000DD5B8 File Offset: 0x000DB7B8
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00010005 File Offset: 0x0000E205
		public unsafe float timeSincePushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart)) = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000DD5E0 File Offset: 0x000DB7E0
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00010020 File Offset: 0x0000E220
		public unsafe bool braking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x000DD608 File Offset: 0x000DB808
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0001003B File Offset: 0x0000E23B
		public unsafe SkateboardSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000DD638 File Offset: 0x000DB838
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0001005A File Offset: 0x0000E25A
		public unsafe string _ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x000DD660 File Offset: 0x000DB860
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00010079 File Offset: 0x0000E279
		public unsafe bool _IsUnderCover_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__IsUnderCover_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__IsUnderCover_k__BackingField)) = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000DD688 File Offset: 0x000DB888
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00010094 File Offset: 0x0000E294
		public unsafe SyncVar<float> syncVar____JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000DD6B8 File Offset: 0x000DB8B8
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x000100B3 File Offset: 0x0000E2B3
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000DD6E0 File Offset: 0x000DB8E0
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x000100CE File Offset: 0x0000E2CE
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr_JumpCooldown;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceMin;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceBuildTime;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr_PushCooldown;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_PushStaminaConsumption;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr_PitchLimit;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeFieldInfoPtr_RollLimit;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSpeed_Kmh;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSteerInput_k__BackingField;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr__JumpBuildAmount_k__BackingField;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr__Rider_k__BackingField;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeFieldInfoPtr_HoverPoints;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_PlayerContainer;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeFieldInfoPtr_Accelerometer;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_IKAlignmentsContainer;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr__defaultData;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr__rainOverrideData;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_TurnForce;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_TurnChangeRate;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_TurnForceMap;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_BrakeForce;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_MainColliders;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_RotationClampForce;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_SlowOnTerrain;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_FrictionEnabled;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Min;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Max;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardBoost;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_HoverForce;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_HoverRayLength;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_HoverHeight;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_Hover_P;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeFieldInfoPtr_Hover_I;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_Hover_D;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplier;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr_PushForceDuration;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_PushDelay;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr_PushForceCurve;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementEnabled;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementForce;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_OnPushStart;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_OnJump;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_OnLand;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_horizontalInput;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeFieldInfoPtr_jumpReleased;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastJump;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeldTime;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_frontAxleForce;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr_rearAxleForce;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_jumpForwardForce;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_hoverPIDs;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_pushQueued;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_isPushing;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeFieldInfoPtr_thisFramePushForce;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePushStart;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_braking;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr__IsUnderCover_k__BackingField;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_get_AirTime_Public_get_Single_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_Rider_Public_get_Player_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_get_CurentSettings_Public_get_SkateboardSettings_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_get_SkateboardSettings_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_1;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_1;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInput_Private_Void_1;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_1;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGravity_Private_Void_1;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_CheckGrounded_Private_Void_1;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_CheckJump_Private_Void_1;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_SendJump_Private_Void_Single_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_1;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_1;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_ClampRotation_Private_Void_1;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_IsOnTerrain_Public_Boolean_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000959 RID: 2393
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<<Push>g__Push|131_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D8A1 RID: 55457 RVA: 0x0035D0F4 File Offset: 0x0035B2F4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique()
			{
				Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<<Push>g__Push|131_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>1__state");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>2__current");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>4__this");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<i>5__2");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667190);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667191);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667192);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667193);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667194);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667195);
			}

			// Token: 0x0600D8A2 RID: 55458 RVA: 0x0035D1E8 File Offset: 0x0035B3E8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x0035D230 File Offset: 0x0035B430
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8A4 RID: 55460 RVA: 0x0035D264 File Offset: 0x0035B464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103937, XrefRangeEnd = 103951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0600D8A5 RID: 55461 RVA: 0x0035D2A0 File Offset: 0x0035B4A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A6 RID: 55462 RVA: 0x0035D2E0 File Offset: 0x0035B4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103951, XrefRangeEnd = 103956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700422C RID: 16940
			// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x0035D314 File Offset: 0x0035B514
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8A8 RID: 55464 RVA: 0x00065DCD File Offset: 0x00063FCD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004227 RID: 16935
			// (get) Token: 0x0600D8A9 RID: 55465 RVA: 0x0035D354 File Offset: 0x0035B554
			// (set) Token: 0x0600D8AA RID: 55466 RVA: 0x00065DD6 File Offset: 0x00063FD6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004228 RID: 16936
			// (get) Token: 0x0600D8AB RID: 55467 RVA: 0x0035D37C File Offset: 0x0035B57C
			// (set) Token: 0x0600D8AC RID: 55468 RVA: 0x00065DF1 File Offset: 0x00063FF1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004229 RID: 16937
			// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x0035D3AC File Offset: 0x0035B5AC
			// (set) Token: 0x0600D8AE RID: 55470 RVA: 0x00065E10 File Offset: 0x00064010
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0600D8AF RID: 55471 RVA: 0x0035D3DC File Offset: 0x0035B5DC
			// (set) Token: 0x0600D8B0 RID: 55472 RVA: 0x00065E2F File Offset: 0x0006402F
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040093ED RID: 37869
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093EE RID: 37870
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093EF RID: 37871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F0 RID: 37872
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040093F1 RID: 37873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093F2 RID: 37874
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093F3 RID: 37875
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093F4 RID: 37876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093F5 RID: 37877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093F6 RID: 37878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200095A RID: 2394
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass130_0")]
		public sealed class __c__DisplayClass130_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8B1 RID: 55473 RVA: 0x0035D404 File Offset: 0x0035B604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass130_0()
			{
				Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<>c__DisplayClass130_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr);
				Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr, "<>4__this");
				Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr_JumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr, "JumpDuration");
				Skateboard.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr, 100667196);
				Skateboard.__c__DisplayClass130_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr, 100667197);
			}

			// Token: 0x0600D8B2 RID: 55474 RVA: 0x0035D480 File Offset: 0x0035B680
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass130_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8B3 RID: 55475 RVA: 0x0035D4BC File Offset: 0x0035B6BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 103979, RefRangeEnd = 103981, XrefRangeStart = 103974, XrefRangeEnd = 103979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D8B4 RID: 55476 RVA: 0x00065E4A File Offset: 0x0006404A
			public __c__DisplayClass130_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422D RID: 16941
			// (get) Token: 0x0600D8B5 RID: 55477 RVA: 0x0035D4FC File Offset: 0x0035B6FC
			// (set) Token: 0x0600D8B6 RID: 55478 RVA: 0x00065E53 File Offset: 0x00064053
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422E RID: 16942
			// (get) Token: 0x0600D8B7 RID: 55479 RVA: 0x0035D52C File Offset: 0x0035B72C
			// (set) Token: 0x0600D8B8 RID: 55480 RVA: 0x00065E72 File Offset: 0x00064072
			public unsafe float JumpDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr_JumpDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.NativeFieldInfoPtr_JumpDuration)) = value;
				}
			}

			// Token: 0x040093F7 RID: 37879
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F8 RID: 37880
			private static readonly IntPtr NativeFieldInfoPtr_JumpDuration;

			// Token: 0x040093F9 RID: 37881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093FA RID: 37882
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DB2 RID: 3506
			[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass130_0+<<Jump>g__Jump|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FD68 RID: 64872 RVA: 0x003C58BC File Offset: 0x003C3ABC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0>.NativeClassPtr, "<<Jump>g__Jump|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667198);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667199);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667200);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667201);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667202);
					Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667203);
				}

				// Token: 0x0600FD69 RID: 64873 RVA: 0x003C59B0 File Offset: 0x003C3BB0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD6A RID: 64874 RVA: 0x003C59F8 File Offset: 0x003C3BF8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD6B RID: 64875 RVA: 0x003C5A2C File Offset: 0x003C3C2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103956, XrefRangeEnd = 103969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D07 RID: 19719
				// (get) Token: 0x0600FD6C RID: 64876 RVA: 0x003C5A68 File Offset: 0x003C3C68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD6D RID: 64877 RVA: 0x003C5AA8 File Offset: 0x003C3CA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103969, XrefRangeEnd = 103974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D08 RID: 19720
				// (get) Token: 0x0600FD6E RID: 64878 RVA: 0x003C5ADC File Offset: 0x003C3CDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD6F RID: 64879 RVA: 0x00078084 File Offset: 0x00076284
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D03 RID: 19715
				// (get) Token: 0x0600FD70 RID: 64880 RVA: 0x003C5B1C File Offset: 0x003C3D1C
				// (set) Token: 0x0600FD71 RID: 64881 RVA: 0x0007808D File Offset: 0x0007628D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D04 RID: 19716
				// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x003C5B44 File Offset: 0x003C3D44
				// (set) Token: 0x0600FD73 RID: 64883 RVA: 0x000780A8 File Offset: 0x000762A8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D05 RID: 19717
				// (get) Token: 0x0600FD74 RID: 64884 RVA: 0x003C5B74 File Offset: 0x003C3D74
				// (set) Token: 0x0600FD75 RID: 64885 RVA: 0x000780C7 File Offset: 0x000762C7
				public unsafe Skateboard.__c__DisplayClass130_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard.__c__DisplayClass130_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D06 RID: 19718
				// (get) Token: 0x0600FD76 RID: 64886 RVA: 0x003C5BA4 File Offset: 0x003C3DA4
				// (set) Token: 0x0600FD77 RID: 64887 RVA: 0x000780E6 File Offset: 0x000762E6
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass130_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AAD8 RID: 43736
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AAD9 RID: 43737
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AADA RID: 43738
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AADB RID: 43739
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AADC RID: 43740
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AADD RID: 43741
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AADE RID: 43742
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AADF RID: 43743
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AAE0 RID: 43744
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAE1 RID: 43745
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
