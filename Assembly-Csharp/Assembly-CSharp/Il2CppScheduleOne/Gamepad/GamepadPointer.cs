using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E1 RID: 1761
	public class GamepadPointer : PersistentSingleton<GamepadPointer>
	{
		// Token: 0x0600A9FC RID: 43516 RVA: 0x002CEBF4 File Offset: 0x002CCDF4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointer()
		{
			Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr);
			GamepadPointer.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_canvas");
			GamepadPointer.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_container");
			GamepadPointer.NativeFieldInfoPtr__pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_pointer");
			GamepadPointer.NativeFieldInfoPtr__pointerGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_pointerGraphic");
			GamepadPointer.NativeFieldInfoPtr__defaultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_defaultData");
			GamepadPointer.NativeFieldInfoPtr__defaultLureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_defaultLureData");
			GamepadPointer.NativeFieldInfoPtr__modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_modifier");
			GamepadPointer.NativeFieldInfoPtr__maxFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_maxFriction");
			GamepadPointer.NativeFieldInfoPtr__frictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_frictionCurve");
			GamepadPointer.NativeFieldInfoPtr__pointerDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_pointerDataList");
			GamepadPointer.NativeFieldInfoPtr__pointerLureDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_pointerLureDataList");
			GamepadPointer.NativeFieldInfoPtr__debugDirectionMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_debugDirectionMatch");
			GamepadPointer.NativeFieldInfoPtr__lastPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_lastPointerData");
			GamepadPointer.NativeFieldInfoPtr__currentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_currentData");
			GamepadPointer.NativeFieldInfoPtr__dataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_dataLookup");
			GamepadPointer.NativeFieldInfoPtr__lureDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_lureDataLookup");
			GamepadPointer.NativeFieldInfoPtr__activeLures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_activeLures");
			GamepadPointer.NativeFieldInfoPtr__currentLure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_currentLure");
			GamepadPointer.NativeFieldInfoPtr__handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_handler");
			GamepadPointer.NativeFieldInfoPtr__previousRotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_previousRotationAngle");
			GamepadPointer.NativeFieldInfoPtr__isTrackingRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isTrackingRotation");
			GamepadPointer.NativeFieldInfoPtr__rotationDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_rotationDeadzone");
			GamepadPointer.NativeFieldInfoPtr__runRotationInputCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_runRotationInputCheck");
			GamepadPointer.NativeFieldInfoPtr__currentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_currentVelocity");
			GamepadPointer.NativeFieldInfoPtr__currentDistanceToLure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_currentDistanceToLure");
			GamepadPointer.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_sensitivity");
			GamepadPointer.NativeFieldInfoPtr__isInteractingWithLure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isInteractingWithLure");
			GamepadPointer.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isActive");
			GamepadPointer.NativeFieldInfoPtr__isGamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isGamePad");
			GamepadPointer.NativeFieldInfoPtr__isLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isLocked");
			GamepadPointer.NativeFieldInfoPtr__isAimAssistActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "_isAimAssistActive");
			GamepadPointer.NativeFieldInfoPtr_REFERENCE_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "REFERENCE_HEIGHT");
			GamepadPointer.NativeFieldInfoPtr__RotationDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, "<RotationDelta>k__BackingField");
			GamepadPointer.NativeMethodInfoPtr_get_ResolutionScale_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685856);
			GamepadPointer.NativeMethodInfoPtr_get_Acceleration_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685857);
			GamepadPointer.NativeMethodInfoPtr_get_Decceleration_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685858);
			GamepadPointer.NativeMethodInfoPtr_get_Speed_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685859);
			GamepadPointer.NativeMethodInfoPtr_get_RotationDelta_Public_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685860);
			GamepadPointer.NativeMethodInfoPtr_set_RotationDelta_Private_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685861);
			GamepadPointer.NativeMethodInfoPtr_get_IsRotationInputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685862);
			GamepadPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685863);
			GamepadPointer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685864);
			GamepadPointer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685865);
			GamepadPointer.NativeMethodInfoPtr_Initialise_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685866);
			GamepadPointer.NativeMethodInfoPtr_GetNearestLure_Public_IGamepadPointerLure_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685867);
			GamepadPointer.NativeMethodInfoPtr_GetActiveLures_Public_List_1_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685868);
			GamepadPointer.NativeMethodInfoPtr_GetClampedPositionFromVelocity_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685869);
			GamepadPointer.NativeMethodInfoPtr_GetClampedPosition_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685870);
			GamepadPointer.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685871);
			GamepadPointer.NativeMethodInfoPtr_UpdateVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685872);
			GamepadPointer.NativeMethodInfoPtr_IsRunning_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685873);
			GamepadPointer.NativeMethodInfoPtr_GetJoystickInput_Private_Vector2_EGamepadJoystickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685874);
			GamepadPointer.NativeMethodInfoPtr_HandleRotationInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685875);
			GamepadPointer.NativeMethodInfoPtr_GetRotationDelta_Private_Nullable_1_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685876);
			GamepadPointer.NativeMethodInfoPtr_GetJoystickMagnitude_Public_Single_Vector2_EGamepadJoystickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685877);
			GamepadPointer.NativeMethodInfoPtr_SetHandler_Public_Void_IGamepadPointerHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685878);
			GamepadPointer.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685879);
			GamepadPointer.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685880);
			GamepadPointer.NativeMethodInfoPtr_MoveToScreenCenter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685881);
			GamepadPointer.NativeMethodInfoPtr_SetSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685882);
			GamepadPointer.NativeMethodInfoPtr_SetAimAssist_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685883);
			GamepadPointer.NativeMethodInfoPtr_SetPointerData_Public_Void_GamepadPointerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685884);
			GamepadPointer.NativeMethodInfoPtr_SetPointerData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685885);
			GamepadPointer.NativeMethodInfoPtr_RevertPointerData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685886);
			GamepadPointer.NativeMethodInfoPtr_GetLureData_Public_GamepadPointerLureData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685887);
			GamepadPointer.NativeMethodInfoPtr_SetGraphic_Public_Void_Texture2D_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685888);
			GamepadPointer.NativeMethodInfoPtr_GetPointerScreenPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685889);
			GamepadPointer.NativeMethodInfoPtr_RegisterLure_Public_Void_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685890);
			GamepadPointer.NativeMethodInfoPtr_UnregisterLure_Public_Void_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685891);
			GamepadPointer.NativeMethodInfoPtr_SetRotationInputCheckActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685892);
			GamepadPointer.NativeMethodInfoPtr_SetPointerLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685893);
			GamepadPointer.NativeMethodInfoPtr_ConvertRadiusToScreenUnits_Public_Static_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685894);
			GamepadPointer.NativeMethodInfoPtr_DebugToggleActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685895);
			GamepadPointer.NativeMethodInfoPtr_SetToSnapHandler_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685896);
			GamepadPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr, 100685897);
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x002CF200 File Offset: 0x002CD400
		public unsafe float ResolutionScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294188, XrefRangeEnd = 294189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_ResolutionScale_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x002CF23C File Offset: 0x002CD43C
		public unsafe float Acceleration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294189, XrefRangeEnd = 294190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_Acceleration_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x002CF278 File Offset: 0x002CD478
		public unsafe float Decceleration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294190, XrefRangeEnd = 294191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_Decceleration_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x002CF2B4 File Offset: 0x002CD4B4
		public unsafe float Speed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294191, XrefRangeEnd = 294192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_Speed_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x002CF2F0 File Offset: 0x002CD4F0
		// (set) Token: 0x0600AA02 RID: 43522 RVA: 0x002CF328 File Offset: 0x002CD528
		public unsafe Nullable<float> RotationDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_RotationDelta_Public_get_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<float>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_set_RotationDelta_Private_set_Void_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x002CF370 File Offset: 0x002CD570
		public unsafe bool IsRotationInputActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_get_IsRotationInputActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x002CF3AC File Offset: 0x002CD5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294192, XrefRangeEnd = 294196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GamepadPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x002CF3E8 File Offset: 0x002CD5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294196, XrefRangeEnd = 294226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GamepadPointer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x002CF424 File Offset: 0x002CD624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294226, XrefRangeEnd = 294240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x002CF458 File Offset: 0x002CD658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294297, RefRangeEnd = 294298, XrefRangeStart = 294240, XrefRangeEnd = 294297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_Initialise_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x002CF48C File Offset: 0x002CD68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294324, RefRangeEnd = 294325, XrefRangeStart = 294298, XrefRangeEnd = 294324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGamepadPointerLure GetNearestLure(Vector2 screenPos, out Vector2 lureScreenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lureScreenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetNearestLure_Public_IGamepadPointerLure_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr3) : null;
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x002CF4E8 File Offset: 0x002CD6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38414, RefRangeEnd = 38415, XrefRangeStart = 38414, XrefRangeEnd = 38415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IGamepadPointerLure> GetActiveLures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetActiveLures_Public_List_1_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IGamepadPointerLure>>(intPtr3) : null;
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x002CF528 File Offset: 0x002CD728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294325, XrefRangeEnd = 294332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetClampedPositionFromVelocity(Vector2 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetClampedPositionFromVelocity_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x002CF574 File Offset: 0x002CD774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294338, RefRangeEnd = 294339, XrefRangeStart = 294332, XrefRangeEnd = 294338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetClampedPosition(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetClampedPosition_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x002CF5C0 File Offset: 0x002CD7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294339, XrefRangeEnd = 294340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputChange(GameInput.InputDeviceType deviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deviceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x002CF600 File Offset: 0x002CD800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294346, RefRangeEnd = 294350, XrefRangeStart = 294340, XrefRangeEnd = 294346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_UpdateVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x002CF634 File Offset: 0x002CD834
		[CallerCount(0)]
		public unsafe bool IsRunning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_IsRunning_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x002CF670 File Offset: 0x002CD870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294350, XrefRangeEnd = 294357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetJoystickInput(GamepadPointer.EGamepadJoystickType joystickType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref joystickType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetJoystickInput_Private_Vector2_EGamepadJoystickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002CF6BC File Offset: 0x002CD8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294374, RefRangeEnd = 294375, XrefRangeStart = 294357, XrefRangeEnd = 294374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleRotationInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_HandleRotationInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x002CF6F0 File Offset: 0x002CD8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294375, XrefRangeEnd = 294381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<float> GetRotationDelta(Vector2 input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetRotationDelta_Private_Nullable_1_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<float>(pointer);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x002CF734 File Offset: 0x002CD934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294406, RefRangeEnd = 294408, XrefRangeStart = 294381, XrefRangeEnd = 294406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetJoystickMagnitude(Vector2 direction = default(Vector2), GamepadPointer.EGamepadJoystickType joystickType = GamepadPointer.EGamepadJoystickType.Right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joystickType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetJoystickMagnitude_Public_Single_Vector2_EGamepadJoystickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x002CF78C File Offset: 0x002CD98C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294412, RefRangeEnd = 294419, XrefRangeStart = 294408, XrefRangeEnd = 294412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandler(IGamepadPointerHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetHandler_Public_Void_IGamepadPointerHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x002CF7D0 File Offset: 0x002CD9D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 294420, RefRangeEnd = 294430, XrefRangeStart = 294419, XrefRangeEnd = 294420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x002CF810 File Offset: 0x002CDA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294430, XrefRangeEnd = 294432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value, Vector2 startScreenPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startScreenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x002CF85C File Offset: 0x002CDA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294435, RefRangeEnd = 294437, XrefRangeStart = 294432, XrefRangeEnd = 294435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToScreenCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_MoveToScreenCenter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x002CF890 File Offset: 0x002CDA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294437, RefRangeEnd = 294438, XrefRangeStart = 294437, XrefRangeEnd = 294437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sensitivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x002CF8D0 File Offset: 0x002CDAD0
		[CallerCount(0)]
		public unsafe void SetAimAssist(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetAimAssist_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x002CF910 File Offset: 0x002CDB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294438, XrefRangeEnd = 294449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointerData(GamepadPointerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetPointerData_Public_Void_GamepadPointerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x002CF954 File Offset: 0x002CDB54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294462, RefRangeEnd = 294469, XrefRangeStart = 294449, XrefRangeEnd = 294462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointerData(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetPointerData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x002CF998 File Offset: 0x002CDB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294481, RefRangeEnd = 294482, XrefRangeStart = 294469, XrefRangeEnd = 294481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertPointerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_RevertPointerData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x002CF9CC File Offset: 0x002CDBCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294495, RefRangeEnd = 294498, XrefRangeStart = 294482, XrefRangeEnd = 294495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerLureData GetLureData(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetLureData_Public_GamepadPointerLureData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr3) : null;
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x002CFA1C File Offset: 0x002CDC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294502, RefRangeEnd = 294503, XrefRangeStart = 294498, XrefRangeEnd = 294502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGraphic(Texture2D texture, Vector2 hotSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotSpot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetGraphic_Public_Void_Texture2D_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x002CFA6C File Offset: 0x002CDC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294504, RefRangeEnd = 294505, XrefRangeStart = 294503, XrefRangeEnd = 294504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPointerScreenPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_GetPointerScreenPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x002CFAA8 File Offset: 0x002CDCA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294511, RefRangeEnd = 294514, XrefRangeStart = 294505, XrefRangeEnd = 294511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterLure(IGamepadPointerLure lure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_RegisterLure_Public_Void_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x002CFAEC File Offset: 0x002CDCEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294518, RefRangeEnd = 294520, XrefRangeStart = 294514, XrefRangeEnd = 294518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterLure(IGamepadPointerLure lure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_UnregisterLure_Public_Void_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x002CFB30 File Offset: 0x002CDD30
		[CallerCount(0)]
		public unsafe void SetRotationInputCheckActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetRotationInputCheckActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x002CFB70 File Offset: 0x002CDD70
		[CallerCount(0)]
		public unsafe void SetPointerLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetPointerLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x002CFBB0 File Offset: 0x002CDDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294520, XrefRangeEnd = 294528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertRadiusToScreenUnits(Vector3 worldPosition, float radius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_ConvertRadiusToScreenUnits_Public_Static_Single_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x002CFBFC File Offset: 0x002CDDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294528, XrefRangeEnd = 294529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugToggleActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_DebugToggleActive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x002CFC30 File Offset: 0x002CDE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294529, XrefRangeEnd = 294534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToSnapHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr_SetToSnapHandler_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x002CFC64 File Offset: 0x002CDE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294534, XrefRangeEnd = 294546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x0004D716 File Offset: 0x0004B916
		public GamepadPointer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600AA28 RID: 43560 RVA: 0x002CFCA0 File Offset: 0x002CDEA0
		// (set) Token: 0x0600AA29 RID: 43561 RVA: 0x0004D71F File Offset: 0x0004B91F
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600AA2A RID: 43562 RVA: 0x002CFCD0 File Offset: 0x002CDED0
		// (set) Token: 0x0600AA2B RID: 43563 RVA: 0x0004D73E File Offset: 0x0004B93E
		public unsafe RectTransform _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x002CFD00 File Offset: 0x002CDF00
		// (set) Token: 0x0600AA2D RID: 43565 RVA: 0x0004D75D File Offset: 0x0004B95D
		public unsafe RectTransform _pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x002CFD30 File Offset: 0x002CDF30
		// (set) Token: 0x0600AA2F RID: 43567 RVA: 0x0004D77C File Offset: 0x0004B97C
		public unsafe Graphic _pointerGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600AA30 RID: 43568 RVA: 0x002CFD60 File Offset: 0x002CDF60
		// (set) Token: 0x0600AA31 RID: 43569 RVA: 0x0004D79B File Offset: 0x0004B99B
		public unsafe GamepadPointerData _defaultData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__defaultData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__defaultData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600AA32 RID: 43570 RVA: 0x002CFD90 File Offset: 0x002CDF90
		// (set) Token: 0x0600AA33 RID: 43571 RVA: 0x0004D7BA File Offset: 0x0004B9BA
		public unsafe GamepadPointerLureData _defaultLureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__defaultLureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__defaultLureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x002CFDC0 File Offset: 0x002CDFC0
		// (set) Token: 0x0600AA35 RID: 43573 RVA: 0x0004D7D9 File Offset: 0x0004B9D9
		public unsafe float _modifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__modifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__modifier)) = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600AA36 RID: 43574 RVA: 0x002CFDE8 File Offset: 0x002CDFE8
		// (set) Token: 0x0600AA37 RID: 43575 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		public unsafe float _maxFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__maxFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__maxFriction)) = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600AA38 RID: 43576 RVA: 0x002CFE10 File Offset: 0x002CE010
		// (set) Token: 0x0600AA39 RID: 43577 RVA: 0x0004D80F File Offset: 0x0004BA0F
		public unsafe AnimationCurve _frictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__frictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__frictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600AA3A RID: 43578 RVA: 0x002CFE40 File Offset: 0x002CE040
		// (set) Token: 0x0600AA3B RID: 43579 RVA: 0x0004D82E File Offset: 0x0004BA2E
		public unsafe List<GamepadPointerData> _pointerDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GamepadPointerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600AA3C RID: 43580 RVA: 0x002CFE70 File Offset: 0x002CE070
		// (set) Token: 0x0600AA3D RID: 43581 RVA: 0x0004D84D File Offset: 0x0004BA4D
		public unsafe List<GamepadPointerLureData> _pointerLureDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerLureDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GamepadPointerLureData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__pointerLureDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600AA3E RID: 43582 RVA: 0x002CFEA0 File Offset: 0x002CE0A0
		// (set) Token: 0x0600AA3F RID: 43583 RVA: 0x0004D86C File Offset: 0x0004BA6C
		public unsafe float _debugDirectionMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__debugDirectionMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__debugDirectionMatch)) = value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x002CFEC8 File Offset: 0x002CE0C8
		// (set) Token: 0x0600AA41 RID: 43585 RVA: 0x0004D887 File Offset: 0x0004BA87
		public unsafe GamepadPointerData _lastPointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__lastPointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__lastPointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600AA42 RID: 43586 RVA: 0x002CFEF8 File Offset: 0x002CE0F8
		// (set) Token: 0x0600AA43 RID: 43587 RVA: 0x0004D8A6 File Offset: 0x0004BAA6
		public unsafe GamepadPointerData _currentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600AA44 RID: 43588 RVA: 0x002CFF28 File Offset: 0x002CE128
		// (set) Token: 0x0600AA45 RID: 43589 RVA: 0x0004D8C5 File Offset: 0x0004BAC5
		public unsafe Dictionary<string, GamepadPointerData> _dataLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__dataLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GamepadPointerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__dataLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x002CFF58 File Offset: 0x002CE158
		// (set) Token: 0x0600AA47 RID: 43591 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
		public unsafe Dictionary<string, GamepadPointerLureData> _lureDataLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__lureDataLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GamepadPointerLureData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__lureDataLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600AA48 RID: 43592 RVA: 0x002CFF88 File Offset: 0x002CE188
		// (set) Token: 0x0600AA49 RID: 43593 RVA: 0x0004D903 File Offset: 0x0004BB03
		public unsafe List<IGamepadPointerLure> _activeLures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__activeLures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGamepadPointerLure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__activeLures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600AA4A RID: 43594 RVA: 0x002CFFB8 File Offset: 0x002CE1B8
		// (set) Token: 0x0600AA4B RID: 43595 RVA: 0x0004D922 File Offset: 0x0004BB22
		public unsafe IGamepadPointerLure _currentLure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentLure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentLure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600AA4C RID: 43596 RVA: 0x002CFFE8 File Offset: 0x002CE1E8
		// (set) Token: 0x0600AA4D RID: 43597 RVA: 0x0004D941 File Offset: 0x0004BB41
		public unsafe IGamepadPointerHandler _handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGamepadPointerHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600AA4E RID: 43598 RVA: 0x002D0018 File Offset: 0x002CE218
		// (set) Token: 0x0600AA4F RID: 43599 RVA: 0x0004D960 File Offset: 0x0004BB60
		public unsafe float _previousRotationAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__previousRotationAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__previousRotationAngle)) = value;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600AA50 RID: 43600 RVA: 0x002D0040 File Offset: 0x002CE240
		// (set) Token: 0x0600AA51 RID: 43601 RVA: 0x0004D97B File Offset: 0x0004BB7B
		public unsafe bool _isTrackingRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isTrackingRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isTrackingRotation)) = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600AA52 RID: 43602 RVA: 0x002D0068 File Offset: 0x002CE268
		// (set) Token: 0x0600AA53 RID: 43603 RVA: 0x0004D996 File Offset: 0x0004BB96
		public unsafe float _rotationDeadzone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__rotationDeadzone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__rotationDeadzone)) = value;
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600AA54 RID: 43604 RVA: 0x002D0090 File Offset: 0x002CE290
		// (set) Token: 0x0600AA55 RID: 43605 RVA: 0x0004D9B1 File Offset: 0x0004BBB1
		public unsafe bool _runRotationInputCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__runRotationInputCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__runRotationInputCheck)) = value;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x002D00B8 File Offset: 0x002CE2B8
		// (set) Token: 0x0600AA57 RID: 43607 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		public unsafe Vector2 _currentVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentVelocity)) = value;
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x002D00E0 File Offset: 0x002CE2E0
		// (set) Token: 0x0600AA59 RID: 43609 RVA: 0x0004D9E7 File Offset: 0x0004BBE7
		public unsafe float _currentDistanceToLure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentDistanceToLure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__currentDistanceToLure)) = value;
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x002D0108 File Offset: 0x002CE308
		// (set) Token: 0x0600AA5B RID: 43611 RVA: 0x0004DA02 File Offset: 0x0004BC02
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600AA5C RID: 43612 RVA: 0x002D0130 File Offset: 0x002CE330
		// (set) Token: 0x0600AA5D RID: 43613 RVA: 0x0004DA1D File Offset: 0x0004BC1D
		public unsafe bool _isInteractingWithLure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isInteractingWithLure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isInteractingWithLure)) = value;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x002D0158 File Offset: 0x002CE358
		// (set) Token: 0x0600AA5F RID: 43615 RVA: 0x0004DA38 File Offset: 0x0004BC38
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x002D0180 File Offset: 0x002CE380
		// (set) Token: 0x0600AA61 RID: 43617 RVA: 0x0004DA53 File Offset: 0x0004BC53
		public unsafe bool _isGamePad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isGamePad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isGamePad)) = value;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x002D01A8 File Offset: 0x002CE3A8
		// (set) Token: 0x0600AA63 RID: 43619 RVA: 0x0004DA6E File Offset: 0x0004BC6E
		public unsafe bool _isLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isLocked)) = value;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600AA64 RID: 43620 RVA: 0x002D01D0 File Offset: 0x002CE3D0
		// (set) Token: 0x0600AA65 RID: 43621 RVA: 0x0004DA89 File Offset: 0x0004BC89
		public unsafe bool _isAimAssistActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isAimAssistActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__isAimAssistActive)) = value;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600AA66 RID: 43622 RVA: 0x002D01F8 File Offset: 0x002CE3F8
		// (set) Token: 0x0600AA67 RID: 43623 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
		public unsafe static float REFERENCE_HEIGHT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadPointer.NativeFieldInfoPtr_REFERENCE_HEIGHT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadPointer.NativeFieldInfoPtr_REFERENCE_HEIGHT, (void*)(&value));
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x002D0214 File Offset: 0x002CE414
		// (set) Token: 0x0600AA69 RID: 43625 RVA: 0x0004DAB2 File Offset: 0x0004BCB2
		public Nullable<float> _RotationDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__RotationDelta_k__BackingField);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointer.NativeFieldInfoPtr__RotationDelta_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04007581 RID: 30081
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04007582 RID: 30082
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x04007583 RID: 30083
		private static readonly IntPtr NativeFieldInfoPtr__pointer;

		// Token: 0x04007584 RID: 30084
		private static readonly IntPtr NativeFieldInfoPtr__pointerGraphic;

		// Token: 0x04007585 RID: 30085
		private static readonly IntPtr NativeFieldInfoPtr__defaultData;

		// Token: 0x04007586 RID: 30086
		private static readonly IntPtr NativeFieldInfoPtr__defaultLureData;

		// Token: 0x04007587 RID: 30087
		private static readonly IntPtr NativeFieldInfoPtr__modifier;

		// Token: 0x04007588 RID: 30088
		private static readonly IntPtr NativeFieldInfoPtr__maxFriction;

		// Token: 0x04007589 RID: 30089
		private static readonly IntPtr NativeFieldInfoPtr__frictionCurve;

		// Token: 0x0400758A RID: 30090
		private static readonly IntPtr NativeFieldInfoPtr__pointerDataList;

		// Token: 0x0400758B RID: 30091
		private static readonly IntPtr NativeFieldInfoPtr__pointerLureDataList;

		// Token: 0x0400758C RID: 30092
		private static readonly IntPtr NativeFieldInfoPtr__debugDirectionMatch;

		// Token: 0x0400758D RID: 30093
		private static readonly IntPtr NativeFieldInfoPtr__lastPointerData;

		// Token: 0x0400758E RID: 30094
		private static readonly IntPtr NativeFieldInfoPtr__currentData;

		// Token: 0x0400758F RID: 30095
		private static readonly IntPtr NativeFieldInfoPtr__dataLookup;

		// Token: 0x04007590 RID: 30096
		private static readonly IntPtr NativeFieldInfoPtr__lureDataLookup;

		// Token: 0x04007591 RID: 30097
		private static readonly IntPtr NativeFieldInfoPtr__activeLures;

		// Token: 0x04007592 RID: 30098
		private static readonly IntPtr NativeFieldInfoPtr__currentLure;

		// Token: 0x04007593 RID: 30099
		private static readonly IntPtr NativeFieldInfoPtr__handler;

		// Token: 0x04007594 RID: 30100
		private static readonly IntPtr NativeFieldInfoPtr__previousRotationAngle;

		// Token: 0x04007595 RID: 30101
		private static readonly IntPtr NativeFieldInfoPtr__isTrackingRotation;

		// Token: 0x04007596 RID: 30102
		private static readonly IntPtr NativeFieldInfoPtr__rotationDeadzone;

		// Token: 0x04007597 RID: 30103
		private static readonly IntPtr NativeFieldInfoPtr__runRotationInputCheck;

		// Token: 0x04007598 RID: 30104
		private static readonly IntPtr NativeFieldInfoPtr__currentVelocity;

		// Token: 0x04007599 RID: 30105
		private static readonly IntPtr NativeFieldInfoPtr__currentDistanceToLure;

		// Token: 0x0400759A RID: 30106
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x0400759B RID: 30107
		private static readonly IntPtr NativeFieldInfoPtr__isInteractingWithLure;

		// Token: 0x0400759C RID: 30108
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400759D RID: 30109
		private static readonly IntPtr NativeFieldInfoPtr__isGamePad;

		// Token: 0x0400759E RID: 30110
		private static readonly IntPtr NativeFieldInfoPtr__isLocked;

		// Token: 0x0400759F RID: 30111
		private static readonly IntPtr NativeFieldInfoPtr__isAimAssistActive;

		// Token: 0x040075A0 RID: 30112
		private static readonly IntPtr NativeFieldInfoPtr_REFERENCE_HEIGHT;

		// Token: 0x040075A1 RID: 30113
		private static readonly IntPtr NativeFieldInfoPtr__RotationDelta_k__BackingField;

		// Token: 0x040075A2 RID: 30114
		private static readonly IntPtr NativeMethodInfoPtr_get_ResolutionScale_Protected_get_Single_0;

		// Token: 0x040075A3 RID: 30115
		private static readonly IntPtr NativeMethodInfoPtr_get_Acceleration_Protected_get_Single_0;

		// Token: 0x040075A4 RID: 30116
		private static readonly IntPtr NativeMethodInfoPtr_get_Decceleration_Protected_get_Single_0;

		// Token: 0x040075A5 RID: 30117
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Protected_get_Single_0;

		// Token: 0x040075A6 RID: 30118
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDelta_Public_get_Nullable_1_Single_0;

		// Token: 0x040075A7 RID: 30119
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDelta_Private_set_Void_Nullable_1_Single_0;

		// Token: 0x040075A8 RID: 30120
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationInputActive_Public_get_Boolean_0;

		// Token: 0x040075A9 RID: 30121
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040075AA RID: 30122
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040075AB RID: 30123
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040075AC RID: 30124
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Private_Void_0;

		// Token: 0x040075AD RID: 30125
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestLure_Public_IGamepadPointerLure_Vector2_byref_Vector2_0;

		// Token: 0x040075AE RID: 30126
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveLures_Public_List_1_IGamepadPointerLure_0;

		// Token: 0x040075AF RID: 30127
		private static readonly IntPtr NativeMethodInfoPtr_GetClampedPositionFromVelocity_Public_Vector2_Vector2_0;

		// Token: 0x040075B0 RID: 30128
		private static readonly IntPtr NativeMethodInfoPtr_GetClampedPosition_Public_Vector2_Vector2_0;

		// Token: 0x040075B1 RID: 30129
		private static readonly IntPtr NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0;

		// Token: 0x040075B2 RID: 30130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Private_Void_0;

		// Token: 0x040075B3 RID: 30131
		private static readonly IntPtr NativeMethodInfoPtr_IsRunning_Private_Boolean_0;

		// Token: 0x040075B4 RID: 30132
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickInput_Private_Vector2_EGamepadJoystickType_0;

		// Token: 0x040075B5 RID: 30133
		private static readonly IntPtr NativeMethodInfoPtr_HandleRotationInput_Private_Void_0;

		// Token: 0x040075B6 RID: 30134
		private static readonly IntPtr NativeMethodInfoPtr_GetRotationDelta_Private_Nullable_1_Single_Vector2_0;

		// Token: 0x040075B7 RID: 30135
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickMagnitude_Public_Single_Vector2_EGamepadJoystickType_0;

		// Token: 0x040075B8 RID: 30136
		private static readonly IntPtr NativeMethodInfoPtr_SetHandler_Public_Void_IGamepadPointerHandler_0;

		// Token: 0x040075B9 RID: 30137
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040075BA RID: 30138
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_Vector2_0;

		// Token: 0x040075BB RID: 30139
		private static readonly IntPtr NativeMethodInfoPtr_MoveToScreenCenter_Public_Void_0;

		// Token: 0x040075BC RID: 30140
		private static readonly IntPtr NativeMethodInfoPtr_SetSensitivity_Public_Void_Single_0;

		// Token: 0x040075BD RID: 30141
		private static readonly IntPtr NativeMethodInfoPtr_SetAimAssist_Public_Void_Boolean_0;

		// Token: 0x040075BE RID: 30142
		private static readonly IntPtr NativeMethodInfoPtr_SetPointerData_Public_Void_GamepadPointerData_0;

		// Token: 0x040075BF RID: 30143
		private static readonly IntPtr NativeMethodInfoPtr_SetPointerData_Public_Void_String_0;

		// Token: 0x040075C0 RID: 30144
		private static readonly IntPtr NativeMethodInfoPtr_RevertPointerData_Public_Void_0;

		// Token: 0x040075C1 RID: 30145
		private static readonly IntPtr NativeMethodInfoPtr_GetLureData_Public_GamepadPointerLureData_String_0;

		// Token: 0x040075C2 RID: 30146
		private static readonly IntPtr NativeMethodInfoPtr_SetGraphic_Public_Void_Texture2D_Vector2_0;

		// Token: 0x040075C3 RID: 30147
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerScreenPosition_Public_Vector3_0;

		// Token: 0x040075C4 RID: 30148
		private static readonly IntPtr NativeMethodInfoPtr_RegisterLure_Public_Void_IGamepadPointerLure_0;

		// Token: 0x040075C5 RID: 30149
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterLure_Public_Void_IGamepadPointerLure_0;

		// Token: 0x040075C6 RID: 30150
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationInputCheckActive_Public_Void_Boolean_0;

		// Token: 0x040075C7 RID: 30151
		private static readonly IntPtr NativeMethodInfoPtr_SetPointerLocked_Public_Void_Boolean_0;

		// Token: 0x040075C8 RID: 30152
		private static readonly IntPtr NativeMethodInfoPtr_ConvertRadiusToScreenUnits_Public_Static_Single_Vector3_Single_0;

		// Token: 0x040075C9 RID: 30153
		private static readonly IntPtr NativeMethodInfoPtr_DebugToggleActive_Public_Void_0;

		// Token: 0x040075CA RID: 30154
		private static readonly IntPtr NativeMethodInfoPtr_SetToSnapHandler_Public_Void_0;

		// Token: 0x040075CB RID: 30155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C9A RID: 3226
		[OriginalName("Assembly-CSharp.dll", "", "EGamepadJoystickType")]
		public enum EGamepadJoystickType
		{
			// Token: 0x0400A462 RID: 42082
			Left,
			// Token: 0x0400A463 RID: 42083
			Right
		}
	}
}
