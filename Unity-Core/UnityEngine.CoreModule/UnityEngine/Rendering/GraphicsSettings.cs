using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000205 RID: 517
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x000891E8 File Offset: 0x000873E8
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667003);
			GraphicsSettings.NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667004);
			GraphicsSettings.NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667005);
			GraphicsSettings.NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667006);
			GraphicsSettings.NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667007);
			GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667008);
			GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667009);
			GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667010);
			GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667011);
			GraphicsSettings.NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667012);
			GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667013);
			GraphicsSettings.NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667014);
			GraphicsSettings.NativeMethodInfoPtr_GetAllConfiguredRenderPipelines_Private_Static_Il2CppReferenceArray_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667015);
			GraphicsSettings.NativeMethodInfoPtr_get_allConfiguredRenderPipelines_Public_Static_get_Il2CppReferenceArray_1_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667016);
			GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667017);
			GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667018);
			GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667019);
			GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667020);
			GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667021);
			GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667022);
			GraphicsSettings.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
			GraphicsSettings.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
			GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
			GraphicsSettings.get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
			GraphicsSettings.get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
			GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
			GraphicsSettings.get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
			GraphicsSettings.set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
			GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
			GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightProbeOutsideHullStrategy");
			GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightProbeOutsideHullStrategy");
			GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.GetGraphicsSettingsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetGraphicsSettingsDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings");
			GraphicsSettings.SetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
			GraphicsSettings.GetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::GetShaderMode");
			GraphicsSettings.SetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader");
			GraphicsSettings.GetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader");
			GraphicsSettings.get_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeLightCulling");
			GraphicsSettings.set_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeLightCulling");
			GraphicsSettings.get_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeShadowCulling");
			GraphicsSettings.set_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeShadowCulling");
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00089530 File Offset: 0x00087730
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x00089560 File Offset: 0x00087760
		public unsafe static bool lightsUseLinearIntensity
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1287958, RefRangeEnd = 1287965, XrefRangeStart = 1287956, XrefRangeEnd = 1287958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287967, RefRangeEnd = 1287968, XrefRangeStart = 1287965, XrefRangeEnd = 1287967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0000F745 File Offset: 0x0000D945
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00089594 File Offset: 0x00087794
		public unsafe static bool lightsUseColorTemperature
		{
			get
			{
				return GraphicsSettings.get_lightsUseColorTemperatureDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287970, RefRangeEnd = 1287971, XrefRangeStart = 1287968, XrefRangeEnd = 1287970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0000F751 File Offset: 0x0000D951
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x000895C8 File Offset: 0x000877C8
		public unsafe static uint defaultRenderingLayerMask
		{
			get
			{
				return GraphicsSettings.get_defaultRenderingLayerMaskDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287973, RefRangeEnd = 1287974, XrefRangeStart = 1287971, XrefRangeEnd = 1287973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0000F75D File Offset: 0x0000D95D
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x000895FC File Offset: 0x000877FC
		public unsafe static bool useScriptableRenderPipelineBatching
		{
			get
			{
				return GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287976, RefRangeEnd = 1287977, XrefRangeStart = 1287974, XrefRangeEnd = 1287976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00089630 File Offset: 0x00087830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287977, XrefRangeEnd = 1287979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defineHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0008967C File Offset: 0x0008787C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1287985, RefRangeEnd = 1287990, XrefRangeStart = 1287979, XrefRangeEnd = 1287985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref defineHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000896BC File Offset: 0x000878BC
		public unsafe static ScriptableObject INTERNAL_currentRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287990, XrefRangeEnd = 1287992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000896F0 File Offset: 0x000878F0
		public unsafe static RenderPipelineAsset currentRenderPipeline
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1287996, RefRangeEnd = 1288002, XrefRangeStart = 1287992, XrefRangeEnd = 1287996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00089724 File Offset: 0x00087924
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		public unsafe static RenderPipelineAsset renderPipelineAsset
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1288006, RefRangeEnd = 1288012, XrefRangeStart = 1288002, XrefRangeEnd = 1288006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.defaultRenderPipeline = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00089758 File Offset: 0x00087958
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x0000F7CA File Offset: 0x0000D9CA
		public unsafe static ScriptableObject INTERNAL_defaultRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288012, XrefRangeEnd = 1288014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0008978C File Offset: 0x0008798C
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		public unsafe static RenderPipelineAsset defaultRenderPipeline
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1288006, RefRangeEnd = 1288012, XrefRangeStart = 1288006, XrefRangeEnd = 1288012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.INTERNAL_defaultRenderPipeline = value;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000897C0 File Offset: 0x000879C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288014, XrefRangeEnd = 1288016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetAllConfiguredRenderPipelines_Private_Static_Il2CppReferenceArray_1_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr3) : null;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000897F4 File Offset: 0x000879F4
		public unsafe static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1288024, RefRangeEnd = 1288042, XrefRangeStart = 1288016, XrefRangeEnd = 1288024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_allConfiguredRenderPipelines_Public_Static_get_Il2CppReferenceArray_1_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderPipelineAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00089828 File Offset: 0x00087A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1288049, RefRangeEnd = 1288050, XrefRangeStart = 1288042, XrefRangeEnd = 1288049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00089860 File Offset: 0x00087A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1288052, RefRangeEnd = 1288053, XrefRangeStart = 1288050, XrefRangeEnd = 1288052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRenderPipeline(string renderpipelineName, Object settings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000898A8 File Offset: 0x00087AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1288060, RefRangeEnd = 1288061, XrefRangeStart = 1288053, XrefRangeEnd = 1288060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_UnregisterRenderPipelineSettings_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000898D0 File Offset: 0x00087AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1288063, RefRangeEnd = 1288064, XrefRangeStart = 1288061, XrefRangeEnd = 1288063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRenderPipeline(string renderpipelineName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00089908 File Offset: 0x00087B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1288072, RefRangeEnd = 1288074, XrefRangeStart = 1288064, XrefRangeEnd = 1288072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr3) : null;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0008993C File Offset: 0x00087B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1288076, RefRangeEnd = 1288077, XrefRangeStart = 1288074, XrefRangeEnd = 1288076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetSettingsForRenderPipeline(string renderpipelineName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0000F701 File Offset: 0x0000D901
		public GraphicsSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x0000F70A File Offset: 0x0000D90A
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0000F716 File Offset: 0x0000D916
		public static TransparencySortMode transparencySortMode
		{
			get
			{
				return GraphicsSettings.get_transparencySortModeDelegateField();
			}
			set
			{
				GraphicsSettings.set_transparencySortModeDelegateField(value);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00089980 File Offset: 0x00087B80
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0000F723 File Offset: 0x0000D923
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 result;
				GraphicsSettings.get_transparencySortAxis_Injected(out result);
				return result;
			}
			set
			{
				GraphicsSettings.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0000F72C File Offset: 0x0000D92C
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0000F738 File Offset: 0x0000D938
		public static bool realtimeDirectRectangularAreaLights
		{
			get
			{
				return GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField();
			}
			set
			{
				GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField(value);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0000F769 File Offset: 0x0000D969
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0000F775 File Offset: 0x0000D975
		public static bool logWhenShaderIsCompiled
		{
			get
			{
				return GraphicsSettings.get_logWhenShaderIsCompiledDelegateField();
			}
			set
			{
				GraphicsSettings.set_logWhenShaderIsCompiledDelegateField(value);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0000F782 File Offset: 0x0000D982
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0000F78E File Offset: 0x0000D98E
		public static bool disableBuiltinCustomRenderTextureUpdate
		{
			get
			{
				return GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField();
			}
			set
			{
				GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0000F79B File Offset: 0x0000D99B
		public static VideoShadersIncludeMode videoShadersIncludeMode
		{
			get
			{
				return GraphicsSettings.get_videoShadersIncludeModeDelegateField();
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0000F7A7 File Offset: 0x0000D9A7
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x0000F7B3 File Offset: 0x0000D9B3
		public static LightProbeOutsideHullStrategy lightProbeOutsideHullStrategy
		{
			get
			{
				return GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField();
			}
			set
			{
				GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField(value);
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00089998 File Offset: 0x00087B98
		public static Object GetGraphicsSettings()
		{
			IntPtr intPtr = GraphicsSettings.GetGraphicsSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000F7E6 File Offset: 0x0000D9E6
		public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
		{
			GraphicsSettings.SetShaderModeDelegateField(type, mode);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
		{
			return GraphicsSettings.GetShaderModeDelegateField(type);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0000F801 File Offset: 0x0000DA01
		public static void SetCustomShader(BuiltinShaderType type, Shader shader)
		{
			GraphicsSettings.SetCustomShaderDelegateField(type, IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000899C0 File Offset: 0x00087BC0
		public static Shader GetCustomShader(BuiltinShaderType type)
		{
			IntPtr intPtr = GraphicsSettings.GetCustomShaderDelegateField(type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0000F814 File Offset: 0x0000DA14
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0000F820 File Offset: 0x0000DA20
		public static bool cameraRelativeLightCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeLightCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeLightCullingDelegateField(value);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0000F82D File Offset: 0x0000DA2D
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0000F839 File Offset: 0x0000DA39
		public static bool cameraRelativeShadowCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeShadowCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeShadowCullingDelegateField(value);
			}
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0000F846 File Offset: 0x0000DA46
		public static void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField(out ret);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0000F853 File Offset: 0x0000DA53
		public static void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField(ref value);
		}

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_GetAllConfiguredRenderPipelines_Private_Static_Il2CppReferenceArray_1_ScriptableObject_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_get_allConfiguredRenderPipelines_Public_Static_get_Il2CppReferenceArray_1_RenderPipelineAsset_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly GraphicsSettings.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x04001CB9 RID: 7353
		private static readonly GraphicsSettings.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x04001CBA RID: 7354
		private static readonly GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001CBB RID: 7355
		private static readonly GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001CBC RID: 7356
		private static readonly GraphicsSettings.get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;

		// Token: 0x04001CBD RID: 7357
		private static readonly GraphicsSettings.get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;

		// Token: 0x04001CBE RID: 7358
		private static readonly GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x04001CBF RID: 7359
		private static readonly GraphicsSettings.get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;

		// Token: 0x04001CC0 RID: 7360
		private static readonly GraphicsSettings.set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;

		// Token: 0x04001CC1 RID: 7361
		private static readonly GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x04001CC2 RID: 7362
		private static readonly GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x04001CC3 RID: 7363
		private static readonly GraphicsSettings.get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;

		// Token: 0x04001CC4 RID: 7364
		private static readonly GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate get_lightProbeOutsideHullStrategyDelegateField;

		// Token: 0x04001CC5 RID: 7365
		private static readonly GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate set_lightProbeOutsideHullStrategyDelegateField;

		// Token: 0x04001CC6 RID: 7366
		private static readonly GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate set_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x04001CC7 RID: 7367
		private static readonly GraphicsSettings.GetGraphicsSettingsDelegate GetGraphicsSettingsDelegateField;

		// Token: 0x04001CC8 RID: 7368
		private static readonly GraphicsSettings.SetShaderModeDelegate SetShaderModeDelegateField;

		// Token: 0x04001CC9 RID: 7369
		private static readonly GraphicsSettings.GetShaderModeDelegate GetShaderModeDelegateField;

		// Token: 0x04001CCA RID: 7370
		private static readonly GraphicsSettings.SetCustomShaderDelegate SetCustomShaderDelegateField;

		// Token: 0x04001CCB RID: 7371
		private static readonly GraphicsSettings.GetCustomShaderDelegate GetCustomShaderDelegateField;

		// Token: 0x04001CCC RID: 7372
		private static readonly GraphicsSettings.get_cameraRelativeLightCullingDelegate get_cameraRelativeLightCullingDelegateField;

		// Token: 0x04001CCD RID: 7373
		private static readonly GraphicsSettings.set_cameraRelativeLightCullingDelegate set_cameraRelativeLightCullingDelegateField;

		// Token: 0x04001CCE RID: 7374
		private static readonly GraphicsSettings.get_cameraRelativeShadowCullingDelegate get_cameraRelativeShadowCullingDelegateField;

		// Token: 0x04001CCF RID: 7375
		private static readonly GraphicsSettings.set_cameraRelativeShadowCullingDelegate set_cameraRelativeShadowCullingDelegateField;

		// Token: 0x04001CD0 RID: 7376
		private static readonly GraphicsSettings.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04001CD1 RID: 7377
		private static readonly GraphicsSettings.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x02000AD3 RID: 2771
		private sealed class MethodInfoStoreGeneric_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0<T>
		{
			// Token: 0x04002BC8 RID: 11208
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AD4 RID: 2772
		private sealed class MethodInfoStoreGeneric_UnregisterRenderPipelineSettings_Public_Static_Void_0<T>
		{
			// Token: 0x04002BC9 RID: 11209
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AD5 RID: 2773
		private sealed class MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>
		{
			// Token: 0x04002BCA RID: 11210
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AD6 RID: 2774
		// (Invoke) Token: 0x06003E92 RID: 16018
		private delegate TransparencySortMode get_transparencySortModeDelegate();

		// Token: 0x02000AD7 RID: 2775
		// (Invoke) Token: 0x06003E94 RID: 16020
		private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

		// Token: 0x02000AD8 RID: 2776
		// (Invoke) Token: 0x06003E96 RID: 16022
		private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

		// Token: 0x02000AD9 RID: 2777
		// (Invoke) Token: 0x06003E98 RID: 16024
		private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

		// Token: 0x02000ADA RID: 2778
		// (Invoke) Token: 0x06003E9A RID: 16026
		private delegate bool get_lightsUseColorTemperatureDelegate();

		// Token: 0x02000ADB RID: 2779
		// (Invoke) Token: 0x06003E9C RID: 16028
		private delegate uint get_defaultRenderingLayerMaskDelegate();

		// Token: 0x02000ADC RID: 2780
		// (Invoke) Token: 0x06003E9E RID: 16030
		private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

		// Token: 0x02000ADD RID: 2781
		// (Invoke) Token: 0x06003EA0 RID: 16032
		private delegate bool get_logWhenShaderIsCompiledDelegate();

		// Token: 0x02000ADE RID: 2782
		// (Invoke) Token: 0x06003EA2 RID: 16034
		private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

		// Token: 0x02000ADF RID: 2783
		// (Invoke) Token: 0x06003EA4 RID: 16036
		private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

		// Token: 0x02000AE0 RID: 2784
		// (Invoke) Token: 0x06003EA6 RID: 16038
		private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

		// Token: 0x02000AE1 RID: 2785
		// (Invoke) Token: 0x06003EA8 RID: 16040
		private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

		// Token: 0x02000AE2 RID: 2786
		// (Invoke) Token: 0x06003EAA RID: 16042
		private delegate LightProbeOutsideHullStrategy get_lightProbeOutsideHullStrategyDelegate();

		// Token: 0x02000AE3 RID: 2787
		// (Invoke) Token: 0x06003EAC RID: 16044
		private delegate void set_lightProbeOutsideHullStrategyDelegate(LightProbeOutsideHullStrategy value);

		// Token: 0x02000AE4 RID: 2788
		// (Invoke) Token: 0x06003EAE RID: 16046
		private delegate void set_INTERNAL_defaultRenderPipelineDelegate(IntPtr value);

		// Token: 0x02000AE5 RID: 2789
		// (Invoke) Token: 0x06003EB0 RID: 16048
		private delegate IntPtr GetGraphicsSettingsDelegate();

		// Token: 0x02000AE6 RID: 2790
		// (Invoke) Token: 0x06003EB2 RID: 16050
		private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x02000AE7 RID: 2791
		// (Invoke) Token: 0x06003EB4 RID: 16052
		private delegate BuiltinShaderMode GetShaderModeDelegate(BuiltinShaderType type);

		// Token: 0x02000AE8 RID: 2792
		// (Invoke) Token: 0x06003EB6 RID: 16054
		private delegate void SetCustomShaderDelegate(BuiltinShaderType type, IntPtr shader);

		// Token: 0x02000AE9 RID: 2793
		// (Invoke) Token: 0x06003EB8 RID: 16056
		private delegate IntPtr GetCustomShaderDelegate(BuiltinShaderType type);

		// Token: 0x02000AEA RID: 2794
		// (Invoke) Token: 0x06003EBA RID: 16058
		private delegate bool get_cameraRelativeLightCullingDelegate();

		// Token: 0x02000AEB RID: 2795
		// (Invoke) Token: 0x06003EBC RID: 16060
		private delegate void set_cameraRelativeLightCullingDelegate(bool value);

		// Token: 0x02000AEC RID: 2796
		// (Invoke) Token: 0x06003EBE RID: 16062
		private delegate bool get_cameraRelativeShadowCullingDelegate();

		// Token: 0x02000AED RID: 2797
		// (Invoke) Token: 0x06003EC0 RID: 16064
		private delegate void set_cameraRelativeShadowCullingDelegate(bool value);

		// Token: 0x02000AEE RID: 2798
		// (Invoke) Token: 0x06003EC2 RID: 16066
		private delegate void get_transparencySortAxis_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000AEF RID: 2799
		// (Invoke) Token: 0x06003EC4 RID: 16068
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr value);
	}
}
