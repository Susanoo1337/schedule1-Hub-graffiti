using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;
using Il2CppScheduleOne.Core.Weather;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D1 RID: 1745
	public class DayNightController : MonoBehaviour
	{
		// Token: 0x0600A794 RID: 42900 RVA: 0x002C6C74 File Offset: 0x002C4E74
		// Note: this type is marked as 'beforefieldinit'.
		static DayNightController()
		{
			Il2CppClassPointerStore<DayNightController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "DayNightController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightController>.NativeClassPtr);
			DayNightController.NativeFieldInfoPtr__lightPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_lightPivot");
			DayNightController.NativeFieldInfoPtr__skyRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_skyRenderer");
			DayNightController.NativeFieldInfoPtr__sunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_sunLight");
			DayNightController.NativeFieldInfoPtr__moonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_moonLight");
			DayNightController.NativeFieldInfoPtr__ambientLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_ambientLight");
			DayNightController.NativeFieldInfoPtr__fadeInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_fadeInCurve");
			DayNightController.NativeFieldInfoPtr__fadeOutCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_fadeOutCurve");
			DayNightController.NativeFieldInfoPtr__dayNightPhaseTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_dayNightPhaseTimes");
			DayNightController.NativeFieldInfoPtr__debugRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_debugRotationSpeed");
			DayNightController.NativeFieldInfoPtr__debugTimeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_debugTimeSpeed");
			DayNightController.NativeFieldInfoPtr__enableDebugTimeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_enableDebugTimeControl");
			DayNightController.NativeFieldInfoPtr__debugAutoUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_debugAutoUpdateTime");
			DayNightController.NativeFieldInfoPtr__timeInHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_timeInHours");
			DayNightController.NativeFieldInfoPtr__timePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_timePercentage");
			DayNightController.NativeFieldInfoPtr__isDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_isDay");
			DayNightController.NativeFieldInfoPtr__currentSunRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_currentSunRotation");
			DayNightController.NativeFieldInfoPtr__currentMoonRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "_currentMoonRotation");
			DayNightController.NativeFieldInfoPtr_SUN_SHADOW_STRENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "SUN_SHADOW_STRENGTH");
			DayNightController.NativeFieldInfoPtr_MOON_SHADOW_STRENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "MOON_SHADOW_STRENGTH");
			DayNightController.NativeFieldInfoPtr_MAX_LIGHT_INTENSITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, "MAX_LIGHT_INTENSITY");
			DayNightController.NativeMethodInfoPtr_get_EnableDebugTimeControl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685557);
			DayNightController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685558);
			DayNightController.NativeMethodInfoPtr_EvaluateSky_Private_SkyState_SkyState_SkySettings_SkySettings_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685559);
			DayNightController.NativeMethodInfoPtr_BlendSky_Private_SkyState_SkyState_SkyState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685560);
			DayNightController.NativeMethodInfoPtr_UpdateSky_Private_Void_SkyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685561);
			DayNightController.NativeMethodInfoPtr_SetLights_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685562);
			DayNightController.NativeMethodInfoPtr_UpdateRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685563);
			DayNightController.NativeMethodInfoPtr_SnapRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685564);
			DayNightController.NativeMethodInfoPtr_SetRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685565);
			DayNightController.NativeMethodInfoPtr_IsDay_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685566);
			DayNightController.NativeMethodInfoPtr_EvaluateSky_Public_SkyState_SkySettings_SkySettings_Single_SkySettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685567);
			DayNightController.NativeMethodInfoPtr_EvaluateFloatByTimeOfDay_Public_Single_DynamicGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685568);
			DayNightController.NativeMethodInfoPtr_EvaluateColorByTimeOfDay_Public_Color_DynamicGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685569);
			DayNightController.NativeMethodInfoPtr_OnUpdateTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685570);
			DayNightController.NativeMethodInfoPtr_OnTick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685571);
			DayNightController.NativeMethodInfoPtr_OnTimeSet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685572);
			DayNightController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightController>.NativeClassPtr, 100685573);
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A795 RID: 42901 RVA: 0x002C6F88 File Offset: 0x002C5188
		public unsafe bool EnableDebugTimeControl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_get_EnableDebugTimeControl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x002C6FC4 File Offset: 0x002C51C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291045, XrefRangeEnd = 291052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x002C6FF8 File Offset: 0x002C51F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291153, RefRangeEnd = 291155, XrefRangeStart = 291052, XrefRangeEnd = 291153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyState EvaluateSky(SkyState state, SkySettings activeSettings, SkySettings neighbourSettings, float blend, float timeInTwentyFourHour, float timePercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeSettings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neighbourSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeInTwentyFourHour;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timePercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_EvaluateSky_Private_SkyState_SkyState_SkySettings_SkySettings_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyState>(intPtr3) : null;
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x002C7098 File Offset: 0x002C5298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291192, RefRangeEnd = 291193, XrefRangeStart = 291155, XrefRangeEnd = 291192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyState BlendSky(SkyState from, SkyState to, float blend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_BlendSky_Private_SkyState_SkyState_SkyState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyState>(intPtr3) : null;
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x002C7108 File Offset: 0x002C5308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291193, XrefRangeEnd = 291200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSky(SkyState skyState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_UpdateSky_Private_Void_SkyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x002C714C File Offset: 0x002C534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291200, XrefRangeEnd = 291206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLights(bool isDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_SetLights_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x002C718C File Offset: 0x002C538C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291228, RefRangeEnd = 291229, XrefRangeStart = 291206, XrefRangeEnd = 291228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_UpdateRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x002C71C0 File Offset: 0x002C53C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291229, XrefRangeEnd = 291243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_SnapRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x002C71F4 File Offset: 0x002C53F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291245, RefRangeEnd = 291250, XrefRangeStart = 291243, XrefRangeEnd = 291245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_SetRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x002C7228 File Offset: 0x002C5428
		[CallerCount(0)]
		public unsafe bool IsDay(float timeInTwentyFourHour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeInTwentyFourHour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_IsDay_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x002C7274 File Offset: 0x002C5474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291272, RefRangeEnd = 291273, XrefRangeStart = 291250, XrefRangeEnd = 291272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyState EvaluateSky(SkySettings activeSettings, SkySettings neighbourSettings, float blend, SkySettings overrideSkySettings = null, float overrideBlend = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeSettings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neighbourSettings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideSkySettings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideBlend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_EvaluateSky_Public_SkyState_SkySettings_SkySettings_Single_SkySettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyState>(intPtr3) : null;
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x002C7308 File Offset: 0x002C5508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291273, XrefRangeEnd = 291274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EvaluateFloatByTimeOfDay(DynamicGradient gradient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_EvaluateFloatByTimeOfDay_Public_Single_DynamicGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x002C7358 File Offset: 0x002C5558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291274, XrefRangeEnd = 291275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color EvaluateColorByTimeOfDay(DynamicGradient gradient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_EvaluateColorByTimeOfDay_Public_Color_DynamicGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x002C73A8 File Offset: 0x002C55A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291275, XrefRangeEnd = 291278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUpdateTime(float normalisedTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalisedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_OnUpdateTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x002C73E8 File Offset: 0x002C55E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291278, XrefRangeEnd = 291279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_OnTick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x002C741C File Offset: 0x002C561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291279, XrefRangeEnd = 291297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSet(float normalisedTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalisedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr_OnTimeSet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x002C745C File Offset: 0x002C565C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291297, XrefRangeEnd = 291298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayNightController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayNightController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayNightController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x0004C2ED File Offset: 0x0004A4ED
		public DayNightController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x002C7498 File Offset: 0x002C5698
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x0004C2F6 File Offset: 0x0004A4F6
		public unsafe GameObject _lightPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__lightPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__lightPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x002C74C8 File Offset: 0x002C56C8
		// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x0004C315 File Offset: 0x0004A515
		public unsafe MeshRenderer _skyRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__skyRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__skyRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x002C74F8 File Offset: 0x002C56F8
		// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x0004C334 File Offset: 0x0004A534
		public unsafe Light _sunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__sunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__sunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002C7528 File Offset: 0x002C5728
		// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x0004C353 File Offset: 0x0004A553
		public unsafe Light _moonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__moonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__moonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x002C7558 File Offset: 0x002C5758
		// (set) Token: 0x0600A7B0 RID: 42928 RVA: 0x0004C372 File Offset: 0x0004A572
		public unsafe Light _ambientLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__ambientLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__ambientLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x002C7588 File Offset: 0x002C5788
		// (set) Token: 0x0600A7B2 RID: 42930 RVA: 0x0004C391 File Offset: 0x0004A591
		public unsafe AnimationCurve _fadeInCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__fadeInCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__fadeInCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x002C75B8 File Offset: 0x002C57B8
		// (set) Token: 0x0600A7B4 RID: 42932 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		public unsafe AnimationCurve _fadeOutCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__fadeOutCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__fadeOutCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x002C75E8 File Offset: 0x002C57E8
		// (set) Token: 0x0600A7B6 RID: 42934 RVA: 0x0004C3CF File Offset: 0x0004A5CF
		public unsafe DayNightPhaseTimes _dayNightPhaseTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__dayNightPhaseTimes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__dayNightPhaseTimes)) = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A7B7 RID: 42935 RVA: 0x002C7610 File Offset: 0x002C5810
		// (set) Token: 0x0600A7B8 RID: 42936 RVA: 0x0004C3EA File Offset: 0x0004A5EA
		public unsafe float _debugRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugRotationSpeed)) = value;
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A7B9 RID: 42937 RVA: 0x002C7638 File Offset: 0x002C5838
		// (set) Token: 0x0600A7BA RID: 42938 RVA: 0x0004C405 File Offset: 0x0004A605
		public unsafe float _debugTimeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugTimeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugTimeSpeed)) = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x002C7660 File Offset: 0x002C5860
		// (set) Token: 0x0600A7BC RID: 42940 RVA: 0x0004C420 File Offset: 0x0004A620
		public unsafe bool _enableDebugTimeControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__enableDebugTimeControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__enableDebugTimeControl)) = value;
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x002C7688 File Offset: 0x002C5888
		// (set) Token: 0x0600A7BE RID: 42942 RVA: 0x0004C43B File Offset: 0x0004A63B
		public unsafe bool _debugAutoUpdateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugAutoUpdateTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__debugAutoUpdateTime)) = value;
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x002C76B0 File Offset: 0x002C58B0
		// (set) Token: 0x0600A7C0 RID: 42944 RVA: 0x0004C456 File Offset: 0x0004A656
		public unsafe float _timeInHours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__timeInHours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__timeInHours)) = value;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A7C1 RID: 42945 RVA: 0x002C76D8 File Offset: 0x002C58D8
		// (set) Token: 0x0600A7C2 RID: 42946 RVA: 0x0004C471 File Offset: 0x0004A671
		public unsafe float _timePercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__timePercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__timePercentage)) = value;
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600A7C3 RID: 42947 RVA: 0x002C7700 File Offset: 0x002C5900
		// (set) Token: 0x0600A7C4 RID: 42948 RVA: 0x0004C48C File Offset: 0x0004A68C
		public unsafe bool _isDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__isDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__isDay)) = value;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x002C7728 File Offset: 0x002C5928
		// (set) Token: 0x0600A7C6 RID: 42950 RVA: 0x0004C4A7 File Offset: 0x0004A6A7
		public unsafe Quaternion _currentSunRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__currentSunRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__currentSunRotation)) = value;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x002C7750 File Offset: 0x002C5950
		// (set) Token: 0x0600A7C8 RID: 42952 RVA: 0x0004C4C2 File Offset: 0x0004A6C2
		public unsafe Quaternion _currentMoonRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__currentMoonRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayNightController.NativeFieldInfoPtr__currentMoonRotation)) = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x002C7778 File Offset: 0x002C5978
		// (set) Token: 0x0600A7CA RID: 42954 RVA: 0x0004C4DD File Offset: 0x0004A6DD
		public unsafe static float SUN_SHADOW_STRENGTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DayNightController.NativeFieldInfoPtr_SUN_SHADOW_STRENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DayNightController.NativeFieldInfoPtr_SUN_SHADOW_STRENGTH, (void*)(&value));
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A7CB RID: 42955 RVA: 0x002C7794 File Offset: 0x002C5994
		// (set) Token: 0x0600A7CC RID: 42956 RVA: 0x0004C4EB File Offset: 0x0004A6EB
		public unsafe static float MOON_SHADOW_STRENGTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DayNightController.NativeFieldInfoPtr_MOON_SHADOW_STRENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DayNightController.NativeFieldInfoPtr_MOON_SHADOW_STRENGTH, (void*)(&value));
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x002C77B0 File Offset: 0x002C59B0
		// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x0004C4F9 File Offset: 0x0004A6F9
		public unsafe static float MAX_LIGHT_INTENSITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DayNightController.NativeFieldInfoPtr_MAX_LIGHT_INTENSITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DayNightController.NativeFieldInfoPtr_MAX_LIGHT_INTENSITY, (void*)(&value));
			}
		}

		// Token: 0x040073DC RID: 29660
		private static readonly IntPtr NativeFieldInfoPtr__lightPivot;

		// Token: 0x040073DD RID: 29661
		private static readonly IntPtr NativeFieldInfoPtr__skyRenderer;

		// Token: 0x040073DE RID: 29662
		private static readonly IntPtr NativeFieldInfoPtr__sunLight;

		// Token: 0x040073DF RID: 29663
		private static readonly IntPtr NativeFieldInfoPtr__moonLight;

		// Token: 0x040073E0 RID: 29664
		private static readonly IntPtr NativeFieldInfoPtr__ambientLight;

		// Token: 0x040073E1 RID: 29665
		private static readonly IntPtr NativeFieldInfoPtr__fadeInCurve;

		// Token: 0x040073E2 RID: 29666
		private static readonly IntPtr NativeFieldInfoPtr__fadeOutCurve;

		// Token: 0x040073E3 RID: 29667
		private static readonly IntPtr NativeFieldInfoPtr__dayNightPhaseTimes;

		// Token: 0x040073E4 RID: 29668
		private static readonly IntPtr NativeFieldInfoPtr__debugRotationSpeed;

		// Token: 0x040073E5 RID: 29669
		private static readonly IntPtr NativeFieldInfoPtr__debugTimeSpeed;

		// Token: 0x040073E6 RID: 29670
		private static readonly IntPtr NativeFieldInfoPtr__enableDebugTimeControl;

		// Token: 0x040073E7 RID: 29671
		private static readonly IntPtr NativeFieldInfoPtr__debugAutoUpdateTime;

		// Token: 0x040073E8 RID: 29672
		private static readonly IntPtr NativeFieldInfoPtr__timeInHours;

		// Token: 0x040073E9 RID: 29673
		private static readonly IntPtr NativeFieldInfoPtr__timePercentage;

		// Token: 0x040073EA RID: 29674
		private static readonly IntPtr NativeFieldInfoPtr__isDay;

		// Token: 0x040073EB RID: 29675
		private static readonly IntPtr NativeFieldInfoPtr__currentSunRotation;

		// Token: 0x040073EC RID: 29676
		private static readonly IntPtr NativeFieldInfoPtr__currentMoonRotation;

		// Token: 0x040073ED RID: 29677
		private static readonly IntPtr NativeFieldInfoPtr_SUN_SHADOW_STRENGTH;

		// Token: 0x040073EE RID: 29678
		private static readonly IntPtr NativeFieldInfoPtr_MOON_SHADOW_STRENGTH;

		// Token: 0x040073EF RID: 29679
		private static readonly IntPtr NativeFieldInfoPtr_MAX_LIGHT_INTENSITY;

		// Token: 0x040073F0 RID: 29680
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableDebugTimeControl_Public_get_Boolean_0;

		// Token: 0x040073F1 RID: 29681
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040073F2 RID: 29682
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSky_Private_SkyState_SkyState_SkySettings_SkySettings_Single_Single_Single_0;

		// Token: 0x040073F3 RID: 29683
		private static readonly IntPtr NativeMethodInfoPtr_BlendSky_Private_SkyState_SkyState_SkyState_Single_0;

		// Token: 0x040073F4 RID: 29684
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSky_Private_Void_SkyState_0;

		// Token: 0x040073F5 RID: 29685
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Private_Void_Boolean_0;

		// Token: 0x040073F6 RID: 29686
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Private_Void_0;

		// Token: 0x040073F7 RID: 29687
		private static readonly IntPtr NativeMethodInfoPtr_SnapRotation_Private_Void_0;

		// Token: 0x040073F8 RID: 29688
		private static readonly IntPtr NativeMethodInfoPtr_SetRotation_Private_Void_0;

		// Token: 0x040073F9 RID: 29689
		private static readonly IntPtr NativeMethodInfoPtr_IsDay_Private_Boolean_Single_0;

		// Token: 0x040073FA RID: 29690
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSky_Public_SkyState_SkySettings_SkySettings_Single_SkySettings_Single_0;

		// Token: 0x040073FB RID: 29691
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateFloatByTimeOfDay_Public_Single_DynamicGradient_0;

		// Token: 0x040073FC RID: 29692
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateColorByTimeOfDay_Public_Color_DynamicGradient_0;

		// Token: 0x040073FD RID: 29693
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateTime_Public_Void_Single_0;

		// Token: 0x040073FE RID: 29694
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Public_Void_0;

		// Token: 0x040073FF RID: 29695
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSet_Public_Void_Single_0;

		// Token: 0x04007400 RID: 29696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
