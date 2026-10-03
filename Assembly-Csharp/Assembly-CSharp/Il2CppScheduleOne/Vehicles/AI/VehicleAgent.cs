using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000EF RID: 239
	public class VehicleAgent : MonoBehaviour
	{
		// Token: 0x06001674 RID: 5748 RVA: 0x000C5F6C File Offset: 0x000C416C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAgent()
		{
			Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr);
			VehicleAgent.NativeFieldInfoPtr_VehicleGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "VehicleGraphName");
			VehicleAgent.NativeFieldInfoPtr_RoadGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RoadGraphName");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPath");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPathWhenReversing");
			VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MainGraphSamplePoint");
			VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MinRenavigationRate");
			VehicleAgent.NativeFieldInfoPtr_Steer_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_P");
			VehicleAgent.NativeFieldInfoPtr_Steer_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_I");
			VehicleAgent.NativeFieldInfoPtr_Steer_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_D");
			VehicleAgent.NativeFieldInfoPtr_Throttle_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_P");
			VehicleAgent.NativeFieldInfoPtr_Throttle_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_I");
			VehicleAgent.NativeFieldInfoPtr_Throttle_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_D");
			VehicleAgent.NativeFieldInfoPtr_Steer_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_Rate");
			VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxAxlePositionShift");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MIN_RANGE");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MAX_RANGE");
			VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MAX_STEER_ANGLE_OVERRIDE");
			VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "INFREQUENT_UPDATE_RATE");
			VehicleAgent.NativeFieldInfoPtr_KinematicModeRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "KinematicModeRotationSpeed");
			VehicleAgent.NativeFieldInfoPtr_KinematicModeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "KinematicModeSpeedMultiplier");
			VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DEBUG_MODE");
			VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<AutoDriving>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<TargetLocation>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Flags");
			VehicleAgent.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "roadSeeker");
			VehicleAgent.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "generalSeeker");
			VehicleAgent.NativeFieldInfoPtr_CTE_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "CTE_Origin");
			VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "FrontAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RearAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_sensor_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FL");
			VehicleAgent.NativeFieldInfoPtr_sensor_FM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FM");
			VehicleAgent.NativeFieldInfoPtr_sensor_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RL");
			VehicleAgent.NativeFieldInfoPtr_sensors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensors");
			VehicleAgent.NativeFieldInfoPtr_sweepMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepMask");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FR");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RR");
			VehicleAgent.NativeFieldInfoPtr_leftWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "leftWheel");
			VehicleAgent.NativeFieldInfoPtr_rightWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "rightWheel");
			VehicleAgent.NativeFieldInfoPtr_sweepSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepSegment");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMin");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMax");
			VehicleAgent.NativeFieldInfoPtr_aheadPointSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "aheadPointSamples");
			VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationDistanceSlowThreshold");
			VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationArrivalThreshold");
			VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerTargetFollowRate");
			VehicleAgent.NativeFieldInfoPtr_steerPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerPID");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMinRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMaxRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionDivisor");
			VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurnSpeedReductionAngleThreshold");
			VehicleAgent.NativeFieldInfoPtr_minTurningSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurningSpeed");
			VehicleAgent.NativeFieldInfoPtr_throttleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMin");
			VehicleAgent.NativeFieldInfoPtr_throttleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMax");
			VehicleAgent.NativeFieldInfoPtr_throttlePID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttlePID");
			VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "UnmarkedSpeed");
			VehicleAgent.NativeFieldInfoPtr_ReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "ReverseSpeed");
			VehicleAgent.NativeFieldInfoPtr_speedReductionTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "speedReductionTracker");
			VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitModeEnabled");
			VehicleAgent.NativeFieldInfoPtr_PursuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTarget");
			VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitDistanceUpdateThreshold");
			VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTargetLastPosition");
			VehicleAgent.NativeFieldInfoPtr_Teleporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Teleporter");
			VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PositionHistoryTracker");
			VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckTimeThreshold");
			VehicleAgent.NativeFieldInfoPtr_StuckSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckSamples");
			VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckDistanceThreshold");
			VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "storedNavigationCallback");
			VehicleAgent.NativeFieldInfoPtr_currentSpeedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentSpeedZone");
			VehicleAgent.NativeFieldInfoPtr__groundMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "_groundMask");
			VehicleAgent.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicle");
			VehicleAgent.NativeFieldInfoPtr_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelbase");
			VehicleAgent.NativeFieldInfoPtr_wheeltrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheeltrack");
			VehicleAgent.NativeFieldInfoPtr_vehicleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleLength");
			VehicleAgent.NativeFieldInfoPtr_vehicleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleWidth");
			VehicleAgent.NativeFieldInfoPtr_turnRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnRadius");
			VehicleAgent.NativeFieldInfoPtr_sweepTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTrack");
			VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelBottomOffset");
			VehicleAgent.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSpeed");
			VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSteerAngle_Normalized");
			VehicleAgent.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "lateralOffset");
			VehicleAgent.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "path");
			VehicleAgent.NativeFieldInfoPtr_timeOnLastNavigationCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "timeOnLastNavigationCall");
			VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTestFailedTime");
			VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentNavigationSettings");
			VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "navigationCalculationRoutine");
			VehicleAgent.NativeFieldInfoPtr_reverseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "reverseCoroutine");
			VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666440);
			VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666441);
			VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666442);
			VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666443);
			VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666444);
			VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666445);
			VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666446);
			VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666447);
			VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666448);
			VehicleAgent.NativeMethodInfoPtr_get_frontOfVehiclePosition_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666449);
			VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666450);
			VehicleAgent.NativeMethodInfoPtr_get_timeSinceLastNavigationCall_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666451);
			VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666452);
			VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666453);
			VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666454);
			VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666455);
			VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666456);
			VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666457);
			VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666458);
			VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666459);
			VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666460);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666461);
			VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666462);
			VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666463);
			VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666464);
			VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666465);
			VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666466);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666467);
			VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666468);
			VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666469);
			VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666470);
			VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666471);
			VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666472);
			VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666473);
			VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666474);
			VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666475);
			VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666476);
			VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666477);
			VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666478);
			VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666479);
			VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666480);
			VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666481);
			VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666482);
			VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666483);
			VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666484);
			VehicleAgent.NativeMethodInfoPtr__Reverse_b__142_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100666486);
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x000C6A3C File Offset: 0x000C4C3C
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x000C6A78 File Offset: 0x000C4C78
		public unsafe bool AutoDriving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x000C6AB8 File Offset: 0x000C4CB8
		public unsafe bool KinematicMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96118, XrefRangeEnd = 96120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000C6AF4 File Offset: 0x000C4CF4
		public unsafe bool IsReversing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 96120, RefRangeEnd = 96121, XrefRangeStart = 96120, XrefRangeEnd = 96120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x000C6B30 File Offset: 0x000C4D30
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x000C6B6C File Offset: 0x000C4D6C
		public unsafe Vector3 TargetLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x000C6BAC File Offset: 0x000C4DAC
		public unsafe float sampleStepSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 96122, RefRangeEnd = 96124, XrefRangeStart = 96121, XrefRangeEnd = 96122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000C6BE8 File Offset: 0x000C4DE8
		public unsafe float turnSpeedReductionRange
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96124, XrefRangeEnd = 96125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x000C6C24 File Offset: 0x000C4E24
		public unsafe float maxSteerAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96125, XrefRangeEnd = 96127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000C6C60 File Offset: 0x000C4E60
		public unsafe Vector3 frontOfVehiclePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96127, XrefRangeEnd = 96131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_frontOfVehiclePosition_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x000C6C9C File Offset: 0x000C4E9C
		public unsafe bool NavigationCalculationInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 96131, RefRangeEnd = 96132, XrefRangeStart = 96131, XrefRangeEnd = 96131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000C6CD8 File Offset: 0x000C4ED8
		public unsafe float timeSinceLastNavigationCall
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96132, XrefRangeEnd = 96133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_timeSinceLastNavigationCall_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000C6D14 File Offset: 0x000C4F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96133, XrefRangeEnd = 96180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000C6D48 File Offset: 0x000C4F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96180, XrefRangeEnd = 96193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000C6D84 File Offset: 0x000C4F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96278, RefRangeEnd = 96279, XrefRangeStart = 96193, XrefRangeEnd = 96278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000C6DB8 File Offset: 0x000C4FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96279, XrefRangeEnd = 96280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000C6DF4 File Offset: 0x000C4FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96280, XrefRangeEnd = 96310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000C6E28 File Offset: 0x000C5028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96310, XrefRangeEnd = 96323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000C6E5C File Offset: 0x000C505C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96402, RefRangeEnd = 96403, XrefRangeStart = 96323, XrefRangeEnd = 96402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateKinematic(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000C6E9C File Offset: 0x000C509C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96420, RefRangeEnd = 96422, XrefRangeStart = 96403, XrefRangeEnd = 96420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxleGroundHit(bool front)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref front;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000C6EE8 File Offset: 0x000C50E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96438, RefRangeEnd = 96439, XrefRangeStart = 96422, XrefRangeEnd = 96438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSweep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000C6F1C File Offset: 0x000C511C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96511, RefRangeEnd = 96512, XrefRangeStart = 96439, XrefRangeEnd = 96511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedReduction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000C6F50 File Offset: 0x000C5150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96512, XrefRangeEnd = 96525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePursuitMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000C6F84 File Offset: 0x000C5184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96525, XrefRangeEnd = 96549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStuckDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000C6FB8 File Offset: 0x000C51B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96580, RefRangeEnd = 96581, XrefRangeStart = 96549, XrefRangeEnd = 96580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDistanceFromPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000C6FEC File Offset: 0x000C51EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96581, XrefRangeEnd = 96591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOvertaking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000C7020 File Offset: 0x000C5220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96591, XrefRangeEnd = 96602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshSpeedZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000C705C File Offset: 0x000C525C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96602, XrefRangeEnd = 96611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000C7098 File Offset: 0x000C5298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96658, RefRangeEnd = 96659, XrefRangeStart = 96611, XrefRangeEnd = 96658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSteering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000C70CC File Offset: 0x000C52CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 96684, RefRangeEnd = 96690, XrefRangeStart = 96659, XrefRangeEnd = 96684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(Vector3 location, NavigationSettings settings = null, VehicleAgent.NavigationCallback callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000C7130 File Offset: 0x000C5330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96690, XrefRangeEnd = 96695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000C7180 File Offset: 0x000C5380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96708, RefRangeEnd = 96710, XrefRangeStart = 96695, XrefRangeEnd = 96708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDriving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000C71B4 File Offset: 0x000C53B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 96712, RefRangeEnd = 96717, XrefRangeStart = 96710, XrefRangeEnd = 96712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopNavigating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000C71E8 File Offset: 0x000C53E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96718, RefRangeEnd = 96719, XrefRangeStart = 96717, XrefRangeEnd = 96718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNavigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000C721C File Offset: 0x000C541C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96806, RefRangeEnd = 96808, XrefRangeStart = 96719, XrefRangeEnd = 96806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sweepAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000C72B0 File Offset: 0x000C54B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96940, RefRangeEnd = 96942, XrefRangeStart = 96808, XrefRangeEnd = 96940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000C7338 File Offset: 0x000C5538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96942, XrefRangeEnd = 96950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartReverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000C736C File Offset: 0x000C556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96950, XrefRangeEnd = 96955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000C73AC File Offset: 0x000C55AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96963, RefRangeEnd = 96966, XrefRangeStart = 96955, XrefRangeEnd = 96963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopReversing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000C73E0 File Offset: 0x000C55E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96966, XrefRangeEnd = 97024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &obstructionDist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000C742C File Offset: 0x000C562C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97025, RefRangeEnd = 97027, XrefRangeStart = 97024, XrefRangeEnd = 97025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000C7468 File Offset: 0x000C5668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97051, RefRangeEnd = 97054, XrefRangeStart = 97027, XrefRangeEnd = 97051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceFromVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000C74A4 File Offset: 0x000C56A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97065, RefRangeEnd = 97066, XrefRangeStart = 97054, XrefRangeEnd = 97065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPathLateralDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000C74E0 File Offset: 0x000C56E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97085, RefRangeEnd = 97087, XrefRangeStart = 97066, XrefRangeEnd = 97085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsStuck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000C751C File Offset: 0x000C571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97087, XrefRangeEnd = 97092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000C7558 File Offset: 0x000C5758
		[CallerCount(0)]
		public unsafe bool _Reverse_b__142_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__Reverse_b__142_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000C4BD File Offset: 0x0000A6BD
		public VehicleAgent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000C7594 File Offset: 0x000C5794
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000C4C6 File Offset: 0x0000A6C6
		public unsafe static string VehicleGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000C75B4 File Offset: 0x000C57B4
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		public unsafe static string RoadGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000C75D4 File Offset: 0x000C57D4
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000C4EA File Offset: 0x0000A6EA
		public unsafe static float MaxDistanceFromPath
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000C75F0 File Offset: 0x000C57F0
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		public unsafe static float MaxDistanceFromPathWhenReversing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000C760C File Offset: 0x000C580C
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x0000C506 File Offset: 0x0000A706
		public unsafe static Vector3 MainGraphSamplePoint
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x000C7628 File Offset: 0x000C5828
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x0000C514 File Offset: 0x0000A714
		public unsafe static float MinRenavigationRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000C7644 File Offset: 0x000C5844
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x0000C522 File Offset: 0x0000A722
		public unsafe static float Steer_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&value));
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000C7660 File Offset: 0x000C5860
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000C530 File Offset: 0x0000A730
		public unsafe static float Steer_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x000C767C File Offset: 0x000C587C
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000C53E File Offset: 0x0000A73E
		public unsafe static float Steer_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000C7698 File Offset: 0x000C5898
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0000C54C File Offset: 0x0000A74C
		public unsafe static float Throttle_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000C76B4 File Offset: 0x000C58B4
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x0000C55A File Offset: 0x0000A75A
		public unsafe static float Throttle_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000C76D0 File Offset: 0x000C58D0
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x0000C568 File Offset: 0x0000A768
		public unsafe static float Throttle_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x000C76EC File Offset: 0x000C58EC
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x0000C576 File Offset: 0x0000A776
		public unsafe static float Steer_Rate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000C7708 File Offset: 0x000C5908
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x0000C584 File Offset: 0x0000A784
		public unsafe static float MaxAxlePositionShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&value));
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000C7724 File Offset: 0x000C5924
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0000C592 File Offset: 0x0000A792
		public unsafe static float OBSTACLE_MIN_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x000C7740 File Offset: 0x000C5940
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		public unsafe static float OBSTACLE_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x000C775C File Offset: 0x000C595C
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0000C5AE File Offset: 0x0000A7AE
		public unsafe static float MAX_STEER_ANGLE_OVERRIDE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x000C7778 File Offset: 0x000C5978
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		public unsafe static float INFREQUENT_UPDATE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000C7794 File Offset: 0x000C5994
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0000C5CA File Offset: 0x0000A7CA
		public unsafe static float KinematicModeRotationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_KinematicModeRotationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_KinematicModeRotationSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000C77B0 File Offset: 0x000C59B0
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
		public unsafe static float KinematicModeSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_KinematicModeSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_KinematicModeSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000C77CC File Offset: 0x000C59CC
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x0000C5E6 File Offset: 0x0000A7E6
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000C77F4 File Offset: 0x000C59F4
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0000C601 File Offset: 0x0000A801
		public unsafe bool _AutoDriving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField)) = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000C781C File Offset: 0x000C5A1C
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0000C61C File Offset: 0x0000A81C
		public unsafe Vector3 _TargetLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000C7844 File Offset: 0x000C5A44
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0000C637 File Offset: 0x0000A837
		public unsafe DriveFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000C7874 File Offset: 0x000C5A74
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0000C656 File Offset: 0x0000A856
		public unsafe Seeker roadSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000C78A4 File Offset: 0x000C5AA4
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x0000C675 File Offset: 0x0000A875
		public unsafe Seeker generalSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000C78D4 File Offset: 0x000C5AD4
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0000C694 File Offset: 0x0000A894
		public unsafe Transform CTE_Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x000C7904 File Offset: 0x000C5B04
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000C7934 File Offset: 0x000C5B34
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x0000C6D2 File Offset: 0x0000A8D2
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x000C7964 File Offset: 0x000C5B64
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x0000C6F1 File Offset: 0x0000A8F1
		public unsafe Sensor sensor_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000C7994 File Offset: 0x000C5B94
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000C710 File Offset: 0x0000A910
		public unsafe Sensor sensor_FM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x000C79C4 File Offset: 0x000C5BC4
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0000C72F File Offset: 0x0000A92F
		public unsafe Sensor sensor_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000C79F4 File Offset: 0x000C5BF4
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0000C74E File Offset: 0x0000A94E
		public unsafe Sensor sensor_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000C7A24 File Offset: 0x000C5C24
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0000C76D File Offset: 0x0000A96D
		public unsafe Sensor sensor_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000C7A54 File Offset: 0x000C5C54
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0000C78C File Offset: 0x0000A98C
		public unsafe Il2CppReferenceArray<Sensor> sensors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sensor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000C7A84 File Offset: 0x000C5C84
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0000C7AB File Offset: 0x0000A9AB
		public unsafe LayerMask sweepMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask)) = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000C7AAC File Offset: 0x000C5CAC
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0000C7C6 File Offset: 0x0000A9C6
		public unsafe Transform sweepOrigin_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x000C7ADC File Offset: 0x000C5CDC
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000C7E5 File Offset: 0x0000A9E5
		public unsafe Transform sweepOrigin_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000C7B0C File Offset: 0x000C5D0C
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000C804 File Offset: 0x0000AA04
		public unsafe Transform sweepOrigin_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000C7B3C File Offset: 0x000C5D3C
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000C823 File Offset: 0x0000AA23
		public unsafe Transform sweepOrigin_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000C7B6C File Offset: 0x000C5D6C
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0000C842 File Offset: 0x0000AA42
		public unsafe Wheel leftWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000C7B9C File Offset: 0x000C5D9C
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0000C861 File Offset: 0x0000AA61
		public unsafe Wheel rightWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000C7BCC File Offset: 0x000C5DCC
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000C880 File Offset: 0x0000AA80
		public unsafe static float sweepSegment
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x000C7BE8 File Offset: 0x000C5DE8
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0000C88E File Offset: 0x0000AA8E
		public unsafe float sampleStepSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin)) = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000C7C10 File Offset: 0x000C5E10
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0000C8A9 File Offset: 0x0000AAA9
		public unsafe float sampleStepSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax)) = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x000C7C38 File Offset: 0x000C5E38
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
		public unsafe int aheadPointSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples)) = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x000C7C60 File Offset: 0x000C5E60
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0000C8DF File Offset: 0x0000AADF
		public unsafe static float DestinationDistanceSlowThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000C7C7C File Offset: 0x000C5E7C
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000C8ED File Offset: 0x0000AAED
		public unsafe static float DestinationArrivalThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x000C7C98 File Offset: 0x000C5E98
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x0000C8FB File Offset: 0x0000AAFB
		public unsafe float steerTargetFollowRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate)) = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0000C916 File Offset: 0x0000AB16
		public unsafe SteerPID steerPID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteerPID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000C7CF0 File Offset: 0x000C5EF0
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x0000C935 File Offset: 0x0000AB35
		public unsafe float turnSpeedReductionMinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange)) = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x000C7D18 File Offset: 0x000C5F18
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000C950 File Offset: 0x0000AB50
		public unsafe float turnSpeedReductionMaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange)) = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000C7D40 File Offset: 0x000C5F40
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0000C96B File Offset: 0x0000AB6B
		public unsafe float turnSpeedReductionDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x000C7D68 File Offset: 0x000C5F68
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0000C986 File Offset: 0x0000AB86
		public unsafe float minTurnSpeedReductionAngleThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000C7D90 File Offset: 0x000C5F90
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0000C9A1 File Offset: 0x0000ABA1
		public unsafe float minTurningSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed)) = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000C7DB8 File Offset: 0x000C5FB8
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		public unsafe float throttleMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin)) = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000C7DE0 File Offset: 0x000C5FE0
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0000C9D7 File Offset: 0x0000ABD7
		public unsafe float throttleMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax)) = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000C7E08 File Offset: 0x000C6008
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000C9F2 File Offset: 0x0000ABF2
		public unsafe PID throttlePID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000C7E38 File Offset: 0x000C6038
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000CA11 File Offset: 0x0000AC11
		public unsafe static float UnmarkedSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000C7E54 File Offset: 0x000C6054
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000CA1F File Offset: 0x0000AC1F
		public unsafe static float ReverseSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x000C7E70 File Offset: 0x000C6070
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000CA2D File Offset: 0x0000AC2D
		public unsafe ValueTracker speedReductionTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000C7EA0 File Offset: 0x000C60A0
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public unsafe bool PursuitModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled)) = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000C7EC8 File Offset: 0x000C60C8
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000CA67 File Offset: 0x0000AC67
		public unsafe Transform PursuitTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000C7EF8 File Offset: 0x000C60F8
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000CA86 File Offset: 0x0000AC86
		public unsafe float PursuitDistanceUpdateThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold)) = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000C7F20 File Offset: 0x000C6120
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		public unsafe Vector3 PursuitTargetLastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition)) = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x000C7F48 File Offset: 0x000C6148
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000CABC File Offset: 0x0000ACBC
		public unsafe VehicleTeleporter Teleporter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleTeleporter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000C7F78 File Offset: 0x000C6178
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000CADB File Offset: 0x0000ACDB
		public unsafe PositionHistoryTracker PositionHistoryTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionHistoryTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000C7FA8 File Offset: 0x000C61A8
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x0000CAFA File Offset: 0x0000ACFA
		public unsafe float StuckTimeThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold)) = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000C7FD0 File Offset: 0x000C61D0
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000CB15 File Offset: 0x0000AD15
		public unsafe int StuckSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples)) = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x000C7FF8 File Offset: 0x000C61F8
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public unsafe float StuckDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold)) = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x000C8020 File Offset: 0x000C6220
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x0000CB4B File Offset: 0x0000AD4B
		public unsafe VehicleAgent.NavigationCallback storedNavigationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.NavigationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000C8050 File Offset: 0x000C6250
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0000CB6A File Offset: 0x0000AD6A
		public unsafe SpeedZone currentSpeedZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpeedZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x000C8080 File Offset: 0x000C6280
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x0000CB89 File Offset: 0x0000AD89
		public unsafe LayerMask _groundMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__groundMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__groundMask)) = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000C80A8 File Offset: 0x000C62A8
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000C80D8 File Offset: 0x000C62D8
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x0000CBC3 File Offset: 0x0000ADC3
		public unsafe float wheelbase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase)) = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x000C8100 File Offset: 0x000C6300
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x0000CBDE File Offset: 0x0000ADDE
		public unsafe float wheeltrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack)) = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x000C8128 File Offset: 0x000C6328
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x0000CBF9 File Offset: 0x0000ADF9
		public unsafe float vehicleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength)) = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x000C8150 File Offset: 0x000C6350
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000CC14 File Offset: 0x0000AE14
		public unsafe float vehicleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth)) = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000C8178 File Offset: 0x000C6378
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000CC2F File Offset: 0x0000AE2F
		public unsafe float turnRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius)) = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000C81A0 File Offset: 0x000C63A0
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000CC4A File Offset: 0x0000AE4A
		public unsafe float sweepTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack)) = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000C81C8 File Offset: 0x000C63C8
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000CC65 File Offset: 0x0000AE65
		public unsafe float wheelBottomOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset)) = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000C81F0 File Offset: 0x000C63F0
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000CC80 File Offset: 0x0000AE80
		public unsafe float targetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed)) = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x000C8218 File Offset: 0x000C6418
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000CC9B File Offset: 0x0000AE9B
		public unsafe float targetSteerAngle_Normalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized)) = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000C8240 File Offset: 0x000C6440
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000CCB6 File Offset: 0x0000AEB6
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000C8268 File Offset: 0x000C6468
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0000CCD1 File Offset: 0x0000AED1
		public unsafe PathSmoothingUtility.SmoothedPath path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000C8298 File Offset: 0x000C6498
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		public unsafe float timeOnLastNavigationCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeOnLastNavigationCall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeOnLastNavigationCall)) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000C82C0 File Offset: 0x000C64C0
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0000CD0B File Offset: 0x0000AF0B
		public unsafe float sweepTestFailedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime)) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x000C82E8 File Offset: 0x000C64E8
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0000CD26 File Offset: 0x0000AF26
		public unsafe NavigationSettings currentNavigationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000C8318 File Offset: 0x000C6518
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x0000CD45 File Offset: 0x0000AF45
		public unsafe Coroutine navigationCalculationRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000C8348 File Offset: 0x000C6548
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000CD64 File Offset: 0x0000AF64
		public unsafe Coroutine reverseCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeFieldInfoPtr_VehicleGraphName;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeFieldInfoPtr_RoadGraphName;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPath;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeFieldInfoPtr_MainGraphSamplePoint;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr_MinRenavigationRate;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr_Steer_P;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeFieldInfoPtr_Steer_I;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_Steer_D;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_P;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_I;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_D;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeFieldInfoPtr_Steer_Rate;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeFieldInfoPtr_MaxAxlePositionShift;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MIN_RANGE;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MAX_RANGE;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeFieldInfoPtr_KinematicModeRotationSpeed;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr_KinematicModeSpeedMultiplier;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr__AutoDriving_k__BackingField;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr__TargetLocation_k__BackingField;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_CTE_Origin;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FL;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FM;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FR;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RR;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RL;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_sensors;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_sweepMask;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FL;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FR;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RL;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RR;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_leftWheel;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_rightWheel;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_sweepSegment;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMin;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMax;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr_aheadPointSamples;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDistanceSlowThreshold;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_DestinationArrivalThreshold;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_steerTargetFollowRate;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_steerPID;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMinRange;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMaxRange;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionDivisor;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr_minTurningSpeed;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeFieldInfoPtr_throttleMin;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeFieldInfoPtr_throttleMax;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeFieldInfoPtr_throttlePID;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr_UnmarkedSpeed;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeFieldInfoPtr_ReverseSpeed;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeFieldInfoPtr_speedReductionTracker;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_PursuitModeEnabled;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTarget;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr_PursuitDistanceUpdateThreshold;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTargetLastPosition;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_Teleporter;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_PositionHistoryTracker;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_StuckTimeThreshold;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr_StuckSamples;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeFieldInfoPtr_StuckDistanceThreshold;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeFieldInfoPtr_storedNavigationCallback;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeedZone;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeFieldInfoPtr__groundMask;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeFieldInfoPtr_wheelbase;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeFieldInfoPtr_wheeltrack;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeFieldInfoPtr_vehicleLength;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_vehicleWidth;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_turnRadius;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr_sweepTrack;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr_wheelBottomOffset;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeFieldInfoPtr_targetSpeed;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr_targetSteerAngle_Normalized;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastNavigationCall;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_sweepTestFailedTime;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr_currentNavigationSettings;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_navigationCalculationRoutine;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr_reverseCoroutine;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_get_frontOfVehiclePosition_Private_get_Vector3_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastNavigationCall_Private_get_Single_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSweep_Private_Void_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteering_Protected_Void_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_EndDriving_Private_Void_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_StopNavigating_Public_Void_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_RaycastHit_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_StartReverse_Public_Void_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_IEnumerator_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_StopReversing_Private_Void_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr__Reverse_b__142_0_Private_Boolean_0;

		// Token: 0x0200092D RID: 2349
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationResult")]
		public enum ENavigationResult
		{
			// Token: 0x04009318 RID: 37656
			Failed,
			// Token: 0x04009319 RID: 37657
			Complete,
			// Token: 0x0400931A RID: 37658
			Stopped
		}

		// Token: 0x0200092E RID: 2350
		[OriginalName("Assembly-CSharp.dll", "", "EAgentStatus")]
		public enum EAgentStatus
		{
			// Token: 0x0400931C RID: 37660
			Inactive,
			// Token: 0x0400931D RID: 37661
			MovingToRoad,
			// Token: 0x0400931E RID: 37662
			OnRoad
		}

		// Token: 0x0200092F RID: 2351
		[OriginalName("Assembly-CSharp.dll", "", "EPathGroupStatus")]
		public enum EPathGroupStatus
		{
			// Token: 0x04009320 RID: 37664
			Inactive,
			// Token: 0x04009321 RID: 37665
			Calculating
		}

		// Token: 0x02000930 RID: 2352
		[OriginalName("Assembly-CSharp.dll", "", "ESweepType")]
		public enum ESweepType
		{
			// Token: 0x04009323 RID: 37667
			FL,
			// Token: 0x04009324 RID: 37668
			FR,
			// Token: 0x04009325 RID: 37669
			RL,
			// Token: 0x04009326 RID: 37670
			RR
		}

		// Token: 0x02000931 RID: 2353
		public sealed class NavigationCallback : MulticastDelegate
		{
			// Token: 0x0600D7D5 RID: 55253 RVA: 0x0035ADB0 File Offset: 0x00358FB0
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCallback()
			{
				Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "NavigationCallback");
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100666487);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100666488);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100666489);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100666490);
			}

			// Token: 0x0600D7D6 RID: 55254 RVA: 0x0035AE24 File Offset: 0x00359024
			[CallerCount(152)]
			[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95927, XrefRangeEnd = 95930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D7 RID: 55255 RVA: 0x0035AE80 File Offset: 0x00359080
			[CallerCount(0)]
			public unsafe void Invoke(VehicleAgent.ENavigationResult status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D8 RID: 55256 RVA: 0x0035AEC0 File Offset: 0x003590C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96082, XrefRangeEnd = 96086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VehicleAgent.ENavigationResult status, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D7D9 RID: 55257 RVA: 0x0035AF30 File Offset: 0x00359130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7DA RID: 55258 RVA: 0x00065738 File Offset: 0x00063938
			public NavigationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D7DB RID: 55259 RVA: 0x00065741 File Offset: 0x00063941
			public static implicit operator VehicleAgent.NavigationCallback(Action<VehicleAgent.ENavigationResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VehicleAgent.NavigationCallback>(A_0);
			}

			// Token: 0x0600D7DC RID: 55260 RVA: 0x00065749 File Offset: 0x00063949
			public static VehicleAgent.NavigationCallback operator +(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VehicleAgent.NavigationCallback>();
			}

			// Token: 0x0600D7DD RID: 55261 RVA: 0x00065757 File Offset: 0x00063957
			public static VehicleAgent.NavigationCallback operator -(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VehicleAgent.NavigationCallback>();
				}
				return result;
			}

			// Token: 0x04009327 RID: 37671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009328 RID: 37672
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0;

			// Token: 0x04009329 RID: 37673
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0;

			// Token: 0x0400932A RID: 37674
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000932 RID: 2354
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7DE RID: 55262 RVA: 0x0035AF74 File Offset: 0x00359174
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr);
				VehicleAgent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9");
				VehicleAgent.__c.NativeFieldInfoPtr___9__123_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__123_0");
				VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100666492);
				VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__123_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100666493);
			}

			// Token: 0x0600D7DF RID: 55263 RVA: 0x0035AFF0 File Offset: 0x003591F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E0 RID: 55264 RVA: 0x0035B02C File Offset: 0x0035922C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96086, XrefRangeEnd = 96087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateKinematic_b__123_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__123_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7E1 RID: 55265 RVA: 0x00065768 File Offset: 0x00063968
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E8 RID: 16872
			// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x0035B078 File Offset: 0x00359278
			// (set) Token: 0x0600D7E3 RID: 55267 RVA: 0x00065771 File Offset: 0x00063971
			public unsafe static VehicleAgent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E9 RID: 16873
			// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x0035B0A0 File Offset: 0x003592A0
			// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x00065783 File Offset: 0x00063983
			public unsafe static Func<RaycastHit, float> __9__123_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__123_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__123_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400932B RID: 37675
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400932C RID: 37676
			private static readonly IntPtr NativeFieldInfoPtr___9__123_0;

			// Token: 0x0400932D RID: 37677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400932E RID: 37678
			private static readonly IntPtr NativeMethodInfoPtr__UpdateKinematic_b__123_0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000933 RID: 2355
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7E6 RID: 55270 RVA: 0x0035B0C8 File Offset: 0x003592C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr, 100666494);
				VehicleAgent.__c__DisplayClass139_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr, 100666495);
			}

			// Token: 0x0600D7E7 RID: 55271 RVA: 0x0035B144 File Offset: 0x00359344
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E8 RID: 55272 RVA: 0x0035B180 File Offset: 0x00359380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96087, XrefRangeEnd = 96093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _SweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass139_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7E9 RID: 55273 RVA: 0x00065795 File Offset: 0x00063995
			public __c__DisplayClass139_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EA RID: 16874
			// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x0035B1CC File Offset: 0x003593CC
			// (set) Token: 0x0600D7EB RID: 55275 RVA: 0x0006579E File Offset: 0x0006399E
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x170041EB RID: 16875
			// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x0035B1F4 File Offset: 0x003593F4
			// (set) Token: 0x0600D7ED RID: 55277 RVA: 0x000657B9 File Offset: 0x000639B9
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass139_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400932F RID: 37679
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04009330 RID: 37680
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009331 RID: 37681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009332 RID: 37682
			private static readonly IntPtr NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000934 RID: 2356
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass140_0")]
		public sealed class __c__DisplayClass140_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7EE RID: 55278 RVA: 0x0035B224 File Offset: 0x00359424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass140_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass140_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr, 100666496);
				VehicleAgent.__c__DisplayClass140_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr, 100666497);
			}

			// Token: 0x0600D7EF RID: 55279 RVA: 0x0035B2A0 File Offset: 0x003594A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass140_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass140_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F0 RID: 55280 RVA: 0x0035B2DC File Offset: 0x003594DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _BetterSweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass140_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7F1 RID: 55281 RVA: 0x000657D8 File Offset: 0x000639D8
			public __c__DisplayClass140_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EC RID: 16876
			// (get) Token: 0x0600D7F2 RID: 55282 RVA: 0x0035B328 File Offset: 0x00359528
			// (set) Token: 0x0600D7F3 RID: 55283 RVA: 0x000657E1 File Offset: 0x000639E1
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x170041ED RID: 16877
			// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x0035B350 File Offset: 0x00359550
			// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x000657FC File Offset: 0x000639FC
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass140_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009333 RID: 37683
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04009334 RID: 37684
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009335 RID: 37685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009336 RID: 37686
			private static readonly IntPtr NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000935 RID: 2357
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<Reverse>d__142")]
		public sealed class _Reverse_d__142 : Il2CppSystem.Object
		{
			// Token: 0x0600D7F6 RID: 55286 RVA: 0x0035B380 File Offset: 0x00359580
			// Note: this type is marked as 'beforefieldinit'.
			static _Reverse_d__142()
			{
				Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<Reverse>d__142");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr);
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<>1__state");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<>2__current");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<>4__this");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__futureTarget_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<futureTarget>5__2");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__steerAngleNormal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<steerAngleNormal>5__3");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__frontWheel_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<frontWheel>5__4");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__sweepAngle_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<sweepAngle>5__5");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<reverseSweepDistanceMin>5__6");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__canBeginSwing_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<canBeginSwing>5__7");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__faceTarget_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<faceTarget>5__8");
				VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__continueReversing_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, "<continueReversing>5__9");
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666498);
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666499);
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666500);
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666501);
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666502);
				VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr, 100666503);
			}

			// Token: 0x0600D7F7 RID: 55287 RVA: 0x0035B500 File Offset: 0x00359700
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reverse_d__142(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent._Reverse_d__142>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F8 RID: 55288 RVA: 0x0035B548 File Offset: 0x00359748
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F9 RID: 55289 RVA: 0x0035B57C File Offset: 0x0035977C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96093, XrefRangeEnd = 96113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041F9 RID: 16889
			// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x0035B5B8 File Offset: 0x003597B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FB RID: 55291 RVA: 0x0035B5F8 File Offset: 0x003597F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96113, XrefRangeEnd = 96118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041FA RID: 16890
			// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x0035B62C File Offset: 0x0035982C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FD RID: 55293 RVA: 0x0006581B File Offset: 0x00063A1B
			public _Reverse_d__142(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EE RID: 16878
			// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0035B66C File Offset: 0x0035986C
			// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x00065824 File Offset: 0x00063A24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041EF RID: 16879
			// (get) Token: 0x0600D800 RID: 55296 RVA: 0x0035B694 File Offset: 0x00359894
			// (set) Token: 0x0600D801 RID: 55297 RVA: 0x0006583F File Offset: 0x00063A3F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F0 RID: 16880
			// (get) Token: 0x0600D802 RID: 55298 RVA: 0x0035B6C4 File Offset: 0x003598C4
			// (set) Token: 0x0600D803 RID: 55299 RVA: 0x0006585E File Offset: 0x00063A5E
			public unsafe VehicleAgent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F1 RID: 16881
			// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0035B6F4 File Offset: 0x003598F4
			// (set) Token: 0x0600D805 RID: 55301 RVA: 0x0006587D File Offset: 0x00063A7D
			public unsafe Vector3 _futureTarget_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__futureTarget_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__futureTarget_5__2)) = value;
				}
			}

			// Token: 0x170041F2 RID: 16882
			// (get) Token: 0x0600D806 RID: 55302 RVA: 0x0035B71C File Offset: 0x0035991C
			// (set) Token: 0x0600D807 RID: 55303 RVA: 0x00065898 File Offset: 0x00063A98
			public unsafe float _steerAngleNormal_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__steerAngleNormal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__steerAngleNormal_5__3)) = value;
				}
			}

			// Token: 0x170041F3 RID: 16883
			// (get) Token: 0x0600D808 RID: 55304 RVA: 0x0035B744 File Offset: 0x00359944
			// (set) Token: 0x0600D809 RID: 55305 RVA: 0x000658B3 File Offset: 0x00063AB3
			public unsafe VehicleAgent.ESweepType _frontWheel_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__frontWheel_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__frontWheel_5__4)) = value;
				}
			}

			// Token: 0x170041F4 RID: 16884
			// (get) Token: 0x0600D80A RID: 55306 RVA: 0x0035B76C File Offset: 0x0035996C
			// (set) Token: 0x0600D80B RID: 55307 RVA: 0x000658CE File Offset: 0x00063ACE
			public unsafe float _sweepAngle_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__sweepAngle_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__sweepAngle_5__5)) = value;
				}
			}

			// Token: 0x170041F5 RID: 16885
			// (get) Token: 0x0600D80C RID: 55308 RVA: 0x0035B794 File Offset: 0x00359994
			// (set) Token: 0x0600D80D RID: 55309 RVA: 0x000658E9 File Offset: 0x00063AE9
			public unsafe float _reverseSweepDistanceMin_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6)) = value;
				}
			}

			// Token: 0x170041F6 RID: 16886
			// (get) Token: 0x0600D80E RID: 55310 RVA: 0x0035B7BC File Offset: 0x003599BC
			// (set) Token: 0x0600D80F RID: 55311 RVA: 0x00065904 File Offset: 0x00063B04
			public unsafe bool _canBeginSwing_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__canBeginSwing_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__canBeginSwing_5__7)) = value;
				}
			}

			// Token: 0x170041F7 RID: 16887
			// (get) Token: 0x0600D810 RID: 55312 RVA: 0x0035B7E4 File Offset: 0x003599E4
			// (set) Token: 0x0600D811 RID: 55313 RVA: 0x0006591F File Offset: 0x00063B1F
			public unsafe Vector3 _faceTarget_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__faceTarget_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__faceTarget_5__8)) = value;
				}
			}

			// Token: 0x170041F8 RID: 16888
			// (get) Token: 0x0600D812 RID: 55314 RVA: 0x0035B80C File Offset: 0x00359A0C
			// (set) Token: 0x0600D813 RID: 55315 RVA: 0x0006593A File Offset: 0x00063B3A
			public unsafe bool _continueReversing_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__continueReversing_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__142.NativeFieldInfoPtr__continueReversing_5__9)) = value;
				}
			}

			// Token: 0x04009337 RID: 37687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009338 RID: 37688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009339 RID: 37689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400933A RID: 37690
			private static readonly IntPtr NativeFieldInfoPtr__futureTarget_5__2;

			// Token: 0x0400933B RID: 37691
			private static readonly IntPtr NativeFieldInfoPtr__steerAngleNormal_5__3;

			// Token: 0x0400933C RID: 37692
			private static readonly IntPtr NativeFieldInfoPtr__frontWheel_5__4;

			// Token: 0x0400933D RID: 37693
			private static readonly IntPtr NativeFieldInfoPtr__sweepAngle_5__5;

			// Token: 0x0400933E RID: 37694
			private static readonly IntPtr NativeFieldInfoPtr__reverseSweepDistanceMin_5__6;

			// Token: 0x0400933F RID: 37695
			private static readonly IntPtr NativeFieldInfoPtr__canBeginSwing_5__7;

			// Token: 0x04009340 RID: 37696
			private static readonly IntPtr NativeFieldInfoPtr__faceTarget_5__8;

			// Token: 0x04009341 RID: 37697
			private static readonly IntPtr NativeFieldInfoPtr__continueReversing_5__9;

			// Token: 0x04009342 RID: 37698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009343 RID: 37699
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009344 RID: 37700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009345 RID: 37701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009346 RID: 37702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009347 RID: 37703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
