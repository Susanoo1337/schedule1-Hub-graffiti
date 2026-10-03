using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200003E RID: 62
	public class Config : ScriptableObject
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00087200 File Offset: 0x00085400
		// Note: this type is marked as 'beforefieldinit'.
		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
			Config.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ClassName");
			Config.NativeFieldInfoPtr_kAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "kAssetName");
			Config.NativeFieldInfoPtr_kAssetNameExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "kAssetNameExt");
			Config.NativeFieldInfoPtr_geometryOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryOverrideLayer");
			Config.NativeFieldInfoPtr_geometryLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryLayerID");
			Config.NativeFieldInfoPtr_geometryTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryTag");
			Config.NativeFieldInfoPtr_geometryRenderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryRenderQueue");
			Config.NativeFieldInfoPtr_geometryRenderQueueHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryRenderQueueHD");
			Config.NativeFieldInfoPtr_m_RenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RenderPipeline");
			Config.NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RenderingMode");
			Config.NativeFieldInfoPtr_ditheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ditheringFactor");
			Config.NativeFieldInfoPtr_useLightColorTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "useLightColorTemperature");
			Config.NativeFieldInfoPtr_sharedMeshSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSides");
			Config.NativeFieldInfoPtr_sharedMeshSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSegments");
			Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "hdBeamsCameraBlendingDistance");
			Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "urpDepthCameraScriptableRendererIndex");
			Config.NativeFieldInfoPtr_globalNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseScale");
			Config.NativeFieldInfoPtr_globalNoiseVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseVelocity");
			Config.NativeFieldInfoPtr_fadeOutCameraTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "fadeOutCameraTag");
			Config.NativeFieldInfoPtr_noiseTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "noiseTexture3D");
			Config.NativeFieldInfoPtr_dustParticlesPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "dustParticlesPrefab");
			Config.NativeFieldInfoPtr_ditheringNoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ditheringNoiseTexture");
			Config.NativeFieldInfoPtr_jitteringNoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "jitteringNoiseTexture");
			Config.NativeFieldInfoPtr_featureEnabledColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledColorGradient");
			Config.NativeFieldInfoPtr_featureEnabledDepthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledDepthBlend");
			Config.NativeFieldInfoPtr_featureEnabledNoise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledNoise3D");
			Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledDynamicOcclusion");
			Config.NativeFieldInfoPtr_featureEnabledMeshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledMeshSkewing");
			Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledShaderAccuracyHigh");
			Config.NativeFieldInfoPtr_featureEnabledShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledShadow");
			Config.NativeFieldInfoPtr_featureEnabledCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledCookie");
			Config.NativeFieldInfoPtr_m_RaymarchingQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RaymarchingQualities");
			Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_DefaultRaymarchingQualityUniqueID");
			Config.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "pluginVersion");
			Config.NativeFieldInfoPtr__DummyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_DummyMaterial");
			Config.NativeFieldInfoPtr__DummyMaterialHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_DummyMaterialHD");
			Config.NativeFieldInfoPtr__BeamShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_BeamShader");
			Config.NativeFieldInfoPtr__BeamShaderHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_BeamShaderHD");
			Config.NativeFieldInfoPtr_m_CachedFadeOutCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_CachedFadeOutCamera");
			Config.NativeFieldInfoPtr_ms_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ms_Instance");
			Config.NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663695);
			Config.NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663696);
			Config.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663697);
			Config.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663698);
			Config.NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663699);
			Config.NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663700);
			Config.NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663701);
			Config.NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663702);
			Config.NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663703);
			Config.NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663704);
			Config.NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663705);
			Config.NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663706);
			Config.NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663707);
			Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663708);
			Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663709);
			Config.NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663710);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663711);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663712);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663713);
			Config.NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663714);
			Config.NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663715);
			Config.NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663716);
			Config.NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663717);
			Config.NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663718);
			Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663719);
			Config.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663720);
			Config.NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663721);
			Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663722);
			Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663723);
			Config.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663724);
			Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663725);
			Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663726);
			Config.NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663727);
			Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663728);
			Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100663729);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0008780C File Offset: 0x00085A0C
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00087848 File Offset: 0x00085A48
		public unsafe RenderPipeline renderPipeline
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68912, XrefRangeEnd = 68918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00087888 File Offset: 0x00085A88
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000878C4 File Offset: 0x00085AC4
		public unsafe RenderingMode renderingMode
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 41326, RefRangeEnd = 41452, XrefRangeStart = 41326, XrefRangeEnd = 41452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68918, XrefRangeEnd = 68931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00087904 File Offset: 0x00085B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68931, XrefRangeEnd = 68932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSRPBatcherSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00087940 File Offset: 0x00085B40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68933, RefRangeEnd = 68937, XrefRangeStart = 68932, XrefRangeEnd = 68933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0008798C File Offset: 0x00085B8C
		public unsafe bool SD_useSinglePassShader
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68937, XrefRangeEnd = 68938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000879C8 File Offset: 0x00085BC8
		public unsafe bool SD_requiresDoubleSidedMesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00087A04 File Offset: 0x00085C04
		[CallerCount(0)]
		public unsafe Shader GetBeamShader(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00087A50 File Offset: 0x00085C50
		[CallerCount(0)]
		public unsafe ref Shader GetBeamShaderInternal(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00087A90 File Offset: 0x00085C90
		[CallerCount(0)]
		public unsafe int GetRenderQueueInternal(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00087ADC File Offset: 0x00085CDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68970, RefRangeEnd = 68973, XrefRangeStart = 68938, XrefRangeEnd = 68970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gpuInstanced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00087B38 File Offset: 0x00085D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68978, RefRangeEnd = 68980, XrefRangeStart = 68973, XrefRangeEnd = 68978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetURPScriptableRendererIndexToDepthCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00087B7C File Offset: 0x00085D7C
		public unsafe Transform fadeOutCameraTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68980, XrefRangeEnd = 68991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00087BBC File Offset: 0x00085DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68991, XrefRangeEnd = 68998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdateFadeOutCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00087BF0 File Offset: 0x00085DF0
		public unsafe int defaultRaymarchingQualityUniqueID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 68998, RefRangeEnd = 68999, XrefRangeStart = 68998, XrefRangeEnd = 68998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00087C2C File Offset: 0x00085E2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68999, RefRangeEnd = 69002, XrefRangeStart = 68999, XrefRangeEnd = 68999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality GetRaymarchingQualityForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00087C78 File Offset: 0x00085E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69003, RefRangeEnd = 69005, XrefRangeStart = 69002, XrefRangeEnd = 69003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00087CC4 File Offset: 0x00085EC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 69010, RefRangeEnd = 69017, XrefRangeStart = 69005, XrefRangeEnd = 69010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRaymarchingQualityIndexForUniqueID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00087D10 File Offset: 0x00085F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69017, XrefRangeEnd = 69018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRaymarchingQualityUniqueIDValid(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00087D5C File Offset: 0x00085F5C
		public unsafe int raymarchingQualitiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00087D98 File Offset: 0x00085F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69040, RefRangeEnd = 69042, XrefRangeStart = 69018, XrefRangeEnd = 69040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00087DD8 File Offset: 0x00085FD8
		public unsafe bool isHDRPExposureWeightSupported
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00087E14 File Offset: 0x00086014
		public unsafe bool hasRenderPipelineMismatch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69042, XrefRangeEnd = 69043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00087E50 File Offset: 0x00086050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69043, XrefRangeEnd = 69075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStartup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00087E78 File Offset: 0x00086078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69075, XrefRangeEnd = 69101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00087EAC File Offset: 0x000860AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69101, XrefRangeEnd = 69121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshGlobalShaderProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00087EE0 File Offset: 0x000860E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69163, RefRangeEnd = 69164, XrefRangeStart = 69121, XrefRangeEnd = 69163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInternalData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00087F14 File Offset: 0x00086114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69191, RefRangeEnd = 69192, XrefRangeStart = 69164, XrefRangeEnd = 69191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem NewVolumetricDustParticles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr3) : null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00087F54 File Offset: 0x00086154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69192, XrefRangeEnd = 69193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00087F88 File Offset: 0x00086188
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00087FD4 File Offset: 0x000861D4
		public unsafe static Config Instance
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 69194, RefRangeEnd = 69212, XrefRangeStart = 69193, XrefRangeEnd = 69194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00088008 File Offset: 0x00086208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69212, XrefRangeEnd = 69215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Config LoadAssetInternal(string assetName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0008804C File Offset: 0x0008624C
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 69249, RefRangeEnd = 69348, XrefRangeStart = 69215, XrefRangeEnd = 69249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Config GetInstance(bool assertIfNotFound)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref assertIfNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0008808C File Offset: 0x0008628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69348, XrefRangeEnd = 69361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Config() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00004421 File Offset: 0x00002621
		public Config(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000880C8 File Offset: 0x000862C8
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000442A File Offset: 0x0000262A
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000880E8 File Offset: 0x000862E8
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000443C File Offset: 0x0000263C
		public unsafe static string kAssetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_kAssetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_kAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00088108 File Offset: 0x00086308
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000444E File Offset: 0x0000264E
		public unsafe static string kAssetNameExt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_kAssetNameExt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_kAssetNameExt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00088128 File Offset: 0x00086328
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00004460 File Offset: 0x00002660
		public unsafe bool geometryOverrideLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00088150 File Offset: 0x00086350
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0000447B File Offset: 0x0000267B
		public unsafe int geometryLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00088178 File Offset: 0x00086378
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00004496 File Offset: 0x00002696
		public unsafe string geometryTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000881A0 File Offset: 0x000863A0
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000044B5 File Offset: 0x000026B5
		public unsafe int geometryRenderQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x000881C8 File Offset: 0x000863C8
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x000044D0 File Offset: 0x000026D0
		public unsafe int geometryRenderQueueHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueueHD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueueHD)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000881F0 File Offset: 0x000863F0
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000044EB File Offset: 0x000026EB
		public unsafe RenderPipeline m_RenderPipeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderPipeline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderPipeline)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00088218 File Offset: 0x00086418
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00004506 File Offset: 0x00002706
		public unsafe RenderingMode m_RenderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderingMode)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00088240 File Offset: 0x00086440
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00004521 File Offset: 0x00002721
		public unsafe float ditheringFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringFactor)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00088268 File Offset: 0x00086468
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0000453C File Offset: 0x0000273C
		public unsafe bool useLightColorTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_useLightColorTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_useLightColorTemperature)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00088290 File Offset: 0x00086490
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00004557 File Offset: 0x00002757
		public unsafe int sharedMeshSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000882B8 File Offset: 0x000864B8
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00004572 File Offset: 0x00002772
		public unsafe int sharedMeshSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000882E0 File Offset: 0x000864E0
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000458D File Offset: 0x0000278D
		public unsafe float hdBeamsCameraBlendingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00088308 File Offset: 0x00086508
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000045A8 File Offset: 0x000027A8
		public unsafe int urpDepthCameraScriptableRendererIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00088330 File Offset: 0x00086530
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000045C3 File Offset: 0x000027C3
		public unsafe float globalNoiseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00088358 File Offset: 0x00086558
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000045DE File Offset: 0x000027DE
		public unsafe Vector3 globalNoiseVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00088380 File Offset: 0x00086580
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000045F9 File Offset: 0x000027F9
		public unsafe string fadeOutCameraTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000883A8 File Offset: 0x000865A8
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00004618 File Offset: 0x00002818
		public unsafe Texture3D noiseTexture3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noiseTexture3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noiseTexture3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000883D8 File Offset: 0x000865D8
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00004637 File Offset: 0x00002837
		public unsafe ParticleSystem dustParticlesPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00088408 File Offset: 0x00086608
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00004656 File Offset: 0x00002856
		public unsafe Texture2D ditheringNoiseTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringNoiseTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringNoiseTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00088438 File Offset: 0x00086638
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00004675 File Offset: 0x00002875
		public unsafe Texture2D jitteringNoiseTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_jitteringNoiseTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_jitteringNoiseTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00088468 File Offset: 0x00086668
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00004694 File Offset: 0x00002894
		public unsafe FeatureEnabledColorGradient featureEnabledColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledColorGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledColorGradient)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00088490 File Offset: 0x00086690
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000046AF File Offset: 0x000028AF
		public unsafe bool featureEnabledDepthBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDepthBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDepthBlend)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000884B8 File Offset: 0x000866B8
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000046CA File Offset: 0x000028CA
		public unsafe bool featureEnabledNoise3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledNoise3D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledNoise3D)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x000884E0 File Offset: 0x000866E0
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000046E5 File Offset: 0x000028E5
		public unsafe bool featureEnabledDynamicOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00088508 File Offset: 0x00086708
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00004700 File Offset: 0x00002900
		public unsafe bool featureEnabledMeshSkewing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledMeshSkewing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledMeshSkewing)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00088530 File Offset: 0x00086730
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0000471B File Offset: 0x0000291B
		public unsafe bool featureEnabledShaderAccuracyHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00088558 File Offset: 0x00086758
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00004736 File Offset: 0x00002936
		public unsafe bool featureEnabledShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShadow)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00088580 File Offset: 0x00086780
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00004751 File Offset: 0x00002951
		public unsafe bool featureEnabledCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledCookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledCookie)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000885A8 File Offset: 0x000867A8
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000476C File Offset: 0x0000296C
		public unsafe Il2CppReferenceArray<RaymarchingQuality> m_RaymarchingQualities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RaymarchingQualities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RaymarchingQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RaymarchingQualities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000885D8 File Offset: 0x000867D8
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x0000478B File Offset: 0x0000298B
		public unsafe int m_DefaultRaymarchingQualityUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00088600 File Offset: 0x00086800
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000047A6 File Offset: 0x000029A6
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00088628 File Offset: 0x00086828
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x000047C1 File Offset: 0x000029C1
		public unsafe Material _DummyMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00088658 File Offset: 0x00086858
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x000047E0 File Offset: 0x000029E0
		public unsafe Material _DummyMaterialHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterialHD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterialHD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00088688 File Offset: 0x00086888
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000047FF File Offset: 0x000029FF
		public unsafe Shader _BeamShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000886B8 File Offset: 0x000868B8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000481E File Offset: 0x00002A1E
		public unsafe Shader _BeamShaderHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShaderHD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShaderHD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000886E8 File Offset: 0x000868E8
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0000483D File Offset: 0x00002A3D
		public unsafe Transform m_CachedFadeOutCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00088718 File Offset: 0x00086918
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0000485C File Offset: 0x00002A5C
		public unsafe static Config ms_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ms_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Config>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ms_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_kAssetName;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_kAssetNameExt;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_geometryOverrideLayer;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_geometryLayerID;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_geometryTag;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_geometryRenderQueue;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_geometryRenderQueueHD;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPipeline;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_ditheringFactor;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_useLightColorTemperature;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSides;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSegments;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_hdBeamsCameraBlendingDistance;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseScale;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseVelocity;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutCameraTag;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_noiseTexture3D;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_dustParticlesPrefab;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_ditheringNoiseTexture;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_jitteringNoiseTexture;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledColorGradient;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledDepthBlend;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledNoise3D;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledDynamicOcclusion;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledMeshSkewing;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledShadow;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledCookie;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_m_RaymarchingQualities;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr__DummyMaterial;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr__DummyMaterialHD;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr__BeamShader;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr__BeamShaderHD;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedFadeOutCamera;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_ms_Instance;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_OnStartup_Private_Static_Void_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_ResetInternalData_Public_Void_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
