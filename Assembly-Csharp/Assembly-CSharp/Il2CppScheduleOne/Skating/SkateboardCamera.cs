using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x0200012F RID: 303
	public class SkateboardCamera : NetworkBehaviour
	{
		// Token: 0x06001E41 RID: 7745 RVA: 0x000DE884 File Offset: 0x000DCA84
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardCamera()
		{
			Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr);
			SkateboardCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "followDelta");
			SkateboardCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMinLimit");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideTime");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideReturnTime");
			SkateboardCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "xSpeed");
			SkateboardCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "ySpeed");
			SkateboardCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMaxLimit");
			SkateboardCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraOrigin");
			SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraFollowSpeed");
			SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "HorizontalOffset");
			SkateboardCamera.NativeFieldInfoPtr_VerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "VerticalOffset");
			SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraDownAngle");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MinSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MaxSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplierChangeRate");
			SkateboardCamera.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "board");
			SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "currentFovMultiplier");
			SkateboardCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraReversed");
			SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "orbitDistance");
			SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastFrameCameraOffset");
			SkateboardCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastManualOffset");
			SkateboardCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "targetTransform");
			SkateboardCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraDolly");
			SkateboardCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "x");
			SkateboardCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "y");
			SkateboardCamera.NativeFieldInfoPtr_mouseIdleCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "mouseIdleCooldown");
			SkateboardCamera.NativeFieldInfoPtr_mouseIdleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "mouseIdleTimer");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667223);
			SkateboardCamera.NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667224);
			SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667225);
			SkateboardCamera.NativeMethodInfoPtr_OnPlayerMountedSkateboard_Private_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667226);
			SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667227);
			SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667228);
			SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667229);
			SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667230);
			SkateboardCamera.NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667231);
			SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667232);
			SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667233);
			SkateboardCamera.NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667234);
			SkateboardCamera.NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667235);
			SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667236);
			SkateboardCamera.NativeMethodInfoPtr_ForceCameraReturn_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667237);
			SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667238);
			SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667239);
			SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667240);
			SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667241);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667242);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667243);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667244);
			SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667245);
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000DECEC File Offset: 0x000DCEEC
		public unsafe Transform cam
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 104808, RefRangeEnd = 104844, XrefRangeStart = 104802, XrefRangeEnd = 104808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000DED2C File Offset: 0x000DCF2C
		public unsafe bool NeedSecondaryClick
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 104851, RefRangeEnd = 104853, XrefRangeStart = 104844, XrefRangeEnd = 104851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x000DED68 File Offset: 0x000DCF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104853, XrefRangeEnd = 104854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000DEDA4 File Offset: 0x000DCFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104854, XrefRangeEnd = 104881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerMountedSkateboard(Skateboard skateboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_OnPlayerMountedSkateboard_Private_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000DEDE8 File Offset: 0x000DCFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104881, XrefRangeEnd = 104884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000DEE24 File Offset: 0x000DD024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104884, XrefRangeEnd = 104917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000DEE58 File Offset: 0x000DD058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104917, XrefRangeEnd = 104927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000DEE8C File Offset: 0x000DD08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104927, XrefRangeEnd = 104944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000DEEC0 File Offset: 0x000DD0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104956, RefRangeEnd = 104957, XrefRangeStart = 104944, XrefRangeEnd = 104956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForMouseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000DEEF4 File Offset: 0x000DD0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104957, XrefRangeEnd = 104965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000DEF28 File Offset: 0x000DD128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104993, RefRangeEnd = 104994, XrefRangeStart = 104965, XrefRangeEnd = 104993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000DEF5C File Offset: 0x000DD15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105071, RefRangeEnd = 105072, XrefRangeStart = 104994, XrefRangeEnd = 105071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleNonSecondaryClickCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000DEF90 File Offset: 0x000DD190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105072, XrefRangeEnd = 105156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSecondaryClickCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000DEFC4 File Offset: 0x000DD1C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105173, RefRangeEnd = 105174, XrefRangeStart = 105156, XrefRangeEnd = 105173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000DEFF8 File Offset: 0x000DD1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105174, XrefRangeEnd = 105177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceCameraReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_ForceCameraReturn_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000DF02C File Offset: 0x000DD22C
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000DF088 File Offset: 0x000DD288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105187, RefRangeEnd = 105189, XrefRangeStart = 105177, XrefRangeEnd = 105187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000DF0C4 File Offset: 0x000DD2C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 105216, RefRangeEnd = 105221, XrefRangeStart = 105189, XrefRangeEnd = 105216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000DF110 File Offset: 0x000DD310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105221, XrefRangeEnd = 105226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000DF14C File Offset: 0x000DD34C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000DF188 File Offset: 0x000DD388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105226, RefRangeEnd = 105227, XrefRangeStart = 105226, XrefRangeEnd = 105226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000DF1C4 File Offset: 0x000DD3C4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000DF200 File Offset: 0x000DD400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105279, RefRangeEnd = 105280, XrefRangeStart = 105227, XrefRangeEnd = 105279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0001065C File Offset: 0x0000E85C
		public SkateboardCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x000DF234 File Offset: 0x000DD434
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00010665 File Offset: 0x0000E865
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000DF250 File Offset: 0x000DD450
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00010673 File Offset: 0x0000E873
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x000DF26C File Offset: 0x000DD46C
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00010681 File Offset: 0x0000E881
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x000DF288 File Offset: 0x000DD488
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0001068F File Offset: 0x0000E88F
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000DF2A4 File Offset: 0x000DD4A4
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0001069D File Offset: 0x0000E89D
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000DF2C0 File Offset: 0x000DD4C0
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x000106AB File Offset: 0x0000E8AB
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000DF2DC File Offset: 0x000DD4DC
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x000106B9 File Offset: 0x0000E8B9
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000DF2F8 File Offset: 0x000DD4F8
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x000106C7 File Offset: 0x0000E8C7
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000DF328 File Offset: 0x000DD528
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x000106E6 File Offset: 0x0000E8E6
		public unsafe float CameraFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed)) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000DF350 File Offset: 0x000DD550
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x00010701 File Offset: 0x0000E901
		public unsafe float HorizontalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset)) = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x000DF378 File Offset: 0x000DD578
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0001071C File Offset: 0x0000E91C
		public unsafe float VerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x000DF3A0 File Offset: 0x000DD5A0
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00010737 File Offset: 0x0000E937
		public unsafe float CameraDownAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle)) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00010752 File Offset: 0x0000E952
		public unsafe float FOVMultiplier_MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed)) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0001076D File Offset: 0x0000E96D
		public unsafe float FOVMultiplier_MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed)) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x000DF418 File Offset: 0x000DD618
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00010788 File Offset: 0x0000E988
		public unsafe float FOVMultiplierChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate)) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x000DF440 File Offset: 0x000DD640
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x000107A3 File Offset: 0x0000E9A3
		public unsafe Skateboard board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000DF470 File Offset: 0x000DD670
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x000107C2 File Offset: 0x0000E9C2
		public unsafe float currentFovMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier)) = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x000DF498 File Offset: 0x000DD698
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x000107DD File Offset: 0x0000E9DD
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x000DF4C0 File Offset: 0x000DD6C0
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x000107F8 File Offset: 0x0000E9F8
		public unsafe bool cameraAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted)) = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x000DF4E8 File Offset: 0x000DD6E8
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00010813 File Offset: 0x0000EA13
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x000DF510 File Offset: 0x000DD710
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x0001082E File Offset: 0x0000EA2E
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000DF538 File Offset: 0x000DD738
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00010849 File Offset: 0x0000EA49
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000DF560 File Offset: 0x000DD760
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00010864 File Offset: 0x0000EA64
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000DF588 File Offset: 0x000DD788
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0001087F File Offset: 0x0000EA7F
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000DF5B8 File Offset: 0x000DD7B8
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0001089E File Offset: 0x0000EA9E
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x000108BD File Offset: 0x0000EABD
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000DF610 File Offset: 0x000DD810
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x000108D8 File Offset: 0x0000EAD8
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x000DF638 File Offset: 0x000DD838
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x000108F3 File Offset: 0x0000EAF3
		public unsafe float mouseIdleCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_mouseIdleCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_mouseIdleCooldown)) = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000DF660 File Offset: 0x000DD860
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0001090E File Offset: 0x0000EB0E
		public unsafe float mouseIdleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_mouseIdleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_mouseIdleTimer)) = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000DF688 File Offset: 0x000DD888
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00010929 File Offset: 0x0000EB29
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000DF6B0 File Offset: 0x000DD8B0
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x00010944 File Offset: 0x0000EB44
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_CameraFollowSpeed;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalOffset;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_VerticalOffset;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_CameraDownAngle;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MinSpeed;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MaxSpeed;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplierChangeRate;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_board;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_currentFovMultiplier;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_cameraAdjusted;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr_mouseIdleCooldown;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_mouseIdleTimer;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerMountedSkateboard_Private_Void_Skateboard_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_1;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_1;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamera_Private_Void_1;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_1;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_1;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Private_Void_1;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_ForceCameraReturn_Private_Void_1;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
