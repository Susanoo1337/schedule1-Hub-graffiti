using System;
using Il2CppBeautify.Universal;
using Il2CppCorgiGodRays;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000389 RID: 905
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x06005018 RID: 20504 RVA: 0x0018ED5C File Offset: 0x0018CF5C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingManager()
		{
			Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PostProcessingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr);
			PostProcessingManager.NativeFieldInfoPtr_rendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "rendererData");
			PostProcessingManager.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GlobalVolume");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultIntensity");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultSmoothness");
			PostProcessingManager.NativeFieldInfoPtr_MinBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MinBlur");
			PostProcessingManager.NativeFieldInfoPtr_MaxBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MaxBlur");
			PostProcessingManager.NativeFieldInfoPtr_PostExposureCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "PostExposureCurve");
			PostProcessingManager.NativeFieldInfoPtr_PostExposureMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "PostExposureMultiplier");
			PostProcessingManager.NativeFieldInfoPtr_BloomIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "BloomIntensityCurve");
			PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ChromaticAberrationController");
			PostProcessingManager.NativeFieldInfoPtr_SaturationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "SaturationController");
			PostProcessingManager.NativeFieldInfoPtr_BloomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "BloomController");
			PostProcessingManager.NativeFieldInfoPtr_ColorFilterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorFilterController");
			PostProcessingManager.NativeFieldInfoPtr_vig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "vig");
			PostProcessingManager.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "DoF");
			PostProcessingManager.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GodRays");
			PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorAdjustments");
			PostProcessingManager.NativeFieldInfoPtr_beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "beautifySettings");
			PostProcessingManager.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "bloom");
			PostProcessingManager.NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "chromaticAberration");
			PostProcessingManager.NativeFieldInfoPtr_colorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "colorAdjustments");
			PostProcessingManager.NativeFieldInfoPtr__psychedelicFullScreenFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "_psychedelicFullScreenFeature");
			PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673701);
			PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673702);
			PostProcessingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673703);
			PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673704);
			PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673705);
			PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673706);
			PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673707);
			PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673708);
			PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673709);
			PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673710);
			PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673711);
			PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673712);
			PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_PsychedelicFullScreenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673713);
			PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673714);
			PostProcessingManager.NativeMethodInfoPtr_GetActivePsychedelicEffectProperties_Public_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673715);
			PostProcessingManager.NativeMethodInfoPtr_GetPsychedelicEffectDataPreset_Public_PsychedelicFullScreenData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673716);
			PostProcessingManager.NativeMethodInfoPtr_PrintValueOfPsychedelicEffectBlend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673717);
			PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673718);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x0018F0AC File Offset: 0x0018D2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178922, XrefRangeEnd = 178990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x0018F0E8 File Offset: 0x0018D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178990, XrefRangeEnd = 178991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x0018F11C File Offset: 0x0018D31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178991, XrefRangeEnd = 178998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x0018F158 File Offset: 0x0018D358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179018, RefRangeEnd = 179019, XrefRangeStart = 178998, XrefRangeEnd = 179018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x0018F18C File Offset: 0x0018D38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179020, RefRangeEnd = 179021, XrefRangeStart = 179019, XrefRangeEnd = 179020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideVignette(float intensity, float smoothness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x0018F1D8 File Offset: 0x0018D3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179021, XrefRangeEnd = 179022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVignette()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x0018F20C File Offset: 0x0018D40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179023, RefRangeEnd = 179024, XrefRangeStart = 179022, XrefRangeEnd = 179023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGodRayIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x0018F24C File Offset: 0x0018D44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179025, RefRangeEnd = 179026, XrefRangeStart = 179024, XrefRangeEnd = 179025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContrast(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x0018F28C File Offset: 0x0018D48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179028, RefRangeEnd = 179029, XrefRangeStart = 179026, XrefRangeEnd = 179028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSaturation(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x0018F2CC File Offset: 0x0018D4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179030, RefRangeEnd = 179031, XrefRangeStart = 179029, XrefRangeEnd = 179030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBloomThreshold(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x0018F30C File Offset: 0x0018D50C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 179033, RefRangeEnd = 179040, XrefRangeStart = 179031, XrefRangeEnd = 179033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlur(float blurLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blurLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x0018F34C File Offset: 0x0018D54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179044, RefRangeEnd = 179045, XrefRangeStart = 179040, XrefRangeEnd = 179044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPsychedelicEffectActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x0018F38C File Offset: 0x0018D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179045, XrefRangeEnd = 179046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPsychedelicEffectProperties(PsychedelicFullScreenData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_PsychedelicFullScreenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x0018F3D0 File Offset: 0x0018D5D0
		[CallerCount(0)]
		public unsafe void SetPsychedelicEffectProperties(PsychedelicFullScreenFeature.MaterialProperties properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x0018F414 File Offset: 0x0018D614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179046, RefRangeEnd = 179047, XrefRangeStart = 179046, XrefRangeEnd = 179046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenFeature.MaterialProperties GetActivePsychedelicEffectProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_GetActivePsychedelicEffectProperties_Public_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr3) : null;
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x0018F454 File Offset: 0x0018D654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179049, RefRangeEnd = 179051, XrefRangeStart = 179047, XrefRangeEnd = 179049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenData GetPsychedelicEffectDataPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_GetPsychedelicEffectDataPreset_Public_PsychedelicFullScreenData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenData>(intPtr3) : null;
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x0018F4A4 File Offset: 0x0018D6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179064, RefRangeEnd = 179065, XrefRangeStart = 179051, XrefRangeEnd = 179064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintValueOfPsychedelicEffectBlend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_PrintValueOfPsychedelicEffectBlend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x0018F4D8 File Offset: 0x0018D6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179065, XrefRangeEnd = 179068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00026502 File Offset: 0x00024702
		public PostProcessingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x0018F514 File Offset: 0x0018D714
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x0002650B File Offset: 0x0002470B
		public unsafe UniversalRendererData rendererData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_rendererData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRendererData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_rendererData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x0018F544 File Offset: 0x0018D744
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x0002652A File Offset: 0x0002472A
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x0018F574 File Offset: 0x0018D774
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x00026549 File Offset: 0x00024749
		public unsafe float Vig_DefaultIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity)) = value;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x0018F59C File Offset: 0x0018D79C
		// (set) Token: 0x06005033 RID: 20531 RVA: 0x00026564 File Offset: 0x00024764
		public unsafe float Vig_DefaultSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness)) = value;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x0018F5C4 File Offset: 0x0018D7C4
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x0002657F File Offset: 0x0002477F
		public unsafe float MinBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur)) = value;
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x0018F5EC File Offset: 0x0018D7EC
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x0002659A File Offset: 0x0002479A
		public unsafe float MaxBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur)) = value;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x0018F614 File Offset: 0x0018D814
		// (set) Token: 0x06005039 RID: 20537 RVA: 0x000265B5 File Offset: 0x000247B5
		public unsafe AnimationCurve PostExposureCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_PostExposureCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_PostExposureCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x0018F644 File Offset: 0x0018D844
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x000265D4 File Offset: 0x000247D4
		public unsafe float PostExposureMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_PostExposureMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_PostExposureMultiplier)) = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x0018F66C File Offset: 0x0018D86C
		// (set) Token: 0x0600503D RID: 20541 RVA: 0x000265EF File Offset: 0x000247EF
		public unsafe AnimationCurve BloomIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x0018F69C File Offset: 0x0018D89C
		// (set) Token: 0x0600503F RID: 20543 RVA: 0x0002660E File Offset: 0x0002480E
		public unsafe FloatSmoother ChromaticAberrationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x0018F6CC File Offset: 0x0018D8CC
		// (set) Token: 0x06005041 RID: 20545 RVA: 0x0002662D File Offset: 0x0002482D
		public unsafe FloatSmoother SaturationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x0018F6FC File Offset: 0x0018D8FC
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x0002664C File Offset: 0x0002484C
		public unsafe FloatSmoother BloomController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x0018F72C File Offset: 0x0018D92C
		// (set) Token: 0x06005045 RID: 20549 RVA: 0x0002666B File Offset: 0x0002486B
		public unsafe HDRColorSmoother ColorFilterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x0018F75C File Offset: 0x0018D95C
		// (set) Token: 0x06005047 RID: 20551 RVA: 0x0002668A File Offset: 0x0002488A
		public unsafe Vignette vig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vignette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06005048 RID: 20552 RVA: 0x0018F78C File Offset: 0x0018D98C
		// (set) Token: 0x06005049 RID: 20553 RVA: 0x000266A9 File Offset: 0x000248A9
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x0018F7BC File Offset: 0x0018D9BC
		// (set) Token: 0x0600504B RID: 20555 RVA: 0x000266C8 File Offset: 0x000248C8
		public unsafe GodRaysVolume GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GodRaysVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x0018F7EC File Offset: 0x0018D9EC
		// (set) Token: 0x0600504D RID: 20557 RVA: 0x000266E7 File Offset: 0x000248E7
		public unsafe ColorAdjustments ColorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x0600504E RID: 20558 RVA: 0x0018F81C File Offset: 0x0018DA1C
		// (set) Token: 0x0600504F RID: 20559 RVA: 0x00026706 File Offset: 0x00024906
		public unsafe Beautify beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x0018F84C File Offset: 0x0018DA4C
		// (set) Token: 0x06005051 RID: 20561 RVA: 0x00026725 File Offset: 0x00024925
		public unsafe Bloom bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bloom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x0018F87C File Offset: 0x0018DA7C
		// (set) Token: 0x06005053 RID: 20563 RVA: 0x00026744 File Offset: 0x00024944
		public unsafe ChromaticAberration chromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x0018F8AC File Offset: 0x0018DAAC
		// (set) Token: 0x06005055 RID: 20565 RVA: 0x00026763 File Offset: 0x00024963
		public unsafe ColorAdjustments colorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x0018F8DC File Offset: 0x0018DADC
		// (set) Token: 0x06005057 RID: 20567 RVA: 0x00026782 File Offset: 0x00024982
		public unsafe PsychedelicFullScreenFeature _psychedelicFullScreenFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr__psychedelicFullScreenFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr__psychedelicFullScreenFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeFieldInfoPtr_rendererData;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultIntensity;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultSmoothness;

		// Token: 0x040036E9 RID: 14057
		private static readonly IntPtr NativeFieldInfoPtr_MinBlur;

		// Token: 0x040036EA RID: 14058
		private static readonly IntPtr NativeFieldInfoPtr_MaxBlur;

		// Token: 0x040036EB RID: 14059
		private static readonly IntPtr NativeFieldInfoPtr_PostExposureCurve;

		// Token: 0x040036EC RID: 14060
		private static readonly IntPtr NativeFieldInfoPtr_PostExposureMultiplier;

		// Token: 0x040036ED RID: 14061
		private static readonly IntPtr NativeFieldInfoPtr_BloomIntensityCurve;

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberrationController;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeFieldInfoPtr_SaturationController;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeFieldInfoPtr_BloomController;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeFieldInfoPtr_ColorFilterController;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeFieldInfoPtr_vig;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeFieldInfoPtr_ColorAdjustments;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeFieldInfoPtr_beautifySettings;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeFieldInfoPtr_bloom;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeFieldInfoPtr_chromaticAberration;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeFieldInfoPtr_colorAdjustments;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeFieldInfoPtr__psychedelicFullScreenFeature;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeMethodInfoPtr_ResetVignette_Public_Void_0;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeMethodInfoPtr_SetContrast_Public_Void_Single_0;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeMethodInfoPtr_SetBlur_Public_Void_Single_0;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeMethodInfoPtr_SetPsychedelicEffectActive_Public_Void_Boolean_0;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_PsychedelicFullScreenData_0;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeMethodInfoPtr_SetPsychedelicEffectProperties_Public_Void_MaterialProperties_0;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeMethodInfoPtr_GetActivePsychedelicEffectProperties_Public_MaterialProperties_0;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeMethodInfoPtr_GetPsychedelicEffectDataPreset_Public_PsychedelicFullScreenData_String_0;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeMethodInfoPtr_PrintValueOfPsychedelicEffectBlend_Public_Void_0;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A90 RID: 2704
		[ObfuscatedName("ScheduleOne.FX.PostProcessingManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E220 RID: 57888 RVA: 0x00377B44 File Offset: 0x00375D44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr);
				PostProcessingManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr, "<>9");
				PostProcessingManager.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr, "<>9__22_0");
				PostProcessingManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr, 100673720);
				PostProcessingManager.__c.NativeMethodInfoPtr__Awake_b__22_0_Internal_Boolean_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr, 100673721);
			}

			// Token: 0x0600E221 RID: 57889 RVA: 0x00377BC0 File Offset: 0x00375DC0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E222 RID: 57890 RVA: 0x00377BFC File Offset: 0x00375DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178917, XrefRangeEnd = 178922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__22_0(ScriptableRendererFeature x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.__c.NativeMethodInfoPtr__Awake_b__22_0_Internal_Boolean_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E223 RID: 57891 RVA: 0x0006A932 File Offset: 0x00068B32
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D1 RID: 17617
			// (get) Token: 0x0600E224 RID: 57892 RVA: 0x00377C4C File Offset: 0x00375E4C
			// (set) Token: 0x0600E225 RID: 57893 RVA: 0x0006A93B File Offset: 0x00068B3B
			public unsafe static PostProcessingManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessingManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessingManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D2 RID: 17618
			// (get) Token: 0x0600E226 RID: 57894 RVA: 0x00377C74 File Offset: 0x00375E74
			// (set) Token: 0x0600E227 RID: 57895 RVA: 0x0006A94D File Offset: 0x00068B4D
			public unsafe static Predicate<ScriptableRendererFeature> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessingManager.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRendererFeature>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessingManager.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099DE RID: 39390
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099DF RID: 39391
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x040099E0 RID: 39392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099E1 RID: 39393
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Internal_Boolean_ScriptableRendererFeature_0;
		}
	}
}
