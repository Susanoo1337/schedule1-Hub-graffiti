using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000230 RID: 560
	public class RenderPipelineAsset : ScriptableObject
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x00097108 File Offset: 0x00095308
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineAsset()
		{
			Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr);
			RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667359);
			RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667360);
			RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667361);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667362);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667363);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667364);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667365);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667366);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667367);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667368);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667369);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667370);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667371);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667372);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667373);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667374);
			RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667375);
			RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667376);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667377);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667378);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667379);
			RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667380);
			RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667381);
			RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667382);
			RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667383);
			RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100667384);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00097340 File Offset: 0x00095540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290785, RefRangeEnd = 1290786, XrefRangeStart = 1290769, XrefRangeEnd = 1290785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipeline InternalCreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x00097380 File Offset: 0x00095580
		public unsafe virtual Il2CppStringArray renderingLayerMaskNames
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000973CC File Offset: 0x000955CC
		public unsafe virtual Il2CppStringArray prefixedRenderingLayerMaskNames
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00097418 File Offset: 0x00095618
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00097464 File Offset: 0x00095664
		public unsafe virtual Shader autodeskInteractiveShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000974B0 File Offset: 0x000956B0
		public unsafe virtual Shader autodeskInteractiveTransparentShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000974FC File Offset: 0x000956FC
		public unsafe virtual Shader autodeskInteractiveMaskedShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00097548 File Offset: 0x00095748
		public unsafe virtual Shader terrainDetailLitShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00097594 File Offset: 0x00095794
		public unsafe virtual Shader terrainDetailGrassShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000975E0 File Offset: 0x000957E0
		public unsafe virtual Shader terrainDetailGrassBillboardShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0009762C File Offset: 0x0009582C
		public unsafe virtual Material defaultParticleMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x00097678 File Offset: 0x00095878
		public unsafe virtual Material defaultLineMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x000976C4 File Offset: 0x000958C4
		public unsafe virtual Material defaultTerrainMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x00097710 File Offset: 0x00095910
		public unsafe virtual Material defaultUIMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x0009775C File Offset: 0x0009595C
		public unsafe virtual Material defaultUIOverdrawMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000977A8 File Offset: 0x000959A8
		public unsafe virtual Material defaultUIETC1SupportedMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x000977F4 File Offset: 0x000959F4
		public unsafe virtual Material default2DMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x00097840 File Offset: 0x00095A40
		public unsafe virtual Material default2DMaskMaterial
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x0009788C File Offset: 0x00095A8C
		public unsafe virtual Shader defaultShader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000978D8 File Offset: 0x00095AD8
		public unsafe virtual Shader defaultSpeedTree7Shader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x00097924 File Offset: 0x00095B24
		public unsafe virtual Shader defaultSpeedTree8Shader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00097970 File Offset: 0x00095B70
		public unsafe virtual string renderPipelineShaderTag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290786, XrefRangeEnd = 1290794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000979B4 File Offset: 0x00095BB4
		[CallerCount(0)]
		public unsafe virtual RenderPipeline CreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00097A00 File Offset: 0x00095C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290794, XrefRangeEnd = 1290806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00097A3C File Offset: 0x00095C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290810, RefRangeEnd = 1290811, XrefRangeStart = 1290806, XrefRangeEnd = 1290810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00097A78 File Offset: 0x00095C78
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00011529 File Offset: 0x0000F729
		public RenderPipelineAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
