using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200006F RID: 111
	public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x00093140 File Offset: 0x00091340
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamSD()
		{
			Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr);
			VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "ClassName");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "color");
			VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "colorGradient");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityModeAdvanced");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityInside");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityOutside");
			VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "intensityMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "hdrpExposureWeight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "blendingMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngleFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngle");
			VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "spotAngleMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "coneRadiusStart");
			VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "shaderAccuracy");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomMeshType");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCustomSides");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCustomSegments");
			VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "skewingLocalForwardDirection");
			VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "clippingPlaneTransform");
			VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "geomCap");
			VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "attenuationEquation");
			VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "attenuationCustomBlending");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffStart");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEnd");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEndFromLight");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fallOffEndMultiplier");
			VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "depthBlendDistance");
			VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "cameraClippingDistance");
			VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "glareFrontal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "glareBehind");
			VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "fresnelPow");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseIntensity");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseScaleUseGlobal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseScaleLocal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseVelocityUseGlobal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "noiseVelocityLocal");
			VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "dimensions");
			VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "tiltFactor");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_INTERNAL_DynamicOcclusionMode");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_INTERNAL_DynamicOcclusionMode_Runtime");
			VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "onWillCameraRenderThisBeam");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_OnBeamGeometryInitialized");
			VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_TrackChangesDuringPlaytime");
			VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_SortingLayerID");
			VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_SortingOrder");
			VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_FadeOutBegin");
			VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "_FadeOutEnd");
			VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "<_INTERNAL_InstancedMaterialGroupID>k__BackingField");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_BeamGeom");
			VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "m_CoPlaytimeUpdate");
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664247);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664248);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664249);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664250);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664251);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664252);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664253);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664254);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664255);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664256);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664257);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664258);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664259);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664260);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664261);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664262);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664263);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664264);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664265);
			VolumetricLightBeamSD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664266);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664267);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664268);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664269);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664270);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664271);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664272);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664273);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664274);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664275);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664276);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664277);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664278);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664279);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664280);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664281);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664282);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664283);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664284);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664285);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664286);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664287);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664288);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664289);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664290);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664291);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664292);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664293);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664294);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664295);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664296);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664297);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664298);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664299);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664300);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664301);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664302);
			VolumetricLightBeamSD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664303);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664304);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664305);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664306);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664307);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664308);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664309);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664310);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664311);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664312);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664313);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664314);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664315);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664316);
			VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664317);
			VolumetricLightBeamSD.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664318);
			VolumetricLightBeamSD.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664319);
			VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664320);
			VolumetricLightBeamSD.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664321);
			VolumetricLightBeamSD.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664322);
			VolumetricLightBeamSD.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664323);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664324);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664325);
			VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664326);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshStats_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664327);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664328);
			VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664329);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664330);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664331);
			VolumetricLightBeamSD.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664332);
			VolumetricLightBeamSD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664333);
			VolumetricLightBeamSD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664334);
			VolumetricLightBeamSD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664335);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664336);
			VolumetricLightBeamSD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664337);
			VolumetricLightBeamSD.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664338);
			VolumetricLightBeamSD.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664339);
			VolumetricLightBeamSD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664340);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ClampProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664341);
			VolumetricLightBeamSD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664342);
			VolumetricLightBeamSD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664343);
			VolumetricLightBeamSD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, 100664344);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00093D50 File Offset: 0x00091F50
		public unsafe ColorMode usedColorMode
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 70205, RefRangeEnd = 70211, XrefRangeStart = 70205, XrefRangeEnd = 70211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00093D8C File Offset: 0x00091F8C
		public unsafe bool useColorFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73320, XrefRangeEnd = 73321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00093DC8 File Offset: 0x00091FC8
		public unsafe bool useColorTemperatureFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73321, XrefRangeEnd = 73327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00093E04 File Offset: 0x00092004
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00093E40 File Offset: 0x00092040
		public unsafe float alphaInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 73327, RefRangeEnd = 73329, XrefRangeStart = 73327, XrefRangeEnd = 73327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00093E80 File Offset: 0x00092080
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00093EBC File Offset: 0x000920BC
		public unsafe float alphaOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00093EFC File Offset: 0x000920FC
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00093F38 File Offset: 0x00092138
		public unsafe float intensityGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00093F78 File Offset: 0x00092178
		public unsafe bool useIntensityFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73329, XrefRangeEnd = 73330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00093FB4 File Offset: 0x000921B4
		[CallerCount(0)]
		public unsafe void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &inside;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outside;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00094000 File Offset: 0x00092200
		public unsafe bool useSpotAngleFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73330, XrefRangeEnd = 73331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0009403C File Offset: 0x0009223C
		public unsafe float coneAngle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 73333, RefRangeEnd = 73336, XrefRangeStart = 73331, XrefRangeEnd = 73333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00094078 File Offset: 0x00092278
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x000940B4 File Offset: 0x000922B4
		public unsafe float coneRadiusEnd
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73337, RefRangeEnd = 73338, XrefRangeStart = 73336, XrefRangeEnd = 73337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73338, XrefRangeEnd = 73339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000940F4 File Offset: 0x000922F4
		public unsafe float coneVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73339, XrefRangeEnd = 73340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00094130 File Offset: 0x00092330
		public unsafe float coneApexOffsetZ
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73341, RefRangeEnd = 73347, XrefRangeStart = 73340, XrefRangeEnd = 73341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0009416C File Offset: 0x0009236C
		public unsafe Vector3 coneApexPositionLocal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73347, XrefRangeEnd = 73348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000941A8 File Offset: 0x000923A8
		public unsafe Vector3 coneApexPositionGlobal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73348, XrefRangeEnd = 73352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000941E4 File Offset: 0x000923E4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsScalable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0009422C File Offset: 0x0009242C
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00094268 File Offset: 0x00092468
		public unsafe int geomSides
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73352, XrefRangeEnd = 73370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000942A8 File Offset: 0x000924A8
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x000942E4 File Offset: 0x000924E4
		public unsafe int geomSegments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73370, XrefRangeEnd = 73388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00094324 File Offset: 0x00092524
		public unsafe Vector3 skewingLocalForwardDirectionNormalized
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 73393, RefRangeEnd = 73400, XrefRangeStart = 73388, XrefRangeEnd = 73393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00094360 File Offset: 0x00092560
		public unsafe bool canHaveMeshSkewing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0009439C File Offset: 0x0009259C
		public unsafe bool hasMeshSkewing
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 73405, RefRangeEnd = 73413, XrefRangeStart = 73400, XrefRangeEnd = 73405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000943D8 File Offset: 0x000925D8
		public unsafe Vector4 additionalClippingPlane
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73413, XrefRangeEnd = 73419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00094414 File Offset: 0x00092614
		public unsafe float attenuationLerpLinearQuad
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00094450 File Offset: 0x00092650
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0009448C File Offset: 0x0009268C
		public unsafe float fadeStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x000944CC File Offset: 0x000926CC
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00094508 File Offset: 0x00092708
		public unsafe float fadeEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00094548 File Offset: 0x00092748
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00094584 File Offset: 0x00092784
		public unsafe bool fadeEndFromLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000945C4 File Offset: 0x000927C4
		public unsafe bool useFallOffEndFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73419, XrefRangeEnd = 73420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00094600 File Offset: 0x00092800
		public unsafe float maxGeometryDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0009463C File Offset: 0x0009283C
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 73420, RefRangeEnd = 73422, XrefRangeStart = 73420, XrefRangeEnd = 73420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00094678 File Offset: 0x00092878
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x000946B4 File Offset: 0x000928B4
		public unsafe bool noiseEnabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 73420, RefRangeEnd = 73422, XrefRangeStart = 73420, XrefRangeEnd = 73422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000946F4 File Offset: 0x000928F4
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00094730 File Offset: 0x00092930
		public unsafe float fadeOutBegin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73422, XrefRangeEnd = 73423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00094770 File Offset: 0x00092970
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x000947AC File Offset: 0x000929AC
		public unsafe float fadeOutEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73423, XrefRangeEnd = 73424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x000947EC File Offset: 0x000929EC
		public unsafe bool isFadeOutEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73424, RefRangeEnd = 73425, XrefRangeStart = 73424, XrefRangeEnd = 73424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00094828 File Offset: 0x00092A28
		public unsafe bool isTilted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73425, XrefRangeEnd = 73428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00094864 File Offset: 0x00092A64
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x000948A0 File Offset: 0x00092AA0
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73428, XrefRangeEnd = 73433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x000948E0 File Offset: 0x00092AE0
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00094918 File Offset: 0x00092B18
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73433, XrefRangeEnd = 73434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73434, XrefRangeEnd = 73440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0009495C File Offset: 0x00092B5C
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00094998 File Offset: 0x00092B98
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73440, XrefRangeEnd = 73445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000949D8 File Offset: 0x00092BD8
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00094A14 File Offset: 0x00092C14
		public unsafe bool trackChangesDuringPlaytime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73445, XrefRangeEnd = 73446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00094A54 File Offset: 0x00092C54
		public unsafe bool isCurrentlyTrackingChanges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00094A90 File Offset: 0x00092C90
		[CallerCount(0)]
		public unsafe override BeamGeometryAbstractBase GetBeamGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BeamGeometryAbstractBase>(intPtr3) : null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00094ADC File Offset: 0x00092CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73446, XrefRangeEnd = 73447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetBeamGeometryNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00094B18 File Offset: 0x00092D18
		public unsafe int blendingModeAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73447, XrefRangeEnd = 73458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00094B54 File Offset: 0x00092D54
		public unsafe Quaternion beamInternalLocalRotation
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 73460, RefRangeEnd = 73465, XrefRangeStart = 73458, XrefRangeEnd = 73460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00094B90 File Offset: 0x00092D90
		public unsafe Vector3 beamLocalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73465, XrefRangeEnd = 73467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00094BCC File Offset: 0x00092DCC
		public unsafe Vector3 beamGlobalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73467, XrefRangeEnd = 73474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00094C08 File Offset: 0x00092E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73474, XrefRangeEnd = 73476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetLossyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00094C50 File Offset: 0x00092E50
		public unsafe float raycastDistance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 73479, RefRangeEnd = 73483, XrefRangeStart = 73476, XrefRangeEnd = 73479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00094C8C File Offset: 0x00092E8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 73487, RefRangeEnd = 73493, XrefRangeStart = 73483, XrefRangeEnd = 73487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref localVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00094CD8 File Offset: 0x00092ED8
		public unsafe Vector3 raycastGlobalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73493, XrefRangeEnd = 73499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00094D14 File Offset: 0x00092F14
		public unsafe Vector3 raycastGlobalUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73499, XrefRangeEnd = 73502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00094D50 File Offset: 0x00092F50
		public unsafe Vector3 raycastGlobalRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73502, XrefRangeEnd = 73505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00094D8C File Offset: 0x00092F8C
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00094DC8 File Offset: 0x00092FC8
		public unsafe MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73505, XrefRangeEnd = 73506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00094E08 File Offset: 0x00093008
		public unsafe MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73506, XrefRangeEnd = 73507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00094E44 File Offset: 0x00093044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73517, RefRangeEnd = 73519, XrefRangeStart = 73507, XrefRangeEnd = 73517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00094E98 File Offset: 0x00093098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73519, XrefRangeEnd = 73523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00094EDC File Offset: 0x000930DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73523, XrefRangeEnd = 73527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00094F20 File Offset: 0x00093120
		[CallerCount(0)]
		public unsafe void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00094F64 File Offset: 0x00093164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73527, XrefRangeEnd = 73538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeamSD.OnBeamGeometryInitialized cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00094FA8 File Offset: 0x000931A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73538, XrefRangeEnd = 73539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallOnBeamGeometryInitializedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00094FDC File Offset: 0x000931DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73546, RefRangeEnd = 73548, XrefRangeStart = 73539, XrefRangeEnd = 73546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFadeOutValue(ref float propToChange, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &propToChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00095028 File Offset: 0x00093228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73548, XrefRangeEnd = 73553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFadeOutStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0009505C File Offset: 0x0009325C
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00095098 File Offset: 0x00093298
		public unsafe uint _INTERNAL_InstancedMaterialGroupID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000950D8 File Offset: 0x000932D8
		public unsafe string meshStats
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73553, XrefRangeEnd = 73566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshStats_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00095110 File Offset: 0x00093310
		public unsafe int meshVerticesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73566, XrefRangeEnd = 73574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0009514C File Offset: 0x0009334C
		public unsafe int meshTrianglesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73574, XrefRangeEnd = 73582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00095188 File Offset: 0x00093388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73582, XrefRangeEnd = 73585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactor(Vector3 posWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000951D4 File Offset: 0x000933D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73594, RefRangeEnd = 73596, XrefRangeStart = 73585, XrefRangeEnd = 73594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posOS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00095220 File Offset: 0x00093420
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 73596, RefRangeEnd = 73622, XrefRangeStart = 73596, XrefRangeEnd = 73596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00095254 File Offset: 0x00093454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73622, XrefRangeEnd = 73645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GenerateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00095290 File Offset: 0x00093490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73645, XrefRangeEnd = 73652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateAfterManualPropertyChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamSD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000952CC File Offset: 0x000934CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73652, XrefRangeEnd = 73653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00095300 File Offset: 0x00093500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73653, XrefRangeEnd = 73661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00095334 File Offset: 0x00093534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73661, XrefRangeEnd = 73670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00095368 File Offset: 0x00093568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73681, RefRangeEnd = 73683, XrefRangeStart = 73670, XrefRangeEnd = 73681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlaytimeUpdateIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0009539C File Offset: 0x0009359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73683, XrefRangeEnd = 73688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoPlaytimeUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000953DC File Offset: 0x000935DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73710, RefRangeEnd = 73713, XrefRangeStart = 73688, XrefRangeEnd = 73710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPropertiesFromAttachedSpotLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00095410 File Offset: 0x00093610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73720, RefRangeEnd = 73723, XrefRangeStart = 73713, XrefRangeEnd = 73720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ClampProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00095444 File Offset: 0x00093644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73723, XrefRangeEnd = 73725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00095478 File Offset: 0x00093678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73725, XrefRangeEnd = 73731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000954C4 File Offset: 0x000936C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73731, XrefRangeEnd = 73742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamSD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00005900 File Offset: 0x00003B00
		public VolumetricLightBeamSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00095500 File Offset: 0x00093700
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00005909 File Offset: 0x00003B09
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricLightBeamSD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00095520 File Offset: 0x00093720
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000591B File Offset: 0x00003B1B
		public unsafe bool colorFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorFromLight)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00095548 File Offset: 0x00093748
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00005936 File Offset: 0x00003B36
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00095570 File Offset: 0x00093770
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00005951 File Offset: 0x00003B51
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00095598 File Offset: 0x00093798
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe Gradient colorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_colorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000955C8 File Offset: 0x000937C8
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0000598B File Offset: 0x00003B8B
		public unsafe bool intensityFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityFromLight)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000955F0 File Offset: 0x000937F0
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000059A6 File Offset: 0x00003BA6
		public unsafe bool intensityModeAdvanced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityModeAdvanced)) = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00095618 File Offset: 0x00093818
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x000059C1 File Offset: 0x00003BC1
		public unsafe float intensityInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityInside)) = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00095640 File Offset: 0x00093840
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000059DC File Offset: 0x00003BDC
		public unsafe float intensityOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityOutside)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00095668 File Offset: 0x00093868
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000059F7 File Offset: 0x00003BF7
		public unsafe float intensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_intensityMultiplier)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00095690 File Offset: 0x00093890
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00005A12 File Offset: 0x00003C12
		public unsafe float hdrpExposureWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_hdrpExposureWeight)) = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000956B8 File Offset: 0x000938B8
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00005A2D File Offset: 0x00003C2D
		public unsafe BlendingMode blendingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_blendingMode)) = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000956E0 File Offset: 0x000938E0
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00005A48 File Offset: 0x00003C48
		public unsafe bool spotAngleFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleFromLight)) = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00095708 File Offset: 0x00093908
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00005A63 File Offset: 0x00003C63
		public unsafe float spotAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngle)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00095730 File Offset: 0x00093930
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00005A7E File Offset: 0x00003C7E
		public unsafe float spotAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_spotAngleMultiplier)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00095758 File Offset: 0x00093958
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00005A99 File Offset: 0x00003C99
		public unsafe float coneRadiusStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_coneRadiusStart)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00095780 File Offset: 0x00093980
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public unsafe ShaderAccuracy shaderAccuracy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_shaderAccuracy)) = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000957A8 File Offset: 0x000939A8
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00005ACF File Offset: 0x00003CCF
		public unsafe MeshType geomMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomMeshType)) = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000957D0 File Offset: 0x000939D0
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00005AEA File Offset: 0x00003CEA
		public unsafe int geomCustomSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSides)) = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000957F8 File Offset: 0x000939F8
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00005B05 File Offset: 0x00003D05
		public unsafe int geomCustomSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCustomSegments)) = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00095820 File Offset: 0x00093A20
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00005B20 File Offset: 0x00003D20
		public unsafe Vector3 skewingLocalForwardDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_skewingLocalForwardDirection)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00095848 File Offset: 0x00093A48
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00005B3B File Offset: 0x00003D3B
		public unsafe Transform clippingPlaneTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_clippingPlaneTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00095878 File Offset: 0x00093A78
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00005B5A File Offset: 0x00003D5A
		public unsafe bool geomCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_geomCap)) = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000958A0 File Offset: 0x00093AA0
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00005B75 File Offset: 0x00003D75
		public unsafe AttenuationEquation attenuationEquation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationEquation)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000958C8 File Offset: 0x00093AC8
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00005B90 File Offset: 0x00003D90
		public unsafe float attenuationCustomBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_attenuationCustomBlending)) = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000958F0 File Offset: 0x00093AF0
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00005BAB File Offset: 0x00003DAB
		public unsafe float fallOffStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffStart)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00095918 File Offset: 0x00093B18
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00005BC6 File Offset: 0x00003DC6
		public unsafe float fallOffEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEnd)) = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00095940 File Offset: 0x00093B40
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00005BE1 File Offset: 0x00003DE1
		public unsafe bool fallOffEndFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndFromLight)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00095968 File Offset: 0x00093B68
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00005BFC File Offset: 0x00003DFC
		public unsafe float fallOffEndMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fallOffEndMultiplier)) = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00095990 File Offset: 0x00093B90
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00005C17 File Offset: 0x00003E17
		public unsafe float depthBlendDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_depthBlendDistance)) = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000959B8 File Offset: 0x00093BB8
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00005C32 File Offset: 0x00003E32
		public unsafe float cameraClippingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_cameraClippingDistance)) = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000959E0 File Offset: 0x00093BE0
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00005C4D File Offset: 0x00003E4D
		public unsafe float glareFrontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareFrontal)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00095A08 File Offset: 0x00093C08
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00005C68 File Offset: 0x00003E68
		public unsafe float glareBehind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_glareBehind)) = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00095A30 File Offset: 0x00093C30
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00005C83 File Offset: 0x00003E83
		public unsafe float fresnelPow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_fresnelPow)) = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00095A58 File Offset: 0x00093C58
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00005C9E File Offset: 0x00003E9E
		public unsafe NoiseMode noiseMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseMode)) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00095A80 File Offset: 0x00093C80
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00005CB9 File Offset: 0x00003EB9
		public unsafe float noiseIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseIntensity)) = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00095AA8 File Offset: 0x00093CA8
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00005CD4 File Offset: 0x00003ED4
		public unsafe bool noiseScaleUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleUseGlobal)) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00095AD0 File Offset: 0x00093CD0
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00005CEF File Offset: 0x00003EEF
		public unsafe float noiseScaleLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseScaleLocal)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00095AF8 File Offset: 0x00093CF8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00005D0A File Offset: 0x00003F0A
		public unsafe bool noiseVelocityUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityUseGlobal)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00095B20 File Offset: 0x00093D20
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00005D25 File Offset: 0x00003F25
		public unsafe Vector3 noiseVelocityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_noiseVelocityLocal)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00095B48 File Offset: 0x00093D48
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00005D40 File Offset: 0x00003F40
		public unsafe Dimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00095B70 File Offset: 0x00093D70
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00005D5B File Offset: 0x00003F5B
		public unsafe Vector2 tiltFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_tiltFactor)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00095B98 File Offset: 0x00093D98
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00005D76 File Offset: 0x00003F76
		public unsafe MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00095BC0 File Offset: 0x00093DC0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00005D91 File Offset: 0x00003F91
		public unsafe bool m_INTERNAL_DynamicOcclusionMode_Runtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00095BE8 File Offset: 0x00093DE8
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00005DAC File Offset: 0x00003FAC
		public unsafe VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD.OnWillCameraRenderCB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_onWillCameraRenderThisBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00095C18 File Offset: 0x00093E18
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00005DCB File Offset: 0x00003FCB
		public unsafe VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD.OnBeamGeometryInitialized>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_OnBeamGeometryInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00095C48 File Offset: 0x00093E48
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00005DEA File Offset: 0x00003FEA
		public unsafe bool _TrackChangesDuringPlaytime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__TrackChangesDuringPlaytime)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00095C70 File Offset: 0x00093E70
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00005E05 File Offset: 0x00004005
		public unsafe int _SortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingLayerID)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00095C98 File Offset: 0x00093E98
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00005E20 File Offset: 0x00004020
		public unsafe int _SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__SortingOrder)) = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00095CC0 File Offset: 0x00093EC0
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00005E3B File Offset: 0x0000403B
		public unsafe float _FadeOutBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutBegin)) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00095CE8 File Offset: 0x00093EE8
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00005E56 File Offset: 0x00004056
		public unsafe float _FadeOutEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr__FadeOutEnd)) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00095D10 File Offset: 0x00093F10
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00005E71 File Offset: 0x00004071
		public unsafe uint __INTERNAL_InstancedMaterialGroupID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00095D38 File Offset: 0x00093F38
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00005E8C File Offset: 0x0000408C
		public unsafe BeamGeometrySD m_BeamGeom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeamGeometrySD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_BeamGeom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00095D68 File Offset: 0x00093F68
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00005EAB File Offset: 0x000040AB
		public unsafe Coroutine m_CoPlaytimeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD.NativeFieldInfoPtr_m_CoPlaytimeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_colorFromLight;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_intensityFromLight;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_intensityModeAdvanced;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_intensityInside;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_intensityOutside;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_hdrpExposureWeight;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_spotAngleFromLight;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_spotAngle;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_spotAngleMultiplier;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_coneRadiusStart;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_shaderAccuracy;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_geomMeshType;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSides;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSegments;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_skewingLocalForwardDirection;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_clippingPlaneTransform;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_geomCap;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_attenuationEquation;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_attenuationCustomBlending;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_fallOffStart;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEnd;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEndFromLight;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEndMultiplier;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_depthBlendDistance;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_cameraClippingDistance;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_glareFrontal;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_glareBehind;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_fresnelPow;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_noiseMode;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_noiseIntensity;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleUseGlobal;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleLocal;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityUseGlobal;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityLocal;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_tiltFactor;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_m_INTERNAL_DynamicOcclusionMode_Runtime;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_onWillCameraRenderThisBeam;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_m_OnBeamGeometryInitialized;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr__TrackChangesDuringPlaytime;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr__SortingLayerID;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr__SortingOrder;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutBegin;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutEnd;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_m_BeamGeom;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_m_CoPlaytimeUpdate;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_get_usedColorMode_Public_get_ColorMode_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideAndOutsideIntensity_Public_Void_byref_Single_byref_Single_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexPositionLocal_Public_get_Vector3_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexPositionGlobal_Public_get_Vector3_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_get_skewingLocalForwardDirectionNormalized_Public_get_Vector3_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_get_canHaveMeshSkewing_Public_get_Boolean_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_get_hasMeshSkewing_Public_get_Boolean_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalClippingPlane_Public_get_Vector4_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_get_isTilted_Public_get_Boolean_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastDistance_Public_get_Single_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRaycastGlobalVector_Private_Vector3_Vector3_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalForward_Public_get_Vector3_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalUp_Public_get_Vector3_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastGlobalRight_Public_get_Vector3_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Runtime_Public_get_DynamicOcclusion_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_meshStats_Public_get_String_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Private_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_ClampProperties_Private_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_ValidateProperties_Private_Void_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200088D RID: 2189
		public sealed class OnWillCameraRenderCB : MulticastDelegate
		{
			// Token: 0x0600D283 RID: 53891 RVA: 0x0034A17C File Offset: 0x0034837C
			// Note: this type is marked as 'beforefieldinit'.
			static OnWillCameraRenderCB()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "OnWillCameraRenderCB");
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664345);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664346);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664347);
				VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr, 100664348);
			}

			// Token: 0x0600D284 RID: 53892 RVA: 0x0034A1F0 File Offset: 0x003483F0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73303, XrefRangeEnd = 73307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnWillCameraRenderCB(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD.OnWillCameraRenderCB>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D285 RID: 53893 RVA: 0x0034A24C File Offset: 0x0034844C
			[CallerCount(0)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D286 RID: 53894 RVA: 0x0034A290 File Offset: 0x00348490
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D287 RID: 53895 RVA: 0x0034A304 File Offset: 0x00348504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D288 RID: 53896 RVA: 0x0006395B File Offset: 0x00061B5B
			public OnWillCameraRenderCB(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D289 RID: 53897 RVA: 0x00063964 File Offset: 0x00061B64
			public static implicit operator VolumetricLightBeamSD.OnWillCameraRenderCB(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeamSD.OnWillCameraRenderCB>(A_0);
			}

			// Token: 0x0600D28A RID: 53898 RVA: 0x0006396C File Offset: 0x00061B6C
			public static VolumetricLightBeamSD.OnWillCameraRenderCB operator +(VolumetricLightBeamSD.OnWillCameraRenderCB A_0, VolumetricLightBeamSD.OnWillCameraRenderCB A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeamSD.OnWillCameraRenderCB>();
			}

			// Token: 0x0600D28B RID: 53899 RVA: 0x0006397A File Offset: 0x00061B7A
			public static VolumetricLightBeamSD.OnWillCameraRenderCB operator -(VolumetricLightBeamSD.OnWillCameraRenderCB A_0, VolumetricLightBeamSD.OnWillCameraRenderCB A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeamSD.OnWillCameraRenderCB>();
				}
				return result;
			}

			// Token: 0x04008F7C RID: 36732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008F7D RID: 36733
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x04008F7E RID: 36734
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x04008F7F RID: 36735
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200088E RID: 2190
		public sealed class OnBeamGeometryInitialized : MulticastDelegate
		{
			// Token: 0x0600D28C RID: 53900 RVA: 0x0034A348 File Offset: 0x00348548
			// Note: this type is marked as 'beforefieldinit'.
			static OnBeamGeometryInitialized()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "OnBeamGeometryInitialized");
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664349);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664350);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664351);
				VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr, 100664352);
			}

			// Token: 0x0600D28D RID: 53901 RVA: 0x0034A3BC File Offset: 0x003485BC
			[CallerCount(1472)]
			[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnBeamGeometryInitialized(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD.OnBeamGeometryInitialized>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28E RID: 53902 RVA: 0x0034A418 File Offset: 0x00348618
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28F RID: 53903 RVA: 0x0034A44C File Offset: 0x0034864C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x0034A4B0 File Offset: 0x003486B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D291 RID: 53905 RVA: 0x0006398B File Offset: 0x00061B8B
			public OnBeamGeometryInitialized(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D292 RID: 53906 RVA: 0x00063994 File Offset: 0x00061B94
			public static implicit operator VolumetricLightBeamSD.OnBeamGeometryInitialized(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeamSD.OnBeamGeometryInitialized>(A_0);
			}

			// Token: 0x0600D293 RID: 53907 RVA: 0x0006399C File Offset: 0x00061B9C
			public static VolumetricLightBeamSD.OnBeamGeometryInitialized operator +(VolumetricLightBeamSD.OnBeamGeometryInitialized A_0, VolumetricLightBeamSD.OnBeamGeometryInitialized A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeamSD.OnBeamGeometryInitialized>();
			}

			// Token: 0x0600D294 RID: 53908 RVA: 0x000639AA File Offset: 0x00061BAA
			public static VolumetricLightBeamSD.OnBeamGeometryInitialized operator -(VolumetricLightBeamSD.OnBeamGeometryInitialized A_0, VolumetricLightBeamSD.OnBeamGeometryInitialized A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeamSD.OnBeamGeometryInitialized>();
				}
				return result;
			}

			// Token: 0x04008F80 RID: 36736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008F81 RID: 36737
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04008F82 RID: 36738
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04008F83 RID: 36739
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200088F RID: 2191
		[ObfuscatedName("VLB.VolumetricLightBeamSD+<CoPlaytimeUpdate>d__199")]
		public sealed class _CoPlaytimeUpdate_d__199 : Il2CppSystem.Object
		{
			// Token: 0x0600D295 RID: 53909 RVA: 0x0034A4F4 File Offset: 0x003486F4
			// Note: this type is marked as 'beforefieldinit'.
			static _CoPlaytimeUpdate_d__199()
			{
				Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeamSD>.NativeClassPtr, "<CoPlaytimeUpdate>d__199");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>1__state");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>2__current");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, "<>4__this");
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664353);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664354);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664355);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664356);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664357);
				VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr, 100664358);
			}

			// Token: 0x0600D296 RID: 53910 RVA: 0x0034A5D4 File Offset: 0x003487D4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoPlaytimeUpdate_d__199(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamSD._CoPlaytimeUpdate_d__199>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D297 RID: 53911 RVA: 0x0034A61C File Offset: 0x0034881C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D298 RID: 53912 RVA: 0x0034A650 File Offset: 0x00348850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73313, XrefRangeEnd = 73315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FF9 RID: 16377
			// (get) Token: 0x0600D299 RID: 53913 RVA: 0x0034A68C File Offset: 0x0034888C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D29A RID: 53914 RVA: 0x0034A6CC File Offset: 0x003488CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73315, XrefRangeEnd = 73320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FFA RID: 16378
			// (get) Token: 0x0600D29B RID: 53915 RVA: 0x0034A700 File Offset: 0x00348900
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D29C RID: 53916 RVA: 0x000639BB File Offset: 0x00061BBB
			public _CoPlaytimeUpdate_d__199(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF6 RID: 16374
			// (get) Token: 0x0600D29D RID: 53917 RVA: 0x0034A740 File Offset: 0x00348940
			// (set) Token: 0x0600D29E RID: 53918 RVA: 0x000639C4 File Offset: 0x00061BC4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FF7 RID: 16375
			// (get) Token: 0x0600D29F RID: 53919 RVA: 0x0034A768 File Offset: 0x00348968
			// (set) Token: 0x0600D2A0 RID: 53920 RVA: 0x000639DF File Offset: 0x00061BDF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF8 RID: 16376
			// (get) Token: 0x0600D2A1 RID: 53921 RVA: 0x0034A798 File Offset: 0x00348998
			// (set) Token: 0x0600D2A2 RID: 53922 RVA: 0x000639FE File Offset: 0x00061BFE
			public unsafe VolumetricLightBeamSD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamSD._CoPlaytimeUpdate_d__199.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F84 RID: 36740
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F85 RID: 36741
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F86 RID: 36742
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F87 RID: 36743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F88 RID: 36744
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F89 RID: 36745
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F8A RID: 36746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F8B RID: 36747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F8C RID: 36748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
