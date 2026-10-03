using System;
using Il2Cpp;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D4 RID: 1748
	public class EnvironmentManager : NetworkSingleton<EnvironmentManager>
	{
		// Token: 0x0600A7DA RID: 42970 RVA: 0x002C7A04 File Offset: 0x002C5C04
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentManager()
		{
			Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "EnvironmentManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr);
			EnvironmentManager.NativeFieldInfoPtr_UpdateWeatherEntitiesTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "UpdateWeatherEntitiesTickRate");
			EnvironmentManager.NativeFieldInfoPtr__playerObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_playerObj");
			EnvironmentManager.NativeFieldInfoPtr__dayNightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_dayNightController");
			EnvironmentManager.NativeFieldInfoPtr__maskController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_maskController");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumePrefab");
			EnvironmentManager.NativeFieldInfoPtr__weatherBoundsAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherBoundsAnchor");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumeContainer");
			EnvironmentManager.NativeFieldInfoPtr__weatherSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherSequences");
			EnvironmentManager.NativeFieldInfoPtr__dailyWeatherSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_dailyWeatherSequences");
			EnvironmentManager.NativeFieldInfoPtr__weatherProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherProfiles");
			EnvironmentManager.NativeFieldInfoPtr__defaultWeatherVolumeMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_defaultWeatherVolumeMoveSpeed");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumeCount");
			EnvironmentManager.NativeFieldInfoPtr__weatherBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherBounds");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBlendSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumeBlendSize");
			EnvironmentManager.NativeFieldInfoPtr__blendCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_blendCurve");
			EnvironmentManager.NativeFieldInfoPtr__lensFlareSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_lensFlareSettings");
			EnvironmentManager.NativeFieldInfoPtr__windChangeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windChangeSpeed");
			EnvironmentManager.NativeFieldInfoPtr__minMaxWindChangeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_minMaxWindChangeInterval");
			EnvironmentManager.NativeFieldInfoPtr__windChangeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windChangeAngle");
			EnvironmentManager.NativeFieldInfoPtr__minMaxWindShiftInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_minMaxWindShiftInterval");
			EnvironmentManager.NativeFieldInfoPtr__windShiftAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windShiftAngle");
			EnvironmentManager.NativeFieldInfoPtr__rendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_rendererData");
			EnvironmentManager.NativeFieldInfoPtr__debugControlWeatherSpeedWithSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_debugControlWeatherSpeedWithSlider");
			EnvironmentManager.NativeFieldInfoPtr__debugWeatherSliderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_debugWeatherSliderValue");
			EnvironmentManager.NativeFieldInfoPtr__weatherEnclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherEnclosures");
			EnvironmentManager.NativeFieldInfoPtr__overrideEnclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_overrideEnclosures");
			EnvironmentManager.NativeFieldInfoPtr__activeWeatherVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_activeWeatherVolumes");
			EnvironmentManager.NativeFieldInfoPtr__currentWeatherSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_currentWeatherSequence");
			EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_targetWeatherVolume");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumeBounds");
			EnvironmentManager.NativeFieldInfoPtr__weatherBoundsCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherBoundsCenter");
			EnvironmentManager.NativeFieldInfoPtr__skyOverrideSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_skyOverrideSettings");
			EnvironmentManager.NativeFieldInfoPtr__blendAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_blendAmount");
			EnvironmentManager.NativeFieldInfoPtr__skyOverrideBlendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_skyOverrideBlendValue");
			EnvironmentManager.NativeFieldInfoPtr__doWeatherBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_doWeatherBlending");
			EnvironmentManager.NativeFieldInfoPtr__hasWeatherVolumeNeighbour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_hasWeatherVolumeNeighbour");
			EnvironmentManager.NativeFieldInfoPtr__withinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_withinBounds");
			EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolumeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_targetWeatherVolumeIndex");
			EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherVolumeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_neighbourWeatherVolumeIndex");
			EnvironmentManager.NativeFieldInfoPtr__targetWeatherBlendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_targetWeatherBlendValue");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumeMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumeMoveSpeed");
			EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherBlendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_neighbourWeatherBlendValue");
			EnvironmentManager.NativeFieldInfoPtr__closestPointInTargetVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_closestPointInTargetVolume");
			EnvironmentManager.NativeFieldInfoPtr__closestPointInNeighbourVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_closestPointInNeighbourVolume");
			EnvironmentManager.NativeFieldInfoPtr__sequenceVolumeStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_sequenceVolumeStartIndex");
			EnvironmentManager.NativeFieldInfoPtr__weatherVolumePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_weatherVolumePositions");
			EnvironmentManager.NativeFieldInfoPtr__windVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windVelocity");
			EnvironmentManager.NativeFieldInfoPtr__targetWindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_targetWindDirection");
			EnvironmentManager.NativeFieldInfoPtr__currentWindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_currentWindDirection");
			EnvironmentManager.NativeFieldInfoPtr__windChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windChangeTime");
			EnvironmentManager.NativeFieldInfoPtr__windShiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windShiftTime");
			EnvironmentManager.NativeFieldInfoPtr__windShiftTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windShiftTimer");
			EnvironmentManager.NativeFieldInfoPtr__windChangeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_windChangeTimer");
			EnvironmentManager.NativeFieldInfoPtr__currentWeatherConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_currentWeatherConditions");
			EnvironmentManager.NativeFieldInfoPtr__currentSkyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_currentSkyState");
			EnvironmentManager.NativeFieldInfoPtr__fogFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_fogFeature");
			EnvironmentManager.NativeFieldInfoPtr__registeredWeatherEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "_registeredWeatherEntities");
			EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Weather.EnvironmentManagerAssembly-CSharp.dll_Excuted");
			EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Weather.EnvironmentManagerAssembly-CSharp.dll_Excuted");
			EnvironmentManager.NativeMethodInfoPtr_get_Player_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685577);
			EnvironmentManager.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IEnvironmentManager_get_SkyState_Private_Virtual_Final_New_get_SkyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685578);
			EnvironmentManager.NativeMethodInfoPtr_get_WeatherSequences_Public_get_List_1_WeatherSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685579);
			EnvironmentManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685580);
			EnvironmentManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685581);
			EnvironmentManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685582);
			EnvironmentManager.NativeMethodInfoPtr_SetupHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685583);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseFog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685584);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseSky_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685585);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseWind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685586);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseWeather_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685587);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseGlobalVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685588);
			EnvironmentManager.NativeMethodInfoPtr_SetupEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685589);
			EnvironmentManager.NativeMethodInfoPtr_InitialiseControllers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685590);
			EnvironmentManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685591);
			EnvironmentManager.NativeMethodInfoPtr_CreateWeatherVolumesAtStartIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685592);
			EnvironmentManager.NativeMethodInfoPtr_CreateVolume_Private_Void_WeatherProfile_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685593);
			EnvironmentManager.NativeMethodInfoPtr_DetermineWeatherVolumeWithTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685594);
			EnvironmentManager.NativeMethodInfoPtr_CalculateWeatherBlendsFromVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685595);
			EnvironmentManager.NativeMethodInfoPtr_BlendWeatherProfiles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685596);
			EnvironmentManager.NativeMethodInfoPtr_CreateWeatherVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685597);
			EnvironmentManager.NativeMethodInfoPtr_MoveWeatherVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685598);
			EnvironmentManager.NativeMethodInfoPtr_UpdateWind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685599);
			EnvironmentManager.NativeMethodInfoPtr_ChangeWindDirection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685600);
			EnvironmentManager.NativeMethodInfoPtr_ShiftWindDirection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685601);
			EnvironmentManager.NativeMethodInfoPtr_GetNewWindDirection_Public_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685602);
			EnvironmentManager.NativeMethodInfoPtr_UpdateVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685603);
			EnvironmentManager.NativeMethodInfoPtr_UpdateWeather_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685604);
			EnvironmentManager.NativeMethodInfoPtr_UpdateWeatherEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685605);
			EnvironmentManager.NativeMethodInfoPtr_SetLensFlare_Private_Void_LensFlareDataSRP_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685606);
			EnvironmentManager.NativeMethodInfoPtr_ClearWeather_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685607);
			EnvironmentManager.NativeMethodInfoPtr_SetRandomWeatherSequence_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685608);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherProfileFromPosition_Protected_WeatherProfile_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685609);
			EnvironmentManager.NativeMethodInfoPtr_GetActiveWeatherConditionsFromPosition_Private_WeatherConditions_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685610);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherVolumeBounds_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685611);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherVolumeInitialPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685612);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherBoundsCenter_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685613);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherAnchor_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685614);
			EnvironmentManager.NativeMethodInfoPtr_GetPlayer_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685615);
			EnvironmentManager.NativeMethodInfoPtr_IsPositionUnderCover_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685616);
			EnvironmentManager.NativeMethodInfoPtr_GetWrappedIndex_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685617);
			EnvironmentManager.NativeMethodInfoPtr_GetWeatherProfile_Public_WeatherProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685618);
			EnvironmentManager.NativeMethodInfoPtr_OnMinutePass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685619);
			EnvironmentManager.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685620);
			EnvironmentManager.NativeMethodInfoPtr_OnTimeSet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685621);
			EnvironmentManager.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685622);
			EnvironmentManager.NativeMethodInfoPtr_SetWeather_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685623);
			EnvironmentManager.NativeMethodInfoPtr_OnWeatherEntityRegistered_Public_Void_IWeatherEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685624);
			EnvironmentManager.NativeMethodInfoPtr_OnWeatherEntityUnregistered_Public_Void_IWeatherEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685625);
			EnvironmentManager.NativeMethodInfoPtr_OnEnclosureRegistered_Public_Void_WorldEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685626);
			EnvironmentManager.NativeMethodInfoPtr_RegisterEnclosure_Private_Void_WorldEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685627);
			EnvironmentManager.NativeMethodInfoPtr_RegisterWeatherEnclosure_Private_Void_WeatherEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685628);
			EnvironmentManager.NativeMethodInfoPtr_RegisterOverrideEnclosure_Private_Void_SkyOverrideEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685629);
			EnvironmentManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685630);
			EnvironmentManager.NativeMethodInfoPtr_SetWeatherSequence_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685631);
			EnvironmentManager.NativeMethodInfoPtr_TriggerLightningEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685632);
			EnvironmentManager.NativeMethodInfoPtr_TriggerTargetedLightningEvent_Public_Virtual_Final_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685633);
			EnvironmentManager.NativeMethodInfoPtr_TriggerDistantThunder_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685634);
			EnvironmentManager.NativeMethodInfoPtr_GetActiveThunderController_Private_ThunderController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685635);
			EnvironmentManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685636);
			EnvironmentManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685637);
			EnvironmentManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685638);
			EnvironmentManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685639);
			EnvironmentManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, 100685640);
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A7DB RID: 42971 RVA: 0x002C83D0 File Offset: 0x002C65D0
		public unsafe Transform Player
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 291397, RefRangeEnd = 291409, XrefRangeStart = 291390, XrefRangeEnd = 291397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_get_Player_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A7DC RID: 42972 RVA: 0x002C8410 File Offset: 0x002C6610
		public unsafe virtual SkyState SkyState
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 228649, RefRangeEnd = 228651, XrefRangeStart = 228649, XrefRangeEnd = 228651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_ScheduleOne_Core_Weather_IEnvironmentManager_get_SkyState_Private_Virtual_Final_New_get_SkyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyState>(intPtr3) : null;
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x002C8450 File Offset: 0x002C6650
		public unsafe List<WeatherSequence> WeatherSequences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_get_WeatherSequences_Public_get_List_1_WeatherSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WeatherSequence>>(intPtr3) : null;
			}
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002C8490 File Offset: 0x002C6690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291409, XrefRangeEnd = 291445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002C84CC File Offset: 0x002C66CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291445, XrefRangeEnd = 291469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002C8508 File Offset: 0x002C6708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291469, XrefRangeEnd = 291471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x002C8544 File Offset: 0x002C6744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291471, XrefRangeEnd = 291492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetupHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002C8578 File Offset: 0x002C6778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291519, RefRangeEnd = 291521, XrefRangeStart = 291492, XrefRangeEnd = 291519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseFog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseFog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002C85AC File Offset: 0x002C67AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291576, RefRangeEnd = 291578, XrefRangeStart = 291521, XrefRangeEnd = 291576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseSky()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseSky_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x002C85E0 File Offset: 0x002C67E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291578, XrefRangeEnd = 291583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseWind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseWind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002C8614 File Offset: 0x002C6814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291595, RefRangeEnd = 291597, XrefRangeStart = 291583, XrefRangeEnd = 291595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseWeather()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseWeather_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x002C8648 File Offset: 0x002C6848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291597, XrefRangeEnd = 291606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseGlobalVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseGlobalVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x002C867C File Offset: 0x002C687C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291606, XrefRangeEnd = 291618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetupEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x002C86B0 File Offset: 0x002C68B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291618, XrefRangeEnd = 291621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseControllers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_InitialiseControllers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x002C86E4 File Offset: 0x002C68E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291621, XrefRangeEnd = 291669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x002C8718 File Offset: 0x002C6918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291678, RefRangeEnd = 291679, XrefRangeStart = 291669, XrefRangeEnd = 291678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateWeatherVolumesAtStartIndex(int sequenceVolumeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sequenceVolumeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_CreateWeatherVolumesAtStartIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x002C8758 File Offset: 0x002C6958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291695, RefRangeEnd = 291697, XrefRangeStart = 291679, XrefRangeEnd = 291695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateVolume(WeatherProfile profile, Vector3 position, int insertIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_CreateVolume_Private_Void_WeatherProfile_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x002C87B8 File Offset: 0x002C69B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291716, RefRangeEnd = 291717, XrefRangeStart = 291697, XrefRangeEnd = 291716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetermineWeatherVolumeWithTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_DetermineWeatherVolumeWithTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x002C87EC File Offset: 0x002C69EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291749, RefRangeEnd = 291750, XrefRangeStart = 291717, XrefRangeEnd = 291749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateWeatherBlendsFromVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_CalculateWeatherBlendsFromVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x002C8820 File Offset: 0x002C6A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291750, XrefRangeEnd = 291768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendWeatherProfiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_BlendWeatherProfiles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x002C8854 File Offset: 0x002C6A54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291810, RefRangeEnd = 291814, XrefRangeStart = 291768, XrefRangeEnd = 291810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateWeatherVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_CreateWeatherVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x002C8888 File Offset: 0x002C6A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291853, RefRangeEnd = 291854, XrefRangeStart = 291814, XrefRangeEnd = 291853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWeatherVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_MoveWeatherVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x002C88BC File Offset: 0x002C6ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291854, XrefRangeEnd = 291866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_UpdateWind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x002C88F0 File Offset: 0x002C6AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291866, XrefRangeEnd = 291868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeWindDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_ChangeWindDirection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x002C8924 File Offset: 0x002C6B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291868, XrefRangeEnd = 291870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShiftWindDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_ShiftWindDirection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x002C8958 File Offset: 0x002C6B58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 291881, RefRangeEnd = 291889, XrefRangeStart = 291870, XrefRangeEnd = 291881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewWindDirection(float changeAngle, Vector3 currentDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref changeAngle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetNewWindDirection_Public_Vector3_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x002C89B0 File Offset: 0x002C6BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291951, RefRangeEnd = 291952, XrefRangeStart = 291889, XrefRangeEnd = 291951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_UpdateVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x002C89E4 File Offset: 0x002C6BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292022, RefRangeEnd = 292023, XrefRangeStart = 291952, XrefRangeEnd = 292022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWeather()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_UpdateWeather_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x002C8A18 File Offset: 0x002C6C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292023, XrefRangeEnd = 292043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWeatherEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_UpdateWeatherEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x002C8A4C File Offset: 0x002C6C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292043, XrefRangeEnd = 292045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLensFlare(LensFlareDataSRP flare, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(flare);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetLensFlare_Private_Void_LensFlareDataSRP_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x002C8A9C File Offset: 0x002C6C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292045, XrefRangeEnd = 292061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWeather()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_ClearWeather_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x002C8AD0 File Offset: 0x002C6CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292126, RefRangeEnd = 292127, XrefRangeStart = 292061, XrefRangeEnd = 292126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomWeatherSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetRandomWeatherSequence_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x002C8B04 File Offset: 0x002C6D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292140, RefRangeEnd = 292142, XrefRangeStart = 292127, XrefRangeEnd = 292140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherProfile GetWeatherProfileFromPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherProfileFromPosition_Protected_WeatherProfile_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherProfile>(intPtr3) : null;
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x002C8B50 File Offset: 0x002C6D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292142, XrefRangeEnd = 292147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherConditions GetActiveWeatherConditionsFromPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetActiveWeatherConditionsFromPosition_Private_WeatherConditions_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherConditions>(intPtr3) : null;
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x002C8B9C File Offset: 0x002C6D9C
		[CallerCount(0)]
		public unsafe Vector3 GetWeatherVolumeBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherVolumeBounds_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x002C8BD8 File Offset: 0x002C6DD8
		[CallerCount(0)]
		public unsafe Vector3 GetWeatherVolumeInitialPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherVolumeInitialPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x002C8C14 File Offset: 0x002C6E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292147, XrefRangeEnd = 292149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWeatherBoundsCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherBoundsCenter_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x002C8C50 File Offset: 0x002C6E50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292153, RefRangeEnd = 292157, XrefRangeStart = 292149, XrefRangeEnd = 292153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetWeatherAnchor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherAnchor_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x002C8C90 File Offset: 0x002C6E90
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 291397, RefRangeEnd = 291409, XrefRangeStart = 291397, XrefRangeEnd = 291409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetPlayer_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x002C8CD0 File Offset: 0x002C6ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292163, RefRangeEnd = 292164, XrefRangeStart = 292157, XrefRangeEnd = 292163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPositionUnderCover(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_IsPositionUnderCover_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x002C8D1C File Offset: 0x002C6F1C
		[CallerCount(0)]
		public unsafe int GetWrappedIndex(int index, int change, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWrappedIndex_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x002C8D84 File Offset: 0x002C6F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292189, RefRangeEnd = 292191, XrefRangeStart = 292164, XrefRangeEnd = 292189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherProfile GetWeatherProfile(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetWeatherProfile_Public_WeatherProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherProfile>(intPtr3) : null;
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x002C8DD4 File Offset: 0x002C6FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292191, XrefRangeEnd = 292192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinutePass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnMinutePass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x002C8E08 File Offset: 0x002C7008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292192, XrefRangeEnd = 292193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x002C8E3C File Offset: 0x002C703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292193, XrefRangeEnd = 292217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnTimeSet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x002C8E70 File Offset: 0x002C7070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292217, XrefRangeEnd = 292218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A809 RID: 43017 RVA: 0x002C8EA4 File Offset: 0x002C70A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292218, XrefRangeEnd = 292219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWeather(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetWeather_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80A RID: 43018 RVA: 0x002C8EE8 File Offset: 0x002C70E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292219, XrefRangeEnd = 292225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeatherEntityRegistered(IWeatherEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnWeatherEntityRegistered_Public_Void_IWeatherEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80B RID: 43019 RVA: 0x002C8F2C File Offset: 0x002C712C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292225, XrefRangeEnd = 292231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeatherEntityUnregistered(IWeatherEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnWeatherEntityUnregistered_Public_Void_IWeatherEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x002C8F70 File Offset: 0x002C7170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292231, XrefRangeEnd = 292232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnclosureRegistered(WorldEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_OnEnclosureRegistered_Public_Void_WorldEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x002C8FB4 File Offset: 0x002C71B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292241, RefRangeEnd = 292242, XrefRangeStart = 292232, XrefRangeEnd = 292241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEnclosure(WorldEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_RegisterEnclosure_Private_Void_WorldEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x002C8FF8 File Offset: 0x002C71F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292242, XrefRangeEnd = 292248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterWeatherEnclosure(WeatherEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_RegisterWeatherEnclosure_Private_Void_WeatherEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x002C903C File Offset: 0x002C723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292248, XrefRangeEnd = 292254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterOverrideEnclosure(SkyOverrideEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_RegisterOverrideEnclosure_Private_Void_SkyOverrideEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x002C9080 File Offset: 0x002C7280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292254, XrefRangeEnd = 292282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x002C90BC File Offset: 0x002C72BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292310, RefRangeEnd = 292311, XrefRangeStart = 292282, XrefRangeEnd = 292310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeatherSequence(string sequenceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_SetWeatherSequence_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x002C9100 File Offset: 0x002C7300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292311, XrefRangeEnd = 292324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TriggerLightningEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_TriggerLightningEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x002C9134 File Offset: 0x002C7334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292324, XrefRangeEnd = 292330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TriggerTargetedLightningEvent(Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_TriggerTargetedLightningEvent_Public_Virtual_Final_New_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x002C9174 File Offset: 0x002C7374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292330, XrefRangeEnd = 292343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TriggerDistantThunder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_TriggerDistantThunder_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x002C91A8 File Offset: 0x002C73A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292365, RefRangeEnd = 292368, XrefRangeStart = 292343, XrefRangeEnd = 292365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThunderController GetActiveThunderController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr_GetActiveThunderController_Private_ThunderController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThunderController>(intPtr3) : null;
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x002C91E8 File Offset: 0x002C73E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292368, XrefRangeEnd = 292399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x002C9224 File Offset: 0x002C7424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292399, XrefRangeEnd = 292403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x002C9260 File Offset: 0x002C7460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292403, XrefRangeEnd = 292406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x002C929C File Offset: 0x002C749C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x002C92D8 File Offset: 0x002C74D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292406, XrefRangeEnd = 292442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x0004C55C File Offset: 0x0004A75C
		public EnvironmentManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A81C RID: 43036 RVA: 0x002C9314 File Offset: 0x002C7514
		// (set) Token: 0x0600A81D RID: 43037 RVA: 0x0004C565 File Offset: 0x0004A765
		public unsafe static float UpdateWeatherEntitiesTickRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EnvironmentManager.NativeFieldInfoPtr_UpdateWeatherEntitiesTickRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnvironmentManager.NativeFieldInfoPtr_UpdateWeatherEntitiesTickRate, (void*)(&value));
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A81E RID: 43038 RVA: 0x002C9330 File Offset: 0x002C7530
		// (set) Token: 0x0600A81F RID: 43039 RVA: 0x0004C573 File Offset: 0x0004A773
		public unsafe Transform _playerObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__playerObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__playerObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A820 RID: 43040 RVA: 0x002C9360 File Offset: 0x002C7560
		// (set) Token: 0x0600A821 RID: 43041 RVA: 0x0004C592 File Offset: 0x0004A792
		public unsafe DayNightController _dayNightController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__dayNightController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayNightController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__dayNightController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A822 RID: 43042 RVA: 0x002C9390 File Offset: 0x002C7590
		// (set) Token: 0x0600A823 RID: 43043 RVA: 0x0004C5B1 File Offset: 0x0004A7B1
		public unsafe MaskController _maskController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__maskController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__maskController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A824 RID: 43044 RVA: 0x002C93C0 File Offset: 0x002C75C0
		// (set) Token: 0x0600A825 RID: 43045 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		public unsafe WeatherVolume _weatherVolumePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A826 RID: 43046 RVA: 0x002C93F0 File Offset: 0x002C75F0
		// (set) Token: 0x0600A827 RID: 43047 RVA: 0x0004C5EF File Offset: 0x0004A7EF
		public unsafe Transform _weatherBoundsAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBoundsAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBoundsAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A828 RID: 43048 RVA: 0x002C9420 File Offset: 0x002C7620
		// (set) Token: 0x0600A829 RID: 43049 RVA: 0x0004C60E File Offset: 0x0004A80E
		public unsafe Transform _weatherVolumeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A82A RID: 43050 RVA: 0x002C9450 File Offset: 0x002C7650
		// (set) Token: 0x0600A82B RID: 43051 RVA: 0x0004C62D File Offset: 0x0004A82D
		public unsafe List<WeatherSequence> _weatherSequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherSequences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherSequences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A82C RID: 43052 RVA: 0x002C9480 File Offset: 0x002C7680
		// (set) Token: 0x0600A82D RID: 43053 RVA: 0x0004C64C File Offset: 0x0004A84C
		public unsafe List<WeightedWeatherSequence> _dailyWeatherSequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__dailyWeatherSequences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeightedWeatherSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__dailyWeatherSequences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A82E RID: 43054 RVA: 0x002C94B0 File Offset: 0x002C76B0
		// (set) Token: 0x0600A82F RID: 43055 RVA: 0x0004C66B File Offset: 0x0004A86B
		public unsafe List<WeatherProfile> _weatherProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A830 RID: 43056 RVA: 0x002C94E0 File Offset: 0x002C76E0
		// (set) Token: 0x0600A831 RID: 43057 RVA: 0x0004C68A File Offset: 0x0004A88A
		public unsafe float _defaultWeatherVolumeMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__defaultWeatherVolumeMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__defaultWeatherVolumeMoveSpeed)) = value;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A832 RID: 43058 RVA: 0x002C9508 File Offset: 0x002C7708
		// (set) Token: 0x0600A833 RID: 43059 RVA: 0x0004C6A5 File Offset: 0x0004A8A5
		public unsafe int _weatherVolumeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeCount)) = value;
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x002C9530 File Offset: 0x002C7730
		// (set) Token: 0x0600A835 RID: 43061 RVA: 0x0004C6C0 File Offset: 0x0004A8C0
		public unsafe Vector3 _weatherBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBounds)) = value;
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x002C9558 File Offset: 0x002C7758
		// (set) Token: 0x0600A837 RID: 43063 RVA: 0x0004C6DB File Offset: 0x0004A8DB
		public unsafe float _weatherVolumeBlendSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBlendSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBlendSize)) = value;
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A838 RID: 43064 RVA: 0x002C9580 File Offset: 0x002C7780
		// (set) Token: 0x0600A839 RID: 43065 RVA: 0x0004C6F6 File Offset: 0x0004A8F6
		public unsafe AnimationCurve _blendCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__blendCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__blendCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A83A RID: 43066 RVA: 0x002C95B0 File Offset: 0x002C77B0
		// (set) Token: 0x0600A83B RID: 43067 RVA: 0x0004C715 File Offset: 0x0004A915
		public unsafe LensFlareSettings _lensFlareSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__lensFlareSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__lensFlareSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A83C RID: 43068 RVA: 0x002C95E0 File Offset: 0x002C77E0
		// (set) Token: 0x0600A83D RID: 43069 RVA: 0x0004C734 File Offset: 0x0004A934
		public unsafe float _windChangeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeSpeed)) = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A83E RID: 43070 RVA: 0x002C9608 File Offset: 0x002C7808
		// (set) Token: 0x0600A83F RID: 43071 RVA: 0x0004C74F File Offset: 0x0004A94F
		public unsafe Vector2Int _minMaxWindChangeInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__minMaxWindChangeInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__minMaxWindChangeInterval)) = value;
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A840 RID: 43072 RVA: 0x002C9630 File Offset: 0x002C7830
		// (set) Token: 0x0600A841 RID: 43073 RVA: 0x0004C76A File Offset: 0x0004A96A
		public unsafe float _windChangeAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeAngle)) = value;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A842 RID: 43074 RVA: 0x002C9658 File Offset: 0x002C7858
		// (set) Token: 0x0600A843 RID: 43075 RVA: 0x0004C785 File Offset: 0x0004A985
		public unsafe Vector2Int _minMaxWindShiftInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__minMaxWindShiftInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__minMaxWindShiftInterval)) = value;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A844 RID: 43076 RVA: 0x002C9680 File Offset: 0x002C7880
		// (set) Token: 0x0600A845 RID: 43077 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		public unsafe float _windShiftAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftAngle)) = value;
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x002C96A8 File Offset: 0x002C78A8
		// (set) Token: 0x0600A847 RID: 43079 RVA: 0x0004C7BB File Offset: 0x0004A9BB
		public unsafe UniversalRendererData _rendererData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__rendererData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRendererData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__rendererData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A848 RID: 43080 RVA: 0x002C96D8 File Offset: 0x002C78D8
		// (set) Token: 0x0600A849 RID: 43081 RVA: 0x0004C7DA File Offset: 0x0004A9DA
		public unsafe bool _debugControlWeatherSpeedWithSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__debugControlWeatherSpeedWithSlider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__debugControlWeatherSpeedWithSlider)) = value;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600A84A RID: 43082 RVA: 0x002C9700 File Offset: 0x002C7900
		// (set) Token: 0x0600A84B RID: 43083 RVA: 0x0004C7F5 File Offset: 0x0004A9F5
		public unsafe float _debugWeatherSliderValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__debugWeatherSliderValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__debugWeatherSliderValue)) = value;
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A84C RID: 43084 RVA: 0x002C9728 File Offset: 0x002C7928
		// (set) Token: 0x0600A84D RID: 43085 RVA: 0x0004C810 File Offset: 0x0004AA10
		public unsafe List<WeatherEnclosure> _weatherEnclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherEnclosures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherEnclosures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A84E RID: 43086 RVA: 0x002C9758 File Offset: 0x002C7958
		// (set) Token: 0x0600A84F RID: 43087 RVA: 0x0004C82F File Offset: 0x0004AA2F
		public unsafe List<SkyOverrideEnclosure> _overrideEnclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__overrideEnclosures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkyOverrideEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__overrideEnclosures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A850 RID: 43088 RVA: 0x002C9788 File Offset: 0x002C7988
		// (set) Token: 0x0600A851 RID: 43089 RVA: 0x0004C84E File Offset: 0x0004AA4E
		public unsafe SyncList<WeatherVolume> _activeWeatherVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__activeWeatherVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<WeatherVolume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__activeWeatherVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A852 RID: 43090 RVA: 0x002C97B8 File Offset: 0x002C79B8
		// (set) Token: 0x0600A853 RID: 43091 RVA: 0x0004C86D File Offset: 0x0004AA6D
		public unsafe WeatherSequence _currentWeatherSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWeatherSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWeatherSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A854 RID: 43092 RVA: 0x002C97E8 File Offset: 0x002C79E8
		// (set) Token: 0x0600A855 RID: 43093 RVA: 0x0004C88C File Offset: 0x0004AA8C
		public unsafe WeatherVolume _targetWeatherVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A856 RID: 43094 RVA: 0x002C9818 File Offset: 0x002C7A18
		// (set) Token: 0x0600A857 RID: 43095 RVA: 0x0004C8AB File Offset: 0x0004AAAB
		public unsafe Vector3 _weatherVolumeBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeBounds)) = value;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A858 RID: 43096 RVA: 0x002C9840 File Offset: 0x002C7A40
		// (set) Token: 0x0600A859 RID: 43097 RVA: 0x0004C8C6 File Offset: 0x0004AAC6
		public unsafe Vector3 _weatherBoundsCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBoundsCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherBoundsCenter)) = value;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A85A RID: 43098 RVA: 0x002C9868 File Offset: 0x002C7A68
		// (set) Token: 0x0600A85B RID: 43099 RVA: 0x0004C8E1 File Offset: 0x0004AAE1
		public unsafe SkySettings _skyOverrideSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__skyOverrideSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__skyOverrideSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x002C9898 File Offset: 0x002C7A98
		// (set) Token: 0x0600A85D RID: 43101 RVA: 0x0004C900 File Offset: 0x0004AB00
		public unsafe float _blendAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__blendAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__blendAmount)) = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x002C98C0 File Offset: 0x002C7AC0
		// (set) Token: 0x0600A85F RID: 43103 RVA: 0x0004C91B File Offset: 0x0004AB1B
		public unsafe float _skyOverrideBlendValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__skyOverrideBlendValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__skyOverrideBlendValue)) = value;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A860 RID: 43104 RVA: 0x002C98E8 File Offset: 0x002C7AE8
		// (set) Token: 0x0600A861 RID: 43105 RVA: 0x0004C936 File Offset: 0x0004AB36
		public unsafe bool _doWeatherBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__doWeatherBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__doWeatherBlending)) = value;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x002C9910 File Offset: 0x002C7B10
		// (set) Token: 0x0600A863 RID: 43107 RVA: 0x0004C951 File Offset: 0x0004AB51
		public unsafe bool _hasWeatherVolumeNeighbour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__hasWeatherVolumeNeighbour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__hasWeatherVolumeNeighbour)) = value;
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A864 RID: 43108 RVA: 0x002C9938 File Offset: 0x002C7B38
		// (set) Token: 0x0600A865 RID: 43109 RVA: 0x0004C96C File Offset: 0x0004AB6C
		public unsafe bool _withinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__withinBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__withinBounds)) = value;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A866 RID: 43110 RVA: 0x002C9960 File Offset: 0x002C7B60
		// (set) Token: 0x0600A867 RID: 43111 RVA: 0x0004C987 File Offset: 0x0004AB87
		public unsafe int _targetWeatherVolumeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolumeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherVolumeIndex)) = value;
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A868 RID: 43112 RVA: 0x002C9988 File Offset: 0x002C7B88
		// (set) Token: 0x0600A869 RID: 43113 RVA: 0x0004C9A2 File Offset: 0x0004ABA2
		public unsafe int _neighbourWeatherVolumeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherVolumeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherVolumeIndex)) = value;
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A86A RID: 43114 RVA: 0x002C99B0 File Offset: 0x002C7BB0
		// (set) Token: 0x0600A86B RID: 43115 RVA: 0x0004C9BD File Offset: 0x0004ABBD
		public unsafe float _targetWeatherBlendValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherBlendValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWeatherBlendValue)) = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A86C RID: 43116 RVA: 0x002C99D8 File Offset: 0x002C7BD8
		// (set) Token: 0x0600A86D RID: 43117 RVA: 0x0004C9D8 File Offset: 0x0004ABD8
		public unsafe float _weatherVolumeMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumeMoveSpeed)) = value;
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A86E RID: 43118 RVA: 0x002C9A00 File Offset: 0x002C7C00
		// (set) Token: 0x0600A86F RID: 43119 RVA: 0x0004C9F3 File Offset: 0x0004ABF3
		public unsafe float _neighbourWeatherBlendValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherBlendValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__neighbourWeatherBlendValue)) = value;
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A870 RID: 43120 RVA: 0x002C9A28 File Offset: 0x002C7C28
		// (set) Token: 0x0600A871 RID: 43121 RVA: 0x0004CA0E File Offset: 0x0004AC0E
		public unsafe Vector2 _closestPointInTargetVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__closestPointInTargetVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__closestPointInTargetVolume)) = value;
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A872 RID: 43122 RVA: 0x002C9A50 File Offset: 0x002C7C50
		// (set) Token: 0x0600A873 RID: 43123 RVA: 0x0004CA29 File Offset: 0x0004AC29
		public unsafe Vector2 _closestPointInNeighbourVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__closestPointInNeighbourVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__closestPointInNeighbourVolume)) = value;
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x002C9A78 File Offset: 0x002C7C78
		// (set) Token: 0x0600A875 RID: 43125 RVA: 0x0004CA44 File Offset: 0x0004AC44
		public unsafe int _sequenceVolumeStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__sequenceVolumeStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__sequenceVolumeStartIndex)) = value;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A876 RID: 43126 RVA: 0x002C9AA0 File Offset: 0x002C7CA0
		// (set) Token: 0x0600A877 RID: 43127 RVA: 0x0004CA5F File Offset: 0x0004AC5F
		public unsafe Il2CppStructArray<Vector3> _weatherVolumePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__weatherVolumePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x002C9AD0 File Offset: 0x002C7CD0
		// (set) Token: 0x0600A879 RID: 43129 RVA: 0x0004CA7E File Offset: 0x0004AC7E
		public unsafe Vector3 _windVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windVelocity)) = value;
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A87A RID: 43130 RVA: 0x002C9AF8 File Offset: 0x002C7CF8
		// (set) Token: 0x0600A87B RID: 43131 RVA: 0x0004CA99 File Offset: 0x0004AC99
		public unsafe Vector3 _targetWindDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWindDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__targetWindDirection)) = value;
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A87C RID: 43132 RVA: 0x002C9B20 File Offset: 0x002C7D20
		// (set) Token: 0x0600A87D RID: 43133 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		public unsafe Vector3 _currentWindDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWindDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWindDirection)) = value;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x002C9B48 File Offset: 0x002C7D48
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x0004CACF File Offset: 0x0004ACCF
		public unsafe float _windChangeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeTime)) = value;
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x002C9B70 File Offset: 0x002C7D70
		// (set) Token: 0x0600A881 RID: 43137 RVA: 0x0004CAEA File Offset: 0x0004ACEA
		public unsafe float _windShiftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftTime)) = value;
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x002C9B98 File Offset: 0x002C7D98
		// (set) Token: 0x0600A883 RID: 43139 RVA: 0x0004CB05 File Offset: 0x0004AD05
		public unsafe float _windShiftTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windShiftTimer)) = value;
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x002C9BC0 File Offset: 0x002C7DC0
		// (set) Token: 0x0600A885 RID: 43141 RVA: 0x0004CB20 File Offset: 0x0004AD20
		public unsafe float _windChangeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__windChangeTimer)) = value;
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x002C9BE8 File Offset: 0x002C7DE8
		// (set) Token: 0x0600A887 RID: 43143 RVA: 0x0004CB3B File Offset: 0x0004AD3B
		public unsafe WeatherConditions _currentWeatherConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWeatherConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherConditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentWeatherConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x002C9C18 File Offset: 0x002C7E18
		// (set) Token: 0x0600A889 RID: 43145 RVA: 0x0004CB5A File Offset: 0x0004AD5A
		public unsafe SkyState _currentSkyState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentSkyState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__currentSkyState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A88A RID: 43146 RVA: 0x002C9C48 File Offset: 0x002C7E48
		// (set) Token: 0x0600A88B RID: 43147 RVA: 0x0004CB79 File Offset: 0x0004AD79
		public unsafe ScheduleOneFogFeature _fogFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__fogFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScheduleOneFogFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__fogFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A88C RID: 43148 RVA: 0x002C9C78 File Offset: 0x002C7E78
		// (set) Token: 0x0600A88D RID: 43149 RVA: 0x0004CB98 File Offset: 0x0004AD98
		public unsafe List<IWeatherEntity> _registeredWeatherEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__registeredWeatherEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IWeatherEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr__registeredWeatherEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x002C9CA8 File Offset: 0x002C7EA8
		// (set) Token: 0x0600A88F RID: 43151 RVA: 0x0004CBB7 File Offset: 0x0004ADB7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x002C9CD0 File Offset: 0x002C7ED0
		// (set) Token: 0x0600A891 RID: 43153 RVA: 0x0004CBD2 File Offset: 0x0004ADD2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007412 RID: 29714
		private static readonly IntPtr NativeFieldInfoPtr_UpdateWeatherEntitiesTickRate;

		// Token: 0x04007413 RID: 29715
		private static readonly IntPtr NativeFieldInfoPtr__playerObj;

		// Token: 0x04007414 RID: 29716
		private static readonly IntPtr NativeFieldInfoPtr__dayNightController;

		// Token: 0x04007415 RID: 29717
		private static readonly IntPtr NativeFieldInfoPtr__maskController;

		// Token: 0x04007416 RID: 29718
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumePrefab;

		// Token: 0x04007417 RID: 29719
		private static readonly IntPtr NativeFieldInfoPtr__weatherBoundsAnchor;

		// Token: 0x04007418 RID: 29720
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeContainer;

		// Token: 0x04007419 RID: 29721
		private static readonly IntPtr NativeFieldInfoPtr__weatherSequences;

		// Token: 0x0400741A RID: 29722
		private static readonly IntPtr NativeFieldInfoPtr__dailyWeatherSequences;

		// Token: 0x0400741B RID: 29723
		private static readonly IntPtr NativeFieldInfoPtr__weatherProfiles;

		// Token: 0x0400741C RID: 29724
		private static readonly IntPtr NativeFieldInfoPtr__defaultWeatherVolumeMoveSpeed;

		// Token: 0x0400741D RID: 29725
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeCount;

		// Token: 0x0400741E RID: 29726
		private static readonly IntPtr NativeFieldInfoPtr__weatherBounds;

		// Token: 0x0400741F RID: 29727
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeBlendSize;

		// Token: 0x04007420 RID: 29728
		private static readonly IntPtr NativeFieldInfoPtr__blendCurve;

		// Token: 0x04007421 RID: 29729
		private static readonly IntPtr NativeFieldInfoPtr__lensFlareSettings;

		// Token: 0x04007422 RID: 29730
		private static readonly IntPtr NativeFieldInfoPtr__windChangeSpeed;

		// Token: 0x04007423 RID: 29731
		private static readonly IntPtr NativeFieldInfoPtr__minMaxWindChangeInterval;

		// Token: 0x04007424 RID: 29732
		private static readonly IntPtr NativeFieldInfoPtr__windChangeAngle;

		// Token: 0x04007425 RID: 29733
		private static readonly IntPtr NativeFieldInfoPtr__minMaxWindShiftInterval;

		// Token: 0x04007426 RID: 29734
		private static readonly IntPtr NativeFieldInfoPtr__windShiftAngle;

		// Token: 0x04007427 RID: 29735
		private static readonly IntPtr NativeFieldInfoPtr__rendererData;

		// Token: 0x04007428 RID: 29736
		private static readonly IntPtr NativeFieldInfoPtr__debugControlWeatherSpeedWithSlider;

		// Token: 0x04007429 RID: 29737
		private static readonly IntPtr NativeFieldInfoPtr__debugWeatherSliderValue;

		// Token: 0x0400742A RID: 29738
		private static readonly IntPtr NativeFieldInfoPtr__weatherEnclosures;

		// Token: 0x0400742B RID: 29739
		private static readonly IntPtr NativeFieldInfoPtr__overrideEnclosures;

		// Token: 0x0400742C RID: 29740
		private static readonly IntPtr NativeFieldInfoPtr__activeWeatherVolumes;

		// Token: 0x0400742D RID: 29741
		private static readonly IntPtr NativeFieldInfoPtr__currentWeatherSequence;

		// Token: 0x0400742E RID: 29742
		private static readonly IntPtr NativeFieldInfoPtr__targetWeatherVolume;

		// Token: 0x0400742F RID: 29743
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeBounds;

		// Token: 0x04007430 RID: 29744
		private static readonly IntPtr NativeFieldInfoPtr__weatherBoundsCenter;

		// Token: 0x04007431 RID: 29745
		private static readonly IntPtr NativeFieldInfoPtr__skyOverrideSettings;

		// Token: 0x04007432 RID: 29746
		private static readonly IntPtr NativeFieldInfoPtr__blendAmount;

		// Token: 0x04007433 RID: 29747
		private static readonly IntPtr NativeFieldInfoPtr__skyOverrideBlendValue;

		// Token: 0x04007434 RID: 29748
		private static readonly IntPtr NativeFieldInfoPtr__doWeatherBlending;

		// Token: 0x04007435 RID: 29749
		private static readonly IntPtr NativeFieldInfoPtr__hasWeatherVolumeNeighbour;

		// Token: 0x04007436 RID: 29750
		private static readonly IntPtr NativeFieldInfoPtr__withinBounds;

		// Token: 0x04007437 RID: 29751
		private static readonly IntPtr NativeFieldInfoPtr__targetWeatherVolumeIndex;

		// Token: 0x04007438 RID: 29752
		private static readonly IntPtr NativeFieldInfoPtr__neighbourWeatherVolumeIndex;

		// Token: 0x04007439 RID: 29753
		private static readonly IntPtr NativeFieldInfoPtr__targetWeatherBlendValue;

		// Token: 0x0400743A RID: 29754
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeMoveSpeed;

		// Token: 0x0400743B RID: 29755
		private static readonly IntPtr NativeFieldInfoPtr__neighbourWeatherBlendValue;

		// Token: 0x0400743C RID: 29756
		private static readonly IntPtr NativeFieldInfoPtr__closestPointInTargetVolume;

		// Token: 0x0400743D RID: 29757
		private static readonly IntPtr NativeFieldInfoPtr__closestPointInNeighbourVolume;

		// Token: 0x0400743E RID: 29758
		private static readonly IntPtr NativeFieldInfoPtr__sequenceVolumeStartIndex;

		// Token: 0x0400743F RID: 29759
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumePositions;

		// Token: 0x04007440 RID: 29760
		private static readonly IntPtr NativeFieldInfoPtr__windVelocity;

		// Token: 0x04007441 RID: 29761
		private static readonly IntPtr NativeFieldInfoPtr__targetWindDirection;

		// Token: 0x04007442 RID: 29762
		private static readonly IntPtr NativeFieldInfoPtr__currentWindDirection;

		// Token: 0x04007443 RID: 29763
		private static readonly IntPtr NativeFieldInfoPtr__windChangeTime;

		// Token: 0x04007444 RID: 29764
		private static readonly IntPtr NativeFieldInfoPtr__windShiftTime;

		// Token: 0x04007445 RID: 29765
		private static readonly IntPtr NativeFieldInfoPtr__windShiftTimer;

		// Token: 0x04007446 RID: 29766
		private static readonly IntPtr NativeFieldInfoPtr__windChangeTimer;

		// Token: 0x04007447 RID: 29767
		private static readonly IntPtr NativeFieldInfoPtr__currentWeatherConditions;

		// Token: 0x04007448 RID: 29768
		private static readonly IntPtr NativeFieldInfoPtr__currentSkyState;

		// Token: 0x04007449 RID: 29769
		private static readonly IntPtr NativeFieldInfoPtr__fogFeature;

		// Token: 0x0400744A RID: 29770
		private static readonly IntPtr NativeFieldInfoPtr__registeredWeatherEntities;

		// Token: 0x0400744B RID: 29771
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400744C RID: 29772
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400744D RID: 29773
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Protected_get_Transform_0;

		// Token: 0x0400744E RID: 29774
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Weather_IEnvironmentManager_get_SkyState_Private_Virtual_Final_New_get_SkyState_0;

		// Token: 0x0400744F RID: 29775
		private static readonly IntPtr NativeMethodInfoPtr_get_WeatherSequences_Public_get_List_1_WeatherSequence_0;

		// Token: 0x04007450 RID: 29776
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007451 RID: 29777
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04007452 RID: 29778
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04007453 RID: 29779
		private static readonly IntPtr NativeMethodInfoPtr_SetupHandler_Private_Void_0;

		// Token: 0x04007454 RID: 29780
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseFog_Private_Void_0;

		// Token: 0x04007455 RID: 29781
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseSky_Private_Void_0;

		// Token: 0x04007456 RID: 29782
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseWind_Private_Void_0;

		// Token: 0x04007457 RID: 29783
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseWeather_Private_Void_0;

		// Token: 0x04007458 RID: 29784
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseGlobalVariables_Private_Void_0;

		// Token: 0x04007459 RID: 29785
		private static readonly IntPtr NativeMethodInfoPtr_SetupEvents_Private_Void_0;

		// Token: 0x0400745A RID: 29786
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseControllers_Private_Void_0;

		// Token: 0x0400745B RID: 29787
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400745C RID: 29788
		private static readonly IntPtr NativeMethodInfoPtr_CreateWeatherVolumesAtStartIndex_Private_Void_Int32_0;

		// Token: 0x0400745D RID: 29789
		private static readonly IntPtr NativeMethodInfoPtr_CreateVolume_Private_Void_WeatherProfile_Vector3_Int32_0;

		// Token: 0x0400745E RID: 29790
		private static readonly IntPtr NativeMethodInfoPtr_DetermineWeatherVolumeWithTarget_Private_Void_0;

		// Token: 0x0400745F RID: 29791
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWeatherBlendsFromVolumes_Private_Void_0;

		// Token: 0x04007460 RID: 29792
		private static readonly IntPtr NativeMethodInfoPtr_BlendWeatherProfiles_Private_Void_0;

		// Token: 0x04007461 RID: 29793
		private static readonly IntPtr NativeMethodInfoPtr_CreateWeatherVolumes_Private_Void_0;

		// Token: 0x04007462 RID: 29794
		private static readonly IntPtr NativeMethodInfoPtr_MoveWeatherVolumes_Private_Void_0;

		// Token: 0x04007463 RID: 29795
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWind_Private_Void_0;

		// Token: 0x04007464 RID: 29796
		private static readonly IntPtr NativeMethodInfoPtr_ChangeWindDirection_Private_Void_0;

		// Token: 0x04007465 RID: 29797
		private static readonly IntPtr NativeMethodInfoPtr_ShiftWindDirection_Private_Void_0;

		// Token: 0x04007466 RID: 29798
		private static readonly IntPtr NativeMethodInfoPtr_GetNewWindDirection_Public_Vector3_Single_Vector3_0;

		// Token: 0x04007467 RID: 29799
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumes_Private_Void_0;

		// Token: 0x04007468 RID: 29800
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWeather_Private_Void_0;

		// Token: 0x04007469 RID: 29801
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWeatherEntities_Private_Void_0;

		// Token: 0x0400746A RID: 29802
		private static readonly IntPtr NativeMethodInfoPtr_SetLensFlare_Private_Void_LensFlareDataSRP_Single_0;

		// Token: 0x0400746B RID: 29803
		private static readonly IntPtr NativeMethodInfoPtr_ClearWeather_Private_Void_0;

		// Token: 0x0400746C RID: 29804
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomWeatherSequence_Private_Void_0;

		// Token: 0x0400746D RID: 29805
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherProfileFromPosition_Protected_WeatherProfile_Vector3_0;

		// Token: 0x0400746E RID: 29806
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveWeatherConditionsFromPosition_Private_WeatherConditions_Vector3_0;

		// Token: 0x0400746F RID: 29807
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherVolumeBounds_Private_Vector3_0;

		// Token: 0x04007470 RID: 29808
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherVolumeInitialPosition_Private_Vector3_0;

		// Token: 0x04007471 RID: 29809
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherBoundsCenter_Private_Vector3_0;

		// Token: 0x04007472 RID: 29810
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherAnchor_Private_Transform_0;

		// Token: 0x04007473 RID: 29811
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Private_Transform_0;

		// Token: 0x04007474 RID: 29812
		private static readonly IntPtr NativeMethodInfoPtr_IsPositionUnderCover_Private_Boolean_Vector3_0;

		// Token: 0x04007475 RID: 29813
		private static readonly IntPtr NativeMethodInfoPtr_GetWrappedIndex_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x04007476 RID: 29814
		private static readonly IntPtr NativeMethodInfoPtr_GetWeatherProfile_Public_WeatherProfile_String_0;

		// Token: 0x04007477 RID: 29815
		private static readonly IntPtr NativeMethodInfoPtr_OnMinutePass_Private_Void_0;

		// Token: 0x04007478 RID: 29816
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x04007479 RID: 29817
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSet_Private_Void_0;

		// Token: 0x0400747A RID: 29818
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_0;

		// Token: 0x0400747B RID: 29819
		private static readonly IntPtr NativeMethodInfoPtr_SetWeather_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400747C RID: 29820
		private static readonly IntPtr NativeMethodInfoPtr_OnWeatherEntityRegistered_Public_Void_IWeatherEntity_0;

		// Token: 0x0400747D RID: 29821
		private static readonly IntPtr NativeMethodInfoPtr_OnWeatherEntityUnregistered_Public_Void_IWeatherEntity_0;

		// Token: 0x0400747E RID: 29822
		private static readonly IntPtr NativeMethodInfoPtr_OnEnclosureRegistered_Public_Void_WorldEnclosure_0;

		// Token: 0x0400747F RID: 29823
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEnclosure_Private_Void_WorldEnclosure_0;

		// Token: 0x04007480 RID: 29824
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWeatherEnclosure_Private_Void_WeatherEnclosure_0;

		// Token: 0x04007481 RID: 29825
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOverrideEnclosure_Private_Void_SkyOverrideEnclosure_0;

		// Token: 0x04007482 RID: 29826
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04007483 RID: 29827
		private static readonly IntPtr NativeMethodInfoPtr_SetWeatherSequence_Private_Void_String_0;

		// Token: 0x04007484 RID: 29828
		private static readonly IntPtr NativeMethodInfoPtr_TriggerLightningEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007485 RID: 29829
		private static readonly IntPtr NativeMethodInfoPtr_TriggerTargetedLightningEvent_Public_Virtual_Final_New_Void_Vector3_0;

		// Token: 0x04007486 RID: 29830
		private static readonly IntPtr NativeMethodInfoPtr_TriggerDistantThunder_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007487 RID: 29831
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveThunderController_Private_ThunderController_0;

		// Token: 0x04007488 RID: 29832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007489 RID: 29833
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400748A RID: 29834
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400748B RID: 29835
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400748C RID: 29836
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C7F RID: 3199
		[ObfuscatedName("ScheduleOne.Weather.EnvironmentManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F231 RID: 62001 RVA: 0x003A60BC File Offset: 0x003A42BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr);
				EnvironmentManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, "<>9");
				EnvironmentManager.__c.NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, "<>9__67_0");
				EnvironmentManager.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, "<>9__91_0");
				EnvironmentManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, 100685642);
				EnvironmentManager.__c.NativeMethodInfoPtr__InitialiseFog_b__67_0_Internal_Boolean_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, 100685643);
				EnvironmentManager.__c.NativeMethodInfoPtr__SetRandomWeatherSequence_b__91_0_Internal_Single_WeightedWeatherSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr, 100685644);
			}

			// Token: 0x0600F232 RID: 62002 RVA: 0x003A6160 File Offset: 0x003A4360
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F233 RID: 62003 RVA: 0x003A619C File Offset: 0x003A439C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291350, XrefRangeEnd = 291355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitialiseFog_b__67_0(ScriptableRendererFeature x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c.NativeMethodInfoPtr__InitialiseFog_b__67_0_Internal_Boolean_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F234 RID: 62004 RVA: 0x003A61EC File Offset: 0x003A43EC
			[CallerCount(0)]
			public unsafe float _SetRandomWeatherSequence_b__91_0(WeightedWeatherSequence x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c.NativeMethodInfoPtr__SetRandomWeatherSequence_b__91_0_Internal_Single_WeightedWeatherSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F235 RID: 62005 RVA: 0x000724C3 File Offset: 0x000706C3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004985 RID: 18821
			// (get) Token: 0x0600F236 RID: 62006 RVA: 0x003A623C File Offset: 0x003A443C
			// (set) Token: 0x0600F237 RID: 62007 RVA: 0x000724CC File Offset: 0x000706CC
			public unsafe static EnvironmentManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnvironmentManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnvironmentManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004986 RID: 18822
			// (get) Token: 0x0600F238 RID: 62008 RVA: 0x003A6264 File Offset: 0x003A4464
			// (set) Token: 0x0600F239 RID: 62009 RVA: 0x000724DE File Offset: 0x000706DE
			public unsafe static Predicate<ScriptableRendererFeature> __9__67_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnvironmentManager.__c.NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRendererFeature>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnvironmentManager.__c.NativeFieldInfoPtr___9__67_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004987 RID: 18823
			// (get) Token: 0x0600F23A RID: 62010 RVA: 0x003A628C File Offset: 0x003A448C
			// (set) Token: 0x0600F23B RID: 62011 RVA: 0x000724F0 File Offset: 0x000706F0
			public unsafe static Func<WeightedWeatherSequence, float> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnvironmentManager.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WeightedWeatherSequence, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnvironmentManager.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3E2 RID: 41954
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A3E3 RID: 41955
			private static readonly IntPtr NativeFieldInfoPtr___9__67_0;

			// Token: 0x0400A3E4 RID: 41956
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x0400A3E5 RID: 41957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3E6 RID: 41958
			private static readonly IntPtr NativeMethodInfoPtr__InitialiseFog_b__67_0_Internal_Boolean_ScriptableRendererFeature_0;

			// Token: 0x0400A3E7 RID: 41959
			private static readonly IntPtr NativeMethodInfoPtr__SetRandomWeatherSequence_b__91_0_Internal_Single_WeightedWeatherSequence_0;
		}

		// Token: 0x02000C80 RID: 3200
		[ObfuscatedName("ScheduleOne.Weather.EnvironmentManager+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F23C RID: 62012 RVA: 0x003A62B4 File Offset: 0x003A44B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr);
				EnvironmentManager.__c__DisplayClass101_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr, "id");
				EnvironmentManager.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr, 100685645);
				EnvironmentManager.__c__DisplayClass101_0.NativeMethodInfoPtr__GetWeatherProfile_b__0_Internal_Boolean_WeatherProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr, 100685646);
			}

			// Token: 0x0600F23D RID: 62013 RVA: 0x003A631C File Offset: 0x003A451C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F23E RID: 62014 RVA: 0x003A6358 File Offset: 0x003A4558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291355, XrefRangeEnd = 291359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetWeatherProfile_b__0(WeatherProfile p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass101_0.NativeMethodInfoPtr__GetWeatherProfile_b__0_Internal_Boolean_WeatherProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F23F RID: 62015 RVA: 0x00072502 File Offset: 0x00070702
			public __c__DisplayClass101_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004988 RID: 18824
			// (get) Token: 0x0600F240 RID: 62016 RVA: 0x003A63A8 File Offset: 0x003A45A8
			// (set) Token: 0x0600F241 RID: 62017 RVA: 0x0007250B File Offset: 0x0007070B
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass101_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass101_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A3E8 RID: 41960
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400A3E9 RID: 41961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3EA RID: 41962
			private static readonly IntPtr NativeMethodInfoPtr__GetWeatherProfile_b__0_Internal_Boolean_WeatherProfile_0;
		}

		// Token: 0x02000C81 RID: 3201
		[ObfuscatedName("ScheduleOne.Weather.EnvironmentManager+<>c__DisplayClass114_0")]
		public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F242 RID: 62018 RVA: 0x003A63D0 File Offset: 0x003A45D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass114_0()
			{
				Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "<>c__DisplayClass114_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr);
				EnvironmentManager.__c__DisplayClass114_0.NativeFieldInfoPtr_sequenceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr, "sequenceId");
				EnvironmentManager.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr, 100685647);
				EnvironmentManager.__c__DisplayClass114_0.NativeMethodInfoPtr__SetWeatherSequence_b__0_Internal_Boolean_WeatherSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr, 100685648);
			}

			// Token: 0x0600F243 RID: 62019 RVA: 0x003A6438 File Offset: 0x003A4638
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass114_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass114_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F244 RID: 62020 RVA: 0x003A6474 File Offset: 0x003A4674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291359, XrefRangeEnd = 291361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetWeatherSequence_b__0(WeatherSequence s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass114_0.NativeMethodInfoPtr__SetWeatherSequence_b__0_Internal_Boolean_WeatherSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F245 RID: 62021 RVA: 0x0007252A File Offset: 0x0007072A
			public __c__DisplayClass114_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004989 RID: 18825
			// (get) Token: 0x0600F246 RID: 62022 RVA: 0x003A64C4 File Offset: 0x003A46C4
			// (set) Token: 0x0600F247 RID: 62023 RVA: 0x00072533 File Offset: 0x00070733
			public unsafe string sequenceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass114_0.NativeFieldInfoPtr_sequenceId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass114_0.NativeFieldInfoPtr_sequenceId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A3EB RID: 41963
			private static readonly IntPtr NativeFieldInfoPtr_sequenceId;

			// Token: 0x0400A3EC RID: 41964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3ED RID: 41965
			private static readonly IntPtr NativeMethodInfoPtr__SetWeatherSequence_b__0_Internal_Boolean_WeatherSequence_0;
		}

		// Token: 0x02000C82 RID: 3202
		[ObfuscatedName("ScheduleOne.Weather.EnvironmentManager+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F248 RID: 62024 RVA: 0x003A64EC File Offset: 0x003A46EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr);
				EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr_entityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr, "entityCache");
				EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr, "<>4__this");
				EnvironmentManager.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr, 100685649);
				EnvironmentManager.__c__DisplayClass88_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr, 100685650);
			}

			// Token: 0x0600F249 RID: 62025 RVA: 0x003A6568 File Offset: 0x003A4768
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F24A RID: 62026 RVA: 0x003A65A4 File Offset: 0x003A47A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291361, XrefRangeEnd = 291387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass88_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F24B RID: 62027 RVA: 0x00072552 File Offset: 0x00070752
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700498A RID: 18826
			// (get) Token: 0x0600F24C RID: 62028 RVA: 0x003A65E4 File Offset: 0x003A47E4
			// (set) Token: 0x0600F24D RID: 62029 RVA: 0x0007255B File Offset: 0x0007075B
			public unsafe Il2CppReferenceArray<IWeatherEntity> entityCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr_entityCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IWeatherEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr_entityCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700498B RID: 18827
			// (get) Token: 0x0600F24E RID: 62030 RVA: 0x003A6614 File Offset: 0x003A4814
			// (set) Token: 0x0600F24F RID: 62031 RVA: 0x0007257A File Offset: 0x0007077A
			public unsafe EnvironmentManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3EE RID: 41966
			private static readonly IntPtr NativeFieldInfoPtr_entityCache;

			// Token: 0x0400A3EF RID: 41967
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3F0 RID: 41968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3F1 RID: 41969
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;
		}

		// Token: 0x02000C83 RID: 3203
		[ObfuscatedName("ScheduleOne.Weather.EnvironmentManager+<>c__DisplayClass91_0")]
		public sealed class __c__DisplayClass91_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F250 RID: 62032 RVA: 0x003A6644 File Offset: 0x003A4844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_0()
			{
				Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentManager>.NativeClassPtr, "<>c__DisplayClass91_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr);
				EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr, "weights");
				EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_totalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr, "totalWeight");
				EnvironmentManager.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr, 100685651);
				EnvironmentManager.__c__DisplayClass91_0.NativeMethodInfoPtr__SetRandomWeatherSequence_b__1_Internal_Void_WeightedWeatherSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr, 100685652);
			}

			// Token: 0x0600F251 RID: 62033 RVA: 0x003A66C0 File Offset: 0x003A48C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentManager.__c__DisplayClass91_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F252 RID: 62034 RVA: 0x003A66FC File Offset: 0x003A48FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291387, XrefRangeEnd = 291390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetRandomWeatherSequence_b__1(WeightedWeatherSequence s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentManager.__c__DisplayClass91_0.NativeMethodInfoPtr__SetRandomWeatherSequence_b__1_Internal_Void_WeightedWeatherSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F253 RID: 62035 RVA: 0x00072599 File Offset: 0x00070799
			public __c__DisplayClass91_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700498C RID: 18828
			// (get) Token: 0x0600F254 RID: 62036 RVA: 0x003A6740 File Offset: 0x003A4940
			// (set) Token: 0x0600F255 RID: 62037 RVA: 0x000725A2 File Offset: 0x000707A2
			public unsafe List<float> weights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_weights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_weights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700498D RID: 18829
			// (get) Token: 0x0600F256 RID: 62038 RVA: 0x003A6770 File Offset: 0x003A4970
			// (set) Token: 0x0600F257 RID: 62039 RVA: 0x000725C1 File Offset: 0x000707C1
			public unsafe float totalWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_totalWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentManager.__c__DisplayClass91_0.NativeFieldInfoPtr_totalWeight)) = value;
				}
			}

			// Token: 0x0400A3F2 RID: 41970
			private static readonly IntPtr NativeFieldInfoPtr_weights;

			// Token: 0x0400A3F3 RID: 41971
			private static readonly IntPtr NativeFieldInfoPtr_totalWeight;

			// Token: 0x0400A3F4 RID: 41972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3F5 RID: 41973
			private static readonly IntPtr NativeMethodInfoPtr__SetRandomWeatherSequence_b__1_Internal_Void_WeightedWeatherSequence_0;
		}
	}
}
