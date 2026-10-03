using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D5 RID: 213
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x000BFADC File Offset: 0x000BDCDC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCamera()
		{
			Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr);
			VehicleCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "followDelta");
			VehicleCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMinLimit");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideTime");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideReturnTime");
			VehicleCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "xSpeed");
			VehicleCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "ySpeed");
			VehicleCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMaxLimit");
			VehicleCamera.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "vehicle");
			VehicleCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraOrigin");
			VehicleCamera.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lateralOffset");
			VehicleCamera.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "verticalOffset");
			VehicleCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraReversed");
			VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			VehicleCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "orbitDistance");
			VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastFrameCameraOffset");
			VehicleCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastManualOffset");
			VehicleCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "targetTransform");
			VehicleCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraDolly");
			VehicleCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "x");
			VehicleCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "y");
			VehicleCamera.NativeFieldInfoPtr_mouseIdleCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "mouseIdleCooldown");
			VehicleCamera.NativeFieldInfoPtr_mouseIdleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "mouseIdleTimer");
			VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666225);
			VehicleCamera.NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666226);
			VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666227);
			VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666228);
			VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666229);
			VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666230);
			VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666231);
			VehicleCamera.NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666232);
			VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666233);
			VehicleCamera.NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666234);
			VehicleCamera.NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666235);
			VehicleCamera.NativeMethodInfoPtr_ForceCameraReturn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666236);
			VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666237);
			VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666238);
			VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666239);
			VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100666240);
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000BFE04 File Offset: 0x000BE004
		public unsafe Transform cam
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 93856, RefRangeEnd = 93891, XrefRangeStart = 93850, XrefRangeEnd = 93856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x000BFE44 File Offset: 0x000BE044
		public unsafe bool NeedSecondaryClick
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93898, RefRangeEnd = 93900, XrefRangeStart = 93891, XrefRangeEnd = 93898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000BFE80 File Offset: 0x000BE080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93900, XrefRangeEnd = 93963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000BFEBC File Offset: 0x000BE0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93963, XrefRangeEnd = 93975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000BFEF0 File Offset: 0x000BE0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93975, XrefRangeEnd = 93981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000BFF2C File Offset: 0x000BE12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93981, XrefRangeEnd = 94012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnteredVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000BFF70 File Offset: 0x000BE170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94012, XrefRangeEnd = 94029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000BFFA4 File Offset: 0x000BE1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94041, RefRangeEnd = 94042, XrefRangeStart = 94029, XrefRangeEnd = 94041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForMouseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000BFFD8 File Offset: 0x000BE1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94042, XrefRangeEnd = 94071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000C0014 File Offset: 0x000BE214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94148, RefRangeEnd = 94149, XrefRangeStart = 94071, XrefRangeEnd = 94148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleNonSecondaryClickCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000C0048 File Offset: 0x000BE248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94149, XrefRangeEnd = 94233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSecondaryClickCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000C007C File Offset: 0x000BE27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94233, XrefRangeEnd = 94236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceCameraReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_ForceCameraReturn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000C00B0 File Offset: 0x000BE2B0
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000C010C File Offset: 0x000BE30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94250, RefRangeEnd = 94252, XrefRangeStart = 94236, XrefRangeEnd = 94250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000C0148 File Offset: 0x000BE348
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 94279, RefRangeEnd = 94284, XrefRangeStart = 94252, XrefRangeEnd = 94279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000C0194 File Offset: 0x000BE394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94284, XrefRangeEnd = 94289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0000B2E7 File Offset: 0x000094E7
		public VehicleCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000C01D0 File Offset: 0x000BE3D0
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x000C01EC File Offset: 0x000BE3EC
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x0000B2FE File Offset: 0x000094FE
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x000C0208 File Offset: 0x000BE408
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x0000B30C File Offset: 0x0000950C
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x000C0224 File Offset: 0x000BE424
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x0000B31A File Offset: 0x0000951A
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x000C0240 File Offset: 0x000BE440
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x0000B328 File Offset: 0x00009528
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000C025C File Offset: 0x000BE45C
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x0000B336 File Offset: 0x00009536
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x000C0278 File Offset: 0x000BE478
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0000B344 File Offset: 0x00009544
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000C0294 File Offset: 0x000BE494
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0000B352 File Offset: 0x00009552
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x000C02C4 File Offset: 0x000BE4C4
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0000B371 File Offset: 0x00009571
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x000C02F4 File Offset: 0x000BE4F4
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0000B390 File Offset: 0x00009590
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x000C031C File Offset: 0x000BE51C
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0000B3AB File Offset: 0x000095AB
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x000C0344 File Offset: 0x000BE544
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x0000B3C6 File Offset: 0x000095C6
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x000C036C File Offset: 0x000BE56C
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0000B3E1 File Offset: 0x000095E1
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000C0394 File Offset: 0x000BE594
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x0000B3FC File Offset: 0x000095FC
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x000C03BC File Offset: 0x000BE5BC
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0000B417 File Offset: 0x00009617
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000C03E4 File Offset: 0x000BE5E4
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x0000B432 File Offset: 0x00009632
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000C040C File Offset: 0x000BE60C
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x0000B44D File Offset: 0x0000964D
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x000C043C File Offset: 0x000BE63C
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0000B46C File Offset: 0x0000966C
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x000C046C File Offset: 0x000BE66C
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0000B48B File Offset: 0x0000968B
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x000C0494 File Offset: 0x000BE694
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0000B4A6 File Offset: 0x000096A6
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000C04BC File Offset: 0x000BE6BC
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0000B4C1 File Offset: 0x000096C1
		public unsafe float mouseIdleCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_mouseIdleCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_mouseIdleCooldown)) = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x000C04E4 File Offset: 0x000BE6E4
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0000B4DC File Offset: 0x000096DC
		public unsafe float mouseIdleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_mouseIdleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_mouseIdleTimer)) = value;
			}
		}

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr_mouseIdleCooldown;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_mouseIdleTimer;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedSecondaryClick_Private_get_Boolean_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_CheckForMouseMovement_Private_Void_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_HandleNonSecondaryClickCameraMovement_Private_Void_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_HandleSecondaryClickCameraMovement_Private_Void_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_ForceCameraReturn_Private_Void_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
