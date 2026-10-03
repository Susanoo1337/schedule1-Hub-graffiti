using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x02000085 RID: 133
	public class LiquidVolume : MonoBehaviour
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x0009A4C0 File Offset: 0x000986C0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolume()
		{
			Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr);
			LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "FORCE_GLES_COMPATIBILITY");
			LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "onPropertiesChanged");
			LiquidVolume.NativeFieldInfoPtr__topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_topology");
			LiquidVolume.NativeFieldInfoPtr__detail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_detail");
			LiquidVolume.NativeFieldInfoPtr__level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_level");
			LiquidVolume.NativeFieldInfoPtr__levelMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_levelMultiplier");
			LiquidVolume.NativeFieldInfoPtr__useLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_useLightColor");
			LiquidVolume.NativeFieldInfoPtr__useLightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_useLightDirection");
			LiquidVolume.NativeFieldInfoPtr__directionalLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_directionalLight");
			LiquidVolume.NativeFieldInfoPtr__liquidColor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidColor1");
			LiquidVolume.NativeFieldInfoPtr__liquidScale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidScale1");
			LiquidVolume.NativeFieldInfoPtr__liquidColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidColor2");
			LiquidVolume.NativeFieldInfoPtr__liquidScale2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidScale2");
			LiquidVolume.NativeFieldInfoPtr__alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_alpha");
			LiquidVolume.NativeFieldInfoPtr__emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_emissionColor");
			LiquidVolume.NativeFieldInfoPtr__ditherShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_ditherShadows");
			LiquidVolume.NativeFieldInfoPtr__murkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_murkiness");
			LiquidVolume.NativeFieldInfoPtr__turbulence1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_turbulence1");
			LiquidVolume.NativeFieldInfoPtr__turbulence2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_turbulence2");
			LiquidVolume.NativeFieldInfoPtr__frecuency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_frecuency");
			LiquidVolume.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_speed");
			LiquidVolume.NativeFieldInfoPtr__sparklingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_sparklingIntensity");
			LiquidVolume.NativeFieldInfoPtr__sparklingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_sparklingAmount");
			LiquidVolume.NativeFieldInfoPtr__deepObscurance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_deepObscurance");
			LiquidVolume.NativeFieldInfoPtr__foamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamColor");
			LiquidVolume.NativeFieldInfoPtr__foamScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamScale");
			LiquidVolume.NativeFieldInfoPtr__foamThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamThickness");
			LiquidVolume.NativeFieldInfoPtr__foamDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamDensity");
			LiquidVolume.NativeFieldInfoPtr__foamWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamWeight");
			LiquidVolume.NativeFieldInfoPtr__foamTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamTurbulence");
			LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamVisibleFromBottom");
			LiquidVolume.NativeFieldInfoPtr__smokeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeEnabled");
			LiquidVolume.NativeFieldInfoPtr__smokeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeColor");
			LiquidVolume.NativeFieldInfoPtr__smokeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeScale");
			LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeBaseObscurance");
			LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeHeightAtten");
			LiquidVolume.NativeFieldInfoPtr__smokeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeSpeed");
			LiquidVolume.NativeFieldInfoPtr__fixMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_fixMesh");
			LiquidVolume.NativeFieldInfoPtr_originalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "originalMesh");
			LiquidVolume.NativeFieldInfoPtr_originalPivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "originalPivotOffset");
			LiquidVolume.NativeFieldInfoPtr__pivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_pivotOffset");
			LiquidVolume.NativeFieldInfoPtr__limitVerticalRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_limitVerticalRange");
			LiquidVolume.NativeFieldInfoPtr__upperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_upperLimit");
			LiquidVolume.NativeFieldInfoPtr__lowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_lowerLimit");
			LiquidVolume.NativeFieldInfoPtr__subMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_subMeshIndex");
			LiquidVolume.NativeFieldInfoPtr__flaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_flaskMaterial");
			LiquidVolume.NativeFieldInfoPtr__flaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_flaskThickness");
			LiquidVolume.NativeFieldInfoPtr__glossinessInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_glossinessInternal");
			LiquidVolume.NativeFieldInfoPtr__scatteringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringEnabled");
			LiquidVolume.NativeFieldInfoPtr__scatteringPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringPower");
			LiquidVolume.NativeFieldInfoPtr__scatteringAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_scatteringAmount");
			LiquidVolume.NativeFieldInfoPtr__refractionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_refractionBlur");
			LiquidVolume.NativeFieldInfoPtr__blurIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_blurIntensity");
			LiquidVolume.NativeFieldInfoPtr__liquidRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_liquidRaySteps");
			LiquidVolume.NativeFieldInfoPtr__foamRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_foamRaySteps");
			LiquidVolume.NativeFieldInfoPtr__smokeRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_smokeRaySteps");
			LiquidVolume.NativeFieldInfoPtr__bumpMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpMap");
			LiquidVolume.NativeFieldInfoPtr__bumpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpStrength");
			LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpDistortionScale");
			LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_bumpDistortionOffset");
			LiquidVolume.NativeFieldInfoPtr__distortionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_distortionMap");
			LiquidVolume.NativeFieldInfoPtr__texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_texture");
			LiquidVolume.NativeFieldInfoPtr__textureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_textureScale");
			LiquidVolume.NativeFieldInfoPtr__textureOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_textureOffset");
			LiquidVolume.NativeFieldInfoPtr__distortionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_distortionAmount");
			LiquidVolume.NativeFieldInfoPtr__depthAware = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAware");
			LiquidVolume.NativeFieldInfoPtr__depthAwareOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareOffset");
			LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_irregularDepthDebug");
			LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareCustomPass");
			LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_depthAwareCustomPassDebug");
			LiquidVolume.NativeFieldInfoPtr__doubleSidedBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_doubleSidedBias");
			LiquidVolume.NativeFieldInfoPtr__backDepthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_backDepthBias");
			LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_rotationLevelCompensation");
			LiquidVolume.NativeFieldInfoPtr__ignoreGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_ignoreGravity");
			LiquidVolume.NativeFieldInfoPtr__reactToForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_reactToForces");
			LiquidVolume.NativeFieldInfoPtr__extentsScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_extentsScale");
			LiquidVolume.NativeFieldInfoPtr__noiseVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_noiseVariation");
			LiquidVolume.NativeFieldInfoPtr__allowViewFromInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_allowViewFromInside");
			LiquidVolume.NativeFieldInfoPtr__debugSpillPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_debugSpillPoint");
			LiquidVolume.NativeFieldInfoPtr__renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_renderQueue");
			LiquidVolume.NativeFieldInfoPtr__reflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_reflectionTexture");
			LiquidVolume.NativeFieldInfoPtr__physicsMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_physicsMass");
			LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "_physicsAngularDamp");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IGNORE_GRAVITY_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_NON_AABB_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_TOPOLOGY_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_REFRACTION_INDEX");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_NON_AABB");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IGNORE_GRAVITY");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_SPHERE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_CUBE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_CYLINDER");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_IRREGULAR");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_FP_RENDER_TEXTURE");
			LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SHADER_KEYWORD_USE_REFRACTION");
			LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "SPILL_POINT_GIZMO");
			LiquidVolume.NativeFieldInfoPtr_liqMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMat");
			LiquidVolume.NativeFieldInfoPtr_liqMatSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMatSimple");
			LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liqMatDefaultNoFlask");
			LiquidVolume.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mesh");
			LiquidVolume.NativeFieldInfoPtr_mr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mr");
			LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "mrSharedMaterials");
			LiquidVolume.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastPosition");
			LiquidVolume.NativeFieldInfoPtr_lastScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastScale");
			LiquidVolume.NativeFieldInfoPtr_lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastRotation");
			LiquidVolume.NativeFieldInfoPtr_shaderKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shaderKeywords");
			LiquidVolume.NativeFieldInfoPtr_camInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "camInside");
			LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastDistanceToCam");
			LiquidVolume.NativeFieldInfoPtr_currentDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "currentDetail");
			LiquidVolume.NativeFieldInfoPtr_turb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turb");
			LiquidVolume.NativeFieldInfoPtr_shaderTurb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shaderTurb");
			LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turbulenceSpeed");
			LiquidVolume.NativeFieldInfoPtr_murkinessSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "murkinessSpeed");
			LiquidVolume.NativeFieldInfoPtr_liquidLevelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liquidLevelPos");
			LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "shouldUpdateMaterialProperties");
			LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "currentNoiseVariation");
			LiquidVolume.NativeFieldInfoPtr_levelMultipled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "levelMultipled");
			LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "noise3DUnwrapped");
			LiquidVolume.NativeFieldInfoPtr_noise3DTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "noise3DTex");
			LiquidVolume.NativeFieldInfoPtr_colors3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "colors3D");
			LiquidVolume.NativeFieldInfoPtr_verticesUnsorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesUnsorted");
			LiquidVolume.NativeFieldInfoPtr_verticesSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesSorted");
			LiquidVolume.NativeFieldInfoPtr_rotatedVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "rotatedVertices");
			LiquidVolume.NativeFieldInfoPtr_verticesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verticesIndices");
			LiquidVolume.NativeFieldInfoPtr_volumeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "volumeRef");
			LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastLevelVolumeRef");
			LiquidVolume.NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "inertia");
			LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastAvgVelocity");
			LiquidVolume.NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "angularVelocity");
			LiquidVolume.NativeFieldInfoPtr_angularInertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "angularInertia");
			LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "turbulenceDueForces");
			LiquidVolume.NativeFieldInfoPtr_liquidRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "liquidRot");
			LiquidVolume.NativeFieldInfoPtr_prevThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "prevThickness");
			LiquidVolume.NativeFieldInfoPtr_spillPointGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "spillPointGizmo");
			LiquidVolume.NativeFieldInfoPtr_defaultContainerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "defaultContainerNames");
			LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "pointLightColorBuffer");
			LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "pointLightPositionBuffer");
			LiquidVolume.NativeFieldInfoPtr_lastPointLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "lastPointLightCount");
			LiquidVolume.NativeFieldInfoPtr_meshCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "meshCache");
			LiquidVolume.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "verts");
			LiquidVolume.NativeFieldInfoPtr_cutPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "cutPoints");
			LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "cutPlaneCenter");
			LiquidVolume.NativeFieldInfoPtr_fixedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "fixedMesh");
			LiquidVolume.NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664513);
			LiquidVolume.NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664514);
			LiquidVolume.NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664515);
			LiquidVolume.NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664516);
			LiquidVolume.NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664517);
			LiquidVolume.NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664518);
			LiquidVolume.NativeMethodInfoPtr_get_level_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664519);
			LiquidVolume.NativeMethodInfoPtr_set_level_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664520);
			LiquidVolume.NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664521);
			LiquidVolume.NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664522);
			LiquidVolume.NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664523);
			LiquidVolume.NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664524);
			LiquidVolume.NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664525);
			LiquidVolume.NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664526);
			LiquidVolume.NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664527);
			LiquidVolume.NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664528);
			LiquidVolume.NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664529);
			LiquidVolume.NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664530);
			LiquidVolume.NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664531);
			LiquidVolume.NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664532);
			LiquidVolume.NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664533);
			LiquidVolume.NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664534);
			LiquidVolume.NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664535);
			LiquidVolume.NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664536);
			LiquidVolume.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664537);
			LiquidVolume.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664538);
			LiquidVolume.NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664539);
			LiquidVolume.NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664540);
			LiquidVolume.NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664541);
			LiquidVolume.NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664542);
			LiquidVolume.NativeMethodInfoPtr_get_murkiness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664543);
			LiquidVolume.NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664544);
			LiquidVolume.NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664545);
			LiquidVolume.NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664546);
			LiquidVolume.NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664547);
			LiquidVolume.NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664548);
			LiquidVolume.NativeMethodInfoPtr_get_frecuency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664549);
			LiquidVolume.NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664550);
			LiquidVolume.NativeMethodInfoPtr_get_speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664551);
			LiquidVolume.NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664552);
			LiquidVolume.NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664553);
			LiquidVolume.NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664554);
			LiquidVolume.NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664555);
			LiquidVolume.NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664556);
			LiquidVolume.NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664557);
			LiquidVolume.NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664558);
			LiquidVolume.NativeMethodInfoPtr_get_foamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664559);
			LiquidVolume.NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664560);
			LiquidVolume.NativeMethodInfoPtr_get_foamScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664561);
			LiquidVolume.NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664562);
			LiquidVolume.NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664563);
			LiquidVolume.NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664564);
			LiquidVolume.NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664565);
			LiquidVolume.NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664566);
			LiquidVolume.NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664567);
			LiquidVolume.NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664568);
			LiquidVolume.NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664569);
			LiquidVolume.NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664570);
			LiquidVolume.NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664571);
			LiquidVolume.NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664572);
			LiquidVolume.NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664573);
			LiquidVolume.NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664574);
			LiquidVolume.NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664575);
			LiquidVolume.NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664576);
			LiquidVolume.NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664577);
			LiquidVolume.NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664578);
			LiquidVolume.NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664579);
			LiquidVolume.NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664580);
			LiquidVolume.NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664581);
			LiquidVolume.NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664582);
			LiquidVolume.NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664583);
			LiquidVolume.NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664584);
			LiquidVolume.NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664585);
			LiquidVolume.NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664586);
			LiquidVolume.NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664587);
			LiquidVolume.NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664588);
			LiquidVolume.NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664589);
			LiquidVolume.NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664590);
			LiquidVolume.NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664591);
			LiquidVolume.NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664592);
			LiquidVolume.NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664593);
			LiquidVolume.NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664594);
			LiquidVolume.NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664595);
			LiquidVolume.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664596);
			LiquidVolume.NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664597);
			LiquidVolume.NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664598);
			LiquidVolume.NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664599);
			LiquidVolume.NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664600);
			LiquidVolume.NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664601);
			LiquidVolume.NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664602);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664603);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664604);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664605);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664606);
			LiquidVolume.NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664607);
			LiquidVolume.NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664608);
			LiquidVolume.NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664609);
			LiquidVolume.NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664610);
			LiquidVolume.NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664611);
			LiquidVolume.NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664612);
			LiquidVolume.NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664613);
			LiquidVolume.NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664614);
			LiquidVolume.NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664615);
			LiquidVolume.NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664616);
			LiquidVolume.NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664617);
			LiquidVolume.NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664618);
			LiquidVolume.NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664619);
			LiquidVolume.NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664620);
			LiquidVolume.NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664621);
			LiquidVolume.NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664622);
			LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664623);
			LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664624);
			LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664625);
			LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664626);
			LiquidVolume.NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664627);
			LiquidVolume.NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664628);
			LiquidVolume.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664629);
			LiquidVolume.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664630);
			LiquidVolume.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664631);
			LiquidVolume.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664632);
			LiquidVolume.NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664633);
			LiquidVolume.NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664634);
			LiquidVolume.NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664635);
			LiquidVolume.NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664636);
			LiquidVolume.NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664637);
			LiquidVolume.NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664638);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664639);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664640);
			LiquidVolume.NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664641);
			LiquidVolume.NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664642);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664643);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664644);
			LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664645);
			LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664646);
			LiquidVolume.NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664647);
			LiquidVolume.NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664648);
			LiquidVolume.NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664649);
			LiquidVolume.NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664650);
			LiquidVolume.NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664651);
			LiquidVolume.NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664652);
			LiquidVolume.NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664653);
			LiquidVolume.NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664654);
			LiquidVolume.NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664655);
			LiquidVolume.NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664656);
			LiquidVolume.NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664657);
			LiquidVolume.NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664658);
			LiquidVolume.NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664659);
			LiquidVolume.NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664660);
			LiquidVolume.NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664661);
			LiquidVolume.NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664662);
			LiquidVolume.NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664663);
			LiquidVolume.NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664664);
			LiquidVolume.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664665);
			LiquidVolume.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664666);
			LiquidVolume.NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664667);
			LiquidVolume.NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664668);
			LiquidVolume.NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664669);
			LiquidVolume.NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664670);
			LiquidVolume.NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664671);
			LiquidVolume.NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664672);
			LiquidVolume.NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664673);
			LiquidVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664674);
			LiquidVolume.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664675);
			LiquidVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664676);
			LiquidVolume.NativeMethodInfoPtr_RenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664677);
			LiquidVolume.NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664678);
			LiquidVolume.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664679);
			LiquidVolume.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664680);
			LiquidVolume.NativeMethodInfoPtr_ClearMeshCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664681);
			LiquidVolume.NativeMethodInfoPtr_ReadVertices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664682);
			LiquidVolume.NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664683);
			LiquidVolume.NativeMethodInfoPtr_UpdateAnimations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664684);
			LiquidVolume.NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664685);
			LiquidVolume.NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664686);
			LiquidVolume.NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664687);
			LiquidVolume.NativeMethodInfoPtr_GetRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664688);
			LiquidVolume.NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664689);
			LiquidVolume.NativeMethodInfoPtr_RotateVertices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664690);
			LiquidVolume.NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664691);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664692);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664693);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664694);
			LiquidVolume.NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664695);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664696);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664697);
			LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664698);
			LiquidVolume.NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664699);
			LiquidVolume.NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664700);
			LiquidVolume.NativeMethodInfoPtr_CheckInsideOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664701);
			LiquidVolume.NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664702);
			LiquidVolume.NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664703);
			LiquidVolume.NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664704);
			LiquidVolume.NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664705);
			LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664706);
			LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664707);
			LiquidVolume.NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664708);
			LiquidVolume.NativeMethodInfoPtr_BakeRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664709);
			LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664710);
			LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664711);
			LiquidVolume.NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664712);
			LiquidVolume.NativeMethodInfoPtr_Redraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664713);
			LiquidVolume.NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664714);
			LiquidVolume.NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664715);
			LiquidVolume.NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664716);
			LiquidVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, 100664717);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0009C070 File Offset: 0x0009A270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75259, XrefRangeEnd = 75263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onPropertiesChanged(PropertiesChangedEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75263, XrefRangeEnd = 75267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onPropertiesChanged(PropertiesChangedEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0009C0F8 File Offset: 0x0009A2F8
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x0009C134 File Offset: 0x0009A334
		public unsafe TOPOLOGY topology
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75272, RefRangeEnd = 75274, XrefRangeStart = 75267, XrefRangeEnd = 75272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0009C174 File Offset: 0x0009A374
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0009C1B0 File Offset: 0x0009A3B0
		public unsafe DETAIL detail
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75274, XrefRangeEnd = 75279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x0009C22C File Offset: 0x0009A42C
		public unsafe float level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_level_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75284, RefRangeEnd = 75285, XrefRangeStart = 75279, XrefRangeEnd = 75284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_level_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0009C26C File Offset: 0x0009A46C
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0009C2A8 File Offset: 0x0009A4A8
		public unsafe float levelMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75285, XrefRangeEnd = 75290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0009C324 File Offset: 0x0009A524
		public unsafe bool useLightColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75290, XrefRangeEnd = 75295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0009C364 File Offset: 0x0009A564
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0009C3A0 File Offset: 0x0009A5A0
		public unsafe bool useLightDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75295, XrefRangeEnd = 75300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0009C3E0 File Offset: 0x0009A5E0
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0009C420 File Offset: 0x0009A620
		public unsafe Light directionalLight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75310, RefRangeEnd = 75311, XrefRangeStart = 75300, XrefRangeEnd = 75310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0009C464 File Offset: 0x0009A664
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0009C4A0 File Offset: 0x0009A6A0
		public unsafe Color liquidColor1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 75316, RefRangeEnd = 75321, XrefRangeStart = 75311, XrefRangeEnd = 75316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0009C4E0 File Offset: 0x0009A6E0
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x0009C51C File Offset: 0x0009A71C
		public unsafe float liquidScale1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75321, XrefRangeEnd = 75326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0009C55C File Offset: 0x0009A75C
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0009C598 File Offset: 0x0009A798
		public unsafe Color liquidColor2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 75331, RefRangeEnd = 75336, XrefRangeStart = 75326, XrefRangeEnd = 75331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0009C5D8 File Offset: 0x0009A7D8
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0009C614 File Offset: 0x0009A814
		public unsafe float liquidScale2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75336, XrefRangeEnd = 75341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0009C654 File Offset: 0x0009A854
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0009C690 File Offset: 0x0009A890
		public unsafe float alpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75341, XrefRangeEnd = 75349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0009C6D0 File Offset: 0x0009A8D0
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x0009C70C File Offset: 0x0009A90C
		public unsafe Color emissionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75349, XrefRangeEnd = 75354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0009C74C File Offset: 0x0009A94C
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0009C788 File Offset: 0x0009A988
		public unsafe bool ditherShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75354, XrefRangeEnd = 75359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0009C7C8 File Offset: 0x0009A9C8
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0009C804 File Offset: 0x0009AA04
		public unsafe float murkiness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_murkiness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75359, XrefRangeEnd = 75364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0009C844 File Offset: 0x0009AA44
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0009C880 File Offset: 0x0009AA80
		public unsafe float turbulence1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75364, XrefRangeEnd = 75369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0009C8C0 File Offset: 0x0009AAC0
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0009C8FC File Offset: 0x0009AAFC
		public unsafe float turbulence2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75369, XrefRangeEnd = 75374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0009C93C File Offset: 0x0009AB3C
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x0009C978 File Offset: 0x0009AB78
		public unsafe float frecuency
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_frecuency_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75374, XrefRangeEnd = 75379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0009C9B8 File Offset: 0x0009ABB8
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x0009C9F4 File Offset: 0x0009ABF4
		public unsafe float speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75379, XrefRangeEnd = 75384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0009CA34 File Offset: 0x0009AC34
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x0009CA70 File Offset: 0x0009AC70
		public unsafe float sparklingIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75384, XrefRangeEnd = 75389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0009CAB0 File Offset: 0x0009ACB0
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x0009CAEC File Offset: 0x0009ACEC
		public unsafe float sparklingAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75389, XrefRangeEnd = 75394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0009CB2C File Offset: 0x0009AD2C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0009CB68 File Offset: 0x0009AD68
		public unsafe float deepObscurance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75394, XrefRangeEnd = 75399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0009CBA8 File Offset: 0x0009ADA8
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0009CBE4 File Offset: 0x0009ADE4
		public unsafe Color foamColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75399, XrefRangeEnd = 75404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0009CC24 File Offset: 0x0009AE24
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x0009CC60 File Offset: 0x0009AE60
		public unsafe float foamScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75404, XrefRangeEnd = 75409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0009CCA0 File Offset: 0x0009AEA0
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0009CCDC File Offset: 0x0009AEDC
		public unsafe float foamThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75409, XrefRangeEnd = 75414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0009CD1C File Offset: 0x0009AF1C
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0009CD58 File Offset: 0x0009AF58
		public unsafe float foamDensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75414, XrefRangeEnd = 75419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0009CD98 File Offset: 0x0009AF98
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0009CDD4 File Offset: 0x0009AFD4
		public unsafe float foamWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75419, XrefRangeEnd = 75424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0009CE14 File Offset: 0x0009B014
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0009CE50 File Offset: 0x0009B050
		public unsafe float foamTurbulence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75424, XrefRangeEnd = 75429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0009CE90 File Offset: 0x0009B090
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0009CECC File Offset: 0x0009B0CC
		public unsafe bool foamVisibleFromBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75429, XrefRangeEnd = 75434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0009CF0C File Offset: 0x0009B10C
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0009CF48 File Offset: 0x0009B148
		public unsafe bool smokeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75434, XrefRangeEnd = 75439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0009CF88 File Offset: 0x0009B188
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0009CFC4 File Offset: 0x0009B1C4
		public unsafe Color smokeColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75439, XrefRangeEnd = 75444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0009D004 File Offset: 0x0009B204
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0009D040 File Offset: 0x0009B240
		public unsafe float smokeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75444, XrefRangeEnd = 75449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0009D080 File Offset: 0x0009B280
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x0009D0BC File Offset: 0x0009B2BC
		public unsafe float smokeBaseObscurance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75449, XrefRangeEnd = 75454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0009D0FC File Offset: 0x0009B2FC
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x0009D138 File Offset: 0x0009B338
		public unsafe float smokeHeightAtten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75454, XrefRangeEnd = 75459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0009D178 File Offset: 0x0009B378
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0009D1B4 File Offset: 0x0009B3B4
		public unsafe float smokeSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75459, XrefRangeEnd = 75464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0009D1F4 File Offset: 0x0009B3F4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0009D230 File Offset: 0x0009B430
		public unsafe bool fixMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75464, XrefRangeEnd = 75469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0009D270 File Offset: 0x0009B470
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0009D2AC File Offset: 0x0009B4AC
		public unsafe Vector3 pivotOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75469, XrefRangeEnd = 75474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0009D2EC File Offset: 0x0009B4EC
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0009D328 File Offset: 0x0009B528
		public unsafe bool limitVerticalRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75474, XrefRangeEnd = 75479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0009D368 File Offset: 0x0009B568
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x0009D3A4 File Offset: 0x0009B5A4
		public unsafe float upperLimit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75481, XrefRangeEnd = 75486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0009D3E4 File Offset: 0x0009B5E4
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x0009D420 File Offset: 0x0009B620
		public unsafe float lowerLimit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75486, RefRangeEnd = 75489, XrefRangeStart = 75486, XrefRangeEnd = 75486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75489, XrefRangeEnd = 75494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0009D460 File Offset: 0x0009B660
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0009D49C File Offset: 0x0009B69C
		public unsafe int subMeshIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75494, XrefRangeEnd = 75499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0009D4DC File Offset: 0x0009B6DC
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0009D51C File Offset: 0x0009B71C
		public unsafe Material flaskMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75499, XrefRangeEnd = 75509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0009D560 File Offset: 0x0009B760
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0009D59C File Offset: 0x0009B79C
		public unsafe float flaskThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75509, XrefRangeEnd = 75514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0009D5DC File Offset: 0x0009B7DC
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x0009D618 File Offset: 0x0009B818
		public unsafe float glossinessInternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75514, XrefRangeEnd = 75519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0009D658 File Offset: 0x0009B858
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x0009D694 File Offset: 0x0009B894
		public unsafe bool scatteringEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75519, XrefRangeEnd = 75524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0009D6D4 File Offset: 0x0009B8D4
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0009D710 File Offset: 0x0009B910
		public unsafe int scatteringPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75524, XrefRangeEnd = 75529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0009D750 File Offset: 0x0009B950
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0009D78C File Offset: 0x0009B98C
		public unsafe float scatteringAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75529, XrefRangeEnd = 75534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0009D7CC File Offset: 0x0009B9CC
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0009D808 File Offset: 0x0009BA08
		public unsafe bool refractionBlur
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75534, XrefRangeEnd = 75539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0009D848 File Offset: 0x0009BA48
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0009D884 File Offset: 0x0009BA84
		public unsafe float blurIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75539, XrefRangeEnd = 75547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0009D8C4 File Offset: 0x0009BAC4
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0009D900 File Offset: 0x0009BB00
		public unsafe int liquidRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75547, XrefRangeEnd = 75552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0009D940 File Offset: 0x0009BB40
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0009D97C File Offset: 0x0009BB7C
		public unsafe int foamRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75552, XrefRangeEnd = 75557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0009D9BC File Offset: 0x0009BBBC
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x0009D9F8 File Offset: 0x0009BBF8
		public unsafe int smokeRaySteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75557, XrefRangeEnd = 75562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0009DA38 File Offset: 0x0009BC38
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x0009DA78 File Offset: 0x0009BC78
		public unsafe Texture2D bumpMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75562, XrefRangeEnd = 75572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0009DABC File Offset: 0x0009BCBC
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x0009DAF8 File Offset: 0x0009BCF8
		public unsafe float bumpStrength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75572, XrefRangeEnd = 75577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0009DB38 File Offset: 0x0009BD38
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x0009DB74 File Offset: 0x0009BD74
		public unsafe float bumpDistortionScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75577, XrefRangeEnd = 75582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0009DBB4 File Offset: 0x0009BDB4
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0009DBF0 File Offset: 0x0009BDF0
		public unsafe Vector2 bumpDistortionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75582, XrefRangeEnd = 75587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0009DC30 File Offset: 0x0009BE30
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0009DC70 File Offset: 0x0009BE70
		public unsafe Texture2D distortionMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75587, XrefRangeEnd = 75597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0009DCB4 File Offset: 0x0009BEB4
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public unsafe Texture2D texture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75597, XrefRangeEnd = 75607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0009DD38 File Offset: 0x0009BF38
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x0009DD74 File Offset: 0x0009BF74
		public unsafe Vector2 textureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75607, XrefRangeEnd = 75612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0009DDB4 File Offset: 0x0009BFB4
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0009DDF0 File Offset: 0x0009BFF0
		public unsafe Vector2 textureOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75612, XrefRangeEnd = 75617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0009DE30 File Offset: 0x0009C030
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0009DE6C File Offset: 0x0009C06C
		public unsafe float distortionAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75617, XrefRangeEnd = 75622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0009DEAC File Offset: 0x0009C0AC
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0009DEE8 File Offset: 0x0009C0E8
		public unsafe bool depthAware
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75622, XrefRangeEnd = 75627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0009DF28 File Offset: 0x0009C128
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0009DF64 File Offset: 0x0009C164
		public unsafe float depthAwareOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75627, XrefRangeEnd = 75632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0009DFA4 File Offset: 0x0009C1A4
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x0009DFE0 File Offset: 0x0009C1E0
		public unsafe bool irregularDepthDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75632, XrefRangeEnd = 75637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0009E020 File Offset: 0x0009C220
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x0009E05C File Offset: 0x0009C25C
		public unsafe bool depthAwareCustomPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75637, XrefRangeEnd = 75642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0009E09C File Offset: 0x0009C29C
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x0009E0D8 File Offset: 0x0009C2D8
		public unsafe bool depthAwareCustomPassDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75642, XrefRangeEnd = 75647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0009E118 File Offset: 0x0009C318
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0009E154 File Offset: 0x0009C354
		public unsafe float doubleSidedBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75647, XrefRangeEnd = 75652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0009E194 File Offset: 0x0009C394
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
		public unsafe float backDepthBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75652, XrefRangeEnd = 75657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0009E210 File Offset: 0x0009C410
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0009E24C File Offset: 0x0009C44C
		public unsafe LEVEL_COMPENSATION rotationLevelCompensation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75657, XrefRangeEnd = 75662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0009E28C File Offset: 0x0009C48C
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0009E2C8 File Offset: 0x0009C4C8
		public unsafe bool ignoreGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75662, XrefRangeEnd = 75667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0009E308 File Offset: 0x0009C508
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0009E344 File Offset: 0x0009C544
		public unsafe bool reactToForces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75667, XrefRangeEnd = 75672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0009E384 File Offset: 0x0009C584
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
		public unsafe Vector3 extentsScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75672, XrefRangeEnd = 75677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0009E400 File Offset: 0x0009C600
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0009E43C File Offset: 0x0009C63C
		public unsafe int noiseVariation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75677, XrefRangeEnd = 75682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0009E47C File Offset: 0x0009C67C
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0009E4B8 File Offset: 0x0009C6B8
		public unsafe bool allowViewFromInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75682, XrefRangeEnd = 75683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0009E4F8 File Offset: 0x0009C6F8
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0009E534 File Offset: 0x0009C734
		public unsafe bool debugSpillPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0009E574 File Offset: 0x0009C774
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0009E5B0 File Offset: 0x0009C7B0
		public unsafe int renderQueue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75683, XrefRangeEnd = 75688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0009E5F0 File Offset: 0x0009C7F0
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0009E630 File Offset: 0x0009C830
		public unsafe Cubemap reflectionTexture
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 75688, RefRangeEnd = 75698, XrefRangeStart = 75688, XrefRangeEnd = 75688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75698, XrefRangeEnd = 75708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0009E674 File Offset: 0x0009C874
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		public unsafe float physicsMass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75708, XrefRangeEnd = 75713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0009E6F0 File Offset: 0x0009C8F0
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0009E72C File Offset: 0x0009C92C
		public unsafe float physicsAngularDamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75713, XrefRangeEnd = 75718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0009E76C File Offset: 0x0009C96C
		public unsafe static bool useFPRenderTextures
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0009E79C File Offset: 0x0009C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75718, XrefRangeEnd = 75739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0009E7D0 File Offset: 0x0009C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75739, XrefRangeEnd = 75776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0009E804 File Offset: 0x0009CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75776, XrefRangeEnd = 75812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0009E838 File Offset: 0x0009CA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75882, RefRangeEnd = 75883, XrefRangeStart = 75812, XrefRangeEnd = 75882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0009E86C File Offset: 0x0009CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75883, XrefRangeEnd = 75884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75884, XrefRangeEnd = 75894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0009E8D4 File Offset: 0x0009CAD4
		[CallerCount(0)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0009E908 File Offset: 0x0009CB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75902, RefRangeEnd = 75903, XrefRangeStart = 75894, XrefRangeEnd = 75902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ClearMeshCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0009E93C File Offset: 0x0009CB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75926, RefRangeEnd = 75927, XrefRangeStart = 75903, XrefRangeEnd = 75926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ReadVertices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0009E970 File Offset: 0x0009CB70
		[CallerCount(0)]
		public unsafe int vertexComparer(Vector3 v0, Vector3 v1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0009E9C8 File Offset: 0x0009CBC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75996, RefRangeEnd = 75998, XrefRangeStart = 75927, XrefRangeEnd = 75996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateAnimations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0009E9FC File Offset: 0x0009CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75998, XrefRangeEnd = 76003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0009EA30 File Offset: 0x0009CC30
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 76287, RefRangeEnd = 76368, XrefRangeStart = 76003, XrefRangeEnd = 76287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialPropertiesNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0009EA64 File Offset: 0x0009CC64
		[CallerCount(0)]
		public unsafe Color ApplyGlobalAlpha(Color originalColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originalColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0009EAB0 File Offset: 0x0009CCB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76385, RefRangeEnd = 76387, XrefRangeStart = 76368, XrefRangeEnd = 76385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76549, RefRangeEnd = 76551, XrefRangeStart = 76387, XrefRangeEnd = 76549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLevels(bool updateShaderKeywords = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateShaderKeywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0009EB24 File Offset: 0x0009CD24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76572, RefRangeEnd = 76574, XrefRangeStart = 76551, XrefRangeEnd = 76572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RotateVertices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0009EB58 File Offset: 0x0009CD58
		[CallerCount(0)]
		public unsafe float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 zeroPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0009EBCC File Offset: 0x0009CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76574, XrefRangeEnd = 76577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelFast(float level01, float yExtent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level01;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0009EC24 File Offset: 0x0009CE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76577, XrefRangeEnd = 76578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeWSFast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0009EC60 File Offset: 0x0009CE60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76584, RefRangeEnd = 76588, XrefRangeStart = 76578, XrefRangeEnd = 76584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelWSFast(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0009ECAC File Offset: 0x0009CEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76588, XrefRangeEnd = 76589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ClampVertexToSlicePlane(Vector3 p, Vector3 q, float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0009ED14 File Offset: 0x0009CF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76589, XrefRangeEnd = 76592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevel(float level01, float yExtent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level01;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0009ED6C File Offset: 0x0009CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76592, XrefRangeEnd = 76593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeWS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0009EDA8 File Offset: 0x0009CFA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76714, RefRangeEnd = 76718, XrefRangeStart = 76593, XrefRangeEnd = 76714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMeshVolumeUnderLevelWS(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0009EDF4 File Offset: 0x0009CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76718, XrefRangeEnd = 76720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PolygonSortOnPlane(Vector3 p1, Vector3 p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0009EE4C File Offset: 0x0009D04C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76730, RefRangeEnd = 76732, XrefRangeStart = 76720, XrefRangeEnd = 76730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTurbulence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0009EE80 File Offset: 0x0009D080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76762, RefRangeEnd = 76764, XrefRangeStart = 76732, XrefRangeEnd = 76762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsideOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CheckInsideOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0009EEB4 File Offset: 0x0009D0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76764, XrefRangeEnd = 76767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInAABB(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0009EF00 File Offset: 0x0009D100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76767, XrefRangeEnd = 76772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCylinder(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0009EF4C File Offset: 0x0009D14C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76807, RefRangeEnd = 76809, XrefRangeStart = 76772, XrefRangeEnd = 76807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInsideOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0009EF80 File Offset: 0x0009D180
		public unsafe float liquidSurfaceYPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0009EFBC File Offset: 0x0009D1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76809, XrefRangeEnd = 76810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSpillPoint(out Vector3 spillPosition, float apertureStart = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &spillPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apertureStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0009F014 File Offset: 0x0009D214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76830, RefRangeEnd = 76832, XrefRangeStart = 76810, XrefRangeEnd = 76830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSpillPoint(out Vector3 spillPosition, out float spillAmount, float apertureStart = 1f, LEVEL_COMPENSATION rotationCompensation = LEVEL_COMPENSATION.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &spillPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spillAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apertureStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationCompensation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0009F088 File Offset: 0x0009D288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76882, RefRangeEnd = 76883, XrefRangeStart = 76832, XrefRangeEnd = 76882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpillPointGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0009F0BC File Offset: 0x0009D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76883, XrefRangeEnd = 76934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_BakeRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0009F0F0 File Offset: 0x0009D2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76934, XrefRangeEnd = 76937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CenterPivot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0009F124 File Offset: 0x0009D324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76968, RefRangeEnd = 76970, XrefRangeStart = 76937, XrefRangeEnd = 76968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CenterPivot(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0009F164 File Offset: 0x0009D364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76981, RefRangeEnd = 76984, XrefRangeStart = 76970, XrefRangeEnd = 76981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshMeshAndCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0009F198 File Offset: 0x0009D398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_Redraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0009F1CC File Offset: 0x0009D3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77020, RefRangeEnd = 77021, XrefRangeStart = 76984, XrefRangeEnd = 77020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckMeshDisplacement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0009F200 File Offset: 0x0009D400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77037, RefRangeEnd = 77039, XrefRangeStart = 77021, XrefRangeEnd = 77037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreOriginalMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0009F234 File Offset: 0x0009D434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77039, XrefRangeEnd = 77047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(LiquidVolume lv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0009F278 File Offset: 0x0009D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77047, XrefRangeEnd = 77064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00006544 File Offset: 0x00004744
		public LiquidVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0009F2B4 File Offset: 0x0009D4B4
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0000654D File Offset: 0x0000474D
		public unsafe static bool FORCE_GLES_COMPATIBILITY
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY, (void*)(&value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0009F2D0 File Offset: 0x0009D4D0
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0000655B File Offset: 0x0000475B
		public unsafe PropertiesChangedEvent onPropertiesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_onPropertiesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0009F300 File Offset: 0x0009D500
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0000657A File Offset: 0x0000477A
		public unsafe TOPOLOGY _topology
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__topology);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__topology)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0009F328 File Offset: 0x0009D528
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00006595 File Offset: 0x00004795
		public unsafe DETAIL _detail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__detail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__detail)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0009F350 File Offset: 0x0009D550
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000065B0 File Offset: 0x000047B0
		public unsafe float _level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__level)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0009F378 File Offset: 0x0009D578
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000065CB File Offset: 0x000047CB
		public unsafe float _levelMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__levelMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__levelMultiplier)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0009F3A0 File Offset: 0x0009D5A0
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000065E6 File Offset: 0x000047E6
		public unsafe bool _useLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightColor)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00006601 File Offset: 0x00004801
		public unsafe bool _useLightDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__useLightDirection)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0009F3F0 File Offset: 0x0009D5F0
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0000661C File Offset: 0x0000481C
		public unsafe Light _directionalLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__directionalLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__directionalLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0009F420 File Offset: 0x0009D620
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000663B File Offset: 0x0000483B
		public unsafe Color _liquidColor1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor1)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0009F448 File Offset: 0x0009D648
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00006656 File Offset: 0x00004856
		public unsafe float _liquidScale1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale1)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0009F470 File Offset: 0x0009D670
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00006671 File Offset: 0x00004871
		public unsafe Color _liquidColor2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidColor2)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0009F498 File Offset: 0x0009D698
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0000668C File Offset: 0x0000488C
		public unsafe float _liquidScale2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidScale2)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0009F4C0 File Offset: 0x0009D6C0
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000066A7 File Offset: 0x000048A7
		public unsafe float _alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__alpha)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0009F4E8 File Offset: 0x0009D6E8
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000066C2 File Offset: 0x000048C2
		public unsafe Color _emissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__emissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__emissionColor)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0009F510 File Offset: 0x0009D710
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000066DD File Offset: 0x000048DD
		public unsafe bool _ditherShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ditherShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ditherShadows)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0009F538 File Offset: 0x0009D738
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000066F8 File Offset: 0x000048F8
		public unsafe float _murkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__murkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__murkiness)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0009F560 File Offset: 0x0009D760
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00006713 File Offset: 0x00004913
		public unsafe float _turbulence1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence1)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0009F588 File Offset: 0x0009D788
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000672E File Offset: 0x0000492E
		public unsafe float _turbulence2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__turbulence2)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0009F5B0 File Offset: 0x0009D7B0
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00006749 File Offset: 0x00004949
		public unsafe float _frecuency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__frecuency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__frecuency)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00006764 File Offset: 0x00004964
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0009F600 File Offset: 0x0009D800
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0000677F File Offset: 0x0000497F
		public unsafe float _sparklingIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingIntensity)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0009F628 File Offset: 0x0009D828
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0000679A File Offset: 0x0000499A
		public unsafe float _sparklingAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__sparklingAmount)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0009F650 File Offset: 0x0009D850
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x000067B5 File Offset: 0x000049B5
		public unsafe float _deepObscurance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__deepObscurance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__deepObscurance)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0009F678 File Offset: 0x0009D878
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000067D0 File Offset: 0x000049D0
		public unsafe Color _foamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamColor)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0009F6A0 File Offset: 0x0009D8A0
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000067EB File Offset: 0x000049EB
		public unsafe float _foamScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamScale)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0009F6C8 File Offset: 0x0009D8C8
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00006806 File Offset: 0x00004A06
		public unsafe float _foamThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamThickness)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0009F6F0 File Offset: 0x0009D8F0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00006821 File Offset: 0x00004A21
		public unsafe float _foamDensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamDensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamDensity)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0009F718 File Offset: 0x0009D918
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0000683C File Offset: 0x00004A3C
		public unsafe float _foamWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamWeight)) = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0009F740 File Offset: 0x0009D940
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00006857 File Offset: 0x00004A57
		public unsafe float _foamTurbulence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamTurbulence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamTurbulence)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0009F768 File Offset: 0x0009D968
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00006872 File Offset: 0x00004A72
		public unsafe bool _foamVisibleFromBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamVisibleFromBottom)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0009F790 File Offset: 0x0009D990
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0000688D File Offset: 0x00004A8D
		public unsafe bool _smokeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeEnabled)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0009F7B8 File Offset: 0x0009D9B8
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000068A8 File Offset: 0x00004AA8
		public unsafe Color _smokeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeColor)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0009F7E0 File Offset: 0x0009D9E0
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000068C3 File Offset: 0x00004AC3
		public unsafe float _smokeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeScale)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0009F808 File Offset: 0x0009DA08
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000068DE File Offset: 0x00004ADE
		public unsafe float _smokeBaseObscurance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeBaseObscurance)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0009F830 File Offset: 0x0009DA30
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000068F9 File Offset: 0x00004AF9
		public unsafe float _smokeHeightAtten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeHeightAtten)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0009F858 File Offset: 0x0009DA58
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00006914 File Offset: 0x00004B14
		public unsafe float _smokeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeSpeed)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0009F880 File Offset: 0x0009DA80
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0000692F File Offset: 0x00004B2F
		public unsafe bool _fixMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__fixMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__fixMesh)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0009F8A8 File Offset: 0x0009DAA8
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0000694A File Offset: 0x00004B4A
		public unsafe Mesh originalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0009F8D8 File Offset: 0x0009DAD8
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00006969 File Offset: 0x00004B69
		public unsafe Vector3 originalPivotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalPivotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_originalPivotOffset)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0009F900 File Offset: 0x0009DB00
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00006984 File Offset: 0x00004B84
		public unsafe Vector3 _pivotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__pivotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__pivotOffset)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0009F928 File Offset: 0x0009DB28
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0000699F File Offset: 0x00004B9F
		public unsafe bool _limitVerticalRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__limitVerticalRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__limitVerticalRange)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0009F950 File Offset: 0x0009DB50
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000069BA File Offset: 0x00004BBA
		public unsafe float _upperLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__upperLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__upperLimit)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0009F978 File Offset: 0x0009DB78
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000069D5 File Offset: 0x00004BD5
		public unsafe float _lowerLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__lowerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__lowerLimit)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0009F9A0 File Offset: 0x0009DBA0
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000069F0 File Offset: 0x00004BF0
		public unsafe int _subMeshIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__subMeshIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__subMeshIndex)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0009F9C8 File Offset: 0x0009DBC8
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00006A0B File Offset: 0x00004C0B
		public unsafe Material _flaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0009F9F8 File Offset: 0x0009DBF8
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00006A2A File Offset: 0x00004C2A
		public unsafe float _flaskThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__flaskThickness)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0009FA20 File Offset: 0x0009DC20
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00006A45 File Offset: 0x00004C45
		public unsafe float _glossinessInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__glossinessInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__glossinessInternal)) = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0009FA48 File Offset: 0x0009DC48
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00006A60 File Offset: 0x00004C60
		public unsafe bool _scatteringEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringEnabled)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0009FA70 File Offset: 0x0009DC70
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00006A7B File Offset: 0x00004C7B
		public unsafe int _scatteringPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringPower)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0009FA98 File Offset: 0x0009DC98
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00006A96 File Offset: 0x00004C96
		public unsafe float _scatteringAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__scatteringAmount)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0009FAC0 File Offset: 0x0009DCC0
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00006AB1 File Offset: 0x00004CB1
		public unsafe bool _refractionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__refractionBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__refractionBlur)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00006ACC File Offset: 0x00004CCC
		public unsafe float _blurIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__blurIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__blurIntensity)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0009FB10 File Offset: 0x0009DD10
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00006AE7 File Offset: 0x00004CE7
		public unsafe int _liquidRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__liquidRaySteps)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0009FB38 File Offset: 0x0009DD38
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00006B02 File Offset: 0x00004D02
		public unsafe int _foamRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__foamRaySteps)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0009FB60 File Offset: 0x0009DD60
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00006B1D File Offset: 0x00004D1D
		public unsafe int _smokeRaySteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeRaySteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__smokeRaySteps)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0009FB88 File Offset: 0x0009DD88
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00006B38 File Offset: 0x00004D38
		public unsafe Texture2D _bumpMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0009FBB8 File Offset: 0x0009DDB8
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00006B57 File Offset: 0x00004D57
		public unsafe float _bumpStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpStrength)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0009FBE0 File Offset: 0x0009DDE0
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006B72 File Offset: 0x00004D72
		public unsafe float _bumpDistortionScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionScale)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0009FC08 File Offset: 0x0009DE08
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00006B8D File Offset: 0x00004D8D
		public unsafe Vector2 _bumpDistortionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__bumpDistortionOffset)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0009FC30 File Offset: 0x0009DE30
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public unsafe Texture2D _distortionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0009FC60 File Offset: 0x0009DE60
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00006BC7 File Offset: 0x00004DC7
		public unsafe Texture2D _texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0009FC90 File Offset: 0x0009DE90
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00006BE6 File Offset: 0x00004DE6
		public unsafe Vector2 _textureScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureScale)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006C01 File Offset: 0x00004E01
		public unsafe Vector2 _textureOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__textureOffset)) = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0009FCE0 File Offset: 0x0009DEE0
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006C1C File Offset: 0x00004E1C
		public unsafe float _distortionAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__distortionAmount)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0009FD08 File Offset: 0x0009DF08
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00006C37 File Offset: 0x00004E37
		public unsafe bool _depthAware
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAware);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAware)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0009FD30 File Offset: 0x0009DF30
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006C52 File Offset: 0x00004E52
		public unsafe float _depthAwareOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareOffset)) = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0009FD58 File Offset: 0x0009DF58
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00006C6D File Offset: 0x00004E6D
		public unsafe bool _irregularDepthDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__irregularDepthDebug)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0009FD80 File Offset: 0x0009DF80
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00006C88 File Offset: 0x00004E88
		public unsafe bool _depthAwareCustomPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPass)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0009FDA8 File Offset: 0x0009DFA8
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00006CA3 File Offset: 0x00004EA3
		public unsafe bool _depthAwareCustomPassDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__depthAwareCustomPassDebug)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0009FDD0 File Offset: 0x0009DFD0
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00006CBE File Offset: 0x00004EBE
		public unsafe float _doubleSidedBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__doubleSidedBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__doubleSidedBias)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0009FDF8 File Offset: 0x0009DFF8
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00006CD9 File Offset: 0x00004ED9
		public unsafe float _backDepthBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__backDepthBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__backDepthBias)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0009FE20 File Offset: 0x0009E020
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public unsafe LEVEL_COMPENSATION _rotationLevelCompensation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__rotationLevelCompensation)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0009FE48 File Offset: 0x0009E048
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00006D0F File Offset: 0x00004F0F
		public unsafe bool _ignoreGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ignoreGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__ignoreGravity)) = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0009FE70 File Offset: 0x0009E070
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00006D2A File Offset: 0x00004F2A
		public unsafe bool _reactToForces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reactToForces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reactToForces)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0009FE98 File Offset: 0x0009E098
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00006D45 File Offset: 0x00004F45
		public unsafe Vector3 _extentsScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__extentsScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__extentsScale)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00006D60 File Offset: 0x00004F60
		public unsafe int _noiseVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__noiseVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__noiseVariation)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0009FEE8 File Offset: 0x0009E0E8
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00006D7B File Offset: 0x00004F7B
		public unsafe bool _allowViewFromInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__allowViewFromInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__allowViewFromInside)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0009FF10 File Offset: 0x0009E110
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00006D96 File Offset: 0x00004F96
		public unsafe bool _debugSpillPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__debugSpillPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__debugSpillPoint)) = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0009FF38 File Offset: 0x0009E138
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00006DB1 File Offset: 0x00004FB1
		public unsafe int _renderQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__renderQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__renderQueue)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0009FF60 File Offset: 0x0009E160
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00006DCC File Offset: 0x00004FCC
		public unsafe Cubemap _reflectionTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reflectionTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__reflectionTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0009FF90 File Offset: 0x0009E190
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00006DEB File Offset: 0x00004FEB
		public unsafe float _physicsMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsMass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsMass)) = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0009FFB8 File Offset: 0x0009E1B8
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00006E06 File Offset: 0x00005006
		public unsafe float _physicsAngularDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr__physicsAngularDamp)) = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0009FFE0 File Offset: 0x0009E1E0
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00006E21 File Offset: 0x00005021
		public unsafe static int SHADER_KEYWORD_DEPTH_AWARE_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0009FFFC File Offset: 0x0009E1FC
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00006E2F File Offset: 0x0000502F
		public unsafe static int SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000A0018 File Offset: 0x0009E218
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00006E3D File Offset: 0x0000503D
		public unsafe static int SHADER_KEYWORD_IGNORE_GRAVITY_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000A0034 File Offset: 0x0009E234
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00006E4B File Offset: 0x0000504B
		public unsafe static int SHADER_KEYWORD_NON_AABB_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000A0050 File Offset: 0x0009E250
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00006E59 File Offset: 0x00005059
		public unsafe static int SHADER_KEYWORD_TOPOLOGY_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000A006C File Offset: 0x0009E26C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00006E67 File Offset: 0x00005067
		public unsafe static int SHADER_KEYWORD_REFRACTION_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX, (void*)(&value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000A0088 File Offset: 0x0009E288
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00006E75 File Offset: 0x00005075
		public unsafe static string SHADER_KEYWORD_DEPTH_AWARE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000A00A8 File Offset: 0x0009E2A8
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00006E87 File Offset: 0x00005087
		public unsafe static string SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000A00C8 File Offset: 0x0009E2C8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00006E99 File Offset: 0x00005099
		public unsafe static string SHADER_KEYWORD_NON_AABB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000A00E8 File Offset: 0x0009E2E8
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00006EAB File Offset: 0x000050AB
		public unsafe static string SHADER_KEYWORD_IGNORE_GRAVITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000A0108 File Offset: 0x0009E308
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00006EBD File Offset: 0x000050BD
		public unsafe static string SHADER_KEYWORD_SPHERE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000A0128 File Offset: 0x0009E328
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00006ECF File Offset: 0x000050CF
		public unsafe static string SHADER_KEYWORD_CUBE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CUBE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000A0148 File Offset: 0x0009E348
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00006EE1 File Offset: 0x000050E1
		public unsafe static string SHADER_KEYWORD_CYLINDER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000A0168 File Offset: 0x0009E368
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00006EF3 File Offset: 0x000050F3
		public unsafe static string SHADER_KEYWORD_IRREGULAR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000A0188 File Offset: 0x0009E388
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00006F05 File Offset: 0x00005105
		public unsafe static string SHADER_KEYWORD_FP_RENDER_TEXTURE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x000A01A8 File Offset: 0x0009E3A8
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00006F17 File Offset: 0x00005117
		public unsafe static string SHADER_KEYWORD_USE_REFRACTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000A01C8 File Offset: 0x0009E3C8
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00006F29 File Offset: 0x00005129
		public unsafe static string SPILL_POINT_GIZMO
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_SPILL_POINT_GIZMO, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000A01E8 File Offset: 0x0009E3E8
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00006F3B File Offset: 0x0000513B
		public unsafe Material liqMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000A0218 File Offset: 0x0009E418
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00006F5A File Offset: 0x0000515A
		public unsafe Material liqMatSimple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatSimple);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatSimple), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000A0248 File Offset: 0x0009E448
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00006F79 File Offset: 0x00005179
		public unsafe Material liqMatDefaultNoFlask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liqMatDefaultNoFlask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000A0278 File Offset: 0x0009E478
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00006F98 File Offset: 0x00005198
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000A02A8 File Offset: 0x0009E4A8
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00006FB7 File Offset: 0x000051B7
		public unsafe Renderer mr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_mr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00006FD6 File Offset: 0x000051D6
		public unsafe static List<Material> mrSharedMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_mrSharedMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000A0300 File Offset: 0x0009E500
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00006FE8 File Offset: 0x000051E8
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000A0328 File Offset: 0x0009E528
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00007003 File Offset: 0x00005203
		public unsafe Vector3 lastScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastScale)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000A0350 File Offset: 0x0009E550
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0000701E File Offset: 0x0000521E
		public unsafe Quaternion lastRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastRotation)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000A0378 File Offset: 0x0009E578
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00007039 File Offset: 0x00005239
		public unsafe Il2CppStringArray shaderKeywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderKeywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderKeywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000A03A8 File Offset: 0x0009E5A8
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00007058 File Offset: 0x00005258
		public unsafe bool camInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_camInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_camInside)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000A03D0 File Offset: 0x0009E5D0
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00007073 File Offset: 0x00005273
		public unsafe float lastDistanceToCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastDistanceToCam)) = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000A03F8 File Offset: 0x0009E5F8
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0000708E File Offset: 0x0000528E
		public unsafe DETAIL currentDetail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentDetail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentDetail)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000A0420 File Offset: 0x0009E620
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000070A9 File Offset: 0x000052A9
		public unsafe Vector4 turb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turb)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000A0448 File Offset: 0x0009E648
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000070C4 File Offset: 0x000052C4
		public unsafe Vector4 shaderTurb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderTurb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shaderTurb)) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x000A0470 File Offset: 0x0009E670
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000070DF File Offset: 0x000052DF
		public unsafe float turbulenceSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceSpeed)) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000A0498 File Offset: 0x0009E698
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000070FA File Offset: 0x000052FA
		public unsafe float murkinessSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_murkinessSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_murkinessSpeed)) = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000A04C0 File Offset: 0x0009E6C0
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00007115 File Offset: 0x00005315
		public unsafe float liquidLevelPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidLevelPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidLevelPos)) = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000A04E8 File Offset: 0x0009E6E8
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00007130 File Offset: 0x00005330
		public unsafe bool shouldUpdateMaterialProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_shouldUpdateMaterialProperties)) = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000A0510 File Offset: 0x0009E710
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0000714B File Offset: 0x0000534B
		public unsafe int currentNoiseVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_currentNoiseVariation)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000A0538 File Offset: 0x0009E738
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00007166 File Offset: 0x00005366
		public unsafe float levelMultipled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_levelMultipled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_levelMultipled)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000A0560 File Offset: 0x0009E760
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00007181 File Offset: 0x00005381
		public unsafe Texture2D noise3DUnwrapped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DUnwrapped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000A0590 File Offset: 0x0009E790
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000071A0 File Offset: 0x000053A0
		public unsafe Il2CppReferenceArray<Texture3D> noise3DTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_noise3DTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000A05C0 File Offset: 0x0009E7C0
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x000071BF File Offset: 0x000053BF
		public unsafe Il2CppReferenceArray<Il2CppStructArray<Color>> colors3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_colors3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Color>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_colors3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000A05F0 File Offset: 0x0009E7F0
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000071DE File Offset: 0x000053DE
		public unsafe Il2CppStructArray<Vector3> verticesUnsorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesUnsorted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesUnsorted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000A0620 File Offset: 0x0009E820
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x000071FD File Offset: 0x000053FD
		public unsafe Il2CppStructArray<Vector3> verticesSorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesSorted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesSorted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000A0650 File Offset: 0x0009E850
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0000721C File Offset: 0x0000541C
		public unsafe static Il2CppStructArray<Vector3> rotatedVertices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_rotatedVertices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_rotatedVertices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000A0678 File Offset: 0x0009E878
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0000722E File Offset: 0x0000542E
		public unsafe Il2CppStructArray<int> verticesIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verticesIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000A06A8 File Offset: 0x0009E8A8
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x0000724D File Offset: 0x0000544D
		public unsafe float volumeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_volumeRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_volumeRef)) = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000A06D0 File Offset: 0x0009E8D0
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00007268 File Offset: 0x00005468
		public unsafe float lastLevelVolumeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastLevelVolumeRef)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000A06F8 File Offset: 0x0009E8F8
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00007283 File Offset: 0x00005483
		public unsafe Vector3 inertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_inertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_inertia)) = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000A0720 File Offset: 0x0009E920
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x0000729E File Offset: 0x0000549E
		public unsafe Vector3 lastAvgVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastAvgVelocity)) = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000A0748 File Offset: 0x0009E948
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000072B9 File Offset: 0x000054B9
		public unsafe float angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularVelocity)) = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000A0770 File Offset: 0x0009E970
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000072D4 File Offset: 0x000054D4
		public unsafe float angularInertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularInertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_angularInertia)) = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000A0798 File Offset: 0x0009E998
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000072EF File Offset: 0x000054EF
		public unsafe float turbulenceDueForces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_turbulenceDueForces)) = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0000730A File Offset: 0x0000550A
		public unsafe Quaternion liquidRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_liquidRot)) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000A07E8 File Offset: 0x0009E9E8
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00007325 File Offset: 0x00005525
		public unsafe float prevThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_prevThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_prevThickness)) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000A0810 File Offset: 0x0009EA10
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00007340 File Offset: 0x00005540
		public unsafe GameObject spillPointGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_spillPointGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_spillPointGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000A0840 File Offset: 0x0009EA40
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0000735F File Offset: 0x0000555F
		public unsafe static Il2CppStringArray defaultContainerNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_defaultContainerNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_defaultContainerNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000A0868 File Offset: 0x0009EA68
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00007371 File Offset: 0x00005571
		public unsafe Il2CppStructArray<Color> pointLightColorBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightColorBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000A0898 File Offset: 0x0009EA98
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00007390 File Offset: 0x00005590
		public unsafe Il2CppStructArray<Vector4> pointLightPositionBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_pointLightPositionBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000A08C8 File Offset: 0x0009EAC8
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000073AF File Offset: 0x000055AF
		public unsafe int lastPointLightCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPointLightCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_lastPointLightCount)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000A08F0 File Offset: 0x0009EAF0
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000073CA File Offset: 0x000055CA
		public unsafe static Dictionary<Mesh, LiquidVolume.MeshCache> meshCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolume.NativeFieldInfoPtr_meshCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Mesh, LiquidVolume.MeshCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolume.NativeFieldInfoPtr_meshCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000A0918 File Offset: 0x0009EB18
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000073DC File Offset: 0x000055DC
		public unsafe List<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000A0948 File Offset: 0x0009EB48
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x000073FB File Offset: 0x000055FB
		public unsafe List<Vector3> cutPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000A0978 File Offset: 0x0009EB78
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0000741A File Offset: 0x0000561A
		public unsafe Vector3 cutPlaneCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_cutPlaneCenter)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000A09A0 File Offset: 0x0009EBA0
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00007435 File Offset: 0x00005635
		public unsafe Mesh fixedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_fixedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.NativeFieldInfoPtr_fixedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_FORCE_GLES_COMPATIBILITY;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_onPropertiesChanged;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr__topology;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr__detail;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr__level;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__levelMultiplier;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr__useLightColor;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr__useLightDirection;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__directionalLight;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__liquidColor1;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__liquidScale1;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr__liquidColor2;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__liquidScale2;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr__alpha;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr__emissionColor;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr__ditherShadows;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr__murkiness;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr__turbulence1;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr__turbulence2;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr__frecuency;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr__sparklingIntensity;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr__sparklingAmount;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr__deepObscurance;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr__foamColor;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr__foamScale;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr__foamThickness;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr__foamDensity;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__foamWeight;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr__foamTurbulence;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr__foamVisibleFromBottom;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr__smokeEnabled;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr__smokeColor;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr__smokeScale;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr__smokeBaseObscurance;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr__smokeHeightAtten;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr__smokeSpeed;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr__fixMesh;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_originalMesh;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_originalPivotOffset;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr__pivotOffset;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr__limitVerticalRange;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr__upperLimit;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr__lowerLimit;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr__subMeshIndex;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr__flaskMaterial;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr__flaskThickness;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr__glossinessInternal;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr__scatteringEnabled;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr__scatteringPower;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr__scatteringAmount;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr__refractionBlur;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr__blurIntensity;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr__liquidRaySteps;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr__foamRaySteps;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr__smokeRaySteps;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr__bumpMap;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr__bumpStrength;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr__bumpDistortionScale;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr__bumpDistortionOffset;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr__distortionMap;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr__texture;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr__textureScale;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr__textureOffset;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr__distortionAmount;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr__depthAware;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareOffset;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr__irregularDepthDebug;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareCustomPass;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr__depthAwareCustomPassDebug;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr__doubleSidedBias;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr__backDepthBias;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr__rotationLevelCompensation;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr__ignoreGravity;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr__reactToForces;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr__extentsScale;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr__noiseVariation;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr__allowViewFromInside;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr__debugSpillPoint;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr__renderQueue;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr__reflectionTexture;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr__physicsMass;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr__physicsAngularDamp;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_INDEX;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY_INDEX;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB_INDEX;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_TOPOLOGY_INDEX;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_REFRACTION_INDEX;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_NON_AABB;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IGNORE_GRAVITY;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_SPHERE;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_CUBE;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_CYLINDER;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_IRREGULAR;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_FP_RENDER_TEXTURE;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_SHADER_KEYWORD_USE_REFRACTION;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_SPILL_POINT_GIZMO;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_liqMat;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_liqMatSimple;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_liqMatDefaultNoFlask;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_mr;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_mrSharedMaterials;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_lastScale;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_lastRotation;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_shaderKeywords;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_camInside;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_lastDistanceToCam;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_currentDetail;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_turb;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_shaderTurb;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_turbulenceSpeed;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_murkinessSpeed;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_liquidLevelPos;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_shouldUpdateMaterialProperties;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_currentNoiseVariation;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_levelMultipled;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_noise3DUnwrapped;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_noise3DTex;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_colors3D;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_verticesUnsorted;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_verticesSorted;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_rotatedVertices;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_verticesIndices;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_volumeRef;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_lastLevelVolumeRef;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_inertia;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_lastAvgVelocity;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_angularVelocity;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_angularInertia;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_turbulenceDueForces;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_liquidRot;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_prevThickness;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_spillPointGizmo;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_defaultContainerNames;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_pointLightColorBuffer;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_pointLightPositionBuffer;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_lastPointLightCount;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_meshCache;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_cutPoints;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_cutPlaneCenter;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_fixedMesh;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_add_onPropertiesChanged_Public_add_Void_PropertiesChangedEvent_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_remove_onPropertiesChanged_Public_rem_Void_PropertiesChangedEvent_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get_topology_Public_get_TOPOLOGY_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_set_topology_Public_set_Void_TOPOLOGY_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_get_detail_Public_get_DETAIL_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_set_detail_Public_set_Void_DETAIL_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_level_Public_get_Single_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_set_level_Public_set_Void_Single_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_get_levelMultiplier_Public_get_Single_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_set_levelMultiplier_Public_set_Void_Single_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_get_useLightColor_Public_get_Boolean_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_set_useLightColor_Public_set_Void_Boolean_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_get_useLightDirection_Public_get_Boolean_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_set_useLightDirection_Public_set_Void_Boolean_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_get_directionalLight_Public_get_Light_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_set_directionalLight_Public_set_Void_Light_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidColor1_Public_get_Color_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidColor1_Public_set_Void_Color_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidScale1_Public_get_Single_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidScale1_Public_set_Void_Single_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidColor2_Public_get_Color_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidColor2_Public_set_Void_Color_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidScale2_Public_get_Single_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidScale2_Public_set_Void_Single_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_get_emissionColor_Public_get_Color_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_set_emissionColor_Public_set_Void_Color_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_ditherShadows_Public_get_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_set_ditherShadows_Public_set_Void_Boolean_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_murkiness_Public_get_Single_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_set_murkiness_Public_set_Void_Single_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_turbulence1_Public_get_Single_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_set_turbulence1_Public_set_Void_Single_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_get_turbulence2_Public_get_Single_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_set_turbulence2_Public_set_Void_Single_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_get_frecuency_Public_get_Single_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_set_frecuency_Public_set_Void_Single_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Public_get_Single_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_set_speed_Public_set_Void_Single_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_get_sparklingIntensity_Public_get_Single_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_set_sparklingIntensity_Public_set_Void_Single_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_get_sparklingAmount_Public_get_Single_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_set_sparklingAmount_Public_set_Void_Single_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_get_deepObscurance_Public_get_Single_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_set_deepObscurance_Public_set_Void_Single_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_get_foamColor_Public_get_Color_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_set_foamColor_Public_set_Void_Color_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_foamScale_Public_get_Single_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_set_foamScale_Public_set_Void_Single_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_get_foamThickness_Public_get_Single_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_set_foamThickness_Public_set_Void_Single_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_get_foamDensity_Public_get_Single_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_set_foamDensity_Public_set_Void_Single_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_get_foamWeight_Public_get_Single_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_set_foamWeight_Public_set_Void_Single_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_get_foamTurbulence_Public_get_Single_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_set_foamTurbulence_Public_set_Void_Single_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_foamVisibleFromBottom_Public_get_Boolean_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_set_foamVisibleFromBottom_Public_set_Void_Boolean_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeEnabled_Public_get_Boolean_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeColor_Public_get_Color_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeColor_Public_set_Void_Color_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeScale_Public_get_Single_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeScale_Public_set_Void_Single_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeBaseObscurance_Public_get_Single_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeBaseObscurance_Public_set_Void_Single_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeHeightAtten_Public_get_Single_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeHeightAtten_Public_set_Void_Single_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeSpeed_Public_get_Single_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeSpeed_Public_set_Void_Single_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_get_fixMesh_Public_get_Boolean_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_set_fixMesh_Public_set_Void_Boolean_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_get_pivotOffset_Public_get_Vector3_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_set_pivotOffset_Public_set_Void_Vector3_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_limitVerticalRange_Public_get_Boolean_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_set_limitVerticalRange_Public_set_Void_Boolean_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_get_upperLimit_Public_get_Single_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_set_upperLimit_Public_set_Void_Single_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_get_lowerLimit_Public_get_Single_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_set_lowerLimit_Public_set_Void_Single_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshIndex_Public_get_Int32_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_flaskMaterial_Public_get_Material_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_set_flaskMaterial_Public_set_Void_Material_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_get_flaskThickness_Public_get_Single_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_set_flaskThickness_Public_set_Void_Single_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get_glossinessInternal_Public_get_Single_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_set_glossinessInternal_Public_set_Void_Single_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringEnabled_Public_get_Boolean_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringPower_Public_get_Int32_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringPower_Public_set_Void_Int32_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_get_scatteringAmount_Public_get_Single_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_set_scatteringAmount_Public_set_Void_Single_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_refractionBlur_Public_get_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_set_refractionBlur_Public_set_Void_Boolean_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_blurIntensity_Public_get_Single_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_set_blurIntensity_Public_set_Void_Single_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidRaySteps_Public_get_Int32_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_set_liquidRaySteps_Public_set_Void_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_foamRaySteps_Public_get_Int32_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_set_foamRaySteps_Public_set_Void_Int32_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_smokeRaySteps_Public_get_Int32_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_set_smokeRaySteps_Public_set_Void_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpMap_Public_get_Texture2D_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpMap_Public_set_Void_Texture2D_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpStrength_Public_get_Single_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpStrength_Public_set_Void_Single_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpDistortionScale_Public_get_Single_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpDistortionScale_Public_set_Void_Single_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_get_bumpDistortionOffset_Public_get_Vector2_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_set_bumpDistortionOffset_Public_set_Void_Vector2_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_distortionMap_Public_get_Texture2D_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_set_distortionMap_Public_set_Void_Texture2D_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_textureOffset_Public_get_Vector2_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_set_textureOffset_Public_set_Void_Vector2_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_distortionAmount_Public_get_Single_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_set_distortionAmount_Public_set_Void_Single_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAware_Public_get_Boolean_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAware_Public_set_Void_Boolean_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareOffset_Public_get_Single_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareOffset_Public_set_Void_Single_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_get_irregularDepthDebug_Public_get_Boolean_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_set_irregularDepthDebug_Public_set_Void_Boolean_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareCustomPass_Public_get_Boolean_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareCustomPass_Public_set_Void_Boolean_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_get_depthAwareCustomPassDebug_Public_get_Boolean_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_set_depthAwareCustomPassDebug_Public_set_Void_Boolean_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_get_doubleSidedBias_Public_get_Single_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_set_doubleSidedBias_Public_set_Void_Single_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_get_backDepthBias_Public_get_Single_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_set_backDepthBias_Public_set_Void_Single_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationLevelCompensation_Public_get_LEVEL_COMPENSATION_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_set_rotationLevelCompensation_Public_set_Void_LEVEL_COMPENSATION_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreGravity_Public_get_Boolean_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreGravity_Public_set_Void_Boolean_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_reactToForces_Public_get_Boolean_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_set_reactToForces_Public_set_Void_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_extentsScale_Public_get_Vector3_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_set_extentsScale_Public_set_Void_Vector3_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseVariation_Public_get_Int32_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseVariation_Public_set_Void_Int32_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_allowViewFromInside_Public_get_Boolean_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_allowViewFromInside_Public_set_Void_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_debugSpillPoint_Public_get_Boolean_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_debugSpillPoint_Public_set_Void_Boolean_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionTexture_Public_get_Cubemap_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionTexture_Public_set_Void_Cubemap_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_physicsMass_Public_get_Single_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_set_physicsMass_Public_set_Void_Single_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_physicsAngularDamp_Public_get_Single_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_set_physicsAngularDamp_Public_set_Void_Single_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_get_useFPRenderTextures_Public_Static_get_Boolean_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_RenderObject_Private_Void_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshCache_Public_Void_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_ReadVertices_Private_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_vertexComparer_Private_Int32_Vector3_Vector3_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimations_Private_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialProperties_Public_Void_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialPropertiesNow_Private_Void_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGlobalAlpha_Private_Color_Color_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderer_Private_Void_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLevels_Private_Void_Boolean_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_RotateVertices_Private_Void_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_SignedVolumeOfTriangle_Private_Single_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelFast_Public_Single_Single_Single_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeWSFast_Public_Single_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelWSFast_Public_Single_Single_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_ClampVertexToSlicePlane_Private_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevel_Public_Single_Single_Single_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeWS_Public_Single_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshVolumeUnderLevelWS_Public_Single_Single_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_PolygonSortOnPlane_Private_Int32_Vector3_Vector3_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTurbulence_Private_Void_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_CheckInsideOut_Private_Void_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_PointInAABB_Private_Boolean_Vector3_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_PointInCylinder_Private_Boolean_Vector3_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInsideOut_Private_Void_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_get_liquidSurfaceYPosition_Public_get_Single_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_Single_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_GetSpillPoint_Public_Boolean_byref_Vector3_byref_Single_Single_LEVEL_COMPENSATION_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpillPointGizmo_Private_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_BakeRotation_Public_Void_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_CenterPivot_Public_Void_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_CenterPivot_Public_Void_Vector3_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMeshAndCollider_Public_Void_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Public_Void_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_CheckMeshDisplacement_Private_Void_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_RestoreOriginalMesh_Private_Void_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_LiquidVolume_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200089F RID: 2207
		public sealed class MeshCache : ValueType
		{
			// Token: 0x0600D313 RID: 54035 RVA: 0x0034B504 File Offset: 0x00349704
			// Note: this type is marked as 'beforefieldinit'.
			static MeshCache()
			{
				Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "MeshCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr);
				LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "verticesSorted");
				LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "verticesUnsorted");
				LiquidVolume.MeshCache.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr, "indices");
			}

			// Token: 0x0600D314 RID: 54036 RVA: 0x00063D06 File Offset: 0x00061F06
			public MeshCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D315 RID: 54037 RVA: 0x00063D0F File Offset: 0x00061F0F
			public MeshCache() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume.MeshCache>.NativeClassPtr))
			{
			}

			// Token: 0x17004028 RID: 16424
			// (get) Token: 0x0600D316 RID: 54038 RVA: 0x0034B56C File Offset: 0x0034976C
			// (set) Token: 0x0600D317 RID: 54039 RVA: 0x00063D21 File Offset: 0x00061F21
			public unsafe Il2CppStructArray<Vector3> verticesSorted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesSorted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004029 RID: 16425
			// (get) Token: 0x0600D318 RID: 54040 RVA: 0x0034B59C File Offset: 0x0034979C
			// (set) Token: 0x0600D319 RID: 54041 RVA: 0x00063D40 File Offset: 0x00061F40
			public unsafe Il2CppStructArray<Vector3> verticesUnsorted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_verticesUnsorted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402A RID: 16426
			// (get) Token: 0x0600D31A RID: 54042 RVA: 0x0034B5CC File Offset: 0x003497CC
			// (set) Token: 0x0600D31B RID: 54043 RVA: 0x00063D5F File Offset: 0x00061F5F
			public unsafe Il2CppStructArray<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolume.MeshCache.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FD5 RID: 36821
			private static readonly IntPtr NativeFieldInfoPtr_verticesSorted;

			// Token: 0x04008FD6 RID: 36822
			private static readonly IntPtr NativeFieldInfoPtr_verticesUnsorted;

			// Token: 0x04008FD7 RID: 36823
			private static readonly IntPtr NativeFieldInfoPtr_indices;
		}

		// Token: 0x020008A0 RID: 2208
		public sealed class MeshVolumeCalcFunction : MulticastDelegate
		{
			// Token: 0x0600D31C RID: 54044 RVA: 0x0034B5FC File Offset: 0x003497FC
			// Note: this type is marked as 'beforefieldinit'.
			static MeshVolumeCalcFunction()
			{
				Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "MeshVolumeCalcFunction");
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100664719);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100664720);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100664721);
				LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr, 100664722);
			}

			// Token: 0x0600D31D RID: 54045 RVA: 0x0034B670 File Offset: 0x00349870
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 75246, RefRangeEnd = 75251, XrefRangeStart = 75243, XrefRangeEnd = 75246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshVolumeCalcFunction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolume.MeshVolumeCalcFunction>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D31E RID: 54046 RVA: 0x0034B6CC File Offset: 0x003498CC
			[CallerCount(0)]
			public unsafe float Invoke(float level01, float yExtent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref level01;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D31F RID: 54047 RVA: 0x0034B724 File Offset: 0x00349924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75251, XrefRangeEnd = 75257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float level01, float yExtent, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref level01;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yExtent;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D320 RID: 54048 RVA: 0x0034B7A4 File Offset: 0x003499A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75257, XrefRangeEnd = 75259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolume.MeshVolumeCalcFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D321 RID: 54049 RVA: 0x00063D7E File Offset: 0x00061F7E
			public MeshVolumeCalcFunction(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D322 RID: 54050 RVA: 0x00063D87 File Offset: 0x00061F87
			public static implicit operator LiquidVolume.MeshVolumeCalcFunction(Func<float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<LiquidVolume.MeshVolumeCalcFunction>(A_0);
			}

			// Token: 0x0600D323 RID: 54051 RVA: 0x00063D8F File Offset: 0x00061F8F
			public static LiquidVolume.MeshVolumeCalcFunction operator +(LiquidVolume.MeshVolumeCalcFunction A_0, LiquidVolume.MeshVolumeCalcFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LiquidVolume.MeshVolumeCalcFunction>();
			}

			// Token: 0x0600D324 RID: 54052 RVA: 0x00063D9D File Offset: 0x00061F9D
			public static LiquidVolume.MeshVolumeCalcFunction operator -(LiquidVolume.MeshVolumeCalcFunction A_0, LiquidVolume.MeshVolumeCalcFunction A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<LiquidVolume.MeshVolumeCalcFunction>();
				}
				return result;
			}

			// Token: 0x04008FD8 RID: 36824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008FD9 RID: 36825
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_0;

			// Token: 0x04008FDA RID: 36826
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_AsyncCallback_Object_0;

			// Token: 0x04008FDB RID: 36827
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x020008A1 RID: 2209
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600D325 RID: 54053 RVA: 0x0034B7F4 File Offset: 0x003499F4
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolume>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr);
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightInsideAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightColorArray");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightPositionArray");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PointLightCount");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "GlossinessInt");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DoubleSidedBias");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "BackDepthBias");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Muddy");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Alpha");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "AlphaCombined");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SparklingIntensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SparklingThreshold");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DepthAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeHeightAtten");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SmokeRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LiquidRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FlaskBlurIntensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamRaySteps");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamDensity");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamWeight");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamBottom");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamTurbulence");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "RefractTex");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FlaskThickness");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Size");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Scale");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Center");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "SizeWorld");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "DepthAwareOffset");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Turbulence");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "TurbulenceSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "MurkinessSpeed");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Color1");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "Color2");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "EmissionColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LightColor");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LightDir");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LevelPos");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "UpperLimit");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "LowerLimit");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "FoamMaxPos");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "CullMode");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "ZTestMode");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "NoiseTex");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "NoiseTexUnwrapped");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "GlobalRefractionTexture");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "RotationMatrix");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "QueueOffset");
				LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolume.ShaderParams>.NativeClassPtr, "PreserveSpecular");
			}

			// Token: 0x0600D326 RID: 54054 RVA: 0x00063DAE File Offset: 0x00061FAE
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402B RID: 16427
			// (get) Token: 0x0600D327 RID: 54055 RVA: 0x0034BC44 File Offset: 0x00349E44
			// (set) Token: 0x0600D328 RID: 54056 RVA: 0x00063DB7 File Offset: 0x00061FB7
			public unsafe static int PointLightInsideAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightInsideAtten, (void*)(&value));
				}
			}

			// Token: 0x1700402C RID: 16428
			// (get) Token: 0x0600D329 RID: 54057 RVA: 0x0034BC60 File Offset: 0x00349E60
			// (set) Token: 0x0600D32A RID: 54058 RVA: 0x00063DC5 File Offset: 0x00061FC5
			public unsafe static int PointLightColorArray
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightColorArray, (void*)(&value));
				}
			}

			// Token: 0x1700402D RID: 16429
			// (get) Token: 0x0600D32B RID: 54059 RVA: 0x0034BC7C File Offset: 0x00349E7C
			// (set) Token: 0x0600D32C RID: 54060 RVA: 0x00063DD3 File Offset: 0x00061FD3
			public unsafe static int PointLightPositionArray
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightPositionArray, (void*)(&value));
				}
			}

			// Token: 0x1700402E RID: 16430
			// (get) Token: 0x0600D32D RID: 54061 RVA: 0x0034BC98 File Offset: 0x00349E98
			// (set) Token: 0x0600D32E RID: 54062 RVA: 0x00063DE1 File Offset: 0x00061FE1
			public unsafe static int PointLightCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PointLightCount, (void*)(&value));
				}
			}

			// Token: 0x1700402F RID: 16431
			// (get) Token: 0x0600D32F RID: 54063 RVA: 0x0034BCB4 File Offset: 0x00349EB4
			// (set) Token: 0x0600D330 RID: 54064 RVA: 0x00063DEF File Offset: 0x00061FEF
			public unsafe static int GlossinessInt
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlossinessInt, (void*)(&value));
				}
			}

			// Token: 0x17004030 RID: 16432
			// (get) Token: 0x0600D331 RID: 54065 RVA: 0x0034BCD0 File Offset: 0x00349ED0
			// (set) Token: 0x0600D332 RID: 54066 RVA: 0x00063DFD File Offset: 0x00061FFD
			public unsafe static int DoubleSidedBias
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DoubleSidedBias, (void*)(&value));
				}
			}

			// Token: 0x17004031 RID: 16433
			// (get) Token: 0x0600D333 RID: 54067 RVA: 0x0034BCEC File Offset: 0x00349EEC
			// (set) Token: 0x0600D334 RID: 54068 RVA: 0x00063E0B File Offset: 0x0006200B
			public unsafe static int BackDepthBias
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_BackDepthBias, (void*)(&value));
				}
			}

			// Token: 0x17004032 RID: 16434
			// (get) Token: 0x0600D335 RID: 54069 RVA: 0x0034BD08 File Offset: 0x00349F08
			// (set) Token: 0x0600D336 RID: 54070 RVA: 0x00063E19 File Offset: 0x00062019
			public unsafe static int Muddy
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Muddy, (void*)(&value));
				}
			}

			// Token: 0x17004033 RID: 16435
			// (get) Token: 0x0600D337 RID: 54071 RVA: 0x0034BD24 File Offset: 0x00349F24
			// (set) Token: 0x0600D338 RID: 54072 RVA: 0x00063E27 File Offset: 0x00062027
			public unsafe static int Alpha
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Alpha, (void*)(&value));
				}
			}

			// Token: 0x17004034 RID: 16436
			// (get) Token: 0x0600D339 RID: 54073 RVA: 0x0034BD40 File Offset: 0x00349F40
			// (set) Token: 0x0600D33A RID: 54074 RVA: 0x00063E35 File Offset: 0x00062035
			public unsafe static int AlphaCombined
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_AlphaCombined, (void*)(&value));
				}
			}

			// Token: 0x17004035 RID: 16437
			// (get) Token: 0x0600D33B RID: 54075 RVA: 0x0034BD5C File Offset: 0x00349F5C
			// (set) Token: 0x0600D33C RID: 54076 RVA: 0x00063E43 File Offset: 0x00062043
			public unsafe static int SparklingIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingIntensity, (void*)(&value));
				}
			}

			// Token: 0x17004036 RID: 16438
			// (get) Token: 0x0600D33D RID: 54077 RVA: 0x0034BD78 File Offset: 0x00349F78
			// (set) Token: 0x0600D33E RID: 54078 RVA: 0x00063E51 File Offset: 0x00062051
			public unsafe static int SparklingThreshold
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SparklingThreshold, (void*)(&value));
				}
			}

			// Token: 0x17004037 RID: 16439
			// (get) Token: 0x0600D33F RID: 54079 RVA: 0x0034BD94 File Offset: 0x00349F94
			// (set) Token: 0x0600D340 RID: 54080 RVA: 0x00063E5F File Offset: 0x0006205F
			public unsafe static int DepthAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAtten, (void*)(&value));
				}
			}

			// Token: 0x17004038 RID: 16440
			// (get) Token: 0x0600D341 RID: 54081 RVA: 0x0034BDB0 File Offset: 0x00349FB0
			// (set) Token: 0x0600D342 RID: 54082 RVA: 0x00063E6D File Offset: 0x0006206D
			public unsafe static int SmokeColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeColor, (void*)(&value));
				}
			}

			// Token: 0x17004039 RID: 16441
			// (get) Token: 0x0600D343 RID: 54083 RVA: 0x0034BDCC File Offset: 0x00349FCC
			// (set) Token: 0x0600D344 RID: 54084 RVA: 0x00063E7B File Offset: 0x0006207B
			public unsafe static int SmokeAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeAtten, (void*)(&value));
				}
			}

			// Token: 0x1700403A RID: 16442
			// (get) Token: 0x0600D345 RID: 54085 RVA: 0x0034BDE8 File Offset: 0x00349FE8
			// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00063E89 File Offset: 0x00062089
			public unsafe static int SmokeSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeSpeed, (void*)(&value));
				}
			}

			// Token: 0x1700403B RID: 16443
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x0034BE04 File Offset: 0x0034A004
			// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00063E97 File Offset: 0x00062097
			public unsafe static int SmokeHeightAtten
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeHeightAtten, (void*)(&value));
				}
			}

			// Token: 0x1700403C RID: 16444
			// (get) Token: 0x0600D349 RID: 54089 RVA: 0x0034BE20 File Offset: 0x0034A020
			// (set) Token: 0x0600D34A RID: 54090 RVA: 0x00063EA5 File Offset: 0x000620A5
			public unsafe static int SmokeRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SmokeRaySteps, (void*)(&value));
				}
			}

			// Token: 0x1700403D RID: 16445
			// (get) Token: 0x0600D34B RID: 54091 RVA: 0x0034BE3C File Offset: 0x0034A03C
			// (set) Token: 0x0600D34C RID: 54092 RVA: 0x00063EB3 File Offset: 0x000620B3
			public unsafe static int LiquidRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LiquidRaySteps, (void*)(&value));
				}
			}

			// Token: 0x1700403E RID: 16446
			// (get) Token: 0x0600D34D RID: 54093 RVA: 0x0034BE58 File Offset: 0x0034A058
			// (set) Token: 0x0600D34E RID: 54094 RVA: 0x00063EC1 File Offset: 0x000620C1
			public unsafe static int FlaskBlurIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskBlurIntensity, (void*)(&value));
				}
			}

			// Token: 0x1700403F RID: 16447
			// (get) Token: 0x0600D34F RID: 54095 RVA: 0x0034BE74 File Offset: 0x0034A074
			// (set) Token: 0x0600D350 RID: 54096 RVA: 0x00063ECF File Offset: 0x000620CF
			public unsafe static int FoamColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamColor, (void*)(&value));
				}
			}

			// Token: 0x17004040 RID: 16448
			// (get) Token: 0x0600D351 RID: 54097 RVA: 0x0034BE90 File Offset: 0x0034A090
			// (set) Token: 0x0600D352 RID: 54098 RVA: 0x00063EDD File Offset: 0x000620DD
			public unsafe static int FoamRaySteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamRaySteps, (void*)(&value));
				}
			}

			// Token: 0x17004041 RID: 16449
			// (get) Token: 0x0600D353 RID: 54099 RVA: 0x0034BEAC File Offset: 0x0034A0AC
			// (set) Token: 0x0600D354 RID: 54100 RVA: 0x00063EEB File Offset: 0x000620EB
			public unsafe static int FoamDensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamDensity, (void*)(&value));
				}
			}

			// Token: 0x17004042 RID: 16450
			// (get) Token: 0x0600D355 RID: 54101 RVA: 0x0034BEC8 File Offset: 0x0034A0C8
			// (set) Token: 0x0600D356 RID: 54102 RVA: 0x00063EF9 File Offset: 0x000620F9
			public unsafe static int FoamWeight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamWeight, (void*)(&value));
				}
			}

			// Token: 0x17004043 RID: 16451
			// (get) Token: 0x0600D357 RID: 54103 RVA: 0x0034BEE4 File Offset: 0x0034A0E4
			// (set) Token: 0x0600D358 RID: 54104 RVA: 0x00063F07 File Offset: 0x00062107
			public unsafe static int FoamBottom
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamBottom, (void*)(&value));
				}
			}

			// Token: 0x17004044 RID: 16452
			// (get) Token: 0x0600D359 RID: 54105 RVA: 0x0034BF00 File Offset: 0x0034A100
			// (set) Token: 0x0600D35A RID: 54106 RVA: 0x00063F15 File Offset: 0x00062115
			public unsafe static int FoamTurbulence
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamTurbulence, (void*)(&value));
				}
			}

			// Token: 0x17004045 RID: 16453
			// (get) Token: 0x0600D35B RID: 54107 RVA: 0x0034BF1C File Offset: 0x0034A11C
			// (set) Token: 0x0600D35C RID: 54108 RVA: 0x00063F23 File Offset: 0x00062123
			public unsafe static int RefractTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RefractTex, (void*)(&value));
				}
			}

			// Token: 0x17004046 RID: 16454
			// (get) Token: 0x0600D35D RID: 54109 RVA: 0x0034BF38 File Offset: 0x0034A138
			// (set) Token: 0x0600D35E RID: 54110 RVA: 0x00063F31 File Offset: 0x00062131
			public unsafe static int FlaskThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&value));
				}
			}

			// Token: 0x17004047 RID: 16455
			// (get) Token: 0x0600D35F RID: 54111 RVA: 0x0034BF54 File Offset: 0x0034A154
			// (set) Token: 0x0600D360 RID: 54112 RVA: 0x00063F3F File Offset: 0x0006213F
			public unsafe static int Size
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Size, (void*)(&value));
				}
			}

			// Token: 0x17004048 RID: 16456
			// (get) Token: 0x0600D361 RID: 54113 RVA: 0x0034BF70 File Offset: 0x0034A170
			// (set) Token: 0x0600D362 RID: 54114 RVA: 0x00063F4D File Offset: 0x0006214D
			public unsafe static int Scale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Scale, (void*)(&value));
				}
			}

			// Token: 0x17004049 RID: 16457
			// (get) Token: 0x0600D363 RID: 54115 RVA: 0x0034BF8C File Offset: 0x0034A18C
			// (set) Token: 0x0600D364 RID: 54116 RVA: 0x00063F5B File Offset: 0x0006215B
			public unsafe static int Center
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Center, (void*)(&value));
				}
			}

			// Token: 0x1700404A RID: 16458
			// (get) Token: 0x0600D365 RID: 54117 RVA: 0x0034BFA8 File Offset: 0x0034A1A8
			// (set) Token: 0x0600D366 RID: 54118 RVA: 0x00063F69 File Offset: 0x00062169
			public unsafe static int SizeWorld
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_SizeWorld, (void*)(&value));
				}
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0600D367 RID: 54119 RVA: 0x0034BFC4 File Offset: 0x0034A1C4
			// (set) Token: 0x0600D368 RID: 54120 RVA: 0x00063F77 File Offset: 0x00062177
			public unsafe static int DepthAwareOffset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_DepthAwareOffset, (void*)(&value));
				}
			}

			// Token: 0x1700404C RID: 16460
			// (get) Token: 0x0600D369 RID: 54121 RVA: 0x0034BFE0 File Offset: 0x0034A1E0
			// (set) Token: 0x0600D36A RID: 54122 RVA: 0x00063F85 File Offset: 0x00062185
			public unsafe static int Turbulence
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Turbulence, (void*)(&value));
				}
			}

			// Token: 0x1700404D RID: 16461
			// (get) Token: 0x0600D36B RID: 54123 RVA: 0x0034BFFC File Offset: 0x0034A1FC
			// (set) Token: 0x0600D36C RID: 54124 RVA: 0x00063F93 File Offset: 0x00062193
			public unsafe static int TurbulenceSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_TurbulenceSpeed, (void*)(&value));
				}
			}

			// Token: 0x1700404E RID: 16462
			// (get) Token: 0x0600D36D RID: 54125 RVA: 0x0034C018 File Offset: 0x0034A218
			// (set) Token: 0x0600D36E RID: 54126 RVA: 0x00063FA1 File Offset: 0x000621A1
			public unsafe static int MurkinessSpeed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_MurkinessSpeed, (void*)(&value));
				}
			}

			// Token: 0x1700404F RID: 16463
			// (get) Token: 0x0600D36F RID: 54127 RVA: 0x0034C034 File Offset: 0x0034A234
			// (set) Token: 0x0600D370 RID: 54128 RVA: 0x00063FAF File Offset: 0x000621AF
			public unsafe static int Color1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color1, (void*)(&value));
				}
			}

			// Token: 0x17004050 RID: 16464
			// (get) Token: 0x0600D371 RID: 54129 RVA: 0x0034C050 File Offset: 0x0034A250
			// (set) Token: 0x0600D372 RID: 54130 RVA: 0x00063FBD File Offset: 0x000621BD
			public unsafe static int Color2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_Color2, (void*)(&value));
				}
			}

			// Token: 0x17004051 RID: 16465
			// (get) Token: 0x0600D373 RID: 54131 RVA: 0x0034C06C File Offset: 0x0034A26C
			// (set) Token: 0x0600D374 RID: 54132 RVA: 0x00063FCB File Offset: 0x000621CB
			public unsafe static int EmissionColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_EmissionColor, (void*)(&value));
				}
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0600D375 RID: 54133 RVA: 0x0034C088 File Offset: 0x0034A288
			// (set) Token: 0x0600D376 RID: 54134 RVA: 0x00063FD9 File Offset: 0x000621D9
			public unsafe static int LightColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightColor, (void*)(&value));
				}
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0600D377 RID: 54135 RVA: 0x0034C0A4 File Offset: 0x0034A2A4
			// (set) Token: 0x0600D378 RID: 54136 RVA: 0x00063FE7 File Offset: 0x000621E7
			public unsafe static int LightDir
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LightDir, (void*)(&value));
				}
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0600D379 RID: 54137 RVA: 0x0034C0C0 File Offset: 0x0034A2C0
			// (set) Token: 0x0600D37A RID: 54138 RVA: 0x00063FF5 File Offset: 0x000621F5
			public unsafe static int LevelPos
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LevelPos, (void*)(&value));
				}
			}

			// Token: 0x17004055 RID: 16469
			// (get) Token: 0x0600D37B RID: 54139 RVA: 0x0034C0DC File Offset: 0x0034A2DC
			// (set) Token: 0x0600D37C RID: 54140 RVA: 0x00064003 File Offset: 0x00062203
			public unsafe static int UpperLimit
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_UpperLimit, (void*)(&value));
				}
			}

			// Token: 0x17004056 RID: 16470
			// (get) Token: 0x0600D37D RID: 54141 RVA: 0x0034C0F8 File Offset: 0x0034A2F8
			// (set) Token: 0x0600D37E RID: 54142 RVA: 0x00064011 File Offset: 0x00062211
			public unsafe static int LowerLimit
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_LowerLimit, (void*)(&value));
				}
			}

			// Token: 0x17004057 RID: 16471
			// (get) Token: 0x0600D37F RID: 54143 RVA: 0x0034C114 File Offset: 0x0034A314
			// (set) Token: 0x0600D380 RID: 54144 RVA: 0x0006401F File Offset: 0x0006221F
			public unsafe static int FoamMaxPos
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_FoamMaxPos, (void*)(&value));
				}
			}

			// Token: 0x17004058 RID: 16472
			// (get) Token: 0x0600D381 RID: 54145 RVA: 0x0034C130 File Offset: 0x0034A330
			// (set) Token: 0x0600D382 RID: 54146 RVA: 0x0006402D File Offset: 0x0006222D
			public unsafe static int CullMode
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_CullMode, (void*)(&value));
				}
			}

			// Token: 0x17004059 RID: 16473
			// (get) Token: 0x0600D383 RID: 54147 RVA: 0x0034C14C File Offset: 0x0034A34C
			// (set) Token: 0x0600D384 RID: 54148 RVA: 0x0006403B File Offset: 0x0006223B
			public unsafe static int ZTestMode
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_ZTestMode, (void*)(&value));
				}
			}

			// Token: 0x1700405A RID: 16474
			// (get) Token: 0x0600D385 RID: 54149 RVA: 0x0034C168 File Offset: 0x0034A368
			// (set) Token: 0x0600D386 RID: 54150 RVA: 0x00064049 File Offset: 0x00062249
			public unsafe static int NoiseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTex, (void*)(&value));
				}
			}

			// Token: 0x1700405B RID: 16475
			// (get) Token: 0x0600D387 RID: 54151 RVA: 0x0034C184 File Offset: 0x0034A384
			// (set) Token: 0x0600D388 RID: 54152 RVA: 0x00064057 File Offset: 0x00062257
			public unsafe static int NoiseTexUnwrapped
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_NoiseTexUnwrapped, (void*)(&value));
				}
			}

			// Token: 0x1700405C RID: 16476
			// (get) Token: 0x0600D389 RID: 54153 RVA: 0x0034C1A0 File Offset: 0x0034A3A0
			// (set) Token: 0x0600D38A RID: 54154 RVA: 0x00064065 File Offset: 0x00062265
			public unsafe static int GlobalRefractionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_GlobalRefractionTexture, (void*)(&value));
				}
			}

			// Token: 0x1700405D RID: 16477
			// (get) Token: 0x0600D38B RID: 54155 RVA: 0x0034C1BC File Offset: 0x0034A3BC
			// (set) Token: 0x0600D38C RID: 54156 RVA: 0x00064073 File Offset: 0x00062273
			public unsafe static int RotationMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_RotationMatrix, (void*)(&value));
				}
			}

			// Token: 0x1700405E RID: 16478
			// (get) Token: 0x0600D38D RID: 54157 RVA: 0x0034C1D8 File Offset: 0x0034A3D8
			// (set) Token: 0x0600D38E RID: 54158 RVA: 0x00064081 File Offset: 0x00062281
			public unsafe static int QueueOffset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_QueueOffset, (void*)(&value));
				}
			}

			// Token: 0x1700405F RID: 16479
			// (get) Token: 0x0600D38F RID: 54159 RVA: 0x0034C1F4 File Offset: 0x0034A3F4
			// (set) Token: 0x0600D390 RID: 54160 RVA: 0x0006408F File Offset: 0x0006228F
			public unsafe static int PreserveSpecular
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolume.ShaderParams.NativeFieldInfoPtr_PreserveSpecular, (void*)(&value));
				}
			}

			// Token: 0x04008FDC RID: 36828
			private static readonly IntPtr NativeFieldInfoPtr_PointLightInsideAtten;

			// Token: 0x04008FDD RID: 36829
			private static readonly IntPtr NativeFieldInfoPtr_PointLightColorArray;

			// Token: 0x04008FDE RID: 36830
			private static readonly IntPtr NativeFieldInfoPtr_PointLightPositionArray;

			// Token: 0x04008FDF RID: 36831
			private static readonly IntPtr NativeFieldInfoPtr_PointLightCount;

			// Token: 0x04008FE0 RID: 36832
			private static readonly IntPtr NativeFieldInfoPtr_GlossinessInt;

			// Token: 0x04008FE1 RID: 36833
			private static readonly IntPtr NativeFieldInfoPtr_DoubleSidedBias;

			// Token: 0x04008FE2 RID: 36834
			private static readonly IntPtr NativeFieldInfoPtr_BackDepthBias;

			// Token: 0x04008FE3 RID: 36835
			private static readonly IntPtr NativeFieldInfoPtr_Muddy;

			// Token: 0x04008FE4 RID: 36836
			private static readonly IntPtr NativeFieldInfoPtr_Alpha;

			// Token: 0x04008FE5 RID: 36837
			private static readonly IntPtr NativeFieldInfoPtr_AlphaCombined;

			// Token: 0x04008FE6 RID: 36838
			private static readonly IntPtr NativeFieldInfoPtr_SparklingIntensity;

			// Token: 0x04008FE7 RID: 36839
			private static readonly IntPtr NativeFieldInfoPtr_SparklingThreshold;

			// Token: 0x04008FE8 RID: 36840
			private static readonly IntPtr NativeFieldInfoPtr_DepthAtten;

			// Token: 0x04008FE9 RID: 36841
			private static readonly IntPtr NativeFieldInfoPtr_SmokeColor;

			// Token: 0x04008FEA RID: 36842
			private static readonly IntPtr NativeFieldInfoPtr_SmokeAtten;

			// Token: 0x04008FEB RID: 36843
			private static readonly IntPtr NativeFieldInfoPtr_SmokeSpeed;

			// Token: 0x04008FEC RID: 36844
			private static readonly IntPtr NativeFieldInfoPtr_SmokeHeightAtten;

			// Token: 0x04008FED RID: 36845
			private static readonly IntPtr NativeFieldInfoPtr_SmokeRaySteps;

			// Token: 0x04008FEE RID: 36846
			private static readonly IntPtr NativeFieldInfoPtr_LiquidRaySteps;

			// Token: 0x04008FEF RID: 36847
			private static readonly IntPtr NativeFieldInfoPtr_FlaskBlurIntensity;

			// Token: 0x04008FF0 RID: 36848
			private static readonly IntPtr NativeFieldInfoPtr_FoamColor;

			// Token: 0x04008FF1 RID: 36849
			private static readonly IntPtr NativeFieldInfoPtr_FoamRaySteps;

			// Token: 0x04008FF2 RID: 36850
			private static readonly IntPtr NativeFieldInfoPtr_FoamDensity;

			// Token: 0x04008FF3 RID: 36851
			private static readonly IntPtr NativeFieldInfoPtr_FoamWeight;

			// Token: 0x04008FF4 RID: 36852
			private static readonly IntPtr NativeFieldInfoPtr_FoamBottom;

			// Token: 0x04008FF5 RID: 36853
			private static readonly IntPtr NativeFieldInfoPtr_FoamTurbulence;

			// Token: 0x04008FF6 RID: 36854
			private static readonly IntPtr NativeFieldInfoPtr_RefractTex;

			// Token: 0x04008FF7 RID: 36855
			private static readonly IntPtr NativeFieldInfoPtr_FlaskThickness;

			// Token: 0x04008FF8 RID: 36856
			private static readonly IntPtr NativeFieldInfoPtr_Size;

			// Token: 0x04008FF9 RID: 36857
			private static readonly IntPtr NativeFieldInfoPtr_Scale;

			// Token: 0x04008FFA RID: 36858
			private static readonly IntPtr NativeFieldInfoPtr_Center;

			// Token: 0x04008FFB RID: 36859
			private static readonly IntPtr NativeFieldInfoPtr_SizeWorld;

			// Token: 0x04008FFC RID: 36860
			private static readonly IntPtr NativeFieldInfoPtr_DepthAwareOffset;

			// Token: 0x04008FFD RID: 36861
			private static readonly IntPtr NativeFieldInfoPtr_Turbulence;

			// Token: 0x04008FFE RID: 36862
			private static readonly IntPtr NativeFieldInfoPtr_TurbulenceSpeed;

			// Token: 0x04008FFF RID: 36863
			private static readonly IntPtr NativeFieldInfoPtr_MurkinessSpeed;

			// Token: 0x04009000 RID: 36864
			private static readonly IntPtr NativeFieldInfoPtr_Color1;

			// Token: 0x04009001 RID: 36865
			private static readonly IntPtr NativeFieldInfoPtr_Color2;

			// Token: 0x04009002 RID: 36866
			private static readonly IntPtr NativeFieldInfoPtr_EmissionColor;

			// Token: 0x04009003 RID: 36867
			private static readonly IntPtr NativeFieldInfoPtr_LightColor;

			// Token: 0x04009004 RID: 36868
			private static readonly IntPtr NativeFieldInfoPtr_LightDir;

			// Token: 0x04009005 RID: 36869
			private static readonly IntPtr NativeFieldInfoPtr_LevelPos;

			// Token: 0x04009006 RID: 36870
			private static readonly IntPtr NativeFieldInfoPtr_UpperLimit;

			// Token: 0x04009007 RID: 36871
			private static readonly IntPtr NativeFieldInfoPtr_LowerLimit;

			// Token: 0x04009008 RID: 36872
			private static readonly IntPtr NativeFieldInfoPtr_FoamMaxPos;

			// Token: 0x04009009 RID: 36873
			private static readonly IntPtr NativeFieldInfoPtr_CullMode;

			// Token: 0x0400900A RID: 36874
			private static readonly IntPtr NativeFieldInfoPtr_ZTestMode;

			// Token: 0x0400900B RID: 36875
			private static readonly IntPtr NativeFieldInfoPtr_NoiseTex;

			// Token: 0x0400900C RID: 36876
			private static readonly IntPtr NativeFieldInfoPtr_NoiseTexUnwrapped;

			// Token: 0x0400900D RID: 36877
			private static readonly IntPtr NativeFieldInfoPtr_GlobalRefractionTexture;

			// Token: 0x0400900E RID: 36878
			private static readonly IntPtr NativeFieldInfoPtr_RotationMatrix;

			// Token: 0x0400900F RID: 36879
			private static readonly IntPtr NativeFieldInfoPtr_QueueOffset;

			// Token: 0x04009010 RID: 36880
			private static readonly IntPtr NativeFieldInfoPtr_PreserveSpecular;
		}
	}
}
