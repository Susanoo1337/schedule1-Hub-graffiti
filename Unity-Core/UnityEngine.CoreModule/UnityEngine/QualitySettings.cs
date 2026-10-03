using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A2 RID: 162
	public sealed class QualitySettings : Object
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00036404 File Offset: 0x00034604
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySettings()
		{
			Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "QualitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
			QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, "activeQualityLevelChanged");
			QualitySettings.NativeMethodInfoPtr_add_activeQualityLevelChanged_Public_Static_add_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664283);
			QualitySettings.NativeMethodInfoPtr_remove_activeQualityLevelChanged_Public_Static_rem_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664284);
			QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664285);
			QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664286);
			QualitySettings.NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664287);
			QualitySettings.NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664288);
			QualitySettings.NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664289);
			QualitySettings.NativeMethodInfoPtr_set_maximumLODLevel_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664290);
			QualitySettings.NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664291);
			QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664292);
			QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664293);
			QualitySettings.NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664294);
			QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664295);
			QualitySettings.NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664296);
			QualitySettings.NativeMethodInfoPtr_get_INTERNAL_renderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664297);
			QualitySettings.NativeMethodInfoPtr_get_renderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664298);
			QualitySettings.NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664299);
			QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664300);
			QualitySettings.NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664301);
			QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664302);
			QualitySettings.get_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.get_pixelLightCountDelegate>("UnityEngine.QualitySettings::get_pixelLightCount");
			QualitySettings.set_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.set_pixelLightCountDelegate>("UnityEngine.QualitySettings::set_pixelLightCount");
			QualitySettings.get_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
			QualitySettings.set_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
			QualitySettings.get_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
			QualitySettings.set_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
			QualitySettings.get_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
			QualitySettings.set_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
			QualitySettings.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
			QualitySettings.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
			QualitySettings.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
			QualitySettings.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
			QualitySettings.set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
			QualitySettings.get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
			QualitySettings.set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
			QualitySettings.get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
			QualitySettings.set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
			QualitySettings.set_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
			QualitySettings.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
			QualitySettings.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
			QualitySettings.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
			QualitySettings.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
			QualitySettings.get_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::get_globalTextureMipmapLimit");
			QualitySettings.set_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::set_globalTextureMipmapLimit");
			QualitySettings.get_enableLODCrossFadeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_enableLODCrossFadeDelegate>("UnityEngine.QualitySettings::get_enableLODCrossFade");
			QualitySettings.get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
			QualitySettings.set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
			QualitySettings.get_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
			QualitySettings.set_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
			QualitySettings.get_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
			QualitySettings.set_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
			QualitySettings.get_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::get_realtimeGICPUUsage");
			QualitySettings.set_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::set_realtimeGICPUUsage");
			QualitySettings.get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
			QualitySettings.set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
			QualitySettings.get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
			QualitySettings.set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
			QualitySettings.get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
			QualitySettings.set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
			QualitySettings.SetLODSettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.SetLODSettingsDelegate>("UnityEngine.QualitySettings::SetLODSettings");
			QualitySettings.get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
			QualitySettings.set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
			QualitySettings.set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
			QualitySettings.get_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::get_useLegacyDetailDistribution");
			QualitySettings.set_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::set_useLegacyDetailDistribution");
			QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
			QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
			QualitySettings.get_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::get_terrainQualityOverrides");
			QualitySettings.set_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::set_terrainQualityOverrides");
			QualitySettings.get_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::get_terrainPixelError");
			QualitySettings.set_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::set_terrainPixelError");
			QualitySettings.get_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::get_terrainDetailDensityScale");
			QualitySettings.set_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::set_terrainDetailDensityScale");
			QualitySettings.get_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::get_terrainBasemapDistance");
			QualitySettings.set_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::set_terrainBasemapDistance");
			QualitySettings.get_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::get_terrainDetailDistance");
			QualitySettings.set_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::set_terrainDetailDistance");
			QualitySettings.get_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::get_terrainTreeDistance");
			QualitySettings.set_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::set_terrainTreeDistance");
			QualitySettings.get_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::get_terrainBillboardStart");
			QualitySettings.set_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::set_terrainBillboardStart");
			QualitySettings.get_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::get_terrainFadeLength");
			QualitySettings.set_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::set_terrainFadeLength");
			QualitySettings.get_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::get_terrainMaxTrees");
			QualitySettings.set_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::set_terrainMaxTrees");
			QualitySettings.set_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.set_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline");
			QualitySettings.InternalGetRenderPipelineAssetAtDelegateField = IL2CPP.ResolveICall<QualitySettings.InternalGetRenderPipelineAssetAtDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt");
			QualitySettings.get_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
			QualitySettings.set_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
			QualitySettings.get_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
			QualitySettings.set_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
			QualitySettings.get_countDelegateField = IL2CPP.ResolveICall<QualitySettings.get_countDelegate>("UnityEngine.QualitySettings::get_count");
			QualitySettings.get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
			QualitySettings.set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
			QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
			QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
			QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
			QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
			QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
			QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
			QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
			QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
			QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
			QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
			QualitySettings.get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
			QualitySettings.set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
			QualitySettings.GetQualitySettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualitySettingsDelegate>("UnityEngine.QualitySettings::GetQualitySettings");
			QualitySettings.get_desiredColorSpaceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_desiredColorSpaceDelegate>("UnityEngine.QualitySettings::get_desiredColorSpace");
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00036B20 File Offset: 0x00034D20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234523, RefRangeEnd = 1234525, XrefRangeStart = 1234515, XrefRangeEnd = 1234523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_activeQualityLevelChanged(Action<int, int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_add_activeQualityLevelChanged_Public_Static_add_Void_Action_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00036B58 File Offset: 0x00034D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234533, RefRangeEnd = 1234534, XrefRangeStart = 1234525, XrefRangeEnd = 1234533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_activeQualityLevelChanged(Action<int, int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_remove_activeQualityLevelChanged_Public_Static_rem_Void_Action_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00036B90 File Offset: 0x00034D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234534, XrefRangeEnd = 1234536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousQualityLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentQualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00036BD0 File Offset: 0x00034DD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234538, RefRangeEnd = 1234543, XrefRangeStart = 1234536, XrefRangeEnd = 1234538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetQualityLevel(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00036C04 File Offset: 0x00034E04
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00006559 File Offset: 0x00004759
		public unsafe static ShadowmaskMode shadowmaskMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234545, RefRangeEnd = 1234547, XrefRangeStart = 1234543, XrefRangeEnd = 1234545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_shadowmaskModeDelegateField(value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00036C34 File Offset: 0x00034E34
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x000065A1 File Offset: 0x000047A1
		public unsafe static float lodBias
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1234549, RefRangeEnd = 1234557, XrefRangeStart = 1234547, XrefRangeEnd = 1234549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_lodBiasDelegateField(value);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00036C64 File Offset: 0x00034E64
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00036C94 File Offset: 0x00034E94
		public unsafe static int maximumLODLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234557, XrefRangeEnd = 1234559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234559, XrefRangeEnd = 1234561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_maximumLODLevel_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000065F9 File Offset: 0x000047F9
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00036CC8 File Offset: 0x00034EC8
		public unsafe static bool enableLODCrossFade
		{
			get
			{
				return QualitySettings.get_enableLODCrossFadeDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234563, RefRangeEnd = 1234564, XrefRangeStart = 1234561, XrefRangeEnd = 1234563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00036CFC File Offset: 0x00034EFC
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00036D2C File Offset: 0x00034F2C
		public unsafe static int vSyncCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234566, RefRangeEnd = 1234567, XrefRangeStart = 1234564, XrefRangeEnd = 1234566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234569, RefRangeEnd = 1234570, XrefRangeStart = 1234567, XrefRangeEnd = 1234569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00036D60 File Offset: 0x00034F60
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00036D90 File Offset: 0x00034F90
		public unsafe static int antiAliasing
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1234572, RefRangeEnd = 1234577, XrefRangeStart = 1234570, XrefRangeEnd = 1234572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234579, RefRangeEnd = 1234580, XrefRangeStart = 1234577, XrefRangeEnd = 1234579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00036DC4 File Offset: 0x00034FC4
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000066DC File Offset: 0x000048DC
		public unsafe static bool billboardsFaceCameraPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234582, RefRangeEnd = 1234583, XrefRangeStart = 1234580, XrefRangeEnd = 1234582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_billboardsFaceCameraPositionDelegateField(value);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00036DF4 File Offset: 0x00034FF4
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x000067FC File Offset: 0x000049FC
		public unsafe static ScriptableObject INTERNAL_renderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234583, XrefRangeEnd = 1234585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_INTERNAL_renderPipeline_Private_Static_get_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			set
			{
				QualitySettings.set_INTERNAL_renderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00036E28 File Offset: 0x00035028
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0000680E File Offset: 0x00004A0E
		public unsafe static UnityEngine.Rendering.RenderPipelineAsset renderPipeline
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234589, RefRangeEnd = 1234592, XrefRangeStart = 1234585, XrefRangeEnd = 1234589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_renderPipeline_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Rendering.RenderPipelineAsset>(intPtr3) : null;
			}
			set
			{
				QualitySettings.INTERNAL_renderPipeline = value;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00036E5C File Offset: 0x0003505C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234594, RefRangeEnd = 1234596, XrefRangeStart = 1234592, XrefRangeEnd = 1234594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetQualityLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00036E8C File Offset: 0x0003508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234596, XrefRangeEnd = 1234598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetQualityLevel(int index, bool applyExpensiveChanges)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyExpensiveChanges;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00036ECC File Offset: 0x000350CC
		public unsafe static Il2CppStringArray names
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234600, RefRangeEnd = 1234601, XrefRangeStart = 1234598, XrefRangeEnd = 1234600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00036F00 File Offset: 0x00035100
		public unsafe static ColorSpace activeColorSpace
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1234603, RefRangeEnd = 1234625, XrefRangeStart = 1234601, XrefRangeEnd = 1234603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000645A File Offset: 0x0000465A
		public QualitySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00036F30 File Offset: 0x00035130
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00006463 File Offset: 0x00004663
		public unsafe static Action<int, int> activeQualityLevelChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QualitySettings.NativeFieldInfoPtr_activeQualityLevelChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00006475 File Offset: 0x00004675
		public static void IncreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00006486 File Offset: 0x00004686
		public static void DecreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00006497 File Offset: 0x00004697
		public static void IncreaseLevel()
		{
			QualitySettings.IncreaseLevel(false);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000064A1 File Offset: 0x000046A1
		public static void DecreaseLevel()
		{
			QualitySettings.DecreaseLevel(false);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00036F58 File Offset: 0x00035158
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x000064AB File Offset: 0x000046AB
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00036F70 File Offset: 0x00035170
		public static void ForEach(Action callback)
		{
			bool flag = callback == null;
			if (!flag)
			{
				int qualityLevel = QualitySettings.GetQualityLevel();
				try
				{
					for (int i = 0; i < QualitySettings.count; i++)
					{
						QualitySettings.SetQualityLevel(i, false);
						callback.Invoke();
					}
				}
				finally
				{
					QualitySettings.SetQualityLevel(qualityLevel, false);
				}
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000064B6 File Offset: 0x000046B6
		public static void ForEach(Action<int, string> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000064C3 File Offset: 0x000046C3
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000064CF File Offset: 0x000046CF
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.get_pixelLightCountDelegateField();
			}
			set
			{
				QualitySettings.set_pixelLightCountDelegateField(value);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000064E8 File Offset: 0x000046E8
		public static ShadowQuality shadows
		{
			get
			{
				return QualitySettings.get_shadowsDelegateField();
			}
			set
			{
				QualitySettings.set_shadowsDelegateField(value);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000064F5 File Offset: 0x000046F5
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00006501 File Offset: 0x00004701
		public static ShadowProjection shadowProjection
		{
			get
			{
				return QualitySettings.get_shadowProjectionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowProjectionDelegateField(value);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0000650E File Offset: 0x0000470E
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0000651A File Offset: 0x0000471A
		public static int shadowCascades
		{
			get
			{
				return QualitySettings.get_shadowCascadesDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascadesDelegateField(value);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00006527 File Offset: 0x00004727
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00006533 File Offset: 0x00004733
		public static float shadowDistance
		{
			get
			{
				return QualitySettings.get_shadowDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_shadowDistanceDelegateField(value);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0000654C File Offset: 0x0000474C
		public static ShadowResolution shadowResolution
		{
			get
			{
				return QualitySettings.get_shadowResolutionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowResolutionDelegateField(value);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00006566 File Offset: 0x00004766
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00006572 File Offset: 0x00004772
		public static float shadowNearPlaneOffset
		{
			get
			{
				return QualitySettings.get_shadowNearPlaneOffsetDelegateField();
			}
			set
			{
				QualitySettings.set_shadowNearPlaneOffsetDelegateField(value);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0000657F File Offset: 0x0000477F
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0000658B File Offset: 0x0000478B
		public static float shadowCascade2Split
		{
			get
			{
				return QualitySettings.get_shadowCascade2SplitDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascade2SplitDelegateField(value);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00036FD4 File Offset: 0x000351D4
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00006598 File Offset: 0x00004798
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 result;
				QualitySettings.get_shadowCascade4Split_Injected(out result);
				return result;
			}
			set
			{
				QualitySettings.set_shadowCascade4Split_Injected(ref value);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000065AE File Offset: 0x000047AE
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x000065BA File Offset: 0x000047BA
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return QualitySettings.get_anisotropicFilteringDelegateField();
			}
			set
			{
				QualitySettings.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000065C7 File Offset: 0x000047C7
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000065D3 File Offset: 0x000047D3
		public static int masterTextureLimit
		{
			get
			{
				return QualitySettings.get_masterTextureLimitDelegateField();
			}
			set
			{
				QualitySettings.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000065EC File Offset: 0x000047EC
		public static int globalTextureMipmapLimit
		{
			get
			{
				return QualitySettings.get_globalTextureMipmapLimitDelegateField();
			}
			set
			{
				QualitySettings.set_globalTextureMipmapLimitDelegateField(value);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00006605 File Offset: 0x00004805
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00006611 File Offset: 0x00004811
		public static int particleRaycastBudget
		{
			get
			{
				return QualitySettings.get_particleRaycastBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_particleRaycastBudgetDelegateField(value);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0000661E File Offset: 0x0000481E
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0000662A File Offset: 0x0000482A
		public static bool softParticles
		{
			get
			{
				return QualitySettings.get_softParticlesDelegateField();
			}
			set
			{
				QualitySettings.set_softParticlesDelegateField(value);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00006637 File Offset: 0x00004837
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00006643 File Offset: 0x00004843
		public static bool softVegetation
		{
			get
			{
				return QualitySettings.get_softVegetationDelegateField();
			}
			set
			{
				QualitySettings.set_softVegetationDelegateField(value);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0000665C File Offset: 0x0000485C
		public static int realtimeGICPUUsage
		{
			get
			{
				return QualitySettings.get_realtimeGICPUUsageDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeGICPUUsageDelegateField(value);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00006669 File Offset: 0x00004869
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006675 File Offset: 0x00004875
		public static int asyncUploadTimeSlice
		{
			get
			{
				return QualitySettings.get_asyncUploadTimeSliceDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadTimeSliceDelegateField(value);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00006682 File Offset: 0x00004882
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0000668E File Offset: 0x0000488E
		public static int asyncUploadBufferSize
		{
			get
			{
				return QualitySettings.get_asyncUploadBufferSizeDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadBufferSizeDelegateField(value);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0000669B File Offset: 0x0000489B
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000066A7 File Offset: 0x000048A7
		public static bool asyncUploadPersistentBuffer
		{
			get
			{
				return QualitySettings.get_asyncUploadPersistentBufferDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadPersistentBufferDelegateField(value);
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000066B4 File Offset: 0x000048B4
		public static void SetLODSettings(float lodBias, int maximumLODLevel, [Optional] bool setDirty)
		{
			QualitySettings.SetLODSettingsDelegateField(lodBias, maximumLODLevel, setDirty);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000066C3 File Offset: 0x000048C3
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x000066CF File Offset: 0x000048CF
		public static bool realtimeReflectionProbes
		{
			get
			{
				return QualitySettings.get_realtimeReflectionProbesDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeReflectionProbesDelegateField(value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000066E9 File Offset: 0x000048E9
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000066F5 File Offset: 0x000048F5
		public static bool useLegacyDetailDistribution
		{
			get
			{
				return QualitySettings.get_useLegacyDetailDistributionDelegateField();
			}
			set
			{
				QualitySettings.set_useLegacyDetailDistributionDelegateField(value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00006702 File Offset: 0x00004902
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x0000670E File Offset: 0x0000490E
		public static float resolutionScalingFixedDPIFactor
		{
			get
			{
				return QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField();
			}
			set
			{
				QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField(value);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0000671B File Offset: 0x0000491B
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00006727 File Offset: 0x00004927
		public static TerrainQualityOverrides terrainQualityOverrides
		{
			get
			{
				return QualitySettings.get_terrainQualityOverridesDelegateField();
			}
			set
			{
				QualitySettings.set_terrainQualityOverridesDelegateField(value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00006734 File Offset: 0x00004934
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00006740 File Offset: 0x00004940
		public static float terrainPixelError
		{
			get
			{
				return QualitySettings.get_terrainPixelErrorDelegateField();
			}
			set
			{
				QualitySettings.set_terrainPixelErrorDelegateField(value);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0000674D File Offset: 0x0000494D
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00006759 File Offset: 0x00004959
		public static float terrainDetailDensityScale
		{
			get
			{
				return QualitySettings.get_terrainDetailDensityScaleDelegateField();
			}
			set
			{
				QualitySettings.set_terrainDetailDensityScaleDelegateField(value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00006766 File Offset: 0x00004966
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00006772 File Offset: 0x00004972
		public static float terrainBasemapDistance
		{
			get
			{
				return QualitySettings.get_terrainBasemapDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainBasemapDistanceDelegateField(value);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0000677F File Offset: 0x0000497F
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0000678B File Offset: 0x0000498B
		public static float terrainDetailDistance
		{
			get
			{
				return QualitySettings.get_terrainDetailDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainDetailDistanceDelegateField(value);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x000067A4 File Offset: 0x000049A4
		public static float terrainTreeDistance
		{
			get
			{
				return QualitySettings.get_terrainTreeDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_terrainTreeDistanceDelegateField(value);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000067B1 File Offset: 0x000049B1
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x000067BD File Offset: 0x000049BD
		public static float terrainBillboardStart
		{
			get
			{
				return QualitySettings.get_terrainBillboardStartDelegateField();
			}
			set
			{
				QualitySettings.set_terrainBillboardStartDelegateField(value);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000067CA File Offset: 0x000049CA
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000067D6 File Offset: 0x000049D6
		public static float terrainFadeLength
		{
			get
			{
				return QualitySettings.get_terrainFadeLengthDelegateField();
			}
			set
			{
				QualitySettings.set_terrainFadeLengthDelegateField(value);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000067E3 File Offset: 0x000049E3
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000067EF File Offset: 0x000049EF
		public static float terrainMaxTrees
		{
			get
			{
				return QualitySettings.get_terrainMaxTreesDelegateField();
			}
			set
			{
				QualitySettings.set_terrainMaxTreesDelegateField(value);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00036FEC File Offset: 0x000351EC
		public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
		{
			IntPtr intPtr = QualitySettings.InternalGetRenderPipelineAssetAtDelegateField(index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00037014 File Offset: 0x00035214
		public static UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(int index)
		{
			bool flag = index < 0 || index >= QualitySettings.names.Length;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("{0} is out of range [0..{1}[", "index", QualitySettings.names.Length));
			}
			return QualitySettings.InternalGetRenderPipelineAssetAt(index).TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00006818 File Offset: 0x00004A18
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00006824 File Offset: 0x00004A24
		public static BlendWeights blendWeights
		{
			get
			{
				return QualitySettings.get_blendWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_blendWeightsDelegateField(value);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00006831 File Offset: 0x00004A31
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0000683D File Offset: 0x00004A3D
		public static SkinWeights skinWeights
		{
			get
			{
				return QualitySettings.get_skinWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_skinWeightsDelegateField(value);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0000684A File Offset: 0x00004A4A
		public static int count
		{
			get
			{
				return QualitySettings.get_countDelegateField();
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00006856 File Offset: 0x00004A56
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00006862 File Offset: 0x00004A62
		public static bool streamingMipmapsActive
		{
			get
			{
				return QualitySettings.get_streamingMipmapsActiveDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsActiveDelegateField(value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0000686F File Offset: 0x00004A6F
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0000687B File Offset: 0x00004A7B
		public static float streamingMipmapsMemoryBudget
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField(value);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00006888 File Offset: 0x00004A88
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00006894 File Offset: 0x00004A94
		public static int streamingMipmapsRenderersPerFrame
		{
			get
			{
				return QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField(value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000068A1 File Offset: 0x00004AA1
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000068AD File Offset: 0x00004AAD
		public static int streamingMipmapsMaxLevelReduction
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField(value);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x000068BA File Offset: 0x00004ABA
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000068C6 File Offset: 0x00004AC6
		public static bool streamingMipmapsAddAllCameras
		{
			get
			{
				return QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField(value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000068D3 File Offset: 0x00004AD3
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000068DF File Offset: 0x00004ADF
		public static int streamingMipmapsMaxFileIORequests
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField(value);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000068F8 File Offset: 0x00004AF8
		public static int maxQueuedFrames
		{
			get
			{
				return QualitySettings.get_maxQueuedFramesDelegateField();
			}
			set
			{
				QualitySettings.set_maxQueuedFramesDelegateField(value);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00037074 File Offset: 0x00035274
		public static Object GetQualitySettings()
		{
			IntPtr intPtr = QualitySettings.GetQualitySettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00006905 File Offset: 0x00004B05
		public static ColorSpace desiredColorSpace
		{
			get
			{
				return QualitySettings.get_desiredColorSpaceDelegateField();
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00006911 File Offset: 0x00004B11
		public static void get_shadowCascade4Split_Injected(out Vector3 ret)
		{
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField(out ret);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000691E File Offset: 0x00004B1E
		public static void set_shadowCascade4Split_Injected(ref Vector3 value)
		{
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField(ref value);
		}

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_activeQualityLevelChanged;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_add_activeQualityLevelChanged_Public_Static_add_Void_Action_2_Int32_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_remove_activeQualityLevelChanged_Public_Static_rem_Void_Action_2_Int32_Int32_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumLODLevel_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_get_INTERNAL_renderPipeline_Private_Static_get_ScriptableObject_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipeline_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly QualitySettings.get_pixelLightCountDelegate get_pixelLightCountDelegateField;

		// Token: 0x040007B1 RID: 1969
		private static readonly QualitySettings.set_pixelLightCountDelegate set_pixelLightCountDelegateField;

		// Token: 0x040007B2 RID: 1970
		private static readonly QualitySettings.get_shadowsDelegate get_shadowsDelegateField;

		// Token: 0x040007B3 RID: 1971
		private static readonly QualitySettings.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x040007B4 RID: 1972
		private static readonly QualitySettings.get_shadowProjectionDelegate get_shadowProjectionDelegateField;

		// Token: 0x040007B5 RID: 1973
		private static readonly QualitySettings.set_shadowProjectionDelegate set_shadowProjectionDelegateField;

		// Token: 0x040007B6 RID: 1974
		private static readonly QualitySettings.get_shadowCascadesDelegate get_shadowCascadesDelegateField;

		// Token: 0x040007B7 RID: 1975
		private static readonly QualitySettings.set_shadowCascadesDelegate set_shadowCascadesDelegateField;

		// Token: 0x040007B8 RID: 1976
		private static readonly QualitySettings.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x040007B9 RID: 1977
		private static readonly QualitySettings.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x040007BA RID: 1978
		private static readonly QualitySettings.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x040007BB RID: 1979
		private static readonly QualitySettings.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x040007BC RID: 1980
		private static readonly QualitySettings.set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;

		// Token: 0x040007BD RID: 1981
		private static readonly QualitySettings.get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040007BE RID: 1982
		private static readonly QualitySettings.set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040007BF RID: 1983
		private static readonly QualitySettings.get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;

		// Token: 0x040007C0 RID: 1984
		private static readonly QualitySettings.set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;

		// Token: 0x040007C1 RID: 1985
		private static readonly QualitySettings.set_lodBiasDelegate set_lodBiasDelegateField;

		// Token: 0x040007C2 RID: 1986
		private static readonly QualitySettings.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x040007C3 RID: 1987
		private static readonly QualitySettings.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x040007C4 RID: 1988
		private static readonly QualitySettings.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x040007C5 RID: 1989
		private static readonly QualitySettings.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x040007C6 RID: 1990
		private static readonly QualitySettings.get_globalTextureMipmapLimitDelegate get_globalTextureMipmapLimitDelegateField;

		// Token: 0x040007C7 RID: 1991
		private static readonly QualitySettings.set_globalTextureMipmapLimitDelegate set_globalTextureMipmapLimitDelegateField;

		// Token: 0x040007C8 RID: 1992
		private static readonly QualitySettings.get_enableLODCrossFadeDelegate get_enableLODCrossFadeDelegateField;

		// Token: 0x040007C9 RID: 1993
		private static readonly QualitySettings.get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;

		// Token: 0x040007CA RID: 1994
		private static readonly QualitySettings.set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;

		// Token: 0x040007CB RID: 1995
		private static readonly QualitySettings.get_softParticlesDelegate get_softParticlesDelegateField;

		// Token: 0x040007CC RID: 1996
		private static readonly QualitySettings.set_softParticlesDelegate set_softParticlesDelegateField;

		// Token: 0x040007CD RID: 1997
		private static readonly QualitySettings.get_softVegetationDelegate get_softVegetationDelegateField;

		// Token: 0x040007CE RID: 1998
		private static readonly QualitySettings.set_softVegetationDelegate set_softVegetationDelegateField;

		// Token: 0x040007CF RID: 1999
		private static readonly QualitySettings.get_realtimeGICPUUsageDelegate get_realtimeGICPUUsageDelegateField;

		// Token: 0x040007D0 RID: 2000
		private static readonly QualitySettings.set_realtimeGICPUUsageDelegate set_realtimeGICPUUsageDelegateField;

		// Token: 0x040007D1 RID: 2001
		private static readonly QualitySettings.get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;

		// Token: 0x040007D2 RID: 2002
		private static readonly QualitySettings.set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;

		// Token: 0x040007D3 RID: 2003
		private static readonly QualitySettings.get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;

		// Token: 0x040007D4 RID: 2004
		private static readonly QualitySettings.set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;

		// Token: 0x040007D5 RID: 2005
		private static readonly QualitySettings.get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;

		// Token: 0x040007D6 RID: 2006
		private static readonly QualitySettings.set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;

		// Token: 0x040007D7 RID: 2007
		private static readonly QualitySettings.SetLODSettingsDelegate SetLODSettingsDelegateField;

		// Token: 0x040007D8 RID: 2008
		private static readonly QualitySettings.get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;

		// Token: 0x040007D9 RID: 2009
		private static readonly QualitySettings.set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;

		// Token: 0x040007DA RID: 2010
		private static readonly QualitySettings.set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;

		// Token: 0x040007DB RID: 2011
		private static readonly QualitySettings.get_useLegacyDetailDistributionDelegate get_useLegacyDetailDistributionDelegateField;

		// Token: 0x040007DC RID: 2012
		private static readonly QualitySettings.set_useLegacyDetailDistributionDelegate set_useLegacyDetailDistributionDelegateField;

		// Token: 0x040007DD RID: 2013
		private static readonly QualitySettings.get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x040007DE RID: 2014
		private static readonly QualitySettings.set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x040007DF RID: 2015
		private static readonly QualitySettings.get_terrainQualityOverridesDelegate get_terrainQualityOverridesDelegateField;

		// Token: 0x040007E0 RID: 2016
		private static readonly QualitySettings.set_terrainQualityOverridesDelegate set_terrainQualityOverridesDelegateField;

		// Token: 0x040007E1 RID: 2017
		private static readonly QualitySettings.get_terrainPixelErrorDelegate get_terrainPixelErrorDelegateField;

		// Token: 0x040007E2 RID: 2018
		private static readonly QualitySettings.set_terrainPixelErrorDelegate set_terrainPixelErrorDelegateField;

		// Token: 0x040007E3 RID: 2019
		private static readonly QualitySettings.get_terrainDetailDensityScaleDelegate get_terrainDetailDensityScaleDelegateField;

		// Token: 0x040007E4 RID: 2020
		private static readonly QualitySettings.set_terrainDetailDensityScaleDelegate set_terrainDetailDensityScaleDelegateField;

		// Token: 0x040007E5 RID: 2021
		private static readonly QualitySettings.get_terrainBasemapDistanceDelegate get_terrainBasemapDistanceDelegateField;

		// Token: 0x040007E6 RID: 2022
		private static readonly QualitySettings.set_terrainBasemapDistanceDelegate set_terrainBasemapDistanceDelegateField;

		// Token: 0x040007E7 RID: 2023
		private static readonly QualitySettings.get_terrainDetailDistanceDelegate get_terrainDetailDistanceDelegateField;

		// Token: 0x040007E8 RID: 2024
		private static readonly QualitySettings.set_terrainDetailDistanceDelegate set_terrainDetailDistanceDelegateField;

		// Token: 0x040007E9 RID: 2025
		private static readonly QualitySettings.get_terrainTreeDistanceDelegate get_terrainTreeDistanceDelegateField;

		// Token: 0x040007EA RID: 2026
		private static readonly QualitySettings.set_terrainTreeDistanceDelegate set_terrainTreeDistanceDelegateField;

		// Token: 0x040007EB RID: 2027
		private static readonly QualitySettings.get_terrainBillboardStartDelegate get_terrainBillboardStartDelegateField;

		// Token: 0x040007EC RID: 2028
		private static readonly QualitySettings.set_terrainBillboardStartDelegate set_terrainBillboardStartDelegateField;

		// Token: 0x040007ED RID: 2029
		private static readonly QualitySettings.get_terrainFadeLengthDelegate get_terrainFadeLengthDelegateField;

		// Token: 0x040007EE RID: 2030
		private static readonly QualitySettings.set_terrainFadeLengthDelegate set_terrainFadeLengthDelegateField;

		// Token: 0x040007EF RID: 2031
		private static readonly QualitySettings.get_terrainMaxTreesDelegate get_terrainMaxTreesDelegateField;

		// Token: 0x040007F0 RID: 2032
		private static readonly QualitySettings.set_terrainMaxTreesDelegate set_terrainMaxTreesDelegateField;

		// Token: 0x040007F1 RID: 2033
		private static readonly QualitySettings.set_INTERNAL_renderPipelineDelegate set_INTERNAL_renderPipelineDelegateField;

		// Token: 0x040007F2 RID: 2034
		private static readonly QualitySettings.InternalGetRenderPipelineAssetAtDelegate InternalGetRenderPipelineAssetAtDelegateField;

		// Token: 0x040007F3 RID: 2035
		private static readonly QualitySettings.get_blendWeightsDelegate get_blendWeightsDelegateField;

		// Token: 0x040007F4 RID: 2036
		private static readonly QualitySettings.set_blendWeightsDelegate set_blendWeightsDelegateField;

		// Token: 0x040007F5 RID: 2037
		private static readonly QualitySettings.get_skinWeightsDelegate get_skinWeightsDelegateField;

		// Token: 0x040007F6 RID: 2038
		private static readonly QualitySettings.set_skinWeightsDelegate set_skinWeightsDelegateField;

		// Token: 0x040007F7 RID: 2039
		private static readonly QualitySettings.get_countDelegate get_countDelegateField;

		// Token: 0x040007F8 RID: 2040
		private static readonly QualitySettings.get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;

		// Token: 0x040007F9 RID: 2041
		private static readonly QualitySettings.set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;

		// Token: 0x040007FA RID: 2042
		private static readonly QualitySettings.get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x040007FB RID: 2043
		private static readonly QualitySettings.set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x040007FC RID: 2044
		private static readonly QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x040007FD RID: 2045
		private static readonly QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x040007FE RID: 2046
		private static readonly QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x040007FF RID: 2047
		private static readonly QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x04000800 RID: 2048
		private static readonly QualitySettings.get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000801 RID: 2049
		private static readonly QualitySettings.set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000802 RID: 2050
		private static readonly QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000803 RID: 2051
		private static readonly QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000804 RID: 2052
		private static readonly QualitySettings.get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;

		// Token: 0x04000805 RID: 2053
		private static readonly QualitySettings.set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;

		// Token: 0x04000806 RID: 2054
		private static readonly QualitySettings.GetQualitySettingsDelegate GetQualitySettingsDelegateField;

		// Token: 0x04000807 RID: 2055
		private static readonly QualitySettings.get_desiredColorSpaceDelegate get_desiredColorSpaceDelegateField;

		// Token: 0x04000808 RID: 2056
		private static readonly QualitySettings.get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x04000809 RID: 2057
		private static readonly QualitySettings.set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x02000576 RID: 1398
		// (Invoke) Token: 0x060033A6 RID: 13222
		private delegate int get_pixelLightCountDelegate();

		// Token: 0x02000577 RID: 1399
		// (Invoke) Token: 0x060033A8 RID: 13224
		private delegate void set_pixelLightCountDelegate(int value);

		// Token: 0x02000578 RID: 1400
		// (Invoke) Token: 0x060033AA RID: 13226
		private delegate ShadowQuality get_shadowsDelegate();

		// Token: 0x02000579 RID: 1401
		// (Invoke) Token: 0x060033AC RID: 13228
		private delegate void set_shadowsDelegate(ShadowQuality value);

		// Token: 0x0200057A RID: 1402
		// (Invoke) Token: 0x060033AE RID: 13230
		private delegate ShadowProjection get_shadowProjectionDelegate();

		// Token: 0x0200057B RID: 1403
		// (Invoke) Token: 0x060033B0 RID: 13232
		private delegate void set_shadowProjectionDelegate(ShadowProjection value);

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x060033B2 RID: 13234
		private delegate int get_shadowCascadesDelegate();

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x060033B4 RID: 13236
		private delegate void set_shadowCascadesDelegate(int value);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x060033B6 RID: 13238
		private delegate float get_shadowDistanceDelegate();

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x060033B8 RID: 13240
		private delegate void set_shadowDistanceDelegate(float value);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x060033BA RID: 13242
		private delegate ShadowResolution get_shadowResolutionDelegate();

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x060033BC RID: 13244
		private delegate void set_shadowResolutionDelegate(ShadowResolution value);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x060033BE RID: 13246
		private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

		// Token: 0x02000583 RID: 1411
		// (Invoke) Token: 0x060033C0 RID: 13248
		private delegate float get_shadowNearPlaneOffsetDelegate();

		// Token: 0x02000584 RID: 1412
		// (Invoke) Token: 0x060033C2 RID: 13250
		private delegate void set_shadowNearPlaneOffsetDelegate(float value);

		// Token: 0x02000585 RID: 1413
		// (Invoke) Token: 0x060033C4 RID: 13252
		private delegate float get_shadowCascade2SplitDelegate();

		// Token: 0x02000586 RID: 1414
		// (Invoke) Token: 0x060033C6 RID: 13254
		private delegate void set_shadowCascade2SplitDelegate(float value);

		// Token: 0x02000587 RID: 1415
		// (Invoke) Token: 0x060033C8 RID: 13256
		private delegate void set_lodBiasDelegate(float value);

		// Token: 0x02000588 RID: 1416
		// (Invoke) Token: 0x060033CA RID: 13258
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x02000589 RID: 1417
		// (Invoke) Token: 0x060033CC RID: 13260
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x0200058A RID: 1418
		// (Invoke) Token: 0x060033CE RID: 13262
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x0200058B RID: 1419
		// (Invoke) Token: 0x060033D0 RID: 13264
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x0200058C RID: 1420
		// (Invoke) Token: 0x060033D2 RID: 13266
		private delegate int get_globalTextureMipmapLimitDelegate();

		// Token: 0x0200058D RID: 1421
		// (Invoke) Token: 0x060033D4 RID: 13268
		private delegate void set_globalTextureMipmapLimitDelegate(int value);

		// Token: 0x0200058E RID: 1422
		// (Invoke) Token: 0x060033D6 RID: 13270
		private delegate bool get_enableLODCrossFadeDelegate();

		// Token: 0x0200058F RID: 1423
		// (Invoke) Token: 0x060033D8 RID: 13272
		private delegate int get_particleRaycastBudgetDelegate();

		// Token: 0x02000590 RID: 1424
		// (Invoke) Token: 0x060033DA RID: 13274
		private delegate void set_particleRaycastBudgetDelegate(int value);

		// Token: 0x02000591 RID: 1425
		// (Invoke) Token: 0x060033DC RID: 13276
		private delegate bool get_softParticlesDelegate();

		// Token: 0x02000592 RID: 1426
		// (Invoke) Token: 0x060033DE RID: 13278
		private delegate void set_softParticlesDelegate(bool value);

		// Token: 0x02000593 RID: 1427
		// (Invoke) Token: 0x060033E0 RID: 13280
		private delegate bool get_softVegetationDelegate();

		// Token: 0x02000594 RID: 1428
		// (Invoke) Token: 0x060033E2 RID: 13282
		private delegate void set_softVegetationDelegate(bool value);

		// Token: 0x02000595 RID: 1429
		// (Invoke) Token: 0x060033E4 RID: 13284
		private delegate int get_realtimeGICPUUsageDelegate();

		// Token: 0x02000596 RID: 1430
		// (Invoke) Token: 0x060033E6 RID: 13286
		private delegate void set_realtimeGICPUUsageDelegate(int value);

		// Token: 0x02000597 RID: 1431
		// (Invoke) Token: 0x060033E8 RID: 13288
		private delegate int get_asyncUploadTimeSliceDelegate();

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x060033EA RID: 13290
		private delegate void set_asyncUploadTimeSliceDelegate(int value);

		// Token: 0x02000599 RID: 1433
		// (Invoke) Token: 0x060033EC RID: 13292
		private delegate int get_asyncUploadBufferSizeDelegate();

		// Token: 0x0200059A RID: 1434
		// (Invoke) Token: 0x060033EE RID: 13294
		private delegate void set_asyncUploadBufferSizeDelegate(int value);

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x060033F0 RID: 13296
		private delegate bool get_asyncUploadPersistentBufferDelegate();

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x060033F2 RID: 13298
		private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

		// Token: 0x0200059D RID: 1437
		// (Invoke) Token: 0x060033F4 RID: 13300
		private delegate void SetLODSettingsDelegate(float lodBias, int maximumLODLevel, bool setDirty);

		// Token: 0x0200059E RID: 1438
		// (Invoke) Token: 0x060033F6 RID: 13302
		private delegate bool get_realtimeReflectionProbesDelegate();

		// Token: 0x0200059F RID: 1439
		// (Invoke) Token: 0x060033F8 RID: 13304
		private delegate void set_realtimeReflectionProbesDelegate(bool value);

		// Token: 0x020005A0 RID: 1440
		// (Invoke) Token: 0x060033FA RID: 13306
		private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

		// Token: 0x020005A1 RID: 1441
		// (Invoke) Token: 0x060033FC RID: 13308
		private delegate bool get_useLegacyDetailDistributionDelegate();

		// Token: 0x020005A2 RID: 1442
		// (Invoke) Token: 0x060033FE RID: 13310
		private delegate void set_useLegacyDetailDistributionDelegate(bool value);

		// Token: 0x020005A3 RID: 1443
		// (Invoke) Token: 0x06003400 RID: 13312
		private delegate float get_resolutionScalingFixedDPIFactorDelegate();

		// Token: 0x020005A4 RID: 1444
		// (Invoke) Token: 0x06003402 RID: 13314
		private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

		// Token: 0x020005A5 RID: 1445
		// (Invoke) Token: 0x06003404 RID: 13316
		private delegate TerrainQualityOverrides get_terrainQualityOverridesDelegate();

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x06003406 RID: 13318
		private delegate void set_terrainQualityOverridesDelegate(TerrainQualityOverrides value);

		// Token: 0x020005A7 RID: 1447
		// (Invoke) Token: 0x06003408 RID: 13320
		private delegate float get_terrainPixelErrorDelegate();

		// Token: 0x020005A8 RID: 1448
		// (Invoke) Token: 0x0600340A RID: 13322
		private delegate void set_terrainPixelErrorDelegate(float value);

		// Token: 0x020005A9 RID: 1449
		// (Invoke) Token: 0x0600340C RID: 13324
		private delegate float get_terrainDetailDensityScaleDelegate();

		// Token: 0x020005AA RID: 1450
		// (Invoke) Token: 0x0600340E RID: 13326
		private delegate void set_terrainDetailDensityScaleDelegate(float value);

		// Token: 0x020005AB RID: 1451
		// (Invoke) Token: 0x06003410 RID: 13328
		private delegate float get_terrainBasemapDistanceDelegate();

		// Token: 0x020005AC RID: 1452
		// (Invoke) Token: 0x06003412 RID: 13330
		private delegate void set_terrainBasemapDistanceDelegate(float value);

		// Token: 0x020005AD RID: 1453
		// (Invoke) Token: 0x06003414 RID: 13332
		private delegate float get_terrainDetailDistanceDelegate();

		// Token: 0x020005AE RID: 1454
		// (Invoke) Token: 0x06003416 RID: 13334
		private delegate void set_terrainDetailDistanceDelegate(float value);

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x06003418 RID: 13336
		private delegate float get_terrainTreeDistanceDelegate();

		// Token: 0x020005B0 RID: 1456
		// (Invoke) Token: 0x0600341A RID: 13338
		private delegate void set_terrainTreeDistanceDelegate(float value);

		// Token: 0x020005B1 RID: 1457
		// (Invoke) Token: 0x0600341C RID: 13340
		private delegate float get_terrainBillboardStartDelegate();

		// Token: 0x020005B2 RID: 1458
		// (Invoke) Token: 0x0600341E RID: 13342
		private delegate void set_terrainBillboardStartDelegate(float value);

		// Token: 0x020005B3 RID: 1459
		// (Invoke) Token: 0x06003420 RID: 13344
		private delegate float get_terrainFadeLengthDelegate();

		// Token: 0x020005B4 RID: 1460
		// (Invoke) Token: 0x06003422 RID: 13346
		private delegate void set_terrainFadeLengthDelegate(float value);

		// Token: 0x020005B5 RID: 1461
		// (Invoke) Token: 0x06003424 RID: 13348
		private delegate float get_terrainMaxTreesDelegate();

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x06003426 RID: 13350
		private delegate void set_terrainMaxTreesDelegate(float value);

		// Token: 0x020005B7 RID: 1463
		// (Invoke) Token: 0x06003428 RID: 13352
		private delegate void set_INTERNAL_renderPipelineDelegate(IntPtr value);

		// Token: 0x020005B8 RID: 1464
		// (Invoke) Token: 0x0600342A RID: 13354
		private delegate IntPtr InternalGetRenderPipelineAssetAtDelegate(int index);

		// Token: 0x020005B9 RID: 1465
		// (Invoke) Token: 0x0600342C RID: 13356
		private delegate BlendWeights get_blendWeightsDelegate();

		// Token: 0x020005BA RID: 1466
		// (Invoke) Token: 0x0600342E RID: 13358
		private delegate void set_blendWeightsDelegate(BlendWeights value);

		// Token: 0x020005BB RID: 1467
		// (Invoke) Token: 0x06003430 RID: 13360
		private delegate SkinWeights get_skinWeightsDelegate();

		// Token: 0x020005BC RID: 1468
		// (Invoke) Token: 0x06003432 RID: 13362
		private delegate void set_skinWeightsDelegate(SkinWeights value);

		// Token: 0x020005BD RID: 1469
		// (Invoke) Token: 0x06003434 RID: 13364
		private delegate int get_countDelegate();

		// Token: 0x020005BE RID: 1470
		// (Invoke) Token: 0x06003436 RID: 13366
		private delegate bool get_streamingMipmapsActiveDelegate();

		// Token: 0x020005BF RID: 1471
		// (Invoke) Token: 0x06003438 RID: 13368
		private delegate void set_streamingMipmapsActiveDelegate(bool value);

		// Token: 0x020005C0 RID: 1472
		// (Invoke) Token: 0x0600343A RID: 13370
		private delegate float get_streamingMipmapsMemoryBudgetDelegate();

		// Token: 0x020005C1 RID: 1473
		// (Invoke) Token: 0x0600343C RID: 13372
		private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

		// Token: 0x020005C2 RID: 1474
		// (Invoke) Token: 0x0600343E RID: 13374
		private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

		// Token: 0x020005C3 RID: 1475
		// (Invoke) Token: 0x06003440 RID: 13376
		private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

		// Token: 0x020005C4 RID: 1476
		// (Invoke) Token: 0x06003442 RID: 13378
		private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

		// Token: 0x020005C5 RID: 1477
		// (Invoke) Token: 0x06003444 RID: 13380
		private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

		// Token: 0x020005C6 RID: 1478
		// (Invoke) Token: 0x06003446 RID: 13382
		private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

		// Token: 0x020005C7 RID: 1479
		// (Invoke) Token: 0x06003448 RID: 13384
		private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

		// Token: 0x020005C8 RID: 1480
		// (Invoke) Token: 0x0600344A RID: 13386
		private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

		// Token: 0x020005C9 RID: 1481
		// (Invoke) Token: 0x0600344C RID: 13388
		private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

		// Token: 0x020005CA RID: 1482
		// (Invoke) Token: 0x0600344E RID: 13390
		private delegate int get_maxQueuedFramesDelegate();

		// Token: 0x020005CB RID: 1483
		// (Invoke) Token: 0x06003450 RID: 13392
		private delegate void set_maxQueuedFramesDelegate(int value);

		// Token: 0x020005CC RID: 1484
		// (Invoke) Token: 0x06003452 RID: 13394
		private delegate IntPtr GetQualitySettingsDelegate();

		// Token: 0x020005CD RID: 1485
		// (Invoke) Token: 0x06003454 RID: 13396
		private delegate ColorSpace get_desiredColorSpaceDelegate();

		// Token: 0x020005CE RID: 1486
		// (Invoke) Token: 0x06003456 RID: 13398
		private delegate void get_shadowCascade4Split_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020005CF RID: 1487
		// (Invoke) Token: 0x06003458 RID: 13400
		private delegate void set_shadowCascade4Split_InjectedDelegate(IntPtr value);
	}
}
