using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000AF RID: 175
	public sealed class Light : Behaviour
	{
		// Token: 0x06000E21 RID: 3617 RVA: 0x00040F1C File Offset: 0x0003F11C
		// Note: this type is marked as 'beforefieldinit'.
		static Light()
		{
			Il2CppClassPointerStore<Light>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Light");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light>.NativeClassPtr);
			Light.NativeFieldInfoPtr_m_BakedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "m_BakedIndex");
			Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664581);
			Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664582);
			Light.NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664583);
			Light.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664584);
			Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664585);
			Light.NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664586);
			Light.NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664587);
			Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664588);
			Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664589);
			Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664590);
			Light.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664591);
			Light.NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664592);
			Light.NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664593);
			Light.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664594);
			Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664595);
			Light.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664596);
			Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664597);
			Light.NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664598);
			Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664599);
			Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664600);
			Light.NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664601);
			Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664602);
			Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664603);
			Light.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664604);
			Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664605);
			Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664606);
			Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664607);
			Light.set_typeDelegateField = IL2CPP.ResolveICall<Light.set_typeDelegate>("UnityEngine.Light::set_type");
			Light.get_shapeDelegateField = IL2CPP.ResolveICall<Light.get_shapeDelegate>("UnityEngine.Light::get_shape");
			Light.set_shapeDelegateField = IL2CPP.ResolveICall<Light.set_shapeDelegate>("UnityEngine.Light::set_shape");
			Light.set_spotAngleDelegateField = IL2CPP.ResolveICall<Light.set_spotAngleDelegate>("UnityEngine.Light::set_spotAngle");
			Light.set_innerSpotAngleDelegateField = IL2CPP.ResolveICall<Light.set_innerSpotAngleDelegate>("UnityEngine.Light::set_innerSpotAngle");
			Light.set_colorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_colorTemperatureDelegate>("UnityEngine.Light::set_colorTemperature");
			Light.set_useColorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_useColorTemperatureDelegate>("UnityEngine.Light::set_useColorTemperature");
			Light.set_bounceIntensityDelegateField = IL2CPP.ResolveICall<Light.set_bounceIntensityDelegate>("UnityEngine.Light::set_bounceIntensity");
			Light.get_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useBoundingSphereOverrideDelegate>("UnityEngine.Light::get_useBoundingSphereOverride");
			Light.set_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useBoundingSphereOverrideDelegate>("UnityEngine.Light::set_useBoundingSphereOverride");
			Light.get_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.get_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::get_useViewFrustumForShadowCasterCull");
			Light.set_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.set_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::set_useViewFrustumForShadowCasterCull");
			Light.get_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.get_shadowCustomResolutionDelegate>("UnityEngine.Light::get_shadowCustomResolution");
			Light.set_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowCustomResolutionDelegate>("UnityEngine.Light::set_shadowCustomResolution");
			Light.set_shadowBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowBiasDelegate>("UnityEngine.Light::set_shadowBias");
			Light.set_shadowNormalBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowNormalBiasDelegate>("UnityEngine.Light::set_shadowNormalBias");
			Light.set_shadowNearPlaneDelegateField = IL2CPP.ResolveICall<Light.set_shadowNearPlaneDelegate>("UnityEngine.Light::set_shadowNearPlane");
			Light.get_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useShadowMatrixOverrideDelegate>("UnityEngine.Light::get_useShadowMatrixOverride");
			Light.set_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useShadowMatrixOverrideDelegate>("UnityEngine.Light::set_useShadowMatrixOverride");
			Light.set_rangeDelegateField = IL2CPP.ResolveICall<Light.set_rangeDelegate>("UnityEngine.Light::set_range");
			Light.get_flareDelegateField = IL2CPP.ResolveICall<Light.get_flareDelegate>("UnityEngine.Light::get_flare");
			Light.set_flareDelegateField = IL2CPP.ResolveICall<Light.set_flareDelegate>("UnityEngine.Light::set_flare");
			Light.get_cullingMaskDelegateField = IL2CPP.ResolveICall<Light.get_cullingMaskDelegate>("UnityEngine.Light::get_cullingMask");
			Light.set_cullingMaskDelegateField = IL2CPP.ResolveICall<Light.set_cullingMaskDelegate>("UnityEngine.Light::set_cullingMask");
			Light.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Light.get_renderingLayerMaskDelegate>("UnityEngine.Light::get_renderingLayerMask");
			Light.get_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.get_lightShadowCasterModeDelegate>("UnityEngine.Light::get_lightShadowCasterMode");
			Light.set_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.set_lightShadowCasterModeDelegate>("UnityEngine.Light::set_lightShadowCasterMode");
			Light.ResetDelegateField = IL2CPP.ResolveICall<Light.ResetDelegate>("UnityEngine.Light::Reset");
			Light.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowResolutionDelegate>("UnityEngine.Light::set_shadowResolution");
			Light.get_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.get_layerShadowCullDistancesDelegate>("UnityEngine.Light::get_layerShadowCullDistances");
			Light.set_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.set_layerShadowCullDistancesDelegate>("UnityEngine.Light::set_layerShadowCullDistances");
			Light.set_cookieSizeDelegateField = IL2CPP.ResolveICall<Light.set_cookieSizeDelegate>("UnityEngine.Light::set_cookieSize");
			Light.set_cookieDelegateField = IL2CPP.ResolveICall<Light.set_cookieDelegate>("UnityEngine.Light::set_cookie");
			Light.get_renderModeDelegateField = IL2CPP.ResolveICall<Light.get_renderModeDelegate>("UnityEngine.Light::get_renderMode");
			Light.set_renderModeDelegateField = IL2CPP.ResolveICall<Light.set_renderModeDelegate>("UnityEngine.Light::set_renderMode");
			Light.AddCommandBufferDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferDelegate>("UnityEngine.Light::AddCommandBuffer");
			Light.AddCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferAsyncDelegate>("UnityEngine.Light::AddCommandBufferAsync");
			Light.RemoveCommandBufferDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBufferDelegate>("UnityEngine.Light::RemoveCommandBuffer");
			Light.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBuffersDelegate>("UnityEngine.Light::RemoveCommandBuffers");
			Light.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveAllCommandBuffersDelegate>("UnityEngine.Light::RemoveAllCommandBuffers");
			Light.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.GetCommandBuffersDelegate>("UnityEngine.Light::GetCommandBuffers");
			Light.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Light.get_commandBufferCountDelegate>("UnityEngine.Light::get_commandBufferCount");
			Light.GetLightsDelegateField = IL2CPP.ResolveICall<Light.GetLightsDelegate>("UnityEngine.Light::GetLights");
			Light.get_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::get_boundingSphereOverride_Injected");
			Light.set_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::set_boundingSphereOverride_Injected");
			Light.get_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::get_shadowMatrixOverride_Injected");
			Light.set_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::set_shadowMatrixOverride_Injected");
			Light.set_bakingOutput_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_bakingOutput_InjectedDelegate>("UnityEngine.Light::set_bakingOutput_Injected");
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0004144C File Offset: 0x0003F64C
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000088AE File Offset: 0x00006AAE
		public unsafe LightType type
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1237862, RefRangeEnd = 1237874, XrefRangeStart = 1237860, XrefRangeEnd = 1237862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00041488 File Offset: 0x0003F688
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x000088E6 File Offset: 0x00006AE6
		public unsafe float spotAngle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1237876, RefRangeEnd = 1237883, XrefRangeStart = 1237874, XrefRangeEnd = 1237876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_spotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x000414C4 File Offset: 0x0003F6C4
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000088F9 File Offset: 0x00006AF9
		public unsafe float innerSpotAngle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1237885, RefRangeEnd = 1237888, XrefRangeStart = 1237883, XrefRangeEnd = 1237885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_innerSpotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00041500 File Offset: 0x0003F700
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x0004153C File Offset: 0x0003F73C
		public unsafe Color color
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1237890, RefRangeEnd = 1237911, XrefRangeStart = 1237888, XrefRangeEnd = 1237890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1237913, RefRangeEnd = 1237920, XrefRangeStart = 1237911, XrefRangeEnd = 1237913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0004157C File Offset: 0x0003F77C
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0000890C File Offset: 0x00006B0C
		public unsafe float colorTemperature
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1237922, RefRangeEnd = 1237931, XrefRangeStart = 1237920, XrefRangeEnd = 1237922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_colorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x000415B8 File Offset: 0x0003F7B8
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0000891F File Offset: 0x00006B1F
		public unsafe bool useColorTemperature
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1237933, RefRangeEnd = 1237944, XrefRangeStart = 1237931, XrefRangeEnd = 1237933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_useColorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000415F4 File Offset: 0x0003F7F4
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00041630 File Offset: 0x0003F830
		public unsafe float intensity
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1237946, RefRangeEnd = 1237968, XrefRangeStart = 1237944, XrefRangeEnd = 1237946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1237970, RefRangeEnd = 1237987, XrefRangeStart = 1237968, XrefRangeEnd = 1237970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00041670 File Offset: 0x0003F870
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00008932 File Offset: 0x00006B32
		public unsafe float bounceIntensity
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1237989, RefRangeEnd = 1237995, XrefRangeStart = 1237987, XrefRangeEnd = 1237989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_bounceIntensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000416AC File Offset: 0x0003F8AC
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x000089BE File Offset: 0x00006BBE
		public unsafe float shadowBias
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237997, RefRangeEnd = 1237998, XrefRangeStart = 1237995, XrefRangeEnd = 1237997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000416E8 File Offset: 0x0003F8E8
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x000089D1 File Offset: 0x00006BD1
		public unsafe float shadowNormalBias
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238000, RefRangeEnd = 1238001, XrefRangeStart = 1237998, XrefRangeEnd = 1238000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowNormalBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00041724 File Offset: 0x0003F924
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x000089E4 File Offset: 0x00006BE4
		public unsafe float shadowNearPlane
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238003, RefRangeEnd = 1238004, XrefRangeStart = 1238001, XrefRangeEnd = 1238003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowNearPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00041760 File Offset: 0x0003F960
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00008A26 File Offset: 0x00006C26
		public unsafe float range
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1238006, RefRangeEnd = 1238015, XrefRangeStart = 1238004, XrefRangeEnd = 1238006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_rangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0004179C File Offset: 0x0003F99C
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00008A51 File Offset: 0x00006C51
		public unsafe LightBakingOutput bakingOutput
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1238017, RefRangeEnd = 1238034, XrefRangeStart = 1238015, XrefRangeEnd = 1238017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_bakingOutput_Injected(ref value);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00008A80 File Offset: 0x00006C80
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x000417D8 File Offset: 0x0003F9D8
		public unsafe int renderingLayerMask
		{
			get
			{
				return Light.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238036, RefRangeEnd = 1238037, XrefRangeStart = 1238034, XrefRangeEnd = 1238036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00041818 File Offset: 0x0003FA18
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00041854 File Offset: 0x0003FA54
		public unsafe LightShadows shadows
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1238039, RefRangeEnd = 1238073, XrefRangeStart = 1238037, XrefRangeEnd = 1238039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238075, RefRangeEnd = 1238077, XrefRangeStart = 1238073, XrefRangeEnd = 1238075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00041894 File Offset: 0x0003FA94
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x000418D0 File Offset: 0x0003FAD0
		public unsafe float shadowStrength
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1238079, RefRangeEnd = 1238084, XrefRangeStart = 1238077, XrefRangeEnd = 1238079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1238086, RefRangeEnd = 1238090, XrefRangeStart = 1238084, XrefRangeEnd = 1238086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00041910 File Offset: 0x0003FB10
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00008AC9 File Offset: 0x00006CC9
		public unsafe UnityEngine.Rendering.LightShadowResolution shadowResolution
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238092, RefRangeEnd = 1238093, XrefRangeStart = 1238090, XrefRangeEnd = 1238092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0004194C File Offset: 0x0003FB4C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00008AFA File Offset: 0x00006CFA
		public unsafe float cookieSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238095, RefRangeEnd = 1238097, XrefRangeStart = 1238093, XrefRangeEnd = 1238095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_cookieSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00041988 File Offset: 0x0003FB88
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00008B0D File Offset: 0x00006D0D
		public unsafe Texture cookie
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1238099, RefRangeEnd = 1238109, XrefRangeStart = 1238097, XrefRangeEnd = 1238099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			set
			{
				Light.set_cookieDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000419C8 File Offset: 0x0003FBC8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00041A04 File Offset: 0x0003FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238109, XrefRangeEnd = 1238111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00041A44 File Offset: 0x0003FC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238111, XrefRangeEnd = 1238113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00041A84 File Offset: 0x0003FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238113, XrefRangeEnd = 1238115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bakingOutput_Injected(out LightBakingOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0000888A File Offset: 0x00006A8A
		public Light(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00041AC4 File Offset: 0x0003FCC4
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00008893 File Offset: 0x00006A93
		public unsafe int m_BakedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000088C1 File Offset: 0x00006AC1
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000088D3 File Offset: 0x00006AD3
		public LightShape shape
		{
			get
			{
				return Light.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00008945 File Offset: 0x00006B45
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00008957 File Offset: 0x00006B57
		public bool useBoundingSphereOverride
		{
			get
			{
				return Light.get_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00041AEC File Offset: 0x0003FCEC
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0000896A File Offset: 0x00006B6A
		public Vector4 boundingSphereOverride
		{
			get
			{
				Vector4 result;
				this.get_boundingSphereOverride_Injected(out result);
				return result;
			}
			set
			{
				this.set_boundingSphereOverride_Injected(ref value);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00008974 File Offset: 0x00006B74
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00008986 File Offset: 0x00006B86
		public bool useViewFrustumForShadowCasterCull
		{
			get
			{
				return Light.get_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00008999 File Offset: 0x00006B99
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000089AB File Offset: 0x00006BAB
		public int shadowCustomResolution
		{
			get
			{
				return Light.get_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000089F7 File Offset: 0x00006BF7
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00008A09 File Offset: 0x00006C09
		public bool useShadowMatrixOverride
		{
			get
			{
				return Light.get_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00041B04 File Offset: 0x0003FD04
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00008A1C File Offset: 0x00006C1C
		public Matrix4x4 shadowMatrixOverride
		{
			get
			{
				Matrix4x4 result;
				this.get_shadowMatrixOverride_Injected(out result);
				return result;
			}
			set
			{
				this.set_shadowMatrixOverride_Injected(ref value);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00041B1C File Offset: 0x0003FD1C
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00008A39 File Offset: 0x00006C39
		public Flare flare
		{
			get
			{
				IntPtr intPtr = Light.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				Light.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00008A5B File Offset: 0x00006C5B
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00008A6D File Offset: 0x00006C6D
		public int cullingMask
		{
			get
			{
				return Light.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00008A92 File Offset: 0x00006C92
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public LightShadowCasterMode lightShadowCasterMode
		{
			get
			{
				return Light.get_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00008AB7 File Offset: 0x00006CB7
		public void Reset()
		{
			Light.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00041B48 File Offset: 0x0003FD48
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00008ADC File Offset: 0x00006CDC
		public float shadowSoftness
		{
			get
			{
				return 4f;
			}
			set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00041B60 File Offset: 0x0003FD60
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00008ADF File Offset: 0x00006CDF
		public float shadowSoftnessFade
		{
			get
			{
				return 1f;
			}
			set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00041B78 File Offset: 0x0003FD78
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00008AE2 File Offset: 0x00006CE2
		public Il2CppStructArray<float> layerShadowCullDistances
		{
			get
			{
				IntPtr intPtr = Light.get_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				Light.set_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00008B25 File Offset: 0x00006D25
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00008B37 File Offset: 0x00006D37
		public LightRenderMode renderMode
		{
			get
			{
				return Light.get_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00041BA4 File Offset: 0x0003FDA4
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00008B4A File Offset: 0x00006D4A
		public int bakedIndex
		{
			get
			{
				return this.m_BakedIndex;
			}
			set
			{
				this.m_BakedIndex = value;
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00008B54 File Offset: 0x00006D54
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			this.AddCommandBuffer(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00008B65 File Offset: 0x00006D65
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask)
		{
			Light.AddCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00008B7F File Offset: 0x00006D7F
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			this.AddCommandBufferAsync(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All, queueType);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00008B91 File Offset: 0x00006D91
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Light.AddCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask, queueType);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00008BAD File Offset: 0x00006DAD
		public void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			Light.RemoveCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00008BC6 File Offset: 0x00006DC6
		public void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			Light.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00008BD9 File Offset: 0x00006DD9
		public void RemoveAllCommandBuffers()
		{
			Light.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00041BBC File Offset: 0x0003FDBC
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			IntPtr intPtr = Light.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00008BEB File Offset: 0x00006DEB
		public int commandBufferCount
		{
			get
			{
				return Light.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00041BEC File Offset: 0x0003FDEC
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00008BFD File Offset: 0x00006DFD
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.pixelLightCount;
			}
			set
			{
				QualitySettings.pixelLightCount = value;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00041C04 File Offset: 0x0003FE04
		public static Il2CppReferenceArray<Light> GetLights(LightType type, int layer)
		{
			IntPtr intPtr = Light.GetLightsDelegateField(type, layer);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00041C2C File Offset: 0x0003FE2C
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00008C07 File Offset: 0x00006E07
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00041C44 File Offset: 0x0003FE44
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00008C0A File Offset: 0x00006E0A
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00041C5C File Offset: 0x0003FE5C
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00008C0D File Offset: 0x00006E0D
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00008C10 File Offset: 0x00006E10
		public void get_boundingSphereOverride_Injected(out Vector4 ret)
		{
			Light.get_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00008C23 File Offset: 0x00006E23
		public void set_boundingSphereOverride_Injected(ref Vector4 value)
		{
			Light.set_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00008C36 File Offset: 0x00006E36
		public void get_shadowMatrixOverride_Injected(out Matrix4x4 ret)
		{
			Light.get_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00008C49 File Offset: 0x00006E49
		public void set_shadowMatrixOverride_Injected(ref Matrix4x4 value)
		{
			Light.set_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00008C5C File Offset: 0x00006E5C
		public void set_bakingOutput_Injected(ref LightBakingOutput value)
		{
			Light.set_bakingOutput_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_m_BakedIndex;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_LightType_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_cookie_Public_get_Texture_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly Light.set_typeDelegate set_typeDelegateField;

		// Token: 0x04000A86 RID: 2694
		private static readonly Light.get_shapeDelegate get_shapeDelegateField;

		// Token: 0x04000A87 RID: 2695
		private static readonly Light.set_shapeDelegate set_shapeDelegateField;

		// Token: 0x04000A88 RID: 2696
		private static readonly Light.set_spotAngleDelegate set_spotAngleDelegateField;

		// Token: 0x04000A89 RID: 2697
		private static readonly Light.set_innerSpotAngleDelegate set_innerSpotAngleDelegateField;

		// Token: 0x04000A8A RID: 2698
		private static readonly Light.set_colorTemperatureDelegate set_colorTemperatureDelegateField;

		// Token: 0x04000A8B RID: 2699
		private static readonly Light.set_useColorTemperatureDelegate set_useColorTemperatureDelegateField;

		// Token: 0x04000A8C RID: 2700
		private static readonly Light.set_bounceIntensityDelegate set_bounceIntensityDelegateField;

		// Token: 0x04000A8D RID: 2701
		private static readonly Light.get_useBoundingSphereOverrideDelegate get_useBoundingSphereOverrideDelegateField;

		// Token: 0x04000A8E RID: 2702
		private static readonly Light.set_useBoundingSphereOverrideDelegate set_useBoundingSphereOverrideDelegateField;

		// Token: 0x04000A8F RID: 2703
		private static readonly Light.get_useViewFrustumForShadowCasterCullDelegate get_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x04000A90 RID: 2704
		private static readonly Light.set_useViewFrustumForShadowCasterCullDelegate set_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x04000A91 RID: 2705
		private static readonly Light.get_shadowCustomResolutionDelegate get_shadowCustomResolutionDelegateField;

		// Token: 0x04000A92 RID: 2706
		private static readonly Light.set_shadowCustomResolutionDelegate set_shadowCustomResolutionDelegateField;

		// Token: 0x04000A93 RID: 2707
		private static readonly Light.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000A94 RID: 2708
		private static readonly Light.set_shadowNormalBiasDelegate set_shadowNormalBiasDelegateField;

		// Token: 0x04000A95 RID: 2709
		private static readonly Light.set_shadowNearPlaneDelegate set_shadowNearPlaneDelegateField;

		// Token: 0x04000A96 RID: 2710
		private static readonly Light.get_useShadowMatrixOverrideDelegate get_useShadowMatrixOverrideDelegateField;

		// Token: 0x04000A97 RID: 2711
		private static readonly Light.set_useShadowMatrixOverrideDelegate set_useShadowMatrixOverrideDelegateField;

		// Token: 0x04000A98 RID: 2712
		private static readonly Light.set_rangeDelegate set_rangeDelegateField;

		// Token: 0x04000A99 RID: 2713
		private static readonly Light.get_flareDelegate get_flareDelegateField;

		// Token: 0x04000A9A RID: 2714
		private static readonly Light.set_flareDelegate set_flareDelegateField;

		// Token: 0x04000A9B RID: 2715
		private static readonly Light.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x04000A9C RID: 2716
		private static readonly Light.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x04000A9D RID: 2717
		private static readonly Light.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x04000A9E RID: 2718
		private static readonly Light.get_lightShadowCasterModeDelegate get_lightShadowCasterModeDelegateField;

		// Token: 0x04000A9F RID: 2719
		private static readonly Light.set_lightShadowCasterModeDelegate set_lightShadowCasterModeDelegateField;

		// Token: 0x04000AA0 RID: 2720
		private static readonly Light.ResetDelegate ResetDelegateField;

		// Token: 0x04000AA1 RID: 2721
		private static readonly Light.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x04000AA2 RID: 2722
		private static readonly Light.get_layerShadowCullDistancesDelegate get_layerShadowCullDistancesDelegateField;

		// Token: 0x04000AA3 RID: 2723
		private static readonly Light.set_layerShadowCullDistancesDelegate set_layerShadowCullDistancesDelegateField;

		// Token: 0x04000AA4 RID: 2724
		private static readonly Light.set_cookieSizeDelegate set_cookieSizeDelegateField;

		// Token: 0x04000AA5 RID: 2725
		private static readonly Light.set_cookieDelegate set_cookieDelegateField;

		// Token: 0x04000AA6 RID: 2726
		private static readonly Light.get_renderModeDelegate get_renderModeDelegateField;

		// Token: 0x04000AA7 RID: 2727
		private static readonly Light.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x04000AA8 RID: 2728
		private static readonly Light.AddCommandBufferDelegate AddCommandBufferDelegateField;

		// Token: 0x04000AA9 RID: 2729
		private static readonly Light.AddCommandBufferAsyncDelegate AddCommandBufferAsyncDelegateField;

		// Token: 0x04000AAA RID: 2730
		private static readonly Light.RemoveCommandBufferDelegate RemoveCommandBufferDelegateField;

		// Token: 0x04000AAB RID: 2731
		private static readonly Light.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x04000AAC RID: 2732
		private static readonly Light.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x04000AAD RID: 2733
		private static readonly Light.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x04000AAE RID: 2734
		private static readonly Light.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x04000AAF RID: 2735
		private static readonly Light.GetLightsDelegate GetLightsDelegateField;

		// Token: 0x04000AB0 RID: 2736
		private static readonly Light.get_boundingSphereOverride_InjectedDelegate get_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000AB1 RID: 2737
		private static readonly Light.set_boundingSphereOverride_InjectedDelegate set_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000AB2 RID: 2738
		private static readonly Light.get_shadowMatrixOverride_InjectedDelegate get_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x04000AB3 RID: 2739
		private static readonly Light.set_shadowMatrixOverride_InjectedDelegate set_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x04000AB4 RID: 2740
		private static readonly Light.set_bakingOutput_InjectedDelegate set_bakingOutput_InjectedDelegateField;

		// Token: 0x02000711 RID: 1809
		// (Invoke) Token: 0x060036D6 RID: 14038
		private delegate void set_typeDelegate(IntPtr @this, LightType value);

		// Token: 0x02000712 RID: 1810
		// (Invoke) Token: 0x060036D8 RID: 14040
		private delegate LightShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000713 RID: 1811
		// (Invoke) Token: 0x060036DA RID: 14042
		private delegate void set_shapeDelegate(IntPtr @this, LightShape value);

		// Token: 0x02000714 RID: 1812
		// (Invoke) Token: 0x060036DC RID: 14044
		private delegate void set_spotAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000715 RID: 1813
		// (Invoke) Token: 0x060036DE RID: 14046
		private delegate void set_innerSpotAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000716 RID: 1814
		// (Invoke) Token: 0x060036E0 RID: 14048
		private delegate void set_colorTemperatureDelegate(IntPtr @this, float value);

		// Token: 0x02000717 RID: 1815
		// (Invoke) Token: 0x060036E2 RID: 14050
		private delegate void set_useColorTemperatureDelegate(IntPtr @this, bool value);

		// Token: 0x02000718 RID: 1816
		// (Invoke) Token: 0x060036E4 RID: 14052
		private delegate void set_bounceIntensityDelegate(IntPtr @this, float value);

		// Token: 0x02000719 RID: 1817
		// (Invoke) Token: 0x060036E6 RID: 14054
		private delegate bool get_useBoundingSphereOverrideDelegate(IntPtr @this);

		// Token: 0x0200071A RID: 1818
		// (Invoke) Token: 0x060036E8 RID: 14056
		private delegate void set_useBoundingSphereOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x0200071B RID: 1819
		// (Invoke) Token: 0x060036EA RID: 14058
		private delegate bool get_useViewFrustumForShadowCasterCullDelegate(IntPtr @this);

		// Token: 0x0200071C RID: 1820
		// (Invoke) Token: 0x060036EC RID: 14060
		private delegate void set_useViewFrustumForShadowCasterCullDelegate(IntPtr @this, bool value);

		// Token: 0x0200071D RID: 1821
		// (Invoke) Token: 0x060036EE RID: 14062
		private delegate int get_shadowCustomResolutionDelegate(IntPtr @this);

		// Token: 0x0200071E RID: 1822
		// (Invoke) Token: 0x060036F0 RID: 14064
		private delegate void set_shadowCustomResolutionDelegate(IntPtr @this, int value);

		// Token: 0x0200071F RID: 1823
		// (Invoke) Token: 0x060036F2 RID: 14066
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000720 RID: 1824
		// (Invoke) Token: 0x060036F4 RID: 14068
		private delegate void set_shadowNormalBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000721 RID: 1825
		// (Invoke) Token: 0x060036F6 RID: 14070
		private delegate void set_shadowNearPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000722 RID: 1826
		// (Invoke) Token: 0x060036F8 RID: 14072
		private delegate bool get_useShadowMatrixOverrideDelegate(IntPtr @this);

		// Token: 0x02000723 RID: 1827
		// (Invoke) Token: 0x060036FA RID: 14074
		private delegate void set_useShadowMatrixOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x02000724 RID: 1828
		// (Invoke) Token: 0x060036FC RID: 14076
		private delegate void set_rangeDelegate(IntPtr @this, float value);

		// Token: 0x02000725 RID: 1829
		// (Invoke) Token: 0x060036FE RID: 14078
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x02000726 RID: 1830
		// (Invoke) Token: 0x06003700 RID: 14080
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000727 RID: 1831
		// (Invoke) Token: 0x06003702 RID: 14082
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x02000728 RID: 1832
		// (Invoke) Token: 0x06003704 RID: 14084
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000729 RID: 1833
		// (Invoke) Token: 0x06003706 RID: 14086
		private delegate int get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x0200072A RID: 1834
		// (Invoke) Token: 0x06003708 RID: 14088
		private delegate LightShadowCasterMode get_lightShadowCasterModeDelegate(IntPtr @this);

		// Token: 0x0200072B RID: 1835
		// (Invoke) Token: 0x0600370A RID: 14090
		private delegate void set_lightShadowCasterModeDelegate(IntPtr @this, LightShadowCasterMode value);

		// Token: 0x0200072C RID: 1836
		// (Invoke) Token: 0x0600370C RID: 14092
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x0200072D RID: 1837
		// (Invoke) Token: 0x0600370E RID: 14094
		private delegate void set_shadowResolutionDelegate(IntPtr @this, UnityEngine.Rendering.LightShadowResolution value);

		// Token: 0x0200072E RID: 1838
		// (Invoke) Token: 0x06003710 RID: 14096
		private delegate IntPtr get_layerShadowCullDistancesDelegate(IntPtr @this);

		// Token: 0x0200072F RID: 1839
		// (Invoke) Token: 0x06003712 RID: 14098
		private delegate void set_layerShadowCullDistancesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000730 RID: 1840
		// (Invoke) Token: 0x06003714 RID: 14100
		private delegate void set_cookieSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000731 RID: 1841
		// (Invoke) Token: 0x06003716 RID: 14102
		private delegate void set_cookieDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000732 RID: 1842
		// (Invoke) Token: 0x06003718 RID: 14104
		private delegate LightRenderMode get_renderModeDelegate(IntPtr @this);

		// Token: 0x02000733 RID: 1843
		// (Invoke) Token: 0x0600371A RID: 14106
		private delegate void set_renderModeDelegate(IntPtr @this, LightRenderMode value);

		// Token: 0x02000734 RID: 1844
		// (Invoke) Token: 0x0600371C RID: 14108
		private delegate void AddCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);

		// Token: 0x02000735 RID: 1845
		// (Invoke) Token: 0x0600371E RID: 14110
		private delegate void AddCommandBufferAsyncDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x02000736 RID: 1846
		// (Invoke) Token: 0x06003720 RID: 14112
		private delegate void RemoveCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer);

		// Token: 0x02000737 RID: 1847
		// (Invoke) Token: 0x06003722 RID: 14114
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x02000738 RID: 1848
		// (Invoke) Token: 0x06003724 RID: 14116
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x02000739 RID: 1849
		// (Invoke) Token: 0x06003726 RID: 14118
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x0200073A RID: 1850
		// (Invoke) Token: 0x06003728 RID: 14120
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x0200073B RID: 1851
		// (Invoke) Token: 0x0600372A RID: 14122
		private delegate IntPtr GetLightsDelegate(LightType type, int layer);

		// Token: 0x0200073C RID: 1852
		// (Invoke) Token: 0x0600372C RID: 14124
		private delegate void get_boundingSphereOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200073D RID: 1853
		// (Invoke) Token: 0x0600372E RID: 14126
		private delegate void set_boundingSphereOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200073E RID: 1854
		// (Invoke) Token: 0x06003730 RID: 14128
		private delegate void get_shadowMatrixOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200073F RID: 1855
		// (Invoke) Token: 0x06003732 RID: 14130
		private delegate void set_shadowMatrixOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000740 RID: 1856
		// (Invoke) Token: 0x06003734 RID: 14132
		private delegate void set_bakingOutput_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
