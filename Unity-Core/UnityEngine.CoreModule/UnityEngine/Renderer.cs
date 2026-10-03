using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000A7 RID: 167
	public class Renderer : Component
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x000397F8 File Offset: 0x000379F8
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer()
		{
			Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Renderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
			Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664357);
			Renderer.NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664358);
			Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664359);
			Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664360);
			Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664361);
			Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664362);
			Renderer.NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664363);
			Renderer.NativeMethodInfoPtr_CopySharedMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664364);
			Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664365);
			Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664366);
			Renderer.NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664367);
			Renderer.NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664368);
			Renderer.NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664369);
			Renderer.NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664370);
			Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664371);
			Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664372);
			Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664373);
			Renderer.NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664374);
			Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664375);
			Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664376);
			Renderer.NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664377);
			Renderer.NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664378);
			Renderer.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664379);
			Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664380);
			Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664381);
			Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664382);
			Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664383);
			Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664384);
			Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664385);
			Renderer.NativeMethodInfoPtr_set_allowOcclusionWhenDynamic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664386);
			Renderer.NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664387);
			Renderer.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664388);
			Renderer.NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664389);
			Renderer.NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664390);
			Renderer.NativeMethodInfoPtr_GetLightmapST_Private_Vector4_LightmapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664391);
			Renderer.NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664392);
			Renderer.NativeMethodInfoPtr_get_realtimeLightmapIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664393);
			Renderer.NativeMethodInfoPtr_get_lightmapScaleOffset_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664394);
			Renderer.NativeMethodInfoPtr_get_realtimeLightmapScaleOffset_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664395);
			Renderer.NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664396);
			Renderer.NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664397);
			Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664398);
			Renderer.NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664399);
			Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664400);
			Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664401);
			Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664402);
			Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664403);
			Renderer.NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664404);
			Renderer.NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664405);
			Renderer.NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664406);
			Renderer.NativeMethodInfoPtr_SetMaterials_Public_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664407);
			Renderer.NativeMethodInfoPtr_GetSharedMaterials_Public_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664408);
			Renderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664409);
			Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664410);
			Renderer.NativeMethodInfoPtr_get_localBounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664411);
			Renderer.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664412);
			Renderer.NativeMethodInfoPtr_GetLightmapST_Injected_Private_Void_LightmapType_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664413);
			Renderer.ResetBoundsDelegateField = IL2CPP.ResolveICall<Renderer.ResetBoundsDelegate>("UnityEngine.Renderer::ResetBounds");
			Renderer.ResetLocalBoundsDelegateField = IL2CPP.ResolveICall<Renderer.ResetLocalBoundsDelegate>("UnityEngine.Renderer::ResetLocalBounds");
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlockMaterialIndex");
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlockMaterialIndex");
			Renderer.HasPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.HasPropertyBlockDelegate>("UnityEngine.Renderer::HasPropertyBlock");
			Renderer.GetClosestReflectionProbesInternalDelegateField = IL2CPP.ResolveICall<Renderer.GetClosestReflectionProbesInternalDelegate>("UnityEngine.Renderer::GetClosestReflectionProbesInternal");
			Renderer.get_receiveShadowsDelegateField = IL2CPP.ResolveICall<Renderer.get_receiveShadowsDelegate>("UnityEngine.Renderer::get_receiveShadows");
			Renderer.get_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.get_forceRenderingOffDelegate>("UnityEngine.Renderer::get_forceRenderingOff");
			Renderer.set_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.set_forceRenderingOffDelegate>("UnityEngine.Renderer::set_forceRenderingOff");
			Renderer.GetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.GetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::GetIsStaticShadowCaster");
			Renderer.SetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.SetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::SetIsStaticShadowCaster");
			Renderer.get_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.get_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::get_motionVectorGenerationMode");
			Renderer.set_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.set_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::set_motionVectorGenerationMode");
			Renderer.get_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeUsageDelegate>("UnityEngine.Renderer::get_lightProbeUsage");
			Renderer.get_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_reflectionProbeUsageDelegate>("UnityEngine.Renderer::get_reflectionProbeUsage");
			Renderer.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.get_renderingLayerMaskDelegate>("UnityEngine.Renderer::get_renderingLayerMask");
			Renderer.get_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.get_rendererPriorityDelegate>("UnityEngine.Renderer::get_rendererPriority");
			Renderer.set_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.set_rendererPriorityDelegate>("UnityEngine.Renderer::set_rendererPriority");
			Renderer.get_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_rayTracingModeDelegate>("UnityEngine.Renderer::get_rayTracingMode");
			Renderer.set_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.set_rayTracingModeDelegate>("UnityEngine.Renderer::set_rayTracingMode");
			Renderer.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingLayerNameDelegate>("UnityEngine.Renderer::get_sortingLayerName");
			Renderer.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingLayerNameDelegate>("UnityEngine.Renderer::set_sortingLayerName");
			Renderer.get_sortingKeyDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingKeyDelegate>("UnityEngine.Renderer::get_sortingKey");
			Renderer.set_sortingGroupIDDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupIDDelegate>("UnityEngine.Renderer::set_sortingGroupID");
			Renderer.set_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupOrderDelegate>("UnityEngine.Renderer::set_sortingGroupOrder");
			Renderer.get_sortingGroupKeyDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingGroupKeyDelegate>("UnityEngine.Renderer::get_sortingGroupKey");
			Renderer.get_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.get_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::get_allowOcclusionWhenDynamic");
			Renderer.get_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchRootTransformDelegate>("UnityEngine.Renderer::get_staticBatchRootTransform");
			Renderer.set_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.set_staticBatchRootTransformDelegate>("UnityEngine.Renderer::set_staticBatchRootTransform");
			Renderer.get_staticBatchIndexDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchIndexDelegate>("UnityEngine.Renderer::get_staticBatchIndex");
			Renderer.SetStaticBatchInfoDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticBatchInfoDelegate>("UnityEngine.Renderer::SetStaticBatchInfo");
			Renderer.get_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::get_lightProbeProxyVolumeOverride");
			Renderer.set_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::set_lightProbeProxyVolumeOverride");
			Renderer.get_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.get_probeAnchorDelegate>("UnityEngine.Renderer::get_probeAnchor");
			Renderer.SetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapIndexDelegate>("UnityEngine.Renderer::SetLightmapIndex");
			Renderer.set_bounds_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.set_bounds_InjectedDelegate>("UnityEngine.Renderer::set_bounds_Injected");
			Renderer.set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.set_localBounds_InjectedDelegate>("UnityEngine.Renderer::set_localBounds_Injected");
			Renderer.SetStaticLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetStaticLightmapST_Injected");
			Renderer.get_worldToLocalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_worldToLocalMatrix_InjectedDelegate>("UnityEngine.Renderer::get_worldToLocalMatrix_Injected");
			Renderer.SetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetLightmapST_Injected");
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00039EF4 File Offset: 0x000380F4
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00007687 File Offset: 0x00005887
		public unsafe Bounds bounds
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1235009, RefRangeEnd = 1235047, XrefRangeStart = 1235007, XrefRangeEnd = 1235009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_bounds_Injected(ref value);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00039F30 File Offset: 0x00038130
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00007691 File Offset: 0x00005891
		public unsafe Bounds localBounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235049, RefRangeEnd = 1235050, XrefRangeStart = 1235047, XrefRangeEnd = 1235049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00039F6C File Offset: 0x0003816C
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 1235052, RefRangeEnd = 1235119, XrefRangeStart = 1235050, XrefRangeEnd = 1235052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00039FAC File Offset: 0x000381AC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1235121, RefRangeEnd = 1235138, XrefRangeStart = 1235119, XrefRangeEnd = 1235121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00039FEC File Offset: 0x000381EC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1235140, RefRangeEnd = 1235193, XrefRangeStart = 1235138, XrefRangeEnd = 1235140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0003A030 File Offset: 0x00038230
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1235195, RefRangeEnd = 1235209, XrefRangeStart = 1235193, XrefRangeEnd = 1235195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Material> GetMaterialArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003A070 File Offset: 0x00038270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235209, XrefRangeEnd = 1235211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*m = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Material>(intPtr4));
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0003A0C4 File Offset: 0x000382C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235211, XrefRangeEnd = 1235213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopySharedMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_CopySharedMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*m = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Material>(intPtr4));
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0003A118 File Offset: 0x00038318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235213, XrefRangeEnd = 1235215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003A168 File Offset: 0x00038368
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1235219, RefRangeEnd = 1235228, XrefRangeStart = 1235215, XrefRangeEnd = 1235219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003A1AC File Offset: 0x000383AC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1235230, RefRangeEnd = 1235241, XrefRangeStart = 1235228, XrefRangeEnd = 1235230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0003A1F0 File Offset: 0x000383F0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1235243, RefRangeEnd = 1235252, XrefRangeStart = 1235241, XrefRangeEnd = 1235243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_GetPropertyBlock(MaterialPropertyBlock dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0003A234 File Offset: 0x00038434
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1235230, RefRangeEnd = 1235241, XrefRangeStart = 1235230, XrefRangeEnd = 1235241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyBlock(MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0003A278 File Offset: 0x00038478
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1235243, RefRangeEnd = 1235252, XrefRangeStart = 1235243, XrefRangeEnd = 1235252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPropertyBlock(MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003A2BC File Offset: 0x000384BC
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0003A2F8 File Offset: 0x000384F8
		public unsafe bool enabled
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1235254, RefRangeEnd = 1235266, XrefRangeStart = 1235252, XrefRangeEnd = 1235254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 1235268, RefRangeEnd = 1235304, XrefRangeStart = 1235266, XrefRangeEnd = 1235268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003A338 File Offset: 0x00038538
		public unsafe bool isVisible
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1235306, RefRangeEnd = 1235313, XrefRangeStart = 1235304, XrefRangeEnd = 1235306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003A374 File Offset: 0x00038574
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0003A3B0 File Offset: 0x000385B0
		public unsafe UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1235315, RefRangeEnd = 1235322, XrefRangeStart = 1235313, XrefRangeEnd = 1235315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1235324, RefRangeEnd = 1235335, XrefRangeStart = 1235322, XrefRangeEnd = 1235324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0000773D File Offset: 0x0000593D
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0003A3F0 File Offset: 0x000385F0
		public unsafe bool receiveShadows
		{
			get
			{
				return Renderer.get_receiveShadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1235337, RefRangeEnd = 1235341, XrefRangeStart = 1235335, XrefRangeEnd = 1235337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000077C9 File Offset: 0x000059C9
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0003A430 File Offset: 0x00038630
		public unsafe UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		{
			get
			{
				return Renderer.get_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1235343, RefRangeEnd = 1235346, XrefRangeStart = 1235341, XrefRangeEnd = 1235343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000077DB File Offset: 0x000059DB
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0003A470 File Offset: 0x00038670
		public unsafe UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return Renderer.get_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1235348, RefRangeEnd = 1235351, XrefRangeStart = 1235346, XrefRangeEnd = 1235348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000077ED File Offset: 0x000059ED
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0003A4B0 File Offset: 0x000386B0
		public unsafe uint renderingLayerMask
		{
			get
			{
				return Renderer.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235353, RefRangeEnd = 1235355, XrefRangeStart = 1235351, XrefRangeEnd = 1235353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003A4F0 File Offset: 0x000386F0
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0003A52C File Offset: 0x0003872C
		public unsafe int sortingLayerID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1235357, RefRangeEnd = 1235361, XrefRangeStart = 1235355, XrefRangeEnd = 1235357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1235363, RefRangeEnd = 1235374, XrefRangeStart = 1235361, XrefRangeEnd = 1235363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003A56C File Offset: 0x0003876C
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0003A5A8 File Offset: 0x000387A8
		public unsafe int sortingOrder
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1235376, RefRangeEnd = 1235380, XrefRangeStart = 1235374, XrefRangeEnd = 1235376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1235382, RefRangeEnd = 1235392, XrefRangeStart = 1235380, XrefRangeEnd = 1235382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0003A5E8 File Offset: 0x000387E8
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00007873 File Offset: 0x00005A73
		public unsafe int sortingGroupID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235394, RefRangeEnd = 1235396, XrefRangeStart = 1235392, XrefRangeEnd = 1235394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003A624 File Offset: 0x00038824
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00007886 File Offset: 0x00005A86
		public unsafe int sortingGroupOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235398, RefRangeEnd = 1235399, XrefRangeStart = 1235396, XrefRangeEnd = 1235398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000078AB File Offset: 0x00005AAB
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x0003A660 File Offset: 0x00038860
		public unsafe bool allowOcclusionWhenDynamic
		{
			get
			{
				return Renderer.get_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235401, RefRangeEnd = 1235403, XrefRangeStart = 1235399, XrefRangeEnd = 1235401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_allowOcclusionWhenDynamic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0003A6A0 File Offset: 0x000388A0
		public unsafe bool isPartOfStaticBatch
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1235405, RefRangeEnd = 1235408, XrefRangeStart = 1235403, XrefRangeEnd = 1235405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0003A6DC File Offset: 0x000388DC
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1235410, RefRangeEnd = 1235414, XrefRangeStart = 1235408, XrefRangeEnd = 1235410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0003AE84 File Offset: 0x00039084
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0003A718 File Offset: 0x00038918
		public unsafe Transform probeAnchor
		{
			get
			{
				IntPtr intPtr = Renderer.get_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235416, RefRangeEnd = 1235417, XrefRangeStart = 1235414, XrefRangeEnd = 1235416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0003A75C File Offset: 0x0003895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235417, XrefRangeEnd = 1235419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLightmapIndex(UnityEngineInternal.LightmapType lt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0003A7A8 File Offset: 0x000389A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235419, XrefRangeEnd = 1235421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetLightmapST(UnityEngineInternal.LightmapType lt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetLightmapST_Private_Vector4_LightmapType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0003A7F4 File Offset: 0x000389F4
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00007932 File Offset: 0x00005B32
		public unsafe int lightmapIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235423, RefRangeEnd = 1235424, XrefRangeStart = 1235421, XrefRangeEnd = 1235423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetLightmapIndex(value, UnityEngineInternal.LightmapType.StaticLightmap);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003A830 File Offset: 0x00038A30
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0000793E File Offset: 0x00005B3E
		public unsafe int realtimeLightmapIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235426, RefRangeEnd = 1235427, XrefRangeStart = 1235424, XrefRangeEnd = 1235426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_realtimeLightmapIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetLightmapIndex(value, UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0003A86C File Offset: 0x00038A6C
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x0000794A File Offset: 0x00005B4A
		public unsafe Vector4 lightmapScaleOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235429, RefRangeEnd = 1235430, XrefRangeStart = 1235427, XrefRangeEnd = 1235429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_lightmapScaleOffset_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetStaticLightmapST(value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00007955 File Offset: 0x00005B55
		public unsafe Vector4 realtimeLightmapScaleOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235432, RefRangeEnd = 1235433, XrefRangeStart = 1235430, XrefRangeEnd = 1235432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_realtimeLightmapScaleOffset_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetLightmapST(value, UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0003A8E4 File Offset: 0x00038AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235433, XrefRangeEnd = 1235435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaterialCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0003A920 File Offset: 0x00038B20
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1235437, RefRangeEnd = 1235447, XrefRangeStart = 1235435, XrefRangeEnd = 1235437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Material> GetSharedMaterialArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0003A960 File Offset: 0x00038B60
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		public unsafe Il2CppReferenceArray<Material> materials
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1235195, RefRangeEnd = 1235209, XrefRangeStart = 1235195, XrefRangeEnd = 1235209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1235219, RefRangeEnd = 1235228, XrefRangeStart = 1235219, XrefRangeEnd = 1235228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0003A9E4 File Offset: 0x00038BE4
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0003AA24 File Offset: 0x00038C24
		public unsafe Material material
		{
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 1235052, RefRangeEnd = 1235119, XrefRangeStart = 1235052, XrefRangeEnd = 1235119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1235140, RefRangeEnd = 1235193, XrefRangeStart = 1235140, XrefRangeEnd = 1235193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0003AA68 File Offset: 0x00038C68
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x0003AAA8 File Offset: 0x00038CA8
		public unsafe Material sharedMaterial
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1235121, RefRangeEnd = 1235138, XrefRangeStart = 1235121, XrefRangeEnd = 1235138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1235140, RefRangeEnd = 1235193, XrefRangeStart = 1235140, XrefRangeEnd = 1235193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003AAEC File Offset: 0x00038CEC
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0003AB2C File Offset: 0x00038D2C
		public unsafe Il2CppReferenceArray<Material> sharedMaterials
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1235437, RefRangeEnd = 1235447, XrefRangeStart = 1235437, XrefRangeEnd = 1235447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1235219, RefRangeEnd = 1235228, XrefRangeStart = 1235219, XrefRangeEnd = 1235228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0003AB70 File Offset: 0x00038D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235464, RefRangeEnd = 1235465, XrefRangeStart = 1235447, XrefRangeEnd = 1235464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMaterials(List<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235478, RefRangeEnd = 1235480, XrefRangeStart = 1235465, XrefRangeEnd = 1235478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterials(List<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterials_Public_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0003ABF8 File Offset: 0x00038DF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1235497, RefRangeEnd = 1235501, XrefRangeStart = 1235480, XrefRangeEnd = 1235497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSharedMaterials(List<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterials_Public_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0003AC3C File Offset: 0x00038E3C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Renderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0003AC78 File Offset: 0x00038E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235501, XrefRangeEnd = 1235503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0003ACB8 File Offset: 0x00038EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235503, XrefRangeEnd = 1235505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localBounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_localBounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0003ACF8 File Offset: 0x00038EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235505, XrefRangeEnd = 1235507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0003AD38 File Offset: 0x00038F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235507, XrefRangeEnd = 1235509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLightmapST_Injected(UnityEngineInternal.LightmapType lt, out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetLightmapST_Injected_Private_Void_LightmapType_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0000764B File Offset: 0x0000584B
		public Renderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0003AD84 File Offset: 0x00038F84
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00007654 File Offset: 0x00005854
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > UnityEngine.Rendering.ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00007665 File Offset: 0x00005865
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0003ADBC File Offset: 0x00038FBC
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00007676 File Offset: 0x00005876
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage > UnityEngine.Rendering.LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = (value ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000769B File Offset: 0x0000589B
		public void ResetBounds()
		{
			Renderer.ResetBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000076AD File Offset: 0x000058AD
		public void ResetLocalBounds()
		{
			Renderer.ResetLocalBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000076BF File Offset: 0x000058BF
		public void SetStaticLightmapST(Vector4 st)
		{
			this.SetStaticLightmapST_Injected(ref st);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000076C9 File Offset: 0x000058C9
		public void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
		{
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), materialIndex);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000076E2 File Offset: 0x000058E2
		public void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex)
		{
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest), materialIndex);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000076FB File Offset: 0x000058FB
		public bool HasPropertyBlock()
		{
			return Renderer.HasPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0000770D File Offset: 0x0000590D
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_SetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00007719 File Offset: 0x00005919
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_GetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00007725 File Offset: 0x00005925
		public void GetClosestReflectionProbesInternal(Object result)
		{
			Renderer.GetClosestReflectionProbesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(result));
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0000774F File Offset: 0x0000594F
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00007761 File Offset: 0x00005961
		public bool forceRenderingOff
		{
			get
			{
				return Renderer.get_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00007774 File Offset: 0x00005974
		public bool GetIsStaticShadowCaster()
		{
			return Renderer.GetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00007786 File Offset: 0x00005986
		public void SetIsStaticShadowCaster(bool value)
		{
			Renderer.SetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003ADD8 File Offset: 0x00038FD8
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00007799 File Offset: 0x00005999
		public bool staticShadowCaster
		{
			get
			{
				return this.GetIsStaticShadowCaster();
			}
			set
			{
				this.SetIsStaticShadowCaster(value);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000077A4 File Offset: 0x000059A4
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000077B6 File Offset: 0x000059B6
		public MotionVectorGenerationMode motionVectorGenerationMode
		{
			get
			{
				return Renderer.get_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000077FF File Offset: 0x000059FF
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00007811 File Offset: 0x00005A11
		public int rendererPriority
		{
			get
			{
				return Renderer.get_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00007824 File Offset: 0x00005A24
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00007836 File Offset: 0x00005A36
		public UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		{
			get
			{
				return Renderer.get_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00007849 File Offset: 0x00005A49
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Renderer.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Renderer.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00007861 File Offset: 0x00005A61
		public uint sortingKey
		{
			get
			{
				return Renderer.get_sortingKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00007899 File Offset: 0x00005A99
		public uint sortingGroupKey
		{
			get
			{
				return Renderer.get_sortingGroupKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003AE14 File Offset: 0x00039014
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000078BD File Offset: 0x00005ABD
		public Transform staticBatchRootTransform
		{
			get
			{
				IntPtr intPtr = Renderer.get_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000078D5 File Offset: 0x00005AD5
		public int staticBatchIndex
		{
			get
			{
				return Renderer.get_staticBatchIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000078E7 File Offset: 0x00005AE7
		public void SetStaticBatchInfo(int firstSubMesh, int subMeshCount)
		{
			Renderer.SetStaticBatchInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), firstSubMesh, subMeshCount);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0003AE40 File Offset: 0x00039040
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_worldToLocalMatrix_Injected(out result);
				return result;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0003AE58 File Offset: 0x00039058
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000078FB File Offset: 0x00005AFB
		public GameObject lightProbeProxyVolumeOverride
		{
			get
			{
				IntPtr intPtr = Renderer.get_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				Renderer.set_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00007913 File Offset: 0x00005B13
		public void SetLightmapIndex(int index, UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, lt);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00007927 File Offset: 0x00005B27
		public void SetLightmapST(Vector4 st, UnityEngineInternal.LightmapType lt)
		{
			this.SetLightmapST_Injected(ref st, lt);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0003AEB0 File Offset: 0x000390B0
		public void SetSharedMaterials(List<Material> materials)
		{
			bool flag = materials == null;
			if (flag)
			{
				throw new ArgumentNullException("The material list to set cannot be null.", "materials");
			}
			this.SetMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(materials), materials.Count);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00007961 File Offset: 0x00005B61
		public void set_bounds_Injected(ref Bounds value)
		{
			Renderer.set_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00007974 File Offset: 0x00005B74
		public void set_localBounds_Injected(ref Bounds value)
		{
			Renderer.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00007987 File Offset: 0x00005B87
		public void SetStaticLightmapST_Injected(ref Vector4 st)
		{
			Renderer.SetStaticLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0000799A File Offset: 0x00005B9A
		public void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_worldToLocalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000079AD File Offset: 0x00005BAD
		public void SetLightmapST_Injected(ref Vector4 st, UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st, lt);
		}

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_CopySharedMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_set_allowOcclusionWhenDynamic_Public_set_Void_Boolean_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_GetLightmapST_Private_Vector4_LightmapType_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeLightmapIndex_Public_get_Int32_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapScaleOffset_Public_get_Vector4_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeLightmapScaleOffset_Public_get_Vector4_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterials_Public_Void_List_1_Material_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Public_Void_List_1_Material_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_get_localBounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_GetLightmapST_Injected_Private_Void_LightmapType_byref_Vector4_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly Renderer.ResetBoundsDelegate ResetBoundsDelegateField;

		// Token: 0x040008F1 RID: 2289
		private static readonly Renderer.ResetLocalBoundsDelegate ResetLocalBoundsDelegateField;

		// Token: 0x040008F2 RID: 2290
		private static readonly Renderer.Internal_SetPropertyBlockMaterialIndexDelegate Internal_SetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040008F3 RID: 2291
		private static readonly Renderer.Internal_GetPropertyBlockMaterialIndexDelegate Internal_GetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040008F4 RID: 2292
		private static readonly Renderer.HasPropertyBlockDelegate HasPropertyBlockDelegateField;

		// Token: 0x040008F5 RID: 2293
		private static readonly Renderer.GetClosestReflectionProbesInternalDelegate GetClosestReflectionProbesInternalDelegateField;

		// Token: 0x040008F6 RID: 2294
		private static readonly Renderer.get_receiveShadowsDelegate get_receiveShadowsDelegateField;

		// Token: 0x040008F7 RID: 2295
		private static readonly Renderer.get_forceRenderingOffDelegate get_forceRenderingOffDelegateField;

		// Token: 0x040008F8 RID: 2296
		private static readonly Renderer.set_forceRenderingOffDelegate set_forceRenderingOffDelegateField;

		// Token: 0x040008F9 RID: 2297
		private static readonly Renderer.GetIsStaticShadowCasterDelegate GetIsStaticShadowCasterDelegateField;

		// Token: 0x040008FA RID: 2298
		private static readonly Renderer.SetIsStaticShadowCasterDelegate SetIsStaticShadowCasterDelegateField;

		// Token: 0x040008FB RID: 2299
		private static readonly Renderer.get_motionVectorGenerationModeDelegate get_motionVectorGenerationModeDelegateField;

		// Token: 0x040008FC RID: 2300
		private static readonly Renderer.set_motionVectorGenerationModeDelegate set_motionVectorGenerationModeDelegateField;

		// Token: 0x040008FD RID: 2301
		private static readonly Renderer.get_lightProbeUsageDelegate get_lightProbeUsageDelegateField;

		// Token: 0x040008FE RID: 2302
		private static readonly Renderer.get_reflectionProbeUsageDelegate get_reflectionProbeUsageDelegateField;

		// Token: 0x040008FF RID: 2303
		private static readonly Renderer.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x04000900 RID: 2304
		private static readonly Renderer.get_rendererPriorityDelegate get_rendererPriorityDelegateField;

		// Token: 0x04000901 RID: 2305
		private static readonly Renderer.set_rendererPriorityDelegate set_rendererPriorityDelegateField;

		// Token: 0x04000902 RID: 2306
		private static readonly Renderer.get_rayTracingModeDelegate get_rayTracingModeDelegateField;

		// Token: 0x04000903 RID: 2307
		private static readonly Renderer.set_rayTracingModeDelegate set_rayTracingModeDelegateField;

		// Token: 0x04000904 RID: 2308
		private static readonly Renderer.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x04000905 RID: 2309
		private static readonly Renderer.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x04000906 RID: 2310
		private static readonly Renderer.get_sortingKeyDelegate get_sortingKeyDelegateField;

		// Token: 0x04000907 RID: 2311
		private static readonly Renderer.set_sortingGroupIDDelegate set_sortingGroupIDDelegateField;

		// Token: 0x04000908 RID: 2312
		private static readonly Renderer.set_sortingGroupOrderDelegate set_sortingGroupOrderDelegateField;

		// Token: 0x04000909 RID: 2313
		private static readonly Renderer.get_sortingGroupKeyDelegate get_sortingGroupKeyDelegateField;

		// Token: 0x0400090A RID: 2314
		private static readonly Renderer.get_allowOcclusionWhenDynamicDelegate get_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x0400090B RID: 2315
		private static readonly Renderer.get_staticBatchRootTransformDelegate get_staticBatchRootTransformDelegateField;

		// Token: 0x0400090C RID: 2316
		private static readonly Renderer.set_staticBatchRootTransformDelegate set_staticBatchRootTransformDelegateField;

		// Token: 0x0400090D RID: 2317
		private static readonly Renderer.get_staticBatchIndexDelegate get_staticBatchIndexDelegateField;

		// Token: 0x0400090E RID: 2318
		private static readonly Renderer.SetStaticBatchInfoDelegate SetStaticBatchInfoDelegateField;

		// Token: 0x0400090F RID: 2319
		private static readonly Renderer.get_lightProbeProxyVolumeOverrideDelegate get_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x04000910 RID: 2320
		private static readonly Renderer.set_lightProbeProxyVolumeOverrideDelegate set_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x04000911 RID: 2321
		private static readonly Renderer.get_probeAnchorDelegate get_probeAnchorDelegateField;

		// Token: 0x04000912 RID: 2322
		private static readonly Renderer.SetLightmapIndexDelegate SetLightmapIndexDelegateField;

		// Token: 0x04000913 RID: 2323
		private static readonly Renderer.set_bounds_InjectedDelegate set_bounds_InjectedDelegateField;

		// Token: 0x04000914 RID: 2324
		private static readonly Renderer.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField;

		// Token: 0x04000915 RID: 2325
		private static readonly Renderer.SetStaticLightmapST_InjectedDelegate SetStaticLightmapST_InjectedDelegateField;

		// Token: 0x04000916 RID: 2326
		private static readonly Renderer.get_worldToLocalMatrix_InjectedDelegate get_worldToLocalMatrix_InjectedDelegateField;

		// Token: 0x04000917 RID: 2327
		private static readonly Renderer.SetLightmapST_InjectedDelegate SetLightmapST_InjectedDelegateField;

		// Token: 0x02000646 RID: 1606
		// (Invoke) Token: 0x06003546 RID: 13638
		private delegate void ResetBoundsDelegate(IntPtr @this);

		// Token: 0x02000647 RID: 1607
		// (Invoke) Token: 0x06003548 RID: 13640
		private delegate void ResetLocalBoundsDelegate(IntPtr @this);

		// Token: 0x02000648 RID: 1608
		// (Invoke) Token: 0x0600354A RID: 13642
		private delegate void Internal_SetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr properties, int materialIndex);

		// Token: 0x02000649 RID: 1609
		// (Invoke) Token: 0x0600354C RID: 13644
		private delegate void Internal_GetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr dest, int materialIndex);

		// Token: 0x0200064A RID: 1610
		// (Invoke) Token: 0x0600354E RID: 13646
		private delegate bool HasPropertyBlockDelegate(IntPtr @this);

		// Token: 0x0200064B RID: 1611
		// (Invoke) Token: 0x06003550 RID: 13648
		private delegate void GetClosestReflectionProbesInternalDelegate(IntPtr @this, IntPtr result);

		// Token: 0x0200064C RID: 1612
		// (Invoke) Token: 0x06003552 RID: 13650
		private delegate bool get_receiveShadowsDelegate(IntPtr @this);

		// Token: 0x0200064D RID: 1613
		// (Invoke) Token: 0x06003554 RID: 13652
		private delegate bool get_forceRenderingOffDelegate(IntPtr @this);

		// Token: 0x0200064E RID: 1614
		// (Invoke) Token: 0x06003556 RID: 13654
		private delegate void set_forceRenderingOffDelegate(IntPtr @this, bool value);

		// Token: 0x0200064F RID: 1615
		// (Invoke) Token: 0x06003558 RID: 13656
		private delegate bool GetIsStaticShadowCasterDelegate(IntPtr @this);

		// Token: 0x02000650 RID: 1616
		// (Invoke) Token: 0x0600355A RID: 13658
		private delegate void SetIsStaticShadowCasterDelegate(IntPtr @this, bool value);

		// Token: 0x02000651 RID: 1617
		// (Invoke) Token: 0x0600355C RID: 13660
		private delegate MotionVectorGenerationMode get_motionVectorGenerationModeDelegate(IntPtr @this);

		// Token: 0x02000652 RID: 1618
		// (Invoke) Token: 0x0600355E RID: 13662
		private delegate void set_motionVectorGenerationModeDelegate(IntPtr @this, MotionVectorGenerationMode value);

		// Token: 0x02000653 RID: 1619
		// (Invoke) Token: 0x06003560 RID: 13664
		private delegate UnityEngine.Rendering.LightProbeUsage get_lightProbeUsageDelegate(IntPtr @this);

		// Token: 0x02000654 RID: 1620
		// (Invoke) Token: 0x06003562 RID: 13666
		private delegate UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsageDelegate(IntPtr @this);

		// Token: 0x02000655 RID: 1621
		// (Invoke) Token: 0x06003564 RID: 13668
		private delegate uint get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x02000656 RID: 1622
		// (Invoke) Token: 0x06003566 RID: 13670
		private delegate int get_rendererPriorityDelegate(IntPtr @this);

		// Token: 0x02000657 RID: 1623
		// (Invoke) Token: 0x06003568 RID: 13672
		private delegate void set_rendererPriorityDelegate(IntPtr @this, int value);

		// Token: 0x02000658 RID: 1624
		// (Invoke) Token: 0x0600356A RID: 13674
		private delegate UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingModeDelegate(IntPtr @this);

		// Token: 0x02000659 RID: 1625
		// (Invoke) Token: 0x0600356C RID: 13676
		private delegate void set_rayTracingModeDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.RayTracingMode value);

		// Token: 0x0200065A RID: 1626
		// (Invoke) Token: 0x0600356E RID: 13678
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x0200065B RID: 1627
		// (Invoke) Token: 0x06003570 RID: 13680
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200065C RID: 1628
		// (Invoke) Token: 0x06003572 RID: 13682
		private delegate uint get_sortingKeyDelegate(IntPtr @this);

		// Token: 0x0200065D RID: 1629
		// (Invoke) Token: 0x06003574 RID: 13684
		private delegate void set_sortingGroupIDDelegate(IntPtr @this, int value);

		// Token: 0x0200065E RID: 1630
		// (Invoke) Token: 0x06003576 RID: 13686
		private delegate void set_sortingGroupOrderDelegate(IntPtr @this, int value);

		// Token: 0x0200065F RID: 1631
		// (Invoke) Token: 0x06003578 RID: 13688
		private delegate uint get_sortingGroupKeyDelegate(IntPtr @this);

		// Token: 0x02000660 RID: 1632
		// (Invoke) Token: 0x0600357A RID: 13690
		private delegate bool get_allowOcclusionWhenDynamicDelegate(IntPtr @this);

		// Token: 0x02000661 RID: 1633
		// (Invoke) Token: 0x0600357C RID: 13692
		private delegate IntPtr get_staticBatchRootTransformDelegate(IntPtr @this);

		// Token: 0x02000662 RID: 1634
		// (Invoke) Token: 0x0600357E RID: 13694
		private delegate void set_staticBatchRootTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000663 RID: 1635
		// (Invoke) Token: 0x06003580 RID: 13696
		private delegate int get_staticBatchIndexDelegate(IntPtr @this);

		// Token: 0x02000664 RID: 1636
		// (Invoke) Token: 0x06003582 RID: 13698
		private delegate void SetStaticBatchInfoDelegate(IntPtr @this, int firstSubMesh, int subMeshCount);

		// Token: 0x02000665 RID: 1637
		// (Invoke) Token: 0x06003584 RID: 13700
		private delegate IntPtr get_lightProbeProxyVolumeOverrideDelegate(IntPtr @this);

		// Token: 0x02000666 RID: 1638
		// (Invoke) Token: 0x06003586 RID: 13702
		private delegate void set_lightProbeProxyVolumeOverrideDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000667 RID: 1639
		// (Invoke) Token: 0x06003588 RID: 13704
		private delegate IntPtr get_probeAnchorDelegate(IntPtr @this);

		// Token: 0x02000668 RID: 1640
		// (Invoke) Token: 0x0600358A RID: 13706
		private delegate void SetLightmapIndexDelegate(IntPtr @this, int index, UnityEngineInternal.LightmapType lt);

		// Token: 0x02000669 RID: 1641
		// (Invoke) Token: 0x0600358C RID: 13708
		private delegate void set_bounds_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200066A RID: 1642
		// (Invoke) Token: 0x0600358E RID: 13710
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200066B RID: 1643
		// (Invoke) Token: 0x06003590 RID: 13712
		private delegate void SetStaticLightmapST_InjectedDelegate(IntPtr @this, IntPtr st);

		// Token: 0x0200066C RID: 1644
		// (Invoke) Token: 0x06003592 RID: 13714
		private delegate void get_worldToLocalMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200066D RID: 1645
		// (Invoke) Token: 0x06003594 RID: 13716
		private delegate void SetLightmapST_InjectedDelegate(IntPtr @this, IntPtr st, UnityEngineInternal.LightmapType lt);
	}
}
