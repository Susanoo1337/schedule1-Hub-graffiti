using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.Experimental;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DF RID: 223
	public class Wheel : MonoBehaviour
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x000C2C44 File Offset: 0x000C0E44
		// Note: this type is marked as 'beforefieldinit'.
		static Wheel()
		{
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Wheel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
			Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SIDEWAY_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "FORWARD_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DRIFT_AUDIO_THRESHOLD");
			Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "MIN_SPEED_FOR_DRIFT");
			Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "WHEEL_ANIMATION_DISTANCE");
			Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "HandbrakeFowardStiffnessMultiplier_Front");
			Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "HandbrakeSidewayStiffnessMultiplier_Front");
			Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Rear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "HandbrakeFowardStiffnessMultiplier_Rear");
			Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Rear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "HandbrakeSidewayStiffnessMultiplier_Rear");
			Wheel.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DEBUG_MODE");
			Wheel.NativeFieldInfoPtr_wheelModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelModel");
			Wheel.NativeFieldInfoPtr_modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "modelContainer");
			Wheel.NativeFieldInfoPtr_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelCollider");
			Wheel.NativeFieldInfoPtr_axleConnectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "axleConnectionPoint");
			Wheel.NativeFieldInfoPtr_staticCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "staticCollider");
			Wheel.NativeFieldInfoPtr_DriftParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticles");
			Wheel.NativeFieldInfoPtr__defaultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "_defaultData");
			Wheel.NativeFieldInfoPtr__rainOverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "_rainOverrideData");
			Wheel.NativeFieldInfoPtr_DriftParticlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticlesEnabled");
			Wheel.NativeFieldInfoPtr_DriftAudioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioEnabled");
			Wheel.NativeFieldInfoPtr_DriftAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioSource");
			Wheel.NativeFieldInfoPtr_defaultForwardStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultForwardStiffness");
			Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultSidewaysStiffness");
			Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<IsDrifting>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftTime>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftIntensity>k__BackingField");
			Wheel.NativeFieldInfoPtr__IsSteerWheel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<IsSteerWheel>k__BackingField");
			Wheel.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "vehicle");
			Wheel.NativeFieldInfoPtr_lastFixedUpdatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "lastFixedUpdatePosition");
			Wheel.NativeFieldInfoPtr_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelData");
			Wheel.NativeFieldInfoPtr_forwardCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "forwardCurve");
			Wheel.NativeFieldInfoPtr_sidewaysCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "sidewaysCurve");
			Wheel.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "_settings");
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666320);
			Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666321);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666322);
			Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666323);
			Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666324);
			Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666325);
			Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666326);
			Wheel.NativeMethodInfoPtr_get_IsSteerWheel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666327);
			Wheel.NativeMethodInfoPtr_set_IsSteerWheel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666328);
			Wheel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666329);
			Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666330);
			Wheel.NativeMethodInfoPtr_FixedUpdateWheel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666331);
			Wheel.NativeMethodInfoPtr_FakeWheelRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666332);
			Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666333);
			Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666334);
			Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666335);
			Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666336);
			Wheel.NativeMethodInfoPtr_SetPhysicsEnabled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666337);
			Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666338);
			Wheel.NativeMethodInfoPtr_OnWeatherChange_Public_Void_WeatherConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666339);
			Wheel.NativeMethodInfoPtr_ApplyDefaultWheelModelPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666340);
			Wheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100666341);
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000C30C0 File Offset: 0x000C12C0
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x000C30FC File Offset: 0x000C12FC
		public unsafe bool IsDrifting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000C313C File Offset: 0x000C133C
		public unsafe bool IsDrifting_Smoothed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000C3178 File Offset: 0x000C1378
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x000C31B4 File Offset: 0x000C13B4
		public unsafe float DriftTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x000C31F4 File Offset: 0x000C13F4
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x000C3230 File Offset: 0x000C1430
		public unsafe float DriftIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x000C3270 File Offset: 0x000C1470
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x000C32AC File Offset: 0x000C14AC
		public unsafe bool IsSteerWheel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsSteerWheel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_IsSteerWheel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000C32EC File Offset: 0x000C14EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94946, XrefRangeEnd = 94961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000C3320 File Offset: 0x000C1520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94961, XrefRangeEnd = 94966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000C335C File Offset: 0x000C155C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94988, RefRangeEnd = 94989, XrefRangeStart = 94966, XrefRangeEnd = 94988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdateWheel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_FixedUpdateWheel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000C3390 File Offset: 0x000C1590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95002, RefRangeEnd = 95003, XrefRangeStart = 94989, XrefRangeEnd = 95002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FakeWheelRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_FakeWheelRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000C33C4 File Offset: 0x000C15C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95034, RefRangeEnd = 95035, XrefRangeStart = 95003, XrefRangeEnd = 95034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDrifting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000C33F8 File Offset: 0x000C15F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95035, XrefRangeEnd = 95037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000C342C File Offset: 0x000C162C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95037, XrefRangeEnd = 95042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000C3460 File Offset: 0x000C1660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95061, RefRangeEnd = 95062, XrefRangeStart = 95042, XrefRangeEnd = 95061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000C3494 File Offset: 0x000C1694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95062, XrefRangeEnd = 95082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPhysicsEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_SetPhysicsEnabled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000C34E0 File Offset: 0x000C16E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95082, XrefRangeEnd = 95083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWheelGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000C351C File Offset: 0x000C171C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95097, RefRangeEnd = 95098, XrefRangeStart = 95083, XrefRangeEnd = 95097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeatherChange(WeatherConditions newConditions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newConditions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_OnWeatherChange_Public_Void_WeatherConditions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000C3560 File Offset: 0x000C1760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95098, XrefRangeEnd = 95110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultWheelModelPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_ApplyDefaultWheelModelPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000C3594 File Offset: 0x000C1794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95110, XrefRangeEnd = 95113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wheel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public Wheel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000C35D0 File Offset: 0x000C17D0
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000BAA5 File Offset: 0x00009CA5
		public unsafe static float SIDEWAY_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000C35EC File Offset: 0x000C17EC
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x0000BAB3 File Offset: 0x00009CB3
		public unsafe static float FORWARD_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000C3608 File Offset: 0x000C1808
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000BAC1 File Offset: 0x00009CC1
		public unsafe static float DRIFT_AUDIO_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000C3624 File Offset: 0x000C1824
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000BACF File Offset: 0x00009CCF
		public unsafe static float MIN_SPEED_FOR_DRIFT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x000C3640 File Offset: 0x000C1840
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000BADD File Offset: 0x00009CDD
		public unsafe static float WHEEL_ANIMATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x000C365C File Offset: 0x000C185C
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000BAEB File Offset: 0x00009CEB
		public unsafe static float HandbrakeFowardStiffnessMultiplier_Front
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Front, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Front, (void*)(&value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x000C3678 File Offset: 0x000C1878
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0000BAF9 File Offset: 0x00009CF9
		public unsafe static float HandbrakeSidewayStiffnessMultiplier_Front
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Front, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Front, (void*)(&value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x000C3694 File Offset: 0x000C1894
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x0000BB07 File Offset: 0x00009D07
		public unsafe static float HandbrakeFowardStiffnessMultiplier_Rear
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Rear, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Rear, (void*)(&value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x000C36B0 File Offset: 0x000C18B0
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000BB15 File Offset: 0x00009D15
		public unsafe static float HandbrakeSidewayStiffnessMultiplier_Rear
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Rear, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Rear, (void*)(&value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x000C36CC File Offset: 0x000C18CC
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000BB23 File Offset: 0x00009D23
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x000C36F4 File Offset: 0x000C18F4
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x0000BB3E File Offset: 0x00009D3E
		public unsafe Transform wheelModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x000C3724 File Offset: 0x000C1924
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0000BB5D File Offset: 0x00009D5D
		public unsafe Transform modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000C3754 File Offset: 0x000C1954
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x0000BB7C File Offset: 0x00009D7C
		public unsafe WheelCollider wheelCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x000C3784 File Offset: 0x000C1984
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x0000BB9B File Offset: 0x00009D9B
		public unsafe Transform axleConnectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000C37B4 File Offset: 0x000C19B4
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x0000BBBA File Offset: 0x00009DBA
		public unsafe Collider staticCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x000C37E4 File Offset: 0x000C19E4
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x0000BBD9 File Offset: 0x00009DD9
		public unsafe ParticleSystem DriftParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x000C3814 File Offset: 0x000C1A14
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public unsafe WheelData _defaultData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__defaultData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__defaultData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x000C3844 File Offset: 0x000C1A44
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x0000BC17 File Offset: 0x00009E17
		public unsafe WheelOverrideData _rainOverrideData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__rainOverrideData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelOverrideData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__rainOverrideData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x000C3874 File Offset: 0x000C1A74
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x0000BC36 File Offset: 0x00009E36
		public unsafe bool DriftParticlesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled)) = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x000C389C File Offset: 0x000C1A9C
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0000BC51 File Offset: 0x00009E51
		public unsafe bool DriftAudioEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled)) = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000C38C4 File Offset: 0x000C1AC4
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public unsafe AudioSourceController DriftAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000C38F4 File Offset: 0x000C1AF4
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x0000BC8B File Offset: 0x00009E8B
		public unsafe float defaultForwardStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness)) = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000C391C File Offset: 0x000C1B1C
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0000BCA6 File Offset: 0x00009EA6
		public unsafe float defaultSidewaysStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness)) = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000C3944 File Offset: 0x000C1B44
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x0000BCC1 File Offset: 0x00009EC1
		public unsafe bool _IsDrifting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x000C396C File Offset: 0x000C1B6C
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public unsafe float _DriftTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000C3994 File Offset: 0x000C1B94
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000BCF7 File Offset: 0x00009EF7
		public unsafe float _DriftIntensity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x000C39BC File Offset: 0x000C1BBC
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000BD12 File Offset: 0x00009F12
		public unsafe bool _IsSteerWheel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsSteerWheel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsSteerWheel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x000C39E4 File Offset: 0x000C1BE4
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0000BD2D File Offset: 0x00009F2D
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000C3A14 File Offset: 0x000C1C14
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public unsafe Vector3 lastFixedUpdatePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFixedUpdatePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFixedUpdatePosition)) = value;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000C3A3C File Offset: 0x000C1C3C
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x0000BD67 File Offset: 0x00009F67
		public WheelHit wheelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData);
				return new WheelHit(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000C3A6C File Offset: 0x000C1C6C
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x0000BD95 File Offset: 0x00009F95
		public unsafe WheelFrictionCurve forwardCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve)) = value;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000C3A94 File Offset: 0x000C1C94
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		public unsafe WheelFrictionCurve sidewaysCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000C3ABC File Offset: 0x000C1CBC
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0000BDCB File Offset: 0x00009FCB
		public unsafe VehicleSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Front;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Front;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeFowardStiffnessMultiplier_Rear;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSidewayStiffnessMultiplier_Rear;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeFieldInfoPtr_wheelModel;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr_modelContainer;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr_wheelCollider;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeFieldInfoPtr_axleConnectionPoint;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_staticCollider;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticles;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr__defaultData;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr__rainOverrideData;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticlesEnabled;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioEnabled;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioSource;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeFieldInfoPtr_defaultForwardStiffness;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr_defaultSidewaysStiffness;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr__IsDrifting_k__BackingField;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr__DriftTime_k__BackingField;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr__DriftIntensity_k__BackingField;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr__IsSteerWheel_k__BackingField;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_lastFixedUpdatePosition;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_wheelData;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_forwardCurve;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_sidewaysCurve;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteerWheel_Public_get_Boolean_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSteerWheel_Public_set_Void_Boolean_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdateWheel_Public_Void_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_FakeWheelRotation_Public_Void_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_CheckDrifting_Private_Void_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFriction_Private_Void_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_SetPhysicsEnabled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_OnWeatherChange_Public_Void_WeatherConditions_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDefaultWheelModelPosition_Private_Void_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
