using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000164 RID: 356
	public sealed class SystemInfo : Object
	{
		// Token: 0x06001A5F RID: 6751 RVA: 0x0006F8FC File Offset: 0x0006DAFC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
			Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr);
			SystemInfo.NativeMethodInfoPtr_get_batteryLevel_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666116);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666117);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666118);
			SystemInfo.NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666119);
			SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666120);
			SystemInfo.NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666121);
			SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666122);
			SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666123);
			SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666124);
			SystemInfo.NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666125);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666126);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666127);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666128);
			SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666129);
			SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666130);
			SystemInfo.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666131);
			SystemInfo.NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666132);
			SystemInfo.NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666133);
			SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666134);
			SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666135);
			SystemInfo.NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666136);
			SystemInfo.NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666137);
			SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666138);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666139);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666140);
			SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666141);
			SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666142);
			SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666143);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666144);
			SystemInfo.NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666145);
			SystemInfo.NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666146);
			SystemInfo.NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666147);
			SystemInfo.NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666148);
			SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666149);
			SystemInfo.NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666150);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666151);
			SystemInfo.NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666152);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666153);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666154);
			SystemInfo.NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666155);
			SystemInfo.NativeMethodInfoPtr_GetBatteryLevel_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666156);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666157);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666158);
			SystemInfo.NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666159);
			SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666160);
			SystemInfo.NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666161);
			SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666162);
			SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666163);
			SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666164);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666165);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666166);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666167);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666168);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666169);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666170);
			SystemInfo.NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666171);
			SystemInfo.NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666172);
			SystemInfo.NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666173);
			SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666174);
			SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666175);
			SystemInfo.NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666176);
			SystemInfo.NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666177);
			SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666178);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666179);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666180);
			SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666181);
			SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666182);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666183);
			SystemInfo.NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666184);
			SystemInfo.NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666185);
			SystemInfo.NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666186);
			SystemInfo.NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666187);
			SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666188);
			SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666189);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666190);
			SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666191);
			SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666192);
			SystemInfo.NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666193);
			SystemInfo.NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666194);
			SystemInfo.NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666195);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666196);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666197);
			SystemInfo.NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666198);
			SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666199);
			SystemInfo.GetBatteryStatusDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryStatusDelegate>("UnityEngine.SystemInfo::GetBatteryStatus");
			SystemInfo.GetProcessorFrequencyMHzDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorFrequencyMHzDelegate>("UnityEngine.SystemInfo::GetProcessorFrequencyMHz");
			SystemInfo.GetDeviceNameDelegateField = IL2CPP.ResolveICall<SystemInfo.GetDeviceNameDelegate>("UnityEngine.SystemInfo::GetDeviceName");
			SystemInfo.SupportsAccelerometerDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAccelerometerDelegate>("UnityEngine.SystemInfo::SupportsAccelerometer");
			SystemInfo.IsGyroAvailableDelegateField = IL2CPP.ResolveICall<SystemInfo.IsGyroAvailableDelegate>("UnityEngine.SystemInfo::IsGyroAvailable");
			SystemInfo.SupportsLocationServiceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsLocationServiceDelegate>("UnityEngine.SystemInfo::SupportsLocationService");
			SystemInfo.SupportsVibrationDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVibrationDelegate>("UnityEngine.SystemInfo::SupportsVibration");
			SystemInfo.SupportsAudioDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAudioDelegate>("UnityEngine.SystemInfo::SupportsAudio");
			SystemInfo.GetGraphicsDeviceIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceID");
			SystemInfo.GetGraphicsDeviceVendorIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendorID");
			SystemInfo.GetGraphicsDeviceVersionDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVersionDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVersion");
			SystemInfo.GetGraphicsMultiThreadedDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsMultiThreadedDelegate>("UnityEngine.SystemInfo::GetGraphicsMultiThreaded");
			SystemInfo.GetRenderingThreadingModeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderingThreadingModeDelegate>("UnityEngine.SystemInfo::GetRenderingThreadingMode");
			SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate>("UnityEngine.SystemInfo::HasDynamicUniformArrayIndexingInFragmentShaders");
			SystemInfo.SupportsRawShadowDepthSamplingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRawShadowDepthSamplingDelegate>("UnityEngine.SystemInfo::SupportsRawShadowDepthSampling");
			SystemInfo.SupportsMotionVectorsDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMotionVectorsDelegate>("UnityEngine.SystemInfo::SupportsMotionVectors");
			SystemInfo.Supports3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DTexturesDelegate>("UnityEngine.SystemInfo::Supports3DTextures");
			SystemInfo.SupportsCompressed3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCompressed3DTexturesDelegate>("UnityEngine.SystemInfo::SupportsCompressed3DTextures");
			SystemInfo.Supports2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports2DArrayTexturesDelegate>("UnityEngine.SystemInfo::Supports2DArrayTextures");
			SystemInfo.Supports3DRenderTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DRenderTexturesDelegate>("UnityEngine.SystemInfo::Supports3DRenderTextures");
			SystemInfo.SupportsCubemapArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCubemapArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsCubemapArrayTextures");
			SystemInfo.SupportsAnisotropicFilterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAnisotropicFilterDelegate>("UnityEngine.SystemInfo::SupportsAnisotropicFilter");
			SystemInfo.SupportsGeometryShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGeometryShadersDelegate>("UnityEngine.SystemInfo::SupportsGeometryShaders");
			SystemInfo.SupportsTessellationShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTessellationShadersDelegate>("UnityEngine.SystemInfo::SupportsTessellationShaders");
			SystemInfo.SupportsHardwareQuadTopologyDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsHardwareQuadTopologyDelegate>("UnityEngine.SystemInfo::SupportsHardwareQuadTopology");
			SystemInfo.Supports32bitsIndexBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports32bitsIndexBufferDelegate>("UnityEngine.SystemInfo::Supports32bitsIndexBuffer");
			SystemInfo.SupportsSparseTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSparseTexturesDelegate>("UnityEngine.SystemInfo::SupportsSparseTextures");
			SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate>("UnityEngine.SystemInfo::SupportsSeparatedRenderTargetsBlend");
			SystemInfo.SupportedRandomWriteTargetCountDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportedRandomWriteTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRandomWriteTargetCount");
			SystemInfo.MaxComputeBufferInputsVertexDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsVertexDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsVertex");
			SystemInfo.MaxComputeBufferInputsFragmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsFragmentDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsFragment");
			SystemInfo.MaxComputeBufferInputsGeometryDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsGeometryDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsGeometry");
			SystemInfo.MaxComputeBufferInputsDomainDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsDomainDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsDomain");
			SystemInfo.MaxComputeBufferInputsHullDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsHullDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsHull");
			SystemInfo.MaxComputeBufferInputsComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsComputeDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsCompute");
			SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampled2DArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampled2DArrayTextures");
			SystemInfo.SupportsTextureWrapMirrorOnceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTextureWrapMirrorOnceDelegate>("UnityEngine.SystemInfo::SupportsTextureWrapMirrorOnce");
			SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsBlendingOnRenderTextureFormatNative");
			SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsRandomWriteOnRenderTextureFormatNative");
			SystemInfo.SupportsVertexAttributeFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVertexAttributeFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsVertexAttributeFormatNative");
			SystemInfo.GetNPOTSupportDelegateField = IL2CPP.ResolveICall<SystemInfo.GetNPOTSupportDelegate>("UnityEngine.SystemInfo::GetNPOTSupport");
			SystemInfo.GetMaxTexture3DSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTexture3DSizeDelegate>("UnityEngine.SystemInfo::GetMaxTexture3DSize");
			SystemInfo.GetMaxTextureArraySlicesDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTextureArraySlicesDelegate>("UnityEngine.SystemInfo::GetMaxTextureArraySlices");
			SystemInfo.GetMaxCubemapSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxCubemapSizeDelegate>("UnityEngine.SystemInfo::GetMaxCubemapSize");
			SystemInfo.GetMaxAnisotropyLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxAnisotropyLevelDelegate>("UnityEngine.SystemInfo::GetMaxAnisotropyLevel");
			SystemInfo.GetMaxComputeWorkGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSize");
			SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeXDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeX");
			SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeYDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeY");
			SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeZDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeZ");
			SystemInfo.GetComputeSubGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetComputeSubGroupSizeDelegate>("UnityEngine.SystemInfo::GetComputeSubGroupSize");
			SystemInfo.SupportsAsyncComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncComputeDelegate>("UnityEngine.SystemInfo::SupportsAsyncCompute");
			SystemInfo.SupportsGpuRecorderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGpuRecorderDelegate>("UnityEngine.SystemInfo::SupportsGpuRecorder");
			SystemInfo.SupportsAsyncGPUReadbackDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncGPUReadbackDelegate>("UnityEngine.SystemInfo::SupportsAsyncGPUReadback");
			SystemInfo.SupportsRayTracingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRayTracingDelegate>("UnityEngine.SystemInfo::SupportsRayTracing");
			SystemInfo.SupportsSetConstantBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSetConstantBufferDelegate>("UnityEngine.SystemInfo::SupportsSetConstantBuffer");
			SystemInfo.MinConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MinConstantBufferOffsetAlignmentDelegate>("UnityEngine.SystemInfo::MinConstantBufferOffsetAlignment");
			SystemInfo.MaxConstantBufferSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxConstantBufferSizeDelegate>("UnityEngine.SystemInfo::MaxConstantBufferSize");
			SystemInfo.HasMipMaxLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.HasMipMaxLevelDelegate>("UnityEngine.SystemInfo::HasMipMaxLevel");
			SystemInfo.SupportsMipStreamingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMipStreamingDelegate>("UnityEngine.SystemInfo::SupportsMipStreaming");
			SystemInfo.SupportsConservativeRasterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsConservativeRasterDelegate>("UnityEngine.SystemInfo::SupportsConservativeRaster");
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00070340 File Offset: 0x0006E540
		public unsafe static float batteryLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271793, RefRangeEnd = 1271794, XrefRangeStart = 1271791, XrefRangeEnd = 1271793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_batteryLevel_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00070370 File Offset: 0x0006E570
		public unsafe static string operatingSystem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1271796, RefRangeEnd = 1271799, XrefRangeStart = 1271794, XrefRangeEnd = 1271796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0007039C File Offset: 0x0006E59C
		public unsafe static OperatingSystemFamily operatingSystemFamily
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1271801, RefRangeEnd = 1271807, XrefRangeStart = 1271799, XrefRangeEnd = 1271801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000703CC File Offset: 0x0006E5CC
		public unsafe static string processorType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271809, RefRangeEnd = 1271811, XrefRangeStart = 1271807, XrefRangeEnd = 1271809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000703F8 File Offset: 0x0006E5F8
		public unsafe static int processorCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1271813, RefRangeEnd = 1271817, XrefRangeStart = 1271811, XrefRangeEnd = 1271813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00070428 File Offset: 0x0006E628
		public unsafe static int systemMemorySize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1271819, RefRangeEnd = 1271822, XrefRangeStart = 1271817, XrefRangeEnd = 1271819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00070458 File Offset: 0x0006E658
		public unsafe static string deviceUniqueIdentifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271824, RefRangeEnd = 1271825, XrefRangeStart = 1271822, XrefRangeEnd = 1271824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00070484 File Offset: 0x0006E684
		public unsafe static string deviceModel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271827, RefRangeEnd = 1271828, XrefRangeStart = 1271825, XrefRangeEnd = 1271827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000704B0 File Offset: 0x0006E6B0
		public unsafe static DeviceType deviceType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271830, RefRangeEnd = 1271832, XrefRangeStart = 1271828, XrefRangeEnd = 1271830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000704E0 File Offset: 0x0006E6E0
		public unsafe static int graphicsMemorySize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271834, RefRangeEnd = 1271835, XrefRangeStart = 1271832, XrefRangeEnd = 1271834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00070510 File Offset: 0x0006E710
		public unsafe static string graphicsDeviceName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1271837, RefRangeEnd = 1271840, XrefRangeStart = 1271835, XrefRangeEnd = 1271837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0007053C File Offset: 0x0006E73C
		public unsafe static string graphicsDeviceVendor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271842, RefRangeEnd = 1271844, XrefRangeStart = 1271840, XrefRangeEnd = 1271842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00070568 File Offset: 0x0006E768
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 1271846, RefRangeEnd = 1271904, XrefRangeStart = 1271844, XrefRangeEnd = 1271846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00070598 File Offset: 0x0006E798
		public unsafe static bool graphicsUVStartsAtTop
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1271906, RefRangeEnd = 1271920, XrefRangeStart = 1271904, XrefRangeEnd = 1271906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x000705C8 File Offset: 0x0006E7C8
		public unsafe static int graphicsShaderLevel
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1271922, RefRangeEnd = 1271934, XrefRangeStart = 1271920, XrefRangeEnd = 1271922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000705F8 File Offset: 0x0006E7F8
		public unsafe static UnityEngine.Rendering.FoveatedRenderingCaps foveatedRenderingCaps
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1271936, RefRangeEnd = 1271940, XrefRangeStart = 1271934, XrefRangeEnd = 1271936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00070628 File Offset: 0x0006E828
		public unsafe static bool hasHiddenSurfaceRemovalOnGPU
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271942, RefRangeEnd = 1271943, XrefRangeStart = 1271940, XrefRangeEnd = 1271942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x00070658 File Offset: 0x0006E858
		public unsafe static bool supportsShadows
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271945, RefRangeEnd = 1271947, XrefRangeStart = 1271943, XrefRangeEnd = 1271945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x00070688 File Offset: 0x0006E888
		public unsafe static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271949, RefRangeEnd = 1271951, XrefRangeStart = 1271947, XrefRangeEnd = 1271949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000706B8 File Offset: 0x0006E8B8
		public unsafe static bool supportsComputeShaders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271953, RefRangeEnd = 1271954, XrefRangeStart = 1271951, XrefRangeEnd = 1271953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000706E8 File Offset: 0x0006E8E8
		public unsafe static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271956, RefRangeEnd = 1271957, XrefRangeStart = 1271954, XrefRangeEnd = 1271956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00070718 File Offset: 0x0006E918
		public unsafe static bool supportsInstancing
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1271959, RefRangeEnd = 1271968, XrefRangeStart = 1271957, XrefRangeEnd = 1271959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00070748 File Offset: 0x0006E948
		public unsafe static int supportedRenderTargetCount
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1271970, RefRangeEnd = 1271980, XrefRangeStart = 1271968, XrefRangeEnd = 1271970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00070778 File Offset: 0x0006E978
		public unsafe static int supportsMultisampledTextures
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1271982, RefRangeEnd = 1271986, XrefRangeStart = 1271980, XrefRangeEnd = 1271982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000707A8 File Offset: 0x0006E9A8
		public unsafe static bool supportsMultisampleAutoResolve
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1271988, RefRangeEnd = 1271992, XrefRangeStart = 1271986, XrefRangeEnd = 1271988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x000707D8 File Offset: 0x0006E9D8
		public unsafe static bool usesReversedZBuffer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1271994, RefRangeEnd = 1272004, XrefRangeStart = 1271992, XrefRangeEnd = 1271994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00070808 File Offset: 0x0006EA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272004, XrefRangeEnd = 1272009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidEnumValue(Enum value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0007084C File Offset: 0x0006EA4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1272019, RefRangeEnd = 1272029, XrefRangeStart = 1272009, XrefRangeEnd = 1272019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0007088C File Offset: 0x0006EA8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272039, RefRangeEnd = 1272041, XrefRangeStart = 1272029, XrefRangeEnd = 1272039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormat(TextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000708CC File Offset: 0x0006EACC
		public unsafe static int maxTextureSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1272043, RefRangeEnd = 1272047, XrefRangeStart = 1272041, XrefRangeEnd = 1272043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x000708FC File Offset: 0x0006EAFC
		public unsafe static int maxRenderTextureSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1272049, RefRangeEnd = 1272051, XrefRangeStart = 1272047, XrefRangeEnd = 1272049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0007092C File Offset: 0x0006EB2C
		public unsafe static bool supportsGraphicsFence
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1272053, RefRangeEnd = 1272058, XrefRangeStart = 1272051, XrefRangeEnd = 1272053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0007095C File Offset: 0x0006EB5C
		public unsafe static long maxGraphicsBufferSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272060, RefRangeEnd = 1272061, XrefRangeStart = 1272058, XrefRangeEnd = 1272060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0007098C File Offset: 0x0006EB8C
		public unsafe static bool usesLoadStoreActions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1272063, RefRangeEnd = 1272065, XrefRangeStart = 1272061, XrefRangeEnd = 1272063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x000709BC File Offset: 0x0006EBBC
		public unsafe static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1272067, RefRangeEnd = 1272070, XrefRangeStart = 1272065, XrefRangeEnd = 1272067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x000709EC File Offset: 0x0006EBEC
		public unsafe static bool supportsMultiview
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1272072, RefRangeEnd = 1272077, XrefRangeStart = 1272070, XrefRangeEnd = 1272072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00070A1C File Offset: 0x0006EC1C
		public unsafe static bool supportsStoreAndResolveAction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272079, RefRangeEnd = 1272080, XrefRangeStart = 1272077, XrefRangeEnd = 1272079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00070A4C File Offset: 0x0006EC4C
		public unsafe static bool supportsMultisampleResolveDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272082, RefRangeEnd = 1272083, XrefRangeStart = 1272080, XrefRangeEnd = 1272082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00070A7C File Offset: 0x0006EC7C
		public unsafe static bool supportsMultisampleResolveStencil
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272085, RefRangeEnd = 1272086, XrefRangeStart = 1272083, XrefRangeEnd = 1272085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00070AAC File Offset: 0x0006ECAC
		public unsafe static bool supportsIndirectArgumentsBuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272088, RefRangeEnd = 1272089, XrefRangeStart = 1272086, XrefRangeEnd = 1272088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00070ADC File Offset: 0x0006ECDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271793, RefRangeEnd = 1271794, XrefRangeStart = 1271793, XrefRangeEnd = 1271794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetBatteryLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetBatteryLevel_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00070B0C File Offset: 0x0006ED0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271796, RefRangeEnd = 1271799, XrefRangeStart = 1271796, XrefRangeEnd = 1271799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOperatingSystem()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00070B38 File Offset: 0x0006ED38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1271801, RefRangeEnd = 1271807, XrefRangeStart = 1271801, XrefRangeEnd = 1271807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OperatingSystemFamily GetOperatingSystemFamily()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00070B68 File Offset: 0x0006ED68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271809, RefRangeEnd = 1271811, XrefRangeStart = 1271809, XrefRangeEnd = 1271811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetProcessorType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00070B94 File Offset: 0x0006ED94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1271813, RefRangeEnd = 1271817, XrefRangeStart = 1271813, XrefRangeEnd = 1271817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessorCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00070BC4 File Offset: 0x0006EDC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271819, RefRangeEnd = 1271822, XrefRangeStart = 1271819, XrefRangeEnd = 1271822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPhysicalMemoryMB()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271824, RefRangeEnd = 1271825, XrefRangeStart = 1271824, XrefRangeEnd = 1271825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceUniqueIdentifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00070C20 File Offset: 0x0006EE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271827, RefRangeEnd = 1271828, XrefRangeStart = 1271827, XrefRangeEnd = 1271828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceModel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00070C4C File Offset: 0x0006EE4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271830, RefRangeEnd = 1271832, XrefRangeStart = 1271830, XrefRangeEnd = 1271832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeviceType GetDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00070C7C File Offset: 0x0006EE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271834, RefRangeEnd = 1271835, XrefRangeStart = 1271834, XrefRangeEnd = 1271835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsMemorySize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00070CAC File Offset: 0x0006EEAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271837, RefRangeEnd = 1271840, XrefRangeStart = 1271837, XrefRangeEnd = 1271840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphicsDeviceName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00070CD8 File Offset: 0x0006EED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271842, RefRangeEnd = 1271844, XrefRangeStart = 1271842, XrefRangeEnd = 1271844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphicsDeviceVendor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00070D04 File Offset: 0x0006EF04
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1271846, RefRangeEnd = 1271904, XrefRangeStart = 1271846, XrefRangeEnd = 1271904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00070D34 File Offset: 0x0006EF34
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1271906, RefRangeEnd = 1271920, XrefRangeStart = 1271906, XrefRangeEnd = 1271920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGraphicsUVStartsAtTop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00070D64 File Offset: 0x0006EF64
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1271922, RefRangeEnd = 1271934, XrefRangeStart = 1271922, XrefRangeEnd = 1271934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsShaderLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00070D94 File Offset: 0x0006EF94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1271936, RefRangeEnd = 1271940, XrefRangeStart = 1271936, XrefRangeEnd = 1271940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271942, RefRangeEnd = 1271943, XrefRangeStart = 1271942, XrefRangeEnd = 1271943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasHiddenSurfaceRemovalOnGPU()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00070DF4 File Offset: 0x0006EFF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271945, RefRangeEnd = 1271947, XrefRangeStart = 1271945, XrefRangeEnd = 1271947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsShadows()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00070E24 File Offset: 0x0006F024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271949, RefRangeEnd = 1271951, XrefRangeStart = 1271949, XrefRangeEnd = 1271951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00070E54 File Offset: 0x0006F054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271953, RefRangeEnd = 1271954, XrefRangeStart = 1271953, XrefRangeEnd = 1271954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsComputeShaders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00070E84 File Offset: 0x0006F084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271956, RefRangeEnd = 1271957, XrefRangeStart = 1271956, XrefRangeEnd = 1271957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00070EB4 File Offset: 0x0006F0B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1271959, RefRangeEnd = 1271968, XrefRangeStart = 1271959, XrefRangeEnd = 1271968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsInstancing()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00070EE4 File Offset: 0x0006F0E4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1271970, RefRangeEnd = 1271980, XrefRangeStart = 1271970, XrefRangeEnd = 1271980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SupportedRenderTargetCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00070F14 File Offset: 0x0006F114
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1271982, RefRangeEnd = 1271986, XrefRangeStart = 1271982, XrefRangeEnd = 1271986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SupportsMultisampledTextures()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00070F44 File Offset: 0x0006F144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1271988, RefRangeEnd = 1271992, XrefRangeStart = 1271988, XrefRangeEnd = 1271992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleAutoResolve()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00070F74 File Offset: 0x0006F174
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1271994, RefRangeEnd = 1272004, XrefRangeStart = 1271994, XrefRangeEnd = 1272004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesReversedZBuffer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272089, XrefRangeEnd = 1272091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00070FE4 File Offset: 0x0006F1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272091, XrefRangeEnd = 1272093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormatNative(TextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00071024 File Offset: 0x0006F224
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1272043, RefRangeEnd = 1272047, XrefRangeStart = 1272043, XrefRangeEnd = 1272047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxTextureSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00071054 File Offset: 0x0006F254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272049, RefRangeEnd = 1272051, XrefRangeStart = 1272049, XrefRangeEnd = 1272051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxRenderTextureSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00071084 File Offset: 0x0006F284
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1272053, RefRangeEnd = 1272058, XrefRangeStart = 1272053, XrefRangeEnd = 1272058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsGPUFence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000710B4 File Offset: 0x0006F2B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272060, RefRangeEnd = 1272061, XrefRangeStart = 1272060, XrefRangeEnd = 1272061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long MaxGraphicsBufferSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000710E4 File Offset: 0x0006F2E4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1272095, RefRangeEnd = 1272124, XrefRangeStart = 1272093, XrefRangeEnd = 1272095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00071130 File Offset: 0x0006F330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1272126, RefRangeEnd = 1272129, XrefRangeStart = 1272124, XrefRangeEnd = 1272126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0007117C File Offset: 0x0006F37C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1272131, RefRangeEnd = 1272151, XrefRangeStart = 1272129, XrefRangeEnd = 1272131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000711BC File Offset: 0x0006F3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272153, RefRangeEnd = 1272154, XrefRangeStart = 1272151, XrefRangeEnd = 1272153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000711FC File Offset: 0x0006F3FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272063, RefRangeEnd = 1272065, XrefRangeStart = 1272063, XrefRangeEnd = 1272065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesLoadStoreActions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0007122C File Offset: 0x0006F42C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1272067, RefRangeEnd = 1272070, XrefRangeStart = 1272067, XrefRangeEnd = 1272070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0007125C File Offset: 0x0006F45C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1272072, RefRangeEnd = 1272077, XrefRangeStart = 1272072, XrefRangeEnd = 1272077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultiview()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0007128C File Offset: 0x0006F48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272079, RefRangeEnd = 1272080, XrefRangeStart = 1272079, XrefRangeEnd = 1272080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsStoreAndResolveAction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000712BC File Offset: 0x0006F4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272082, RefRangeEnd = 1272083, XrefRangeStart = 1272082, XrefRangeEnd = 1272083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleResolveDepth()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000712EC File Offset: 0x0006F4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272085, RefRangeEnd = 1272086, XrefRangeStart = 1272085, XrefRangeEnd = 1272086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleResolveStencil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007131C File Offset: 0x0006F51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272088, RefRangeEnd = 1272089, XrefRangeStart = 1272088, XrefRangeEnd = 1272089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsIndirectArgumentsBuffer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0007134C File Offset: 0x0006F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272154, XrefRangeEnd = 1272156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		public SystemInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0007138C File Offset: 0x0006F58C
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.GetBatteryStatus();
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000713A4 File Offset: 0x0006F5A4
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.GetProcessorFrequencyMHz();
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x000713BC File Offset: 0x0006F5BC
		public static string deviceName
		{
			get
			{
				return SystemInfo.GetDeviceName();
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x000713D4 File Offset: 0x0006F5D4
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.SupportsAccelerometer();
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x000713EC File Offset: 0x0006F5EC
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.IsGyroAvailable();
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00071404 File Offset: 0x0006F604
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.SupportsLocationService();
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0007141C File Offset: 0x0006F61C
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.SupportsVibration();
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00071434 File Offset: 0x0006F634
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.SupportsAudio();
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0007144C File Offset: 0x0006F64C
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceID();
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00071464 File Offset: 0x0006F664
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendorID();
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0007147C File Offset: 0x0006F67C
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVersion();
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00071494 File Offset: 0x0006F694
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.GetGraphicsMultiThreaded();
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000714AC File Offset: 0x0006F6AC
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.GetRenderingThreadingMode();
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000714C4 File Offset: 0x0006F6C4
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShaders();
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000714DC File Offset: 0x0006F6DC
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.SupportsRawShadowDepthSampling();
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x000714F4 File Offset: 0x0006F6F4
		public static bool supportsRenderTextures
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00071508 File Offset: 0x0006F708
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.SupportsMotionVectors();
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00071520 File Offset: 0x0006F720
		public static bool supportsRenderToCubemap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00071534 File Offset: 0x0006F734
		public static bool supportsImageEffects
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00071548 File Offset: 0x0006F748
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.Supports3DTextures();
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00071560 File Offset: 0x0006F760
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.SupportsCompressed3DTextures();
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00071578 File Offset: 0x0006F778
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.Supports2DArrayTextures();
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00071590 File Offset: 0x0006F790
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.Supports3DRenderTextures();
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000715A8 File Offset: 0x0006F7A8
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.SupportsCubemapArrayTextures();
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000715C0 File Offset: 0x0006F7C0
		public static bool supportsAnisotropicFilter
		{
			get
			{
				return SystemInfo.SupportsAnisotropicFilter();
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000715D8 File Offset: 0x0006F7D8
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.SupportsGeometryShaders();
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000715F0 File Offset: 0x0006F7F0
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.SupportsTessellationShaders();
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00071608 File Offset: 0x0006F808
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.SupportsHardwareQuadTopology();
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00071620 File Offset: 0x0006F820
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.Supports32bitsIndexBuffer();
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x00071638 File Offset: 0x0006F838
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.SupportsSparseTextures();
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x00071650 File Offset: 0x0006F850
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.SupportsSeparatedRenderTargetsBlend();
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00071668 File Offset: 0x0006F868
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.SupportedRandomWriteTargetCount();
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00071680 File Offset: 0x0006F880
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampled2DArrayTextures();
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00071698 File Offset: 0x0006F898
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.SupportsTextureWrapMirrorOnce();
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000716B0 File Offset: 0x0006F8B0
		public static int supportsStencil
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000716C4 File Offset: 0x0006F8C4
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsBlendingOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000716FC File Offset: 0x0006F8FC
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsRandomWriteOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00071734 File Offset: 0x0006F934
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; format is not a valid VertexAttributeFormat");
			}
			bool flag2 = dimension < 1 || dimension > 4;
			if (flag2)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; dimension must be in 1..4 range");
			}
			return SystemInfo.SupportsVertexAttributeFormatNative(format, dimension);
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00071784 File Offset: 0x0006F984
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.GetNPOTSupport();
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0007179C File Offset: 0x0006F99C
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.GetMaxTexture3DSize();
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000717B4 File Offset: 0x0006F9B4
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.GetMaxTextureArraySlices();
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000717CC File Offset: 0x0006F9CC
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.GetMaxCubemapSize();
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000717E4 File Offset: 0x0006F9E4
		public static int maxAnisotropyLevel
		{
			get
			{
				return SystemInfo.GetMaxAnisotropyLevel();
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000717FC File Offset: 0x0006F9FC
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsVertex();
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x00071814 File Offset: 0x0006FA14
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsFragment();
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0007182C File Offset: 0x0006FA2C
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsGeometry();
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00071844 File Offset: 0x0006FA44
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsDomain();
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0007185C File Offset: 0x0006FA5C
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsHull();
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x00071874 File Offset: 0x0006FA74
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsCompute();
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0007188C File Offset: 0x0006FA8C
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSize();
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000718A4 File Offset: 0x0006FAA4
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeX();
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x000718BC File Offset: 0x0006FABC
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeY();
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000718D4 File Offset: 0x0006FAD4
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeZ();
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x000718EC File Offset: 0x0006FAEC
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.GetComputeSubGroupSize();
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x00071904 File Offset: 0x0006FB04
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.SupportsAsyncCompute();
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0007191C File Offset: 0x0006FB1C
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.SupportsGpuRecorder();
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x00071934 File Offset: 0x0006FB34
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.SupportsAsyncGPUReadback();
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0007194C File Offset: 0x0006FB4C
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.SupportsRayTracing();
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00071964 File Offset: 0x0006FB64
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.SupportsSetConstantBuffer();
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0007197C File Offset: 0x0006FB7C
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.MinConstantBufferOffsetAlignment();
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00071994 File Offset: 0x0006FB94
		public static int maxConstantBufferSize
		{
			get
			{
				return SystemInfo.MaxConstantBufferSize();
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000719AC File Offset: 0x0006FBAC
		public static bool minConstantBufferOffsetAlignment
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000719C0 File Offset: 0x0006FBC0
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.HasMipMaxLevel();
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000719D8 File Offset: 0x0006FBD8
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.SupportsMipStreaming();
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000719F0 File Offset: 0x0006FBF0
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00071A04 File Offset: 0x0006FC04
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.SupportsConservativeRaster();
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00071A1C File Offset: 0x0006FC1C
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0000CDDD File Offset: 0x0000AFDD
		public static BatteryStatus GetBatteryStatus()
		{
			return SystemInfo.GetBatteryStatusDelegateField();
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0000CDE9 File Offset: 0x0000AFE9
		public static int GetProcessorFrequencyMHz()
		{
			return SystemInfo.GetProcessorFrequencyMHzDelegateField();
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00071A30 File Offset: 0x0006FC30
		public static string GetDeviceName()
		{
			IntPtr intPtr = SystemInfo.GetDeviceNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0000CDF5 File Offset: 0x0000AFF5
		public static bool SupportsAccelerometer()
		{
			return SystemInfo.SupportsAccelerometerDelegateField();
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0000CE01 File Offset: 0x0000B001
		public static bool IsGyroAvailable()
		{
			return SystemInfo.IsGyroAvailableDelegateField();
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000CE0D File Offset: 0x0000B00D
		public static bool SupportsLocationService()
		{
			return SystemInfo.SupportsLocationServiceDelegateField();
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0000CE19 File Offset: 0x0000B019
		public static bool SupportsVibration()
		{
			return SystemInfo.SupportsVibrationDelegateField();
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000CE25 File Offset: 0x0000B025
		public static bool SupportsAudio()
		{
			return SystemInfo.SupportsAudioDelegateField();
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000CE31 File Offset: 0x0000B031
		public static int GetGraphicsDeviceID()
		{
			return SystemInfo.GetGraphicsDeviceIDDelegateField();
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0000CE3D File Offset: 0x0000B03D
		public static int GetGraphicsDeviceVendorID()
		{
			return SystemInfo.GetGraphicsDeviceVendorIDDelegateField();
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00071A50 File Offset: 0x0006FC50
		public static string GetGraphicsDeviceVersion()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceVersionDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0000CE49 File Offset: 0x0000B049
		public static bool GetGraphicsMultiThreaded()
		{
			return SystemInfo.GetGraphicsMultiThreadedDelegateField();
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0000CE55 File Offset: 0x0000B055
		public static UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode()
		{
			return SystemInfo.GetRenderingThreadingModeDelegateField();
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000CE61 File Offset: 0x0000B061
		public static bool HasDynamicUniformArrayIndexingInFragmentShaders()
		{
			return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000CE6D File Offset: 0x0000B06D
		public static bool SupportsRawShadowDepthSampling()
		{
			return SystemInfo.SupportsRawShadowDepthSamplingDelegateField();
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0000CE79 File Offset: 0x0000B079
		public static bool SupportsMotionVectors()
		{
			return SystemInfo.SupportsMotionVectorsDelegateField();
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0000CE85 File Offset: 0x0000B085
		public static bool Supports3DTextures()
		{
			return SystemInfo.Supports3DTexturesDelegateField();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000CE91 File Offset: 0x0000B091
		public static bool SupportsCompressed3DTextures()
		{
			return SystemInfo.SupportsCompressed3DTexturesDelegateField();
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0000CE9D File Offset: 0x0000B09D
		public static bool Supports2DArrayTextures()
		{
			return SystemInfo.Supports2DArrayTexturesDelegateField();
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0000CEA9 File Offset: 0x0000B0A9
		public static bool Supports3DRenderTextures()
		{
			return SystemInfo.Supports3DRenderTexturesDelegateField();
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
		public static bool SupportsCubemapArrayTextures()
		{
			return SystemInfo.SupportsCubemapArrayTexturesDelegateField();
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000CEC1 File Offset: 0x0000B0C1
		public static bool SupportsAnisotropicFilter()
		{
			return SystemInfo.SupportsAnisotropicFilterDelegateField();
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public static bool SupportsGeometryShaders()
		{
			return SystemInfo.SupportsGeometryShadersDelegateField();
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0000CED9 File Offset: 0x0000B0D9
		public static bool SupportsTessellationShaders()
		{
			return SystemInfo.SupportsTessellationShadersDelegateField();
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0000CEE5 File Offset: 0x0000B0E5
		public static bool SupportsHardwareQuadTopology()
		{
			return SystemInfo.SupportsHardwareQuadTopologyDelegateField();
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		public static bool Supports32bitsIndexBuffer()
		{
			return SystemInfo.Supports32bitsIndexBufferDelegateField();
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0000CEFD File Offset: 0x0000B0FD
		public static bool SupportsSparseTextures()
		{
			return SystemInfo.SupportsSparseTexturesDelegateField();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000CF09 File Offset: 0x0000B109
		public static bool SupportsSeparatedRenderTargetsBlend()
		{
			return SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField();
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0000CF15 File Offset: 0x0000B115
		public static int SupportedRandomWriteTargetCount()
		{
			return SystemInfo.SupportedRandomWriteTargetCountDelegateField();
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0000CF21 File Offset: 0x0000B121
		public static int MaxComputeBufferInputsVertex()
		{
			return SystemInfo.MaxComputeBufferInputsVertexDelegateField();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0000CF2D File Offset: 0x0000B12D
		public static int MaxComputeBufferInputsFragment()
		{
			return SystemInfo.MaxComputeBufferInputsFragmentDelegateField();
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0000CF39 File Offset: 0x0000B139
		public static int MaxComputeBufferInputsGeometry()
		{
			return SystemInfo.MaxComputeBufferInputsGeometryDelegateField();
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0000CF45 File Offset: 0x0000B145
		public static int MaxComputeBufferInputsDomain()
		{
			return SystemInfo.MaxComputeBufferInputsDomainDelegateField();
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0000CF51 File Offset: 0x0000B151
		public static int MaxComputeBufferInputsHull()
		{
			return SystemInfo.MaxComputeBufferInputsHullDelegateField();
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0000CF5D File Offset: 0x0000B15D
		public static int MaxComputeBufferInputsCompute()
		{
			return SystemInfo.MaxComputeBufferInputsComputeDelegateField();
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0000CF69 File Offset: 0x0000B169
		public static bool SupportsMultisampled2DArrayTextures()
		{
			return SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000CF75 File Offset: 0x0000B175
		public static int SupportsTextureWrapMirrorOnce()
		{
			return SystemInfo.SupportsTextureWrapMirrorOnceDelegateField();
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0000CF81 File Offset: 0x0000B181
		public static bool SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0000CF8E File Offset: 0x0000B18E
		public static bool SupportsRandomWriteOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0000CF9B File Offset: 0x0000B19B
		public static bool SupportsVertexAttributeFormatNative(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormatNativeDelegateField(format, dimension);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0000CFA9 File Offset: 0x0000B1A9
		public static NPOTSupport GetNPOTSupport()
		{
			return SystemInfo.GetNPOTSupportDelegateField();
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0000CFB5 File Offset: 0x0000B1B5
		public static int GetMaxTexture3DSize()
		{
			return SystemInfo.GetMaxTexture3DSizeDelegateField();
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0000CFC1 File Offset: 0x0000B1C1
		public static int GetMaxTextureArraySlices()
		{
			return SystemInfo.GetMaxTextureArraySlicesDelegateField();
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0000CFCD File Offset: 0x0000B1CD
		public static int GetMaxCubemapSize()
		{
			return SystemInfo.GetMaxCubemapSizeDelegateField();
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000CFD9 File Offset: 0x0000B1D9
		public static int GetMaxAnisotropyLevel()
		{
			return SystemInfo.GetMaxAnisotropyLevelDelegateField();
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		public static int GetMaxComputeWorkGroupSize()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeDelegateField();
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0000CFF1 File Offset: 0x0000B1F1
		public static int GetMaxComputeWorkGroupSizeX()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0000CFFD File Offset: 0x0000B1FD
		public static int GetMaxComputeWorkGroupSizeY()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField();
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0000D009 File Offset: 0x0000B209
		public static int GetMaxComputeWorkGroupSizeZ()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField();
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000D015 File Offset: 0x0000B215
		public static int GetComputeSubGroupSize()
		{
			return SystemInfo.GetComputeSubGroupSizeDelegateField();
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0000D021 File Offset: 0x0000B221
		public static bool SupportsAsyncCompute()
		{
			return SystemInfo.SupportsAsyncComputeDelegateField();
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000D02D File Offset: 0x0000B22D
		public static bool SupportsGpuRecorder()
		{
			return SystemInfo.SupportsGpuRecorderDelegateField();
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0000D039 File Offset: 0x0000B239
		public static bool SupportsAsyncGPUReadback()
		{
			return SystemInfo.SupportsAsyncGPUReadbackDelegateField();
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0000D045 File Offset: 0x0000B245
		public static bool SupportsRayTracing()
		{
			return SystemInfo.SupportsRayTracingDelegateField();
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000D051 File Offset: 0x0000B251
		public static bool SupportsSetConstantBuffer()
		{
			return SystemInfo.SupportsSetConstantBufferDelegateField();
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000D05D File Offset: 0x0000B25D
		public static int MinConstantBufferOffsetAlignment()
		{
			return SystemInfo.MinConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000D069 File Offset: 0x0000B269
		public static int MaxConstantBufferSize()
		{
			return SystemInfo.MaxConstantBufferSizeDelegateField();
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0000D075 File Offset: 0x0000B275
		public static bool HasMipMaxLevel()
		{
			return SystemInfo.HasMipMaxLevelDelegateField();
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0000D081 File Offset: 0x0000B281
		public static bool SupportsMipStreaming()
		{
			return SystemInfo.SupportsMipStreamingDelegateField();
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000D08D File Offset: 0x0000B28D
		public static bool SupportsConservativeRaster()
		{
			return SystemInfo.SupportsConservativeRasterDelegateField();
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x00071A70 File Offset: 0x0006FC70
		public static bool supportsGPUFence
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_get_batteryLevel_Public_Static_get_Single_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_GetBatteryLevel_Private_Static_Single_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0;

		// Token: 0x04001620 RID: 5664
		public const string unsupportedIdentifier = "n/a";

		// Token: 0x04001621 RID: 5665
		private static readonly SystemInfo.GetBatteryStatusDelegate GetBatteryStatusDelegateField;

		// Token: 0x04001622 RID: 5666
		private static readonly SystemInfo.GetProcessorFrequencyMHzDelegate GetProcessorFrequencyMHzDelegateField;

		// Token: 0x04001623 RID: 5667
		private static readonly SystemInfo.GetDeviceNameDelegate GetDeviceNameDelegateField;

		// Token: 0x04001624 RID: 5668
		private static readonly SystemInfo.SupportsAccelerometerDelegate SupportsAccelerometerDelegateField;

		// Token: 0x04001625 RID: 5669
		private static readonly SystemInfo.IsGyroAvailableDelegate IsGyroAvailableDelegateField;

		// Token: 0x04001626 RID: 5670
		private static readonly SystemInfo.SupportsLocationServiceDelegate SupportsLocationServiceDelegateField;

		// Token: 0x04001627 RID: 5671
		private static readonly SystemInfo.SupportsVibrationDelegate SupportsVibrationDelegateField;

		// Token: 0x04001628 RID: 5672
		private static readonly SystemInfo.SupportsAudioDelegate SupportsAudioDelegateField;

		// Token: 0x04001629 RID: 5673
		private static readonly SystemInfo.GetGraphicsDeviceIDDelegate GetGraphicsDeviceIDDelegateField;

		// Token: 0x0400162A RID: 5674
		private static readonly SystemInfo.GetGraphicsDeviceVendorIDDelegate GetGraphicsDeviceVendorIDDelegateField;

		// Token: 0x0400162B RID: 5675
		private static readonly SystemInfo.GetGraphicsDeviceVersionDelegate GetGraphicsDeviceVersionDelegateField;

		// Token: 0x0400162C RID: 5676
		private static readonly SystemInfo.GetGraphicsMultiThreadedDelegate GetGraphicsMultiThreadedDelegateField;

		// Token: 0x0400162D RID: 5677
		private static readonly SystemInfo.GetRenderingThreadingModeDelegate GetRenderingThreadingModeDelegateField;

		// Token: 0x0400162E RID: 5678
		private static readonly SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate HasDynamicUniformArrayIndexingInFragmentShadersDelegateField;

		// Token: 0x0400162F RID: 5679
		private static readonly SystemInfo.SupportsRawShadowDepthSamplingDelegate SupportsRawShadowDepthSamplingDelegateField;

		// Token: 0x04001630 RID: 5680
		private static readonly SystemInfo.SupportsMotionVectorsDelegate SupportsMotionVectorsDelegateField;

		// Token: 0x04001631 RID: 5681
		private static readonly SystemInfo.Supports3DTexturesDelegate Supports3DTexturesDelegateField;

		// Token: 0x04001632 RID: 5682
		private static readonly SystemInfo.SupportsCompressed3DTexturesDelegate SupportsCompressed3DTexturesDelegateField;

		// Token: 0x04001633 RID: 5683
		private static readonly SystemInfo.Supports2DArrayTexturesDelegate Supports2DArrayTexturesDelegateField;

		// Token: 0x04001634 RID: 5684
		private static readonly SystemInfo.Supports3DRenderTexturesDelegate Supports3DRenderTexturesDelegateField;

		// Token: 0x04001635 RID: 5685
		private static readonly SystemInfo.SupportsCubemapArrayTexturesDelegate SupportsCubemapArrayTexturesDelegateField;

		// Token: 0x04001636 RID: 5686
		private static readonly SystemInfo.SupportsAnisotropicFilterDelegate SupportsAnisotropicFilterDelegateField;

		// Token: 0x04001637 RID: 5687
		private static readonly SystemInfo.SupportsGeometryShadersDelegate SupportsGeometryShadersDelegateField;

		// Token: 0x04001638 RID: 5688
		private static readonly SystemInfo.SupportsTessellationShadersDelegate SupportsTessellationShadersDelegateField;

		// Token: 0x04001639 RID: 5689
		private static readonly SystemInfo.SupportsHardwareQuadTopologyDelegate SupportsHardwareQuadTopologyDelegateField;

		// Token: 0x0400163A RID: 5690
		private static readonly SystemInfo.Supports32bitsIndexBufferDelegate Supports32bitsIndexBufferDelegateField;

		// Token: 0x0400163B RID: 5691
		private static readonly SystemInfo.SupportsSparseTexturesDelegate SupportsSparseTexturesDelegateField;

		// Token: 0x0400163C RID: 5692
		private static readonly SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate SupportsSeparatedRenderTargetsBlendDelegateField;

		// Token: 0x0400163D RID: 5693
		private static readonly SystemInfo.SupportedRandomWriteTargetCountDelegate SupportedRandomWriteTargetCountDelegateField;

		// Token: 0x0400163E RID: 5694
		private static readonly SystemInfo.MaxComputeBufferInputsVertexDelegate MaxComputeBufferInputsVertexDelegateField;

		// Token: 0x0400163F RID: 5695
		private static readonly SystemInfo.MaxComputeBufferInputsFragmentDelegate MaxComputeBufferInputsFragmentDelegateField;

		// Token: 0x04001640 RID: 5696
		private static readonly SystemInfo.MaxComputeBufferInputsGeometryDelegate MaxComputeBufferInputsGeometryDelegateField;

		// Token: 0x04001641 RID: 5697
		private static readonly SystemInfo.MaxComputeBufferInputsDomainDelegate MaxComputeBufferInputsDomainDelegateField;

		// Token: 0x04001642 RID: 5698
		private static readonly SystemInfo.MaxComputeBufferInputsHullDelegate MaxComputeBufferInputsHullDelegateField;

		// Token: 0x04001643 RID: 5699
		private static readonly SystemInfo.MaxComputeBufferInputsComputeDelegate MaxComputeBufferInputsComputeDelegateField;

		// Token: 0x04001644 RID: 5700
		private static readonly SystemInfo.SupportsMultisampled2DArrayTexturesDelegate SupportsMultisampled2DArrayTexturesDelegateField;

		// Token: 0x04001645 RID: 5701
		private static readonly SystemInfo.SupportsTextureWrapMirrorOnceDelegate SupportsTextureWrapMirrorOnceDelegateField;

		// Token: 0x04001646 RID: 5702
		private static readonly SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate SupportsBlendingOnRenderTextureFormatNativeDelegateField;

		// Token: 0x04001647 RID: 5703
		private static readonly SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate SupportsRandomWriteOnRenderTextureFormatNativeDelegateField;

		// Token: 0x04001648 RID: 5704
		private static readonly SystemInfo.SupportsVertexAttributeFormatNativeDelegate SupportsVertexAttributeFormatNativeDelegateField;

		// Token: 0x04001649 RID: 5705
		private static readonly SystemInfo.GetNPOTSupportDelegate GetNPOTSupportDelegateField;

		// Token: 0x0400164A RID: 5706
		private static readonly SystemInfo.GetMaxTexture3DSizeDelegate GetMaxTexture3DSizeDelegateField;

		// Token: 0x0400164B RID: 5707
		private static readonly SystemInfo.GetMaxTextureArraySlicesDelegate GetMaxTextureArraySlicesDelegateField;

		// Token: 0x0400164C RID: 5708
		private static readonly SystemInfo.GetMaxCubemapSizeDelegate GetMaxCubemapSizeDelegateField;

		// Token: 0x0400164D RID: 5709
		private static readonly SystemInfo.GetMaxAnisotropyLevelDelegate GetMaxAnisotropyLevelDelegateField;

		// Token: 0x0400164E RID: 5710
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeDelegate GetMaxComputeWorkGroupSizeDelegateField;

		// Token: 0x0400164F RID: 5711
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeXDelegate GetMaxComputeWorkGroupSizeXDelegateField;

		// Token: 0x04001650 RID: 5712
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeYDelegate GetMaxComputeWorkGroupSizeYDelegateField;

		// Token: 0x04001651 RID: 5713
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeZDelegate GetMaxComputeWorkGroupSizeZDelegateField;

		// Token: 0x04001652 RID: 5714
		private static readonly SystemInfo.GetComputeSubGroupSizeDelegate GetComputeSubGroupSizeDelegateField;

		// Token: 0x04001653 RID: 5715
		private static readonly SystemInfo.SupportsAsyncComputeDelegate SupportsAsyncComputeDelegateField;

		// Token: 0x04001654 RID: 5716
		private static readonly SystemInfo.SupportsGpuRecorderDelegate SupportsGpuRecorderDelegateField;

		// Token: 0x04001655 RID: 5717
		private static readonly SystemInfo.SupportsAsyncGPUReadbackDelegate SupportsAsyncGPUReadbackDelegateField;

		// Token: 0x04001656 RID: 5718
		private static readonly SystemInfo.SupportsRayTracingDelegate SupportsRayTracingDelegateField;

		// Token: 0x04001657 RID: 5719
		private static readonly SystemInfo.SupportsSetConstantBufferDelegate SupportsSetConstantBufferDelegateField;

		// Token: 0x04001658 RID: 5720
		private static readonly SystemInfo.MinConstantBufferOffsetAlignmentDelegate MinConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x04001659 RID: 5721
		private static readonly SystemInfo.MaxConstantBufferSizeDelegate MaxConstantBufferSizeDelegateField;

		// Token: 0x0400165A RID: 5722
		private static readonly SystemInfo.HasMipMaxLevelDelegate HasMipMaxLevelDelegateField;

		// Token: 0x0400165B RID: 5723
		private static readonly SystemInfo.SupportsMipStreamingDelegate SupportsMipStreamingDelegateField;

		// Token: 0x0400165C RID: 5724
		private static readonly SystemInfo.SupportsConservativeRasterDelegate SupportsConservativeRasterDelegateField;

		// Token: 0x02000921 RID: 2337
		// (Invoke) Token: 0x06003ABE RID: 15038
		private delegate BatteryStatus GetBatteryStatusDelegate();

		// Token: 0x02000922 RID: 2338
		// (Invoke) Token: 0x06003AC0 RID: 15040
		private delegate int GetProcessorFrequencyMHzDelegate();

		// Token: 0x02000923 RID: 2339
		// (Invoke) Token: 0x06003AC2 RID: 15042
		private delegate IntPtr GetDeviceNameDelegate();

		// Token: 0x02000924 RID: 2340
		// (Invoke) Token: 0x06003AC4 RID: 15044
		private delegate bool SupportsAccelerometerDelegate();

		// Token: 0x02000925 RID: 2341
		// (Invoke) Token: 0x06003AC6 RID: 15046
		private delegate bool IsGyroAvailableDelegate();

		// Token: 0x02000926 RID: 2342
		// (Invoke) Token: 0x06003AC8 RID: 15048
		private delegate bool SupportsLocationServiceDelegate();

		// Token: 0x02000927 RID: 2343
		// (Invoke) Token: 0x06003ACA RID: 15050
		private delegate bool SupportsVibrationDelegate();

		// Token: 0x02000928 RID: 2344
		// (Invoke) Token: 0x06003ACC RID: 15052
		private delegate bool SupportsAudioDelegate();

		// Token: 0x02000929 RID: 2345
		// (Invoke) Token: 0x06003ACE RID: 15054
		private delegate int GetGraphicsDeviceIDDelegate();

		// Token: 0x0200092A RID: 2346
		// (Invoke) Token: 0x06003AD0 RID: 15056
		private delegate int GetGraphicsDeviceVendorIDDelegate();

		// Token: 0x0200092B RID: 2347
		// (Invoke) Token: 0x06003AD2 RID: 15058
		private delegate IntPtr GetGraphicsDeviceVersionDelegate();

		// Token: 0x0200092C RID: 2348
		// (Invoke) Token: 0x06003AD4 RID: 15060
		private delegate bool GetGraphicsMultiThreadedDelegate();

		// Token: 0x0200092D RID: 2349
		// (Invoke) Token: 0x06003AD6 RID: 15062
		private delegate UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingModeDelegate();

		// Token: 0x0200092E RID: 2350
		// (Invoke) Token: 0x06003AD8 RID: 15064
		private delegate bool HasDynamicUniformArrayIndexingInFragmentShadersDelegate();

		// Token: 0x0200092F RID: 2351
		// (Invoke) Token: 0x06003ADA RID: 15066
		private delegate bool SupportsRawShadowDepthSamplingDelegate();

		// Token: 0x02000930 RID: 2352
		// (Invoke) Token: 0x06003ADC RID: 15068
		private delegate bool SupportsMotionVectorsDelegate();

		// Token: 0x02000931 RID: 2353
		// (Invoke) Token: 0x06003ADE RID: 15070
		private delegate bool Supports3DTexturesDelegate();

		// Token: 0x02000932 RID: 2354
		// (Invoke) Token: 0x06003AE0 RID: 15072
		private delegate bool SupportsCompressed3DTexturesDelegate();

		// Token: 0x02000933 RID: 2355
		// (Invoke) Token: 0x06003AE2 RID: 15074
		private delegate bool Supports2DArrayTexturesDelegate();

		// Token: 0x02000934 RID: 2356
		// (Invoke) Token: 0x06003AE4 RID: 15076
		private delegate bool Supports3DRenderTexturesDelegate();

		// Token: 0x02000935 RID: 2357
		// (Invoke) Token: 0x06003AE6 RID: 15078
		private delegate bool SupportsCubemapArrayTexturesDelegate();

		// Token: 0x02000936 RID: 2358
		// (Invoke) Token: 0x06003AE8 RID: 15080
		private delegate bool SupportsAnisotropicFilterDelegate();

		// Token: 0x02000937 RID: 2359
		// (Invoke) Token: 0x06003AEA RID: 15082
		private delegate bool SupportsGeometryShadersDelegate();

		// Token: 0x02000938 RID: 2360
		// (Invoke) Token: 0x06003AEC RID: 15084
		private delegate bool SupportsTessellationShadersDelegate();

		// Token: 0x02000939 RID: 2361
		// (Invoke) Token: 0x06003AEE RID: 15086
		private delegate bool SupportsHardwareQuadTopologyDelegate();

		// Token: 0x0200093A RID: 2362
		// (Invoke) Token: 0x06003AF0 RID: 15088
		private delegate bool Supports32bitsIndexBufferDelegate();

		// Token: 0x0200093B RID: 2363
		// (Invoke) Token: 0x06003AF2 RID: 15090
		private delegate bool SupportsSparseTexturesDelegate();

		// Token: 0x0200093C RID: 2364
		// (Invoke) Token: 0x06003AF4 RID: 15092
		private delegate bool SupportsSeparatedRenderTargetsBlendDelegate();

		// Token: 0x0200093D RID: 2365
		// (Invoke) Token: 0x06003AF6 RID: 15094
		private delegate int SupportedRandomWriteTargetCountDelegate();

		// Token: 0x0200093E RID: 2366
		// (Invoke) Token: 0x06003AF8 RID: 15096
		private delegate int MaxComputeBufferInputsVertexDelegate();

		// Token: 0x0200093F RID: 2367
		// (Invoke) Token: 0x06003AFA RID: 15098
		private delegate int MaxComputeBufferInputsFragmentDelegate();

		// Token: 0x02000940 RID: 2368
		// (Invoke) Token: 0x06003AFC RID: 15100
		private delegate int MaxComputeBufferInputsGeometryDelegate();

		// Token: 0x02000941 RID: 2369
		// (Invoke) Token: 0x06003AFE RID: 15102
		private delegate int MaxComputeBufferInputsDomainDelegate();

		// Token: 0x02000942 RID: 2370
		// (Invoke) Token: 0x06003B00 RID: 15104
		private delegate int MaxComputeBufferInputsHullDelegate();

		// Token: 0x02000943 RID: 2371
		// (Invoke) Token: 0x06003B02 RID: 15106
		private delegate int MaxComputeBufferInputsComputeDelegate();

		// Token: 0x02000944 RID: 2372
		// (Invoke) Token: 0x06003B04 RID: 15108
		private delegate bool SupportsMultisampled2DArrayTexturesDelegate();

		// Token: 0x02000945 RID: 2373
		// (Invoke) Token: 0x06003B06 RID: 15110
		private delegate int SupportsTextureWrapMirrorOnceDelegate();

		// Token: 0x02000946 RID: 2374
		// (Invoke) Token: 0x06003B08 RID: 15112
		private delegate bool SupportsBlendingOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x02000947 RID: 2375
		// (Invoke) Token: 0x06003B0A RID: 15114
		private delegate bool SupportsRandomWriteOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x02000948 RID: 2376
		// (Invoke) Token: 0x06003B0C RID: 15116
		private delegate bool SupportsVertexAttributeFormatNativeDelegate(UnityEngine.Rendering.VertexAttributeFormat format, int dimension);

		// Token: 0x02000949 RID: 2377
		// (Invoke) Token: 0x06003B0E RID: 15118
		private delegate NPOTSupport GetNPOTSupportDelegate();

		// Token: 0x0200094A RID: 2378
		// (Invoke) Token: 0x06003B10 RID: 15120
		private delegate int GetMaxTexture3DSizeDelegate();

		// Token: 0x0200094B RID: 2379
		// (Invoke) Token: 0x06003B12 RID: 15122
		private delegate int GetMaxTextureArraySlicesDelegate();

		// Token: 0x0200094C RID: 2380
		// (Invoke) Token: 0x06003B14 RID: 15124
		private delegate int GetMaxCubemapSizeDelegate();

		// Token: 0x0200094D RID: 2381
		// (Invoke) Token: 0x06003B16 RID: 15126
		private delegate int GetMaxAnisotropyLevelDelegate();

		// Token: 0x0200094E RID: 2382
		// (Invoke) Token: 0x06003B18 RID: 15128
		private delegate int GetMaxComputeWorkGroupSizeDelegate();

		// Token: 0x0200094F RID: 2383
		// (Invoke) Token: 0x06003B1A RID: 15130
		private delegate int GetMaxComputeWorkGroupSizeXDelegate();

		// Token: 0x02000950 RID: 2384
		// (Invoke) Token: 0x06003B1C RID: 15132
		private delegate int GetMaxComputeWorkGroupSizeYDelegate();

		// Token: 0x02000951 RID: 2385
		// (Invoke) Token: 0x06003B1E RID: 15134
		private delegate int GetMaxComputeWorkGroupSizeZDelegate();

		// Token: 0x02000952 RID: 2386
		// (Invoke) Token: 0x06003B20 RID: 15136
		private delegate int GetComputeSubGroupSizeDelegate();

		// Token: 0x02000953 RID: 2387
		// (Invoke) Token: 0x06003B22 RID: 15138
		private delegate bool SupportsAsyncComputeDelegate();

		// Token: 0x02000954 RID: 2388
		// (Invoke) Token: 0x06003B24 RID: 15140
		private delegate bool SupportsGpuRecorderDelegate();

		// Token: 0x02000955 RID: 2389
		// (Invoke) Token: 0x06003B26 RID: 15142
		private delegate bool SupportsAsyncGPUReadbackDelegate();

		// Token: 0x02000956 RID: 2390
		// (Invoke) Token: 0x06003B28 RID: 15144
		private delegate bool SupportsRayTracingDelegate();

		// Token: 0x02000957 RID: 2391
		// (Invoke) Token: 0x06003B2A RID: 15146
		private delegate bool SupportsSetConstantBufferDelegate();

		// Token: 0x02000958 RID: 2392
		// (Invoke) Token: 0x06003B2C RID: 15148
		private delegate int MinConstantBufferOffsetAlignmentDelegate();

		// Token: 0x02000959 RID: 2393
		// (Invoke) Token: 0x06003B2E RID: 15150
		private delegate int MaxConstantBufferSizeDelegate();

		// Token: 0x0200095A RID: 2394
		// (Invoke) Token: 0x06003B30 RID: 15152
		private delegate bool HasMipMaxLevelDelegate();

		// Token: 0x0200095B RID: 2395
		// (Invoke) Token: 0x06003B32 RID: 15154
		private delegate bool SupportsMipStreamingDelegate();

		// Token: 0x0200095C RID: 2396
		// (Invoke) Token: 0x06003B34 RID: 15156
		private delegate bool SupportsConservativeRasterDelegate();
	}
}
