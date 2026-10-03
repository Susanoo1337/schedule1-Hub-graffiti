using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000BF RID: 191
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x06001139 RID: 4409 RVA: 0x000B4CBC File Offset: 0x000B2EBC
		// Note: this type is marked as 'beforefieldinit'.
		static GameInput()
		{
			Il2CppClassPointerStore<GameInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "GameInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput>.NativeClassPtr);
			GameInput.NativeFieldInfoPtr__CurrentInputDevice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<CurrentInputDevice>k__BackingField");
			GameInput.NativeFieldInfoPtr__CurrentPlatformType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<CurrentPlatformType>k__BackingField");
			GameInput.NativeFieldInfoPtr_OnInputDeviceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "OnInputDeviceChanged");
			GameInput.NativeFieldInfoPtr_exitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "exitListeners");
			GameInput.NativeFieldInfoPtr_PlayerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "PlayerInput");
			GameInput.NativeFieldInfoPtr_PrimaryExitAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "PrimaryExitAction");
			GameInput.NativeFieldInfoPtr_SecondaryExitAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "SecondaryExitAction");
			GameInput.NativeFieldInfoPtr__isTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "_isTyping");
			GameInput.NativeFieldInfoPtr_MotionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "MotionAxis");
			GameInput.NativeFieldInfoPtr_CameraAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "CameraAxis");
			GameInput.NativeFieldInfoPtr_systemMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "systemMouse");
			GameInput.NativeFieldInfoPtr_MouseWheelAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "MouseWheelAxis");
			GameInput.NativeFieldInfoPtr_ControllerComboActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ControllerComboActive");
			GameInput.NativeFieldInfoPtr_vehicleDriveAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "vehicleDriveAxis");
			GameInput.NativeFieldInfoPtr__UINavigationDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UINavigationDirection>k__BackingField");
			GameInput.NativeFieldInfoPtr__UICyclePanelDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UICyclePanelDirection>k__BackingField");
			GameInput.NativeFieldInfoPtr__UITabNavigationPrimaryAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UITabNavigationPrimaryAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UITabNavigationSecondaryAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UITabNavigationSecondaryAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UITabNavigationTertiaryAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UITabNavigationTertiaryAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIScrollbarAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIScrollbarAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIMapNavigationDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIMapNavigationDirection>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIMapZoomAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIMapZoomAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierOneAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIModifyAmountIncrementTierOneAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierTwoAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIModifyAmountIncrementTierTwoAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierThreeAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<UIModifyAmountIncrementTierThreeAxis>k__BackingField");
			GameInput.NativeFieldInfoPtr_buttonsDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDownThisFrame");
			GameInput.NativeFieldInfoPtr_buttonsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDown");
			GameInput.NativeFieldInfoPtr_buttonsUpThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsUpThisFrame");
			GameInput.NativeFieldInfoPtr__timeOnLastRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "_timeOnLastRebind");
			GameInput.NativeMethodInfoPtr_get_CurrentInputDevice_Public_Static_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665813);
			GameInput.NativeMethodInfoPtr_set_CurrentInputDevice_Private_Static_set_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665814);
			GameInput.NativeMethodInfoPtr_get_CurrentPlatformType_Public_Static_get_EPlatformType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665815);
			GameInput.NativeMethodInfoPtr_set_CurrentPlatformType_Private_Static_set_Void_EPlatformType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665816);
			GameInput.NativeMethodInfoPtr_get_IsTyping_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665817);
			GameInput.NativeMethodInfoPtr_set_IsTyping_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665818);
			GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665819);
			GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665820);
			GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665821);
			GameInput.NativeMethodInfoPtr_get_VehicleDriveAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665822);
			GameInput.NativeMethodInfoPtr_set_VehicleDriveAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665823);
			GameInput.NativeMethodInfoPtr_get_UINavigationDirection_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665824);
			GameInput.NativeMethodInfoPtr_set_UINavigationDirection_Private_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665825);
			GameInput.NativeMethodInfoPtr_get_UICyclePanelDirection_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665826);
			GameInput.NativeMethodInfoPtr_set_UICyclePanelDirection_Private_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665827);
			GameInput.NativeMethodInfoPtr_get_UITabNavigationPrimaryAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665828);
			GameInput.NativeMethodInfoPtr_set_UITabNavigationPrimaryAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665829);
			GameInput.NativeMethodInfoPtr_get_UITabNavigationSecondaryAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665830);
			GameInput.NativeMethodInfoPtr_set_UITabNavigationSecondaryAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665831);
			GameInput.NativeMethodInfoPtr_get_UITabNavigationTertiaryAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665832);
			GameInput.NativeMethodInfoPtr_set_UITabNavigationTertiaryAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665833);
			GameInput.NativeMethodInfoPtr_get_UIScrollbarAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665834);
			GameInput.NativeMethodInfoPtr_set_UIScrollbarAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665835);
			GameInput.NativeMethodInfoPtr_get_UIMapNavigationDirection_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665836);
			GameInput.NativeMethodInfoPtr_set_UIMapNavigationDirection_Private_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665837);
			GameInput.NativeMethodInfoPtr_get_UIMapZoomAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665838);
			GameInput.NativeMethodInfoPtr_set_UIMapZoomAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665839);
			GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierOneAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665840);
			GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierOneAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665841);
			GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierTwoAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665842);
			GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierTwoAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665843);
			GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierThreeAxis_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665844);
			GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierThreeAxis_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665845);
			GameInput.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665846);
			GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665847);
			GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665848);
			GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665849);
			GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665850);
			GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665851);
			GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665852);
			GameInput.NativeMethodInfoPtr_GetCurrentInputDeviceIsKeyboardMouse_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665853);
			GameInput.NativeMethodInfoPtr_GetCurrentInputDeviceIsGamepad_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665854);
			GameInput.NativeMethodInfoPtr_GetCurrentInputDevice_Public_Static_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665855);
			GameInput.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665856);
			GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665857);
			GameInput.NativeMethodInfoPtr_HandleExitInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665858);
			GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665859);
			GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665860);
			GameInput.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665861);
			GameInput.NativeMethodInfoPtr_OnControlsChanged_Private_Void_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665862);
			GameInput.NativeMethodInfoPtr_TryGetAction_Public_Boolean_String_byref_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665863);
			GameInput.NativeMethodInfoPtr_SetCurrentPlatformType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665864);
			GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665865);
			GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665866);
			GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665867);
			GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665868);
			GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665869);
			GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665870);
			GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665871);
			GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665872);
			GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665873);
			GameInput.NativeMethodInfoPtr_OnVehicleToggleLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665874);
			GameInput.NativeMethodInfoPtr_OnVehicleHandbrake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665875);
			GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665876);
			GameInput.NativeMethodInfoPtr_OnCamera_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665877);
			GameInput.NativeMethodInfoPtr_OnScrollWheel_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665878);
			GameInput.NativeMethodInfoPtr_OnInventoryLeft_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665879);
			GameInput.NativeMethodInfoPtr_OnInventoryRight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665880);
			GameInput.NativeMethodInfoPtr_OnControllerCombo_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665881);
			GameInput.NativeMethodInfoPtr_OnVehicleResetCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665882);
			GameInput.NativeMethodInfoPtr_OnVehicleDrive_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665883);
			GameInput.NativeMethodInfoPtr_OnSkateboardDismount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665884);
			GameInput.NativeMethodInfoPtr_OnSkateboardMount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665885);
			GameInput.NativeMethodInfoPtr_OnUINavigationDirection_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665886);
			GameInput.NativeMethodInfoPtr_OnUICyclePanelDirection_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665887);
			GameInput.NativeMethodInfoPtr_OnUITabNavigationPrimary_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665888);
			GameInput.NativeMethodInfoPtr_OnUITabNavigationSecondary_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665889);
			GameInput.NativeMethodInfoPtr_OnUITabNavigationTertiary_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665890);
			GameInput.NativeMethodInfoPtr_OnUIScrollbar_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665891);
			GameInput.NativeMethodInfoPtr_OnUIMapNavigationDirection_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665892);
			GameInput.NativeMethodInfoPtr_OnUIMapZoom_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665893);
			GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierOne_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665894);
			GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierTwo_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665895);
			GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierThree_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665896);
			GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665897);
			GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665898);
			GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_Action_Func_1_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665899);
			GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665900);
			GameInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100665901);
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x000B5624 File Offset: 0x000B3824
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x000B5654 File Offset: 0x000B3854
		public unsafe static GameInput.InputDeviceType CurrentInputDevice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89369, XrefRangeEnd = 89373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_CurrentInputDevice_Public_Static_get_InputDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89373, XrefRangeEnd = 89377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_CurrentInputDevice_Private_Static_set_Void_InputDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000B5688 File Offset: 0x000B3888
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x000B56B8 File Offset: 0x000B38B8
		public unsafe static EPlatformType CurrentPlatformType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89377, XrefRangeEnd = 89381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_CurrentPlatformType_Public_Static_get_EPlatformType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89381, XrefRangeEnd = 89385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_CurrentPlatformType_Private_Static_set_Void_EPlatformType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x000B56EC File Offset: 0x000B38EC
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x000B571C File Offset: 0x000B391C
		public unsafe static bool IsTyping
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 89390, RefRangeEnd = 89416, XrefRangeStart = 89385, XrefRangeEnd = 89390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_IsTyping_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89416, XrefRangeEnd = 89420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_IsTyping_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000B5750 File Offset: 0x000B3950
		public unsafe static Vector2 MouseDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89420, XrefRangeEnd = 89424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000B5780 File Offset: 0x000B3980
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 89445, RefRangeEnd = 89469, XrefRangeStart = 89424, XrefRangeEnd = 89445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x000B57B0 File Offset: 0x000B39B0
		public unsafe static float MouseScrollDelta
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 89473, RefRangeEnd = 89480, XrefRangeStart = 89469, XrefRangeEnd = 89473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000B57E0 File Offset: 0x000B39E0
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x000B5810 File Offset: 0x000B3A10
		public unsafe static float VehicleDriveAxis
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89492, RefRangeEnd = 89495, XrefRangeStart = 89480, XrefRangeEnd = 89492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_VehicleDriveAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89495, XrefRangeEnd = 89499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_VehicleDriveAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x000B5844 File Offset: 0x000B3A44
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x000B5874 File Offset: 0x000B3A74
		public unsafe static Vector2 UINavigationDirection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89499, XrefRangeEnd = 89503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UINavigationDirection_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89503, XrefRangeEnd = 89507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UINavigationDirection_Private_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x000B58A8 File Offset: 0x000B3AA8
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x000B58D8 File Offset: 0x000B3AD8
		public unsafe static Vector2 UICyclePanelDirection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89507, XrefRangeEnd = 89511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UICyclePanelDirection_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89511, XrefRangeEnd = 89515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UICyclePanelDirection_Private_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000B590C File Offset: 0x000B3B0C
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x000B593C File Offset: 0x000B3B3C
		public unsafe static float UITabNavigationPrimaryAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89515, XrefRangeEnd = 89519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UITabNavigationPrimaryAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89519, XrefRangeEnd = 89523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UITabNavigationPrimaryAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x000B5970 File Offset: 0x000B3B70
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x000B59A0 File Offset: 0x000B3BA0
		public unsafe static float UITabNavigationSecondaryAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89523, XrefRangeEnd = 89527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UITabNavigationSecondaryAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89527, XrefRangeEnd = 89531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UITabNavigationSecondaryAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000B59D4 File Offset: 0x000B3BD4
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000B5A04 File Offset: 0x000B3C04
		public unsafe static float UITabNavigationTertiaryAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89531, XrefRangeEnd = 89535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UITabNavigationTertiaryAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89535, XrefRangeEnd = 89539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UITabNavigationTertiaryAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000B5A38 File Offset: 0x000B3C38
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000B5A68 File Offset: 0x000B3C68
		public unsafe static float UIScrollbarAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89539, XrefRangeEnd = 89543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIScrollbarAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89543, XrefRangeEnd = 89547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIScrollbarAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000B5A9C File Offset: 0x000B3C9C
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x000B5ACC File Offset: 0x000B3CCC
		public unsafe static Vector2 UIMapNavigationDirection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89547, XrefRangeEnd = 89551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIMapNavigationDirection_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89551, XrefRangeEnd = 89555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIMapNavigationDirection_Private_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000B5B00 File Offset: 0x000B3D00
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x000B5B30 File Offset: 0x000B3D30
		public unsafe static float UIMapZoomAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89555, XrefRangeEnd = 89559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIMapZoomAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89559, XrefRangeEnd = 89563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIMapZoomAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000B5B64 File Offset: 0x000B3D64
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x000B5B94 File Offset: 0x000B3D94
		public unsafe static float UIModifyAmountIncrementTierOneAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89563, XrefRangeEnd = 89567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierOneAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89567, XrefRangeEnd = 89571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierOneAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000B5BC8 File Offset: 0x000B3DC8
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x000B5BF8 File Offset: 0x000B3DF8
		public unsafe static float UIModifyAmountIncrementTierTwoAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89571, XrefRangeEnd = 89575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierTwoAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89575, XrefRangeEnd = 89579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierTwoAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x000B5C5C File Offset: 0x000B3E5C
		public unsafe static float UIModifyAmountIncrementTierThreeAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89579, XrefRangeEnd = 89583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_UIModifyAmountIncrementTierThreeAxis_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89583, XrefRangeEnd = 89587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_set_UIModifyAmountIncrementTierThreeAxis_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000B5C90 File Offset: 0x000B3E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89587, XrefRangeEnd = 89598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000B5CCC File Offset: 0x000B3ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89598, XrefRangeEnd = 89619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000B5D08 File Offset: 0x000B3F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89619, XrefRangeEnd = 89671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000B5D44 File Offset: 0x000B3F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89671, XrefRangeEnd = 89690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000B5D84 File Offset: 0x000B3F84
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 89698, RefRangeEnd = 89755, XrefRangeStart = 89690, XrefRangeEnd = 89698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000B5DC4 File Offset: 0x000B3FC4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89837, XrefRangeStart = 89755, XrefRangeEnd = 89763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000B5E04 File Offset: 0x000B4004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89845, RefRangeEnd = 89846, XrefRangeStart = 89837, XrefRangeEnd = 89845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000B5E44 File Offset: 0x000B4044
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 89853, RefRangeEnd = 89874, XrefRangeStart = 89846, XrefRangeEnd = 89853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCurrentInputDeviceIsKeyboardMouse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetCurrentInputDeviceIsKeyboardMouse_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x000B5E74 File Offset: 0x000B4074
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 89881, RefRangeEnd = 89915, XrefRangeStart = 89874, XrefRangeEnd = 89881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCurrentInputDeviceIsGamepad()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetCurrentInputDeviceIsGamepad_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000B5EA4 File Offset: 0x000B40A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89915, XrefRangeEnd = 89923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameInput.InputDeviceType GetCurrentInputDevice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetCurrentInputDevice_Public_Static_InputDeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000B5ED4 File Offset: 0x000B40D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89923, XrefRangeEnd = 89926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000B5F08 File Offset: 0x000B4108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89926, XrefRangeEnd = 89927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000B5F3C File Offset: 0x000B413C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89955, RefRangeEnd = 89956, XrefRangeStart = 89927, XrefRangeEnd = 89955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleExitInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_HandleExitInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000B5F70 File Offset: 0x000B4170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89971, RefRangeEnd = 89972, XrefRangeStart = 89956, XrefRangeEnd = 89971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000B5FB0 File Offset: 0x000B41B0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89976, RefRangeEnd = 89985, XrefRangeStart = 89972, XrefRangeEnd = 89976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000B5FE4 File Offset: 0x000B41E4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 89994, RefRangeEnd = 90007, XrefRangeStart = 89985, XrefRangeEnd = 89994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointerPosition()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000B6014 File Offset: 0x000B4214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90007, XrefRangeEnd = 90054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlsChanged(PlayerInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnControlsChanged_Private_Void_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000B6058 File Offset: 0x000B4258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90057, RefRangeEnd = 90058, XrefRangeStart = 90054, XrefRangeEnd = 90057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAction(string actionName, out InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_TryGetAction_Public_Boolean_String_byref_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000B60C8 File Offset: 0x000B42C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90071, RefRangeEnd = 90073, XrefRangeStart = 90058, XrefRangeEnd = 90071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentPlatformType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_SetCurrentPlatformType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x000B60FC File Offset: 0x000B42FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90073, XrefRangeEnd = 90145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMotion(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000B6140 File Offset: 0x000B4340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90145, XrefRangeEnd = 90155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrimaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000B6174 File Offset: 0x000B4374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90155, XrefRangeEnd = 90165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000B61A8 File Offset: 0x000B43A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90165, XrefRangeEnd = 90175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000B61DC File Offset: 0x000B43DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90175, XrefRangeEnd = 90189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000B6210 File Offset: 0x000B4410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90189, XrefRangeEnd = 90203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000B6244 File Offset: 0x000B4444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90203, XrefRangeEnd = 90213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000B6278 File Offset: 0x000B4478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90213, XrefRangeEnd = 90227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000B62AC File Offset: 0x000B44AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90227, XrefRangeEnd = 90237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000B62E0 File Offset: 0x000B44E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90237, XrefRangeEnd = 90247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVehicleToggleLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnVehicleToggleLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000B6314 File Offset: 0x000B4514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90247, XrefRangeEnd = 90257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVehicleHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnVehicleHandbrake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000B6348 File Offset: 0x000B4548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90257, XrefRangeEnd = 90271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000B637C File Offset: 0x000B457C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90271, XrefRangeEnd = 90285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCamera(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnCamera_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000B63C0 File Offset: 0x000B45C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90285, XrefRangeEnd = 90292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollWheel(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnScrollWheel_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000B6404 File Offset: 0x000B4604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90292, XrefRangeEnd = 90302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInventoryLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInventoryLeft_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000B6438 File Offset: 0x000B4638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90302, XrefRangeEnd = 90312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInventoryRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInventoryRight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000B646C File Offset: 0x000B466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90312, XrefRangeEnd = 90319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerCombo(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnControllerCombo_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000B64B0 File Offset: 0x000B46B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90319, XrefRangeEnd = 90329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVehicleResetCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnVehicleResetCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x000B64E4 File Offset: 0x000B46E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90329, XrefRangeEnd = 90339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVehicleDrive(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnVehicleDrive_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000B6528 File Offset: 0x000B4728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90339, XrefRangeEnd = 90349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkateboardDismount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSkateboardDismount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000B655C File Offset: 0x000B475C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90349, XrefRangeEnd = 90359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkateboardMount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSkateboardMount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000B6590 File Offset: 0x000B4790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90359, XrefRangeEnd = 90369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUINavigationDirection(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUINavigationDirection_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000B65D4 File Offset: 0x000B47D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90369, XrefRangeEnd = 90379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUICyclePanelDirection(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUICyclePanelDirection_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000B6618 File Offset: 0x000B4818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90379, XrefRangeEnd = 90389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUITabNavigationPrimary(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUITabNavigationPrimary_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000B665C File Offset: 0x000B485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90389, XrefRangeEnd = 90399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUITabNavigationSecondary(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUITabNavigationSecondary_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000B66A0 File Offset: 0x000B48A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90399, XrefRangeEnd = 90409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUITabNavigationTertiary(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUITabNavigationTertiary_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000B66E4 File Offset: 0x000B48E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90409, XrefRangeEnd = 90419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIScrollbar(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIScrollbar_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000B6728 File Offset: 0x000B4928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90419, XrefRangeEnd = 90429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIMapNavigationDirection(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIMapNavigationDirection_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000B676C File Offset: 0x000B496C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90429, XrefRangeEnd = 90439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIMapZoom(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIMapZoom_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000B67B0 File Offset: 0x000B49B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90439, XrefRangeEnd = 90449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIModifyAmountIncrementTierOne(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierOne_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000B67F4 File Offset: 0x000B49F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90449, XrefRangeEnd = 90459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIModifyAmountIncrementTierTwo(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierTwo_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000B6838 File Offset: 0x000B4A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90459, XrefRangeEnd = 90469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUIModifyAmountIncrementTierThree(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnUIModifyAmountIncrementTierThree_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000B687C File Offset: 0x000B4A7C
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 90499, RefRangeEnd = 90539, XrefRangeStart = 90469, XrefRangeEnd = 90499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x000B68C0 File Offset: 0x000B4AC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 90557, RefRangeEnd = 90562, XrefRangeStart = 90539, XrefRangeEnd = 90557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000B68F8 File Offset: 0x000B4AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90579, RefRangeEnd = 90581, XrefRangeStart = 90562, XrefRangeEnd = 90579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExitListener(Action exitMethod, Func<bool> condition, int priority = 0, bool primaryExitOnly = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitMethod);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref primaryExitOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_Action_Func_1_Boolean_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000B695C File Offset: 0x000B4B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90581, XrefRangeEnd = 90585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction GetAction(GameInput.ButtonCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000B69A8 File Offset: 0x000B4BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90585, XrefRangeEnd = 90605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00009F0E File Offset: 0x0000810E
		public GameInput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000B69E4 File Offset: 0x000B4BE4
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00009F17 File Offset: 0x00008117
		public unsafe static GameInput.InputDeviceType _CurrentInputDevice_k__BackingField
		{
			get
			{
				GameInput.InputDeviceType result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__CurrentInputDevice_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__CurrentInputDevice_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000B6A00 File Offset: 0x000B4C00
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00009F25 File Offset: 0x00008125
		public unsafe static EPlatformType _CurrentPlatformType_k__BackingField
		{
			get
			{
				EPlatformType result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__CurrentPlatformType_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__CurrentPlatformType_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000B6A1C File Offset: 0x000B4C1C
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00009F33 File Offset: 0x00008133
		public unsafe static Action<GameInput.InputDeviceType> OnInputDeviceChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_OnInputDeviceChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameInput.InputDeviceType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_OnInputDeviceChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000B6A44 File Offset: 0x000B4C44
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00009F45 File Offset: 0x00008145
		public unsafe static List<GameInput.ExitListener> exitListeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_exitListeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ExitListener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_exitListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000B6A6C File Offset: 0x000B4C6C
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00009F57 File Offset: 0x00008157
		public unsafe PlayerInput PlayerInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000B6A9C File Offset: 0x000B4C9C
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00009F76 File Offset: 0x00008176
		public unsafe InputActionReference PrimaryExitAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PrimaryExitAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PrimaryExitAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000B6ACC File Offset: 0x000B4CCC
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00009F95 File Offset: 0x00008195
		public unsafe InputActionReference SecondaryExitAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_SecondaryExitAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_SecondaryExitAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000B6AFC File Offset: 0x000B4CFC
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00009FB4 File Offset: 0x000081B4
		public unsafe static bool _isTyping
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__isTyping, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__isTyping, (void*)(&value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000B6B18 File Offset: 0x000B4D18
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00009FC2 File Offset: 0x000081C2
		public unsafe static Vector2 MotionAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x000B6B34 File Offset: 0x000B4D34
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00009FD0 File Offset: 0x000081D0
		public unsafe static Vector2 CameraAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_CameraAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_CameraAxis, (void*)(&value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000B6B50 File Offset: 0x000B4D50
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00009FDE File Offset: 0x000081DE
		public unsafe static Mouse systemMouse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_systemMouse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_systemMouse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000B6B78 File Offset: 0x000B4D78
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00009FF0 File Offset: 0x000081F0
		public unsafe static Vector2 MouseWheelAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_MouseWheelAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_MouseWheelAxis, (void*)(&value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x000B6B94 File Offset: 0x000B4D94
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00009FFE File Offset: 0x000081FE
		public unsafe static bool ControllerComboActive
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_ControllerComboActive, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_ControllerComboActive, (void*)(&value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x000B6BB0 File Offset: 0x000B4DB0
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x0000A00C File Offset: 0x0000820C
		public unsafe float vehicleDriveAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_vehicleDriveAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_vehicleDriveAxis)) = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0000A027 File Offset: 0x00008227
		public unsafe static Vector2 _UINavigationDirection_k__BackingField
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UINavigationDirection_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UINavigationDirection_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x000B6BF4 File Offset: 0x000B4DF4
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x0000A035 File Offset: 0x00008235
		public unsafe static Vector2 _UICyclePanelDirection_k__BackingField
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UICyclePanelDirection_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UICyclePanelDirection_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000B6C10 File Offset: 0x000B4E10
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0000A043 File Offset: 0x00008243
		public unsafe static float _UITabNavigationPrimaryAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UITabNavigationPrimaryAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UITabNavigationPrimaryAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000B6C2C File Offset: 0x000B4E2C
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x0000A051 File Offset: 0x00008251
		public unsafe static float _UITabNavigationSecondaryAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UITabNavigationSecondaryAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UITabNavigationSecondaryAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000B6C48 File Offset: 0x000B4E48
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0000A05F File Offset: 0x0000825F
		public unsafe static float _UITabNavigationTertiaryAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UITabNavigationTertiaryAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UITabNavigationTertiaryAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000B6C64 File Offset: 0x000B4E64
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0000A06D File Offset: 0x0000826D
		public unsafe static float _UIScrollbarAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIScrollbarAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIScrollbarAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000B6C80 File Offset: 0x000B4E80
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000A07B File Offset: 0x0000827B
		public unsafe static Vector2 _UIMapNavigationDirection_k__BackingField
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIMapNavigationDirection_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIMapNavigationDirection_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000B6C9C File Offset: 0x000B4E9C
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000A089 File Offset: 0x00008289
		public unsafe static float _UIMapZoomAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIMapZoomAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIMapZoomAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000B6CB8 File Offset: 0x000B4EB8
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0000A097 File Offset: 0x00008297
		public unsafe static float _UIModifyAmountIncrementTierOneAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierOneAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierOneAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000B6CD4 File Offset: 0x000B4ED4
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000A0A5 File Offset: 0x000082A5
		public unsafe static float _UIModifyAmountIncrementTierTwoAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierTwoAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierTwoAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x000B6CF0 File Offset: 0x000B4EF0
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0000A0B3 File Offset: 0x000082B3
		public unsafe static float _UIModifyAmountIncrementTierThreeAxis_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierThreeAxis_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr__UIModifyAmountIncrementTierThreeAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000B6D0C File Offset: 0x000B4F0C
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0000A0C1 File Offset: 0x000082C1
		public unsafe List<GameInput.ButtonCode> buttonsDownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000B6D3C File Offset: 0x000B4F3C
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public unsafe List<GameInput.ButtonCode> buttonsDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000B6D6C File Offset: 0x000B4F6C
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x0000A0FF File Offset: 0x000082FF
		public unsafe List<GameInput.ButtonCode> buttonsUpThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000B6D9C File Offset: 0x000B4F9C
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0000A11E File Offset: 0x0000831E
		public unsafe float _timeOnLastRebind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr__timeOnLastRebind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr__timeOnLastRebind)) = value;
			}
		}

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr__CurrentInputDevice_k__BackingField;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlatformType_k__BackingField;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr_OnInputDeviceChanged;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_exitListeners;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInput;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_PrimaryExitAction;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryExitAction;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr__isTyping;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_MotionAxis;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_CameraAxis;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_systemMouse;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr_MouseWheelAxis;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr_ControllerComboActive;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDriveAxis;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr__UINavigationDirection_k__BackingField;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeFieldInfoPtr__UICyclePanelDirection_k__BackingField;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr__UITabNavigationPrimaryAxis_k__BackingField;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr__UITabNavigationSecondaryAxis_k__BackingField;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr__UITabNavigationTertiaryAxis_k__BackingField;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr__UIScrollbarAxis_k__BackingField;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr__UIMapNavigationDirection_k__BackingField;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr__UIMapZoomAxis_k__BackingField;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr__UIModifyAmountIncrementTierOneAxis_k__BackingField;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr__UIModifyAmountIncrementTierTwoAxis_k__BackingField;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr__UIModifyAmountIncrementTierThreeAxis_k__BackingField;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDownThisFrame;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDown;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr_buttonsUpThisFrame;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr__timeOnLastRebind;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInputDevice_Public_Static_get_InputDeviceType_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentInputDevice_Private_Static_set_Void_InputDeviceType_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatformType_Public_Static_get_EPlatformType_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlatformType_Private_Static_set_Void_EPlatformType_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTyping_Public_Static_get_Boolean_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTyping_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleDriveAxis_Public_Static_get_Single_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_set_VehicleDriveAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_get_UINavigationDirection_Public_Static_get_Vector2_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_set_UINavigationDirection_Private_Static_set_Void_Vector2_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_get_UICyclePanelDirection_Public_Static_get_Vector2_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_set_UICyclePanelDirection_Private_Static_set_Void_Vector2_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_UITabNavigationPrimaryAxis_Public_Static_get_Single_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_set_UITabNavigationPrimaryAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_get_UITabNavigationSecondaryAxis_Public_Static_get_Single_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_set_UITabNavigationSecondaryAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_get_UITabNavigationTertiaryAxis_Public_Static_get_Single_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_set_UITabNavigationTertiaryAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_get_UIScrollbarAxis_Public_Static_get_Single_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_set_UIScrollbarAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_get_UIMapNavigationDirection_Public_Static_get_Vector2_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_set_UIMapNavigationDirection_Private_Static_set_Void_Vector2_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_get_UIMapZoomAxis_Public_Static_get_Single_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_set_UIMapZoomAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_get_UIModifyAmountIncrementTierOneAxis_Public_Static_get_Single_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_set_UIModifyAmountIncrementTierOneAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_get_UIModifyAmountIncrementTierTwoAxis_Public_Static_get_Single_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_set_UIModifyAmountIncrementTierTwoAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_get_UIModifyAmountIncrementTierThreeAxis_Public_Static_get_Single_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_set_UIModifyAmountIncrementTierThreeAxis_Private_Static_set_Void_Single_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentInputDeviceIsKeyboardMouse_Public_Static_Boolean_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentInputDeviceIsGamepad_Public_Static_Boolean_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentInputDevice_Public_Static_InputDeviceType_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_HandleExitInputs_Private_Void_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitType_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector3_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_OnControlsChanged_Private_Void_PlayerInput_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAction_Public_Boolean_String_byref_InputAction_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentPlatformType_Private_Void_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_OnJump_Private_Void_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_OnCrouch_Private_Void_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_OnSprint_Private_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleToggleLights_Private_Void_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleHandbrake_Private_Void_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_OnReload_Private_Void_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_OnCamera_Private_Void_InputValue_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollWheel_Private_Void_InputValue_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryLeft_Private_Void_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryRight_Private_Void_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerCombo_Private_Void_InputValue_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleResetCamera_Private_Void_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleDrive_Private_Void_InputValue_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_OnSkateboardDismount_Private_Void_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_OnSkateboardMount_Private_Void_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_OnUINavigationDirection_Private_Void_InputValue_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_OnUICyclePanelDirection_Private_Void_InputValue_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_OnUITabNavigationPrimary_Private_Void_InputValue_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_OnUITabNavigationSecondary_Private_Void_InputValue_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_OnUITabNavigationTertiary_Private_Void_InputValue_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_OnUIScrollbar_Private_Void_InputValue_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_OnUIMapNavigationDirection_Private_Void_InputValue_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_OnUIMapZoom_Private_Void_InputValue_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_OnUIModifyAmountIncrementTierOne_Private_Void_InputValue_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_OnUIModifyAmountIncrementTierTwo_Private_Void_InputValue_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_OnUIModifyAmountIncrementTierThree_Private_Void_InputValue_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_Action_Func_1_Boolean_Int32_Boolean_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000914 RID: 2324
		[OriginalName("Assembly-CSharp.dll", "", "ButtonCode")]
		public enum ButtonCode
		{
			// Token: 0x04009265 RID: 37477
			PrimaryClick,
			// Token: 0x04009266 RID: 37478
			SecondaryClick,
			// Token: 0x04009267 RID: 37479
			TertiaryClick,
			// Token: 0x04009268 RID: 37480
			Forward,
			// Token: 0x04009269 RID: 37481
			Backward,
			// Token: 0x0400926A RID: 37482
			Left,
			// Token: 0x0400926B RID: 37483
			Right,
			// Token: 0x0400926C RID: 37484
			Jump,
			// Token: 0x0400926D RID: 37485
			Crouch,
			// Token: 0x0400926E RID: 37486
			Sprint,
			// Token: 0x0400926F RID: 37487
			Interact,
			// Token: 0x04009270 RID: 37488
			Submit,
			// Token: 0x04009271 RID: 37489
			VehicleToggleLights,
			// Token: 0x04009272 RID: 37490
			VehicleHandbrake,
			// Token: 0x04009273 RID: 37491
			Reload,
			// Token: 0x04009274 RID: 37492
			InventoryLeft,
			// Token: 0x04009275 RID: 37493
			InventoryRight,
			// Token: 0x04009276 RID: 37494
			VehicleResetCamera,
			// Token: 0x04009277 RID: 37495
			SkateboardDismount,
			// Token: 0x04009278 RID: 37496
			SkateboardMount
		}

		// Token: 0x02000915 RID: 2325
		[OriginalName("Assembly-CSharp.dll", "", "InputDeviceType")]
		public enum InputDeviceType
		{
			// Token: 0x0400927A RID: 37498
			KeyboardMouse,
			// Token: 0x0400927B RID: 37499
			Gamepad
		}

		// Token: 0x02000916 RID: 2326
		public class ExitListener : Il2CppSystem.Object
		{
			// Token: 0x0600D6E5 RID: 55013 RVA: 0x003582F4 File Offset: 0x003564F4
			// Note: this type is marked as 'beforefieldinit'.
			static ExitListener()
			{
				Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitListener");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr);
				GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "listenerFunction");
				GameInput.ExitListener.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "priority");
				GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, 100665903);
			}

			// Token: 0x0600D6E6 RID: 55014 RVA: 0x0035835C File Offset: 0x0035655C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitListener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E7 RID: 55015 RVA: 0x00064FB2 File Offset: 0x000631B2
			public ExitListener(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A4 RID: 16804
			// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x00358398 File Offset: 0x00356598
			// (set) Token: 0x0600D6E9 RID: 55017 RVA: 0x00064FBB File Offset: 0x000631BB
			public unsafe GameInput.ExitDelegate listenerFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.ExitDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A5 RID: 16805
			// (get) Token: 0x0600D6EA RID: 55018 RVA: 0x003583C8 File Offset: 0x003565C8
			// (set) Token: 0x0600D6EB RID: 55019 RVA: 0x00064FDA File Offset: 0x000631DA
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x0400927C RID: 37500
			private static readonly IntPtr NativeFieldInfoPtr_listenerFunction;

			// Token: 0x0400927D RID: 37501
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x0400927E RID: 37502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000917 RID: 2327
		public sealed class ExitDelegate : MulticastDelegate
		{
			// Token: 0x0600D6EC RID: 55020 RVA: 0x003583F0 File Offset: 0x003565F0
			// Note: this type is marked as 'beforefieldinit'.
			static ExitDelegate()
			{
				Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitDelegate");
				GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100665904);
				GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100665905);
				GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100665906);
				GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100665907);
			}

			// Token: 0x0600D6ED RID: 55021 RVA: 0x00358464 File Offset: 0x00356664
			[CallerCount(628)]
			[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6EE RID: 55022 RVA: 0x003584C0 File Offset: 0x003566C0
			[CallerCount(0)]
			public unsafe void Invoke(ExitAction exitAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6EF RID: 55023 RVA: 0x00358504 File Offset: 0x00356704
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ExitAction exitAction, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D6F0 RID: 55024 RVA: 0x00358578 File Offset: 0x00356778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F1 RID: 55025 RVA: 0x00064FF5 File Offset: 0x000631F5
			public ExitDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D6F2 RID: 55026 RVA: 0x00064FFE File Offset: 0x000631FE
			public static implicit operator GameInput.ExitDelegate(Action<ExitAction> A_0)
			{
				return DelegateSupport.ConvertDelegate<GameInput.ExitDelegate>(A_0);
			}

			// Token: 0x0600D6F3 RID: 55027 RVA: 0x00065006 File Offset: 0x00063206
			public static GameInput.ExitDelegate operator +(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GameInput.ExitDelegate>();
			}

			// Token: 0x0600D6F4 RID: 55028 RVA: 0x00065014 File Offset: 0x00063214
			public static GameInput.ExitDelegate operator -(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<GameInput.ExitDelegate>();
				}
				return result;
			}

			// Token: 0x0400927F RID: 37503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009280 RID: 37504
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0;

			// Token: 0x04009281 RID: 37505
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0;

			// Token: 0x04009282 RID: 37506
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000918 RID: 2328
		[ObfuscatedName("ScheduleOne.GameInput+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D6F5 RID: 55029 RVA: 0x003585BC File Offset: 0x003567BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr);
				GameInput.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9");
				GameInput.__c.NativeFieldInfoPtr___9__86_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9__86_0");
				GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100665909);
				GameInput.__c.NativeMethodInfoPtr__Start_b__86_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100665910);
			}

			// Token: 0x0600D6F6 RID: 55030 RVA: 0x00358638 File Offset: 0x00356838
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F7 RID: 55031 RVA: 0x00358674 File Offset: 0x00356874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89362, XrefRangeEnd = 89368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__86_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__Start_b__86_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F8 RID: 55032 RVA: 0x00065025 File Offset: 0x00063225
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A6 RID: 16806
			// (get) Token: 0x0600D6F9 RID: 55033 RVA: 0x003586A8 File Offset: 0x003568A8
			// (set) Token: 0x0600D6FA RID: 55034 RVA: 0x0006502E File Offset: 0x0006322E
			public unsafe static GameInput.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A7 RID: 16807
			// (get) Token: 0x0600D6FB RID: 55035 RVA: 0x003586D0 File Offset: 0x003568D0
			// (set) Token: 0x0600D6FC RID: 55036 RVA: 0x00065040 File Offset: 0x00063240
			public unsafe static UnityAction __9__86_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9__86_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9__86_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009283 RID: 37507
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009284 RID: 37508
			private static readonly IntPtr NativeFieldInfoPtr___9__86_0;

			// Token: 0x04009285 RID: 37509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009286 RID: 37510
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__86_0_Internal_Void_0;
		}

		// Token: 0x02000919 RID: 2329
		[ObfuscatedName("ScheduleOne.GameInput+<>c__DisplayClass137_0")]
		public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6FD RID: 55037 RVA: 0x003586F8 File Offset: 0x003568F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass137_0()
			{
				Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<>c__DisplayClass137_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr);
				GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_primaryExitOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr, "primaryExitOnly");
				GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr, "condition");
				GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_exitMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr, "exitMethod");
				GameInput.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr, 100665911);
				GameInput.__c__DisplayClass137_0.NativeMethodInfoPtr__RegisterExitListener_b__0_Internal_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr, 100665912);
			}

			// Token: 0x0600D6FE RID: 55038 RVA: 0x00358788 File Offset: 0x00356988
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass137_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.__c__DisplayClass137_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6FF RID: 55039 RVA: 0x003587C4 File Offset: 0x003569C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89368, XrefRangeEnd = 89369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterExitListener_b__0(ExitAction action)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c__DisplayClass137_0.NativeMethodInfoPtr__RegisterExitListener_b__0_Internal_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D700 RID: 55040 RVA: 0x00065052 File Offset: 0x00063252
			public __c__DisplayClass137_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A8 RID: 16808
			// (get) Token: 0x0600D701 RID: 55041 RVA: 0x00358808 File Offset: 0x00356A08
			// (set) Token: 0x0600D702 RID: 55042 RVA: 0x0006505B File Offset: 0x0006325B
			public unsafe bool primaryExitOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_primaryExitOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_primaryExitOnly)) = value;
				}
			}

			// Token: 0x170041A9 RID: 16809
			// (get) Token: 0x0600D703 RID: 55043 RVA: 0x00358830 File Offset: 0x00356A30
			// (set) Token: 0x0600D704 RID: 55044 RVA: 0x00065076 File Offset: 0x00063276
			public unsafe Func<bool> condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_condition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AA RID: 16810
			// (get) Token: 0x0600D705 RID: 55045 RVA: 0x00358860 File Offset: 0x00356A60
			// (set) Token: 0x0600D706 RID: 55046 RVA: 0x00065095 File Offset: 0x00063295
			public unsafe Action exitMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_exitMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.__c__DisplayClass137_0.NativeFieldInfoPtr_exitMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009287 RID: 37511
			private static readonly IntPtr NativeFieldInfoPtr_primaryExitOnly;

			// Token: 0x04009288 RID: 37512
			private static readonly IntPtr NativeFieldInfoPtr_condition;

			// Token: 0x04009289 RID: 37513
			private static readonly IntPtr NativeFieldInfoPtr_exitMethod;

			// Token: 0x0400928A RID: 37514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400928B RID: 37515
			private static readonly IntPtr NativeMethodInfoPtr__RegisterExitListener_b__0_Internal_Void_ExitAction_0;
		}
	}
}
