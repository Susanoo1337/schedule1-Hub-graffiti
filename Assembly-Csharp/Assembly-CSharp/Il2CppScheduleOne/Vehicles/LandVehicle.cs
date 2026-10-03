using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.Graffiti;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000CD RID: 205
	public class LandVehicle : NetworkBehaviour
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x000B8900 File Offset: 0x000B6B00
		// Note: this type is marked as 'beforefieldinit'.
		static LandVehicle()
		{
			Il2CppClassPointerStore<LandVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LandVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr);
			LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "KINEMATIC_THRESHOLD_DISTANCE");
			LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MAX_TURNOVER_SPEED");
			LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TURNOVER_FORCE");
			LandVehicle.NativeFieldInfoPtr_USE_WHEEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "USE_WHEEL");
			LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SPEED_DISPLAY_MULTIPLIER");
			LandVehicle.NativeFieldInfoPtr_MaxImpactDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MaxImpactDamage");
			LandVehicle.NativeFieldInfoPtr_MaxImpactDamageSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MaxImpactDamageSpeed");
			LandVehicle.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DEBUG");
			LandVehicle.NativeFieldInfoPtr_vehicleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleName");
			LandVehicle.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleCode");
			LandVehicle.NativeFieldInfoPtr_vehiclePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehiclePrice");
			LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsPlayerOwned>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsVisible>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "UseHumanoidCollider");
			LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<GUID>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SpawnAsPlayerOwned");
			LandVehicle.NativeFieldInfoPtr_vehicleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleModel");
			LandVehicle.NativeFieldInfoPtr_driveWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "driveWheels");
			LandVehicle.NativeFieldInfoPtr_steerWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerWheels");
			LandVehicle.NativeFieldInfoPtr_handbrakeWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handbrakeWheels");
			LandVehicle.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "wheels");
			LandVehicle.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "intObj");
			LandVehicle.NativeFieldInfoPtr_exitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "exitPoints");
			LandVehicle.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Rb");
			LandVehicle.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Color");
			LandVehicle.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Seats");
			LandVehicle.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "boundingBox");
			LandVehicle.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Agent");
			LandVehicle.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VelocityCalculator");
			LandVehicle.NativeFieldInfoPtr_Trunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Trunk");
			LandVehicle.NativeFieldInfoPtr_NavMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavMeshObstacle");
			LandVehicle.NativeFieldInfoPtr_NavmeshCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavmeshCut");
			LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "HumanoidColliderContainer");
			LandVehicle.NativeFieldInfoPtr_POI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "POI");
			LandVehicle.NativeFieldInfoPtr__spraySurfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "_spraySurfaces");
			LandVehicle.NativeFieldInfoPtr_pushers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "pushers");
			LandVehicle.NativeFieldInfoPtr_centerOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "centerOfMass");
			LandVehicle.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "cameraOrigin");
			LandVehicle.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lights");
			LandVehicle.NativeFieldInfoPtr_maxSteeringAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "maxSteeringAngle");
			LandVehicle.NativeFieldInfoPtr_steerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerRate");
			LandVehicle.NativeFieldInfoPtr_flipSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "flipSteer");
			LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<MaxSteerAngleOverridden>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OverriddenMaxSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_motorTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "motorTorque");
			LandVehicle.NativeFieldInfoPtr_TopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TopSpeed");
			LandVehicle.NativeFieldInfoPtr_diffGearing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "diffGearing");
			LandVehicle.NativeFieldInfoPtr_handBrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handBrakeForce");
			LandVehicle.NativeFieldInfoPtr_brakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "brakeForce");
			LandVehicle.NativeFieldInfoPtr_BrakeForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BrakeForceMultiplier");
			LandVehicle.NativeFieldInfoPtr_downforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "downforce");
			LandVehicle.NativeFieldInfoPtr_reverseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "reverseMultiplier");
			LandVehicle.NativeFieldInfoPtr_overrideControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "overrideControls");
			LandVehicle.NativeFieldInfoPtr_throttleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "throttleOverride");
			LandVehicle.NativeFieldInfoPtr_steerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerOverride");
			LandVehicle.NativeFieldInfoPtr_handbrakeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handbrakeOverride");
			LandVehicle.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Storage");
			LandVehicle.NativeFieldInfoPtr_localPlayerSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "localPlayerSeat");
			LandVehicle.NativeFieldInfoPtr__LocalPlayerIsDriver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalPlayerIsDriver>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__LocalPlayerIsInVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalPlayerIsInVehicle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isOccupied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "_isOccupied");
			LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OccupantNPCs>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__localPlayerJustEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "_localPlayerJustEntered");
			LandVehicle.NativeFieldInfoPtr__Speed_Kmh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<Speed_Kmh>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsPhysicallySimulated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsPhysicallySimulated>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_previousSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeeds");
			LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeedsSampleSize");
			LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<currentThrottle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__CurrentSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFrameSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastReplicatedSteerAngle");
			LandVehicle.NativeFieldInfoPtr_justExitedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "justExitedVehicle");
			LandVehicle.NativeFieldInfoPtr__BrakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<BrakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__HandbrakeApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<HandbrakeApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFramePosition");
			LandVehicle.NativeFieldInfoPtr_closestExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "closestExitPoint");
			LandVehicle.NativeFieldInfoPtr_timeOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "timeOnSpawn");
			LandVehicle.NativeFieldInfoPtr_timeOnLastOccupied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "timeOnLastOccupied");
			LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OwnedColor>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "_state");
			LandVehicle.NativeFieldInfoPtr_CurrentParkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "CurrentParkData");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingLot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingSpot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "loader");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<HasChanged>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_onVehicleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStart");
			LandVehicle.NativeFieldInfoPtr_onVehicleStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStop");
			LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onHandbrakeApplied");
			LandVehicle.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onCollision");
			LandVehicle.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<ScheduleOne.Core.Weather.IWeatherEntity.WeatherVolume>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsUnderCover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsUnderCover>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____CurrentSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<CurrentSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____BrakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<BrakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____IsReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<IsReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665974);
			LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665975);
			LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665976);
			LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665977);
			LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665978);
			LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665979);
			LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665980);
			LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665981);
			LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665982);
			LandVehicle.NativeMethodInfoPtr_get_State_Public_get_MonoState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665983);
			LandVehicle.NativeMethodInfoPtr_get_BoundingBoxDimensions_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665984);
			LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665985);
			LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665986);
			LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665987);
			LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665988);
			LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665989);
			LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665990);
			LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665991);
			LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665992);
			LandVehicle.NativeMethodInfoPtr_get_LocalPlayerIsDriver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665993);
			LandVehicle.NativeMethodInfoPtr_set_LocalPlayerIsDriver_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665994);
			LandVehicle.NativeMethodInfoPtr_get_LocalPlayerIsInVehicle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665995);
			LandVehicle.NativeMethodInfoPtr_set_LocalPlayerIsInVehicle_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665996);
			LandVehicle.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665997);
			LandVehicle.NativeMethodInfoPtr_set_IsOccupied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665998);
			LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100665999);
			LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666000);
			LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666001);
			LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666002);
			LandVehicle.NativeMethodInfoPtr_get_Speed_Kmh_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666003);
			LandVehicle.NativeMethodInfoPtr_set_Speed_Kmh_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666004);
			LandVehicle.NativeMethodInfoPtr_get_IsPhysicallySimulated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666005);
			LandVehicle.NativeMethodInfoPtr_set_IsPhysicallySimulated_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666006);
			LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666007);
			LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666008);
			LandVehicle.NativeMethodInfoPtr_get_CurrentSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666009);
			LandVehicle.NativeMethodInfoPtr_set_CurrentSteerAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666010);
			LandVehicle.NativeMethodInfoPtr_get_BrakesApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666011);
			LandVehicle.NativeMethodInfoPtr_set_BrakesApplied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666012);
			LandVehicle.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666013);
			LandVehicle.NativeMethodInfoPtr_set_IsReversing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666014);
			LandVehicle.NativeMethodInfoPtr_get_HandbrakeApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666015);
			LandVehicle.NativeMethodInfoPtr_set_HandbrakeApplied_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666016);
			LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666017);
			LandVehicle.NativeMethodInfoPtr_get_timeSinceSpawn_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666018);
			LandVehicle.NativeMethodInfoPtr_get_timeSinceLastOccupied_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666019);
			LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666020);
			LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666021);
			LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666022);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666023);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666024);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666025);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666026);
			LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666027);
			LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666028);
			LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666029);
			LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666030);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666031);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666032);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666033);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666034);
			LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666035);
			LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666036);
			LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666037);
			LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666038);
			LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666039);
			LandVehicle.NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666040);
			LandVehicle.NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666041);
			LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666042);
			LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666043);
			LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666044);
			LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666045);
			LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666046);
			LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666047);
			LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666048);
			LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666049);
			LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666050);
			LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666051);
			LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666052);
			LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666053);
			LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666054);
			LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666055);
			LandVehicle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666056);
			LandVehicle.NativeMethodInfoPtr_UpdateSpeedCalculation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666057);
			LandVehicle.NativeMethodInfoPtr_UpdateOutOfBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666058);
			LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666059);
			LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666060);
			LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666061);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666062);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666063);
			LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666064);
			LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666065);
			LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666066);
			LandVehicle.NativeMethodInfoPtr_ApplyDownForce_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666067);
			LandVehicle.NativeMethodInfoPtr_UpdateTurnOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666068);
			LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666069);
			LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666070);
			LandVehicle.NativeMethodInfoPtr_SetIsBraking_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666071);
			LandVehicle.NativeMethodInfoPtr_SetIsBreaking_Server_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666072);
			LandVehicle.NativeMethodInfoPtr_SetIsReversing_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666073);
			LandVehicle.NativeMethodInfoPtr_SetIsReversing_Server_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666074);
			LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666075);
			LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666076);
			LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666077);
			LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666078);
			LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666079);
			LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666080);
			LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666081);
			LandVehicle.NativeMethodInfoPtr_UpdatePhysicallySimulated_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666082);
			LandVehicle.NativeMethodInfoPtr_ShouldBePhysicallySimulated_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666083);
			LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666084);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666085);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666086);
			LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666087);
			LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666088);
			LandVehicle.NativeMethodInfoPtr_StartVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666089);
			LandVehicle.NativeMethodInfoPtr_StopVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666090);
			LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666091);
			LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666092);
			LandVehicle.NativeMethodInfoPtr_OnLocalPlayerEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666093);
			LandVehicle.NativeMethodInfoPtr_OnLocalPlayerExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666094);
			LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666095);
			LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666096);
			LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666097);
			LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666098);
			LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666099);
			LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666100);
			LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666101);
			LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666102);
			LandVehicle.NativeMethodInfoPtr_TeleportToNavMesh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666103);
			LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666104);
			LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666105);
			LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666106);
			LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666107);
			LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666108);
			LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666109);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666110);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666111);
			LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666112);
			LandVehicle.NativeMethodInfoPtr_RegisterPusher_Public_Void_PlayerPusher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666113);
			LandVehicle.NativeMethodInfoPtr_DeregisterPusher_Public_Void_PlayerPusher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666114);
			LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666115);
			LandVehicle.NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666116);
			LandVehicle.NativeMethodInfoPtr_GetSpraySurfaceData_Protected_List_1_SpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666117);
			LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666118);
			LandVehicle.NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666119);
			LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666120);
			LandVehicle.NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666121);
			LandVehicle.NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666122);
			LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666123);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666124);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666125);
			LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666126);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666127);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666128);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666129);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666130);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666131);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666132);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666133);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666134);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666135);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666136);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666137);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666138);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666139);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666140);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666141);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666142);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666143);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666144);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666145);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666146);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetIsBreaking_Server_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666147);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsBreaking_Server_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666148);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetIsBreaking_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666149);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetIsReversing_Server_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666150);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsReversing_Server_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666151);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetIsReversing_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666152);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666153);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666154);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666155);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666156);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666157);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666158);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666159);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666160);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666161);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666162);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666163);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666164);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666165);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666166);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666167);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666168);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666169);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666170);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666171);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666172);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666173);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666174);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666175);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666176);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666177);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666178);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__CurrentSteerAngle_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666179);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__CurrentSteerAngle_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666180);
			LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666181);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__BrakesApplied_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666182);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__BrakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666183);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__IsReversing_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666184);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__IsReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666185);
			LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100666186);
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x000BA190 File Offset: 0x000B8390
		public unsafe string VehicleName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x000BA1C8 File Offset: 0x000B83C8
		public unsafe string VehicleCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000BA200 File Offset: 0x000B8400
		public unsafe float VehiclePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x000BA23C File Offset: 0x000B843C
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x000BA278 File Offset: 0x000B8478
		public unsafe bool IsPlayerOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x000BA2B8 File Offset: 0x000B84B8
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x000BA2F4 File Offset: 0x000B84F4
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000BA334 File Offset: 0x000B8534
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x000BA370 File Offset: 0x000B8570
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000BA3B0 File Offset: 0x000B85B0
		public unsafe MonoState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_State_Public_get_MonoState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr3) : null;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x000BA3F0 File Offset: 0x000B85F0
		public unsafe Vector3 BoundingBoxDimensions
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 91112, RefRangeEnd = 91121, XrefRangeStart = 91103, XrefRangeEnd = 91112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_BoundingBoxDimensions_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000BA42C File Offset: 0x000B862C
		public unsafe Transform driverEntryPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91121, XrefRangeEnd = 91125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000BA46C File Offset: 0x000B866C
		public unsafe float ActualMaxSteeringAngle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 91125, RefRangeEnd = 91133, XrefRangeStart = 91125, XrefRangeEnd = 91125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000BA4A8 File Offset: 0x000B86A8
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x000BA4E4 File Offset: 0x000B86E4
		public unsafe bool MaxSteerAngleOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000BA524 File Offset: 0x000B8724
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000BA560 File Offset: 0x000B8760
		public unsafe float OverriddenMaxSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000BA5A0 File Offset: 0x000B87A0
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000BA5DC File Offset: 0x000B87DC
		public unsafe int CurrentPlayerOccupancy
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91151, RefRangeEnd = 91153, XrefRangeStart = 91133, XrefRangeEnd = 91151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000BA618 File Offset: 0x000B8818
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x000BA654 File Offset: 0x000B8854
		public unsafe bool LocalPlayerIsDriver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalPlayerIsDriver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalPlayerIsDriver_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000BA694 File Offset: 0x000B8894
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x000BA6D0 File Offset: 0x000B88D0
		public unsafe bool LocalPlayerIsInVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalPlayerIsInVehicle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalPlayerIsInVehicle_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x000BA710 File Offset: 0x000B8910
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x000BA74C File Offset: 0x000B894C
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91153, XrefRangeEnd = 91154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsOccupied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x000BA78C File Offset: 0x000B898C
		public unsafe Player DriverPlayer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 91158, RefRangeEnd = 91171, XrefRangeStart = 91154, XrefRangeEnd = 91158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000BA7CC File Offset: 0x000B89CC
		public unsafe List<Player> OccupantPlayers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91209, RefRangeEnd = 91211, XrefRangeStart = 91171, XrefRangeEnd = 91209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000BA80C File Offset: 0x000B8A0C
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x000BA84C File Offset: 0x000B8A4C
		public unsafe Il2CppReferenceArray<NPC> OccupantNPCs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91211, XrefRangeEnd = 91212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x000BA890 File Offset: 0x000B8A90
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x000BA8CC File Offset: 0x000B8ACC
		public unsafe float Speed_Kmh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Speed_Kmh_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_Speed_Kmh_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x000BA90C File Offset: 0x000B8B0C
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x000BA948 File Offset: 0x000B8B48
		public unsafe bool IsPhysicallySimulated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsPhysicallySimulated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsPhysicallySimulated_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000BA988 File Offset: 0x000B8B88
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x000BA9C4 File Offset: 0x000B8BC4
		public unsafe float currentThrottle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000BAA04 File Offset: 0x000B8C04
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x000BAA40 File Offset: 0x000B8C40
		public unsafe float CurrentSteerAngle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91212, RefRangeEnd = 91214, XrefRangeStart = 91212, XrefRangeEnd = 91212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 91221, RefRangeEnd = 91226, XrefRangeStart = 91214, XrefRangeEnd = 91221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentSteerAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000BAA80 File Offset: 0x000B8C80
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x000BAABC File Offset: 0x000B8CBC
		public unsafe bool BrakesApplied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_BrakesApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 91233, RefRangeEnd = 91236, XrefRangeStart = 91226, XrefRangeEnd = 91233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_BrakesApplied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x000BAAFC File Offset: 0x000B8CFC
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x000BAB38 File Offset: 0x000B8D38
		public unsafe bool IsReversing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 91243, RefRangeEnd = 91246, XrefRangeStart = 91236, XrefRangeEnd = 91243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsReversing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000BAB78 File Offset: 0x000B8D78
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x000BABB4 File Offset: 0x000B8DB4
		public unsafe bool HandbrakeApplied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_HandbrakeApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_HandbrakeApplied_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000BABF4 File Offset: 0x000B8DF4
		public unsafe float boundingBaseOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91246, XrefRangeEnd = 91251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x000BAC30 File Offset: 0x000B8E30
		public unsafe float timeSinceSpawn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91251, XrefRangeEnd = 91252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_timeSinceSpawn_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000BAC6C File Offset: 0x000B8E6C
		public unsafe float timeSinceLastOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91252, XrefRangeEnd = 91253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_timeSinceLastOccupied_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x000BACE4 File Offset: 0x000B8EE4
		public unsafe EVehicleColor OwnedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x000BAD24 File Offset: 0x000B8F24
		public unsafe bool isParked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91257, RefRangeEnd = 91258, XrefRangeStart = 91253, XrefRangeEnd = 91257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000BAD60 File Offset: 0x000B8F60
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000BADA0 File Offset: 0x000B8FA0
		public unsafe ParkingLot CurrentParkingLot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91258, XrefRangeEnd = 91259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x000BADE4 File Offset: 0x000B8FE4
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000BAE24 File Offset: 0x000B9024
		public unsafe ParkingSpot CurrentParkingSpot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91259, XrefRangeEnd = 91260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x000BAE68 File Offset: 0x000B9068
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91260, XrefRangeEnd = 91265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x000BAEA0 File Offset: 0x000B90A0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91265, XrefRangeEnd = 91267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000BAED8 File Offset: 0x000B90D8
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x000BAF18 File Offset: 0x000B9118
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000BAF54 File Offset: 0x000B9154
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x000BAF94 File Offset: 0x000B9194
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 91267, RefRangeEnd = 91275, XrefRangeStart = 91267, XrefRangeEnd = 91267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91275, XrefRangeEnd = 91276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000BAFD8 File Offset: 0x000B91D8
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x000BB018 File Offset: 0x000B9218
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91276, XrefRangeEnd = 91277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000BB05C File Offset: 0x000B925C
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x000BB098 File Offset: 0x000B9298
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000BB0D8 File Offset: 0x000B92D8
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44652, RefRangeEnd = 44654, XrefRangeStart = 44652, XrefRangeEnd = 44654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000BB118 File Offset: 0x000B9318
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x000BB150 File Offset: 0x000B9350
		public unsafe virtual string WeatherVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91277, XrefRangeEnd = 91278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000BB194 File Offset: 0x000B9394
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x000BB1D0 File Offset: 0x000B93D0
		public unsafe virtual bool IsUnderCover
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000BB210 File Offset: 0x000B9410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91278, XrefRangeEnd = 91279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000BB24C File Offset: 0x000B944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91279, XrefRangeEnd = 91285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000BB288 File Offset: 0x000B9488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91285, XrefRangeEnd = 91290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000BB2C4 File Offset: 0x000B94C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91290, XrefRangeEnd = 91304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000BB314 File Offset: 0x000B9514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91304, XrefRangeEnd = 91306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000BB350 File Offset: 0x000B9550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91345, RefRangeEnd = 91348, XrefRangeStart = 91306, XrefRangeEnd = 91345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000BB3A0 File Offset: 0x000B95A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91358, RefRangeEnd = 91363, XrefRangeStart = 91348, XrefRangeEnd = 91358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000BB3D4 File Offset: 0x000B95D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91367, RefRangeEnd = 91368, XrefRangeStart = 91363, XrefRangeEnd = 91367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000BB414 File Offset: 0x000B9614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91368, XrefRangeEnd = 91460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000BB450 File Offset: 0x000B9650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91460, XrefRangeEnd = 91463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000BB494 File Offset: 0x000B9694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91463, XrefRangeEnd = 91505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000BB4D0 File Offset: 0x000B96D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91505, XrefRangeEnd = 91506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000BB514 File Offset: 0x000B9714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91506, XrefRangeEnd = 91530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000BB550 File Offset: 0x000B9750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91530, XrefRangeEnd = 91576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000BB58C File Offset: 0x000B978C
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000BB5C0 File Offset: 0x000B97C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91593, RefRangeEnd = 91594, XrefRangeStart = 91576, XrefRangeEnd = 91593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedCalculation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_UpdateSpeedCalculation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000BB5F4 File Offset: 0x000B97F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91619, RefRangeEnd = 91620, XrefRangeStart = 91594, XrefRangeEnd = 91619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutOfBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_UpdateOutOfBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000BB628 File Offset: 0x000B9828
		[CallerCount(0)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000BB66C File Offset: 0x000B986C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91620, XrefRangeEnd = 91630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000BB6BC File Offset: 0x000B98BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91630, XrefRangeEnd = 91639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOwnerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000BB6F8 File Offset: 0x000B98F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91641, RefRangeEnd = 91642, XrefRangeStart = 91639, XrefRangeEnd = 91641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000BB744 File Offset: 0x000B9944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 91649, RefRangeEnd = 91656, XrefRangeStart = 91642, XrefRangeEnd = 91649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000BB790 File Offset: 0x000B9990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91656, XrefRangeEnd = 91684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000BB7C4 File Offset: 0x000B99C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91684, XrefRangeEnd = 91690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000BB800 File Offset: 0x000B9A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91690, XrefRangeEnd = 91759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000BB83C File Offset: 0x000B9A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91759, XrefRangeEnd = 91762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDownForce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyDownForce_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000BB870 File Offset: 0x000B9A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91771, RefRangeEnd = 91772, XrefRangeStart = 91762, XrefRangeEnd = 91771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTurnOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_UpdateTurnOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000BB8A4 File Offset: 0x000B9AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91772, XrefRangeEnd = 91820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000BB8E0 File Offset: 0x000B9AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91820, XrefRangeEnd = 91830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteeringAngle(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000BB920 File Offset: 0x000B9B20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91851, RefRangeEnd = 91855, XrefRangeStart = 91830, XrefRangeEnd = 91851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsBraking(bool braking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref braking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsBraking_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000BB960 File Offset: 0x000B9B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91855, XrefRangeEnd = 91877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsBreaking_Server(bool braking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref braking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsBreaking_Server_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000BB9A0 File Offset: 0x000B9BA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91898, RefRangeEnd = 91902, XrefRangeStart = 91877, XrefRangeEnd = 91898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsReversing(bool reversing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reversing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsReversing_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000BB9E0 File Offset: 0x000B9BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91902, XrefRangeEnd = 91924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsReversing_Server(bool reversing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reversing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsReversing_Server_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000BBA20 File Offset: 0x000B9C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91924, XrefRangeEnd = 91926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplySteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000BBA5C File Offset: 0x000B9C5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 91945, RefRangeEnd = 91951, XrefRangeStart = 91926, XrefRangeEnd = 91945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000BBABC File Offset: 0x000B9CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91969, RefRangeEnd = 91971, XrefRangeStart = 91951, XrefRangeEnd = 91969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr3) : null;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000BBB1C File Offset: 0x000B9D1C
		[CallerCount(0)]
		public unsafe float GetVehicleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000BBB58 File Offset: 0x000B9D58
		[CallerCount(0)]
		public unsafe void OverrideMaxSteerAngle(float maxAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000BBB98 File Offset: 0x000B9D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91971, RefRangeEnd = 91972, XrefRangeStart = 91971, XrefRangeEnd = 91971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMaxSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000BBBCC File Offset: 0x000B9DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91977, RefRangeEnd = 91978, XrefRangeStart = 91972, XrefRangeEnd = 91977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObstaclesActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000BBC0C File Offset: 0x000B9E0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 92002, RefRangeEnd = 92008, XrefRangeStart = 91978, XrefRangeEnd = 92002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePhysicallySimulated(bool forceApply = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceApply;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_UpdatePhysicallySimulated_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000BBC4C File Offset: 0x000B9E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92025, RefRangeEnd = 92026, XrefRangeStart = 92008, XrefRangeEnd = 92025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBePhysicallySimulated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ShouldBePhysicallySimulated_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000BBC88 File Offset: 0x000B9E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92026, XrefRangeEnd = 92031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr3) : null;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000BBCC8 File Offset: 0x000B9EC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92074, RefRangeEnd = 92078, XrefRangeStart = 92031, XrefRangeEnd = 92074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92101, RefRangeEnd = 92103, XrefRangeStart = 92078, XrefRangeEnd = 92101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000BBD7C File Offset: 0x000B9F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92103, XrefRangeEnd = 92108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92108, XrefRangeEnd = 92110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000BBDE4 File Offset: 0x000B9FE4
		[CallerCount(0)]
		public unsafe void StartVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_StartVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000BBE18 File Offset: 0x000BA018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92113, RefRangeEnd = 92114, XrefRangeStart = 92110, XrefRangeEnd = 92113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_StopVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000BBE4C File Offset: 0x000BA04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92114, XrefRangeEnd = 92115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000BBE80 File Offset: 0x000BA080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92117, RefRangeEnd = 92119, XrefRangeStart = 92115, XrefRangeEnd = 92117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000BBEB4 File Offset: 0x000BA0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92119, XrefRangeEnd = 92164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnLocalPlayerEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000BBEE8 File Offset: 0x000BA0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92164, XrefRangeEnd = 92218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnLocalPlayerExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000BBF1C File Offset: 0x000BA11C
		[CallerCount(0)]
		public unsafe void EndJustExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000BBF50 File Offset: 0x000BA150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92223, RefRangeEnd = 92224, XrefRangeStart = 92218, XrefRangeEnd = 92223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetExitPoint(int seatIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000BBF9C File Offset: 0x000BA19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92224, XrefRangeEnd = 92240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetClosestExitPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000BBFE8 File Offset: 0x000BA1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92277, RefRangeEnd = 92278, XrefRangeStart = 92240, XrefRangeEnd = 92277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(possibleExitPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000BC038 File Offset: 0x000BA238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92309, RefRangeEnd = 92310, XrefRangeStart = 92278, XrefRangeEnd = 92309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000BC07C File Offset: 0x000BA27C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92341, RefRangeEnd = 92342, XrefRangeStart = 92310, XrefRangeEnd = 92341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000BC0C0 File Offset: 0x000BA2C0
		[CallerCount(0)]
		public unsafe virtual bool CanBeRecovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000BC108 File Offset: 0x000BA308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92342, XrefRangeEnd = 92358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000BC144 File Offset: 0x000BA344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92358, XrefRangeEnd = 92393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TeleportToNavMesh(bool resetVelocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetVelocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_TeleportToNavMesh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000BC184 File Offset: 0x000BA384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92414, RefRangeEnd = 92415, XrefRangeStart = 92393, XrefRangeEnd = 92414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOwnedColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000BC1C4 File Offset: 0x000BA3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92415, XrefRangeEnd = 92425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000BC220 File Offset: 0x000BA420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92426, RefRangeEnd = 92428, XrefRangeStart = 92425, XrefRangeEnd = 92426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000BC260 File Offset: 0x000BA460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92429, RefRangeEnd = 92430, XrefRangeStart = 92428, XrefRangeEnd = 92429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOwnedColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000BC294 File Offset: 0x000BA494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92469, RefRangeEnd = 92471, XrefRangeStart = 92430, XrefRangeEnd = 92469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000BC2E8 File Offset: 0x000BA4E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 92507, RefRangeEnd = 92518, XrefRangeStart = 92471, XrefRangeEnd = 92507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000BC34C File Offset: 0x000BA54C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92557, RefRangeEnd = 92560, XrefRangeStart = 92518, XrefRangeEnd = 92557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000BC39C File Offset: 0x000BA59C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 92583, RefRangeEnd = 92589, XrefRangeStart = 92560, XrefRangeEnd = 92583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark(bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000BC3DC File Offset: 0x000BA5DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92597, RefRangeEnd = 92601, XrefRangeStart = 92589, XrefRangeEnd = 92597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000BC41C File Offset: 0x000BA61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92601, XrefRangeEnd = 92607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPusher(PlayerPusher pusher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pusher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RegisterPusher_Public_Void_PlayerPusher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000BC460 File Offset: 0x000BA660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92607, XrefRangeEnd = 92611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterPusher(PlayerPusher pusher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pusher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DeregisterPusher_Public_Void_PlayerPusher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000BC4A4 File Offset: 0x000BA6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92611, XrefRangeEnd = 92625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000BC4E4 File Offset: 0x000BA6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92625, XrefRangeEnd = 92658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual VehicleData GetVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleData>(intPtr3) : null;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x000BC530 File Offset: 0x000BA730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92658, XrefRangeEnd = 92673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SpraySurfaceData> GetSpraySurfaceData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetSpraySurfaceData_Protected_List_1_SpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpraySurfaceData>>(intPtr3) : null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000BC570 File Offset: 0x000BA770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92673, XrefRangeEnd = 92674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000BC5A8 File Offset: 0x000BA7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92674, XrefRangeEnd = 92683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet GetContentsSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr3) : null;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000BC5E8 File Offset: 0x000BA7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92683, XrefRangeEnd = 92730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000BC648 File Offset: 0x000BA848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92730, XrefRangeEnd = 92745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnWeatherChange(WeatherConditions newConditions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newConditions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000BC68C File Offset: 0x000BA88C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateWeatherEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000BC6C0 File Offset: 0x000BA8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92868, RefRangeEnd = 92869, XrefRangeStart = 92745, XrefRangeEnd = 92868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000BC6FC File Offset: 0x000BA8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93017, RefRangeEnd = 93018, XrefRangeStart = 92869, XrefRangeEnd = 93017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000BC738 File Offset: 0x000BA938
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000BC774 File Offset: 0x000BA974
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000BC7B0 File Offset: 0x000BA9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93018, XrefRangeEnd = 93028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000BC800 File Offset: 0x000BAA00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93048, RefRangeEnd = 93051, XrefRangeStart = 93028, XrefRangeEnd = 93048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000BC850 File Offset: 0x000BAA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93051, XrefRangeEnd = 93054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000BC8A0 File Offset: 0x000BAAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93054, XrefRangeEnd = 93064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000BC8F0 File Offset: 0x000BAAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93064, XrefRangeEnd = 93067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000BC940 File Offset: 0x000BAB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000BC984 File Offset: 0x000BAB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93067, XrefRangeEnd = 93069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000BC9D4 File Offset: 0x000BABD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93069, XrefRangeEnd = 93072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000BCA38 File Offset: 0x000BAC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000BCA6C File Offset: 0x000BAC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93072, XrefRangeEnd = 93090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000BCAA8 File Offset: 0x000BACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93090, XrefRangeEnd = 93108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000BCAF8 File Offset: 0x000BACF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93132, RefRangeEnd = 93134, XrefRangeStart = 93108, XrefRangeEnd = 93132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000BCB44 File Offset: 0x000BAD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93134, XrefRangeEnd = 93135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000BCB90 File Offset: 0x000BAD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93135, XrefRangeEnd = 93143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000BCBF4 File Offset: 0x000BADF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93167, RefRangeEnd = 93168, XrefRangeStart = 93143, XrefRangeEnd = 93167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000BCC40 File Offset: 0x000BAE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93168, XrefRangeEnd = 93174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000BCC8C File Offset: 0x000BAE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93174, XrefRangeEnd = 93187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000BCCDC File Offset: 0x000BAEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000BCD1C File Offset: 0x000BAF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93187, XrefRangeEnd = 93188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000BCD5C File Offset: 0x000BAF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93188, XrefRangeEnd = 93191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000BCDC0 File Offset: 0x000BAFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93191, XrefRangeEnd = 93201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsBreaking_Server_1140765316(bool braking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref braking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetIsBreaking_Server_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000BCE00 File Offset: 0x000BB000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91233, RefRangeEnd = 91236, XrefRangeStart = 91233, XrefRangeEnd = 91236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsBreaking_Server_1140765316(bool braking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref braking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsBreaking_Server_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000BCE40 File Offset: 0x000BB040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93201, XrefRangeEnd = 93204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsBreaking_Server_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetIsBreaking_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000BCEA4 File Offset: 0x000BB0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93204, XrefRangeEnd = 93214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsReversing_Server_1140765316(bool reversing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reversing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetIsReversing_Server_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000BCEE4 File Offset: 0x000BB0E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91243, RefRangeEnd = 91246, XrefRangeStart = 91243, XrefRangeEnd = 91246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsReversing_Server_1140765316(bool reversing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reversing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsReversing_Server_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000BCF24 File Offset: 0x000BB124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93214, XrefRangeEnd = 93217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsReversing_Server_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetIsReversing_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000BCF88 File Offset: 0x000BB188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93217, XrefRangeEnd = 93229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000BCFEC File Offset: 0x000BB1EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93256, RefRangeEnd = 93259, XrefRangeStart = 93229, XrefRangeEnd = 93256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000BD050 File Offset: 0x000BB250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93259, XrefRangeEnd = 93265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000BD0A0 File Offset: 0x000BB2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93265, XrefRangeEnd = 93277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000BD104 File Offset: 0x000BB304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93277, XrefRangeEnd = 93283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000BD154 File Offset: 0x000BB354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93283, XrefRangeEnd = 93295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000BD1A4 File Offset: 0x000BB3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93295, XrefRangeEnd = 93296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000BD1F4 File Offset: 0x000BB3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93296, XrefRangeEnd = 93302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000BD258 File Offset: 0x000BB458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93302, XrefRangeEnd = 93312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000BD298 File Offset: 0x000BB498
		[CallerCount(0)]
		public unsafe void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000BD2D8 File Offset: 0x000BB4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93312, XrefRangeEnd = 93315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000BD33C File Offset: 0x000BB53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93315, XrefRangeEnd = 93325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000BD38C File Offset: 0x000BB58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93325, XrefRangeEnd = 93327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000BD3E8 File Offset: 0x000BB5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93327, XrefRangeEnd = 93331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000BD438 File Offset: 0x000BB638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93331, XrefRangeEnd = 93341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000BD488 File Offset: 0x000BB688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93341, XrefRangeEnd = 93345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000BD4D8 File Offset: 0x000BB6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93345, XrefRangeEnd = 93355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000BD52C File Offset: 0x000BB72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93355, XrefRangeEnd = 93356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000BD580 File Offset: 0x000BB780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93356, XrefRangeEnd = 93360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000BD5D0 File Offset: 0x000BB7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93360, XrefRangeEnd = 93370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000BD624 File Offset: 0x000BB824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93370, XrefRangeEnd = 93374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000BD674 File Offset: 0x000BB874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93374, XrefRangeEnd = 93384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93384, XrefRangeEnd = 93385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000BD714 File Offset: 0x000BB914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93385, XrefRangeEnd = 93388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000BD764 File Offset: 0x000BB964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93388, XrefRangeEnd = 93398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000BD7B4 File Offset: 0x000BB9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93398, XrefRangeEnd = 93401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000BD804 File Offset: 0x000BBA04
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000BD840 File Offset: 0x000BBA40
		public unsafe float SyncAccessor_<CurrentSteerAngle>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91212, RefRangeEnd = 91214, XrefRangeStart = 91212, XrefRangeEnd = 91214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__CurrentSteerAngle_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93401, XrefRangeEnd = 93409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__CurrentSteerAngle_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000BD88C File Offset: 0x000BBA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93409, XrefRangeEnd = 93411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000BD900 File Offset: 0x000BBB00
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000BD93C File Offset: 0x000BBB3C
		public unsafe bool SyncAccessor_<BrakesApplied>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__BrakesApplied_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93411, XrefRangeEnd = 93419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__BrakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000BD988 File Offset: 0x000BBB88
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000BD9C4 File Offset: 0x000BBBC4
		public unsafe bool SyncAccessor_<IsReversing>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__IsReversing_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93419, XrefRangeEnd = 93427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__IsReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000BDA10 File Offset: 0x000BBC10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93509, RefRangeEnd = 93511, XrefRangeStart = 93427, XrefRangeEnd = 93509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0000A4FE File Offset: 0x000086FE
		public LandVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000BDA4C File Offset: 0x000BBC4C
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x0000A507 File Offset: 0x00008707
		public unsafe static float KINEMATIC_THRESHOLD_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000BDA68 File Offset: 0x000BBC68
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0000A515 File Offset: 0x00008715
		public unsafe static float MAX_TURNOVER_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000BDA84 File Offset: 0x000BBC84
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000A523 File Offset: 0x00008723
		public unsafe static float TURNOVER_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000BDAA0 File Offset: 0x000BBCA0
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0000A531 File Offset: 0x00008731
		public unsafe static bool USE_WHEEL
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x000BDABC File Offset: 0x000BBCBC
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0000A53F File Offset: 0x0000873F
		public unsafe static float SPEED_DISPLAY_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x000BDAD8 File Offset: 0x000BBCD8
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x0000A54D File Offset: 0x0000874D
		public unsafe static float MaxImpactDamage
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MaxImpactDamage, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MaxImpactDamage, (void*)(&value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x000BDAF4 File Offset: 0x000BBCF4
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000A55B File Offset: 0x0000875B
		public unsafe static float MaxImpactDamageSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MaxImpactDamageSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MaxImpactDamageSpeed, (void*)(&value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000BDB10 File Offset: 0x000BBD10
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000A569 File Offset: 0x00008769
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x000BDB38 File Offset: 0x000BBD38
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000A584 File Offset: 0x00008784
		public unsafe string vehicleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x000BDB60 File Offset: 0x000BBD60
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0000A5A3 File Offset: 0x000087A3
		public unsafe string vehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x000BDB88 File Offset: 0x000BBD88
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x0000A5C2 File Offset: 0x000087C2
		public unsafe float vehiclePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice)) = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000BDBB0 File Offset: 0x000BBDB0
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x0000A5DD File Offset: 0x000087DD
		public unsafe bool _IsPlayerOwned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x000BDBD8 File Offset: 0x000BBDD8
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000BDC00 File Offset: 0x000BBE00
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x0000A613 File Offset: 0x00008813
		public unsafe bool UseHumanoidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider)) = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000BDC28 File Offset: 0x000BBE28
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x0000A62E File Offset: 0x0000882E
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000BDC50 File Offset: 0x000BBE50
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0000A649 File Offset: 0x00008849
		public unsafe bool SpawnAsPlayerOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned)) = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x000BDC78 File Offset: 0x000BBE78
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x0000A664 File Offset: 0x00008864
		public unsafe GameObject vehicleModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x000BDCA8 File Offset: 0x000BBEA8
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0000A683 File Offset: 0x00008883
		public unsafe Il2CppReferenceArray<WheelCollider> driveWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x000BDCD8 File Offset: 0x000BBED8
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000A6A2 File Offset: 0x000088A2
		public unsafe Il2CppReferenceArray<WheelCollider> steerWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x000BDD08 File Offset: 0x000BBF08
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000A6C1 File Offset: 0x000088C1
		public unsafe Il2CppReferenceArray<WheelCollider> handbrakeWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x000BDD38 File Offset: 0x000BBF38
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0000A6E0 File Offset: 0x000088E0
		public unsafe List<Wheel> wheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Wheel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x000BDD68 File Offset: 0x000BBF68
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000A6FF File Offset: 0x000088FF
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x000BDD98 File Offset: 0x000BBF98
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x0000A71E File Offset: 0x0000891E
		public unsafe List<Transform> exitPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000BDDC8 File Offset: 0x000BBFC8
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0000A73D File Offset: 0x0000893D
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x000BDDF8 File Offset: 0x000BBFF8
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0000A75C File Offset: 0x0000895C
		public unsafe VehicleColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x000BDE28 File Offset: 0x000BC028
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0000A77B File Offset: 0x0000897B
		public unsafe Il2CppReferenceArray<VehicleSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x000BDE58 File Offset: 0x000BC058
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000A79A File Offset: 0x0000899A
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x000BDE88 File Offset: 0x000BC088
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000A7B9 File Offset: 0x000089B9
		public unsafe VehicleAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x000BDEB8 File Offset: 0x000BC0B8
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x0000A7D8 File Offset: 0x000089D8
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000A7F7 File Offset: 0x000089F7
		public unsafe StorageDoorAnimation Trunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageDoorAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000BDF18 File Offset: 0x000BC118
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000A816 File Offset: 0x00008A16
		public unsafe NavMeshObstacle NavMeshObstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000BDF48 File Offset: 0x000BC148
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000A835 File Offset: 0x00008A35
		public unsafe NavmeshCut NavmeshCut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavmeshCut>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000BDF78 File Offset: 0x000BC178
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000A854 File Offset: 0x00008A54
		public unsafe VehicleHumanoidCollider HumanoidColliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleHumanoidCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000A873 File Offset: 0x00008A73
		public unsafe POI POI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000BDFD8 File Offset: 0x000BC1D8
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0000A892 File Offset: 0x00008A92
		public unsafe Il2CppReferenceArray<SpraySurface> _spraySurfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__spraySurfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpraySurface>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__spraySurfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000BE008 File Offset: 0x000BC208
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0000A8B1 File Offset: 0x00008AB1
		public unsafe List<PlayerPusher> pushers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_pushers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerPusher>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_pushers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x000BE038 File Offset: 0x000BC238
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public unsafe Transform centerOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x000BE068 File Offset: 0x000BC268
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x0000A8EF File Offset: 0x00008AEF
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x000BE098 File Offset: 0x000BC298
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000A90E File Offset: 0x00008B0E
		public unsafe VehicleLights lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x0000A92D File Offset: 0x00008B2D
		public unsafe float maxSteeringAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle)) = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x0000A948 File Offset: 0x00008B48
		public unsafe float steerRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000BE118 File Offset: 0x000BC318
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000A963 File Offset: 0x00008B63
		public unsafe bool flipSteer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000BE140 File Offset: 0x000BC340
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x0000A97E File Offset: 0x00008B7E
		public unsafe bool _MaxSteerAngleOverridden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000BE168 File Offset: 0x000BC368
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x0000A999 File Offset: 0x00008B99
		public unsafe float _OverriddenMaxSteerAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000BE190 File Offset: 0x000BC390
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		public unsafe AnimationCurve motorTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000BE1C0 File Offset: 0x000BC3C0
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000A9D3 File Offset: 0x00008BD3
		public unsafe float TopSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed)) = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x0000A9EE File Offset: 0x00008BEE
		public unsafe float diffGearing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x000BE210 File Offset: 0x000BC410
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0000AA09 File Offset: 0x00008C09
		public unsafe float handBrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce)) = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000BE238 File Offset: 0x000BC438
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x0000AA24 File Offset: 0x00008C24
		public unsafe AnimationCurve brakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000BE268 File Offset: 0x000BC468
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x0000AA43 File Offset: 0x00008C43
		public unsafe float BrakeForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BrakeForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BrakeForceMultiplier)) = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000BE290 File Offset: 0x000BC490
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x0000AA5E File Offset: 0x00008C5E
		public unsafe float downforce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce)) = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000BE2B8 File Offset: 0x000BC4B8
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0000AA79 File Offset: 0x00008C79
		public unsafe float reverseMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier)) = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000BE2E0 File Offset: 0x000BC4E0
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x0000AA94 File Offset: 0x00008C94
		public unsafe bool overrideControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls)) = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000BE308 File Offset: 0x000BC508
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x0000AAAF File Offset: 0x00008CAF
		public unsafe float throttleOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride)) = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000BE330 File Offset: 0x000BC530
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0000AACA File Offset: 0x00008CCA
		public unsafe float steerOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride)) = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000BE358 File Offset: 0x000BC558
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0000AAE5 File Offset: 0x00008CE5
		public unsafe bool handbrakeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeOverride)) = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000BE380 File Offset: 0x000BC580
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0000AB00 File Offset: 0x00008D00
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x000BE3B0 File Offset: 0x000BC5B0
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0000AB1F File Offset: 0x00008D1F
		public unsafe VehicleSeat localPlayerSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x000BE3E0 File Offset: 0x000BC5E0
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0000AB3E File Offset: 0x00008D3E
		public unsafe bool _LocalPlayerIsDriver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalPlayerIsDriver_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalPlayerIsDriver_k__BackingField)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x000BE408 File Offset: 0x000BC608
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000AB59 File Offset: 0x00008D59
		public unsafe bool _LocalPlayerIsInVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalPlayerIsInVehicle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalPlayerIsInVehicle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000BE430 File Offset: 0x000BC630
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0000AB74 File Offset: 0x00008D74
		public unsafe bool _isOccupied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied)) = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x000BE458 File Offset: 0x000BC658
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0000AB8F File Offset: 0x00008D8F
		public unsafe Il2CppReferenceArray<NPC> _OccupantNPCs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x000BE488 File Offset: 0x000BC688
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0000ABAE File Offset: 0x00008DAE
		public unsafe bool _localPlayerJustEntered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerJustEntered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerJustEntered)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x000BE4B0 File Offset: 0x000BC6B0
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000ABC9 File Offset: 0x00008DC9
		public unsafe float _Speed_Kmh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__Speed_Kmh_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__Speed_Kmh_k__BackingField)) = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000BE4D8 File Offset: 0x000BC6D8
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public unsafe bool _IsPhysicallySimulated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPhysicallySimulated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPhysicallySimulated_k__BackingField)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x000BE500 File Offset: 0x000BC700
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0000ABFF File Offset: 0x00008DFF
		public unsafe RollingAverage<float> previousSpeeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RollingAverage<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x000BE530 File Offset: 0x000BC730
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x0000AC1E File Offset: 0x00008E1E
		public unsafe static int previousSpeedsSampleSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize, (void*)(&value));
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x000BE54C File Offset: 0x000BC74C
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x0000AC2C File Offset: 0x00008E2C
		public unsafe float _currentThrottle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x000BE574 File Offset: 0x000BC774
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0000AC47 File Offset: 0x00008E47
		public unsafe float _CurrentSteerAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentSteerAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentSteerAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000BE59C File Offset: 0x000BC79C
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0000AC62 File Offset: 0x00008E62
		public unsafe float lastFrameSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle)) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000BE5C4 File Offset: 0x000BC7C4
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0000AC7D File Offset: 0x00008E7D
		public unsafe float lastReplicatedSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle)) = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000BE5EC File Offset: 0x000BC7EC
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000AC98 File Offset: 0x00008E98
		public unsafe bool justExitedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle)) = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x000BE614 File Offset: 0x000BC814
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000ACB3 File Offset: 0x00008EB3
		public unsafe bool _BrakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__BrakesApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__BrakesApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x000BE63C File Offset: 0x000BC83C
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0000ACCE File Offset: 0x00008ECE
		public unsafe bool _IsReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsReversing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsReversing_k__BackingField)) = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000BE664 File Offset: 0x000BC864
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000ACE9 File Offset: 0x00008EE9
		public unsafe bool _HandbrakeApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HandbrakeApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HandbrakeApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x000BE68C File Offset: 0x000BC88C
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x0000AD04 File Offset: 0x00008F04
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x000BE6B4 File Offset: 0x000BC8B4
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x0000AD1F File Offset: 0x00008F1F
		public unsafe Transform closestExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000BE6E4 File Offset: 0x000BC8E4
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0000AD3E File Offset: 0x00008F3E
		public unsafe float timeOnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_timeOnSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_timeOnSpawn)) = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x000BE70C File Offset: 0x000BC90C
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0000AD59 File Offset: 0x00008F59
		public unsafe float timeOnLastOccupied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_timeOnLastOccupied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_timeOnLastOccupied)) = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000BE734 File Offset: 0x000BC934
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0000AD74 File Offset: 0x00008F74
		public unsafe EVehicleColor _OwnedColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x000BE75C File Offset: 0x000BC95C
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0000AD8F File Offset: 0x00008F8F
		public unsafe MonoState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000BE78C File Offset: 0x000BC98C
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public unsafe ParkData CurrentParkData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000BE7BC File Offset: 0x000BC9BC
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0000ADCD File Offset: 0x00008FCD
		public unsafe ParkingLot _CurrentParkingLot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x000BE7EC File Offset: 0x000BC9EC
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public unsafe ParkingSpot _CurrentParkingSpot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000BE81C File Offset: 0x000BCA1C
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x0000AE0B File Offset: 0x0000900B
		public unsafe VehicleLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000BE84C File Offset: 0x000BCA4C
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0000AE2A File Offset: 0x0000902A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x000BE87C File Offset: 0x000BCA7C
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0000AE49 File Offset: 0x00009049
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000BE8AC File Offset: 0x000BCAAC
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000AE68 File Offset: 0x00009068
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000BE8D4 File Offset: 0x000BCAD4
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0000AE83 File Offset: 0x00009083
		public unsafe Action onVehicleStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000BE904 File Offset: 0x000BCB04
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0000AEA2 File Offset: 0x000090A2
		public unsafe Action onVehicleStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x000BE934 File Offset: 0x000BCB34
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0000AEC1 File Offset: 0x000090C1
		public unsafe Action onHandbrakeApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000BE964 File Offset: 0x000BCB64
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000AEE0 File Offset: 0x000090E0
		public unsafe Action<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x000BE994 File Offset: 0x000BCB94
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000AEFF File Offset: 0x000090FF
		public unsafe string _ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000BE9BC File Offset: 0x000BCBBC
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000AF1E File Offset: 0x0000911E
		public unsafe bool _IsUnderCover_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsUnderCover_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsUnderCover_k__BackingField)) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000BE9E4 File Offset: 0x000BCBE4
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000AF39 File Offset: 0x00009139
		public unsafe SyncVar<float> syncVar____CurrentSteerAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____CurrentSteerAngle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____CurrentSteerAngle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000BEA14 File Offset: 0x000BCC14
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0000AF58 File Offset: 0x00009158
		public unsafe SyncVar<bool> syncVar____BrakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____BrakesApplied_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____BrakesApplied_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000BEA44 File Offset: 0x000BCC44
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000AF77 File Offset: 0x00009177
		public unsafe SyncVar<bool> syncVar____IsReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____IsReversing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____IsReversing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000BEA74 File Offset: 0x000BCC74
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0000AF96 File Offset: 0x00009196
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000BEA9C File Offset: 0x000BCC9C
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0000AFB1 File Offset: 0x000091B1
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TURNOVER_SPEED;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_TURNOVER_FORCE;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_USE_WHEEL;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_MaxImpactDamage;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_MaxImpactDamageSpeed;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_vehicleName;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePrice;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr__IsPlayerOwned_k__BackingField;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_UseHumanoidCollider;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_SpawnAsPlayerOwned;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeFieldInfoPtr_vehicleModel;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr_driveWheels;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr_steerWheels;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr_handbrakeWheels;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_exitPoints;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr_Trunk;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr_NavMeshObstacle;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_NavmeshCut;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_HumanoidColliderContainer;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_POI;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr__spraySurfaces;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_pushers;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_centerOfMass;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_maxSteeringAngle;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_steerRate;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_flipSteer;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_motorTorque;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr_diffGearing;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_handBrakeForce;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_brakeForce;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_BrakeForceMultiplier;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_downforce;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_reverseMultiplier;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_overrideControls;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_throttleOverride;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_steerOverride;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_handbrakeOverride;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerSeat;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerIsDriver_k__BackingField;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerIsInVehicle_k__BackingField;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr__isOccupied;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr__OccupantNPCs_k__BackingField;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeFieldInfoPtr__localPlayerJustEntered;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeFieldInfoPtr__Speed_Kmh_k__BackingField;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeFieldInfoPtr__IsPhysicallySimulated_k__BackingField;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeeds;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeedsSampleSize;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr__currentThrottle_k__BackingField;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSteerAngle_k__BackingField;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameSteerAngle;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_lastReplicatedSteerAngle;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_justExitedVehicle;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr__BrakesApplied_k__BackingField;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr__IsReversing_k__BackingField;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr__HandbrakeApplied_k__BackingField;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_closestExitPoint;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_timeOnSpawn;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastOccupied;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr__OwnedColor_k__BackingField;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_CurrentParkData;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingLot_k__BackingField;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStart;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStop;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_onHandbrakeApplied;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleOne_Core_Weather_IWeatherEntity_WeatherVolume_k__BackingField;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr__IsUnderCover_k__BackingField;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentSteerAngle_k__BackingField;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____BrakesApplied_k__BackingField;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IsReversing_k__BackingField;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleName_Public_get_String_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_MonoState_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_get_BoundingBoxDimensions_Public_get_Vector3_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerIsDriver_Public_get_Boolean_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerIsDriver_Protected_set_Void_Boolean_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerIsInVehicle_Public_get_Boolean_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerIsInVehicle_Protected_set_Void_Boolean_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOccupied_Public_set_Void_Boolean_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Kmh_Public_get_Single_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Kmh_Protected_set_Void_Single_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPhysicallySimulated_Public_get_Boolean_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPhysicallySimulated_Protected_set_Void_Boolean_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSteerAngle_Public_get_Single_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSteerAngle_Public_set_Void_Single_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_get_BrakesApplied_Public_get_Boolean_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_set_BrakesApplied_Public_set_Void_Boolean_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReversing_Public_set_Void_Boolean_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_get_HandbrakeApplied_Public_get_Boolean_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_set_HandbrakeApplied_Protected_set_Void_Boolean_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceSpawn_Private_get_Single_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastOccupied_Public_get_Single_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_Transform_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_get_WeatherVolume_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IWeatherEntity_set_WeatherVolume_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnderCover_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnderCover_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPoI_Private_Void_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedCalculation_Private_Void_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutOfBounds_Private_Void_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVehicle_Public_Void_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDownForce_Private_Void_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTurnOver_Private_Void_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_SetIsBraking_Private_Void_Boolean_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_SetIsBreaking_Server_Private_Void_Boolean_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_SetIsReversing_Private_Void_Boolean_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_SetIsReversing_Server_Private_Void_Boolean_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_GetVehicleValue_Public_Single_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePhysicallySimulated_Private_Void_Boolean_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBePhysicallySimulated_Private_Boolean_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_StartVehicle_Private_Void_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_StopVehicle_Private_Void_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerEnter_Private_Void_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerExit_Private_Void_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_EndJustExited_Private_Void_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_TeleportToNavMesh_Public_Void_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Void_EVehicleColor_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPusher_Public_Void_PlayerPusher_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterPusher_Public_Void_PlayerPusher_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_GetSpraySurfaceData_Protected_List_1_SpraySurfaceData_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_OnWeatherChange_Public_Virtual_Final_New_Void_WeatherConditions_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateWeatherEntity_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsBreaking_Server_1140765316_Private_Void_Boolean_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsBreaking_Server_1140765316_Private_Void_Boolean_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsBreaking_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsReversing_Server_1140765316_Private_Void_Boolean_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsReversing_Server_1140765316_Private_Void_Boolean_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsReversing_Server_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentSteerAngle_k__BackingField_Public_get_Single_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentSteerAngle_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__BrakesApplied_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__BrakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IsReversing_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IsReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200091D RID: 2333
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D71D RID: 55069 RVA: 0x00358CC0 File Offset: 0x00356EC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr);
				LandVehicle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9");
				LandVehicle.__c.NativeFieldInfoPtr___9__89_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__89_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__106_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__106_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__106_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__106_1");
				LandVehicle.__c.NativeFieldInfoPtr___9__249_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__249_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__263_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__263_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__264_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__264_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__287_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__287_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__287_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__287_1");
				LandVehicle.__c.NativeFieldInfoPtr___9__287_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__287_2");
				LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666188);
				LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__89_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666189);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__106_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666190);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__106_1_Internal_Player_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666191);
				LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__249_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666192);
				LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__263_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666193);
				LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__264_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666194);
				LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_0_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666195);
				LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_1_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666196);
				LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_2_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100666197);
			}

			// Token: 0x0600D71E RID: 55070 RVA: 0x00358E7C File Offset: 0x0035707C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x00358EB8 File Offset: 0x003570B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91090, XrefRangeEnd = 91095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerOccupancy_b__89_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__89_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D720 RID: 55072 RVA: 0x00358F08 File Offset: 0x00357108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_OccupantPlayers_b__106_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__106_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x00358F58 File Offset: 0x00357158
			[CallerCount(0)]
			public unsafe Player _get_OccupantPlayers_b__106_1(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__106_1_Internal_Player_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}

			// Token: 0x0600D722 RID: 55074 RVA: 0x00358FA8 File Offset: 0x003571A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSeatOccupant_b__249_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__249_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x00358FF8 File Offset: 0x003571F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91095, XrefRangeEnd = 91099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddNPCOccupant_b__263_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__263_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D724 RID: 55076 RVA: 0x00359048 File Offset: 0x00357248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91099, XrefRangeEnd = 91103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNPCOccupant_b__264_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__264_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D725 RID: 55077 RVA: 0x00359098 File Offset: 0x00357298
			[CallerCount(0)]
			public unsafe float __ctor_b__287_0(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_0_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D726 RID: 55078 RVA: 0x003590F0 File Offset: 0x003572F0
			[CallerCount(0)]
			public unsafe float __ctor_b__287_1(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_1_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D727 RID: 55079 RVA: 0x00359148 File Offset: 0x00357348
			[CallerCount(0)]
			public unsafe float __ctor_b__287_2(float a, float c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr___ctor_b__287_2_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D728 RID: 55080 RVA: 0x00065143 File Offset: 0x00063343
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B2 RID: 16818
			// (get) Token: 0x0600D729 RID: 55081 RVA: 0x003591A0 File Offset: 0x003573A0
			// (set) Token: 0x0600D72A RID: 55082 RVA: 0x0006514C File Offset: 0x0006334C
			public unsafe static LandVehicle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B3 RID: 16819
			// (get) Token: 0x0600D72B RID: 55083 RVA: 0x003591C8 File Offset: 0x003573C8
			// (set) Token: 0x0600D72C RID: 55084 RVA: 0x0006515E File Offset: 0x0006335E
			public unsafe static Func<VehicleSeat, bool> __9__89_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__89_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__89_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0600D72D RID: 55085 RVA: 0x003591F0 File Offset: 0x003573F0
			// (set) Token: 0x0600D72E RID: 55086 RVA: 0x00065170 File Offset: 0x00063370
			public unsafe static Func<VehicleSeat, bool> __9__106_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__106_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__106_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B5 RID: 16821
			// (get) Token: 0x0600D72F RID: 55087 RVA: 0x00359218 File Offset: 0x00357418
			// (set) Token: 0x0600D730 RID: 55088 RVA: 0x00065182 File Offset: 0x00063382
			public unsafe static Func<VehicleSeat, Player> __9__106_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__106_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, Player>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__106_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0600D731 RID: 55089 RVA: 0x00359240 File Offset: 0x00357440
			// (set) Token: 0x0600D732 RID: 55090 RVA: 0x00065194 File Offset: 0x00063394
			public unsafe static Func<VehicleSeat, bool> __9__249_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__249_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__249_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B7 RID: 16823
			// (get) Token: 0x0600D733 RID: 55091 RVA: 0x00359268 File Offset: 0x00357468
			// (set) Token: 0x0600D734 RID: 55092 RVA: 0x000651A6 File Offset: 0x000633A6
			public unsafe static Func<NPC, bool> __9__263_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__263_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__263_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B8 RID: 16824
			// (get) Token: 0x0600D735 RID: 55093 RVA: 0x00359290 File Offset: 0x00357490
			// (set) Token: 0x0600D736 RID: 55094 RVA: 0x000651B8 File Offset: 0x000633B8
			public unsafe static Func<NPC, bool> __9__264_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__264_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__264_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0600D737 RID: 55095 RVA: 0x003592B8 File Offset: 0x003574B8
			// (set) Token: 0x0600D738 RID: 55096 RVA: 0x000651CA File Offset: 0x000633CA
			public unsafe static Func<float, float, float> __9__287_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BA RID: 16826
			// (get) Token: 0x0600D739 RID: 55097 RVA: 0x003592E0 File Offset: 0x003574E0
			// (set) Token: 0x0600D73A RID: 55098 RVA: 0x000651DC File Offset: 0x000633DC
			public unsafe static Func<float, float, float> __9__287_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BB RID: 16827
			// (get) Token: 0x0600D73B RID: 55099 RVA: 0x00359308 File Offset: 0x00357508
			// (set) Token: 0x0600D73C RID: 55100 RVA: 0x000651EE File Offset: 0x000633EE
			public unsafe static Func<float, float, float> __9__287_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__287_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092A7 RID: 37543
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092A8 RID: 37544
			private static readonly IntPtr NativeFieldInfoPtr___9__89_0;

			// Token: 0x040092A9 RID: 37545
			private static readonly IntPtr NativeFieldInfoPtr___9__106_0;

			// Token: 0x040092AA RID: 37546
			private static readonly IntPtr NativeFieldInfoPtr___9__106_1;

			// Token: 0x040092AB RID: 37547
			private static readonly IntPtr NativeFieldInfoPtr___9__249_0;

			// Token: 0x040092AC RID: 37548
			private static readonly IntPtr NativeFieldInfoPtr___9__263_0;

			// Token: 0x040092AD RID: 37549
			private static readonly IntPtr NativeFieldInfoPtr___9__264_0;

			// Token: 0x040092AE RID: 37550
			private static readonly IntPtr NativeFieldInfoPtr___9__287_0;

			// Token: 0x040092AF RID: 37551
			private static readonly IntPtr NativeFieldInfoPtr___9__287_1;

			// Token: 0x040092B0 RID: 37552
			private static readonly IntPtr NativeFieldInfoPtr___9__287_2;

			// Token: 0x040092B1 RID: 37553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B2 RID: 37554
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__89_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x040092B3 RID: 37555
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__106_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x040092B4 RID: 37556
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__106_1_Internal_Player_VehicleSeat_0;

			// Token: 0x040092B5 RID: 37557
			private static readonly IntPtr NativeMethodInfoPtr__SetSeatOccupant_b__249_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x040092B6 RID: 37558
			private static readonly IntPtr NativeMethodInfoPtr__AddNPCOccupant_b__263_0_Internal_Boolean_NPC_0;

			// Token: 0x040092B7 RID: 37559
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNPCOccupant_b__264_0_Internal_Boolean_NPC_0;

			// Token: 0x040092B8 RID: 37560
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__287_0_Internal_Single_Single_Single_0;

			// Token: 0x040092B9 RID: 37561
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__287_1_Internal_Single_Single_Single_0;

			// Token: 0x040092BA RID: 37562
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__287_2_Internal_Single_Single_Single_0;
		}
	}
}
