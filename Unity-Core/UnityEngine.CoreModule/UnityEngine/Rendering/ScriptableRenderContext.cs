using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering
{
	// Token: 0x02000237 RID: 567
	[StructLayout(2)]
	public struct ScriptableRenderContext
	{
		// Token: 0x0600268F RID: 9871 RVA: 0x00099084 File Offset: 0x00097284
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderContext()
		{
			Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableRenderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
			ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "kRenderTypeTag");
			ScriptableRenderContext.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "m_Ptr");
			ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667432);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667433);
			ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667434);
			ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667435);
			ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667436);
			ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667437);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667438);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667439);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667440);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667441);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667442);
			ScriptableRenderContext.NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667443);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667444);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667445);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667446);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667447);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667448);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667449);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667450);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667451);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667452);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667453);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667455);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667456);
			ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667457);
			ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667458);
			ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667459);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667460);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667461);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667462);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667463);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667464);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667465);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667466);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667467);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667468);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667469);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667470);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667471);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667472);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667473);
			ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667474);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667475);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667476);
			ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667477);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667478);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667479);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667480);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667481);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667482);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667483);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667484);
			ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667486);
			ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667487);
			ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667488);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667489);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667490);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667491);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667492);
			ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667493);
			ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667494);
			ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667495);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667496);
			ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667497);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667498);
			ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667499);
			ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667500);
			ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100667501);
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
			ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::CreateShadowRendererList_Internal_Injected");
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00099688 File Offset: 0x00097888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291229, XrefRangeEnd = 1291231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samples;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colors;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0009971C File Offset: 0x0009791C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291231, XrefRangeEnd = 1291233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colors;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthReadOnly;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000997A4 File Offset: 0x000979A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291233, XrefRangeEnd = 1291235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSubPass_Internal(IntPtr self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000997D8 File Offset: 0x000979D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291235, XrefRangeEnd = 1291237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndRenderPass_Internal(IntPtr self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0009980C File Offset: 0x00097A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291237, XrefRangeEnd = 1291242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderLoop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref results;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0009985C File Offset: 0x00097A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291242, XrefRangeEnd = 1291244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sortingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000998A0 File Offset: 0x00097AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291244, XrefRangeEnd = 1291249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000998C8 File Offset: 0x00097AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291249, XrefRangeEnd = 1291254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SubmitForRenderPassValidation_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000998F8 File Offset: 0x00097AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291259, RefRangeEnd = 1291260, XrefRangeStart = 1291254, XrefRangeEnd = 1291259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras_Internal(Type listType, Object resultList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00099940 File Offset: 0x00097B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291265, RefRangeEnd = 1291267, XrefRangeStart = 1291260, XrefRangeEnd = 1291265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000999D4 File Offset: 0x00097BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291272, RefRangeEnd = 1291273, XrefRangeStart = 1291267, XrefRangeEnd = 1291272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawShadows_Internal(IntPtr shadowDrawingSettings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shadowDrawingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00099A08 File Offset: 0x00097C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291273, XrefRangeEnd = 1291275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitGeometryForCamera(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00099A40 File Offset: 0x00097C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291280, RefRangeEnd = 1291281, XrefRangeStart = 1291275, XrefRangeEnd = 1291280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00099A78 File Offset: 0x00097C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291286, RefRangeEnd = 1291287, XrefRangeStart = 1291281, XrefRangeEnd = 1291286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00099ABC File Offset: 0x00097CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291292, RefRangeEnd = 1291294, XrefRangeStart = 1291287, XrefRangeEnd = 1291292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00099B10 File Offset: 0x00097D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291294, XrefRangeEnd = 1291299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnRenderObjectCallback_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00099B38 File Offset: 0x00097D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291304, RefRangeEnd = 1291305, XrefRangeStart = 1291299, XrefRangeEnd = 1291304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireOverlay_Impl(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00099B70 File Offset: 0x00097D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291310, RefRangeEnd = 1291311, XrefRangeStart = 1291305, XrefRangeEnd = 1291310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUIOverlay_Internal(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00099BA8 File Offset: 0x00097DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291311, XrefRangeEnd = 1291316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00099C48 File Offset: 0x00097E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291316, XrefRangeEnd = 1291321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projR;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00099CD0 File Offset: 0x00097ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291326, RefRangeEnd = 1291327, XrefRangeStart = 1291321, XrefRangeEnd = 1291326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRendererListsAsync_Internal(Object rendererLists)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00099D08 File Offset: 0x00097F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291327, XrefRangeEnd = 1291332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00099D48 File Offset: 0x00097F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291341, RefRangeEnd = 1291342, XrefRangeStart = 1291332, XrefRangeEnd = 1291341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samples;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(attachments));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthAttachmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00099DBC File Offset: 0x00097FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291354, RefRangeEnd = 1291356, XrefRangeStart = 1291342, XrefRangeEnd = 1291354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colors));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputs));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00099E1C File Offset: 0x0009801C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291365, RefRangeEnd = 1291367, XrefRangeStart = 1291356, XrefRangeEnd = 1291365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colors));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDepthStencilReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00099E68 File Offset: 0x00098068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291372, RefRangeEnd = 1291375, XrefRangeStart = 1291367, XrefRangeEnd = 1291372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSubPass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndSubPass_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00099E90 File Offset: 0x00098090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291380, RefRangeEnd = 1291381, XrefRangeStart = 1291375, XrefRangeEnd = 1291380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndRenderPass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_EndRenderPass_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00099EB8 File Offset: 0x000980B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1291394, RefRangeEnd = 1291401, XrefRangeStart = 1291381, XrefRangeEnd = 1291394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00099EE0 File Offset: 0x000980E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291401, XrefRangeEnd = 1291409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SubmitForRenderPassValidation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00099F10 File Offset: 0x00098110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291419, RefRangeEnd = 1291420, XrefRangeStart = 1291409, XrefRangeEnd = 1291419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCameras(List<Camera> results)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00099F48 File Offset: 0x00098148
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1291430, RefRangeEnd = 1291446, XrefRangeStart = 1291420, XrefRangeEnd = 1291430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00099F98 File Offset: 0x00098198
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1291454, RefRangeEnd = 1291462, XrefRangeStart = 1291446, XrefRangeEnd = 1291454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stateBlock;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00099FF8 File Offset: 0x000981F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291474, RefRangeEnd = 1291475, XrefRangeStart = 1291462, XrefRangeEnd = 1291474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, Unity.Collections.NativeArray<ShaderTagId> tagValues, Unity.Collections.NativeArray<RenderStateBlock> stateBlocks)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tagValues));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(stateBlocks));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0009A094 File Offset: 0x00098294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291480, RefRangeEnd = 1291482, XrefRangeStart = 1291475, XrefRangeEnd = 1291480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawShadows(ref ShadowDrawingSettings settings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0009A0C8 File Offset: 0x000982C8
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 1291499, RefRangeEnd = 1291588, XrefRangeStart = 1291482, XrefRangeEnd = 1291499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBuffer(CommandBuffer commandBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x0009A100 File Offset: 0x00098300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291605, RefRangeEnd = 1291606, XrefRangeStart = 1291588, XrefRangeEnd = 1291605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0009A144 File Offset: 0x00098344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291613, RefRangeEnd = 1291614, XrefRangeStart = 1291606, XrefRangeEnd = 1291613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0009A188 File Offset: 0x00098388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291614, XrefRangeEnd = 1291618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x0009A1DC File Offset: 0x000983DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291626, RefRangeEnd = 1291628, XrefRangeStart = 1291618, XrefRangeEnd = 1291626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnRenderObjectCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0009A204 File Offset: 0x00098404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291632, RefRangeEnd = 1291633, XrefRangeStart = 1291628, XrefRangeEnd = 1291632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireOverlay(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0009A23C File Offset: 0x0009843C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291637, RefRangeEnd = 1291641, XrefRangeStart = 1291633, XrefRangeEnd = 1291637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUIOverlay(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0009A274 File Offset: 0x00098474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291641, XrefRangeEnd = 1291650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullingResults Cull(ref ScriptableCullingParameters parameters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0009A2B4 File Offset: 0x000984B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291654, RefRangeEnd = 1291655, XrefRangeStart = 1291650, XrefRangeEnd = 1291654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableRenderContext other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0009A2F4 File Offset: 0x000984F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291655, XrefRangeEnd = 1291661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0009A338 File Offset: 0x00098538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0009A368 File Offset: 0x00098568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291674, RefRangeEnd = 1291675, XrefRangeStart = 1291661, XrefRangeEnd = 1291674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0009A3B0 File Offset: 0x000985B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291690, RefRangeEnd = 1291691, XrefRangeStart = 1291675, XrefRangeEnd = 1291690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateRendererList(ref RendererListParams param)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(param));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0009A3F8 File Offset: 0x000985F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291699, RefRangeEnd = 1291700, XrefRangeStart = 1291691, XrefRangeEnd = 1291699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrixL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrixL;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrixR;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrixR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0009A474 File Offset: 0x00098674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291712, RefRangeEnd = 1291713, XrefRangeStart = 1291700, XrefRangeEnd = 1291712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0009A4D4 File Offset: 0x000986D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291729, RefRangeEnd = 1291730, XrefRangeStart = 1291713, XrefRangeEnd = 1291729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList CreateSkyboxRendererList(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0009A518 File Offset: 0x00098718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291734, RefRangeEnd = 1291735, XrefRangeStart = 1291730, XrefRangeEnd = 1291734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRendererListsAsync(List<RendererList> rendererLists)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0009A550 File Offset: 0x00098750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291743, RefRangeEnd = 1291744, XrefRangeStart = 1291735, XrefRangeEnd = 1291743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListStatus QueryRendererListStatus(RendererList rendererList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rendererList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0009A590 File Offset: 0x00098790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291744, XrefRangeEnd = 1291746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderLoop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref results;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0009A5E0 File Offset: 0x000987E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291746, XrefRangeEnd = 1291748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0009A614 File Offset: 0x00098814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291748, XrefRangeEnd = 1291750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubmitForRenderPassValidation_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0009A654 File Offset: 0x00098854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291750, XrefRangeEnd = 1291752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, Object resultList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0009A6AC File Offset: 0x000988AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291752, XrefRangeEnd = 1291754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0009A750 File Offset: 0x00098950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291754, XrefRangeEnd = 1291756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowDrawingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0009A790 File Offset: 0x00098990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291756, XrefRangeEnd = 1291758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0009A7D4 File Offset: 0x000989D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291758, XrefRangeEnd = 1291760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0009A828 File Offset: 0x00098A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291760, XrefRangeEnd = 1291762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoSetup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0009A888 File Offset: 0x00098A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291762, XrefRangeEnd = 1291764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0009A8BC File Offset: 0x00098ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291764, XrefRangeEnd = 1291766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0009A900 File Offset: 0x00098B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291766, XrefRangeEnd = 1291768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0009A944 File Offset: 0x00098B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291768, XrefRangeEnd = 1291770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tagName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPassTagName;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagValues;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateBlocks;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0009A9F8 File Offset: 0x00098BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291770, XrefRangeEnd = 1291772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int mode, ref Matrix4x4 proj, ref Matrix4x4 view, ref Matrix4x4 projR, ref Matrix4x4 viewR, out RendererList ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &proj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &view;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projR;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewR;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0009AA94 File Offset: 0x00098C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291772, XrefRangeEnd = 1291774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, Object rendererLists)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0009AAD8 File Offset: 0x00098CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291774, XrefRangeEnd = 1291776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref RendererList handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0001181D File Offset: 0x0000FA1D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, ref this));
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0009AB24 File Offset: 0x00098D24
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0001182F File Offset: 0x0000FA2F
		public unsafe static ShaderTagId kRenderTypeTag
		{
			get
			{
				ShaderTagId result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&value));
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0001183D File Offset: 0x0000FA3D
		public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_Injected(ref this, camera, eye, isFinalPass);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00011848 File Offset: 0x0000FA48
		public void StartMultiEye_Internal(Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_Injected(ref this, camera, eye);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00011852 File Offset: 0x0000FA52
		public void StopMultiEye_Internal(Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_Injected(ref this, camera);
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0001185B File Offset: 0x0000FA5B
		public void DrawSkybox_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_Injected(ref this, camera);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00011864 File Offset: 0x0000FA64
		public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_Injected(ref this, camera, gizmoSubset);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0009AB40 File Offset: 0x00098D40
		public IntPtr Internal_GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0009AB58 File Offset: 0x00098D58
		public RendererList CreateShadowRendererList_Internal(IntPtr shadowDrawinSettings)
		{
			RendererList result;
			ScriptableRenderContext.CreateShadowRendererList_Internal_Injected(ref this, shadowDrawinSettings, out result);
			return result;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0001186E File Offset: 0x0000FA6E
		public void BeginRenderPass(int width, int height, int volumeDepth, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
		{
			ScriptableRenderContext.BeginRenderPass_Internal(this.m_Ptr, width, height, volumeDepth, samples, (IntPtr)attachments.GetUnsafeReadOnlyPtr<AttachmentDescriptor>(), attachments.Length, depthAttachmentIndex);
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0009AB70 File Offset: 0x00098D70
		public ScopedRenderPass BeginScopedRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
		{
			this.BeginRenderPass(width, height, samples, attachments, depthAttachmentIndex);
			return new ScopedRenderPass(this);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00011897 File Offset: 0x0000FA97
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000118CD File Offset: 0x0000FACD
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0009AB9C File Offset: 0x00098D9C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0009ABC8 File Offset: 0x00098DC8
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0009ABF0 File Offset: 0x00098DF0
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0009AC18 File Offset: 0x00098E18
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000118F6 File Offset: 0x0000FAF6
		public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, Unity.Collections.NativeArray<ShaderTagId> renderTypes, Unity.Collections.NativeArray<RenderStateBlock> stateBlocks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00011903 File Offset: 0x0000FB03
		public void StereoEndRender(Camera camera)
		{
			this.StereoEndRender(camera, 0, true);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00011910 File Offset: 0x0000FB10
		public void StereoEndRender(Camera camera, int eye)
		{
			this.StereoEndRender(camera, eye, true);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0001191D File Offset: 0x0000FB1D
		public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
		{
			this.StereoEndRender_Internal(camera, eye, isFinalPass);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0001192A File Offset: 0x0000FB2A
		public void StartMultiEye(Camera camera)
		{
			this.StartMultiEye(camera, 0);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00011936 File Offset: 0x0000FB36
		public void StartMultiEye(Camera camera, int eye)
		{
			this.StartMultiEye_Internal(camera, eye);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00011942 File Offset: 0x0000FB42
		public void StopMultiEye(Camera camera)
		{
			this.StopMultiEye_Internal(camera);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0001194D File Offset: 0x0000FB4D
		public void DrawSkybox(Camera camera)
		{
			this.DrawSkybox_Internal(camera);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00011958 File Offset: 0x0000FB58
		public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
		{
			this.DrawGizmos_Internal(camera, gizmoSubset);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00011964 File Offset: 0x0000FB64
		public void Validate()
		{
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0009AC40 File Offset: 0x00098E40
		public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return left.Equals(right);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0009AC5C File Offset: 0x00098E5C
		public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0009AC7C File Offset: 0x00098E7C
		public unsafe RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings)
		{
			fixed (ShadowDrawingSettings* ptr = &settings)
			{
				ShadowDrawingSettings* value = ptr;
				return this.CreateShadowRendererList_Internal((IntPtr)((void*)value));
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00011967 File Offset: 0x0000FB67
		public static void StereoEndRender_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye, isFinalPass);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0001197C File Offset: 0x0000FB7C
		public static void StartMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00011990 File Offset: 0x0000FB90
		public static void StopMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000119A3 File Offset: 0x0000FBA3
		public static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000119B6 File Offset: 0x0000FBB6
		public static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), gizmoSubset);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x000119CA File Offset: 0x0000FBCA
		public static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawinSettings, out RendererList ret)
		{
			ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegateField(ref _unity_self, shadowDrawinSettings, out ret);
		}

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_kRenderTypeTag;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Internal_Private_Void_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Internal_Private_Void_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Internal_Private_Void_IntPtr_0;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Private_Void_0;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Internal_Private_Void_Camera_0;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_EndSubPass_Public_Void_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderPass_Public_Void_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_0;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Public_Void_CullingResults_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_NativeArray_1_ShaderTagId_NativeArray_1_RenderStateBlock_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Public_Void_byref_ShadowDrawingSettings_0;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Public_Void_0;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Public_Void_Camera_0;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_RendererListDesc_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Injected_Private_Static_Boolean_byref_ScriptableRenderContext_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Type_Object_0;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr_DrawRenderers_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr_DrawShadows_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_CommandBuffer_ComputeQueueType_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Boolean_Int32_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnRenderObjectCallback_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_DrawUIOverlay_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Camera_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_Object_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0;

		// Token: 0x04002144 RID: 8516
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04002145 RID: 8517
		private static readonly ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;

		// Token: 0x04002146 RID: 8518
		private static readonly ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04002147 RID: 8519
		private static readonly ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04002148 RID: 8520
		private static readonly ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;

		// Token: 0x04002149 RID: 8521
		private static readonly ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;

		// Token: 0x0400214A RID: 8522
		private static readonly ScriptableRenderContext.CreateShadowRendererList_Internal_InjectedDelegate CreateShadowRendererList_Internal_InjectedDelegateField;

		// Token: 0x02000B6B RID: 2923
		public enum SkyboxXRMode
		{
			// Token: 0x04002BE2 RID: 11234
			Off,
			// Token: 0x04002BE3 RID: 11235
			Enabled,
			// Token: 0x04002BE4 RID: 11236
			LegacySinglePass
		}

		// Token: 0x02000B6C RID: 2924
		// (Invoke) Token: 0x06003FC5 RID: 16325
		private delegate void StereoEndRender_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye, bool isFinalPass);

		// Token: 0x02000B6D RID: 2925
		// (Invoke) Token: 0x06003FC7 RID: 16327
		private delegate void StartMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye);

		// Token: 0x02000B6E RID: 2926
		// (Invoke) Token: 0x06003FC9 RID: 16329
		private delegate void StopMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x02000B6F RID: 2927
		// (Invoke) Token: 0x06003FCB RID: 16331
		private delegate void DrawSkybox_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x02000B70 RID: 2928
		// (Invoke) Token: 0x06003FCD RID: 16333
		private delegate void DrawGizmos_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, GizmoSubset gizmoSubset);

		// Token: 0x02000B71 RID: 2929
		// (Invoke) Token: 0x06003FCF RID: 16335
		private delegate void CreateShadowRendererList_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr shadowDrawinSettings, [Out] IntPtr ret);
	}
}
