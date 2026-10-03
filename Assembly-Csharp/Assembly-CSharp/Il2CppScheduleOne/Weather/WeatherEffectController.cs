using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Core.Audio;
using Il2CppScheduleOne.Core.Effects;
using Il2CppScheduleOne.Core.Weather;
using Il2CppScheduleOne.Effects;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006DE RID: 1758
	public class WeatherEffectController : EffectController
	{
		// Token: 0x0600A978 RID: 43384 RVA: 0x002CCD4C File Offset: 0x002CAF4C
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherEffectController()
		{
			Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "WeatherEffectController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr);
			WeatherEffectController.NativeFieldInfoPtr_particleEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "particleEffects");
			WeatherEffectController.NativeFieldInfoPtr_visualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "visualEffects");
			WeatherEffectController.NativeFieldInfoPtr_shaderEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "shaderEffects");
			WeatherEffectController.NativeFieldInfoPtr__audioSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_audioSources");
			WeatherEffectController.NativeFieldInfoPtr__controllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_controllerId");
			WeatherEffectController.NativeFieldInfoPtr__showGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_showGizmos");
			WeatherEffectController.NativeFieldInfoPtr__minMaxDistanceToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_minMaxDistanceToPlayer");
			WeatherEffectController.NativeFieldInfoPtr__distanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_distanceCurve");
			WeatherEffectController.NativeFieldInfoPtr__enclosureCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_enclosureCurve");
			WeatherEffectController.NativeFieldInfoPtr__effectSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_effectSettings");
			WeatherEffectController.NativeFieldInfoPtr__audioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_audioSettings");
			WeatherEffectController.NativeFieldInfoPtr__weatherBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_weatherBlend");
			WeatherEffectController.NativeFieldInfoPtr__mainVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_mainVolume");
			WeatherEffectController.NativeFieldInfoPtr__neighbourVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_neighbourVolume");
			WeatherEffectController.NativeFieldInfoPtr__audioRequiresUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "_audioRequiresUpdate");
			WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Weather.WeatherEffectControllerAssembly-CSharp.dll_Excuted");
			WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Weather.WeatherEffectControllerAssembly-CSharp.dll_Excuted");
			WeatherEffectController.NativeMethodInfoPtr_get_ControllerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685770);
			WeatherEffectController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685771);
			WeatherEffectController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685772);
			WeatherEffectController.NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_WeatherVolume_WeatherSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685773);
			WeatherEffectController.NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685774);
			WeatherEffectController.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685775);
			WeatherEffectController.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685776);
			WeatherEffectController.NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685777);
			WeatherEffectController.NativeMethodInfoPtr_SetEffectParamters_Private_Void_EffectHandler_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685778);
			WeatherEffectController.NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685779);
			WeatherEffectController.NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685780);
			WeatherEffectController.NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685781);
			WeatherEffectController.NativeMethodInfoPtr_SetVisualEffectColorParameter_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685782);
			WeatherEffectController.NativeMethodInfoPtr_FindEffectSettings_Public_EffectSettings_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685783);
			WeatherEffectController.NativeMethodInfoPtr_GetFromEffectSettings_Protected_Virtual_New_EffectSettings_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685784);
			WeatherEffectController.NativeMethodInfoPtr_SetAudio_Protected_Void_AudioSourceController_AudioSettingsWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685785);
			WeatherEffectController.NativeMethodInfoPtr_UpdateAudio_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685786);
			WeatherEffectController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685787);
			WeatherEffectController.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685788);
			WeatherEffectController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685789);
			WeatherEffectController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685790);
			WeatherEffectController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685791);
			WeatherEffectController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685792);
			WeatherEffectController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, 100685793);
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A979 RID: 43385 RVA: 0x002CD0B0 File Offset: 0x002CB2B0
		public unsafe string ControllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_get_ControllerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x002CD0E8 File Offset: 0x002CB2E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293413, RefRangeEnd = 293416, XrefRangeStart = 293407, XrefRangeEnd = 293413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x002CD124 File Offset: 0x002CB324
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x002CD160 File Offset: 0x002CB360
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293489, RefRangeEnd = 293494, XrefRangeStart = 293416, XrefRangeEnd = 293489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialise(WeatherVolume mainVolume, WeatherSettings weatherSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainVolume);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weatherSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_WeatherVolume_WeatherSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x002CD1C0 File Offset: 0x002CB3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNeighbourVolume(WeatherVolume neighbourVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(neighbourVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x002CD204 File Offset: 0x002CB404
		[CallerCount(0)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x002CD240 File Offset: 0x002CB440
		[CallerCount(0)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x002CD27C File Offset: 0x002CB47C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293510, RefRangeEnd = 293513, XrefRangeStart = 293494, XrefRangeEnd = 293510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendEffects(float blend, AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blend;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x002CD2CC File Offset: 0x002CB4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293600, RefRangeEnd = 293601, XrefRangeStart = 293513, XrefRangeEnd = 293600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffectParamters(EffectHandler effectHandler, float blend, AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effectHandler);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetEffectParamters_Private_Void_EffectHandler_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x002CD330 File Offset: 0x002CB530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293601, XrefRangeEnd = 293616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderNumericParameter(string paramater, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x002CD380 File Offset: 0x002CB580
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293631, RefRangeEnd = 293636, XrefRangeStart = 293616, XrefRangeEnd = 293631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualEffectNumericParameter(string paramater, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x002CD3D0 File Offset: 0x002CB5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293636, XrefRangeEnd = 293651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderColorParameter(string paramater, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x002CD420 File Offset: 0x002CB620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293651, XrefRangeEnd = 293666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualEffectColorParameter(string paramater, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetVisualEffectColorParameter_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x002CD470 File Offset: 0x002CB670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293666, XrefRangeEnd = 293681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectSettings FindEffectSettings(string handlerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(handlerId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_FindEffectSettings_Public_EffectSettings_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EffectSettings>(intPtr3) : null;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x002CD4C0 File Offset: 0x002CB6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293681, XrefRangeEnd = 293726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EffectSettings GetFromEffectSettings(string handlerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(handlerId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_GetFromEffectSettings_Protected_Virtual_New_EffectSettings_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EffectSettings>(intPtr3) : null;
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x002CD51C File Offset: 0x002CB71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293726, XrefRangeEnd = 293728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAudio(AudioSourceController controller, AudioSettingsWrapper settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_SetAudio_Protected_Void_AudioSourceController_AudioSettingsWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x002CD570 File Offset: 0x002CB770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293728, XrefRangeEnd = 293782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UpdateAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_UpdateAudio_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x002CD5B8 File Offset: 0x002CB7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293782, XrefRangeEnd = 293787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateProperties(Vector3 anchoredPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend, float enclosurePan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchoredPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrDistanceToPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosureBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosurePan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x002CD63C File Offset: 0x002CB83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293787, XrefRangeEnd = 293791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x002CD670 File Offset: 0x002CB870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292848, RefRangeEnd = 292849, XrefRangeStart = 292848, XrefRangeEnd = 292849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherEffectController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x002CD6AC File Offset: 0x002CB8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293792, RefRangeEnd = 293793, XrefRangeStart = 293791, XrefRangeEnd = 293792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x002CD6E8 File Offset: 0x002CB8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293794, RefRangeEnd = 293795, XrefRangeStart = 293793, XrefRangeEnd = 293794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x002CD724 File Offset: 0x002CB924
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x002CD760 File Offset: 0x002CB960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293795, XrefRangeEnd = 293801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherEffectController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x0004D349 File Offset: 0x0004B549
		public WeatherEffectController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A992 RID: 43410 RVA: 0x002CD79C File Offset: 0x002CB99C
		// (set) Token: 0x0600A993 RID: 43411 RVA: 0x0004D352 File Offset: 0x0004B552
		public unsafe List<ParticleEffectHandler> particleEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_particleEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleEffectHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_particleEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A994 RID: 43412 RVA: 0x002CD7CC File Offset: 0x002CB9CC
		// (set) Token: 0x0600A995 RID: 43413 RVA: 0x0004D371 File Offset: 0x0004B571
		public unsafe List<VFXEffectHandler> visualEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_visualEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VFXEffectHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_visualEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A996 RID: 43414 RVA: 0x002CD7FC File Offset: 0x002CB9FC
		// (set) Token: 0x0600A997 RID: 43415 RVA: 0x0004D390 File Offset: 0x0004B590
		public unsafe List<ShaderEffectHandler> shaderEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_shaderEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderEffectHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_shaderEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x002CD82C File Offset: 0x002CBA2C
		// (set) Token: 0x0600A999 RID: 43417 RVA: 0x0004D3AF File Offset: 0x0004B5AF
		public unsafe List<AudioSourceController> _audioSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A99A RID: 43418 RVA: 0x002CD85C File Offset: 0x002CBA5C
		// (set) Token: 0x0600A99B RID: 43419 RVA: 0x0004D3CE File Offset: 0x0004B5CE
		public unsafe string _controllerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__controllerId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__controllerId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A99C RID: 43420 RVA: 0x002CD884 File Offset: 0x002CBA84
		// (set) Token: 0x0600A99D RID: 43421 RVA: 0x0004D3ED File Offset: 0x0004B5ED
		public unsafe bool _showGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__showGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__showGizmos)) = value;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x002CD8AC File Offset: 0x002CBAAC
		// (set) Token: 0x0600A99F RID: 43423 RVA: 0x0004D408 File Offset: 0x0004B608
		public unsafe Vector2 _minMaxDistanceToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__minMaxDistanceToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__minMaxDistanceToPlayer)) = value;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A9A0 RID: 43424 RVA: 0x002CD8D4 File Offset: 0x002CBAD4
		// (set) Token: 0x0600A9A1 RID: 43425 RVA: 0x0004D423 File Offset: 0x0004B623
		public unsafe AnimationCurve _distanceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__distanceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__distanceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A9A2 RID: 43426 RVA: 0x002CD904 File Offset: 0x002CBB04
		// (set) Token: 0x0600A9A3 RID: 43427 RVA: 0x0004D442 File Offset: 0x0004B642
		public unsafe AnimationCurve _enclosureCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__enclosureCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__enclosureCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A9A4 RID: 43428 RVA: 0x002CD934 File Offset: 0x002CBB34
		// (set) Token: 0x0600A9A5 RID: 43429 RVA: 0x0004D461 File Offset: 0x0004B661
		public unsafe List<EffectSettings> _effectSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__effectSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EffectSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__effectSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A9A6 RID: 43430 RVA: 0x002CD964 File Offset: 0x002CBB64
		// (set) Token: 0x0600A9A7 RID: 43431 RVA: 0x0004D480 File Offset: 0x0004B680
		public unsafe List<Il2CppScheduleOne.Core.Audio.AudioSettings> _audioSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppScheduleOne.Core.Audio.AudioSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A9A8 RID: 43432 RVA: 0x002CD994 File Offset: 0x002CBB94
		// (set) Token: 0x0600A9A9 RID: 43433 RVA: 0x0004D49F File Offset: 0x0004B69F
		public unsafe float _weatherBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__weatherBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__weatherBlend)) = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A9AA RID: 43434 RVA: 0x002CD9BC File Offset: 0x002CBBBC
		// (set) Token: 0x0600A9AB RID: 43435 RVA: 0x0004D4BA File Offset: 0x0004B6BA
		public unsafe WeatherVolume _mainVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__mainVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__mainVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A9AC RID: 43436 RVA: 0x002CD9EC File Offset: 0x002CBBEC
		// (set) Token: 0x0600A9AD RID: 43437 RVA: 0x0004D4D9 File Offset: 0x0004B6D9
		public unsafe WeatherVolume _neighbourVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__neighbourVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__neighbourVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A9AE RID: 43438 RVA: 0x002CDA1C File Offset: 0x002CBC1C
		// (set) Token: 0x0600A9AF RID: 43439 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
		public unsafe bool _audioRequiresUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioRequiresUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr__audioRequiresUpdate)) = value;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A9B0 RID: 43440 RVA: 0x002CDA44 File Offset: 0x002CBC44
		// (set) Token: 0x0600A9B1 RID: 43441 RVA: 0x0004D513 File Offset: 0x0004B713
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A9B2 RID: 43442 RVA: 0x002CDA6C File Offset: 0x002CBC6C
		// (set) Token: 0x0600A9B3 RID: 43443 RVA: 0x0004D52E File Offset: 0x0004B72E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007524 RID: 29988
		private static readonly IntPtr NativeFieldInfoPtr_particleEffects;

		// Token: 0x04007525 RID: 29989
		private static readonly IntPtr NativeFieldInfoPtr_visualEffects;

		// Token: 0x04007526 RID: 29990
		private static readonly IntPtr NativeFieldInfoPtr_shaderEffects;

		// Token: 0x04007527 RID: 29991
		private static readonly IntPtr NativeFieldInfoPtr__audioSources;

		// Token: 0x04007528 RID: 29992
		private static readonly IntPtr NativeFieldInfoPtr__controllerId;

		// Token: 0x04007529 RID: 29993
		private static readonly IntPtr NativeFieldInfoPtr__showGizmos;

		// Token: 0x0400752A RID: 29994
		private static readonly IntPtr NativeFieldInfoPtr__minMaxDistanceToPlayer;

		// Token: 0x0400752B RID: 29995
		private static readonly IntPtr NativeFieldInfoPtr__distanceCurve;

		// Token: 0x0400752C RID: 29996
		private static readonly IntPtr NativeFieldInfoPtr__enclosureCurve;

		// Token: 0x0400752D RID: 29997
		private static readonly IntPtr NativeFieldInfoPtr__effectSettings;

		// Token: 0x0400752E RID: 29998
		private static readonly IntPtr NativeFieldInfoPtr__audioSettings;

		// Token: 0x0400752F RID: 29999
		private static readonly IntPtr NativeFieldInfoPtr__weatherBlend;

		// Token: 0x04007530 RID: 30000
		private static readonly IntPtr NativeFieldInfoPtr__mainVolume;

		// Token: 0x04007531 RID: 30001
		private static readonly IntPtr NativeFieldInfoPtr__neighbourVolume;

		// Token: 0x04007532 RID: 30002
		private static readonly IntPtr NativeFieldInfoPtr__audioRequiresUpdate;

		// Token: 0x04007533 RID: 30003
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007534 RID: 30004
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007535 RID: 30005
		private static readonly IntPtr NativeMethodInfoPtr_get_ControllerId_Public_get_String_0;

		// Token: 0x04007536 RID: 30006
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007537 RID: 30007
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04007538 RID: 30008
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_WeatherVolume_WeatherSettings_0;

		// Token: 0x04007539 RID: 30009
		private static readonly IntPtr NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0;

		// Token: 0x0400753A RID: 30010
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x0400753B RID: 30011
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x0400753C RID: 30012
		private static readonly IntPtr NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0;

		// Token: 0x0400753D RID: 30013
		private static readonly IntPtr NativeMethodInfoPtr_SetEffectParamters_Private_Void_EffectHandler_Single_AnimationCurve_0;

		// Token: 0x0400753E RID: 30014
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0;

		// Token: 0x0400753F RID: 30015
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0;

		// Token: 0x04007540 RID: 30016
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0;

		// Token: 0x04007541 RID: 30017
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualEffectColorParameter_Public_Void_String_Color_0;

		// Token: 0x04007542 RID: 30018
		private static readonly IntPtr NativeMethodInfoPtr_FindEffectSettings_Public_EffectSettings_String_0;

		// Token: 0x04007543 RID: 30019
		private static readonly IntPtr NativeMethodInfoPtr_GetFromEffectSettings_Protected_Virtual_New_EffectSettings_String_0;

		// Token: 0x04007544 RID: 30020
		private static readonly IntPtr NativeMethodInfoPtr_SetAudio_Protected_Void_AudioSourceController_AudioSettingsWrapper_0;

		// Token: 0x04007545 RID: 30021
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAudio_Public_Virtual_New_Boolean_0;

		// Token: 0x04007546 RID: 30022
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProperties_Public_Virtual_Void_Vector3_Vector3_Single_Single_Single_0;

		// Token: 0x04007547 RID: 30023
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007548 RID: 30024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007549 RID: 30025
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400754A RID: 30026
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400754B RID: 30027
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400754C RID: 30028
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000C8E RID: 3214
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2AB RID: 62123 RVA: 0x003A76B4 File Offset: 0x003A58B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass19_0.NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr, "audioSource");
				WeatherEffectController.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr, 100685794);
				WeatherEffectController.__c__DisplayClass19_0.NativeMethodInfoPtr__Initialise_b__0_Internal_Boolean_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr, 100685795);
			}

			// Token: 0x0600F2AC RID: 62124 RVA: 0x003A771C File Offset: 0x003A591C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2AD RID: 62125 RVA: 0x003A7758 File Offset: 0x003A5958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293376, XrefRangeEnd = 293378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialise_b__0(Il2CppScheduleOne.Core.Audio.AudioSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass19_0.NativeMethodInfoPtr__Initialise_b__0_Internal_Boolean_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2AE RID: 62126 RVA: 0x0007282A File Offset: 0x00070A2A
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A5 RID: 18853
			// (get) Token: 0x0600F2AF RID: 62127 RVA: 0x003A77A8 File Offset: 0x003A59A8
			// (set) Token: 0x0600F2B0 RID: 62128 RVA: 0x00072833 File Offset: 0x00070A33
			public unsafe AudioSourceController audioSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass19_0.NativeFieldInfoPtr_audioSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass19_0.NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A434 RID: 42036
			private static readonly IntPtr NativeFieldInfoPtr_audioSource;

			// Token: 0x0400A435 RID: 42037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A436 RID: 42038
			private static readonly IntPtr NativeMethodInfoPtr__Initialise_b__0_Internal_Boolean_AudioSettings_0;
		}

		// Token: 0x02000C8F RID: 3215
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2B1 RID: 62129 RVA: 0x003A77D8 File Offset: 0x003A59D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr, "blend");
				WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr, "curve");
				WeatherEffectController.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr, 100685796);
				WeatherEffectController.__c__DisplayClass23_0.NativeMethodInfoPtr__BlendEffects_b__0_Internal_Void_ParticleEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr, 100685797);
			}

			// Token: 0x0600F2B2 RID: 62130 RVA: 0x003A7868 File Offset: 0x003A5A68
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2B3 RID: 62131 RVA: 0x003A78A4 File Offset: 0x003A5AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293378, XrefRangeEnd = 293379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BlendEffects_b__0(ParticleEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass23_0.NativeMethodInfoPtr__BlendEffects_b__0_Internal_Void_ParticleEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2B4 RID: 62132 RVA: 0x00072852 File Offset: 0x00070A52
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A6 RID: 18854
			// (get) Token: 0x0600F2B5 RID: 62133 RVA: 0x003A78E8 File Offset: 0x003A5AE8
			// (set) Token: 0x0600F2B6 RID: 62134 RVA: 0x0007285B File Offset: 0x00070A5B
			public unsafe WeatherEffectController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEffectController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A7 RID: 18855
			// (get) Token: 0x0600F2B7 RID: 62135 RVA: 0x003A7918 File Offset: 0x003A5B18
			// (set) Token: 0x0600F2B8 RID: 62136 RVA: 0x0007287A File Offset: 0x00070A7A
			public unsafe float blend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_blend);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_blend)) = value;
				}
			}

			// Token: 0x170049A8 RID: 18856
			// (get) Token: 0x0600F2B9 RID: 62137 RVA: 0x003A7940 File Offset: 0x003A5B40
			// (set) Token: 0x0600F2BA RID: 62138 RVA: 0x00072895 File Offset: 0x00070A95
			public unsafe AnimationCurve curve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_curve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass23_0.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A437 RID: 42039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A438 RID: 42040
			private static readonly IntPtr NativeFieldInfoPtr_blend;

			// Token: 0x0400A439 RID: 42041
			private static readonly IntPtr NativeFieldInfoPtr_curve;

			// Token: 0x0400A43A RID: 42042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A43B RID: 42043
			private static readonly IntPtr NativeMethodInfoPtr__BlendEffects_b__0_Internal_Void_ParticleEffectHandler_0;
		}

		// Token: 0x02000C90 RID: 3216
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2BB RID: 62139 RVA: 0x003A7970 File Offset: 0x003A5B70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass24_0.NativeFieldInfoPtr_effectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr, "effectHandler");
				WeatherEffectController.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr, 100685798);
				WeatherEffectController.__c__DisplayClass24_0.NativeMethodInfoPtr__SetEffectParamters_b__0_Internal_Boolean_EffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr, 100685799);
			}

			// Token: 0x0600F2BC RID: 62140 RVA: 0x003A79D8 File Offset: 0x003A5BD8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2BD RID: 62141 RVA: 0x003A7A14 File Offset: 0x003A5C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293379, XrefRangeEnd = 293384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetEffectParamters_b__0(EffectSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass24_0.NativeMethodInfoPtr__SetEffectParamters_b__0_Internal_Boolean_EffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2BE RID: 62142 RVA: 0x000728B4 File Offset: 0x00070AB4
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A9 RID: 18857
			// (get) Token: 0x0600F2BF RID: 62143 RVA: 0x003A7A64 File Offset: 0x003A5C64
			// (set) Token: 0x0600F2C0 RID: 62144 RVA: 0x000728BD File Offset: 0x00070ABD
			public unsafe EffectHandler effectHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass24_0.NativeFieldInfoPtr_effectHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass24_0.NativeFieldInfoPtr_effectHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A43C RID: 42044
			private static readonly IntPtr NativeFieldInfoPtr_effectHandler;

			// Token: 0x0400A43D RID: 42045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A43E RID: 42046
			private static readonly IntPtr NativeMethodInfoPtr__SetEffectParamters_b__0_Internal_Boolean_EffectSettings_0;
		}

		// Token: 0x02000C91 RID: 3217
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F2C1 RID: 62145 RVA: 0x003A7A94 File Offset: 0x003A5C94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass24_1.NativeFieldInfoPtr_toEffectItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr, "toEffectItem");
				WeatherEffectController.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr, 100685800);
				WeatherEffectController.__c__DisplayClass24_1.NativeMethodInfoPtr__SetEffectParamters_b__1_Internal_Boolean_EffectItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr, 100685801);
			}

			// Token: 0x0600F2C2 RID: 62146 RVA: 0x003A7AFC File Offset: 0x003A5CFC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2C3 RID: 62147 RVA: 0x003A7B38 File Offset: 0x003A5D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetEffectParamters_b__1(EffectItem i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass24_1.NativeMethodInfoPtr__SetEffectParamters_b__1_Internal_Boolean_EffectItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2C4 RID: 62148 RVA: 0x000728DC File Offset: 0x00070ADC
			public __c__DisplayClass24_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049AA RID: 18858
			// (get) Token: 0x0600F2C5 RID: 62149 RVA: 0x003A7B88 File Offset: 0x003A5D88
			// (set) Token: 0x0600F2C6 RID: 62150 RVA: 0x000728E5 File Offset: 0x00070AE5
			public unsafe EffectItem toEffectItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass24_1.NativeFieldInfoPtr_toEffectItem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass24_1.NativeFieldInfoPtr_toEffectItem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A43F RID: 42047
			private static readonly IntPtr NativeFieldInfoPtr_toEffectItem;

			// Token: 0x0400A440 RID: 42048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A441 RID: 42049
			private static readonly IntPtr NativeMethodInfoPtr__SetEffectParamters_b__1_Internal_Boolean_EffectItem_0;
		}

		// Token: 0x02000C92 RID: 3218
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2C7 RID: 62151 RVA: 0x003A7BB8 File Offset: 0x003A5DB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_paramater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr, "paramater");
				WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr, "value");
				WeatherEffectController.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr, 100685802);
				WeatherEffectController.__c__DisplayClass25_0.NativeMethodInfoPtr__SetShaderNumericParameter_b__0_Internal_Void_ShaderEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr, 100685803);
			}

			// Token: 0x0600F2C8 RID: 62152 RVA: 0x003A7C34 File Offset: 0x003A5E34
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2C9 RID: 62153 RVA: 0x003A7C70 File Offset: 0x003A5E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293384, XrefRangeEnd = 293385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetShaderNumericParameter_b__0(ShaderEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass25_0.NativeMethodInfoPtr__SetShaderNumericParameter_b__0_Internal_Void_ShaderEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2CA RID: 62154 RVA: 0x00072904 File Offset: 0x00070B04
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049AB RID: 18859
			// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x003A7CB4 File Offset: 0x003A5EB4
			// (set) Token: 0x0600F2CC RID: 62156 RVA: 0x0007290D File Offset: 0x00070B0D
			public unsafe string paramater
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_paramater);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_paramater), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049AC RID: 18860
			// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x003A7CDC File Offset: 0x003A5EDC
			// (set) Token: 0x0600F2CE RID: 62158 RVA: 0x0007292C File Offset: 0x00070B2C
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass25_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400A442 RID: 42050
			private static readonly IntPtr NativeFieldInfoPtr_paramater;

			// Token: 0x0400A443 RID: 42051
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A444 RID: 42052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A445 RID: 42053
			private static readonly IntPtr NativeMethodInfoPtr__SetShaderNumericParameter_b__0_Internal_Void_ShaderEffectHandler_0;
		}

		// Token: 0x02000C93 RID: 3219
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2CF RID: 62159 RVA: 0x003A7D04 File Offset: 0x003A5F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_paramater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr, "paramater");
				WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr, "value");
				WeatherEffectController.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr, 100685804);
				WeatherEffectController.__c__DisplayClass26_0.NativeMethodInfoPtr__SetVisualEffectNumericParameter_b__0_Internal_Void_VFXEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr, 100685805);
			}

			// Token: 0x0600F2D0 RID: 62160 RVA: 0x003A7D80 File Offset: 0x003A5F80
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2D1 RID: 62161 RVA: 0x003A7DBC File Offset: 0x003A5FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetVisualEffectNumericParameter_b__0(VFXEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass26_0.NativeMethodInfoPtr__SetVisualEffectNumericParameter_b__0_Internal_Void_VFXEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2D2 RID: 62162 RVA: 0x00072947 File Offset: 0x00070B47
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049AD RID: 18861
			// (get) Token: 0x0600F2D3 RID: 62163 RVA: 0x003A7E00 File Offset: 0x003A6000
			// (set) Token: 0x0600F2D4 RID: 62164 RVA: 0x00072950 File Offset: 0x00070B50
			public unsafe string paramater
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_paramater);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_paramater), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049AE RID: 18862
			// (get) Token: 0x0600F2D5 RID: 62165 RVA: 0x003A7E28 File Offset: 0x003A6028
			// (set) Token: 0x0600F2D6 RID: 62166 RVA: 0x0007296F File Offset: 0x00070B6F
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass26_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400A446 RID: 42054
			private static readonly IntPtr NativeFieldInfoPtr_paramater;

			// Token: 0x0400A447 RID: 42055
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A448 RID: 42056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A449 RID: 42057
			private static readonly IntPtr NativeMethodInfoPtr__SetVisualEffectNumericParameter_b__0_Internal_Void_VFXEffectHandler_0;
		}

		// Token: 0x02000C94 RID: 3220
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2D7 RID: 62167 RVA: 0x003A7E50 File Offset: 0x003A6050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_paramater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr, "paramater");
				WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr, "value");
				WeatherEffectController.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr, 100685806);
				WeatherEffectController.__c__DisplayClass27_0.NativeMethodInfoPtr__SetShaderColorParameter_b__0_Internal_Void_ShaderEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr, 100685807);
			}

			// Token: 0x0600F2D8 RID: 62168 RVA: 0x003A7ECC File Offset: 0x003A60CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2D9 RID: 62169 RVA: 0x003A7F08 File Offset: 0x003A6108
			[CallerCount(0)]
			public unsafe void _SetShaderColorParameter_b__0(ShaderEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass27_0.NativeMethodInfoPtr__SetShaderColorParameter_b__0_Internal_Void_ShaderEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2DA RID: 62170 RVA: 0x0007298A File Offset: 0x00070B8A
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049AF RID: 18863
			// (get) Token: 0x0600F2DB RID: 62171 RVA: 0x003A7F4C File Offset: 0x003A614C
			// (set) Token: 0x0600F2DC RID: 62172 RVA: 0x00072993 File Offset: 0x00070B93
			public unsafe string paramater
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_paramater);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_paramater), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049B0 RID: 18864
			// (get) Token: 0x0600F2DD RID: 62173 RVA: 0x003A7F74 File Offset: 0x003A6174
			// (set) Token: 0x0600F2DE RID: 62174 RVA: 0x000729B2 File Offset: 0x00070BB2
			public unsafe Color value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass27_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400A44A RID: 42058
			private static readonly IntPtr NativeFieldInfoPtr_paramater;

			// Token: 0x0400A44B RID: 42059
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A44C RID: 42060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A44D RID: 42061
			private static readonly IntPtr NativeMethodInfoPtr__SetShaderColorParameter_b__0_Internal_Void_ShaderEffectHandler_0;
		}

		// Token: 0x02000C95 RID: 3221
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2DF RID: 62175 RVA: 0x003A7F9C File Offset: 0x003A619C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_paramater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr, "paramater");
				WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr, "value");
				WeatherEffectController.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr, 100685808);
				WeatherEffectController.__c__DisplayClass28_0.NativeMethodInfoPtr__SetVisualEffectColorParameter_b__0_Internal_Void_VFXEffectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr, 100685809);
			}

			// Token: 0x0600F2E0 RID: 62176 RVA: 0x003A8018 File Offset: 0x003A6218
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2E1 RID: 62177 RVA: 0x003A8054 File Offset: 0x003A6254
			[CallerCount(0)]
			public unsafe void _SetVisualEffectColorParameter_b__0(VFXEffectHandler e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass28_0.NativeMethodInfoPtr__SetVisualEffectColorParameter_b__0_Internal_Void_VFXEffectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2E2 RID: 62178 RVA: 0x000729CD File Offset: 0x00070BCD
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B1 RID: 18865
			// (get) Token: 0x0600F2E3 RID: 62179 RVA: 0x003A8098 File Offset: 0x003A6298
			// (set) Token: 0x0600F2E4 RID: 62180 RVA: 0x000729D6 File Offset: 0x00070BD6
			public unsafe string paramater
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_paramater);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_paramater), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049B2 RID: 18866
			// (get) Token: 0x0600F2E5 RID: 62181 RVA: 0x003A80C0 File Offset: 0x003A62C0
			// (set) Token: 0x0600F2E6 RID: 62182 RVA: 0x000729F5 File Offset: 0x00070BF5
			public unsafe Color value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass28_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400A44E RID: 42062
			private static readonly IntPtr NativeFieldInfoPtr_paramater;

			// Token: 0x0400A44F RID: 42063
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A450 RID: 42064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A451 RID: 42065
			private static readonly IntPtr NativeMethodInfoPtr__SetVisualEffectColorParameter_b__0_Internal_Void_VFXEffectHandler_0;
		}

		// Token: 0x02000C96 RID: 3222
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2E7 RID: 62183 RVA: 0x003A80E8 File Offset: 0x003A62E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass29_0.NativeFieldInfoPtr_handlerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr, "handlerId");
				WeatherEffectController.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr, 100685810);
				WeatherEffectController.__c__DisplayClass29_0.NativeMethodInfoPtr__FindEffectSettings_b__0_Internal_Boolean_EffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr, 100685811);
			}

			// Token: 0x0600F2E8 RID: 62184 RVA: 0x003A8150 File Offset: 0x003A6350
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2E9 RID: 62185 RVA: 0x003A818C File Offset: 0x003A638C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293385, XrefRangeEnd = 293390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindEffectSettings_b__0(EffectSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass29_0.NativeMethodInfoPtr__FindEffectSettings_b__0_Internal_Boolean_EffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2EA RID: 62186 RVA: 0x00072A10 File Offset: 0x00070C10
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B3 RID: 18867
			// (get) Token: 0x0600F2EB RID: 62187 RVA: 0x003A81DC File Offset: 0x003A63DC
			// (set) Token: 0x0600F2EC RID: 62188 RVA: 0x00072A19 File Offset: 0x00070C19
			public unsafe string handlerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass29_0.NativeFieldInfoPtr_handlerId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass29_0.NativeFieldInfoPtr_handlerId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A452 RID: 42066
			private static readonly IntPtr NativeFieldInfoPtr_handlerId;

			// Token: 0x0400A453 RID: 42067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A454 RID: 42068
			private static readonly IntPtr NativeMethodInfoPtr__FindEffectSettings_b__0_Internal_Boolean_EffectSettings_0;
		}

		// Token: 0x02000C97 RID: 3223
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2ED RID: 62189 RVA: 0x003A8204 File Offset: 0x003A6404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr_handlerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr, "handlerId");
				WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr, 100685812);
				WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__GetFromEffectSettings_b__0_Internal_Boolean_EffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr, 100685813);
				WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__GetFromEffectSettings_b__1_Internal_Boolean_WeatherEffectController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr, 100685814);
			}

			// Token: 0x0600F2EE RID: 62190 RVA: 0x003A8294 File Offset: 0x003A6494
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2EF RID: 62191 RVA: 0x003A82D0 File Offset: 0x003A64D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293390, XrefRangeEnd = 293395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFromEffectSettings_b__0(EffectSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__GetFromEffectSettings_b__0_Internal_Boolean_EffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2F0 RID: 62192 RVA: 0x003A8320 File Offset: 0x003A6520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293395, XrefRangeEnd = 293397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFromEffectSettings_b__1(WeatherEffectController e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass30_0.NativeMethodInfoPtr__GetFromEffectSettings_b__1_Internal_Boolean_WeatherEffectController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2F1 RID: 62193 RVA: 0x00072A38 File Offset: 0x00070C38
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B4 RID: 18868
			// (get) Token: 0x0600F2F2 RID: 62194 RVA: 0x003A8370 File Offset: 0x003A6570
			// (set) Token: 0x0600F2F3 RID: 62195 RVA: 0x00072A41 File Offset: 0x00070C41
			public unsafe string handlerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr_handlerId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr_handlerId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049B5 RID: 18869
			// (get) Token: 0x0600F2F4 RID: 62196 RVA: 0x003A8398 File Offset: 0x003A6598
			// (set) Token: 0x0600F2F5 RID: 62197 RVA: 0x00072A60 File Offset: 0x00070C60
			public unsafe WeatherEffectController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEffectController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A455 RID: 42069
			private static readonly IntPtr NativeFieldInfoPtr_handlerId;

			// Token: 0x0400A456 RID: 42070
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A457 RID: 42071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A458 RID: 42072
			private static readonly IntPtr NativeMethodInfoPtr__GetFromEffectSettings_b__0_Internal_Boolean_EffectSettings_0;

			// Token: 0x0400A459 RID: 42073
			private static readonly IntPtr NativeMethodInfoPtr__GetFromEffectSettings_b__1_Internal_Boolean_WeatherEffectController_0;
		}

		// Token: 0x02000C98 RID: 3224
		[ObfuscatedName("ScheduleOne.Weather.WeatherEffectController+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2F6 RID: 62198 RVA: 0x003A83C8 File Offset: 0x003A65C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherEffectController>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr);
				WeatherEffectController.__c__DisplayClass32_0.NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr, "audioSource");
				WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr, 100685815);
				WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr, 100685816);
				WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr, 100685817);
			}

			// Token: 0x0600F2F7 RID: 62199 RVA: 0x003A8444 File Offset: 0x003A6644
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEffectController.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2F8 RID: 62200 RVA: 0x003A8480 File Offset: 0x003A6680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293397, XrefRangeEnd = 293402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAudio_b__0(Il2CppScheduleOne.Core.Audio.AudioSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2F9 RID: 62201 RVA: 0x003A84D0 File Offset: 0x003A66D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293402, XrefRangeEnd = 293407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAudio_b__1(Il2CppScheduleOne.Core.Audio.AudioSettings s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEffectController.__c__DisplayClass32_0.NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2FA RID: 62202 RVA: 0x00072A7F File Offset: 0x00070C7F
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B6 RID: 18870
			// (get) Token: 0x0600F2FB RID: 62203 RVA: 0x003A8520 File Offset: 0x003A6720
			// (set) Token: 0x0600F2FC RID: 62204 RVA: 0x00072A88 File Offset: 0x00070C88
			public unsafe AudioSourceController audioSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass32_0.NativeFieldInfoPtr_audioSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEffectController.__c__DisplayClass32_0.NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A45A RID: 42074
			private static readonly IntPtr NativeFieldInfoPtr_audioSource;

			// Token: 0x0400A45B RID: 42075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A45C RID: 42076
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAudio_b__0_Internal_Boolean_AudioSettings_0;

			// Token: 0x0400A45D RID: 42077
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAudio_b__1_Internal_Boolean_AudioSettings_0;
		}
	}
}
