using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	public class Graphics : Object
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		// Note: this type is marked as 'beforefieldinit'.
		static Graphics()
		{
			Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Graphics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
			Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "kMaxDrawMeshInstanceCount");
			Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "s_RenderInstancedDataLayouts");
			Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664162);
			Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664163);
			Graphics.NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664164);
			Graphics.NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664165);
			Graphics.NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664166);
			Graphics.NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664167);
			Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664168);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664169);
			Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664170);
			Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664171);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664172);
			Graphics.NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664173);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664174);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664175);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Private_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664176);
			Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664177);
			Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664178);
			Graphics.NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664179);
			Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664180);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664181);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664182);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664183);
			Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664184);
			Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664185);
			Graphics.NativeMethodInfoPtr_DrawTextureImpl_Private_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Color_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664186);
			Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664187);
			Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Int32_Int32_Int32_Int32_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664188);
			Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664189);
			Graphics.NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664190);
			Graphics.NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664191);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664192);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664193);
			Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664194);
			Graphics.NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664195);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664196);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664197);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664198);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664199);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664200);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664201);
			Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664202);
			Graphics.NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664203);
			Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664204);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664205);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664206);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664208);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664209);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664210);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Injected_Private_Static_Void_Mesh_Int32_Material_byref_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664211);
			Graphics.NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664212);
			Graphics.GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
			Graphics.set_activeTierDelegateField = IL2CPP.ResolveICall<Graphics.set_activeTierDelegate>("UnityEngine.Graphics::set_activeTier");
			Graphics.Internal_SetRandomWriteTargetRTDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetRTDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT");
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer");
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer");
			Graphics.ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<Graphics.ClearRandomWriteTargetsDelegate>("UnityEngine.Graphics::ClearRandomWriteTargets");
			Graphics.CopyTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_FullDelegate>("UnityEngine.Graphics::CopyTexture_Full");
			Graphics.CopyTexture_Slice_AllMipsDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_AllMipsDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips");
			Graphics.ConvertTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_FullDelegate>("UnityEngine.Graphics::ConvertTexture_Full");
			Graphics.ConvertTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_SliceDelegate>("UnityEngine.Graphics::ConvertTexture_Slice");
			Graphics.CopyBufferImplDelegateField = IL2CPP.ResolveICall<Graphics.CopyBufferImplDelegate>("UnityEngine.Graphics::CopyBufferImpl");
			Graphics.Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
			Graphics.Internal_DrawProceduralIndexedNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow");
			Graphics.Internal_DrawProceduralIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow");
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow");
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer");
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer");
			Graphics.Internal_BlitMaterial6DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial6Delegate>("UnityEngine.Graphics::Internal_BlitMaterial6");
			Graphics.Internal_BlitMultiTap4DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap4Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap4");
			Graphics.Internal_BlitMultiTap5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap5Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap5");
			Graphics.Blit3DelegateField = IL2CPP.ResolveICall<Graphics.Blit3Delegate>("UnityEngine.Graphics::Blit3");
			Graphics.CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
			Graphics.WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
			Graphics.ExecuteCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferAsyncDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync");
			Graphics.GetActiveColorBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveColorBuffer_Injected");
			Graphics.GetActiveDepthBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveDepthBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveDepthBuffer_Injected");
			Graphics.Internal_SetMRTSimple_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTSimple_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTSimple_Injected");
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTFullSetup_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTFullSetup_Injected");
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");
			Graphics.Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0003125C File Offset: 0x0002F45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233799, XrefRangeEnd = 1233801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetMaxDrawMeshInstanceCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0003128C File Offset: 0x0002F48C
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00005A4E File Offset: 0x00003C4E
		public unsafe static UnityEngine.Rendering.GraphicsTier activeTier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233803, RefRangeEnd = 1233804, XrefRangeStart = 1233801, XrefRangeEnd = 1233803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Graphics.set_activeTierDelegateField(value);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000312BC File Offset: 0x0002F4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233804, XrefRangeEnd = 1233806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetPreserveFramebufferAlpha()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000312EC File Offset: 0x0002F4EC
		public unsafe static bool preserveFramebufferAlpha
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1233811, RefRangeEnd = 1233814, XrefRangeStart = 1233806, XrefRangeEnd = 1233811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0003131C File Offset: 0x0002F51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233814, XrefRangeEnd = 1233816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0003134C File Offset: 0x0002F54C
		public unsafe static UnityEngine.Rendering.OpenGLESVersion minOpenGLESVersion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233821, RefRangeEnd = 1233823, XrefRangeStart = 1233816, XrefRangeEnd = 1233821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0003137C File Offset: 0x0002F57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233823, XrefRangeEnd = 1233825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNullRT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000313A4 File Offset: 0x0002F5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233825, XrefRangeEnd = 1233830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00031410 File Offset: 0x0002F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233830, XrefRangeEnd = 1233832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00031490 File Offset: 0x0002F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233832, XrefRangeEnd = 1233834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcY;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0003156C File Offset: 0x0002F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233834, XrefRangeEnd = 1233839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subsetIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000315C0 File Offset: 0x0002F7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233839, XrefRangeEnd = 1233841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000315FC File Offset: 0x0002F7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233841, XrefRangeEnd = 1233846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000316E8 File Offset: 0x0002F8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233846, XrefRangeEnd = 1233848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000317D4 File Offset: 0x0002F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233848, XrefRangeEnd = 1233853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argsOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Private_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000318D0 File Offset: 0x0002FAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233853, XrefRangeEnd = 1233855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setRT;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00031948 File Offset: 0x0002FB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233855, XrefRangeEnd = 1233857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit2(Texture source, RenderTexture dest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00031990 File Offset: 0x0002FB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233857, XrefRangeEnd = 1233862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000319F4 File Offset: 0x0002FBF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1233864, RefRangeEnd = 1233869, XrefRangeStart = 1233862, XrefRangeEnd = 1233864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00031A2C File Offset: 0x0002FC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233869, XrefRangeEnd = 1233877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00031A98 File Offset: 0x0002FC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233877, XrefRangeEnd = 1233886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00031AF8 File Offset: 0x0002FCF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233898, RefRangeEnd = 1233900, XrefRangeStart = 1233886, XrefRangeEnd = 1233898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00031B58 File Offset: 0x0002FD58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1233905, RefRangeEnd = 1233908, XrefRangeStart = 1233900, XrefRangeEnd = 1233905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1233913, RefRangeEnd = 1233924, XrefRangeStart = 1233908, XrefRangeEnd = 1233913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcY;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233924, XrefRangeEnd = 1233932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenRect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftBorder;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBorder;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topBorder;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomBorder;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawTextureImpl_Private_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Color_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00031D70 File Offset: 0x0002FF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233932, XrefRangeEnd = 1233942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenRect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftBorder;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBorder;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topBorder;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomBorder;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00031E1C File Offset: 0x0003001C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233955, RefRangeEnd = 1233957, XrefRangeStart = 1233942, XrefRangeEnd = 1233955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenRect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftBorder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBorder;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topBorder;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomBorder;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Int32_Int32_Int32_Int32_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00031EBC File Offset: 0x000300BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233957, XrefRangeEnd = 1233961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenRect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00031F20 File Offset: 0x00030120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233961, XrefRangeEnd = 1233973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00031F74 File Offset: 0x00030174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233988, RefRangeEnd = 1233989, XrefRangeStart = 1233973, XrefRangeEnd = 1233988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00031FB8 File Offset: 0x000301B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233993, RefRangeEnd = 1233994, XrefRangeStart = 1233989, XrefRangeEnd = 1233993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useLightProbes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0003207C File Offset: 0x0003027C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234006, RefRangeEnd = 1234007, XrefRangeStart = 1233994, XrefRangeEnd = 1234006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00032168 File Offset: 0x00030368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234030, RefRangeEnd = 1234033, XrefRangeStart = 1234007, XrefRangeEnd = 1234030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00032254 File Offset: 0x00030454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234055, RefRangeEnd = 1234056, XrefRangeStart = 1234033, XrefRangeEnd = 1234055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argsOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00032350 File Offset: 0x00030550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234061, RefRangeEnd = 1234063, XrefRangeStart = 1234056, XrefRangeEnd = 1234061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00032398 File Offset: 0x00030598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234071, RefRangeEnd = 1234072, XrefRangeStart = 1234063, XrefRangeEnd = 1234071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000323FC File Offset: 0x000305FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234077, RefRangeEnd = 1234080, XrefRangeStart = 1234072, XrefRangeEnd = 1234077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Material mat, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00032464 File Offset: 0x00030664
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234088, RefRangeEnd = 1234091, XrefRangeStart = 1234080, XrefRangeEnd = 1234088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000324C0 File Offset: 0x000306C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234103, RefRangeEnd = 1234105, XrefRangeStart = 1234091, XrefRangeEnd = 1234103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00032524 File Offset: 0x00030724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234117, RefRangeEnd = 1234118, XrefRangeStart = 1234105, XrefRangeEnd = 1234117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000325BC File Offset: 0x000307BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234122, RefRangeEnd = 1234123, XrefRangeStart = 1234118, XrefRangeEnd = 1234122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00032684 File Offset: 0x00030884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234127, RefRangeEnd = 1234128, XrefRangeStart = 1234123, XrefRangeEnd = 1234127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset = 0, MaterialPropertyBlock properties = null, UnityEngine.Rendering.ShadowCastingMode castShadows = UnityEngine.Rendering.ShadowCastingMode.On, bool receiveShadows = true, int layer = 0, Camera camera = null, UnityEngine.Rendering.LightProbeUsage lightProbeUsage = UnityEngine.Rendering.LightProbeUsage.BlendProbes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argsOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003276C File Offset: 0x0003096C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234135, RefRangeEnd = 1234136, XrefRangeStart = 1234128, XrefRangeEnd = 1234135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect screenRect, Texture texture)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenRect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000327B0 File Offset: 0x000309B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1234140, RefRangeEnd = 1234144, XrefRangeStart = 1234136, XrefRangeEnd = 1234140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000327E8 File Offset: 0x000309E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234148, RefRangeEnd = 1234149, XrefRangeStart = 1234144, XrefRangeEnd = 1234148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0003282C File Offset: 0x00030A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234149, XrefRangeEnd = 1234151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00032898 File Offset: 0x00030A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234151, XrefRangeEnd = 1234153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subsetIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000328EC File Offset: 0x00030AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234153, XrefRangeEnd = 1234155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000329D8 File Offset: 0x00030BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234155, XrefRangeEnd = 1234157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argsOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Injected_Private_Static_Void_Mesh_Int32_Material_byref_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00032AD4 File Offset: 0x00030CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234157, XrefRangeEnd = 1234159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00005A19 File Offset: 0x00003C19
		public Graphics(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00032B38 File Offset: 0x00030D38
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00005A22 File Offset: 0x00003C22
		public unsafe static int kMaxDrawMeshInstanceCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00032B54 File Offset: 0x00030D54
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00005A30 File Offset: 0x00003C30
		public unsafe static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RenderInstancedDataLayout>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00005A42 File Offset: 0x00003C42
		public static ColorGamut GetActiveColorGamut()
		{
			return Graphics.GetActiveColorGamutDelegateField();
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00032B7C File Offset: 0x00030D7C
		public static ColorGamut activeColorGamut
		{
			get
			{
				return Graphics.GetActiveColorGamut();
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00032B94 File Offset: 0x00030D94
		public static RenderBuffer GetActiveColorBuffer()
		{
			RenderBuffer result;
			Graphics.GetActiveColorBuffer_Injected(out result);
			return result;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00032BAC File Offset: 0x00030DAC
		public static RenderBuffer GetActiveDepthBuffer()
		{
			RenderBuffer result;
			Graphics.GetActiveDepthBuffer_Injected(out result);
			return result;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00005A5B File Offset: 0x00003C5B
		public static void Internal_SetMRTSimple(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_Injected(color, ref depth, mip, face, depthSlice);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00032BC4 File Offset: 0x00030DC4
		public static void Internal_SetMRTFullSetup(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_Injected(color, ref depth, mip, face, depthSlice, colorLA, colorSA, depthLA, depthSA);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00005A69 File Offset: 0x00003C69
		public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRTDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav));
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00005A7C File Offset: 0x00003C7C
		public static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00005A90 File Offset: 0x00003C90
		public static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public static void ClearRandomWriteTargets()
		{
			Graphics.ClearRandomWriteTargetsDelegateField();
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public static void CopyTexture_Full(Texture src, Texture dst)
		{
			Graphics.CopyTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00005AC8 File Offset: 0x00003CC8
		public static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00005AE2 File Offset: 0x00003CE2
		public static bool ConvertTexture_Full(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00005AFA File Offset: 0x00003CFA
		public static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00005B14 File Offset: 0x00003D14
		public static void CopyBufferImpl(GraphicsBuffer source, GraphicsBuffer dest)
		{
			Graphics.CopyBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00005B2C File Offset: 0x00003D2C
		public static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_Injected(mesh, subsetIndex, ref position, ref rotation);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00032BE8 File Offset: 0x00030DE8
		public static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_Injected(mesh, submeshIndex, material, ref bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00032C10 File Offset: 0x00030E10
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00005B39 File Offset: 0x00003D39
		public static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00005B48 File Offset: 0x00003D48
		public static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralIndexedNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00005B5D File Offset: 0x00003D5D
		public static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00005B71 File Offset: 0x00003D71
		public static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00005B8B File Offset: 0x00003D8B
		public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005B9F File Offset: 0x00003D9F
		public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00032C3C File Offset: 0x00030E3C
		public static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_Injected(material, ref bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00032C60 File Offset: 0x00030E60
		public static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_Injected(material, ref bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00032C88 File Offset: 0x00030E88
		public static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00032CAC File Offset: 0x00030EAC
		public static void Internal_DrawProceduralIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00032CD0 File Offset: 0x00030ED0
		public static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00032CF8 File Offset: 0x00030EF8
		public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00005BB9 File Offset: 0x00003DB9
		public static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT, destDepthSlice);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005BDC File Offset: 0x00003DDC
		public static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			Graphics.Internal_BlitMultiTap4DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets));
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00005C00 File Offset: 0x00003E00
		public static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
		{
			Graphics.Internal_BlitMultiTap5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets), destDepthSlice);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00005C26 File Offset: 0x00003E26
		public static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00005C40 File Offset: 0x00003E40
		public static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_Injected(source, dest, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00005C51 File Offset: 0x00003E51
		public static IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			return Graphics.CreateGPUFenceImplDelegateField(fenceType, stage);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00005C5F File Offset: 0x00003E5F
		public static void WaitOnGPUFenceImpl(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			Graphics.WaitOnGPUFenceImplDelegateField(fencePtr, stage);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00005C6D File Offset: 0x00003E6D
		public static void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Graphics.ExecuteCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00005C80 File Offset: 0x00003E80
		public static void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00005C8D File Offset: 0x00003E8D
		public static void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00032D20 File Offset: 0x00030F20
		public static void SetRenderTargetImpl(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple(colorBuffers, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00005C9A File Offset: 0x00003E9A
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00005CA9 File Offset: 0x00003EA9
		public static void SetRenderTarget(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00032D3C File Offset: 0x00030F3C
		public static RenderBuffer activeColorBuffer
		{
			get
			{
				return Graphics.GetActiveColorBuffer();
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00032D54 File Offset: 0x00030F54
		public static RenderBuffer activeDepthBuffer
		{
			get
			{
				return Graphics.GetActiveDepthBuffer();
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00032D6C File Offset: 0x00030F6C
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			bool flag = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00032DB8 File Offset: 0x00030FB8
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			bool flag = uav == null;
			if (flag)
			{
				throw new ArgumentNullException("uav");
			}
			bool flag2 = uav.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("uav");
			}
			bool flag3 = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00032E38 File Offset: 0x00031038
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			bool flag = uav == null;
			if (flag)
			{
				throw new ArgumentNullException("uav");
			}
			bool flag2 = uav.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("uav");
			}
			bool flag3 = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetGraphicsBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public static void CopyTexture(Texture src, Texture dst)
		{
			Graphics.CopyTexture_Full(src, dst);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00005CC2 File Offset: 0x00003EC2
		public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00032EB8 File Offset: 0x000310B8
		public static bool ConvertTexture(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_Full(src, dst);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00032ED4 File Offset: 0x000310D4
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00032EF0 File Offset: 0x000310F0
		public static UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage stage)
		{
			return Graphics.CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation, UnityEngine.Rendering.GraphicsFence.TranslateSynchronizationStageToFlags(stage));
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00032F10 File Offset: 0x00031110
		public static UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
		{
			return Graphics.CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation, UnityEngine.Rendering.SynchronisationStageFlags.PixelProcessing);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00032F2C File Offset: 0x0003112C
		public static UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			UnityEngine.Rendering.GraphicsFence result = default(UnityEngine.Rendering.GraphicsFence);
			result.m_FenceType = fenceType;
			result.m_Ptr = Graphics.CreateGPUFenceImpl(fenceType, stage);
			result.InitPostAllocation();
			result.Validate();
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00005CCF File Offset: 0x00003ECF
		public static void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence)
		{
			Graphics.WaitOnAsyncGraphicsFence(fence, UnityEngine.Rendering.SynchronisationStage.PixelProcessing);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00032F70 File Offset: 0x00031170
		public static void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage)
		{
			bool flag = fence.m_FenceType > UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation;
			if (flag)
			{
				throw new ArgumentException("Graphics.WaitOnGraphicsFence can only be called with fences created with GraphicsFenceType.AsyncQueueSynchronization.");
			}
			fence.Validate();
			bool flag2 = fence.IsFencePending();
			if (flag2)
			{
				Graphics.WaitOnGPUFenceImpl(fence.m_Ptr, UnityEngine.Rendering.GraphicsFence.TranslateSynchronizationStageToFlags(stage));
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00032FBC File Offset: 0x000311BC
		public static void ValidateCopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
		{
			bool flag = source == null;
			if (flag)
			{
				throw new ArgumentNullException("source");
			}
			bool flag2 = dest == null;
			if (flag2)
			{
				throw new ArgumentNullException("dest");
			}
			long num = (long)source.count * (long)source.stride;
			long num2 = (long)dest.count * (long)dest.stride;
			bool flag3 = num != num2;
			if (flag3)
			{
				throw new ArgumentException(String.Format("CopyBuffer source and destination buffers must be the same size, source was {0} bytes, dest was {1} bytes", num, num2));
			}
			bool flag4 = (source.target & GraphicsBuffer.Target.CopySource) == (GraphicsBuffer.Target)0;
			if (flag4)
			{
				throw new ArgumentException("CopyBuffer source must have CopySource target", "source");
			}
			bool flag5 = (dest.target & GraphicsBuffer.Target.CopyDestination) == (GraphicsBuffer.Target)0;
			if (flag5)
			{
				throw new ArgumentException("CopyBuffer destination must have CopyDestination target", "dest");
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00005CDA File Offset: 0x00003EDA
		public static void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
		{
			Graphics.ValidateCopyBuffer(source, dest);
			Graphics.CopyBufferImpl(source, dest);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003307C File Offset: 0x0003127C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000330A0 File Offset: 0x000312A0
		public static RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(Type type)
		{
			int hashCode = type.GetHashCode();
			RenderInstancedDataLayout renderInstancedDataLayout;
			bool flag = !Graphics.s_RenderInstancedDataLayouts.TryGetValue(hashCode, out renderInstancedDataLayout);
			if (flag)
			{
				renderInstancedDataLayout = new RenderInstancedDataLayout(type);
				Graphics.s_RenderInstancedDataLayouts.Add(hashCode, renderInstancedDataLayout);
			}
			return renderInstancedDataLayout;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000330E8 File Offset: 0x000312E8
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00005CED File Offset: 0x00003EED
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.DrawMeshNow(mesh, position, rotation, -1);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00033118 File Offset: 0x00031318
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00033158 File Offset: 0x00031358
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00033194 File Offset: 0x00031394
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = matrices == null;
			if (flag)
			{
				throw new ArgumentNullException("matrices");
			}
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000331D8 File Offset: 0x000313D8
		public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage, [Optional] LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag7 = count > 0;
			if (flag7)
			{
				Graphics.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000332B4 File Offset: 0x000314B4
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag2)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag3 = mesh == null;
			if (flag3)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag4 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag5 = material == null;
			if (flag5)
			{
				throw new ArgumentNullException("material");
			}
			bool flag6 = bufferWithArgs == null;
			if (flag6)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			bool flag7 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag7)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00005CFA File Offset: 0x00003EFA
		public static void DrawProceduralNow(MeshTopology topology, int vertexCount, [Optional] int instanceCount)
		{
			Graphics.Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000333A0 File Offset: 0x000315A0
		public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000333CC File Offset: 0x000315CC
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00033410 File Offset: 0x00031610
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00033468 File Offset: 0x00031668
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000334AC File Offset: 0x000316AC
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00033504 File Offset: 0x00031704
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			Graphics.Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00033528 File Offset: 0x00031728
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00033564 File Offset: 0x00031764
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000335B4 File Offset: 0x000317B4
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00033604 File Offset: 0x00031804
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00033668 File Offset: 0x00031868
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00005D06 File Offset: 0x00003F06
		public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3(source, dest, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00005D13 File Offset: 0x00003F13
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00005D24 File Offset: 0x00003F24
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, dest, mat, pass, true, destDepthSlice);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00005D34 File Offset: 0x00003F34
		public static void Blit(Texture source, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, null, mat, pass, false);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005D42 File Offset: 0x00003F42
		public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, null, mat, pass, false, destDepthSlice);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00005D51 File Offset: 0x00003F51
		public static void Blit(Texture source, Material mat)
		{
			Graphics.Blit(source, mat, -1);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000336CC File Offset: 0x000318CC
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap4(source, dest, mat, offsets);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005D5D File Offset: 0x00003F5D
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00033704 File Offset: 0x00031904
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005D6D File Offset: 0x00003F6D
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0003373C File Offset: 0x0003193C
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00033768 File Offset: 0x00031968
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00033798 File Offset: 0x00031998
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000337C8 File Offset: 0x000319C8
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000337F8 File Offset: 0x000319F8
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00033830 File Offset: 0x00031A30
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00033868 File Offset: 0x00031A68
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00033898 File Offset: 0x00031A98
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000338CC File Offset: 0x00031ACC
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00033900 File Offset: 0x00031B00
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00033924 File Offset: 0x00031B24
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00033948 File Offset: 0x00031B48
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00033974 File Offset: 0x00031B74
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000339A0 File Offset: 0x00031BA0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000339C4 File Offset: 0x00031BC4
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000339EC File Offset: 0x00031BEC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00033A14 File Offset: 0x00031C14
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00033A44 File Offset: 0x00031C44
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, null);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00033A6C File Offset: 0x00031C6C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, matrices.Length, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00033A94 File Offset: 0x00031C94
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00033AB8 File Offset: 0x00031CB8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00033ADC File Offset: 0x00031CDC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00033B00 File Offset: 0x00031D00
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00033B24 File Offset: 0x00031D24
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00033B4C File Offset: 0x00031D4C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00033B74 File Offset: 0x00031D74
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00033B94 File Offset: 0x00031D94
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00033BB4 File Offset: 0x00031DB4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00033BD8 File Offset: 0x00031DD8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00033BFC File Offset: 0x00031DFC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00033C20 File Offset: 0x00031E20
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00033C44 File Offset: 0x00031E44
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00033C6C File Offset: 0x00031E6C
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00033C98 File Offset: 0x00031E98
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00033CBC File Offset: 0x00031EBC
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, null, -1);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00033CE0 File Offset: 0x00031EE0
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00033D04 File Offset: 0x00031F04
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00005D7F File Offset: 0x00003F7F
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00005D93 File Offset: 0x00003F93
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00005DA6 File Offset: 0x00003FA6
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, mat, -1);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00005DB3 File Offset: 0x00003FB3
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(rt, mipLevel, face, 0);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00005DCE File Offset: 0x00003FCE
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00005DDC File Offset: 0x00003FDC
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, 0);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005DEA File Offset: 0x00003FEA
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00005DF6 File Offset: 0x00003FF6
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00005E02 File Offset: 0x00004002
		public static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveColorBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00005E0F File Offset: 0x0000400F
		public static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveDepthBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00005E1C File Offset: 0x0000401C
		public static void Internal_SetMRTSimple_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00033D24 File Offset: 0x00031F24
		public static void Internal_SetMRTFullSetup_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice, IL2CPP.Il2CppObjectBaseToPtr(colorLA), IL2CPP.Il2CppObjectBaseToPtr(colorSA), depthLA, depthSA);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00005E33 File Offset: 0x00004033
		public static void Internal_DrawMeshNow1_Injected(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref position, ref rotation);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00033D58 File Offset: 0x00031F58
		public static void Internal_DrawMeshInstancedProcedural_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00033D9C File Offset: 0x00031F9C
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00033DE8 File Offset: 0x00031FE8
		public static void Internal_DrawProcedural_Injected(Material material, ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00033E20 File Offset: 0x00032020
		public static void Internal_DrawProceduralIndexed_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00033E60 File Offset: 0x00032060
		public static void Internal_DrawProceduralIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00033E9C File Offset: 0x0003209C
		public static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00033ED8 File Offset: 0x000320D8
		public static void Internal_DrawProceduralIndexedIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00033F1C File Offset: 0x0003211C
		public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00005E48 File Offset: 0x00004048
		public static void Blit5_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_s_RenderInstancedDataLayouts;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Private_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextureImpl_Private_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Color_Material_Int32_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Rect_Int32_Int32_Int32_Int32_Material_Int32_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Int32_Int32_Int32_Int32_Material_Int32_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_Material_Int32_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_Boolean_Boolean_Boolean_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstancedIndirect_Public_Static_Void_Mesh_Int32_Material_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstancedIndirect_Injected_Private_Static_Void_Mesh_Int32_Material_byref_Bounds_ComputeBuffer_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly Graphics.GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;

		// Token: 0x040006C8 RID: 1736
		private static readonly Graphics.set_activeTierDelegate set_activeTierDelegateField;

		// Token: 0x040006C9 RID: 1737
		private static readonly Graphics.Internal_SetRandomWriteTargetRTDelegate Internal_SetRandomWriteTargetRTDelegateField;

		// Token: 0x040006CA RID: 1738
		private static readonly Graphics.Internal_SetRandomWriteTargetBufferDelegate Internal_SetRandomWriteTargetBufferDelegateField;

		// Token: 0x040006CB RID: 1739
		private static readonly Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate Internal_SetRandomWriteTargetGraphicsBufferDelegateField;

		// Token: 0x040006CC RID: 1740
		private static readonly Graphics.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField;

		// Token: 0x040006CD RID: 1741
		private static readonly Graphics.CopyTexture_FullDelegate CopyTexture_FullDelegateField;

		// Token: 0x040006CE RID: 1742
		private static readonly Graphics.CopyTexture_Slice_AllMipsDelegate CopyTexture_Slice_AllMipsDelegateField;

		// Token: 0x040006CF RID: 1743
		private static readonly Graphics.ConvertTexture_FullDelegate ConvertTexture_FullDelegateField;

		// Token: 0x040006D0 RID: 1744
		private static readonly Graphics.ConvertTexture_SliceDelegate ConvertTexture_SliceDelegateField;

		// Token: 0x040006D1 RID: 1745
		private static readonly Graphics.CopyBufferImplDelegate CopyBufferImplDelegateField;

		// Token: 0x040006D2 RID: 1746
		private static readonly Graphics.Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;

		// Token: 0x040006D3 RID: 1747
		private static readonly Graphics.Internal_DrawProceduralIndexedNowDelegate Internal_DrawProceduralIndexedNowDelegateField;

		// Token: 0x040006D4 RID: 1748
		private static readonly Graphics.Internal_DrawProceduralIndirectNowDelegate Internal_DrawProceduralIndirectNowDelegateField;

		// Token: 0x040006D5 RID: 1749
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate Internal_DrawProceduralIndexedIndirectNowDelegateField;

		// Token: 0x040006D6 RID: 1750
		private static readonly Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040006D7 RID: 1751
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040006D8 RID: 1752
		private static readonly Graphics.Internal_BlitMaterial6Delegate Internal_BlitMaterial6DelegateField;

		// Token: 0x040006D9 RID: 1753
		private static readonly Graphics.Internal_BlitMultiTap4Delegate Internal_BlitMultiTap4DelegateField;

		// Token: 0x040006DA RID: 1754
		private static readonly Graphics.Internal_BlitMultiTap5Delegate Internal_BlitMultiTap5DelegateField;

		// Token: 0x040006DB RID: 1755
		private static readonly Graphics.Blit3Delegate Blit3DelegateField;

		// Token: 0x040006DC RID: 1756
		private static readonly Graphics.CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;

		// Token: 0x040006DD RID: 1757
		private static readonly Graphics.WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;

		// Token: 0x040006DE RID: 1758
		private static readonly Graphics.ExecuteCommandBufferAsyncDelegate ExecuteCommandBufferAsyncDelegateField;

		// Token: 0x040006DF RID: 1759
		private static readonly Graphics.GetActiveColorBuffer_InjectedDelegate GetActiveColorBuffer_InjectedDelegateField;

		// Token: 0x040006E0 RID: 1760
		private static readonly Graphics.GetActiveDepthBuffer_InjectedDelegate GetActiveDepthBuffer_InjectedDelegateField;

		// Token: 0x040006E1 RID: 1761
		private static readonly Graphics.Internal_SetMRTSimple_InjectedDelegate Internal_SetMRTSimple_InjectedDelegateField;

		// Token: 0x040006E2 RID: 1762
		private static readonly Graphics.Internal_SetMRTFullSetup_InjectedDelegate Internal_SetMRTFullSetup_InjectedDelegateField;

		// Token: 0x040006E3 RID: 1763
		private static readonly Graphics.Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;

		// Token: 0x040006E4 RID: 1764
		private static readonly Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;

		// Token: 0x040006E5 RID: 1765
		private static readonly Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006E6 RID: 1766
		private static readonly Graphics.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

		// Token: 0x040006E7 RID: 1767
		private static readonly Graphics.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

		// Token: 0x040006E8 RID: 1768
		private static readonly Graphics.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

		// Token: 0x040006E9 RID: 1769
		private static readonly Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006EA RID: 1770
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

		// Token: 0x040006EB RID: 1771
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006EC RID: 1772
		private static readonly Graphics.Blit5_InjectedDelegate Blit5_InjectedDelegateField;

		// Token: 0x02000529 RID: 1321
		// (Invoke) Token: 0x0600330C RID: 13068
		private delegate ColorGamut GetActiveColorGamutDelegate();

		// Token: 0x0200052A RID: 1322
		// (Invoke) Token: 0x0600330E RID: 13070
		private delegate void set_activeTierDelegate(UnityEngine.Rendering.GraphicsTier value);

		// Token: 0x0200052B RID: 1323
		// (Invoke) Token: 0x06003310 RID: 13072
		private delegate void Internal_SetRandomWriteTargetRTDelegate(int index, IntPtr uav);

		// Token: 0x0200052C RID: 1324
		// (Invoke) Token: 0x06003312 RID: 13074
		private delegate void Internal_SetRandomWriteTargetBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200052D RID: 1325
		// (Invoke) Token: 0x06003314 RID: 13076
		private delegate void Internal_SetRandomWriteTargetGraphicsBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200052E RID: 1326
		// (Invoke) Token: 0x06003316 RID: 13078
		private delegate void ClearRandomWriteTargetsDelegate();

		// Token: 0x0200052F RID: 1327
		// (Invoke) Token: 0x06003318 RID: 13080
		private delegate void CopyTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000530 RID: 1328
		// (Invoke) Token: 0x0600331A RID: 13082
		private delegate void CopyTexture_Slice_AllMipsDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000531 RID: 1329
		// (Invoke) Token: 0x0600331C RID: 13084
		private delegate bool ConvertTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000532 RID: 1330
		// (Invoke) Token: 0x0600331E RID: 13086
		private delegate bool ConvertTexture_SliceDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000533 RID: 1331
		// (Invoke) Token: 0x06003320 RID: 13088
		private delegate void CopyBufferImplDelegate(IntPtr source, IntPtr dest);

		// Token: 0x02000534 RID: 1332
		// (Invoke) Token: 0x06003322 RID: 13090
		private delegate void Internal_DrawProceduralNowDelegate(MeshTopology topology, int vertexCount, int instanceCount);

		// Token: 0x02000535 RID: 1333
		// (Invoke) Token: 0x06003324 RID: 13092
		private delegate void Internal_DrawProceduralIndexedNowDelegate(MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount);

		// Token: 0x02000536 RID: 1334
		// (Invoke) Token: 0x06003326 RID: 13094
		private delegate void Internal_DrawProceduralIndirectNowDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000537 RID: 1335
		// (Invoke) Token: 0x06003328 RID: 13096
		private delegate void Internal_DrawProceduralIndexedIndirectNowDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000538 RID: 1336
		// (Invoke) Token: 0x0600332A RID: 13098
		private delegate void Internal_DrawProceduralIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000539 RID: 1337
		// (Invoke) Token: 0x0600332C RID: 13100
		private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x0200053A RID: 1338
		// (Invoke) Token: 0x0600332E RID: 13102
		private delegate void Internal_BlitMaterial6Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT, int destDepthSlice);

		// Token: 0x0200053B RID: 1339
		// (Invoke) Token: 0x06003330 RID: 13104
		private delegate void Internal_BlitMultiTap4Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets);

		// Token: 0x0200053C RID: 1340
		// (Invoke) Token: 0x06003332 RID: 13106
		private delegate void Internal_BlitMultiTap5Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets, int destDepthSlice);

		// Token: 0x0200053D RID: 1341
		// (Invoke) Token: 0x06003334 RID: 13108
		private delegate void Blit3Delegate(IntPtr source, IntPtr dest, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x0200053E RID: 1342
		// (Invoke) Token: 0x06003336 RID: 13110
		private delegate IntPtr CreateGPUFenceImplDelegate(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x06003338 RID: 13112
		private delegate void WaitOnGPUFenceImplDelegate(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x02000540 RID: 1344
		// (Invoke) Token: 0x0600333A RID: 13114
		private delegate void ExecuteCommandBufferAsyncDelegate(IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x02000541 RID: 1345
		// (Invoke) Token: 0x0600333C RID: 13116
		private delegate void GetActiveColorBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000542 RID: 1346
		// (Invoke) Token: 0x0600333E RID: 13118
		private delegate void GetActiveDepthBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000543 RID: 1347
		// (Invoke) Token: 0x06003340 RID: 13120
		private delegate void Internal_SetMRTSimple_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x06003342 RID: 13122
		private delegate void Internal_SetMRTFullSetup_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice, IntPtr colorLA, IntPtr colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA);

		// Token: 0x02000545 RID: 1349
		// (Invoke) Token: 0x06003344 RID: 13124
		private delegate void Internal_DrawMeshNow1_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr position, IntPtr rotation);

		// Token: 0x02000546 RID: 1350
		// (Invoke) Token: 0x06003346 RID: 13126
		private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x06003348 RID: 13128
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x0600334A RID: 13130
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, int vertexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x02000549 RID: 1353
		// (Invoke) Token: 0x0600334C RID: 13132
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200054A RID: 1354
		// (Invoke) Token: 0x0600334E RID: 13134
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200054B RID: 1355
		// (Invoke) Token: 0x06003350 RID: 13136
		private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200054C RID: 1356
		// (Invoke) Token: 0x06003352 RID: 13138
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200054D RID: 1357
		// (Invoke) Token: 0x06003354 RID: 13140
		private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200054E RID: 1358
		// (Invoke) Token: 0x06003356 RID: 13142
		private delegate void Blit5_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);
	}
}
