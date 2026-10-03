using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	public sealed class Camera : Behaviour
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x000240C4 File Offset: 0x000222C4
		// Note: this type is marked as 'beforefieldinit'.
		static Camera()
		{
			Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Camera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
			Camera.NativeFieldInfoPtr_kMinAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinAperture");
			Camera.NativeFieldInfoPtr_kMaxAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxAperture");
			Camera.NativeFieldInfoPtr_kMinBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinBladeCount");
			Camera.NativeFieldInfoPtr_kMaxBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxBladeCount");
			Camera.NativeFieldInfoPtr_onPreCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreCull");
			Camera.NativeFieldInfoPtr_onPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreRender");
			Camera.NativeFieldInfoPtr_onPostRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPostRender");
			Camera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663714);
			Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663715);
			Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663716);
			Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663717);
			Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663718);
			Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663719);
			Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663720);
			Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663721);
			Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663722);
			Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663723);
			Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663724);
			Camera.NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663725);
			Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663726);
			Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663727);
			Camera.NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663728);
			Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663729);
			Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663730);
			Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663731);
			Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663732);
			Camera.NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663733);
			Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663734);
			Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663735);
			Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663736);
			Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663737);
			Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663738);
			Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663739);
			Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663740);
			Camera.NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663741);
			Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663742);
			Camera.NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663743);
			Camera.NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663744);
			Camera.NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663745);
			Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663746);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663747);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663748);
			Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663749);
			Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663750);
			Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663751);
			Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663752);
			Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663753);
			Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663754);
			Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663755);
			Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663756);
			Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663757);
			Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663758);
			Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663759);
			Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663760);
			Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663761);
			Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663762);
			Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663763);
			Camera.NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663764);
			Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663765);
			Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663766);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663767);
			Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663768);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663769);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663770);
			Camera.NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663771);
			Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663772);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663773);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663774);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663775);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663776);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663777);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663778);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663779);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663780);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663781);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663782);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663783);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663784);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663785);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663786);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663787);
			Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663788);
			Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663789);
			Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663790);
			Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663791);
			Camera.NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663792);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663793);
			Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663794);
			Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663795);
			Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663796);
			Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663797);
			Camera.NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663798);
			Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663799);
			Camera.NativeMethodInfoPtr_GetFilterMode_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663800);
			Camera.NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663801);
			Camera.NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663802);
			Camera.NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663803);
			Camera.NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663804);
			Camera.NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663805);
			Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663806);
			Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663807);
			Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663808);
			Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663809);
			Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663810);
			Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663811);
			Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663812);
			Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663813);
			Camera.NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663814);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663815);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663816);
			Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663817);
			Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663818);
			Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663819);
			Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663820);
			Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663821);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663822);
			Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663823);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663824);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663825);
			Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663826);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663827);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663828);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663829);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663830);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663831);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663832);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663833);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663834);
			Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663835);
			Camera.get_renderingPathDelegateField = IL2CPP.ResolveICall<Camera.get_renderingPathDelegate>("UnityEngine.Camera::get_renderingPath");
			Camera.ResetDelegateField = IL2CPP.ResolveICall<Camera.ResetDelegate>("UnityEngine.Camera::Reset");
			Camera.set_allowDynamicResolutionDelegateField = IL2CPP.ResolveICall<Camera.set_allowDynamicResolutionDelegate>("UnityEngine.Camera::set_allowDynamicResolution");
			Camera.get_forceIntoRenderTextureDelegateField = IL2CPP.ResolveICall<Camera.get_forceIntoRenderTextureDelegate>("UnityEngine.Camera::get_forceIntoRenderTexture");
			Camera.set_opaqueSortModeDelegateField = IL2CPP.ResolveICall<Camera.set_opaqueSortModeDelegate>("UnityEngine.Camera::set_opaqueSortMode");
			Camera.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortModeDelegate>("UnityEngine.Camera::get_transparencySortMode");
			Camera.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortModeDelegate>("UnityEngine.Camera::set_transparencySortMode");
			Camera.ResetTransparencySortSettingsDelegateField = IL2CPP.ResolveICall<Camera.ResetTransparencySortSettingsDelegate>("UnityEngine.Camera::ResetTransparencySortSettings");
			Camera.ResetAspectDelegateField = IL2CPP.ResolveICall<Camera.ResetAspectDelegate>("UnityEngine.Camera::ResetAspect");
			Camera.set_eventMaskDelegateField = IL2CPP.ResolveICall<Camera.set_eventMaskDelegate>("UnityEngine.Camera::set_eventMask");
			Camera.get_layerCullSphericalDelegateField = IL2CPP.ResolveICall<Camera.get_layerCullSphericalDelegate>("UnityEngine.Camera::get_layerCullSpherical");
			Camera.get_skyboxMaterialDelegateField = IL2CPP.ResolveICall<Camera.get_skyboxMaterialDelegate>("UnityEngine.Camera::get_skyboxMaterial");
			Camera.get_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::get_overrideSceneCullingMask");
			Camera.set_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.set_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::set_overrideSceneCullingMask");
			Camera.get_sceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_sceneCullingMaskDelegate>("UnityEngine.Camera::get_sceneCullingMask");
			Camera.GetLayerCullDistancesDelegateField = IL2CPP.ResolveICall<Camera.GetLayerCullDistancesDelegate>("UnityEngine.Camera::GetLayerCullDistances");
			Camera.get_useOcclusionCullingDelegateField = IL2CPP.ResolveICall<Camera.get_useOcclusionCullingDelegate>("UnityEngine.Camera::get_useOcclusionCulling");
			Camera.ResetCullingMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetCullingMatrixDelegate>("UnityEngine.Camera::ResetCullingMatrix");
			Camera.get_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.get_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::get_clearStencilAfterLightingPass");
			Camera.set_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.set_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::set_clearStencilAfterLightingPass");
			Camera.SetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.SetReplacementShaderDelegate>("UnityEngine.Camera::SetReplacementShader");
			Camera.ResetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.ResetReplacementShaderDelegate>("UnityEngine.Camera::ResetReplacementShader");
			Camera.get_projectionMatrixModeDelegateField = IL2CPP.ResolveICall<Camera.get_projectionMatrixModeDelegate>("UnityEngine.Camera::get_projectionMatrixMode");
			Camera.set_usePhysicalPropertiesDelegateField = IL2CPP.ResolveICall<Camera.set_usePhysicalPropertiesDelegate>("UnityEngine.Camera::set_usePhysicalProperties");
			Camera.get_isoDelegateField = IL2CPP.ResolveICall<Camera.get_isoDelegate>("UnityEngine.Camera::get_iso");
			Camera.set_isoDelegateField = IL2CPP.ResolveICall<Camera.set_isoDelegate>("UnityEngine.Camera::set_iso");
			Camera.get_shutterSpeedDelegateField = IL2CPP.ResolveICall<Camera.get_shutterSpeedDelegate>("UnityEngine.Camera::get_shutterSpeed");
			Camera.set_shutterSpeedDelegateField = IL2CPP.ResolveICall<Camera.set_shutterSpeedDelegate>("UnityEngine.Camera::set_shutterSpeed");
			Camera.get_apertureDelegateField = IL2CPP.ResolveICall<Camera.get_apertureDelegate>("UnityEngine.Camera::get_aperture");
			Camera.set_apertureDelegateField = IL2CPP.ResolveICall<Camera.set_apertureDelegate>("UnityEngine.Camera::set_aperture");
			Camera.get_focusDistanceDelegateField = IL2CPP.ResolveICall<Camera.get_focusDistanceDelegate>("UnityEngine.Camera::get_focusDistance");
			Camera.set_focusDistanceDelegateField = IL2CPP.ResolveICall<Camera.set_focusDistanceDelegate>("UnityEngine.Camera::set_focusDistance");
			Camera.get_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.get_focalLengthDelegate>("UnityEngine.Camera::get_focalLength");
			Camera.set_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.set_focalLengthDelegate>("UnityEngine.Camera::set_focalLength");
			Camera.get_bladeCountDelegateField = IL2CPP.ResolveICall<Camera.get_bladeCountDelegate>("UnityEngine.Camera::get_bladeCount");
			Camera.set_bladeCountDelegateField = IL2CPP.ResolveICall<Camera.set_bladeCountDelegate>("UnityEngine.Camera::set_bladeCount");
			Camera.get_barrelClippingDelegateField = IL2CPP.ResolveICall<Camera.get_barrelClippingDelegate>("UnityEngine.Camera::get_barrelClipping");
			Camera.set_barrelClippingDelegateField = IL2CPP.ResolveICall<Camera.set_barrelClippingDelegate>("UnityEngine.Camera::set_barrelClipping");
			Camera.get_anamorphismDelegateField = IL2CPP.ResolveICall<Camera.get_anamorphismDelegate>("UnityEngine.Camera::get_anamorphism");
			Camera.set_anamorphismDelegateField = IL2CPP.ResolveICall<Camera.set_anamorphismDelegate>("UnityEngine.Camera::set_anamorphism");
			Camera.get_gateFitDelegateField = IL2CPP.ResolveICall<Camera.get_gateFitDelegate>("UnityEngine.Camera::get_gateFit");
			Camera.set_gateFitDelegateField = IL2CPP.ResolveICall<Camera.set_gateFitDelegate>("UnityEngine.Camera::set_gateFit");
			Camera.GetGateFittedFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedFieldOfViewDelegate>("UnityEngine.Camera::GetGateFittedFieldOfView");
			Camera.set_targetDisplayDelegateField = IL2CPP.ResolveICall<Camera.set_targetDisplayDelegate>("UnityEngine.Camera::set_targetDisplay");
			Camera.GetCameraBufferWarningsDelegateField = IL2CPP.ResolveICall<Camera.GetCameraBufferWarningsDelegate>("UnityEngine.Camera::GetCameraBufferWarnings");
			Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField = IL2CPP.ResolveICall<Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate>("UnityEngine.Camera::get_useJitteredProjectionMatrixForTransparentRendering");
			Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegateField = IL2CPP.ResolveICall<Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegate>("UnityEngine.Camera::set_useJitteredProjectionMatrixForTransparentRendering");
			Camera.ResetProjectionMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetProjectionMatrixDelegate>("UnityEngine.Camera::ResetProjectionMatrix");
			Camera.FocalLengthToFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.FocalLengthToFieldOfViewDelegate>("UnityEngine.Camera::FocalLengthToFieldOfView");
			Camera.FieldOfViewToFocalLengthDelegateField = IL2CPP.ResolveICall<Camera.FieldOfViewToFocalLengthDelegate>("UnityEngine.Camera::FieldOfViewToFocalLength");
			Camera.HorizontalToVerticalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.HorizontalToVerticalFieldOfViewDelegate>("UnityEngine.Camera::HorizontalToVerticalFieldOfView");
			Camera.VerticalToHorizontalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.VerticalToHorizontalFieldOfViewDelegate>("UnityEngine.Camera::VerticalToHorizontalFieldOfView");
			Camera.get_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.get_stereoSeparationDelegate>("UnityEngine.Camera::get_stereoSeparation");
			Camera.set_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.set_stereoSeparationDelegate>("UnityEngine.Camera::set_stereoSeparation");
			Camera.get_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.get_stereoConvergenceDelegate>("UnityEngine.Camera::get_stereoConvergence");
			Camera.set_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.set_stereoConvergenceDelegate>("UnityEngine.Camera::set_stereoConvergence");
			Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField = IL2CPP.ResolveICall<Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate>("UnityEngine.Camera::get_areVRStereoViewMatricesWithinSingleCullTolerance");
			Camera.get_stereoActiveEyeDelegateField = IL2CPP.ResolveICall<Camera.get_stereoActiveEyeDelegate>("UnityEngine.Camera::get_stereoActiveEye");
			Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField = IL2CPP.ResolveICall<Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegate>("UnityEngine.Camera::CopyStereoDeviceProjectionMatrixToNonJittered");
			Camera.ResetStereoProjectionMatricesDelegateField = IL2CPP.ResolveICall<Camera.ResetStereoProjectionMatricesDelegate>("UnityEngine.Camera::ResetStereoProjectionMatrices");
			Camera.ResetStereoViewMatricesDelegateField = IL2CPP.ResolveICall<Camera.ResetStereoViewMatricesDelegate>("UnityEngine.Camera::ResetStereoViewMatrices");
			Camera.RenderToCubemapImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapImplDelegate>("UnityEngine.Camera::RenderToCubemapImpl");
			Camera.RenderToCubemapEyeImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapEyeImplDelegate>("UnityEngine.Camera::RenderToCubemapEyeImpl");
			Camera.RenderDontRestoreDelegateField = IL2CPP.ResolveICall<Camera.RenderDontRestoreDelegate>("UnityEngine.Camera::RenderDontRestore");
			Camera.SubmitRenderRequestsInternalDelegateField = IL2CPP.ResolveICall<Camera.SubmitRenderRequestsInternalDelegate>("UnityEngine.Camera::SubmitRenderRequestsInternal");
			Camera.SubmitBuiltInObjectIDRenderRequestDelegateField = IL2CPP.ResolveICall<Camera.SubmitBuiltInObjectIDRenderRequestDelegate>("UnityEngine.Camera::SubmitBuiltInObjectIDRenderRequest");
			Camera.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Camera.get_commandBufferCountDelegate>("UnityEngine.Camera::get_commandBufferCount");
			Camera.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveCommandBuffersDelegate>("UnityEngine.Camera::RemoveCommandBuffers");
			Camera.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveAllCommandBuffersDelegate>("UnityEngine.Camera::RemoveAllCommandBuffers");
			Camera.AddCommandBufferAsyncImplDelegateField = IL2CPP.ResolveICall<Camera.AddCommandBufferAsyncImplDelegate>("UnityEngine.Camera::AddCommandBufferAsyncImpl");
			Camera.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.GetCommandBuffersDelegate>("UnityEngine.Camera::GetCommandBuffers");
			Camera.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::get_transparencySortAxis_Injected");
			Camera.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::set_transparencySortAxis_Injected");
			Camera.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_velocity_InjectedDelegate>("UnityEngine.Camera::get_velocity_Injected");
			Camera.get_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::get_cullingMatrix_Injected");
			Camera.set_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::set_cullingMatrix_Injected");
			Camera.get_curvature_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_curvature_InjectedDelegate>("UnityEngine.Camera::get_curvature_Injected");
			Camera.set_curvature_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_curvature_InjectedDelegate>("UnityEngine.Camera::set_curvature_Injected");
			Camera.get_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_sensorSize_InjectedDelegate>("UnityEngine.Camera::get_sensorSize_Injected");
			Camera.set_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_sensorSize_InjectedDelegate>("UnityEngine.Camera::set_sensorSize_Injected");
			Camera.get_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_lensShift_InjectedDelegate>("UnityEngine.Camera::get_lensShift_Injected");
			Camera.set_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_lensShift_InjectedDelegate>("UnityEngine.Camera::set_lensShift_Injected");
			Camera.GetGateFittedLensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedLensShift_InjectedDelegate>("UnityEngine.Camera::GetGateFittedLensShift_Injected");
			Camera.GetLocalSpaceAim_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetLocalSpaceAim_InjectedDelegate>("UnityEngine.Camera::GetLocalSpaceAim_Injected");
			Camera.SetTargetBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetTargetBuffersImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersImpl_Injected");
			Camera.SetTargetBuffersMRTImpl_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetTargetBuffersMRTImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersMRTImpl_Injected");
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_nonJitteredProjectionMatrix_Injected");
			Camera.set_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::set_nonJitteredProjectionMatrix_Injected");
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_previousViewProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_previousViewProjectionMatrix_Injected");
			Camera.ViewportToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<Camera.ViewportToScreenPoint_InjectedDelegate>("UnityEngine.Camera::ViewportToScreenPoint_Injected");
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetFrustumPlaneSizeAt_InjectedDelegate>("UnityEngine.Camera::GetFrustumPlaneSizeAt_Injected");
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateFrustumCornersInternal_InjectedDelegate>("UnityEngine.Camera::CalculateFrustumCornersInternal_Injected");
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate>("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected");
			Camera.get_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_scene_InjectedDelegate>("UnityEngine.Camera::get_scene_Injected");
			Camera.set_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_scene_InjectedDelegate>("UnityEngine.Camera::set_scene_Injected");
			Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoNonJitteredProjectionMatrix_Injected");
			Camera.GetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoViewMatrix_Injected");
			Camera.GetStereoProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoProjectionMatrix_Injected");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000250C8 File Offset: 0x000232C8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00025104 File Offset: 0x00023304
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00025140 File Offset: 0x00023340
		public unsafe float nearClipPlane
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1228316, RefRangeEnd = 1228334, XrefRangeStart = 1228314, XrefRangeEnd = 1228316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1228336, RefRangeEnd = 1228342, XrefRangeStart = 1228334, XrefRangeEnd = 1228336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00025180 File Offset: 0x00023380
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000251BC File Offset: 0x000233BC
		public unsafe float farClipPlane
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 1228344, RefRangeEnd = 1228371, XrefRangeStart = 1228342, XrefRangeEnd = 1228344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228373, RefRangeEnd = 1228378, XrefRangeStart = 1228371, XrefRangeEnd = 1228373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000251FC File Offset: 0x000233FC
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00025238 File Offset: 0x00023438
		public unsafe float fieldOfView
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1228380, RefRangeEnd = 1228402, XrefRangeStart = 1228378, XrefRangeEnd = 1228380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1228404, RefRangeEnd = 1228419, XrefRangeStart = 1228402, XrefRangeEnd = 1228404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00003F8F File Offset: 0x0000218F
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00025278 File Offset: 0x00023478
		public unsafe RenderingPath renderingPath
		{
			get
			{
				return Camera.get_renderingPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228421, RefRangeEnd = 1228423, XrefRangeStart = 1228419, XrefRangeEnd = 1228421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000252B8 File Offset: 0x000234B8
		public unsafe RenderingPath actualRenderingPath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228425, RefRangeEnd = 1228427, XrefRangeStart = 1228423, XrefRangeEnd = 1228425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000252F4 File Offset: 0x000234F4
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00025330 File Offset: 0x00023530
		public unsafe bool allowHDR
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228429, RefRangeEnd = 1228432, XrefRangeStart = 1228427, XrefRangeEnd = 1228429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228434, RefRangeEnd = 1228435, XrefRangeStart = 1228432, XrefRangeEnd = 1228434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00025370 File Offset: 0x00023570
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000253AC File Offset: 0x000235AC
		public unsafe bool allowMSAA
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228437, RefRangeEnd = 1228440, XrefRangeStart = 1228435, XrefRangeEnd = 1228437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228442, RefRangeEnd = 1228443, XrefRangeStart = 1228440, XrefRangeEnd = 1228442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000253EC File Offset: 0x000235EC
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003FB3 File Offset: 0x000021B3
		public unsafe bool allowDynamicResolution
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1228445, RefRangeEnd = 1228451, XrefRangeStart = 1228443, XrefRangeEnd = 1228445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_allowDynamicResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00003FC6 File Offset: 0x000021C6
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00025428 File Offset: 0x00023628
		public unsafe bool forceIntoRenderTexture
		{
			get
			{
				return Camera.get_forceIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228453, RefRangeEnd = 1228454, XrefRangeStart = 1228451, XrefRangeEnd = 1228453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00025468 File Offset: 0x00023668
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000254A4 File Offset: 0x000236A4
		public unsafe float orthographicSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228456, RefRangeEnd = 1228461, XrefRangeStart = 1228454, XrefRangeEnd = 1228456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228463, RefRangeEnd = 1228468, XrefRangeStart = 1228461, XrefRangeEnd = 1228463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000254E4 File Offset: 0x000236E4
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00025520 File Offset: 0x00023720
		public unsafe bool orthographic
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1228470, RefRangeEnd = 1228494, XrefRangeStart = 1228468, XrefRangeEnd = 1228470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228496, RefRangeEnd = 1228501, XrefRangeStart = 1228494, XrefRangeEnd = 1228496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00025560 File Offset: 0x00023760
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003FD8 File Offset: 0x000021D8
		public unsafe UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228503, RefRangeEnd = 1228505, XrefRangeStart = 1228501, XrefRangeEnd = 1228503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_opaqueSortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0002559C File Offset: 0x0002379C
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000255D8 File Offset: 0x000237D8
		public unsafe float depth
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1228507, RefRangeEnd = 1228517, XrefRangeStart = 1228505, XrefRangeEnd = 1228507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228519, RefRangeEnd = 1228520, XrefRangeStart = 1228517, XrefRangeEnd = 1228519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00025618 File Offset: 0x00023818
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00025654 File Offset: 0x00023854
		public unsafe float aspect
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1228522, RefRangeEnd = 1228528, XrefRangeStart = 1228520, XrefRangeEnd = 1228522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228530, RefRangeEnd = 1228533, XrefRangeStart = 1228528, XrefRangeEnd = 1228530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00025694 File Offset: 0x00023894
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000256D0 File Offset: 0x000238D0
		public unsafe int cullingMask
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1228535, RefRangeEnd = 1228552, XrefRangeStart = 1228533, XrefRangeEnd = 1228535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1228554, RefRangeEnd = 1228563, XrefRangeStart = 1228552, XrefRangeEnd = 1228554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00025710 File Offset: 0x00023910
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0000403E File Offset: 0x0000223E
		public unsafe int eventMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228565, RefRangeEnd = 1228568, XrefRangeStart = 1228563, XrefRangeEnd = 1228565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_eventMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00004051 File Offset: 0x00002251
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0002574C File Offset: 0x0002394C
		public unsafe bool layerCullSpherical
		{
			get
			{
				return Camera.get_layerCullSphericalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228570, RefRangeEnd = 1228571, XrefRangeStart = 1228568, XrefRangeEnd = 1228570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0002578C File Offset: 0x0002398C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000257C8 File Offset: 0x000239C8
		public unsafe CameraType cameraType
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1228573, RefRangeEnd = 1228607, XrefRangeStart = 1228571, XrefRangeEnd = 1228573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228609, RefRangeEnd = 1228610, XrefRangeStart = 1228607, XrefRangeEnd = 1228609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00025808 File Offset: 0x00023A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228610, XrefRangeEnd = 1228612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerCullDistances(Il2CppStructArray<float> d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00027284 File Offset: 0x00025484
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0002584C File Offset: 0x00023A4C
		public unsafe Il2CppStructArray<float> layerCullDistances
		{
			get
			{
				return this.GetLayerCullDistances();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228621, RefRangeEnd = 1228622, XrefRangeStart = 1228612, XrefRangeEnd = 1228621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000409A File Offset: 0x0000229A
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00025890 File Offset: 0x00023A90
		public unsafe bool useOcclusionCulling
		{
			get
			{
				return Camera.get_useOcclusionCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228624, RefRangeEnd = 1228627, XrefRangeStart = 1228622, XrefRangeEnd = 1228624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0002590C File Offset: 0x00023B0C
		public unsafe Color backgroundColor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228629, RefRangeEnd = 1228632, XrefRangeStart = 1228627, XrefRangeEnd = 1228629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1228634, RefRangeEnd = 1228640, XrefRangeStart = 1228632, XrefRangeEnd = 1228634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0002594C File Offset: 0x00023B4C
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00025988 File Offset: 0x00023B88
		public unsafe CameraClearFlags clearFlags
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1228642, RefRangeEnd = 1228652, XrefRangeStart = 1228640, XrefRangeEnd = 1228642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1228654, RefRangeEnd = 1228664, XrefRangeStart = 1228652, XrefRangeEnd = 1228654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000259C8 File Offset: 0x00023BC8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00025A04 File Offset: 0x00023C04
		public unsafe DepthTextureMode depthTextureMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1228666, RefRangeEnd = 1228670, XrefRangeStart = 1228664, XrefRangeEnd = 1228666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1228672, RefRangeEnd = 1228679, XrefRangeStart = 1228670, XrefRangeEnd = 1228672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00025A44 File Offset: 0x00023C44
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0000412F File Offset: 0x0000232F
		public unsafe bool usePhysicalProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228679, XrefRangeEnd = 1228681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_usePhysicalPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00025A80 File Offset: 0x00023C80
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00025ABC File Offset: 0x00023CBC
		public unsafe Rect rect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228683, RefRangeEnd = 1228685, XrefRangeStart = 1228681, XrefRangeEnd = 1228683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228687, RefRangeEnd = 1228692, XrefRangeStart = 1228685, XrefRangeEnd = 1228687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00025AFC File Offset: 0x00023CFC
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00025B38 File Offset: 0x00023D38
		public unsafe Rect pixelRect
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1228694, RefRangeEnd = 1228698, XrefRangeStart = 1228692, XrefRangeEnd = 1228694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228698, XrefRangeEnd = 1228700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00025B78 File Offset: 0x00023D78
		public unsafe int pixelWidth
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1228702, RefRangeEnd = 1228721, XrefRangeStart = 1228700, XrefRangeEnd = 1228702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00025BB4 File Offset: 0x00023DB4
		public unsafe int pixelHeight
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1228723, RefRangeEnd = 1228741, XrefRangeStart = 1228721, XrefRangeEnd = 1228723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00025BF0 File Offset: 0x00023DF0
		public unsafe int scaledPixelWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228743, RefRangeEnd = 1228745, XrefRangeStart = 1228741, XrefRangeEnd = 1228743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00025C2C File Offset: 0x00023E2C
		public unsafe int scaledPixelHeight
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1228747, RefRangeEnd = 1228752, XrefRangeStart = 1228745, XrefRangeEnd = 1228747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00025C68 File Offset: 0x00023E68
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00025CA8 File Offset: 0x00023EA8
		public unsafe RenderTexture targetTexture
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 1228754, RefRangeEnd = 1228802, XrefRangeStart = 1228752, XrefRangeEnd = 1228754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1228804, RefRangeEnd = 1228819, XrefRangeStart = 1228802, XrefRangeEnd = 1228804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00025CEC File Offset: 0x00023EEC
		public unsafe RenderTexture activeTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228821, RefRangeEnd = 1228822, XrefRangeStart = 1228819, XrefRangeEnd = 1228821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00025D2C File Offset: 0x00023F2C
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x000042BF File Offset: 0x000024BF
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228824, RefRangeEnd = 1228827, XrefRangeStart = 1228822, XrefRangeEnd = 1228824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_targetDisplayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00025D68 File Offset: 0x00023F68
		public unsafe Matrix4x4 cameraToWorldMatrix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228829, RefRangeEnd = 1228831, XrefRangeStart = 1228827, XrefRangeEnd = 1228829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00025DA4 File Offset: 0x00023FA4
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00025DE0 File Offset: 0x00023FE0
		public unsafe Matrix4x4 worldToCameraMatrix
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1228833, RefRangeEnd = 1228844, XrefRangeStart = 1228831, XrefRangeEnd = 1228833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228846, RefRangeEnd = 1228848, XrefRangeStart = 1228844, XrefRangeEnd = 1228846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00025E20 File Offset: 0x00024020
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00025E5C File Offset: 0x0002405C
		public unsafe Matrix4x4 projectionMatrix
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1228850, RefRangeEnd = 1228859, XrefRangeStart = 1228848, XrefRangeEnd = 1228850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1228861, RefRangeEnd = 1228862, XrefRangeStart = 1228859, XrefRangeEnd = 1228861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00025E9C File Offset: 0x0002409C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228864, RefRangeEnd = 1228865, XrefRangeStart = 1228862, XrefRangeEnd = 1228864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetWorldToCameraMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00025ED0 File Offset: 0x000240D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228867, RefRangeEnd = 1228868, XrefRangeStart = 1228865, XrefRangeEnd = 1228867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00025F1C File Offset: 0x0002411C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228870, RefRangeEnd = 1228871, XrefRangeStart = 1228868, XrefRangeEnd = 1228870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00025F74 File Offset: 0x00024174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228871, XrefRangeEnd = 1228873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00025FCC File Offset: 0x000241CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228873, XrefRangeEnd = 1228875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00026024 File Offset: 0x00024224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228875, XrefRangeEnd = 1228877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002607C File Offset: 0x0002427C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1228879, RefRangeEnd = 1228900, XrefRangeStart = 1228877, XrefRangeEnd = 1228879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000260C8 File Offset: 0x000242C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1228902, RefRangeEnd = 1228906, XrefRangeStart = 1228900, XrefRangeEnd = 1228902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00026114 File Offset: 0x00024314
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1228908, RefRangeEnd = 1228916, XrefRangeStart = 1228906, XrefRangeEnd = 1228908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00026160 File Offset: 0x00024360
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1228918, RefRangeEnd = 1228924, XrefRangeStart = 1228916, XrefRangeEnd = 1228918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000261AC File Offset: 0x000243AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228926, RefRangeEnd = 1228927, XrefRangeStart = 1228924, XrefRangeEnd = 1228926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000261F8 File Offset: 0x000243F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228927, XrefRangeEnd = 1228929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00026250 File Offset: 0x00024450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228929, XrefRangeEnd = 1228931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000262A8 File Offset: 0x000244A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228933, RefRangeEnd = 1228934, XrefRangeStart = 1228931, XrefRangeEnd = 1228933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000262F4 File Offset: 0x000244F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228934, XrefRangeEnd = 1228936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002634C File Offset: 0x0002454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228936, XrefRangeEnd = 1228938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000263A4 File Offset: 0x000245A4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1228940, RefRangeEnd = 1228960, XrefRangeStart = 1228938, XrefRangeEnd = 1228940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000263F0 File Offset: 0x000245F0
		public unsafe static Camera main
		{
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 1228962, RefRangeEnd = 1229014, XrefRangeStart = 1228960, XrefRangeEnd = 1228962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00026424 File Offset: 0x00024624
		public unsafe static Camera current
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1229016, RefRangeEnd = 1229025, XrefRangeStart = 1229014, XrefRangeEnd = 1229016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00026458 File Offset: 0x00024658
		public unsafe bool stereoEnabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1229027, RefRangeEnd = 1229030, XrefRangeStart = 1229025, XrefRangeEnd = 1229027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00026494 File Offset: 0x00024694
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x000264D0 File Offset: 0x000246D0
		public unsafe StereoTargetEyeMask stereoTargetEye
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1229032, RefRangeEnd = 1229035, XrefRangeStart = 1229030, XrefRangeEnd = 1229032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1229037, RefRangeEnd = 1229038, XrefRangeStart = 1229035, XrefRangeEnd = 1229037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00026510 File Offset: 0x00024710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229040, RefRangeEnd = 1229041, XrefRangeStart = 1229038, XrefRangeEnd = 1229040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eye;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002655C File Offset: 0x0002475C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229043, RefRangeEnd = 1229044, XrefRangeStart = 1229041, XrefRangeEnd = 1229043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eye;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000265A8 File Offset: 0x000247A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229046, RefRangeEnd = 1229049, XrefRangeStart = 1229044, XrefRangeEnd = 1229046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000265D8 File Offset: 0x000247D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229049, XrefRangeEnd = 1229051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasImpl([Out] Il2CppReferenceArray<Camera> cam)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*cam = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Camera>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0002662C File Offset: 0x0002482C
		public unsafe static int allCamerasCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1229046, RefRangeEnd = 1229049, XrefRangeStart = 1229046, XrefRangeEnd = 1229049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0002665C File Offset: 0x0002485C
		public unsafe static Il2CppReferenceArray<Camera> allCameras
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1229058, RefRangeEnd = 1229060, XrefRangeStart = 1229051, XrefRangeEnd = 1229058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr3) : null;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00026690 File Offset: 0x00024890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229075, RefRangeEnd = 1229077, XrefRangeStart = 1229060, XrefRangeEnd = 1229075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCameras(Il2CppReferenceArray<Camera> cameras)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000266D4 File Offset: 0x000248D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229079, RefRangeEnd = 1229081, XrefRangeStart = 1229077, XrefRangeEnd = 1229079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFilterMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetFilterMode_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00026710 File Offset: 0x00024910
		public unsafe Camera.SceneViewFilterMode sceneViewFilterMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1229079, RefRangeEnd = 1229081, XrefRangeStart = 1229079, XrefRangeEnd = 1229081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002674C File Offset: 0x0002494C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1229083, RefRangeEnd = 1229093, XrefRangeStart = 1229081, XrefRangeEnd = 1229083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00026780 File Offset: 0x00024980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229095, RefRangeEnd = 1229096, XrefRangeStart = 1229093, XrefRangeEnd = 1229095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderWithShader(Shader shader, string replacementTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacementTag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000267D4 File Offset: 0x000249D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1229098, RefRangeEnd = 1229102, XrefRangeStart = 1229096, XrefRangeEnd = 1229098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupCurrent(Camera cur)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0002680C File Offset: 0x00024A0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229104, RefRangeEnd = 1229107, XrefRangeStart = 1229102, XrefRangeEnd = 1229104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Camera other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00026850 File Offset: 0x00024A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229107, XrefRangeEnd = 1229109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000268A0 File Offset: 0x00024AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229109, XrefRangeEnd = 1229111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000268F0 File Offset: 0x00024AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229130, RefRangeEnd = 1229132, XrefRangeStart = 1229111, XrefRangeEnd = 1229130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00026940 File Offset: 0x00024B40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1229151, RefRangeEnd = 1229157, XrefRangeStart = 1229132, XrefRangeEnd = 1229151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00026990 File Offset: 0x00024B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229157, XrefRangeEnd = 1229159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreCull(Camera cam)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000269C8 File Offset: 0x00024BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229159, XrefRangeEnd = 1229161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreRender(Camera cam)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00026A00 File Offset: 0x00024C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229161, XrefRangeEnd = 1229163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPostRender(Camera cam)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00026A38 File Offset: 0x00024C38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229165, RefRangeEnd = 1229168, XrefRangeStart = 1229163, XrefRangeEnd = 1229165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCullingParameters(bool stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stereoAware;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullingParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00026A90 File Offset: 0x00024C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229168, XrefRangeEnd = 1229170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoAware;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullingParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedCullingParametersSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00026AFC File Offset: 0x00024CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229170, XrefRangeEnd = 1229172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_backgroundColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00026B3C File Offset: 0x00024D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229172, XrefRangeEnd = 1229174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_backgroundColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00026B7C File Offset: 0x00024D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229174, XrefRangeEnd = 1229176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00026BBC File Offset: 0x00024DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229176, XrefRangeEnd = 1229178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00026BFC File Offset: 0x00024DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229178, XrefRangeEnd = 1229180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pixelRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00026C3C File Offset: 0x00024E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229180, XrefRangeEnd = 1229182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pixelRect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00026C7C File Offset: 0x00024E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229182, XrefRangeEnd = 1229184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00026CBC File Offset: 0x00024EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229184, XrefRangeEnd = 1229186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00026CFC File Offset: 0x00024EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229186, XrefRangeEnd = 1229188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00026D3C File Offset: 0x00024F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229188, XrefRangeEnd = 1229190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00026D7C File Offset: 0x00024F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229190, XrefRangeEnd = 1229192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_projectionMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00026DBC File Offset: 0x00024FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229192, XrefRangeEnd = 1229194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &clipPlane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00026E08 File Offset: 0x00025008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229194, XrefRangeEnd = 1229196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00026E64 File Offset: 0x00025064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229196, XrefRangeEnd = 1229198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00026EC0 File Offset: 0x000250C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229198, XrefRangeEnd = 1229200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00026F1C File Offset: 0x0002511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229200, XrefRangeEnd = 1229202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00026F78 File Offset: 0x00025178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229202, XrefRangeEnd = 1229204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00026FC4 File Offset: 0x000251C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229204, XrefRangeEnd = 1229206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00027020 File Offset: 0x00025220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229206, XrefRangeEnd = 1229208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0002707C File Offset: 0x0002527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229208, XrefRangeEnd = 1229210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eye;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000270C8 File Offset: 0x000252C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229210, XrefRangeEnd = 1229212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eye;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00003F18 File Offset: 0x00002118
		public Camera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00027114 File Offset: 0x00025314
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00003F21 File Offset: 0x00002121
		public unsafe static float kMinAperture
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMinAperture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMinAperture, (void*)(&value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00027130 File Offset: 0x00025330
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003F2F File Offset: 0x0000212F
		public unsafe static float kMaxAperture
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMaxAperture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMaxAperture, (void*)(&value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0002714C File Offset: 0x0002534C
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00003F3D File Offset: 0x0000213D
		public unsafe static int kMinBladeCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMinBladeCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMinBladeCount, (void*)(&value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00027168 File Offset: 0x00025368
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003F4B File Offset: 0x0000214B
		public unsafe static int kMaxBladeCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMaxBladeCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMaxBladeCount, (void*)(&value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00027184 File Offset: 0x00025384
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003F59 File Offset: 0x00002159
		public unsafe static Camera.CameraCallback onPreCull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreCull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreCull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000271AC File Offset: 0x000253AC
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003F6B File Offset: 0x0000216B
		public unsafe static Camera.CameraCallback onPreRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000271D4 File Offset: 0x000253D4
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00003F7D File Offset: 0x0000217D
		public unsafe static Camera.CameraCallback onPostRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPostRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPostRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003FA1 File Offset: 0x000021A1
		public void Reset()
		{
			Camera.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00003FEB File Offset: 0x000021EB
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003FFD File Offset: 0x000021FD
		public TransparencySortMode transparencySortMode
		{
			get
			{
				return Camera.get_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000271FC File Offset: 0x000253FC
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00004010 File Offset: 0x00002210
		public Vector3 transparencySortAxis
		{
			get
			{
				Vector3 result;
				this.get_transparencySortAxis_Injected(out result);
				return result;
			}
			set
			{
				this.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000401A File Offset: 0x0000221A
		public void ResetTransparencySortSettings()
		{
			Camera.ResetTransparencySortSettingsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000402C File Offset: 0x0000222C
		public void ResetAspect()
		{
			Camera.ResetAspectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00027214 File Offset: 0x00025414
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.get_velocity_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0002722C File Offset: 0x0002542C
		public Material skyboxMaterial
		{
			get
			{
				IntPtr intPtr = Camera.get_skyboxMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00004063 File Offset: 0x00002263
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004075 File Offset: 0x00002275
		public ulong overrideSceneCullingMask
		{
			get
			{
				return Camera.get_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00004088 File Offset: 0x00002288
		public ulong sceneCullingMask
		{
			get
			{
				return Camera.get_sceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00027258 File Offset: 0x00025458
		public Il2CppStructArray<float> GetLayerCullDistances()
		{
			IntPtr intPtr = Camera.GetLayerCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0002729C File Offset: 0x0002549C
		public static int PreviewCullingLayer
		{
			get
			{
				return 31;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000272B0 File Offset: 0x000254B0
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000040AC File Offset: 0x000022AC
		public Matrix4x4 cullingMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_cullingMatrix_Injected(out result);
				return result;
			}
			set
			{
				this.set_cullingMatrix_Injected(ref value);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000040B6 File Offset: 0x000022B6
		public void ResetCullingMatrix()
		{
			Camera.ResetCullingMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000040DA File Offset: 0x000022DA
		public bool clearStencilAfterLightingPass
		{
			get
			{
				return Camera.get_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000040ED File Offset: 0x000022ED
		public void SetReplacementShader(Shader shader, string replacementTag)
		{
			Camera.SetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(replacementTag));
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000410B File Offset: 0x0000230B
		public void ResetReplacementShader()
		{
			Camera.ResetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000411D File Offset: 0x0000231D
		public Camera.ProjectionMatrixMode projectionMatrixMode
		{
			get
			{
				return Camera.get_projectionMatrixModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00004142 File Offset: 0x00002342
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00004154 File Offset: 0x00002354
		public int iso
		{
			get
			{
				return Camera.get_isoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_isoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00004167 File Offset: 0x00002367
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00004179 File Offset: 0x00002379
		public float shutterSpeed
		{
			get
			{
				return Camera.get_shutterSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_shutterSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0000419E File Offset: 0x0000239E
		public float aperture
		{
			get
			{
				return Camera.get_apertureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_apertureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x000041B1 File Offset: 0x000023B1
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000041C3 File Offset: 0x000023C3
		public float focusDistance
		{
			get
			{
				return Camera.get_focusDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_focusDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000041D6 File Offset: 0x000023D6
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x000041E8 File Offset: 0x000023E8
		public float focalLength
		{
			get
			{
				return Camera.get_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000041FB File Offset: 0x000023FB
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000420D File Offset: 0x0000240D
		public int bladeCount
		{
			get
			{
				return Camera.get_bladeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_bladeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000272C8 File Offset: 0x000254C8
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00004220 File Offset: 0x00002420
		public Vector2 curvature
		{
			get
			{
				Vector2 result;
				this.get_curvature_Injected(out result);
				return result;
			}
			set
			{
				this.set_curvature_Injected(ref value);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0000422A File Offset: 0x0000242A
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x0000423C File Offset: 0x0000243C
		public float barrelClipping
		{
			get
			{
				return Camera.get_barrelClippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_barrelClippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000424F File Offset: 0x0000244F
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004261 File Offset: 0x00002461
		public float anamorphism
		{
			get
			{
				return Camera.get_anamorphismDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_anamorphismDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000272E0 File Offset: 0x000254E0
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00004274 File Offset: 0x00002474
		public Vector2 sensorSize
		{
			get
			{
				Vector2 result;
				this.get_sensorSize_Injected(out result);
				return result;
			}
			set
			{
				this.set_sensorSize_Injected(ref value);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000272F8 File Offset: 0x000254F8
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0000427E File Offset: 0x0000247E
		public Vector2 lensShift
		{
			get
			{
				Vector2 result;
				this.get_lensShift_Injected(out result);
				return result;
			}
			set
			{
				this.set_lensShift_Injected(ref value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00004288 File Offset: 0x00002488
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000429A File Offset: 0x0000249A
		public Camera.GateFitMode gateFit
		{
			get
			{
				return Camera.get_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000042AD File Offset: 0x000024AD
		public float GetGateFittedFieldOfView()
		{
			return Camera.GetGateFittedFieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00027310 File Offset: 0x00025510
		public Vector2 GetGateFittedLensShift()
		{
			Vector2 result;
			this.GetGateFittedLensShift_Injected(out result);
			return result;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00027328 File Offset: 0x00025528
		public Vector3 GetLocalSpaceAim()
		{
			Vector3 result;
			this.GetLocalSpaceAim_Injected(out result);
			return result;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000042D2 File Offset: 0x000024D2
		public void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth)
		{
			this.SetTargetBuffersImpl_Injected(ref color, ref depth);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000042DE File Offset: 0x000024DE
		public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersImpl(colorBuffer, depthBuffer);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000042EA File Offset: 0x000024EA
		public void SetTargetBuffersMRTImpl(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth)
		{
			this.SetTargetBuffersMRTImpl_Injected(color, ref depth);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000042F5 File Offset: 0x000024F5
		public void SetTargetBuffers(Il2CppStructArray<RenderBuffer> colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersMRTImpl(colorBuffer, depthBuffer);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00027340 File Offset: 0x00025540
		public Il2CppStringArray GetCameraBufferWarnings()
		{
			IntPtr intPtr = Camera.GetCameraBufferWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0002736C File Offset: 0x0002556C
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004301 File Offset: 0x00002501
		public Matrix4x4 nonJitteredProjectionMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_nonJitteredProjectionMatrix_Injected(out result);
				return result;
			}
			set
			{
				this.set_nonJitteredProjectionMatrix_Injected(ref value);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000430B File Offset: 0x0000250B
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000431D File Offset: 0x0000251D
		public bool useJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				return Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00027384 File Offset: 0x00025584
		public Matrix4x4 previousViewProjectionMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_previousViewProjectionMatrix_Injected(out result);
				return result;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004330 File Offset: 0x00002530
		public void ResetProjectionMatrix()
		{
			Camera.ResetProjectionMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002739C File Offset: 0x0002559C
		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			Vector3 result;
			this.ViewportToScreenPoint_Injected(ref position, out result);
			return result;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000273B4 File Offset: 0x000255B4
		public Vector2 GetFrustumPlaneSizeAt(float distance)
		{
			Vector2 result;
			this.GetFrustumPlaneSizeAt_Injected(distance, out result);
			return result;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00004342 File Offset: 0x00002542
		public void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			this.CalculateFrustumCornersInternal_Injected(ref viewport, z, eye, outCorners);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000273CC File Offset: 0x000255CC
		public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Il2CppStructArray<Vector3> outCorners)
		{
			bool flag = outCorners == null;
			if (flag)
			{
				throw new ArgumentNullException("outCorners");
			}
			bool flag2 = outCorners.Length < 4;
			if (flag2)
			{
				throw new ArgumentException("outCorners minimum size is 4", "outCorners");
			}
			this.CalculateFrustumCornersInternal(viewport, z, eye, outCorners);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00004350 File Offset: 0x00002550
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00004365 File Offset: 0x00002565
		public static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
		{
			return Camera.FocalLengthToFieldOfViewDelegateField(focalLength, sensorSize);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004373 File Offset: 0x00002573
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
		{
			return Camera.FieldOfViewToFocalLengthDelegateField(fieldOfView, sensorSize);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004381 File Offset: 0x00002581
		public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
		{
			return Camera.HorizontalToVerticalFieldOfViewDelegateField(horizontalFieldOfView, aspectRatio);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000438F File Offset: 0x0000258F
		public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
		{
			return Camera.VerticalToHorizontalFieldOfViewDelegateField(verticalFieldOfView, aspectRatio);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0002741C File Offset: 0x0002561C
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0000439D File Offset: 0x0000259D
		public UnityEngine.SceneManagement.Scene scene
		{
			get
			{
				UnityEngine.SceneManagement.Scene result;
				this.get_scene_Injected(out result);
				return result;
			}
			set
			{
				this.set_scene_Injected(ref value);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x000043A7 File Offset: 0x000025A7
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000043B9 File Offset: 0x000025B9
		public float stereoSeparation
		{
			get
			{
				return Camera.get_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000043CC File Offset: 0x000025CC
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000043DE File Offset: 0x000025DE
		public float stereoConvergence
		{
			get
			{
				return Camera.get_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000043F1 File Offset: 0x000025F1
		public bool areVRStereoViewMatricesWithinSingleCullTolerance
		{
			get
			{
				return Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00004403 File Offset: 0x00002603
		public Camera.MonoOrStereoscopicEye stereoActiveEye
		{
			get
			{
				return Camera.get_stereoActiveEyeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00027434 File Offset: 0x00025634
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 result;
			this.GetStereoNonJitteredProjectionMatrix_Injected(eye, out result);
			return result;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002744C File Offset: 0x0002564C
		public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 result;
			this.GetStereoViewMatrix_Injected(eye, out result);
			return result;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004415 File Offset: 0x00002615
		public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye)
		{
			Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00027464 File Offset: 0x00025664
		public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 result;
			this.GetStereoProjectionMatrix_Injected(eye, out result);
			return result;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004428 File Offset: 0x00002628
		public void ResetStereoProjectionMatrices()
		{
			Camera.ResetStereoProjectionMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000443A File Offset: 0x0000263A
		public void ResetStereoViewMatrices()
		{
			Camera.ResetStereoViewMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000444C File Offset: 0x0000264C
		public bool RenderToCubemapImpl(Texture tex, int faceMask)
		{
			return Camera.RenderToCubemapImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tex), faceMask);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002747C File Offset: 0x0002567C
		public bool RenderToCubemap(Cubemap cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00027498 File Offset: 0x00025698
		public bool RenderToCubemap(Cubemap cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000274B4 File Offset: 0x000256B4
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000274D0 File Offset: 0x000256D0
		public bool RenderToCubemap(RenderTexture cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004465 File Offset: 0x00002665
		public bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return Camera.RenderToCubemapEyeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(cubemap), faceMask, stereoEye);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000274EC File Offset: 0x000256EC
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return this.RenderToCubemapEyeImpl(cubemap, faceMask, stereoEye);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000447F File Offset: 0x0000267F
		public void RenderDontRestore()
		{
			Camera.RenderDontRestoreDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00027508 File Offset: 0x00025708
		public void SubmitRenderRequest<RequestData>(RequestData renderRequest)
		{
			bool flag = renderRequest == null;
			if (flag)
			{
				throw new ArgumentException("SubmitRenderRequests is invoked with invalid renderRequests");
			}
			UnityEngine.Rendering.ObjectIdRequest objectIdRequest = renderRequest.TryCast<UnityEngine.Rendering.ObjectIdRequest>();
			bool flag2 = objectIdRequest != null;
			if (flag2)
			{
				bool flag3 = objectIdRequest.destination.depthStencilFormat == UnityEngine.Experimental.Rendering.GraphicsFormat.None;
				if (flag3)
				{
					Debug.LogWarning("ObjectId Render Request submitted without a depth stencil, which can produce results that are not depth tested correctly");
				}
				bool flag4 = UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline == null || !UnityEngine.Rendering.RenderPipelineManager.currentPipeline.IsRenderRequestSupported<UnityEngine.Rendering.ObjectIdRequest>(this, objectIdRequest);
				if (flag4)
				{
					throw new ArgumentException((UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline == null) ? "The Built-In Render Pipeline does not support ObjectIdRequest outside of the editor." : "The current render pipeline does not support ObjectIdRequest, and the fallback implementation of the Built-In Render Pipeline is not available outside of the editor.");
				}
			}
			bool flag5 = UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline == null;
			if (flag5)
			{
				Debug.LogWarning("Trying to invoke 'SubmitRenderRequest' when no SRP is set. A scriptable render pipeline is needed for this function call");
			}
			else
			{
				this.SubmitRenderRequestsInternal(renderRequest);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004491 File Offset: 0x00002691
		public void SubmitRenderRequestsInternal(Object requests)
		{
			Camera.SubmitRenderRequestsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(requests));
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000275D4 File Offset: 0x000257D4
		public Il2CppReferenceArray<Object> SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			IntPtr intPtr = Camera.SubmitBuiltInObjectIDRenderRequestDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(target), mipLevel, cubemapFace, depthSlice);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000044A9 File Offset: 0x000026A9
		public int commandBufferCount
		{
			get
			{
				return Camera.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000044BB File Offset: 0x000026BB
		public void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			Camera.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000044CE File Offset: 0x000026CE
		public void RemoveAllCommandBuffers()
		{
			Camera.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000044E0 File Offset: 0x000026E0
		public void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Camera.AddCommandBufferAsyncImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002760C File Offset: 0x0002580C
		public void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			bool flag = !UnityEngine.Rendering.CameraEventUtils.IsValid(evt);
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid CameraEvent value \"{0}\".", (int)evt), "evt");
			}
			bool flag2 = buffer == null;
			if (flag2)
			{
				throw new NullReferenceException("buffer is null");
			}
			this.AddCommandBufferAsyncImpl(evt, buffer, queueType);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00027660 File Offset: 0x00025860
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			IntPtr intPtr = Camera.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000044FA File Offset: 0x000026FA
		public void OnlyUsedForTesting1()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000044FD File Offset: 0x000026FD
		public void OnlyUsedForTesting2()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00027690 File Offset: 0x00025890
		public bool TryGetCullingParameters(out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
		{
			return Camera.GetCullingParameters_Internal(this, false, out cullingParameters, sizeof(UnityEngine.Rendering.ScriptableCullingParameters));
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00004500 File Offset: 0x00002700
		public void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			Camera.get_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004513 File Offset: 0x00002713
		public void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			Camera.set_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004526 File Offset: 0x00002726
		public void get_velocity_Injected(out Vector3 ret)
		{
			Camera.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00004539 File Offset: 0x00002739
		public void get_cullingMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000454C File Offset: 0x0000274C
		public void set_cullingMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000455F File Offset: 0x0000275F
		public void get_curvature_Injected(out Vector2 ret)
		{
			Camera.get_curvature_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004572 File Offset: 0x00002772
		public void set_curvature_Injected(ref Vector2 value)
		{
			Camera.set_curvature_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00004585 File Offset: 0x00002785
		public void get_sensorSize_Injected(out Vector2 ret)
		{
			Camera.get_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004598 File Offset: 0x00002798
		public void set_sensorSize_Injected(ref Vector2 value)
		{
			Camera.set_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000045AB File Offset: 0x000027AB
		public void get_lensShift_Injected(out Vector2 ret)
		{
			Camera.get_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000045BE File Offset: 0x000027BE
		public void set_lensShift_Injected(ref Vector2 value)
		{
			Camera.set_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000045D1 File Offset: 0x000027D1
		public void GetGateFittedLensShift_Injected(out Vector2 ret)
		{
			Camera.GetGateFittedLensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000045E4 File Offset: 0x000027E4
		public void GetLocalSpaceAim_Injected(out Vector3 ret)
		{
			Camera.GetLocalSpaceAim_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000045F7 File Offset: 0x000027F7
		public void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth)
		{
			Camera.SetTargetBuffersImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref color, ref depth);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000460B File Offset: 0x0000280B
		public void SetTargetBuffersMRTImpl_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth)
		{
			Camera.SetTargetBuffersMRTImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(color), ref depth);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00004624 File Offset: 0x00002824
		public void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00004637 File Offset: 0x00002837
		public void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_nonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000464A File Offset: 0x0000284A
		public void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000465D File Offset: 0x0000285D
		public void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			Camera.ViewportToScreenPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00004671 File Offset: 0x00002871
		public void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret)
		{
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), distance, out ret);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00004685 File Offset: 0x00002885
		public void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref viewport, z, eye, IL2CPP.Il2CppObjectBaseToPtr(outCorners));
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000276B0 File Offset: 0x000258B0
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000046A1 File Offset: 0x000028A1
		public void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			Camera.get_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000046B4 File Offset: 0x000028B4
		public void set_scene_Injected(ref UnityEngine.SceneManagement.Scene value)
		{
			Camera.set_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000046C7 File Offset: 0x000028C7
		public void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000046DB File Offset: 0x000028DB
		public void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000046EF File Offset: 0x000028EF
		public void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr_kMinAperture;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_kMaxAperture;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_kMinBladeCount;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_kMaxBladeCount;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_onPreCull;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_onPreRender;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_onPostRender;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Single_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_aspect_Public_get_Single_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterMode_Private_Int32_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x0400041A RID: 1050
		private static readonly Camera.get_renderingPathDelegate get_renderingPathDelegateField;

		// Token: 0x0400041B RID: 1051
		private static readonly Camera.ResetDelegate ResetDelegateField;

		// Token: 0x0400041C RID: 1052
		private static readonly Camera.set_allowDynamicResolutionDelegate set_allowDynamicResolutionDelegateField;

		// Token: 0x0400041D RID: 1053
		private static readonly Camera.get_forceIntoRenderTextureDelegate get_forceIntoRenderTextureDelegateField;

		// Token: 0x0400041E RID: 1054
		private static readonly Camera.set_opaqueSortModeDelegate set_opaqueSortModeDelegateField;

		// Token: 0x0400041F RID: 1055
		private static readonly Camera.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x04000420 RID: 1056
		private static readonly Camera.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x04000421 RID: 1057
		private static readonly Camera.ResetTransparencySortSettingsDelegate ResetTransparencySortSettingsDelegateField;

		// Token: 0x04000422 RID: 1058
		private static readonly Camera.ResetAspectDelegate ResetAspectDelegateField;

		// Token: 0x04000423 RID: 1059
		private static readonly Camera.set_eventMaskDelegate set_eventMaskDelegateField;

		// Token: 0x04000424 RID: 1060
		private static readonly Camera.get_layerCullSphericalDelegate get_layerCullSphericalDelegateField;

		// Token: 0x04000425 RID: 1061
		private static readonly Camera.get_skyboxMaterialDelegate get_skyboxMaterialDelegateField;

		// Token: 0x04000426 RID: 1062
		private static readonly Camera.get_overrideSceneCullingMaskDelegate get_overrideSceneCullingMaskDelegateField;

		// Token: 0x04000427 RID: 1063
		private static readonly Camera.set_overrideSceneCullingMaskDelegate set_overrideSceneCullingMaskDelegateField;

		// Token: 0x04000428 RID: 1064
		private static readonly Camera.get_sceneCullingMaskDelegate get_sceneCullingMaskDelegateField;

		// Token: 0x04000429 RID: 1065
		private static readonly Camera.GetLayerCullDistancesDelegate GetLayerCullDistancesDelegateField;

		// Token: 0x0400042A RID: 1066
		private static readonly Camera.get_useOcclusionCullingDelegate get_useOcclusionCullingDelegateField;

		// Token: 0x0400042B RID: 1067
		private static readonly Camera.ResetCullingMatrixDelegate ResetCullingMatrixDelegateField;

		// Token: 0x0400042C RID: 1068
		private static readonly Camera.get_clearStencilAfterLightingPassDelegate get_clearStencilAfterLightingPassDelegateField;

		// Token: 0x0400042D RID: 1069
		private static readonly Camera.set_clearStencilAfterLightingPassDelegate set_clearStencilAfterLightingPassDelegateField;

		// Token: 0x0400042E RID: 1070
		private static readonly Camera.SetReplacementShaderDelegate SetReplacementShaderDelegateField;

		// Token: 0x0400042F RID: 1071
		private static readonly Camera.ResetReplacementShaderDelegate ResetReplacementShaderDelegateField;

		// Token: 0x04000430 RID: 1072
		private static readonly Camera.get_projectionMatrixModeDelegate get_projectionMatrixModeDelegateField;

		// Token: 0x04000431 RID: 1073
		private static readonly Camera.set_usePhysicalPropertiesDelegate set_usePhysicalPropertiesDelegateField;

		// Token: 0x04000432 RID: 1074
		private static readonly Camera.get_isoDelegate get_isoDelegateField;

		// Token: 0x04000433 RID: 1075
		private static readonly Camera.set_isoDelegate set_isoDelegateField;

		// Token: 0x04000434 RID: 1076
		private static readonly Camera.get_shutterSpeedDelegate get_shutterSpeedDelegateField;

		// Token: 0x04000435 RID: 1077
		private static readonly Camera.set_shutterSpeedDelegate set_shutterSpeedDelegateField;

		// Token: 0x04000436 RID: 1078
		private static readonly Camera.get_apertureDelegate get_apertureDelegateField;

		// Token: 0x04000437 RID: 1079
		private static readonly Camera.set_apertureDelegate set_apertureDelegateField;

		// Token: 0x04000438 RID: 1080
		private static readonly Camera.get_focusDistanceDelegate get_focusDistanceDelegateField;

		// Token: 0x04000439 RID: 1081
		private static readonly Camera.set_focusDistanceDelegate set_focusDistanceDelegateField;

		// Token: 0x0400043A RID: 1082
		private static readonly Camera.get_focalLengthDelegate get_focalLengthDelegateField;

		// Token: 0x0400043B RID: 1083
		private static readonly Camera.set_focalLengthDelegate set_focalLengthDelegateField;

		// Token: 0x0400043C RID: 1084
		private static readonly Camera.get_bladeCountDelegate get_bladeCountDelegateField;

		// Token: 0x0400043D RID: 1085
		private static readonly Camera.set_bladeCountDelegate set_bladeCountDelegateField;

		// Token: 0x0400043E RID: 1086
		private static readonly Camera.get_barrelClippingDelegate get_barrelClippingDelegateField;

		// Token: 0x0400043F RID: 1087
		private static readonly Camera.set_barrelClippingDelegate set_barrelClippingDelegateField;

		// Token: 0x04000440 RID: 1088
		private static readonly Camera.get_anamorphismDelegate get_anamorphismDelegateField;

		// Token: 0x04000441 RID: 1089
		private static readonly Camera.set_anamorphismDelegate set_anamorphismDelegateField;

		// Token: 0x04000442 RID: 1090
		private static readonly Camera.get_gateFitDelegate get_gateFitDelegateField;

		// Token: 0x04000443 RID: 1091
		private static readonly Camera.set_gateFitDelegate set_gateFitDelegateField;

		// Token: 0x04000444 RID: 1092
		private static readonly Camera.GetGateFittedFieldOfViewDelegate GetGateFittedFieldOfViewDelegateField;

		// Token: 0x04000445 RID: 1093
		private static readonly Camera.set_targetDisplayDelegate set_targetDisplayDelegateField;

		// Token: 0x04000446 RID: 1094
		private static readonly Camera.GetCameraBufferWarningsDelegate GetCameraBufferWarningsDelegateField;

		// Token: 0x04000447 RID: 1095
		private static readonly Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate get_useJitteredProjectionMatrixForTransparentRenderingDelegateField;

		// Token: 0x04000448 RID: 1096
		private static readonly Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegate set_useJitteredProjectionMatrixForTransparentRenderingDelegateField;

		// Token: 0x04000449 RID: 1097
		private static readonly Camera.ResetProjectionMatrixDelegate ResetProjectionMatrixDelegateField;

		// Token: 0x0400044A RID: 1098
		private static readonly Camera.FocalLengthToFieldOfViewDelegate FocalLengthToFieldOfViewDelegateField;

		// Token: 0x0400044B RID: 1099
		private static readonly Camera.FieldOfViewToFocalLengthDelegate FieldOfViewToFocalLengthDelegateField;

		// Token: 0x0400044C RID: 1100
		private static readonly Camera.HorizontalToVerticalFieldOfViewDelegate HorizontalToVerticalFieldOfViewDelegateField;

		// Token: 0x0400044D RID: 1101
		private static readonly Camera.VerticalToHorizontalFieldOfViewDelegate VerticalToHorizontalFieldOfViewDelegateField;

		// Token: 0x0400044E RID: 1102
		private static readonly Camera.get_stereoSeparationDelegate get_stereoSeparationDelegateField;

		// Token: 0x0400044F RID: 1103
		private static readonly Camera.set_stereoSeparationDelegate set_stereoSeparationDelegateField;

		// Token: 0x04000450 RID: 1104
		private static readonly Camera.get_stereoConvergenceDelegate get_stereoConvergenceDelegateField;

		// Token: 0x04000451 RID: 1105
		private static readonly Camera.set_stereoConvergenceDelegate set_stereoConvergenceDelegateField;

		// Token: 0x04000452 RID: 1106
		private static readonly Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField;

		// Token: 0x04000453 RID: 1107
		private static readonly Camera.get_stereoActiveEyeDelegate get_stereoActiveEyeDelegateField;

		// Token: 0x04000454 RID: 1108
		private static readonly Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegate CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField;

		// Token: 0x04000455 RID: 1109
		private static readonly Camera.ResetStereoProjectionMatricesDelegate ResetStereoProjectionMatricesDelegateField;

		// Token: 0x04000456 RID: 1110
		private static readonly Camera.ResetStereoViewMatricesDelegate ResetStereoViewMatricesDelegateField;

		// Token: 0x04000457 RID: 1111
		private static readonly Camera.RenderToCubemapImplDelegate RenderToCubemapImplDelegateField;

		// Token: 0x04000458 RID: 1112
		private static readonly Camera.RenderToCubemapEyeImplDelegate RenderToCubemapEyeImplDelegateField;

		// Token: 0x04000459 RID: 1113
		private static readonly Camera.RenderDontRestoreDelegate RenderDontRestoreDelegateField;

		// Token: 0x0400045A RID: 1114
		private static readonly Camera.SubmitRenderRequestsInternalDelegate SubmitRenderRequestsInternalDelegateField;

		// Token: 0x0400045B RID: 1115
		private static readonly Camera.SubmitBuiltInObjectIDRenderRequestDelegate SubmitBuiltInObjectIDRenderRequestDelegateField;

		// Token: 0x0400045C RID: 1116
		private static readonly Camera.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x0400045D RID: 1117
		private static readonly Camera.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x0400045E RID: 1118
		private static readonly Camera.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x0400045F RID: 1119
		private static readonly Camera.AddCommandBufferAsyncImplDelegate AddCommandBufferAsyncImplDelegateField;

		// Token: 0x04000460 RID: 1120
		private static readonly Camera.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x04000461 RID: 1121
		private static readonly Camera.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04000462 RID: 1122
		private static readonly Camera.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04000463 RID: 1123
		private static readonly Camera.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x04000464 RID: 1124
		private static readonly Camera.get_cullingMatrix_InjectedDelegate get_cullingMatrix_InjectedDelegateField;

		// Token: 0x04000465 RID: 1125
		private static readonly Camera.set_cullingMatrix_InjectedDelegate set_cullingMatrix_InjectedDelegateField;

		// Token: 0x04000466 RID: 1126
		private static readonly Camera.get_curvature_InjectedDelegate get_curvature_InjectedDelegateField;

		// Token: 0x04000467 RID: 1127
		private static readonly Camera.set_curvature_InjectedDelegate set_curvature_InjectedDelegateField;

		// Token: 0x04000468 RID: 1128
		private static readonly Camera.get_sensorSize_InjectedDelegate get_sensorSize_InjectedDelegateField;

		// Token: 0x04000469 RID: 1129
		private static readonly Camera.set_sensorSize_InjectedDelegate set_sensorSize_InjectedDelegateField;

		// Token: 0x0400046A RID: 1130
		private static readonly Camera.get_lensShift_InjectedDelegate get_lensShift_InjectedDelegateField;

		// Token: 0x0400046B RID: 1131
		private static readonly Camera.set_lensShift_InjectedDelegate set_lensShift_InjectedDelegateField;

		// Token: 0x0400046C RID: 1132
		private static readonly Camera.GetGateFittedLensShift_InjectedDelegate GetGateFittedLensShift_InjectedDelegateField;

		// Token: 0x0400046D RID: 1133
		private static readonly Camera.GetLocalSpaceAim_InjectedDelegate GetLocalSpaceAim_InjectedDelegateField;

		// Token: 0x0400046E RID: 1134
		private static readonly Camera.SetTargetBuffersImpl_InjectedDelegate SetTargetBuffersImpl_InjectedDelegateField;

		// Token: 0x0400046F RID: 1135
		private static readonly Camera.SetTargetBuffersMRTImpl_InjectedDelegate SetTargetBuffersMRTImpl_InjectedDelegateField;

		// Token: 0x04000470 RID: 1136
		private static readonly Camera.get_nonJitteredProjectionMatrix_InjectedDelegate get_nonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000471 RID: 1137
		private static readonly Camera.set_nonJitteredProjectionMatrix_InjectedDelegate set_nonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000472 RID: 1138
		private static readonly Camera.get_previousViewProjectionMatrix_InjectedDelegate get_previousViewProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000473 RID: 1139
		private static readonly Camera.ViewportToScreenPoint_InjectedDelegate ViewportToScreenPoint_InjectedDelegateField;

		// Token: 0x04000474 RID: 1140
		private static readonly Camera.GetFrustumPlaneSizeAt_InjectedDelegate GetFrustumPlaneSizeAt_InjectedDelegateField;

		// Token: 0x04000475 RID: 1141
		private static readonly Camera.CalculateFrustumCornersInternal_InjectedDelegate CalculateFrustumCornersInternal_InjectedDelegateField;

		// Token: 0x04000476 RID: 1142
		private static readonly Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField;

		// Token: 0x04000477 RID: 1143
		private static readonly Camera.get_scene_InjectedDelegate get_scene_InjectedDelegateField;

		// Token: 0x04000478 RID: 1144
		private static readonly Camera.set_scene_InjectedDelegate set_scene_InjectedDelegateField;

		// Token: 0x04000479 RID: 1145
		private static readonly Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegate GetStereoNonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x0400047A RID: 1146
		private static readonly Camera.GetStereoViewMatrix_InjectedDelegate GetStereoViewMatrix_InjectedDelegateField;

		// Token: 0x0400047B RID: 1147
		private static readonly Camera.GetStereoProjectionMatrix_InjectedDelegate GetStereoProjectionMatrix_InjectedDelegateField;

		// Token: 0x02000424 RID: 1060
		[OriginalName("UnityEngine.CoreModule.dll", "", "StereoscopicEye")]
		public enum StereoscopicEye
		{
			// Token: 0x04002A2A RID: 10794
			Left,
			// Token: 0x04002A2B RID: 10795
			Right
		}

		// Token: 0x02000425 RID: 1061
		[OriginalName("UnityEngine.CoreModule.dll", "", "MonoOrStereoscopicEye")]
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04002A2D RID: 10797
			Left,
			// Token: 0x04002A2E RID: 10798
			Right,
			// Token: 0x04002A2F RID: 10799
			Mono
		}

		// Token: 0x02000426 RID: 1062
		[OriginalName("UnityEngine.CoreModule.dll", "", "SceneViewFilterMode")]
		public enum SceneViewFilterMode
		{
			// Token: 0x04002A31 RID: 10801
			Off,
			// Token: 0x04002A32 RID: 10802
			ShowFiltered
		}

		// Token: 0x02000427 RID: 1063
		public sealed class CameraCallback : MulticastDelegate
		{
			// Token: 0x060030F3 RID: 12531 RVA: 0x00015A63 File Offset: 0x00013C63
			// Note: this type is marked as 'beforefieldinit'.
			static CameraCallback()
			{
				Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "CameraCallback");
				Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663836);
				Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663837);
			}

			// Token: 0x060030F4 RID: 12532 RVA: 0x000AFFEC File Offset: 0x000AE1EC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73307, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030F5 RID: 12533 RVA: 0x000B0048 File Offset: 0x000AE248
			[CallerCount(0)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030F6 RID: 12534 RVA: 0x00015AA1 File Offset: 0x00013CA1
			public CameraCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060030F7 RID: 12535 RVA: 0x00015AAA File Offset: 0x00013CAA
			public static implicit operator Camera.CameraCallback(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<Camera.CameraCallback>(A_0);
			}

			// Token: 0x060030F8 RID: 12536 RVA: 0x00015AB2 File Offset: 0x00013CB2
			public static Camera.CameraCallback operator +(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Camera.CameraCallback>();
			}

			// Token: 0x060030F9 RID: 12537 RVA: 0x00015AC0 File Offset: 0x00013CC0
			public static Camera.CameraCallback operator -(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Camera.CameraCallback>();
				}
				return result;
			}

			// Token: 0x04002A33 RID: 10803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A34 RID: 10804
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;
		}

		// Token: 0x02000428 RID: 1064
		public enum ProjectionMatrixMode
		{
			// Token: 0x04002A36 RID: 10806
			Explicit,
			// Token: 0x04002A37 RID: 10807
			Implicit,
			// Token: 0x04002A38 RID: 10808
			PhysicalPropertiesBased
		}

		// Token: 0x02000429 RID: 1065
		public enum GateFitMode
		{
			// Token: 0x04002A3A RID: 10810
			Vertical = 1,
			// Token: 0x04002A3B RID: 10811
			Horizontal,
			// Token: 0x04002A3C RID: 10812
			Fill,
			// Token: 0x04002A3D RID: 10813
			Overscan,
			// Token: 0x04002A3E RID: 10814
			None = 0
		}

		// Token: 0x0200042A RID: 1066
		public enum FieldOfViewAxis
		{
			// Token: 0x04002A40 RID: 10816
			Vertical,
			// Token: 0x04002A41 RID: 10817
			Horizontal
		}

		// Token: 0x0200042B RID: 1067
		public enum RenderRequestMode
		{
			// Token: 0x04002A43 RID: 10819
			None,
			// Token: 0x04002A44 RID: 10820
			ObjectId,
			// Token: 0x04002A45 RID: 10821
			Depth,
			// Token: 0x04002A46 RID: 10822
			VertexNormal,
			// Token: 0x04002A47 RID: 10823
			WorldPosition,
			// Token: 0x04002A48 RID: 10824
			EntityId,
			// Token: 0x04002A49 RID: 10825
			BaseColor,
			// Token: 0x04002A4A RID: 10826
			SpecularColor,
			// Token: 0x04002A4B RID: 10827
			Metallic,
			// Token: 0x04002A4C RID: 10828
			Emission,
			// Token: 0x04002A4D RID: 10829
			Normal,
			// Token: 0x04002A4E RID: 10830
			Smoothness,
			// Token: 0x04002A4F RID: 10831
			Occlusion,
			// Token: 0x04002A50 RID: 10832
			DiffuseColor
		}

		// Token: 0x0200042C RID: 1068
		public enum RenderRequestOutputSpace
		{
			// Token: 0x04002A52 RID: 10834
			ScreenSpace = -1,
			// Token: 0x04002A53 RID: 10835
			UV0,
			// Token: 0x04002A54 RID: 10836
			UV1,
			// Token: 0x04002A55 RID: 10837
			UV2,
			// Token: 0x04002A56 RID: 10838
			UV3,
			// Token: 0x04002A57 RID: 10839
			UV4,
			// Token: 0x04002A58 RID: 10840
			UV5,
			// Token: 0x04002A59 RID: 10841
			UV6,
			// Token: 0x04002A5A RID: 10842
			UV7,
			// Token: 0x04002A5B RID: 10843
			UV8
		}

		// Token: 0x0200042D RID: 1069
		// (Invoke) Token: 0x060030FB RID: 12539
		private delegate RenderingPath get_renderingPathDelegate(IntPtr @this);

		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x060030FD RID: 12541
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x0200042F RID: 1071
		// (Invoke) Token: 0x060030FF RID: 12543
		private delegate void set_allowDynamicResolutionDelegate(IntPtr @this, bool value);

		// Token: 0x02000430 RID: 1072
		// (Invoke) Token: 0x06003101 RID: 12545
		private delegate bool get_forceIntoRenderTextureDelegate(IntPtr @this);

		// Token: 0x02000431 RID: 1073
		// (Invoke) Token: 0x06003103 RID: 12547
		private delegate void set_opaqueSortModeDelegate(IntPtr @this, UnityEngine.Rendering.OpaqueSortMode value);

		// Token: 0x02000432 RID: 1074
		// (Invoke) Token: 0x06003105 RID: 12549
		private delegate TransparencySortMode get_transparencySortModeDelegate(IntPtr @this);

		// Token: 0x02000433 RID: 1075
		// (Invoke) Token: 0x06003107 RID: 12551
		private delegate void set_transparencySortModeDelegate(IntPtr @this, TransparencySortMode value);

		// Token: 0x02000434 RID: 1076
		// (Invoke) Token: 0x06003109 RID: 12553
		private delegate void ResetTransparencySortSettingsDelegate(IntPtr @this);

		// Token: 0x02000435 RID: 1077
		// (Invoke) Token: 0x0600310B RID: 12555
		private delegate void ResetAspectDelegate(IntPtr @this);

		// Token: 0x02000436 RID: 1078
		// (Invoke) Token: 0x0600310D RID: 12557
		private delegate void set_eventMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000437 RID: 1079
		// (Invoke) Token: 0x0600310F RID: 12559
		private delegate bool get_layerCullSphericalDelegate(IntPtr @this);

		// Token: 0x02000438 RID: 1080
		// (Invoke) Token: 0x06003111 RID: 12561
		private delegate IntPtr get_skyboxMaterialDelegate(IntPtr @this);

		// Token: 0x02000439 RID: 1081
		// (Invoke) Token: 0x06003113 RID: 12563
		private delegate ulong get_overrideSceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x0200043A RID: 1082
		// (Invoke) Token: 0x06003115 RID: 12565
		private delegate void set_overrideSceneCullingMaskDelegate(IntPtr @this, ulong value);

		// Token: 0x0200043B RID: 1083
		// (Invoke) Token: 0x06003117 RID: 12567
		private delegate ulong get_sceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x0200043C RID: 1084
		// (Invoke) Token: 0x06003119 RID: 12569
		private delegate IntPtr GetLayerCullDistancesDelegate(IntPtr @this);

		// Token: 0x0200043D RID: 1085
		// (Invoke) Token: 0x0600311B RID: 12571
		private delegate bool get_useOcclusionCullingDelegate(IntPtr @this);

		// Token: 0x0200043E RID: 1086
		// (Invoke) Token: 0x0600311D RID: 12573
		private delegate void ResetCullingMatrixDelegate(IntPtr @this);

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x0600311F RID: 12575
		private delegate bool get_clearStencilAfterLightingPassDelegate(IntPtr @this);

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x06003121 RID: 12577
		private delegate void set_clearStencilAfterLightingPassDelegate(IntPtr @this, bool value);

		// Token: 0x02000441 RID: 1089
		// (Invoke) Token: 0x06003123 RID: 12579
		private delegate void SetReplacementShaderDelegate(IntPtr @this, IntPtr shader, IntPtr replacementTag);

		// Token: 0x02000442 RID: 1090
		// (Invoke) Token: 0x06003125 RID: 12581
		private delegate void ResetReplacementShaderDelegate(IntPtr @this);

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x06003127 RID: 12583
		private delegate Camera.ProjectionMatrixMode get_projectionMatrixModeDelegate(IntPtr @this);

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x06003129 RID: 12585
		private delegate void set_usePhysicalPropertiesDelegate(IntPtr @this, bool value);

		// Token: 0x02000445 RID: 1093
		// (Invoke) Token: 0x0600312B RID: 12587
		private delegate int get_isoDelegate(IntPtr @this);

		// Token: 0x02000446 RID: 1094
		// (Invoke) Token: 0x0600312D RID: 12589
		private delegate void set_isoDelegate(IntPtr @this, int value);

		// Token: 0x02000447 RID: 1095
		// (Invoke) Token: 0x0600312F RID: 12591
		private delegate float get_shutterSpeedDelegate(IntPtr @this);

		// Token: 0x02000448 RID: 1096
		// (Invoke) Token: 0x06003131 RID: 12593
		private delegate void set_shutterSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000449 RID: 1097
		// (Invoke) Token: 0x06003133 RID: 12595
		private delegate float get_apertureDelegate(IntPtr @this);

		// Token: 0x0200044A RID: 1098
		// (Invoke) Token: 0x06003135 RID: 12597
		private delegate void set_apertureDelegate(IntPtr @this, float value);

		// Token: 0x0200044B RID: 1099
		// (Invoke) Token: 0x06003137 RID: 12599
		private delegate float get_focusDistanceDelegate(IntPtr @this);

		// Token: 0x0200044C RID: 1100
		// (Invoke) Token: 0x06003139 RID: 12601
		private delegate void set_focusDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200044D RID: 1101
		// (Invoke) Token: 0x0600313B RID: 12603
		private delegate float get_focalLengthDelegate(IntPtr @this);

		// Token: 0x0200044E RID: 1102
		// (Invoke) Token: 0x0600313D RID: 12605
		private delegate void set_focalLengthDelegate(IntPtr @this, float value);

		// Token: 0x0200044F RID: 1103
		// (Invoke) Token: 0x0600313F RID: 12607
		private delegate int get_bladeCountDelegate(IntPtr @this);

		// Token: 0x02000450 RID: 1104
		// (Invoke) Token: 0x06003141 RID: 12609
		private delegate void set_bladeCountDelegate(IntPtr @this, int value);

		// Token: 0x02000451 RID: 1105
		// (Invoke) Token: 0x06003143 RID: 12611
		private delegate float get_barrelClippingDelegate(IntPtr @this);

		// Token: 0x02000452 RID: 1106
		// (Invoke) Token: 0x06003145 RID: 12613
		private delegate void set_barrelClippingDelegate(IntPtr @this, float value);

		// Token: 0x02000453 RID: 1107
		// (Invoke) Token: 0x06003147 RID: 12615
		private delegate float get_anamorphismDelegate(IntPtr @this);

		// Token: 0x02000454 RID: 1108
		// (Invoke) Token: 0x06003149 RID: 12617
		private delegate void set_anamorphismDelegate(IntPtr @this, float value);

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x0600314B RID: 12619
		private delegate Camera.GateFitMode get_gateFitDelegate(IntPtr @this);

		// Token: 0x02000456 RID: 1110
		// (Invoke) Token: 0x0600314D RID: 12621
		private delegate void set_gateFitDelegate(IntPtr @this, Camera.GateFitMode value);

		// Token: 0x02000457 RID: 1111
		// (Invoke) Token: 0x0600314F RID: 12623
		private delegate float GetGateFittedFieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000458 RID: 1112
		// (Invoke) Token: 0x06003151 RID: 12625
		private delegate void set_targetDisplayDelegate(IntPtr @this, int value);

		// Token: 0x02000459 RID: 1113
		// (Invoke) Token: 0x06003153 RID: 12627
		private delegate IntPtr GetCameraBufferWarningsDelegate(IntPtr @this);

		// Token: 0x0200045A RID: 1114
		// (Invoke) Token: 0x06003155 RID: 12629
		private delegate bool get_useJitteredProjectionMatrixForTransparentRenderingDelegate(IntPtr @this);

		// Token: 0x0200045B RID: 1115
		// (Invoke) Token: 0x06003157 RID: 12631
		private delegate void set_useJitteredProjectionMatrixForTransparentRenderingDelegate(IntPtr @this, bool value);

		// Token: 0x0200045C RID: 1116
		// (Invoke) Token: 0x06003159 RID: 12633
		private delegate void ResetProjectionMatrixDelegate(IntPtr @this);

		// Token: 0x0200045D RID: 1117
		// (Invoke) Token: 0x0600315B RID: 12635
		private delegate float FocalLengthToFieldOfViewDelegate(float focalLength, float sensorSize);

		// Token: 0x0200045E RID: 1118
		// (Invoke) Token: 0x0600315D RID: 12637
		private delegate float FieldOfViewToFocalLengthDelegate(float fieldOfView, float sensorSize);

		// Token: 0x0200045F RID: 1119
		// (Invoke) Token: 0x0600315F RID: 12639
		private delegate float HorizontalToVerticalFieldOfViewDelegate(float horizontalFieldOfView, float aspectRatio);

		// Token: 0x02000460 RID: 1120
		// (Invoke) Token: 0x06003161 RID: 12641
		private delegate float VerticalToHorizontalFieldOfViewDelegate(float verticalFieldOfView, float aspectRatio);

		// Token: 0x02000461 RID: 1121
		// (Invoke) Token: 0x06003163 RID: 12643
		private delegate float get_stereoSeparationDelegate(IntPtr @this);

		// Token: 0x02000462 RID: 1122
		// (Invoke) Token: 0x06003165 RID: 12645
		private delegate void set_stereoSeparationDelegate(IntPtr @this, float value);

		// Token: 0x02000463 RID: 1123
		// (Invoke) Token: 0x06003167 RID: 12647
		private delegate float get_stereoConvergenceDelegate(IntPtr @this);

		// Token: 0x02000464 RID: 1124
		// (Invoke) Token: 0x06003169 RID: 12649
		private delegate void set_stereoConvergenceDelegate(IntPtr @this, float value);

		// Token: 0x02000465 RID: 1125
		// (Invoke) Token: 0x0600316B RID: 12651
		private delegate bool get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate(IntPtr @this);

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x0600316D RID: 12653
		private delegate Camera.MonoOrStereoscopicEye get_stereoActiveEyeDelegate(IntPtr @this);

		// Token: 0x02000467 RID: 1127
		// (Invoke) Token: 0x0600316F RID: 12655
		private delegate void CopyStereoDeviceProjectionMatrixToNonJitteredDelegate(IntPtr @this, Camera.StereoscopicEye eye);

		// Token: 0x02000468 RID: 1128
		// (Invoke) Token: 0x06003171 RID: 12657
		private delegate void ResetStereoProjectionMatricesDelegate(IntPtr @this);

		// Token: 0x02000469 RID: 1129
		// (Invoke) Token: 0x06003173 RID: 12659
		private delegate void ResetStereoViewMatricesDelegate(IntPtr @this);

		// Token: 0x0200046A RID: 1130
		// (Invoke) Token: 0x06003175 RID: 12661
		private delegate bool RenderToCubemapImplDelegate(IntPtr @this, IntPtr tex, int faceMask);

		// Token: 0x0200046B RID: 1131
		// (Invoke) Token: 0x06003177 RID: 12663
		private delegate bool RenderToCubemapEyeImplDelegate(IntPtr @this, IntPtr cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye);

		// Token: 0x0200046C RID: 1132
		// (Invoke) Token: 0x06003179 RID: 12665
		private delegate void RenderDontRestoreDelegate(IntPtr @this);

		// Token: 0x0200046D RID: 1133
		// (Invoke) Token: 0x0600317B RID: 12667
		private delegate void SubmitRenderRequestsInternalDelegate(IntPtr @this, IntPtr requests);

		// Token: 0x0200046E RID: 1134
		// (Invoke) Token: 0x0600317D RID: 12669
		private delegate IntPtr SubmitBuiltInObjectIDRenderRequestDelegate(IntPtr @this, IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x0200046F RID: 1135
		// (Invoke) Token: 0x0600317F RID: 12671
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x02000470 RID: 1136
		// (Invoke) Token: 0x06003181 RID: 12673
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x06003183 RID: 12675
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x02000472 RID: 1138
		// (Invoke) Token: 0x06003185 RID: 12677
		private delegate void AddCommandBufferAsyncImplDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt, IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x02000473 RID: 1139
		// (Invoke) Token: 0x06003187 RID: 12679
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x06003189 RID: 12681
		private delegate void get_transparencySortAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000475 RID: 1141
		// (Invoke) Token: 0x0600318B RID: 12683
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000476 RID: 1142
		// (Invoke) Token: 0x0600318D RID: 12685
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x0600318F RID: 12687
		private delegate void get_cullingMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x06003191 RID: 12689
		private delegate void set_cullingMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000479 RID: 1145
		// (Invoke) Token: 0x06003193 RID: 12691
		private delegate void get_curvature_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x06003195 RID: 12693
		private delegate void set_curvature_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200047B RID: 1147
		// (Invoke) Token: 0x06003197 RID: 12695
		private delegate void get_sensorSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200047C RID: 1148
		// (Invoke) Token: 0x06003199 RID: 12697
		private delegate void set_sensorSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200047D RID: 1149
		// (Invoke) Token: 0x0600319B RID: 12699
		private delegate void get_lensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x0600319D RID: 12701
		private delegate void set_lensShift_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x0600319F RID: 12703
		private delegate void GetGateFittedLensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x060031A1 RID: 12705
		private delegate void GetLocalSpaceAim_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x060031A3 RID: 12707
		private delegate void SetTargetBuffersImpl_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth);

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x060031A5 RID: 12709
		private delegate void SetTargetBuffersMRTImpl_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth);

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x060031A7 RID: 12711
		private delegate void get_nonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x060031A9 RID: 12713
		private delegate void set_nonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000485 RID: 1157
		// (Invoke) Token: 0x060031AB RID: 12715
		private delegate void get_previousViewProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000486 RID: 1158
		// (Invoke) Token: 0x060031AD RID: 12717
		private delegate void ViewportToScreenPoint_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x02000487 RID: 1159
		// (Invoke) Token: 0x060031AF RID: 12719
		private delegate void GetFrustumPlaneSizeAt_InjectedDelegate(IntPtr @this, float distance, [Out] IntPtr ret);

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x060031B1 RID: 12721
		private delegate void CalculateFrustumCornersInternal_InjectedDelegate(IntPtr @this, IntPtr viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr outCorners);

		// Token: 0x02000489 RID: 1161
		// (Invoke) Token: 0x060031B3 RID: 12723
		private delegate void CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate([Out] IntPtr output, float focalLength, IntPtr sensorSize, IntPtr lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode);

		// Token: 0x0200048A RID: 1162
		// (Invoke) Token: 0x060031B5 RID: 12725
		private delegate void get_scene_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200048B RID: 1163
		// (Invoke) Token: 0x060031B7 RID: 12727
		private delegate void set_scene_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x060031B9 RID: 12729
		private delegate void GetStereoNonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x0200048D RID: 1165
		// (Invoke) Token: 0x060031BB RID: 12731
		private delegate void GetStereoViewMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x0200048E RID: 1166
		// (Invoke) Token: 0x060031BD RID: 12733
		private delegate void GetStereoProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);
	}
}
