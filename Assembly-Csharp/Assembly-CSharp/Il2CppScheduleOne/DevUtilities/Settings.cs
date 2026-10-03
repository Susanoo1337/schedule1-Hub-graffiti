using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Gamepad;
using Il2CppScheduleOne.Platform;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000416 RID: 1046
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x06005BEE RID: 23534 RVA: 0x001B8240 File Offset: 0x001B6440
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_MinYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "MinYPos");
			Settings.NativeFieldInfoPtr_BETA_ARG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "BETA_ARG");
			Settings.NativeFieldInfoPtr_LaunchArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "LaunchArgs");
			Settings.NativeFieldInfoPtr__ChristmasEventActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<ChristmasEventActive>k__BackingField");
			Settings.NativeFieldInfoPtr__UnitType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<UnitType>k__BackingField");
			Settings.NativeFieldInfoPtr_DisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DisplaySettings");
			Settings.NativeFieldInfoPtr_UnappliedDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "UnappliedDisplaySettings");
			Settings.NativeFieldInfoPtr_GraphicsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GraphicsSettings");
			Settings.NativeFieldInfoPtr_AudioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "AudioSettings");
			Settings.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputSettings");
			Settings.NativeFieldInfoPtr_GamepadSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GamepadSettings");
			Settings.NativeFieldInfoPtr_OtherSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "OtherSettings");
			Settings.NativeFieldInfoPtr_InputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputActions");
			Settings.NativeFieldInfoPtr_GameInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GameInput");
			Settings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SSAO");
			Settings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GodRays");
			Settings.NativeFieldInfoPtr__platformDefaultSettingsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_platformDefaultSettingsList");
			Settings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InvertMouse");
			Settings.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraFOV");
			Settings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SprintMode");
			Settings.NativeFieldInfoPtr_CameraBobIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraBobIntensity");
			Settings.NativeFieldInfoPtr__gamepadRebindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_gamepadRebindings");
			Settings.NativeFieldInfoPtr__pcRebindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_pcRebindings");
			Settings.NativeFieldInfoPtr_playerControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "playerControls");
			Settings.NativeFieldInfoPtr_onInputsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onInputsApplied");
			Settings.NativeFieldInfoPtr_onDisplaySettingsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onDisplaySettingsApplied");
			Settings.NativeFieldInfoPtr_onQualitySettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onQualitySettingsChanged");
			Settings.NativeFieldInfoPtr_onUnappliedDisplayIndexChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onUnappliedDisplayIndexChanged");
			Settings.NativeFieldInfoPtr__thisPlatformDefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_thisPlatformDefaultSettings");
			Settings.NativeFieldInfoPtr_mouseCameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "mouseCameraSensitivity");
			Settings.NativeFieldInfoPtr_gamepadCameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "gamepadCameraSensitivity");
			Settings.NativeFieldInfoPtr__defaultBindingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "_defaultBindingOverrides");
			Settings.NativeMethodInfoPtr_get_ChristmasEventActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675301);
			Settings.NativeMethodInfoPtr_set_ChristmasEventActive_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675302);
			Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675303);
			Settings.NativeMethodInfoPtr_get_UnitType_Public_get_EUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675304);
			Settings.NativeMethodInfoPtr_set_UnitType_Private_set_Void_EUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675305);
			Settings.NativeMethodInfoPtr_get_LookSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675306);
			Settings.NativeMethodInfoPtr_add_onDisplaySettingsApplied_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675307);
			Settings.NativeMethodInfoPtr_remove_onDisplaySettingsApplied_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675308);
			Settings.NativeMethodInfoPtr_add_onQualitySettingsChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675309);
			Settings.NativeMethodInfoPtr_remove_onQualitySettingsChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675310);
			Settings.NativeMethodInfoPtr_get_GamepadRebindings_Public_get_List_1_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675311);
			Settings.NativeMethodInfoPtr_get_PCRebindings_Public_get_List_1_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675312);
			Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675313);
			Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675314);
			Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675315);
			Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675316);
			Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675317);
			Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675318);
			Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675319);
			Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675320);
			Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675321);
			Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675322);
			Settings.NativeMethodInfoPtr_ReloadOtherSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675323);
			Settings.NativeMethodInfoPtr_ApplyOtherSettings_Public_Void_OtherSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675324);
			Settings.NativeMethodInfoPtr_ReloadGamepadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675325);
			Settings.NativeMethodInfoPtr_ApplyGamepadSettings_Public_Void_GamepadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675326);
			Settings.NativeMethodInfoPtr_RestoreDefaultKeyboardBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675327);
			Settings.NativeMethodInfoPtr_RestoreDefaultGamepadBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675328);
			Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675329);
			Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675330);
			Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675331);
			Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675332);
			Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675333);
			Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675334);
			Settings.NativeMethodInfoPtr_WriteGamepadSettings_Public_Void_GamepadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675335);
			Settings.NativeMethodInfoPtr_ReadGamepadSettings_Public_GamepadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675336);
			Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675337);
			Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675338);
			Settings.NativeMethodInfoPtr_WriteOtherSettings_Public_Void_OtherSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675339);
			Settings.NativeMethodInfoPtr_ReadOtherSettings_Public_OtherSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675340);
			Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675341);
			Settings.NativeMethodInfoPtr_GetDefaultUnitTypeForPlayer_Private_EUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675342);
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675343);
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06005BEF RID: 23535 RVA: 0x001B884C File Offset: 0x001B6A4C
		// (set) Token: 0x06005BF0 RID: 23536 RVA: 0x001B887C File Offset: 0x001B6A7C
		public unsafe static bool ChristmasEventActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197747, XrefRangeEnd = 197749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_ChristmasEventActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197749, XrefRangeEnd = 197751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_ChristmasEventActive_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x001B88B0 File Offset: 0x001B6AB0
		public unsafe bool PausingFreezesTime
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 197757, RefRangeEnd = 197760, XrefRangeStart = 197751, XrefRangeEnd = 197757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x001B88EC File Offset: 0x001B6AEC
		// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x001B8928 File Offset: 0x001B6B28
		public unsafe Settings.EUnitType UnitType
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_UnitType_Public_get_EUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63932, RefRangeEnd = 63933, XrefRangeStart = 63932, XrefRangeEnd = 63933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_UnitType_Private_set_Void_EUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x001B8968 File Offset: 0x001B6B68
		public unsafe float LookSensitivity
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 197767, RefRangeEnd = 197779, XrefRangeStart = 197760, XrefRangeEnd = 197767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_LookSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x001B89A4 File Offset: 0x001B6BA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 197783, RefRangeEnd = 197788, XrefRangeStart = 197779, XrefRangeEnd = 197783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onDisplaySettingsApplied(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_add_onDisplaySettingsApplied_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x001B89E8 File Offset: 0x001B6BE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 197792, RefRangeEnd = 197797, XrefRangeStart = 197788, XrefRangeEnd = 197792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onDisplaySettingsApplied(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_remove_onDisplaySettingsApplied_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x001B8A2C File Offset: 0x001B6C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197801, RefRangeEnd = 197802, XrefRangeStart = 197797, XrefRangeEnd = 197801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onQualitySettingsChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_add_onQualitySettingsChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x001B8A70 File Offset: 0x001B6C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197802, XrefRangeEnd = 197806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onQualitySettingsChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_remove_onQualitySettingsChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06005BF9 RID: 23545 RVA: 0x001B8AB4 File Offset: 0x001B6CB4
		public unsafe List<InputActionReference> GamepadRebindings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_GamepadRebindings_Public_get_List_1_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr3) : null;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x001B8AF4 File Offset: 0x001B6CF4
		public unsafe List<InputActionReference> PCRebindings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PCRebindings_Public_get_List_1_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr3) : null;
			}
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x001B8B34 File Offset: 0x001B6D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197806, XrefRangeEnd = 197977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x001B8B70 File Offset: 0x001B6D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197977, XrefRangeEnd = 197988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x001B8BAC File Offset: 0x001B6DAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198057, RefRangeEnd = 198060, XrefRangeStart = 197988, XrefRangeEnd = 198057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x001B8BEC File Offset: 0x001B6DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198060, XrefRangeEnd = 198061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveMainWindowTo(DisplayInfo displayInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x001B8C34 File Offset: 0x001B6E34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 198063, RefRangeEnd = 198068, XrefRangeStart = 198061, XrefRangeEnd = 198063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x001B8C68 File Offset: 0x001B6E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198068, XrefRangeEnd = 198070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x001B8CAC File Offset: 0x001B6EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198071, RefRangeEnd = 198072, XrefRangeStart = 198070, XrefRangeEnd = 198071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x001B8CE0 File Offset: 0x001B6EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198106, RefRangeEnd = 198108, XrefRangeStart = 198072, XrefRangeEnd = 198106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x001B8D24 File Offset: 0x001B6F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198109, RefRangeEnd = 198111, XrefRangeStart = 198108, XrefRangeEnd = 198109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x001B8D58 File Offset: 0x001B6F58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 198116, RefRangeEnd = 198120, XrefRangeStart = 198111, XrefRangeEnd = 198116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x001B8D9C File Offset: 0x001B6F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198121, RefRangeEnd = 198122, XrefRangeStart = 198120, XrefRangeEnd = 198121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadOtherSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadOtherSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x001B8DD0 File Offset: 0x001B6FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOtherSettings(OtherSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyOtherSettings_Public_Void_OtherSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x001B8E14 File Offset: 0x001B7014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198123, RefRangeEnd = 198125, XrefRangeStart = 198122, XrefRangeEnd = 198123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGamepadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadGamepadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x001B8E48 File Offset: 0x001B7048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198132, RefRangeEnd = 198134, XrefRangeStart = 198125, XrefRangeEnd = 198132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGamepadSettings(GamepadSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyGamepadSettings_Public_Void_GamepadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x001B8E8C File Offset: 0x001B708C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198144, RefRangeEnd = 198145, XrefRangeStart = 198134, XrefRangeEnd = 198144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreDefaultKeyboardBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_RestoreDefaultKeyboardBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x001B8EC0 File Offset: 0x001B70C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198145, XrefRangeEnd = 198155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreDefaultGamepadBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_RestoreDefaultGamepadBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x001B8EF4 File Offset: 0x001B70F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198182, RefRangeEnd = 198184, XrefRangeStart = 198155, XrefRangeEnd = 198182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x001B8F34 File Offset: 0x001B7134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198223, RefRangeEnd = 198225, XrefRangeStart = 198184, XrefRangeEnd = 198223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplaySettings ReadDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x001B8F70 File Offset: 0x001B7170
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 198242, RefRangeEnd = 198247, XrefRangeStart = 198225, XrefRangeEnd = 198242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x001B8FB4 File Offset: 0x001B71B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198247, XrefRangeEnd = 198266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings ReadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr3) : null;
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x001B8FF4 File Offset: 0x001B71F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198292, RefRangeEnd = 198293, XrefRangeStart = 198266, XrefRangeEnd = 198292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x001B9038 File Offset: 0x001B7238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198293, XrefRangeEnd = 198321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings ReadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr3) : null;
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x001B9078 File Offset: 0x001B7278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198329, RefRangeEnd = 198331, XrefRangeStart = 198321, XrefRangeEnd = 198329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGamepadSettings(GamepadSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteGamepadSettings_Public_Void_GamepadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x001B90BC File Offset: 0x001B72BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198331, XrefRangeEnd = 198341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadSettings ReadGamepadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadGamepadSettings_Public_GamepadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadSettings>(intPtr3) : null;
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x001B90FC File Offset: 0x001B72FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 198357, RefRangeEnd = 198361, XrefRangeStart = 198341, XrefRangeEnd = 198357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x001B9140 File Offset: 0x001B7340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198361, XrefRangeEnd = 198380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings ReadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr3) : null;
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x001B9180 File Offset: 0x001B7380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198385, RefRangeEnd = 198386, XrefRangeStart = 198380, XrefRangeEnd = 198385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteOtherSettings(OtherSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteOtherSettings_Public_Void_OtherSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x001B91C4 File Offset: 0x001B73C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198386, XrefRangeEnd = 198393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OtherSettings ReadOtherSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadOtherSettings_Public_OtherSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OtherSettings>(intPtr3) : null;
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x001B9204 File Offset: 0x001B7404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198393, XrefRangeEnd = 198403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionControlPath(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x001B924C File Offset: 0x001B744C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198414, RefRangeEnd = 198415, XrefRangeStart = 198403, XrefRangeEnd = 198414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings.EUnitType GetDefaultUnitTypeForPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_GetDefaultUnitTypeForPlayer_Private_EUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x001B9288 File Offset: 0x001B7488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198415, XrefRangeEnd = 198457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x0002B8BB File Offset: 0x00029ABB
		public Settings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x001B92C4 File Offset: 0x001B74C4
		// (set) Token: 0x06005C1C RID: 23580 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		public unsafe static float MinYPos
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&value));
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x001B92E0 File Offset: 0x001B74E0
		// (set) Token: 0x06005C1E RID: 23582 RVA: 0x0002B8D2 File Offset: 0x00029AD2
		public unsafe static string BETA_ARG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_BETA_ARG, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_BETA_ARG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x001B9300 File Offset: 0x001B7500
		// (set) Token: 0x06005C20 RID: 23584 RVA: 0x0002B8E4 File Offset: 0x00029AE4
		public unsafe List<string> LaunchArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LaunchArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LaunchArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001B9330 File Offset: 0x001B7530
		// (set) Token: 0x06005C22 RID: 23586 RVA: 0x0002B903 File Offset: 0x00029B03
		public unsafe static bool _ChristmasEventActive_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr__ChristmasEventActive_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr__ChristmasEventActive_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x001B934C File Offset: 0x001B754C
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x0002B911 File Offset: 0x00029B11
		public unsafe Settings.EUnitType _UnitType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__UnitType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__UnitType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06005C25 RID: 23589 RVA: 0x001B9374 File Offset: 0x001B7574
		// (set) Token: 0x06005C26 RID: 23590 RVA: 0x0002B92C File Offset: 0x00029B2C
		public unsafe DisplaySettings DisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings)) = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06005C27 RID: 23591 RVA: 0x001B939C File Offset: 0x001B759C
		// (set) Token: 0x06005C28 RID: 23592 RVA: 0x0002B947 File Offset: 0x00029B47
		public unsafe DisplaySettings UnappliedDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings)) = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x001B93C4 File Offset: 0x001B75C4
		// (set) Token: 0x06005C2A RID: 23594 RVA: 0x0002B962 File Offset: 0x00029B62
		public unsafe GraphicsSettings GraphicsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06005C2B RID: 23595 RVA: 0x001B93F4 File Offset: 0x001B75F4
		// (set) Token: 0x06005C2C RID: 23596 RVA: 0x0002B981 File Offset: 0x00029B81
		public unsafe AudioSettings AudioSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06005C2D RID: 23597 RVA: 0x001B9424 File Offset: 0x001B7624
		// (set) Token: 0x06005C2E RID: 23598 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		public unsafe InputSettings InputSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06005C2F RID: 23599 RVA: 0x001B9454 File Offset: 0x001B7654
		// (set) Token: 0x06005C30 RID: 23600 RVA: 0x0002B9BF File Offset: 0x00029BBF
		public unsafe GamepadSettings GamepadSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GamepadSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GamepadSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06005C31 RID: 23601 RVA: 0x001B9484 File Offset: 0x001B7684
		// (set) Token: 0x06005C32 RID: 23602 RVA: 0x0002B9DE File Offset: 0x00029BDE
		public unsafe OtherSettings OtherSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_OtherSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OtherSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_OtherSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06005C33 RID: 23603 RVA: 0x001B94B4 File Offset: 0x001B76B4
		// (set) Token: 0x06005C34 RID: 23604 RVA: 0x0002B9FD File Offset: 0x00029BFD
		public unsafe InputActionAsset InputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x001B94E4 File Offset: 0x001B76E4
		// (set) Token: 0x06005C36 RID: 23606 RVA: 0x0002BA1C File Offset: 0x00029C1C
		public unsafe GameInput GameInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x001B9514 File Offset: 0x001B7714
		// (set) Token: 0x06005C38 RID: 23608 RVA: 0x0002BA3B File Offset: 0x00029C3B
		public unsafe ScriptableRendererFeature SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x001B9544 File Offset: 0x001B7744
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x0002BA5A File Offset: 0x00029C5A
		public unsafe ScriptableRendererFeature GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x001B9574 File Offset: 0x001B7774
		// (set) Token: 0x06005C3C RID: 23612 RVA: 0x0002BA79 File Offset: 0x00029C79
		public unsafe List<PlatformDefaultSettings> _platformDefaultSettingsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__platformDefaultSettingsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDefaultSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__platformDefaultSettingsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x001B95A4 File Offset: 0x001B77A4
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x0002BA98 File Offset: 0x00029C98
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x001B95CC File Offset: 0x001B77CC
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x0002BAB3 File Offset: 0x00029CB3
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x001B95F4 File Offset: 0x001B77F4
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x0002BACE File Offset: 0x00029CCE
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x001B961C File Offset: 0x001B781C
		// (set) Token: 0x06005C44 RID: 23620 RVA: 0x0002BAE9 File Offset: 0x00029CE9
		public unsafe float CameraBobIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity)) = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x001B9644 File Offset: 0x001B7844
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x0002BB04 File Offset: 0x00029D04
		public unsafe List<InputActionReference> _gamepadRebindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__gamepadRebindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__gamepadRebindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x001B9674 File Offset: 0x001B7874
		// (set) Token: 0x06005C48 RID: 23624 RVA: 0x0002BB23 File Offset: 0x00029D23
		public unsafe List<InputActionReference> _pcRebindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__pcRebindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__pcRebindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x001B96A4 File Offset: 0x001B78A4
		// (set) Token: 0x06005C4A RID: 23626 RVA: 0x0002BB42 File Offset: 0x00029D42
		public unsafe InputActionMap playerControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x001B96D4 File Offset: 0x001B78D4
		// (set) Token: 0x06005C4C RID: 23628 RVA: 0x0002BB61 File Offset: 0x00029D61
		public unsafe Action onInputsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x001B9704 File Offset: 0x001B7904
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x0002BB80 File Offset: 0x00029D80
		public unsafe Action onDisplaySettingsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplaySettingsApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplaySettingsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x001B9734 File Offset: 0x001B7934
		// (set) Token: 0x06005C50 RID: 23632 RVA: 0x0002BB9F File Offset: 0x00029D9F
		public unsafe Action onQualitySettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onQualitySettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onQualitySettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x001B9764 File Offset: 0x001B7964
		// (set) Token: 0x06005C52 RID: 23634 RVA: 0x0002BBBE File Offset: 0x00029DBE
		public unsafe Action onUnappliedDisplayIndexChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onUnappliedDisplayIndexChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onUnappliedDisplayIndexChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x001B9794 File Offset: 0x001B7994
		// (set) Token: 0x06005C54 RID: 23636 RVA: 0x0002BBDD File Offset: 0x00029DDD
		public unsafe PlatformDefaultSettings _thisPlatformDefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__thisPlatformDefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDefaultSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__thisPlatformDefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x001B97C4 File Offset: 0x001B79C4
		// (set) Token: 0x06005C56 RID: 23638 RVA: 0x0002BBFC File Offset: 0x00029DFC
		public unsafe float mouseCameraSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_mouseCameraSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_mouseCameraSensitivity)) = value;
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x001B97EC File Offset: 0x001B79EC
		// (set) Token: 0x06005C58 RID: 23640 RVA: 0x0002BC17 File Offset: 0x00029E17
		public unsafe float gamepadCameraSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_gamepadCameraSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_gamepadCameraSensitivity)) = value;
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06005C59 RID: 23641 RVA: 0x001B9814 File Offset: 0x001B7A14
		// (set) Token: 0x06005C5A RID: 23642 RVA: 0x0002BC32 File Offset: 0x00029E32
		public unsafe string _defaultBindingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__defaultBindingOverrides);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__defaultBindingOverrides), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003F0A RID: 16138
		private static readonly IntPtr NativeFieldInfoPtr_MinYPos;

		// Token: 0x04003F0B RID: 16139
		private static readonly IntPtr NativeFieldInfoPtr_BETA_ARG;

		// Token: 0x04003F0C RID: 16140
		private static readonly IntPtr NativeFieldInfoPtr_LaunchArgs;

		// Token: 0x04003F0D RID: 16141
		private static readonly IntPtr NativeFieldInfoPtr__ChristmasEventActive_k__BackingField;

		// Token: 0x04003F0E RID: 16142
		private static readonly IntPtr NativeFieldInfoPtr__UnitType_k__BackingField;

		// Token: 0x04003F0F RID: 16143
		private static readonly IntPtr NativeFieldInfoPtr_DisplaySettings;

		// Token: 0x04003F10 RID: 16144
		private static readonly IntPtr NativeFieldInfoPtr_UnappliedDisplaySettings;

		// Token: 0x04003F11 RID: 16145
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsSettings;

		// Token: 0x04003F12 RID: 16146
		private static readonly IntPtr NativeFieldInfoPtr_AudioSettings;

		// Token: 0x04003F13 RID: 16147
		private static readonly IntPtr NativeFieldInfoPtr_InputSettings;

		// Token: 0x04003F14 RID: 16148
		private static readonly IntPtr NativeFieldInfoPtr_GamepadSettings;

		// Token: 0x04003F15 RID: 16149
		private static readonly IntPtr NativeFieldInfoPtr_OtherSettings;

		// Token: 0x04003F16 RID: 16150
		private static readonly IntPtr NativeFieldInfoPtr_InputActions;

		// Token: 0x04003F17 RID: 16151
		private static readonly IntPtr NativeFieldInfoPtr_GameInput;

		// Token: 0x04003F18 RID: 16152
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04003F19 RID: 16153
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04003F1A RID: 16154
		private static readonly IntPtr NativeFieldInfoPtr__platformDefaultSettingsList;

		// Token: 0x04003F1B RID: 16155
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x04003F1C RID: 16156
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x04003F1D RID: 16157
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x04003F1E RID: 16158
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobIntensity;

		// Token: 0x04003F1F RID: 16159
		private static readonly IntPtr NativeFieldInfoPtr__gamepadRebindings;

		// Token: 0x04003F20 RID: 16160
		private static readonly IntPtr NativeFieldInfoPtr__pcRebindings;

		// Token: 0x04003F21 RID: 16161
		private static readonly IntPtr NativeFieldInfoPtr_playerControls;

		// Token: 0x04003F22 RID: 16162
		private static readonly IntPtr NativeFieldInfoPtr_onInputsApplied;

		// Token: 0x04003F23 RID: 16163
		private static readonly IntPtr NativeFieldInfoPtr_onDisplaySettingsApplied;

		// Token: 0x04003F24 RID: 16164
		private static readonly IntPtr NativeFieldInfoPtr_onQualitySettingsChanged;

		// Token: 0x04003F25 RID: 16165
		private static readonly IntPtr NativeFieldInfoPtr_onUnappliedDisplayIndexChanged;

		// Token: 0x04003F26 RID: 16166
		private static readonly IntPtr NativeFieldInfoPtr__thisPlatformDefaultSettings;

		// Token: 0x04003F27 RID: 16167
		private static readonly IntPtr NativeFieldInfoPtr_mouseCameraSensitivity;

		// Token: 0x04003F28 RID: 16168
		private static readonly IntPtr NativeFieldInfoPtr_gamepadCameraSensitivity;

		// Token: 0x04003F29 RID: 16169
		private static readonly IntPtr NativeFieldInfoPtr__defaultBindingOverrides;

		// Token: 0x04003F2A RID: 16170
		private static readonly IntPtr NativeMethodInfoPtr_get_ChristmasEventActive_Public_Static_get_Boolean_0;

		// Token: 0x04003F2B RID: 16171
		private static readonly IntPtr NativeMethodInfoPtr_set_ChristmasEventActive_Private_Static_set_Void_Boolean_0;

		// Token: 0x04003F2C RID: 16172
		private static readonly IntPtr NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0;

		// Token: 0x04003F2D RID: 16173
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitType_Public_get_EUnitType_0;

		// Token: 0x04003F2E RID: 16174
		private static readonly IntPtr NativeMethodInfoPtr_set_UnitType_Private_set_Void_EUnitType_0;

		// Token: 0x04003F2F RID: 16175
		private static readonly IntPtr NativeMethodInfoPtr_get_LookSensitivity_Public_get_Single_0;

		// Token: 0x04003F30 RID: 16176
		private static readonly IntPtr NativeMethodInfoPtr_add_onDisplaySettingsApplied_Public_add_Void_Action_0;

		// Token: 0x04003F31 RID: 16177
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDisplaySettingsApplied_Public_rem_Void_Action_0;

		// Token: 0x04003F32 RID: 16178
		private static readonly IntPtr NativeMethodInfoPtr_add_onQualitySettingsChanged_Public_add_Void_Action_0;

		// Token: 0x04003F33 RID: 16179
		private static readonly IntPtr NativeMethodInfoPtr_remove_onQualitySettingsChanged_Public_rem_Void_Action_0;

		// Token: 0x04003F34 RID: 16180
		private static readonly IntPtr NativeMethodInfoPtr_get_GamepadRebindings_Public_get_List_1_InputActionReference_0;

		// Token: 0x04003F35 RID: 16181
		private static readonly IntPtr NativeMethodInfoPtr_get_PCRebindings_Public_get_List_1_InputActionReference_0;

		// Token: 0x04003F36 RID: 16182
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003F37 RID: 16183
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003F38 RID: 16184
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x04003F39 RID: 16185
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0;

		// Token: 0x04003F3A RID: 16186
		private static readonly IntPtr NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0;

		// Token: 0x04003F3B RID: 16187
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x04003F3C RID: 16188
		private static readonly IntPtr NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0;

		// Token: 0x04003F3D RID: 16189
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x04003F3E RID: 16190
		private static readonly IntPtr NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0;

		// Token: 0x04003F3F RID: 16191
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0;

		// Token: 0x04003F40 RID: 16192
		private static readonly IntPtr NativeMethodInfoPtr_ReloadOtherSettings_Public_Void_0;

		// Token: 0x04003F41 RID: 16193
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOtherSettings_Public_Void_OtherSettings_0;

		// Token: 0x04003F42 RID: 16194
		private static readonly IntPtr NativeMethodInfoPtr_ReloadGamepadSettings_Public_Void_0;

		// Token: 0x04003F43 RID: 16195
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGamepadSettings_Public_Void_GamepadSettings_0;

		// Token: 0x04003F44 RID: 16196
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefaultKeyboardBindings_Public_Void_0;

		// Token: 0x04003F45 RID: 16197
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefaultGamepadBindings_Public_Void_0;

		// Token: 0x04003F46 RID: 16198
		private static readonly IntPtr NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x04003F47 RID: 16199
		private static readonly IntPtr NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0;

		// Token: 0x04003F48 RID: 16200
		private static readonly IntPtr NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x04003F49 RID: 16201
		private static readonly IntPtr NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0;

		// Token: 0x04003F4A RID: 16202
		private static readonly IntPtr NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x04003F4B RID: 16203
		private static readonly IntPtr NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0;

		// Token: 0x04003F4C RID: 16204
		private static readonly IntPtr NativeMethodInfoPtr_WriteGamepadSettings_Public_Void_GamepadSettings_0;

		// Token: 0x04003F4D RID: 16205
		private static readonly IntPtr NativeMethodInfoPtr_ReadGamepadSettings_Public_GamepadSettings_0;

		// Token: 0x04003F4E RID: 16206
		private static readonly IntPtr NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0;

		// Token: 0x04003F4F RID: 16207
		private static readonly IntPtr NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0;

		// Token: 0x04003F50 RID: 16208
		private static readonly IntPtr NativeMethodInfoPtr_WriteOtherSettings_Public_Void_OtherSettings_0;

		// Token: 0x04003F51 RID: 16209
		private static readonly IntPtr NativeMethodInfoPtr_ReadOtherSettings_Public_OtherSettings_0;

		// Token: 0x04003F52 RID: 16210
		private static readonly IntPtr NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0;

		// Token: 0x04003F53 RID: 16211
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultUnitTypeForPlayer_Private_EUnitType_0;

		// Token: 0x04003F54 RID: 16212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFF RID: 2815
		[OriginalName("Assembly-CSharp.dll", "", "EUnitType")]
		public enum EUnitType
		{
			// Token: 0x04009BB6 RID: 39862
			Metric,
			// Token: 0x04009BB7 RID: 39863
			Imperial
		}

		// Token: 0x02000B00 RID: 2816
		[ObfuscatedName("ScheduleOne.DevUtilities.Settings+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E562 RID: 58722 RVA: 0x00380D34 File Offset: 0x0037EF34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr);
				Settings.__c__DisplayClass51_0.NativeFieldInfoPtr_currentPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr, "currentPlatform");
				Settings.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr, 100675344);
				Settings.__c__DisplayClass51_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_PlatformDefaultSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr, 100675345);
			}

			// Token: 0x0600E563 RID: 58723 RVA: 0x00380D9C File Offset: 0x0037EF9C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E564 RID: 58724 RVA: 0x00380DD8 File Offset: 0x0037EFD8
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(PlatformDefaultSettings p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass51_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_PlatformDefaultSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E565 RID: 58725 RVA: 0x0006C2BE File Offset: 0x0006A4BE
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B1 RID: 17841
			// (get) Token: 0x0600E566 RID: 58726 RVA: 0x00380E28 File Offset: 0x0037F028
			// (set) Token: 0x0600E567 RID: 58727 RVA: 0x0006C2C7 File Offset: 0x0006A4C7
			public unsafe EHardwarePlatform currentPlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass51_0.NativeFieldInfoPtr_currentPlatform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass51_0.NativeFieldInfoPtr_currentPlatform)) = value;
				}
			}

			// Token: 0x04009BB8 RID: 39864
			private static readonly IntPtr NativeFieldInfoPtr_currentPlatform;

			// Token: 0x04009BB9 RID: 39865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BBA RID: 39866
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_PlatformDefaultSettings_0;
		}

		// Token: 0x02000B01 RID: 2817
		[ObfuscatedName("ScheduleOne.DevUtilities.Settings+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E568 RID: 58728 RVA: 0x00380E50 File Offset: 0x0037F050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr);
				Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, "resolution");
				Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, "mode");
				Settings.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				Settings.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, 100675346);
				Settings.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, 100675347);
			}

			// Token: 0x0600E569 RID: 58729 RVA: 0x00380EE0 File Offset: 0x0037F0E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E56A RID: 58730 RVA: 0x00380F1C File Offset: 0x0037F11C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 197746, RefRangeEnd = 197747, XrefRangeStart = 197741, XrefRangeEnd = 197746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E56B RID: 58731 RVA: 0x0006C2E2 File Offset: 0x0006A4E2
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B2 RID: 17842
			// (get) Token: 0x0600E56C RID: 58732 RVA: 0x00380F5C File Offset: 0x0037F15C
			// (set) Token: 0x0600E56D RID: 58733 RVA: 0x0006C2EB File Offset: 0x0006A4EB
			public unsafe Resolution resolution
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_resolution);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_resolution)) = value;
				}
			}

			// Token: 0x170045B3 RID: 17843
			// (get) Token: 0x0600E56E RID: 58734 RVA: 0x00380F84 File Offset: 0x0037F184
			// (set) Token: 0x0600E56F RID: 58735 RVA: 0x0006C306 File Offset: 0x0006A506
			public unsafe FullScreenMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x170045B4 RID: 17844
			// (get) Token: 0x0600E570 RID: 58736 RVA: 0x00380FAC File Offset: 0x0037F1AC
			// (set) Token: 0x0600E571 RID: 58737 RVA: 0x0006C321 File Offset: 0x0006A521
			public unsafe Settings __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Settings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BBB RID: 39867
			private static readonly IntPtr NativeFieldInfoPtr_resolution;

			// Token: 0x04009BBC RID: 39868
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04009BBD RID: 39869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BBE RID: 39870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BBF RID: 39871
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DD4 RID: 3540
			[ObfuscatedName("ScheduleOne.DevUtilities.Settings+<>c__DisplayClass53_0+<<ApplyDisplaySettings>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF84 RID: 65412 RVA: 0x003CC0C8 File Offset: 0x003CA2C8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0>.NativeClassPtr, "<<ApplyDisplaySettings>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675348);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675349);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675350);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675351);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675352);
					Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675353);
				}

				// Token: 0x0600FF85 RID: 65413 RVA: 0x003CC1A8 File Offset: 0x003CA3A8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF86 RID: 65414 RVA: 0x003CC1F0 File Offset: 0x003CA3F0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF87 RID: 65415 RVA: 0x003CC224 File Offset: 0x003CA424
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197729, XrefRangeEnd = 197736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DCC RID: 19916
				// (get) Token: 0x0600FF88 RID: 65416 RVA: 0x003CC260 File Offset: 0x003CA460
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF89 RID: 65417 RVA: 0x003CC2A0 File Offset: 0x003CA4A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197736, XrefRangeEnd = 197741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DCD RID: 19917
				// (get) Token: 0x0600FF8A RID: 65418 RVA: 0x003CC2D4 File Offset: 0x003CA4D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF8B RID: 65419 RVA: 0x00079137 File Offset: 0x00077337
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DC9 RID: 19913
				// (get) Token: 0x0600FF8C RID: 65420 RVA: 0x003CC314 File Offset: 0x003CA514
				// (set) Token: 0x0600FF8D RID: 65421 RVA: 0x00079140 File Offset: 0x00077340
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DCA RID: 19914
				// (get) Token: 0x0600FF8E RID: 65422 RVA: 0x003CC33C File Offset: 0x003CA53C
				// (set) Token: 0x0600FF8F RID: 65423 RVA: 0x0007915B File Offset: 0x0007735B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DCB RID: 19915
				// (get) Token: 0x0600FF90 RID: 65424 RVA: 0x003CC36C File Offset: 0x003CA56C
				// (set) Token: 0x0600FF91 RID: 65425 RVA: 0x0007917A File Offset: 0x0007737A
				public unsafe Settings.__c__DisplayClass53_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Settings.__c__DisplayClass53_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC27 RID: 44071
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC28 RID: 44072
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC29 RID: 44073
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC2A RID: 44074
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC2B RID: 44075
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC2C RID: 44076
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC2D RID: 44077
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC2E RID: 44078
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC2F RID: 44079
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
