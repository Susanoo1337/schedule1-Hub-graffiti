using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000326 RID: 806
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x060041DD RID: 16861 RVA: 0x0015B968 File Offset: 0x00159B68
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCamera()
		{
			Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr);
			PlayerCamera.NativeFieldInfoPtr_CameraShakeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CameraShakeMultiplier");
			PlayerCamera.NativeFieldInfoPtr_MinFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "MinFov");
			PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<AntiAliasingMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CanLook_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CanLook>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FreeCamEnabled>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ViewingAvatar>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CameraMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<MethVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CocaineVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FovJitter>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<Position>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraOffsetFromTop");
			PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SprintFoVBoost");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_BobRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "BobRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamAcceleration");
			PlayerCamera.NativeFieldInfoPtr_SmoothLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLook");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSpeed");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeSmoother");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSmoother");
			PlayerCamera.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CameraContainer");
			PlayerCamera.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Camera");
			PlayerCamera.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "OverlayCamera");
			PlayerCamera.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Animator");
			PlayerCamera.NativeFieldInfoPtr_JoltClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "JoltClips");
			PlayerCamera.NativeFieldInfoPtr_URPAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "URPAssets");
			PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ViewAvatarCameraPosition");
			PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HeartbeatSoundController");
			PlayerCamera.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Flies");
			PlayerCamera.NativeFieldInfoPtr_MethRumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "MethRumble");
			PlayerCamera.NativeFieldInfoPtr_SchizoVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SchizoVoices");
			PlayerCamera.NativeFieldInfoPtr__viewAvatarAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "_viewAvatarAction");
			PlayerCamera.NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "globalVolume");
			PlayerCamera.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoF");
			PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<activeUIElements>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraShakeCoroutine");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalPos");
			PlayerCamera.NativeFieldInfoPtr_freeCamMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamMovement");
			PlayerCamera.NativeFieldInfoPtr_focusRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusRoutine");
			PlayerCamera.NativeFieldInfoPtr_focusMouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseX");
			PlayerCamera.NativeFieldInfoPtr_focusMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseY");
			PlayerCamera.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "movementEvents");
			PlayerCamera.NativeFieldInfoPtr_movementEventKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "movementEventKeys");
			PlayerCamera.NativeFieldInfoPtr_freeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_mouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseX");
			PlayerCamera.NativeFieldInfoPtr_mouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseY");
			PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<transformOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<fovOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameralocalPos_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalRot_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_lerpCameraRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "lerpCameraRoutine");
			PlayerCamera.NativeFieldInfoPtr_seizureJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "seizureJitter");
			PlayerCamera.NativeFieldInfoPtr_schizoFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "schizoFoV");
			PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "timeUntilNextSchizoVoice");
			PlayerCamera.NativeFieldInfoPtr__dofWasActiveBeforeScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "_dofWasActiveBeforeScreenshot");
			PlayerCamera.NativeFieldInfoPtr_gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "gizmos");
			PlayerCamera.NativeFieldInfoPtr_lookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "lookRoutine");
			PlayerCamera.NativeFieldInfoPtr_DoFCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoFCoroutine");
			PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCameraFOV_Coroutine");
			PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671796);
			PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671797);
			PlayerCamera.NativeMethodInfoPtr_get_CanLook_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671798);
			PlayerCamera.NativeMethodInfoPtr_set_CanLook_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671799);
			PlayerCamera.NativeMethodInfoPtr_get_ActiveUIElementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671800);
			PlayerCamera.NativeMethodInfoPtr_get_ActiveUIElements_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671801);
			PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671802);
			PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671803);
			PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671804);
			PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671805);
			PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671806);
			PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671807);
			PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671808);
			PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671809);
			PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671810);
			PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671811);
			PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671812);
			PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671813);
			PlayerCamera.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671814);
			PlayerCamera.NativeMethodInfoPtr_set_Position_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671815);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Private_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671816);
			PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671817);
			PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671818);
			PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671819);
			PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671820);
			PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671821);
			PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671822);
			PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671823);
			PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671824);
			PlayerCamera.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671825);
			PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671826);
			PlayerCamera.NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671827);
			PlayerCamera.NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671828);
			PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671829);
			PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671830);
			PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671831);
			PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671832);
			PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671833);
			PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671834);
			PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671835);
			PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671836);
			PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671837);
			PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671838);
			PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671839);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671840);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671841);
			PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671842);
			PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671843);
			PlayerCamera.NativeMethodInfoPtr_GetPointerRay_Public_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671844);
			PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671845);
			PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671846);
			PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671847);
			PlayerCamera.NativeMethodInfoPtr_LerpCameraTransform_Private_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671848);
			PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671849);
			PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671850);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671851);
			PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671852);
			PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671853);
			PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671854);
			PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671855);
			PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671856);
			PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671857);
			PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671858);
			PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671859);
			PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671860);
			PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671861);
			PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671862);
			PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671863);
			PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671864);
			PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671865);
			PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671866);
			PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671867);
			PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671868);
			PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671869);
			PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671870);
			PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671871);
			PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671872);
			PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671873);
			PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671874);
			PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671875);
			PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671876);
			PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671877);
			PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671878);
			PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__104_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671879);
			PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100671880);
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x0015C53C File Offset: 0x0015A73C
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x0015C56C File Offset: 0x0015A76C
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158892, XrefRangeEnd = 158894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158894, XrefRangeEnd = 158896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x0015C5A0 File Offset: 0x0015A7A0
		// (set) Token: 0x060041E1 RID: 16865 RVA: 0x0015C5DC File Offset: 0x0015A7DC
		public unsafe bool CanLook
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CanLook_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CanLook_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x0015C61C File Offset: 0x0015A81C
		public unsafe int ActiveUIElementCount
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 158897, RefRangeEnd = 158914, XrefRangeStart = 158896, XrefRangeEnd = 158897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ActiveUIElementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x0015C658 File Offset: 0x0015A858
		public unsafe List<string> ActiveUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ActiveUIElements_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0015C698 File Offset: 0x0015A898
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x0015C6D4 File Offset: 0x0015A8D4
		public unsafe bool FreeCamEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x0015C714 File Offset: 0x0015A914
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x0015C750 File Offset: 0x0015A950
		public unsafe bool ViewingAvatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0015C790 File Offset: 0x0015A990
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x0015C7CC File Offset: 0x0015A9CC
		public unsafe PlayerCamera.ECameraMode CameraMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x0015C80C File Offset: 0x0015AA0C
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x0015C848 File Offset: 0x0015AA48
		public unsafe bool MethVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x0015C888 File Offset: 0x0015AA88
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x0015C8C4 File Offset: 0x0015AAC4
		public unsafe bool CocaineVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x0015C904 File Offset: 0x0015AB04
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x0015C940 File Offset: 0x0015AB40
		public unsafe float FovJitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x0015C980 File Offset: 0x0015AB80
		// (set) Token: 0x060041F1 RID: 16881 RVA: 0x0015C9BC File Offset: 0x0015ABBC
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_Position_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x0015C9FC File Offset: 0x0015ABFC
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x0015CA3C File Offset: 0x0015AC3C
		public unsafe List<string> activeUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Private_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158914, XrefRangeEnd = 158915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x0015CA80 File Offset: 0x0015AC80
		// (set) Token: 0x060041F5 RID: 16885 RVA: 0x0015CABC File Offset: 0x0015ACBC
		public unsafe bool transformOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158915, RefRangeEnd = 158916, XrefRangeStart = 158915, XrefRangeEnd = 158915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x0015CAFC File Offset: 0x0015ACFC
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x0015CB38 File Offset: 0x0015AD38
		public unsafe bool fovOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x0015CB78 File Offset: 0x0015AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158916, XrefRangeEnd = 158965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x0015CBB4 File Offset: 0x0015ADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158965, XrefRangeEnd = 158975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x0015CC00 File Offset: 0x0015AE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158975, XrefRangeEnd = 159026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0015CC3C File Offset: 0x0015AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159026, XrefRangeEnd = 159042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0015CC78 File Offset: 0x0015AE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159042, XrefRangeEnd = 159068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x0015CCAC File Offset: 0x0015AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159068, XrefRangeEnd = 159070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepForScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0015CCE0 File Offset: 0x0015AEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159070, XrefRangeEnd = 159071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0015CD14 File Offset: 0x0015AF14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159085, RefRangeEnd = 159088, XrefRangeStart = 159071, XrefRangeEnd = 159085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAntialiasingMode(Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0015CD48 File Offset: 0x0015AF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159095, RefRangeEnd = 159097, XrefRangeStart = 159088, XrefRangeEnd = 159095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAASettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x0015CD7C File Offset: 0x0015AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159097, XrefRangeEnd = 159177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x0015CDB8 File Offset: 0x0015AFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159177, XrefRangeEnd = 159182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Screenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x0015CDEC File Offset: 0x0015AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159182, XrefRangeEnd = 159231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0015CE28 File Offset: 0x0015B028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159231, XrefRangeEnd = 159235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0015CE6C File Offset: 0x0015B06C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 159243, RefRangeEnd = 159249, XrefRangeStart = 159235, XrefRangeEnd = 159243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetLocalY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x0015CEA8 File Offset: 0x0015B0A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x0015CEE8 File Offset: 0x0015B0E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159333, RefRangeEnd = 159334, XrefRangeStart = 159249, XrefRangeEnd = 159333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0015CF1C File Offset: 0x0015B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159334, XrefRangeEnd = 159338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockMouse(bool showCrosshair = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCrosshair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x0015CF5C File Offset: 0x0015B15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159338, XrefRangeEnd = 159342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeMouse(bool hideCrosshair = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hideCrosshair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x0015CF9C File Offset: 0x0015B19C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 159351, RefRangeEnd = 159370, XrefRangeStart = 159342, XrefRangeEnd = 159351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x0015D020 File Offset: 0x0015B220
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 159404, RefRangeEnd = 159408, XrefRangeStart = 159370, XrefRangeEnd = 159404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x0015D094 File Offset: 0x0015B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159408, XrefRangeEnd = 159415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0015D0C8 File Offset: 0x0015B2C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 159455, RefRangeEnd = 159463, XrefRangeStart = 159415, XrefRangeEnd = 159455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAngleDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0015D174 File Offset: 0x0015B374
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 159472, RefRangeEnd = 159477, XrefRangeStart = 159463, XrefRangeEnd = 159472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray GetPointerRay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_GetPointerRay_Public_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 159491, RefRangeEnd = 159497, XrefRangeStart = 159477, XrefRangeEnd = 159491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0015D234 File Offset: 0x0015B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159497, XrefRangeEnd = 159506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x0015D2A8 File Offset: 0x0015B4A8
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 159530, RefRangeEnd = 159582, XrefRangeStart = 159506, XrefRangeEnd = 159530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepParented;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0015D310 File Offset: 0x0015B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159582, XrefRangeEnd = 159587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpCameraTransform(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition, bool enableLookWhenDone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endRot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToRestingPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableLookWhenDone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LerpCameraTransform_Private_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0015D3A4 File Offset: 0x0015B5A4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 159622, RefRangeEnd = 159649, XrefRangeStart = 159587, XrefRangeEnd = 159622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableCameraLook;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToOriginalRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0015D400 File Offset: 0x0015B600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159649, XrefRangeEnd = 159659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 point, float duration = 0.25f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x0015D44C File Offset: 0x0015B64C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159665, RefRangeEnd = 159668, XrefRangeStart = 159659, XrefRangeEnd = 159665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanLook(bool canLook)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x0015D48C File Offset: 0x0015B68C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159680, RefRangeEnd = 159683, XrefRangeStart = 159668, XrefRangeEnd = 159680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoFActive(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x0015D4D8 File Offset: 0x0015B6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159683, XrefRangeEnd = 159688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpDoF(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0015D534 File Offset: 0x0015B734
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 159701, RefRangeEnd = 159737, XrefRangeStart = 159688, XrefRangeEnd = 159701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideFOV(float fov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0015D580 File Offset: 0x0015B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159737, XrefRangeEnd = 159742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endFov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0015D5DC File Offset: 0x0015B7DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 159754, RefRangeEnd = 159776, XrefRangeStart = 159742, XrefRangeEnd = 159754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFOVOverride(float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0015D61C File Offset: 0x0015B81C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 159782, RefRangeEnd = 159823, XrefRangeStart = 159776, XrefRangeEnd = 159782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0015D660 File Offset: 0x0015B860
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 159829, RefRangeEnd = 159873, XrefRangeStart = 159823, XrefRangeEnd = 159829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0015D6A4 File Offset: 0x0015B8A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159895, RefRangeEnd = 159898, XrefRangeStart = 159873, XrefRangeEnd = 159895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0015D6F4 File Offset: 0x0015B8F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159926, RefRangeEnd = 159929, XrefRangeStart = 159898, XrefRangeEnd = 159926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x0015D738 File Offset: 0x0015B938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159951, RefRangeEnd = 159952, XrefRangeStart = 159929, XrefRangeEnd = 159951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0015D76C File Offset: 0x0015B96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160000, RefRangeEnd = 160001, XrefRangeStart = 159952, XrefRangeEnd = 160000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0015D7A0 File Offset: 0x0015B9A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160021, RefRangeEnd = 160023, XrefRangeStart = 160001, XrefRangeEnd = 160021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopViewingAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0015D7D4 File Offset: 0x0015B9D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160026, RefRangeEnd = 160029, XrefRangeStart = 160023, XrefRangeEnd = 160026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoltCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0015D808 File Offset: 0x0015BA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160029, XrefRangeEnd = 160053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x0015D854 File Offset: 0x0015BA54
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0015D8A0 File Offset: 0x0015BAA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160057, RefRangeEnd = 160059, XrefRangeStart = 160053, XrefRangeEnd = 160057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0015D8D4 File Offset: 0x0015BAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160070, RefRangeEnd = 160071, XrefRangeStart = 160059, XrefRangeEnd = 160070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusCameraOnTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0015D918 File Offset: 0x0015BB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160072, RefRangeEnd = 160073, XrefRangeStart = 160071, XrefRangeEnd = 160072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0015D94C File Offset: 0x0015BB4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 160087, RefRangeEnd = 160093, XrefRangeStart = 160073, XrefRangeEnd = 160087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decreaseOverTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0015D9A8 File Offset: 0x0015BBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160093, XrefRangeEnd = 160098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCameraShake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0015D9DC File Offset: 0x0015BBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160116, RefRangeEnd = 160117, XrefRangeStart = 160098, XrefRangeEnd = 160116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x0015DA10 File Offset: 0x0015BC10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160140, RefRangeEnd = 160143, XrefRangeStart = 160117, XrefRangeEnd = 160140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeCam(bool enable, bool reenableLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x0015DA5C File Offset: 0x0015BC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160198, RefRangeEnd = 160199, XrefRangeStart = 160143, XrefRangeEnd = 160198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0015DA90 File Offset: 0x0015BC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160225, RefRangeEnd = 160226, XrefRangeStart = 160199, XrefRangeEnd = 160225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFreeCamInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0015DAC4 File Offset: 0x0015BCC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160237, RefRangeEnd = 160238, XrefRangeStart = 160226, XrefRangeEnd = 160237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0015DAF8 File Offset: 0x0015BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160238, XrefRangeEnd = 160281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x0015DB34 File Offset: 0x0015BD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160281, XrefRangeEnd = 160282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayerSpawned_b__104_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x0015DB68 File Offset: 0x0015BD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160282, XrefRangeEnd = 160283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayerSpawned_b__104_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__104_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0015DB9C File Offset: 0x0015BD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160283, XrefRangeEnd = 160287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x000202EB File Offset: 0x0001E4EB
		public PlayerCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x0015DBD0 File Offset: 0x0015BDD0
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x000202F4 File Offset: 0x0001E4F4
		public unsafe static float CameraShakeMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr_CameraShakeMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr_CameraShakeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x0015DBEC File Offset: 0x0015BDEC
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x00020302 File Offset: 0x0001E502
		public unsafe static float MinFov
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr_MinFov, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr_MinFov, (void*)(&value));
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x0015DC08 File Offset: 0x0015BE08
		// (set) Token: 0x06004239 RID: 16953 RVA: 0x00020310 File Offset: 0x0001E510
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode _AntiAliasingMode_k__BackingField
		{
			get
			{
				Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x0015DC24 File Offset: 0x0015BE24
		// (set) Token: 0x0600423B RID: 16955 RVA: 0x0002031E File Offset: 0x0001E51E
		public unsafe bool _CanLook_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CanLook_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CanLook_k__BackingField)) = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x0015DC4C File Offset: 0x0015BE4C
		// (set) Token: 0x0600423D RID: 16957 RVA: 0x00020339 File Offset: 0x0001E539
		public unsafe bool _FreeCamEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x0015DC74 File Offset: 0x0015BE74
		// (set) Token: 0x0600423F RID: 16959 RVA: 0x00020354 File Offset: 0x0001E554
		public unsafe bool _ViewingAvatar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField)) = value;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x0015DC9C File Offset: 0x0015BE9C
		// (set) Token: 0x06004241 RID: 16961 RVA: 0x0002036F File Offset: 0x0001E56F
		public unsafe PlayerCamera.ECameraMode _CameraMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x0015DCC4 File Offset: 0x0015BEC4
		// (set) Token: 0x06004243 RID: 16963 RVA: 0x0002038A File Offset: 0x0001E58A
		public unsafe bool _MethVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x0015DCEC File Offset: 0x0015BEEC
		// (set) Token: 0x06004245 RID: 16965 RVA: 0x000203A5 File Offset: 0x0001E5A5
		public unsafe bool _CocaineVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x0015DD14 File Offset: 0x0015BF14
		// (set) Token: 0x06004247 RID: 16967 RVA: 0x000203C0 File Offset: 0x0001E5C0
		public unsafe float _FovJitter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField)) = value;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x0015DD3C File Offset: 0x0015BF3C
		// (set) Token: 0x06004249 RID: 16969 RVA: 0x000203DB File Offset: 0x0001E5DB
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x0015DD64 File Offset: 0x0015BF64
		// (set) Token: 0x0600424B RID: 16971 RVA: 0x000203F6 File Offset: 0x0001E5F6
		public unsafe float cameraOffsetFromTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop)) = value;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x0015DD8C File Offset: 0x0015BF8C
		// (set) Token: 0x0600424D RID: 16973 RVA: 0x00020411 File Offset: 0x0001E611
		public unsafe float SprintFoVBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost)) = value;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x0015DDB4 File Offset: 0x0015BFB4
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x0002042C File Offset: 0x0001E62C
		public unsafe float FoVChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate)) = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x0015DDDC File Offset: 0x0015BFDC
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x00020447 File Offset: 0x0001E647
		public unsafe float HorizontalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob)) = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x0015DE04 File Offset: 0x0015C004
		// (set) Token: 0x06004253 RID: 16979 RVA: 0x00020462 File Offset: 0x0001E662
		public unsafe float VerticalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob)) = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x0015DE2C File Offset: 0x0015C02C
		// (set) Token: 0x06004255 RID: 16981 RVA: 0x0002047D File Offset: 0x0001E67D
		public unsafe float BobRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate)) = value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x0015DE54 File Offset: 0x0015C054
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x00020498 File Offset: 0x0001E698
		public unsafe AnimationCurve HorizontalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x0015DE84 File Offset: 0x0015C084
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x000204B7 File Offset: 0x0001E6B7
		public unsafe AnimationCurve VerticalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x0015DEB4 File Offset: 0x0015C0B4
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x000204D6 File Offset: 0x0001E6D6
		public unsafe float FreeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed)) = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x0015DEDC File Offset: 0x0015C0DC
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x000204F1 File Offset: 0x0001E6F1
		public unsafe float FreeCamAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration)) = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x0015DF04 File Offset: 0x0015C104
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x0002050C File Offset: 0x0001E70C
		public unsafe bool SmoothLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook)) = value;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x0015DF2C File Offset: 0x0015C12C
		// (set) Token: 0x06004261 RID: 16993 RVA: 0x00020527 File Offset: 0x0001E727
		public unsafe float SmoothLookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed)) = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x0015DF54 File Offset: 0x0015C154
		// (set) Token: 0x06004263 RID: 16995 RVA: 0x00020542 File Offset: 0x0001E742
		public unsafe FloatSmoother FoVChangeSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x0015DF84 File Offset: 0x0015C184
		// (set) Token: 0x06004265 RID: 16997 RVA: 0x00020561 File Offset: 0x0001E761
		public unsafe FloatSmoother SmoothLookSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x0015DFB4 File Offset: 0x0015C1B4
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x00020580 File Offset: 0x0001E780
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x0015DFE4 File Offset: 0x0015C1E4
		// (set) Token: 0x06004269 RID: 17001 RVA: 0x0002059F File Offset: 0x0001E79F
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x0015E014 File Offset: 0x0015C214
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x000205BE File Offset: 0x0001E7BE
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x0015E044 File Offset: 0x0015C244
		// (set) Token: 0x0600426D RID: 17005 RVA: 0x000205DD File Offset: 0x0001E7DD
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x0015E074 File Offset: 0x0015C274
		// (set) Token: 0x0600426F RID: 17007 RVA: 0x000205FC File Offset: 0x0001E7FC
		public unsafe Il2CppReferenceArray<AnimationClip> JoltClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x0015E0A4 File Offset: 0x0015C2A4
		// (set) Token: 0x06004271 RID: 17009 RVA: 0x0002061B File Offset: 0x0001E81B
		public unsafe Il2CppReferenceArray<UniversalRenderPipelineAsset> URPAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniversalRenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x0015E0D4 File Offset: 0x0015C2D4
		// (set) Token: 0x06004273 RID: 17011 RVA: 0x0002063A File Offset: 0x0001E83A
		public unsafe Transform ViewAvatarCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x0015E104 File Offset: 0x0015C304
		// (set) Token: 0x06004275 RID: 17013 RVA: 0x00020659 File Offset: 0x0001E859
		public unsafe HeartbeatSoundController HeartbeatSoundController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeartbeatSoundController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0015E134 File Offset: 0x0015C334
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x00020678 File Offset: 0x0001E878
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x0015E164 File Offset: 0x0015C364
		// (set) Token: 0x06004279 RID: 17017 RVA: 0x00020697 File Offset: 0x0001E897
		public unsafe AudioSourceController MethRumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x0600427A RID: 17018 RVA: 0x0015E194 File Offset: 0x0015C394
		// (set) Token: 0x0600427B RID: 17019 RVA: 0x000206B6 File Offset: 0x0001E8B6
		public unsafe RandomizedAudioSourceController SchizoVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x0015E1C4 File Offset: 0x0015C3C4
		// (set) Token: 0x0600427D RID: 17021 RVA: 0x000206D5 File Offset: 0x0001E8D5
		public unsafe InputActionReference _viewAvatarAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__viewAvatarAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__viewAvatarAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x0015E1F4 File Offset: 0x0015C3F4
		// (set) Token: 0x0600427F RID: 17023 RVA: 0x000206F4 File Offset: 0x0001E8F4
		public unsafe Volume globalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06004280 RID: 17024 RVA: 0x0015E224 File Offset: 0x0015C424
		// (set) Token: 0x06004281 RID: 17025 RVA: 0x00020713 File Offset: 0x0001E913
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x0015E254 File Offset: 0x0015C454
		// (set) Token: 0x06004283 RID: 17027 RVA: 0x00020732 File Offset: 0x0001E932
		public unsafe List<string> _activeUIElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x0015E284 File Offset: 0x0015C484
		// (set) Token: 0x06004285 RID: 17029 RVA: 0x00020751 File Offset: 0x0001E951
		public unsafe Coroutine cameraShakeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x0015E2B4 File Offset: 0x0015C4B4
		// (set) Token: 0x06004287 RID: 17031 RVA: 0x00020770 File Offset: 0x0001E970
		public unsafe Vector3 cameraLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos)) = value;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x0015E2DC File Offset: 0x0015C4DC
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x0002078B File Offset: 0x0001E98B
		public unsafe Vector3 freeCamMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement)) = value;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x0015E304 File Offset: 0x0015C504
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x000207A6 File Offset: 0x0001E9A6
		public unsafe Coroutine focusRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x0015E334 File Offset: 0x0015C534
		// (set) Token: 0x0600428D RID: 17037 RVA: 0x000207C5 File Offset: 0x0001E9C5
		public unsafe float focusMouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX)) = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x0015E35C File Offset: 0x0015C55C
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public unsafe float focusMouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY)) = value;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x0015E384 File Offset: 0x0015C584
		// (set) Token: 0x06004291 RID: 17041 RVA: 0x000207FB File Offset: 0x0001E9FB
		public unsafe Dictionary<int, MotionEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MotionEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x0015E3B4 File Offset: 0x0015C5B4
		// (set) Token: 0x06004293 RID: 17043 RVA: 0x0002081A File Offset: 0x0001EA1A
		public unsafe List<int> movementEventKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEventKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEventKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x0015E3E4 File Offset: 0x0015C5E4
		// (set) Token: 0x06004295 RID: 17045 RVA: 0x00020839 File Offset: 0x0001EA39
		public unsafe float freeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed)) = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x0015E40C File Offset: 0x0015C60C
		// (set) Token: 0x06004297 RID: 17047 RVA: 0x00020854 File Offset: 0x0001EA54
		public unsafe float mouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX)) = value;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x0015E434 File Offset: 0x0015C634
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x0002086F File Offset: 0x0001EA6F
		public unsafe float mouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY)) = value;
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x0015E45C File Offset: 0x0015C65C
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x0002088A File Offset: 0x0001EA8A
		public unsafe bool _transformOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x0015E484 File Offset: 0x0015C684
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x000208A5 File Offset: 0x0001EAA5
		public unsafe bool _fovOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x0015E4AC File Offset: 0x0015C6AC
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x000208C0 File Offset: 0x0001EAC0
		public unsafe Vector3 cameralocalPos_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride)) = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0015E4D4 File Offset: 0x0015C6D4
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x000208DB File Offset: 0x0001EADB
		public unsafe Quaternion cameraLocalRot_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride)) = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0015E4FC File Offset: 0x0015C6FC
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x000208F6 File Offset: 0x0001EAF6
		public unsafe Coroutine lerpCameraRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lerpCameraRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lerpCameraRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0015E52C File Offset: 0x0015C72C
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x00020915 File Offset: 0x0001EB15
		public unsafe Vector2 seizureJitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter)) = value;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x0015E554 File Offset: 0x0015C754
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x00020930 File Offset: 0x0001EB30
		public unsafe float schizoFoV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV)) = value;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0015E57C File Offset: 0x0015C77C
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x0002094B File Offset: 0x0001EB4B
		public unsafe float timeUntilNextSchizoVoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice)) = value;
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x0015E5A4 File Offset: 0x0015C7A4
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x00020966 File Offset: 0x0001EB66
		public unsafe bool _dofWasActiveBeforeScreenshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__dofWasActiveBeforeScreenshot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__dofWasActiveBeforeScreenshot)) = value;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0015E5CC File Offset: 0x0015C7CC
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x00020981 File Offset: 0x0001EB81
		public unsafe List<Vector3> gizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x0015E5FC File Offset: 0x0015C7FC
		// (set) Token: 0x060042AF RID: 17071 RVA: 0x000209A0 File Offset: 0x0001EBA0
		public unsafe Coroutine lookRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x0015E62C File Offset: 0x0015C82C
		// (set) Token: 0x060042B1 RID: 17073 RVA: 0x000209BF File Offset: 0x0001EBBF
		public unsafe Coroutine DoFCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x0015E65C File Offset: 0x0015C85C
		// (set) Token: 0x060042B3 RID: 17075 RVA: 0x000209DE File Offset: 0x0001EBDE
		public unsafe Coroutine ILerpCameraFOV_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeFieldInfoPtr_CameraShakeMultiplier;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeFieldInfoPtr_MinFov;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeFieldInfoPtr__AntiAliasingMode_k__BackingField;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeFieldInfoPtr__CanLook_k__BackingField;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeFieldInfoPtr__FreeCamEnabled_k__BackingField;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeFieldInfoPtr__ViewingAvatar_k__BackingField;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeFieldInfoPtr__CameraMode_k__BackingField;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeFieldInfoPtr__MethVisuals_k__BackingField;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeFieldInfoPtr__CocaineVisuals_k__BackingField;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeFieldInfoPtr__FovJitter_k__BackingField;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeFieldInfoPtr_cameraOffsetFromTop;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeFieldInfoPtr_SprintFoVBoost;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeRate;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalCameraBob;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeFieldInfoPtr_VerticalCameraBob;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeFieldInfoPtr_BobRate;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalBobCurve;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeFieldInfoPtr_VerticalBobCurve;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamSpeed;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamAcceleration;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLook;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSpeed;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeSmoother;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSmoother;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeFieldInfoPtr_JoltClips;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeFieldInfoPtr_URPAssets;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeFieldInfoPtr_ViewAvatarCameraPosition;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeFieldInfoPtr_HeartbeatSoundController;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeFieldInfoPtr_MethRumble;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeFieldInfoPtr_SchizoVoices;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeFieldInfoPtr__viewAvatarAction;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeFieldInfoPtr_globalVolume;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeFieldInfoPtr__activeUIElements_k__BackingField;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeCoroutine;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalPos;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeFieldInfoPtr_freeCamMovement;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeFieldInfoPtr_focusRoutine;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseX;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseY;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeFieldInfoPtr_movementEventKeys;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeFieldInfoPtr_freeCamSpeed;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeFieldInfoPtr_mouseX;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeFieldInfoPtr_mouseY;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeFieldInfoPtr__transformOverriden_k__BackingField;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeFieldInfoPtr__fovOverriden_k__BackingField;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeFieldInfoPtr_cameralocalPos_PriorOverride;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalRot_PriorOverride;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeFieldInfoPtr_lerpCameraRoutine;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeFieldInfoPtr_seizureJitter;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeFieldInfoPtr_schizoFoV;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextSchizoVoice;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeFieldInfoPtr__dofWasActiveBeforeScreenshot;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeFieldInfoPtr_gizmos;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeFieldInfoPtr_lookRoutine;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeFieldInfoPtr_DoFCoroutine;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeFieldInfoPtr_ILerpCameraFOV_Coroutine;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_get_CanLook_Public_get_Boolean_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_set_CanLook_Protected_set_Void_Boolean_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveUIElementCount_Public_get_Int32_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveUIElements_Public_get_List_1_String_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0;

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Private_set_Void_Vector3_0;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeMethodInfoPtr_get_activeUIElements_Private_get_List_1_String_0;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeMethodInfoPtr_set_activeUIElements_Private_set_Void_List_1_String_0;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeMethodInfoPtr_get_transformOverriden_Private_get_Boolean_0;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_set_transformOverriden_Private_set_Void_Boolean_0;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_get_fovOverriden_Private_get_Boolean_0;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeMethodInfoPtr_set_fovOverriden_Private_set_Void_Boolean_0;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04002D29 RID: 11561
		private static readonly IntPtr NativeMethodInfoPtr_PrepForScreenshot_Private_Void_0;

		// Token: 0x04002D2A RID: 11562
		private static readonly IntPtr NativeMethodInfoPtr_CleanupScreenshot_Private_Void_0;

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAASettings_Public_Void_0;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeMethodInfoPtr_Screenshot_Private_Void_0;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0;

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeMethodInfoPtr_RotateCamera_Private_Void_0;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeMethodInfoPtr_LockMouse_Public_Void_Boolean_0;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeMethodInfoPtr_FreeMouse_Public_Void_Boolean_0;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerRay_Public_Ray_0;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeMethodInfoPtr_LerpCameraTransform_Private_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_ViewAvatar_Private_Void_0;

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_JoltCamera_Public_Void_0;

		// Token: 0x04002D4F RID: 11599
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x04002D50 RID: 11600
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr_ResetRotation_Public_Void_0;

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0;

		// Token: 0x04002D53 RID: 11603
		private static readonly IntPtr NativeMethodInfoPtr_StopFocus_Public_Void_0;

		// Token: 0x04002D54 RID: 11604
		private static readonly IntPtr NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04002D55 RID: 11605
		private static readonly IntPtr NativeMethodInfoPtr_StopCameraShake_Public_Void_0;

		// Token: 0x04002D56 RID: 11606
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0;

		// Token: 0x04002D57 RID: 11607
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0;

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr_RotateFreeCam_Private_Void_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeMethodInfoPtr_MoveFreeCam_Private_Void_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr__PlayerSpawned_b__104_0_Private_Void_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr__PlayerSpawned_b__104_1_Private_Void_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x02000A4B RID: 2635
		[OriginalName("Assembly-CSharp.dll", "", "ECameraMode")]
		public enum ECameraMode
		{
			// Token: 0x04009863 RID: 39011
			Default,
			// Token: 0x04009864 RID: 39012
			Vehicle,
			// Token: 0x04009865 RID: 39013
			Skateboard
		}

		// Token: 0x02000A4C RID: 2636
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<<Screenshot>g__Routine|111_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DFC6 RID: 57286 RVA: 0x00371284 File Offset: 0x0036F484
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<<Screenshot>g__Routine|111_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671881);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671882);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671883);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671884);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671885);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671886);
			}

			// Token: 0x0600DFC7 RID: 57287 RVA: 0x00371350 File Offset: 0x0036F550
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFC8 RID: 57288 RVA: 0x00371398 File Offset: 0x0036F598
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFC9 RID: 57289 RVA: 0x003713CC File Offset: 0x0036F5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158670, XrefRangeEnd = 158678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004419 RID: 17433
			// (get) Token: 0x0600DFCA RID: 57290 RVA: 0x00371408 File Offset: 0x0036F608
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFCB RID: 57291 RVA: 0x00371448 File Offset: 0x0036F648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158678, XrefRangeEnd = 158683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700441A RID: 17434
			// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x0037147C File Offset: 0x0036F67C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFCD RID: 57293 RVA: 0x0006960E File Offset: 0x0006780E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004417 RID: 17431
			// (get) Token: 0x0600DFCE RID: 57294 RVA: 0x003714BC File Offset: 0x0036F6BC
			// (set) Token: 0x0600DFCF RID: 57295 RVA: 0x00069617 File Offset: 0x00067817
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004418 RID: 17432
			// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x003714E4 File Offset: 0x0036F6E4
			// (set) Token: 0x0600DFD1 RID: 57297 RVA: 0x00069632 File Offset: 0x00067832
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009866 RID: 39014
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009867 RID: 39015
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009868 RID: 39016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009869 RID: 39017
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400986A RID: 39018
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400986B RID: 39019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400986C RID: 39020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400986D RID: 39021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A4D RID: 2637
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass131_0")]
		public sealed class __c__DisplayClass131_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFD2 RID: 57298 RVA: 0x00371514 File Offset: 0x0036F714
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass131_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass131_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, "point");
				PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass131_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, 100671887);
				PlayerCamera.__c__DisplayClass131_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, 100671888);
			}

			// Token: 0x0600DFD3 RID: 57299 RVA: 0x003715A4 File Offset: 0x0036F7A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass131_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFD4 RID: 57300 RVA: 0x003715E0 File Offset: 0x0036F7E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158738, RefRangeEnd = 158739, XrefRangeStart = 158733, XrefRangeEnd = 158738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFD5 RID: 57301 RVA: 0x00069651 File Offset: 0x00067851
			public __c__DisplayClass131_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441B RID: 17435
			// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x00371620 File Offset: 0x0036F820
			// (set) Token: 0x0600DFD7 RID: 57303 RVA: 0x0006965A File Offset: 0x0006785A
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x1700441C RID: 17436
			// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x00371648 File Offset: 0x0036F848
			// (set) Token: 0x0600DFD9 RID: 57305 RVA: 0x00069675 File Offset: 0x00067875
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441D RID: 17437
			// (get) Token: 0x0600DFDA RID: 57306 RVA: 0x00371678 File Offset: 0x0036F878
			// (set) Token: 0x0600DFDB RID: 57307 RVA: 0x00069694 File Offset: 0x00067894
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x0400986E RID: 39022
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x0400986F RID: 39023
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009870 RID: 39024
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009871 RID: 39025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009872 RID: 39026
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DC3 RID: 3523
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass131_0+<<LookAt>g__Look|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FE85 RID: 65157 RVA: 0x003C8EE4 File Offset: 0x003C70E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0>.NativeClassPtr, "<<LookAt>g__Look|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerEndRot>5__2");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraRotation>5__3");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerStartRot>5__4");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraStartRot>5__5");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<i>5__6");
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671889);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671890);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671891);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671892);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671893);
					PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100671894);
				}

				// Token: 0x0600FE86 RID: 65158 RVA: 0x003C9028 File Offset: 0x003C7228
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE87 RID: 65159 RVA: 0x003C9070 File Offset: 0x003C7270
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE88 RID: 65160 RVA: 0x003C90A4 File Offset: 0x003C72A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158683, XrefRangeEnd = 158728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D77 RID: 19831
				// (get) Token: 0x0600FE89 RID: 65161 RVA: 0x003C90E0 File Offset: 0x003C72E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE8A RID: 65162 RVA: 0x003C9120 File Offset: 0x003C7320
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158728, XrefRangeEnd = 158733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D78 RID: 19832
				// (get) Token: 0x0600FE8B RID: 65163 RVA: 0x003C9154 File Offset: 0x003C7354
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE8C RID: 65164 RVA: 0x000789A7 File Offset: 0x00076BA7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D6F RID: 19823
				// (get) Token: 0x0600FE8D RID: 65165 RVA: 0x003C9194 File Offset: 0x003C7394
				// (set) Token: 0x0600FE8E RID: 65166 RVA: 0x000789B0 File Offset: 0x00076BB0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D70 RID: 19824
				// (get) Token: 0x0600FE8F RID: 65167 RVA: 0x003C91BC File Offset: 0x003C73BC
				// (set) Token: 0x0600FE90 RID: 65168 RVA: 0x000789CB File Offset: 0x00076BCB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D71 RID: 19825
				// (get) Token: 0x0600FE91 RID: 65169 RVA: 0x003C91EC File Offset: 0x003C73EC
				// (set) Token: 0x0600FE92 RID: 65170 RVA: 0x000789EA File Offset: 0x00076BEA
				public unsafe PlayerCamera.__c__DisplayClass131_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass131_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D72 RID: 19826
				// (get) Token: 0x0600FE93 RID: 65171 RVA: 0x003C921C File Offset: 0x003C741C
				// (set) Token: 0x0600FE94 RID: 65172 RVA: 0x00078A09 File Offset: 0x00076C09
				public unsafe Quaternion _playerEndRot_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2)) = value;
					}
				}

				// Token: 0x17004D73 RID: 19827
				// (get) Token: 0x0600FE95 RID: 65173 RVA: 0x003C9244 File Offset: 0x003C7444
				// (set) Token: 0x0600FE96 RID: 65174 RVA: 0x00078A24 File Offset: 0x00076C24
				public unsafe Quaternion _cameraRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3)) = value;
					}
				}

				// Token: 0x17004D74 RID: 19828
				// (get) Token: 0x0600FE97 RID: 65175 RVA: 0x003C926C File Offset: 0x003C746C
				// (set) Token: 0x0600FE98 RID: 65176 RVA: 0x00078A3F File Offset: 0x00076C3F
				public unsafe Quaternion _playerStartRot_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4)) = value;
					}
				}

				// Token: 0x17004D75 RID: 19829
				// (get) Token: 0x0600FE99 RID: 65177 RVA: 0x003C9294 File Offset: 0x003C7494
				// (set) Token: 0x0600FE9A RID: 65178 RVA: 0x00078A5A File Offset: 0x00076C5A
				public unsafe Quaternion _cameraStartRot_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5)) = value;
					}
				}

				// Token: 0x17004D76 RID: 19830
				// (get) Token: 0x0600FE9B RID: 65179 RVA: 0x003C92BC File Offset: 0x003C74BC
				// (set) Token: 0x0600FE9C RID: 65180 RVA: 0x00078A75 File Offset: 0x00076C75
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass131_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x0400AB89 RID: 43913
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB8A RID: 43914
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB8B RID: 43915
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB8C RID: 43916
				private static readonly IntPtr NativeFieldInfoPtr__playerEndRot_5__2;

				// Token: 0x0400AB8D RID: 43917
				private static readonly IntPtr NativeFieldInfoPtr__cameraRotation_5__3;

				// Token: 0x0400AB8E RID: 43918
				private static readonly IntPtr NativeFieldInfoPtr__playerStartRot_5__4;

				// Token: 0x0400AB8F RID: 43919
				private static readonly IntPtr NativeFieldInfoPtr__cameraStartRot_5__5;

				// Token: 0x0400AB90 RID: 43920
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x0400AB91 RID: 43921
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB92 RID: 43922
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB93 RID: 43923
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB94 RID: 43924
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB95 RID: 43925
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB96 RID: 43926
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A4E RID: 2638
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass151_0")]
		public sealed class __c__DisplayClass151_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFDC RID: 57308 RVA: 0x003716A0 File Offset: 0x0036F8A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass151_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass151_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr, "target");
				PlayerCamera.__c__DisplayClass151_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr, 100671895);
				PlayerCamera.__c__DisplayClass151_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr, 100671896);
			}

			// Token: 0x0600DFDD RID: 57309 RVA: 0x0037171C File Offset: 0x0036F91C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass151_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFDE RID: 57310 RVA: 0x00371758 File Offset: 0x0036F958
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158796, RefRangeEnd = 158797, XrefRangeStart = 158791, XrefRangeEnd = 158796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFDF RID: 57311 RVA: 0x000696AF File Offset: 0x000678AF
			public __c__DisplayClass151_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441E RID: 17438
			// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x00371798 File Offset: 0x0036F998
			// (set) Token: 0x0600DFE1 RID: 57313 RVA: 0x000696B8 File Offset: 0x000678B8
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441F RID: 17439
			// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x003717C8 File Offset: 0x0036F9C8
			// (set) Token: 0x0600DFE3 RID: 57315 RVA: 0x000696D7 File Offset: 0x000678D7
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009873 RID: 39027
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009874 RID: 39028
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04009875 RID: 39029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009876 RID: 39030
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DC4 RID: 3524
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass151_0+<<FocusCameraOnTarget>g__FocusRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FE9D RID: 65181 RVA: 0x003C92E4 File Offset: 0x003C74E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0>.NativeClassPtr, "<<FocusCameraOnTarget>g__FocusRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<duration>5__2");
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671897);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671898);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671899);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671900);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671901);
					PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671902);
				}

				// Token: 0x0600FE9E RID: 65182 RVA: 0x003C93D8 File Offset: 0x003C75D8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE9F RID: 65183 RVA: 0x003C9420 File Offset: 0x003C7620
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEA0 RID: 65184 RVA: 0x003C9454 File Offset: 0x003C7654
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158739, XrefRangeEnd = 158786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D7D RID: 19837
				// (get) Token: 0x0600FEA1 RID: 65185 RVA: 0x003C9490 File Offset: 0x003C7690
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEA2 RID: 65186 RVA: 0x003C94D0 File Offset: 0x003C76D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158786, XrefRangeEnd = 158791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D7E RID: 19838
				// (get) Token: 0x0600FEA3 RID: 65187 RVA: 0x003C9504 File Offset: 0x003C7704
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEA4 RID: 65188 RVA: 0x00078A90 File Offset: 0x00076C90
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D79 RID: 19833
				// (get) Token: 0x0600FEA5 RID: 65189 RVA: 0x003C9544 File Offset: 0x003C7744
				// (set) Token: 0x0600FEA6 RID: 65190 RVA: 0x00078A99 File Offset: 0x00076C99
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D7A RID: 19834
				// (get) Token: 0x0600FEA7 RID: 65191 RVA: 0x003C956C File Offset: 0x003C776C
				// (set) Token: 0x0600FEA8 RID: 65192 RVA: 0x00078AB4 File Offset: 0x00076CB4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D7B RID: 19835
				// (get) Token: 0x0600FEA9 RID: 65193 RVA: 0x003C959C File Offset: 0x003C779C
				// (set) Token: 0x0600FEAA RID: 65194 RVA: 0x00078AD3 File Offset: 0x00076CD3
				public unsafe PlayerCamera.__c__DisplayClass151_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass151_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D7C RID: 19836
				// (get) Token: 0x0600FEAB RID: 65195 RVA: 0x003C95CC File Offset: 0x003C77CC
				// (set) Token: 0x0600FEAC RID: 65196 RVA: 0x00078AF2 File Offset: 0x00076CF2
				public unsafe float _duration_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass151_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2)) = value;
					}
				}

				// Token: 0x0400AB97 RID: 43927
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB98 RID: 43928
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB99 RID: 43929
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB9A RID: 43930
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__2;

				// Token: 0x0400AB9B RID: 43931
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB9C RID: 43932
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB9D RID: 43933
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB9E RID: 43934
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB9F RID: 43935
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABA0 RID: 43936
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A4F RID: 2639
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass153_0")]
		public sealed class __c__DisplayClass153_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE4 RID: 57316 RVA: 0x003717F8 File Offset: 0x0036F9F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass153_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass153_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, "intensity");
				PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_decreaseOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, "decreaseOverTime");
				PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass153_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, 100671903);
				PlayerCamera.__c__DisplayClass153_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, 100671904);
			}

			// Token: 0x0600DFE5 RID: 57317 RVA: 0x0037189C File Offset: 0x0036FA9C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass153_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE6 RID: 57318 RVA: 0x003718D8 File Offset: 0x0036FAD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158817, RefRangeEnd = 158818, XrefRangeStart = 158812, XrefRangeEnd = 158817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFE7 RID: 57319 RVA: 0x000696F6 File Offset: 0x000678F6
			public __c__DisplayClass153_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004420 RID: 17440
			// (get) Token: 0x0600DFE8 RID: 57320 RVA: 0x00371918 File Offset: 0x0036FB18
			// (set) Token: 0x0600DFE9 RID: 57321 RVA: 0x000696FF File Offset: 0x000678FF
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004421 RID: 17441
			// (get) Token: 0x0600DFEA RID: 57322 RVA: 0x00371940 File Offset: 0x0036FB40
			// (set) Token: 0x0600DFEB RID: 57323 RVA: 0x0006971A File Offset: 0x0006791A
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x00371968 File Offset: 0x0036FB68
			// (set) Token: 0x0600DFED RID: 57325 RVA: 0x00069735 File Offset: 0x00067935
			public unsafe bool decreaseOverTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_decreaseOverTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr_decreaseOverTime)) = value;
				}
			}

			// Token: 0x17004423 RID: 17443
			// (get) Token: 0x0600DFEE RID: 57326 RVA: 0x00371990 File Offset: 0x0036FB90
			// (set) Token: 0x0600DFEF RID: 57327 RVA: 0x00069750 File Offset: 0x00067950
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009877 RID: 39031
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009878 RID: 39032
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04009879 RID: 39033
			private static readonly IntPtr NativeFieldInfoPtr_decreaseOverTime;

			// Token: 0x0400987A RID: 39034
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400987B RID: 39035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400987C RID: 39036
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DC5 RID: 3525
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass153_0+<<StartCameraShake>g__Shake|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FEAD RID: 65197 RVA: 0x003C95F4 File Offset: 0x003C77F4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0>.NativeClassPtr, "<<StartCameraShake>g__Shake|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<timeRemaining>5__2");
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671905);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671906);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671907);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671908);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671909);
					PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671910);
				}

				// Token: 0x0600FEAE RID: 65198 RVA: 0x003C96E8 File Offset: 0x003C78E8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEAF RID: 65199 RVA: 0x003C9730 File Offset: 0x003C7930
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEB0 RID: 65200 RVA: 0x003C9764 File Offset: 0x003C7964
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158797, XrefRangeEnd = 158807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D83 RID: 19843
				// (get) Token: 0x0600FEB1 RID: 65201 RVA: 0x003C97A0 File Offset: 0x003C79A0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEB2 RID: 65202 RVA: 0x003C97E0 File Offset: 0x003C79E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158807, XrefRangeEnd = 158812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D84 RID: 19844
				// (get) Token: 0x0600FEB3 RID: 65203 RVA: 0x003C9814 File Offset: 0x003C7A14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEB4 RID: 65204 RVA: 0x00078B0D File Offset: 0x00076D0D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D7F RID: 19839
				// (get) Token: 0x0600FEB5 RID: 65205 RVA: 0x003C9854 File Offset: 0x003C7A54
				// (set) Token: 0x0600FEB6 RID: 65206 RVA: 0x00078B16 File Offset: 0x00076D16
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D80 RID: 19840
				// (get) Token: 0x0600FEB7 RID: 65207 RVA: 0x003C987C File Offset: 0x003C7A7C
				// (set) Token: 0x0600FEB8 RID: 65208 RVA: 0x00078B31 File Offset: 0x00076D31
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D81 RID: 19841
				// (get) Token: 0x0600FEB9 RID: 65209 RVA: 0x003C98AC File Offset: 0x003C7AAC
				// (set) Token: 0x0600FEBA RID: 65210 RVA: 0x00078B50 File Offset: 0x00076D50
				public unsafe PlayerCamera.__c__DisplayClass153_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass153_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D82 RID: 19842
				// (get) Token: 0x0600FEBB RID: 65211 RVA: 0x003C98DC File Offset: 0x003C7ADC
				// (set) Token: 0x0600FEBC RID: 65212 RVA: 0x00078B6F File Offset: 0x00076D6F
				public unsafe float _timeRemaining_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass153_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2)) = value;
					}
				}

				// Token: 0x0400ABA1 RID: 43937
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABA2 RID: 43938
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABA3 RID: 43939
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABA4 RID: 43940
				private static readonly IntPtr NativeFieldInfoPtr__timeRemaining_5__2;

				// Token: 0x0400ABA5 RID: 43941
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABA6 RID: 43942
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABA7 RID: 43943
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABA8 RID: 43944
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABA9 RID: 43945
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABAA RID: 43946
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A50 RID: 2640
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpFOV>d__138")]
		public sealed class _ILerpFOV_d__138 : Il2CppSystem.Object
		{
			// Token: 0x0600DFF0 RID: 57328 RVA: 0x003719C0 File Offset: 0x0036FBC0
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpFOV_d__138()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpFOV>d__138");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr);
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_endFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "endFov");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__startFov_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "<startFov>5__2");
				PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, "<i>5__3");
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671911);
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671912);
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671913);
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671914);
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671915);
				PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr, 100671916);
			}

			// Token: 0x0600DFF1 RID: 57329 RVA: 0x00371AF0 File Offset: 0x0036FCF0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpFOV_d__138(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__138>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF2 RID: 57330 RVA: 0x00371B38 File Offset: 0x0036FD38
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF3 RID: 57331 RVA: 0x00371B6C File Offset: 0x0036FD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158818, XrefRangeEnd = 158828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700442B RID: 17451
			// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x00371BA8 File Offset: 0x0036FDA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFF5 RID: 57333 RVA: 0x00371BE8 File Offset: 0x0036FDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158828, XrefRangeEnd = 158833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700442C RID: 17452
			// (get) Token: 0x0600DFF6 RID: 57334 RVA: 0x00371C1C File Offset: 0x0036FE1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFF7 RID: 57335 RVA: 0x0006976F File Offset: 0x0006796F
			public _ILerpFOV_d__138(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004424 RID: 17444
			// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x00371C5C File Offset: 0x0036FE5C
			// (set) Token: 0x0600DFF9 RID: 57337 RVA: 0x00069778 File Offset: 0x00067978
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004425 RID: 17445
			// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x00371C84 File Offset: 0x0036FE84
			// (set) Token: 0x0600DFFB RID: 57339 RVA: 0x00069793 File Offset: 0x00067993
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004426 RID: 17446
			// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x00371CB4 File Offset: 0x0036FEB4
			// (set) Token: 0x0600DFFD RID: 57341 RVA: 0x000697B2 File Offset: 0x000679B2
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004427 RID: 17447
			// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x00371CE4 File Offset: 0x0036FEE4
			// (set) Token: 0x0600DFFF RID: 57343 RVA: 0x000697D1 File Offset: 0x000679D1
			public unsafe float endFov
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_endFov);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_endFov)) = value;
				}
			}

			// Token: 0x17004428 RID: 17448
			// (get) Token: 0x0600E000 RID: 57344 RVA: 0x00371D0C File Offset: 0x0036FF0C
			// (set) Token: 0x0600E001 RID: 57345 RVA: 0x000697EC File Offset: 0x000679EC
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004429 RID: 17449
			// (get) Token: 0x0600E002 RID: 57346 RVA: 0x00371D34 File Offset: 0x0036FF34
			// (set) Token: 0x0600E003 RID: 57347 RVA: 0x00069807 File Offset: 0x00067A07
			public unsafe float _startFov_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__startFov_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__startFov_5__2)) = value;
				}
			}

			// Token: 0x1700442A RID: 17450
			// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00371D5C File Offset: 0x0036FF5C
			// (set) Token: 0x0600E005 RID: 57349 RVA: 0x00069822 File Offset: 0x00067A22
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__138.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400987D RID: 39037
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400987E RID: 39038
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400987F RID: 39039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009880 RID: 39040
			private static readonly IntPtr NativeFieldInfoPtr_endFov;

			// Token: 0x04009881 RID: 39041
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04009882 RID: 39042
			private static readonly IntPtr NativeFieldInfoPtr__startFov_5__2;

			// Token: 0x04009883 RID: 39043
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009884 RID: 39044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009885 RID: 39045
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009886 RID: 39046
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009887 RID: 39047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009888 RID: 39048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009889 RID: 39049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A51 RID: 2641
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<LerpCameraTransform>d__128")]
		public sealed class _LerpCameraTransform_d__128 : Il2CppSystem.Object
		{
			// Token: 0x0600E006 RID: 57350 RVA: 0x00371D84 File Offset: 0x0036FF84
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpCameraTransform_d__128()
			{
				Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<LerpCameraTransform>d__128");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr);
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<>1__state");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<>2__current");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<>4__this");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "worldSpace");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_returnToRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "returnToRestingPosition");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "lerpTime");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "endPos");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "endRot");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_enableLookWhenDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "enableLookWhenDone");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<startPos>5__2");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startRot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<startRot>5__3");
				PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, "<elapsed>5__4");
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671917);
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671918);
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671919);
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671920);
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671921);
				PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr, 100671922);
			}

			// Token: 0x0600E007 RID: 57351 RVA: 0x00371F18 File Offset: 0x00370118
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpCameraTransform_d__128(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._LerpCameraTransform_d__128>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E008 RID: 57352 RVA: 0x00371F60 File Offset: 0x00370160
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E009 RID: 57353 RVA: 0x00371F94 File Offset: 0x00370194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158833, XrefRangeEnd = 158873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004439 RID: 17465
			// (get) Token: 0x0600E00A RID: 57354 RVA: 0x00371FD0 File Offset: 0x003701D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E00B RID: 57355 RVA: 0x00372010 File Offset: 0x00370210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158873, XrefRangeEnd = 158878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700443A RID: 17466
			// (get) Token: 0x0600E00C RID: 57356 RVA: 0x00372044 File Offset: 0x00370244
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpCameraTransform_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E00D RID: 57357 RVA: 0x0006983D File Offset: 0x00067A3D
			public _LerpCameraTransform_d__128(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442D RID: 17453
			// (get) Token: 0x0600E00E RID: 57358 RVA: 0x00372084 File Offset: 0x00370284
			// (set) Token: 0x0600E00F RID: 57359 RVA: 0x00069846 File Offset: 0x00067A46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700442E RID: 17454
			// (get) Token: 0x0600E010 RID: 57360 RVA: 0x003720AC File Offset: 0x003702AC
			// (set) Token: 0x0600E011 RID: 57361 RVA: 0x00069861 File Offset: 0x00067A61
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442F RID: 17455
			// (get) Token: 0x0600E012 RID: 57362 RVA: 0x003720DC File Offset: 0x003702DC
			// (set) Token: 0x0600E013 RID: 57363 RVA: 0x00069880 File Offset: 0x00067A80
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004430 RID: 17456
			// (get) Token: 0x0600E014 RID: 57364 RVA: 0x0037210C File Offset: 0x0037030C
			// (set) Token: 0x0600E015 RID: 57365 RVA: 0x0006989F File Offset: 0x00067A9F
			public unsafe bool worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x17004431 RID: 17457
			// (get) Token: 0x0600E016 RID: 57366 RVA: 0x00372134 File Offset: 0x00370334
			// (set) Token: 0x0600E017 RID: 57367 RVA: 0x000698BA File Offset: 0x00067ABA
			public unsafe bool returnToRestingPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_returnToRestingPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_returnToRestingPosition)) = value;
				}
			}

			// Token: 0x17004432 RID: 17458
			// (get) Token: 0x0600E018 RID: 57368 RVA: 0x0037215C File Offset: 0x0037035C
			// (set) Token: 0x0600E019 RID: 57369 RVA: 0x000698D5 File Offset: 0x00067AD5
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004433 RID: 17459
			// (get) Token: 0x0600E01A RID: 57370 RVA: 0x00372184 File Offset: 0x00370384
			// (set) Token: 0x0600E01B RID: 57371 RVA: 0x000698F0 File Offset: 0x00067AF0
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004434 RID: 17460
			// (get) Token: 0x0600E01C RID: 57372 RVA: 0x003721AC File Offset: 0x003703AC
			// (set) Token: 0x0600E01D RID: 57373 RVA: 0x0006990B File Offset: 0x00067B0B
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x17004435 RID: 17461
			// (get) Token: 0x0600E01E RID: 57374 RVA: 0x003721D4 File Offset: 0x003703D4
			// (set) Token: 0x0600E01F RID: 57375 RVA: 0x00069926 File Offset: 0x00067B26
			public unsafe bool enableLookWhenDone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_enableLookWhenDone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr_enableLookWhenDone)) = value;
				}
			}

			// Token: 0x17004436 RID: 17462
			// (get) Token: 0x0600E020 RID: 57376 RVA: 0x003721FC File Offset: 0x003703FC
			// (set) Token: 0x0600E021 RID: 57377 RVA: 0x00069941 File Offset: 0x00067B41
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17004437 RID: 17463
			// (get) Token: 0x0600E022 RID: 57378 RVA: 0x00372224 File Offset: 0x00370424
			// (set) Token: 0x0600E023 RID: 57379 RVA: 0x0006995C File Offset: 0x00067B5C
			public unsafe Quaternion _startRot_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startRot_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__startRot_5__3)) = value;
				}
			}

			// Token: 0x17004438 RID: 17464
			// (get) Token: 0x0600E024 RID: 57380 RVA: 0x0037224C File Offset: 0x0037044C
			// (set) Token: 0x0600E025 RID: 57381 RVA: 0x00069977 File Offset: 0x00067B77
			public unsafe float _elapsed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpCameraTransform_d__128.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x0400988A RID: 39050
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400988B RID: 39051
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400988C RID: 39052
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400988D RID: 39053
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x0400988E RID: 39054
			private static readonly IntPtr NativeFieldInfoPtr_returnToRestingPosition;

			// Token: 0x0400988F RID: 39055
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04009890 RID: 39056
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009891 RID: 39057
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x04009892 RID: 39058
			private static readonly IntPtr NativeFieldInfoPtr_enableLookWhenDone;

			// Token: 0x04009893 RID: 39059
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x04009894 RID: 39060
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__3;

			// Token: 0x04009895 RID: 39061
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04009896 RID: 39062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009897 RID: 39063
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009898 RID: 39064
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009899 RID: 39065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400989A RID: 39066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400989B RID: 39067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A52 RID: 2642
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<LerpDoF>d__135")]
		public sealed class _LerpDoF_d__135 : Il2CppSystem.Object
		{
			// Token: 0x0600E026 RID: 57382 RVA: 0x00372274 File Offset: 0x00370474
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpDoF_d__135()
			{
				Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<LerpDoF>d__135");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr);
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<>1__state");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<>2__current");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "active");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<>4__this");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "lerpTime");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__startFocusDist_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<startFocusDist>5__2");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__endFocusDist_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<endFocusDist>5__3");
				PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, "<i>5__4");
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671923);
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671924);
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671925);
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671926);
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671927);
				PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr, 100671928);
			}

			// Token: 0x0600E027 RID: 57383 RVA: 0x003723B8 File Offset: 0x003705B8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpDoF_d__135(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__135>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E028 RID: 57384 RVA: 0x00372400 File Offset: 0x00370600
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E029 RID: 57385 RVA: 0x00372434 File Offset: 0x00370634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158878, XrefRangeEnd = 158887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004443 RID: 17475
			// (get) Token: 0x0600E02A RID: 57386 RVA: 0x00372470 File Offset: 0x00370670
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E02B RID: 57387 RVA: 0x003724B0 File Offset: 0x003706B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158887, XrefRangeEnd = 158892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004444 RID: 17476
			// (get) Token: 0x0600E02C RID: 57388 RVA: 0x003724E4 File Offset: 0x003706E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E02D RID: 57389 RVA: 0x00069992 File Offset: 0x00067B92
			public _LerpDoF_d__135(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443B RID: 17467
			// (get) Token: 0x0600E02E RID: 57390 RVA: 0x00372524 File Offset: 0x00370724
			// (set) Token: 0x0600E02F RID: 57391 RVA: 0x0006999B File Offset: 0x00067B9B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700443C RID: 17468
			// (get) Token: 0x0600E030 RID: 57392 RVA: 0x0037254C File Offset: 0x0037074C
			// (set) Token: 0x0600E031 RID: 57393 RVA: 0x000699B6 File Offset: 0x00067BB6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443D RID: 17469
			// (get) Token: 0x0600E032 RID: 57394 RVA: 0x0037257C File Offset: 0x0037077C
			// (set) Token: 0x0600E033 RID: 57395 RVA: 0x000699D5 File Offset: 0x00067BD5
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x1700443E RID: 17470
			// (get) Token: 0x0600E034 RID: 57396 RVA: 0x003725A4 File Offset: 0x003707A4
			// (set) Token: 0x0600E035 RID: 57397 RVA: 0x000699F0 File Offset: 0x00067BF0
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443F RID: 17471
			// (get) Token: 0x0600E036 RID: 57398 RVA: 0x003725D4 File Offset: 0x003707D4
			// (set) Token: 0x0600E037 RID: 57399 RVA: 0x00069A0F File Offset: 0x00067C0F
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004440 RID: 17472
			// (get) Token: 0x0600E038 RID: 57400 RVA: 0x003725FC File Offset: 0x003707FC
			// (set) Token: 0x0600E039 RID: 57401 RVA: 0x00069A2A File Offset: 0x00067C2A
			public unsafe float _startFocusDist_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__startFocusDist_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__startFocusDist_5__2)) = value;
				}
			}

			// Token: 0x17004441 RID: 17473
			// (get) Token: 0x0600E03A RID: 57402 RVA: 0x00372624 File Offset: 0x00370824
			// (set) Token: 0x0600E03B RID: 57403 RVA: 0x00069A45 File Offset: 0x00067C45
			public unsafe float _endFocusDist_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__endFocusDist_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__endFocusDist_5__3)) = value;
				}
			}

			// Token: 0x17004442 RID: 17474
			// (get) Token: 0x0600E03C RID: 57404 RVA: 0x0037264C File Offset: 0x0037084C
			// (set) Token: 0x0600E03D RID: 57405 RVA: 0x00069A60 File Offset: 0x00067C60
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__135.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400989C RID: 39068
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400989D RID: 39069
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400989E RID: 39070
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x0400989F RID: 39071
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098A0 RID: 39072
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040098A1 RID: 39073
			private static readonly IntPtr NativeFieldInfoPtr__startFocusDist_5__2;

			// Token: 0x040098A2 RID: 39074
			private static readonly IntPtr NativeFieldInfoPtr__endFocusDist_5__3;

			// Token: 0x040098A3 RID: 39075
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040098A4 RID: 39076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098A5 RID: 39077
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098A6 RID: 39078
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040098A7 RID: 39079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040098A8 RID: 39080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098A9 RID: 39081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
