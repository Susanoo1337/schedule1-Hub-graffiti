using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006EC RID: 1772
	public class HapticsManager : MonoBehaviour
	{
		// Token: 0x0600AAD3 RID: 43731 RVA: 0x002D1664 File Offset: 0x002CF864
		// Note: this type is marked as 'beforefieldinit'.
		static HapticsManager()
		{
			Il2CppClassPointerStore<HapticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "HapticsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr);
			HapticsManager.NativeFieldInfoPtr__hapticsMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsMultipler");
			HapticsManager.NativeFieldInfoPtr__hapticsCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsCurve");
			HapticsManager.NativeFieldInfoPtr__minMaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_minMaxForce");
			HapticsManager.NativeFieldInfoPtr__hapticsDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsDataList");
			HapticsManager.NativeFieldInfoPtr__LightForceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_LightForceMax");
			HapticsManager.NativeFieldInfoPtr__MediumForceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_MediumForceMax");
			HapticsManager.NativeFieldInfoPtr__HeavyForceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_HeavyForceMax");
			HapticsManager.NativeFieldInfoPtr__debugHapticsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_debugHapticsId");
			HapticsManager.NativeFieldInfoPtr__enableHaptics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_enableHaptics");
			HapticsManager.NativeFieldInfoPtr__bypassInputCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_bypassInputCheck");
			HapticsManager.NativeFieldInfoPtr__hapticsRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsRegistry");
			HapticsManager.NativeFieldInfoPtr__currentHapticsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_currentHapticsData");
			HapticsManager.NativeFieldInfoPtr__hapticsCo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsCo");
			HapticsManager.NativeFieldInfoPtr__hapticsTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_hapticsTimer");
			HapticsManager.NativeFieldInfoPtr__canExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "_canExit");
			HapticsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685933);
			HapticsManager.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685934);
			HapticsManager.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_HapticsData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685935);
			HapticsManager.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685936);
			HapticsManager.NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685937);
			HapticsManager.NativeMethodInfoPtr_SetMultiplier_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685938);
			HapticsManager.NativeMethodInfoPtr_DoHapticsRoutine_Private_IEnumerator_HapticsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685939);
			HapticsManager.NativeMethodInfoPtr_GetHapticsIntensity_Private_Single_HapticSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685940);
			HapticsManager.NativeMethodInfoPtr_SetHaptics_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685941);
			HapticsManager.NativeMethodInfoPtr_ForceToMultiplier_Public_Virtual_Final_New_Single_EHapticImpact_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685942);
			HapticsManager.NativeMethodInfoPtr_DebugTriggerHaptics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685943);
			HapticsManager.NativeMethodInfoPtr_DebugEndHaptics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685944);
			HapticsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685945);
			HapticsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, 100685946);
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x002D18D8 File Offset: 0x002CFAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294715, XrefRangeEnd = 294748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x002D190C File Offset: 0x002CFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294748, XrefRangeEnd = 294759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(string preset, float intensityMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x002D195C File Offset: 0x002CFB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294759, XrefRangeEnd = 294795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(HapticsData data, float intensityMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_HapticsData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x002D19AC File Offset: 0x002CFBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294795, XrefRangeEnd = 294799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x002D19E0 File Offset: 0x002CFBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294799, XrefRangeEnd = 294811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAD9 RID: 43737 RVA: 0x002D1A14 File Offset: 0x002CFC14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294811, RefRangeEnd = 294818, XrefRangeStart = 294811, XrefRangeEnd = 294811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_SetMultiplier_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x002D1A54 File Offset: 0x002CFC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294818, XrefRangeEnd = 294824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoHapticsRoutine(HapticsData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_DoHapticsRoutine_Private_IEnumerator_HapticsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x002D1AA4 File Offset: 0x002CFCA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294827, RefRangeEnd = 294829, XrefRangeStart = 294824, XrefRangeEnd = 294827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetHapticsIntensity(HapticSettings settings, float timer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_GetHapticsIntensity_Private_Single_HapticSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x002D1B00 File Offset: 0x002CFD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294831, RefRangeEnd = 294832, XrefRangeStart = 294829, XrefRangeEnd = 294831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHaptics(float lowFrequencyIntensity, float highFrequencyIntensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lowFrequencyIntensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highFrequencyIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_SetHaptics_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AADD RID: 43741 RVA: 0x002D1B4C File Offset: 0x002CFD4C
		[CallerCount(0)]
		public unsafe virtual float ForceToMultiplier(EHapticImpact impact, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impact;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_ForceToMultiplier_Public_Virtual_Final_New_Single_EHapticImpact_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x002D1BA4 File Offset: 0x002CFDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294832, XrefRangeEnd = 294843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugTriggerHaptics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_DebugTriggerHaptics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x002D1BD8 File Offset: 0x002CFDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugEndHaptics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_DebugEndHaptics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x002D1C0C File Offset: 0x002CFE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294843, XrefRangeEnd = 294845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x002D1C40 File Offset: 0x002CFE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294845, XrefRangeEnd = 294848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HapticsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAE2 RID: 43746 RVA: 0x0004DE0E File Offset: 0x0004C00E
		public HapticsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x002D1C7C File Offset: 0x002CFE7C
		// (set) Token: 0x0600AAE4 RID: 43748 RVA: 0x0004DE17 File Offset: 0x0004C017
		public unsafe float _hapticsMultipler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsMultipler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsMultipler)) = value;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600AAE5 RID: 43749 RVA: 0x002D1CA4 File Offset: 0x002CFEA4
		// (set) Token: 0x0600AAE6 RID: 43750 RVA: 0x0004DE32 File Offset: 0x0004C032
		public unsafe AnimationCurve _hapticsCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x002D1CD4 File Offset: 0x002CFED4
		// (set) Token: 0x0600AAE8 RID: 43752 RVA: 0x0004DE51 File Offset: 0x0004C051
		public unsafe Vector2 _minMaxForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__minMaxForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__minMaxForce)) = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600AAE9 RID: 43753 RVA: 0x002D1CFC File Offset: 0x002CFEFC
		// (set) Token: 0x0600AAEA RID: 43754 RVA: 0x0004DE6C File Offset: 0x0004C06C
		public unsafe List<HapticsData> _hapticsDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HapticsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x002D1D2C File Offset: 0x002CFF2C
		// (set) Token: 0x0600AAEC RID: 43756 RVA: 0x0004DE8B File Offset: 0x0004C08B
		public unsafe float _LightForceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__LightForceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__LightForceMax)) = value;
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x002D1D54 File Offset: 0x002CFF54
		// (set) Token: 0x0600AAEE RID: 43758 RVA: 0x0004DEA6 File Offset: 0x0004C0A6
		public unsafe float _MediumForceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__MediumForceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__MediumForceMax)) = value;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600AAEF RID: 43759 RVA: 0x002D1D7C File Offset: 0x002CFF7C
		// (set) Token: 0x0600AAF0 RID: 43760 RVA: 0x0004DEC1 File Offset: 0x0004C0C1
		public unsafe float _HeavyForceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__HeavyForceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__HeavyForceMax)) = value;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x002D1DA4 File Offset: 0x002CFFA4
		// (set) Token: 0x0600AAF2 RID: 43762 RVA: 0x0004DEDC File Offset: 0x0004C0DC
		public unsafe string _debugHapticsId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__debugHapticsId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__debugHapticsId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600AAF3 RID: 43763 RVA: 0x002D1DCC File Offset: 0x002CFFCC
		// (set) Token: 0x0600AAF4 RID: 43764 RVA: 0x0004DEFB File Offset: 0x0004C0FB
		public unsafe bool _enableHaptics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__enableHaptics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__enableHaptics)) = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600AAF5 RID: 43765 RVA: 0x002D1DF4 File Offset: 0x002CFFF4
		// (set) Token: 0x0600AAF6 RID: 43766 RVA: 0x0004DF16 File Offset: 0x0004C116
		public unsafe bool _bypassInputCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__bypassInputCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__bypassInputCheck)) = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600AAF7 RID: 43767 RVA: 0x002D1E1C File Offset: 0x002D001C
		// (set) Token: 0x0600AAF8 RID: 43768 RVA: 0x0004DF31 File Offset: 0x0004C131
		public unsafe Dictionary<string, HapticsData> _hapticsRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HapticsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600AAF9 RID: 43769 RVA: 0x002D1E4C File Offset: 0x002D004C
		// (set) Token: 0x0600AAFA RID: 43770 RVA: 0x0004DF50 File Offset: 0x0004C150
		public unsafe HapticsData _currentHapticsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__currentHapticsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HapticsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__currentHapticsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600AAFB RID: 43771 RVA: 0x002D1E7C File Offset: 0x002D007C
		// (set) Token: 0x0600AAFC RID: 43772 RVA: 0x0004DF6F File Offset: 0x0004C16F
		public unsafe Coroutine _hapticsCo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsCo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsCo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x002D1EAC File Offset: 0x002D00AC
		// (set) Token: 0x0600AAFE RID: 43774 RVA: 0x0004DF8E File Offset: 0x0004C18E
		public unsafe float _hapticsTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__hapticsTimer)) = value;
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600AAFF RID: 43775 RVA: 0x002D1ED4 File Offset: 0x002D00D4
		// (set) Token: 0x0600AB00 RID: 43776 RVA: 0x0004DFA9 File Offset: 0x0004C1A9
		public unsafe bool _canExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__canExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager.NativeFieldInfoPtr__canExit)) = value;
			}
		}

		// Token: 0x0400760C RID: 30220
		private static readonly IntPtr NativeFieldInfoPtr__hapticsMultipler;

		// Token: 0x0400760D RID: 30221
		private static readonly IntPtr NativeFieldInfoPtr__hapticsCurve;

		// Token: 0x0400760E RID: 30222
		private static readonly IntPtr NativeFieldInfoPtr__minMaxForce;

		// Token: 0x0400760F RID: 30223
		private static readonly IntPtr NativeFieldInfoPtr__hapticsDataList;

		// Token: 0x04007610 RID: 30224
		private static readonly IntPtr NativeFieldInfoPtr__LightForceMax;

		// Token: 0x04007611 RID: 30225
		private static readonly IntPtr NativeFieldInfoPtr__MediumForceMax;

		// Token: 0x04007612 RID: 30226
		private static readonly IntPtr NativeFieldInfoPtr__HeavyForceMax;

		// Token: 0x04007613 RID: 30227
		private static readonly IntPtr NativeFieldInfoPtr__debugHapticsId;

		// Token: 0x04007614 RID: 30228
		private static readonly IntPtr NativeFieldInfoPtr__enableHaptics;

		// Token: 0x04007615 RID: 30229
		private static readonly IntPtr NativeFieldInfoPtr__bypassInputCheck;

		// Token: 0x04007616 RID: 30230
		private static readonly IntPtr NativeFieldInfoPtr__hapticsRegistry;

		// Token: 0x04007617 RID: 30231
		private static readonly IntPtr NativeFieldInfoPtr__currentHapticsData;

		// Token: 0x04007618 RID: 30232
		private static readonly IntPtr NativeFieldInfoPtr__hapticsCo;

		// Token: 0x04007619 RID: 30233
		private static readonly IntPtr NativeFieldInfoPtr__hapticsTimer;

		// Token: 0x0400761A RID: 30234
		private static readonly IntPtr NativeFieldInfoPtr__canExit;

		// Token: 0x0400761B RID: 30235
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400761C RID: 30236
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_String_Single_0;

		// Token: 0x0400761D RID: 30237
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_HapticsData_Single_0;

		// Token: 0x0400761E RID: 30238
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400761F RID: 30239
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007620 RID: 30240
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x04007621 RID: 30241
		private static readonly IntPtr NativeMethodInfoPtr_DoHapticsRoutine_Private_IEnumerator_HapticsData_0;

		// Token: 0x04007622 RID: 30242
		private static readonly IntPtr NativeMethodInfoPtr_GetHapticsIntensity_Private_Single_HapticSettings_Single_0;

		// Token: 0x04007623 RID: 30243
		private static readonly IntPtr NativeMethodInfoPtr_SetHaptics_Private_Void_Single_Single_0;

		// Token: 0x04007624 RID: 30244
		private static readonly IntPtr NativeMethodInfoPtr_ForceToMultiplier_Public_Virtual_Final_New_Single_EHapticImpact_Single_0;

		// Token: 0x04007625 RID: 30245
		private static readonly IntPtr NativeMethodInfoPtr_DebugTriggerHaptics_Public_Void_0;

		// Token: 0x04007626 RID: 30246
		private static readonly IntPtr NativeMethodInfoPtr_DebugEndHaptics_Public_Void_0;

		// Token: 0x04007627 RID: 30247
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007628 RID: 30248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C9B RID: 3227
		[ObfuscatedName("ScheduleOne.Gamepad.HapticsManager+<DoHapticsRoutine>d__21")]
		public sealed class _DoHapticsRoutine_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600F303 RID: 62211 RVA: 0x003A8668 File Offset: 0x003A6868
			// Note: this type is marked as 'beforefieldinit'.
			static _DoHapticsRoutine_d__21()
			{
				Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HapticsManager>.NativeClassPtr, "<DoHapticsRoutine>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr);
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<>1__state");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<>2__current");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<>4__this");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "data");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__isContinuous_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<isContinuous>5__2");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__enterTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<enterTime>5__3");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__activeTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<activeTime>5__4");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__exitTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<exitTime>5__5");
				HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__totalDuration_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, "<totalDuration>5__6");
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685947);
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685948);
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685949);
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685950);
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685951);
				HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr, 100685952);
			}

			// Token: 0x0600F304 RID: 62212 RVA: 0x003A87C0 File Offset: 0x003A69C0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoHapticsRoutine_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HapticsManager._DoHapticsRoutine_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F305 RID: 62213 RVA: 0x003A8808 File Offset: 0x003A6A08
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F306 RID: 62214 RVA: 0x003A883C File Offset: 0x003A6A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294694, XrefRangeEnd = 294710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049C1 RID: 18881
			// (get) Token: 0x0600F307 RID: 62215 RVA: 0x003A8878 File Offset: 0x003A6A78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F308 RID: 62216 RVA: 0x003A88B8 File Offset: 0x003A6AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294710, XrefRangeEnd = 294715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049C2 RID: 18882
			// (get) Token: 0x0600F309 RID: 62217 RVA: 0x003A88EC File Offset: 0x003A6AEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsManager._DoHapticsRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F30A RID: 62218 RVA: 0x00072ACF File Offset: 0x00070CCF
			public _DoHapticsRoutine_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B8 RID: 18872
			// (get) Token: 0x0600F30B RID: 62219 RVA: 0x003A892C File Offset: 0x003A6B2C
			// (set) Token: 0x0600F30C RID: 62220 RVA: 0x00072AD8 File Offset: 0x00070CD8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049B9 RID: 18873
			// (get) Token: 0x0600F30D RID: 62221 RVA: 0x003A8954 File Offset: 0x003A6B54
			// (set) Token: 0x0600F30E RID: 62222 RVA: 0x00072AF3 File Offset: 0x00070CF3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BA RID: 18874
			// (get) Token: 0x0600F30F RID: 62223 RVA: 0x003A8984 File Offset: 0x003A6B84
			// (set) Token: 0x0600F310 RID: 62224 RVA: 0x00072B12 File Offset: 0x00070D12
			public unsafe HapticsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HapticsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BB RID: 18875
			// (get) Token: 0x0600F311 RID: 62225 RVA: 0x003A89B4 File Offset: 0x003A6BB4
			// (set) Token: 0x0600F312 RID: 62226 RVA: 0x00072B31 File Offset: 0x00070D31
			public unsafe HapticsData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HapticsData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BC RID: 18876
			// (get) Token: 0x0600F313 RID: 62227 RVA: 0x003A89E4 File Offset: 0x003A6BE4
			// (set) Token: 0x0600F314 RID: 62228 RVA: 0x00072B50 File Offset: 0x00070D50
			public unsafe bool _isContinuous_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__isContinuous_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__isContinuous_5__2)) = value;
				}
			}

			// Token: 0x170049BD RID: 18877
			// (get) Token: 0x0600F315 RID: 62229 RVA: 0x003A8A0C File Offset: 0x003A6C0C
			// (set) Token: 0x0600F316 RID: 62230 RVA: 0x00072B6B File Offset: 0x00070D6B
			public unsafe float _enterTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__enterTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__enterTime_5__3)) = value;
				}
			}

			// Token: 0x170049BE RID: 18878
			// (get) Token: 0x0600F317 RID: 62231 RVA: 0x003A8A34 File Offset: 0x003A6C34
			// (set) Token: 0x0600F318 RID: 62232 RVA: 0x00072B86 File Offset: 0x00070D86
			public unsafe float _activeTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__activeTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__activeTime_5__4)) = value;
				}
			}

			// Token: 0x170049BF RID: 18879
			// (get) Token: 0x0600F319 RID: 62233 RVA: 0x003A8A5C File Offset: 0x003A6C5C
			// (set) Token: 0x0600F31A RID: 62234 RVA: 0x00072BA1 File Offset: 0x00070DA1
			public unsafe float _exitTime_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__exitTime_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__exitTime_5__5)) = value;
				}
			}

			// Token: 0x170049C0 RID: 18880
			// (get) Token: 0x0600F31B RID: 62235 RVA: 0x003A8A84 File Offset: 0x003A6C84
			// (set) Token: 0x0600F31C RID: 62236 RVA: 0x00072BBC File Offset: 0x00070DBC
			public unsafe float _totalDuration_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__totalDuration_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsManager._DoHapticsRoutine_d__21.NativeFieldInfoPtr__totalDuration_5__6)) = value;
				}
			}

			// Token: 0x0400A464 RID: 42084
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A465 RID: 42085
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A466 RID: 42086
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A467 RID: 42087
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400A468 RID: 42088
			private static readonly IntPtr NativeFieldInfoPtr__isContinuous_5__2;

			// Token: 0x0400A469 RID: 42089
			private static readonly IntPtr NativeFieldInfoPtr__enterTime_5__3;

			// Token: 0x0400A46A RID: 42090
			private static readonly IntPtr NativeFieldInfoPtr__activeTime_5__4;

			// Token: 0x0400A46B RID: 42091
			private static readonly IntPtr NativeFieldInfoPtr__exitTime_5__5;

			// Token: 0x0400A46C RID: 42092
			private static readonly IntPtr NativeFieldInfoPtr__totalDuration_5__6;

			// Token: 0x0400A46D RID: 42093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A46E RID: 42094
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A46F RID: 42095
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A470 RID: 42096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A471 RID: 42097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A472 RID: 42098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
