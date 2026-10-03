using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000240 RID: 576
	public class SupportedRenderingFeatures : Object
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x0009C888 File Offset: 0x0009AA88
		// Note: this type is marked as 'beforefieldinit'.
		static SupportedRenderingFeatures()
		{
			Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SupportedRenderingFeatures");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
			SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "s_Active");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlightenLightmapper>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbesBlendDistance>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnableLODCrossFade>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoAmbientProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoDefaultReflectionProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystem>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsHDR>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystemWarningMessage>k__BackingField");
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667571);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667572);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667573);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667574);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667575);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667576);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667577);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667578);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667579);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667580);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667581);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667582);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667583);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667584);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667585);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667586);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667587);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667588);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667589);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667590);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667591);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667592);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667593);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667594);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667595);
			SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667596);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667597);
			SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100667598);
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x0009CD54 File Offset: 0x0009AF54
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x0009CD88 File Offset: 0x0009AF88
		public unsafe static SupportedRenderingFeatures active
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 1292025, RefRangeEnd = 1292052, XrefRangeStart = 1292011, XrefRangeEnd = 1292025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1292058, RefRangeEnd = 1292060, XrefRangeStart = 1292052, XrefRangeEnd = 1292058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0009CDC0 File Offset: 0x0009AFC0
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x00011E44 File Offset: 0x00010044
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._defaultMixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x0009CDFC File Offset: 0x0009AFFC
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00011E4D File Offset: 0x0001004D
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._mixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x0009CE38 File Offset: 0x0009B038
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x00011E56 File Offset: 0x00010056
		public unsafe LightmapBakeType lightmapBakeTypes
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapBakeTypes_k__BackingField = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0009CE74 File Offset: 0x0009B074
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x00011E5F File Offset: 0x0001005F
		public unsafe LightmapsMode lightmapsModes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapsModes_k__BackingField = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x0009CEB0 File Offset: 0x0009B0B0
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x00011E68 File Offset: 0x00010068
		public unsafe bool enlightenLightmapper
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlightenLightmapper_k__BackingField = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x0009CEEC File Offset: 0x0009B0EC
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x00011E71 File Offset: 0x00010071
		public unsafe bool enlighten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlighten_k__BackingField = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00011E8B File Offset: 0x0001008B
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x0009CF28 File Offset: 0x0009B128
		public unsafe bool motionVectors
		{
			get
			{
				return this._motionVectors_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x0009CF68 File Offset: 0x0009B168
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
		public unsafe bool rendersUIOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x00011F81 File Offset: 0x00010181
		public unsafe bool autoAmbientProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoAmbientProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x0009D020 File Offset: 0x0009B220
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x00011F8A File Offset: 0x0001018A
		public unsafe bool autoDefaultReflectionProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoDefaultReflectionProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x0009D05C File Offset: 0x0009B25C
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00011FA4 File Offset: 0x000101A4
		public unsafe bool overridesLightProbeSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._overridesLightProbeSystem_k__BackingField = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x00011FAD File Offset: 0x000101AD
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x0009D098 File Offset: 0x0009B298
		public unsafe bool supportsHDR
		{
			get
			{
				return this._supportsHDR_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0009D0D8 File Offset: 0x0009B2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292060, XrefRangeEnd = 1292073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallbackModePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x0009D10C File Offset: 0x0009B30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292073, XrefRangeEnd = 1292094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mixedMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x0009D14C File Offset: 0x0009B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292094, XrefRangeEnd = 1292102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mixedMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0009D18C File Offset: 0x0009B38C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292119, RefRangeEnd = 1292123, XrefRangeStart = 1292102, XrefRangeEnd = 1292119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bakeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292123, XrefRangeEnd = 1292137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bakeType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0009D20C File Offset: 0x0009B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292137, XrefRangeEnd = 1292142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0009D24C File Offset: 0x0009B44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292142, XrefRangeEnd = 1292144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lightmapper;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x0009D28C File Offset: 0x0009B48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292144, XrefRangeEnd = 1292149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x0009D2C0 File Offset: 0x0009B4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292149, XrefRangeEnd = 1292154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x0009D2F4 File Offset: 0x0009B4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292154, XrefRangeEnd = 1292159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0009D328 File Offset: 0x0009B528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292159, XrefRangeEnd = 1292164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OverridesLightProbeSystem(IntPtr overridesPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overridesPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x0009D35C File Offset: 0x0009B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292164, XrefRangeEnd = 1292165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lightmapperPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0009D390 File Offset: 0x0009B590
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1292170, RefRangeEnd = 1292173, XrefRangeStart = 1292165, XrefRangeEnd = 1292170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupportedRenderingFeatures() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00011AEA File Offset: 0x0000FCEA
		public SupportedRenderingFeatures(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0009D3CC File Offset: 0x0009B5CC
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x00011AF3 File Offset: 0x0000FCF3
		public unsafe static SupportedRenderingFeatures s_Active
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x0009D3F4 File Offset: 0x0009B5F4
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00011B05 File Offset: 0x0000FD05
		public unsafe SupportedRenderingFeatures.ReflectionProbeModes _reflectionProbeModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x0009D41C File Offset: 0x0009B61C
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x00011B20 File Offset: 0x0000FD20
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x0009D444 File Offset: 0x0009B644
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x00011B3B File Offset: 0x0000FD3B
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _mixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x0009D46C File Offset: 0x0009B66C
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x00011B56 File Offset: 0x0000FD56
		public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0009D494 File Offset: 0x0009B694
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00011B71 File Offset: 0x0000FD71
		public unsafe LightmapsMode _lightmapsModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x0009D4BC File Offset: 0x0009B6BC
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public unsafe bool _enlightenLightmapper_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlightenLightmapper_k__BackingField)) = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0009D4E4 File Offset: 0x0009B6E4
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x00011BA7 File Offset: 0x0000FDA7
		public unsafe bool _enlighten_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0009D50C File Offset: 0x0009B70C
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x00011BC2 File Offset: 0x0000FDC2
		public unsafe bool _lightProbeProxyVolumes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0009D534 File Offset: 0x0009B734
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00011BDD File Offset: 0x0000FDDD
		public unsafe bool _motionVectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0009D55C File Offset: 0x0009B75C
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public unsafe bool _receiveShadows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0009D584 File Offset: 0x0009B784
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x00011C13 File Offset: 0x0000FE13
		public unsafe bool _reflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x0009D5AC File Offset: 0x0009B7AC
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x00011C2E File Offset: 0x0000FE2E
		public unsafe bool _reflectionProbesBlendDistance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x0009D5D4 File Offset: 0x0009B7D4
		// (set) Token: 0x060027AF RID: 10159 RVA: 0x00011C49 File Offset: 0x0000FE49
		public unsafe bool _rendererPriority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x0009D5FC File Offset: 0x0009B7FC
		// (set) Token: 0x060027B1 RID: 10161 RVA: 0x00011C64 File Offset: 0x0000FE64
		public unsafe bool _rendersUIOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x0009D624 File Offset: 0x0009B824
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x00011C7F File Offset: 0x0000FE7F
		public unsafe bool _overridesEnvironmentLighting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0009D64C File Offset: 0x0009B84C
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00011C9A File Offset: 0x0000FE9A
		public unsafe bool _overridesFog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0009D674 File Offset: 0x0009B874
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x00011CB5 File Offset: 0x0000FEB5
		public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x0009D69C File Offset: 0x0009B89C
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x00011CD0 File Offset: 0x0000FED0
		public unsafe bool _overridesOtherLightingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0009D6C4 File Offset: 0x0009B8C4
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x00011CEB File Offset: 0x0000FEEB
		public unsafe bool _editableMaterialRenderQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0009D6EC File Offset: 0x0009B8EC
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00011D06 File Offset: 0x0000FF06
		public unsafe bool _overridesLODBias_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x0009D714 File Offset: 0x0009B914
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x00011D21 File Offset: 0x0000FF21
		public unsafe bool _overridesMaximumLODLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0009D73C File Offset: 0x0009B93C
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x00011D3C File Offset: 0x0000FF3C
		public unsafe bool _overridesEnableLODCrossFade_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField)) = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0009D764 File Offset: 0x0009B964
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00011D57 File Offset: 0x0000FF57
		public unsafe bool _rendererProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x0009D78C File Offset: 0x0009B98C
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00011D72 File Offset: 0x0000FF72
		public unsafe bool _particleSystemInstancing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0009D7B4 File Offset: 0x0009B9B4
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00011D8D File Offset: 0x0000FF8D
		public unsafe bool _autoAmbientProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0009D7DC File Offset: 0x0009B9DC
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		public unsafe bool _autoDefaultReflectionProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0009D804 File Offset: 0x0009BA04
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x00011DC3 File Offset: 0x0000FFC3
		public unsafe bool _overridesShadowmask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0009D82C File Offset: 0x0009BA2C
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x00011DDE File Offset: 0x0000FFDE
		public unsafe bool _overridesLightProbeSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField)) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x0009D854 File Offset: 0x0009BA54
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x00011DF9 File Offset: 0x0000FFF9
		public unsafe bool _supportsHDR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__supportsHDR_k__BackingField)) = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x0009D87C File Offset: 0x0009BA7C
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00011E14 File Offset: 0x00010014
		public unsafe string _overridesLightProbeSystemWarningMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00011E33 File Offset: 0x00010033
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x00011E3B File Offset: 0x0001003B
		public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes
		{
			get
			{
				return this._reflectionProbeModes_k__BackingField;
			}
			set
			{
				this._reflectionProbeModes_k__BackingField = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00011E7A File Offset: 0x0001007A
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x00011E82 File Offset: 0x00010082
		public bool lightProbeProxyVolumes
		{
			get
			{
				return this._lightProbeProxyVolumes_k__BackingField;
			}
			set
			{
				this._lightProbeProxyVolumes_k__BackingField = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00011E93 File Offset: 0x00010093
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00011E9B File Offset: 0x0001009B
		public bool receiveShadows
		{
			get
			{
				return this._receiveShadows_k__BackingField;
			}
			set
			{
				this._receiveShadows_k__BackingField = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00011EA4 File Offset: 0x000100A4
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00011EAC File Offset: 0x000100AC
		public bool reflectionProbes
		{
			get
			{
				return this._reflectionProbes_k__BackingField;
			}
			set
			{
				this._reflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00011EB5 File Offset: 0x000100B5
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00011EBD File Offset: 0x000100BD
		public bool reflectionProbesBlendDistance
		{
			get
			{
				return this._reflectionProbesBlendDistance_k__BackingField;
			}
			set
			{
				this._reflectionProbesBlendDistance_k__BackingField = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00011EC6 File Offset: 0x000100C6
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00011ECE File Offset: 0x000100CE
		public bool rendererPriority
		{
			get
			{
				return this._rendererPriority_k__BackingField;
			}
			set
			{
				this._rendererPriority_k__BackingField = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x00011ED7 File Offset: 0x000100D7
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x00011EDF File Offset: 0x000100DF
		public bool overridesEnvironmentLighting
		{
			get
			{
				return this._overridesEnvironmentLighting_k__BackingField;
			}
			set
			{
				this._overridesEnvironmentLighting_k__BackingField = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x00011EE8 File Offset: 0x000100E8
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x00011EF0 File Offset: 0x000100F0
		public bool overridesFog
		{
			get
			{
				return this._overridesFog_k__BackingField;
			}
			set
			{
				this._overridesFog_k__BackingField = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x00011EF9 File Offset: 0x000100F9
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x00011F01 File Offset: 0x00010101
		public bool overridesRealtimeReflectionProbes
		{
			get
			{
				return this._overridesRealtimeReflectionProbes_k__BackingField;
			}
			set
			{
				this._overridesRealtimeReflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x00011F0A File Offset: 0x0001010A
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x00011F12 File Offset: 0x00010112
		public bool overridesOtherLightingSettings
		{
			get
			{
				return this._overridesOtherLightingSettings_k__BackingField;
			}
			set
			{
				this._overridesOtherLightingSettings_k__BackingField = value;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x00011F1B File Offset: 0x0001011B
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x00011F23 File Offset: 0x00010123
		public bool editableMaterialRenderQueue
		{
			get
			{
				return this._editableMaterialRenderQueue_k__BackingField;
			}
			set
			{
				this._editableMaterialRenderQueue_k__BackingField = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x00011F2C File Offset: 0x0001012C
		// (set) Token: 0x060027F0 RID: 10224 RVA: 0x00011F34 File Offset: 0x00010134
		public bool overridesLODBias
		{
			get
			{
				return this._overridesLODBias_k__BackingField;
			}
			set
			{
				this._overridesLODBias_k__BackingField = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x00011F3D File Offset: 0x0001013D
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00011F45 File Offset: 0x00010145
		public bool overridesMaximumLODLevel
		{
			get
			{
				return this._overridesMaximumLODLevel_k__BackingField;
			}
			set
			{
				this._overridesMaximumLODLevel_k__BackingField = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00011F4E File Offset: 0x0001014E
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00011F56 File Offset: 0x00010156
		public bool overridesEnableLODCrossFade
		{
			get
			{
				return this._overridesEnableLODCrossFade_k__BackingField;
			}
			set
			{
				this._overridesEnableLODCrossFade_k__BackingField = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x00011F5F File Offset: 0x0001015F
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00011F67 File Offset: 0x00010167
		public bool rendererProbes
		{
			get
			{
				return this._rendererProbes_k__BackingField;
			}
			set
			{
				this._rendererProbes_k__BackingField = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x00011F70 File Offset: 0x00010170
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x00011F78 File Offset: 0x00010178
		public bool particleSystemInstancing
		{
			get
			{
				return this._particleSystemInstancing_k__BackingField;
			}
			set
			{
				this._particleSystemInstancing_k__BackingField = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x00011F93 File Offset: 0x00010193
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x00011F9B File Offset: 0x0001019B
		public bool overridesShadowmask
		{
			get
			{
				return this._overridesShadowmask_k__BackingField;
			}
			set
			{
				this._overridesShadowmask_k__BackingField = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x00011FB5 File Offset: 0x000101B5
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x00011FBD File Offset: 0x000101BD
		public string overridesLightProbeSystemWarningMessage
		{
			get
			{
				return this._overridesLightProbeSystemWarningMessage_k__BackingField;
			}
			set
			{
				this._overridesLightProbeSystemWarningMessage_k__BackingField = value;
			}
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0009D8A4 File Offset: 0x0009BAA4
		public unsafe static MixedLightingMode FallbackMixedLightingMode()
		{
			MixedLightingMode result;
			SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x0009D8C8 File Offset: 0x0009BAC8
		public unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
		{
			bool result;
			SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x0009D8EC File Offset: 0x0009BAEC
		public unsafe static bool IsLightmapperSupported(int lightmapper)
		{
			bool result;
			SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0009D910 File Offset: 0x0009BB10
		public unsafe static int FallbackLightmapper()
		{
			int result;
			SupportedRenderingFeatures.FallbackLightmapperByRef(new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x0009D934 File Offset: 0x0009BB34
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00011FC6 File Offset: 0x000101C6
		public bool terrainDetailUnsupported
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr_s_Active;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeFieldInfoPtr__enlightenLightmapper_k__BackingField;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeFieldInfoPtr__supportsHDR_k__BackingField;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_get_enlightenLightmapper_Public_get_Boolean_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_set_motionVectors_Public_set_Void_Boolean_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B73 RID: 2931
		[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeModes")]
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x04002BE8 RID: 11240
			None = 0,
			// Token: 0x04002BE9 RID: 11241
			Rotation = 1
		}

		// Token: 0x02000B74 RID: 2932
		[OriginalName("UnityEngine.CoreModule.dll", "", "LightmapMixedBakeModes")]
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x04002BEB RID: 11243
			None = 0,
			// Token: 0x04002BEC RID: 11244
			IndirectOnly = 1,
			// Token: 0x04002BED RID: 11245
			Subtractive = 2,
			// Token: 0x04002BEE RID: 11246
			Shadowmask = 4
		}
	}
}
