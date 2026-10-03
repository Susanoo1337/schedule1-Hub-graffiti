using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200007A RID: 122
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x0002801C File Offset: 0x0002621C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbe()
		{
			Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
			ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "reflectionProbeChanged");
			ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionSetActions");
			ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionTextureActions");
			ReflectionProbe.NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663857);
			ReflectionProbe.NativeMethodInfoPtr_get_timeSlicingMode_Public_get_ReflectionProbeTimeSlicingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663858);
			ReflectionProbe.NativeMethodInfoPtr_RenderProbe_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663859);
			ReflectionProbe.NativeMethodInfoPtr_RenderProbe_Public_Int32_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663860);
			ReflectionProbe.NativeMethodInfoPtr_ScheduleRender_Private_Int32_ReflectionProbeTimeSlicingMode_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663861);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663862);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663863);
			ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663864);
			ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663865);
			ReflectionProbe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663866);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663868);
			ReflectionProbe.get_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_typeDelegate>("UnityEngine.ReflectionProbe::get_type");
			ReflectionProbe.set_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_typeDelegate>("UnityEngine.ReflectionProbe::set_type");
			ReflectionProbe.get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane");
			ReflectionProbe.set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane");
			ReflectionProbe.get_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane");
			ReflectionProbe.set_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane");
			ReflectionProbe.get_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_intensityDelegate>("UnityEngine.ReflectionProbe::get_intensity");
			ReflectionProbe.set_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_intensityDelegate>("UnityEngine.ReflectionProbe::set_intensity");
			ReflectionProbe.get_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_hdrDelegate>("UnityEngine.ReflectionProbe::get_hdr");
			ReflectionProbe.set_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_hdrDelegate>("UnityEngine.ReflectionProbe::set_hdr");
			ReflectionProbe.get_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects");
			ReflectionProbe.set_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects");
			ReflectionProbe.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance");
			ReflectionProbe.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance");
			ReflectionProbe.get_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_resolutionDelegate>("UnityEngine.ReflectionProbe::get_resolution");
			ReflectionProbe.set_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_resolutionDelegate>("UnityEngine.ReflectionProbe::set_resolution");
			ReflectionProbe.get_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_cullingMaskDelegate>("UnityEngine.ReflectionProbe::get_cullingMask");
			ReflectionProbe.set_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_cullingMaskDelegate>("UnityEngine.ReflectionProbe::set_cullingMask");
			ReflectionProbe.get_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_clearFlagsDelegate>("UnityEngine.ReflectionProbe::get_clearFlags");
			ReflectionProbe.set_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_clearFlagsDelegate>("UnityEngine.ReflectionProbe::set_clearFlags");
			ReflectionProbe.get_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_blendDistanceDelegate>("UnityEngine.ReflectionProbe::get_blendDistance");
			ReflectionProbe.set_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_blendDistanceDelegate>("UnityEngine.ReflectionProbe::set_blendDistance");
			ReflectionProbe.get_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_boxProjectionDelegate>("UnityEngine.ReflectionProbe::get_boxProjection");
			ReflectionProbe.set_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_boxProjectionDelegate>("UnityEngine.ReflectionProbe::set_boxProjection");
			ReflectionProbe.get_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_modeDelegate>("UnityEngine.ReflectionProbe::get_mode");
			ReflectionProbe.set_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_modeDelegate>("UnityEngine.ReflectionProbe::set_mode");
			ReflectionProbe.get_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_importanceDelegate>("UnityEngine.ReflectionProbe::get_importance");
			ReflectionProbe.set_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_importanceDelegate>("UnityEngine.ReflectionProbe::set_importance");
			ReflectionProbe.set_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_refreshModeDelegate>("UnityEngine.ReflectionProbe::set_refreshMode");
			ReflectionProbe.set_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode");
			ReflectionProbe.get_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bakedTextureDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture");
			ReflectionProbe.set_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_bakedTextureDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture");
			ReflectionProbe.get_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture");
			ReflectionProbe.set_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture");
			ReflectionProbe.get_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture");
			ReflectionProbe.set_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture");
			ReflectionProbe.get_textureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureDelegate>("UnityEngine.ReflectionProbe::get_texture");
			ReflectionProbe.ResetDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ResetDelegate>("UnityEngine.ReflectionProbe::Reset");
			ReflectionProbe.IsFinishedRenderingDelegateField = IL2CPP.ResolveICall<ReflectionProbe.IsFinishedRenderingDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering");
			ReflectionProbe.BlendCubemapDelegateField = IL2CPP.ResolveICall<ReflectionProbe.BlendCubemapDelegate>("UnityEngine.ReflectionProbe::BlendCubemap");
			ReflectionProbe.UpdateCachedStateDelegateField = IL2CPP.ResolveICall<ReflectionProbe.UpdateCachedStateDelegate>("UnityEngine.ReflectionProbe::UpdateCachedState");
			ReflectionProbe.get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
			ReflectionProbe.get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
			ReflectionProbe.get_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
			ReflectionProbe.set_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
			ReflectionProbe.get_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
			ReflectionProbe.set_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
			ReflectionProbe.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
			ReflectionProbe.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
			ReflectionProbe.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00028464 File Offset: 0x00026664
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1229300, RefRangeEnd = 1229301, XrefRangeStart = 1229298, XrefRangeEnd = 1229300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ReflectionProbe.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x000284A0 File Offset: 0x000266A0
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229301, XrefRangeEnd = 1229303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_timeSlicingMode_Public_get_ReflectionProbeTimeSlicingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ReflectionProbe.set_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000284DC File Offset: 0x000266DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229307, RefRangeEnd = 1229308, XrefRangeStart = 1229303, XrefRangeEnd = 1229307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RenderProbe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_RenderProbe_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00028518 File Offset: 0x00026718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229308, XrefRangeEnd = 1229312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RenderProbe(RenderTexture targetTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_RenderProbe_Public_Int32_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00028568 File Offset: 0x00026768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229312, XrefRangeEnd = 1229333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeSlicingMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_ScheduleRender_Private_Int32_ReflectionProbeTimeSlicingMode_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000285C4 File Offset: 0x000267C4
		public unsafe static Vector4 defaultTextureHDRDecodeValues
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1229338, RefRangeEnd = 1229340, XrefRangeStart = 1229333, XrefRangeEnd = 1229338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000285F4 File Offset: 0x000267F4
		public unsafe static Texture defaultTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1229342, RefRangeEnd = 1229343, XrefRangeStart = 1229340, XrefRangeEnd = 1229342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00028628 File Offset: 0x00026828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229343, XrefRangeEnd = 1229347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(probe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probeEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002866C File Offset: 0x0002686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229347, XrefRangeEnd = 1229365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultReflectionCubemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000286A4 File Offset: 0x000268A4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionProbe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000286E0 File Offset: 0x000268E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229365, XrefRangeEnd = 1229367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000480D File Offset: 0x00002A0D
		public ReflectionProbe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00028714 File Offset: 0x00026914
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004816 File Offset: 0x00002A16
		public unsafe static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0002873C File Offset: 0x0002693C
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004828 File Offset: 0x00002A28
		public unsafe static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action<Texture>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00028764 File Offset: 0x00026964
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000483A File Offset: 0x00002A3A
		public unsafe static List<Action<Texture>> registeredDefaultReflectionTextureActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action<Texture>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000484C File Offset: 0x00002A4C
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000485E File Offset: 0x00002A5E
		public UnityEngine.Rendering.ReflectionProbeType type
		{
			get
			{
				return ReflectionProbe.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0002878C File Offset: 0x0002698C
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004871 File Offset: 0x00002A71
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.get_size_Injected(out result);
				return result;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x000287A4 File Offset: 0x000269A4
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000487B File Offset: 0x00002A7B
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.get_center_Injected(out result);
				return result;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00004885 File Offset: 0x00002A85
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00004897 File Offset: 0x00002A97
		public float nearClipPlane
		{
			get
			{
				return ReflectionProbe.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000048AA File Offset: 0x00002AAA
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x000048BC File Offset: 0x00002ABC
		public float farClipPlane
		{
			get
			{
				return ReflectionProbe.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000048CF File Offset: 0x00002ACF
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x000048E1 File Offset: 0x00002AE1
		public float intensity
		{
			get
			{
				return ReflectionProbe.get_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x000287BC File Offset: 0x000269BC
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.get_bounds_Injected(out result);
				return result;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000048F4 File Offset: 0x00002AF4
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004906 File Offset: 0x00002B06
		public bool hdr
		{
			get
			{
				return ReflectionProbe.get_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00004919 File Offset: 0x00002B19
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000492B File Offset: 0x00002B2B
		public bool renderDynamicObjects
		{
			get
			{
				return ReflectionProbe.get_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000493E File Offset: 0x00002B3E
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004950 File Offset: 0x00002B50
		public float shadowDistance
		{
			get
			{
				return ReflectionProbe.get_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00004963 File Offset: 0x00002B63
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00004975 File Offset: 0x00002B75
		public int resolution
		{
			get
			{
				return ReflectionProbe.get_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00004988 File Offset: 0x00002B88
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0000499A File Offset: 0x00002B9A
		public int cullingMask
		{
			get
			{
				return ReflectionProbe.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000049AD File Offset: 0x00002BAD
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000049BF File Offset: 0x00002BBF
		public UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		{
			get
			{
				return ReflectionProbe.get_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000287D4 File Offset: 0x000269D4
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x000049D2 File Offset: 0x00002BD2
		public Color backgroundColor
		{
			get
			{
				Color result;
				this.get_backgroundColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_backgroundColor_Injected(ref value);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x000049DC File Offset: 0x00002BDC
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x000049EE File Offset: 0x00002BEE
		public float blendDistance
		{
			get
			{
				return ReflectionProbe.get_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00004A01 File Offset: 0x00002C01
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004A13 File Offset: 0x00002C13
		public bool boxProjection
		{
			get
			{
				return ReflectionProbe.get_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00004A26 File Offset: 0x00002C26
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00004A38 File Offset: 0x00002C38
		public UnityEngine.Rendering.ReflectionProbeMode mode
		{
			get
			{
				return ReflectionProbe.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00004A4B File Offset: 0x00002C4B
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00004A5D File Offset: 0x00002C5D
		public int importance
		{
			get
			{
				return ReflectionProbe.get_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000287EC File Offset: 0x000269EC
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004A96 File Offset: 0x00002C96
		public Texture bakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00028818 File Offset: 0x00026A18
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004AAE File Offset: 0x00002CAE
		public Texture customBakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00028844 File Offset: 0x00026A44
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public RenderTexture realtimeTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00028870 File Offset: 0x00026A70
		public Texture texture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_textureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0002889C File Offset: 0x00026A9C
		public Vector4 textureHDRDecodeValues
		{
			get
			{
				Vector4 result;
				this.get_textureHDRDecodeValues_Injected(out result);
				return result;
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00004ADE File Offset: 0x00002CDE
		public void Reset()
		{
			ReflectionProbe.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public bool IsFinishedRendering(int renderId)
		{
			return ReflectionProbe.IsFinishedRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderId);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00004B03 File Offset: 0x00002D03
		public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
		{
			return ReflectionProbe.BlendCubemapDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), blend, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004B22 File Offset: 0x00002D22
		public static void UpdateCachedState()
		{
			ReflectionProbe.UpdateCachedStateDelegateField();
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00004B2E File Offset: 0x00002D2E
		public static int minBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_minBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00004B3A File Offset: 0x00002D3A
		public static int maxBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_maxBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00004B46 File Offset: 0x00002D46
		public static void add_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00004B53 File Offset: 0x00002D53
		public static void remove_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004B60 File Offset: 0x00002D60
		public static void add_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000288B4 File Offset: 0x00026AB4
		public static void remove_defaultReflectionSet(Action<Cubemap> value)
		{
			Action<Texture> value2;
			bool flag = ReflectionProbe.registeredDefaultReflectionSetActions.TryGetValue(value.Method.GetHashCode(), out value2);
			if (flag)
			{
				ReflectionProbe.remove_defaultReflectionTexture(value2);
				ReflectionProbe.registeredDefaultReflectionSetActions.Remove(value.Method.GetHashCode());
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00004B6D File Offset: 0x00002D6D
		public static void add_defaultReflectionTexture(Action<Texture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00004B7A File Offset: 0x00002D7A
		public static void remove_defaultReflectionTexture(Action<Texture> value)
		{
			ReflectionProbe.registeredDefaultReflectionTextureActions.Remove(value);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00004B89 File Offset: 0x00002D89
		public void get_size_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004B9C File Offset: 0x00002D9C
		public void set_size_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00004BAF File Offset: 0x00002DAF
		public void get_center_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public void set_center_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00004BD5 File Offset: 0x00002DD5
		public void get_bounds_Injected(out Bounds ret)
		{
			ReflectionProbe.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00004BE8 File Offset: 0x00002DE8
		public void get_backgroundColor_Injected(out Color ret)
		{
			ReflectionProbe.get_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00004BFB File Offset: 0x00002DFB
		public void set_backgroundColor_Injected(ref Color value)
		{
			ReflectionProbe.set_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00004C0E File Offset: 0x00002E0E
		public void get_textureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeChanged;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_registeredDefaultReflectionSetActions;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_registeredDefaultReflectionTextureActions;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSlicingMode_Public_get_ReflectionProbeTimeSlicingMode_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_RenderProbe_Public_Int32_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_RenderProbe_Public_Int32_RenderTexture_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleRender_Private_Int32_ReflectionProbeTimeSlicingMode_RenderTexture_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly ReflectionProbe.get_typeDelegate get_typeDelegateField;

		// Token: 0x040004B5 RID: 1205
		private static readonly ReflectionProbe.set_typeDelegate set_typeDelegateField;

		// Token: 0x040004B6 RID: 1206
		private static readonly ReflectionProbe.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField;

		// Token: 0x040004B7 RID: 1207
		private static readonly ReflectionProbe.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField;

		// Token: 0x040004B8 RID: 1208
		private static readonly ReflectionProbe.get_farClipPlaneDelegate get_farClipPlaneDelegateField;

		// Token: 0x040004B9 RID: 1209
		private static readonly ReflectionProbe.set_farClipPlaneDelegate set_farClipPlaneDelegateField;

		// Token: 0x040004BA RID: 1210
		private static readonly ReflectionProbe.get_intensityDelegate get_intensityDelegateField;

		// Token: 0x040004BB RID: 1211
		private static readonly ReflectionProbe.set_intensityDelegate set_intensityDelegateField;

		// Token: 0x040004BC RID: 1212
		private static readonly ReflectionProbe.get_hdrDelegate get_hdrDelegateField;

		// Token: 0x040004BD RID: 1213
		private static readonly ReflectionProbe.set_hdrDelegate set_hdrDelegateField;

		// Token: 0x040004BE RID: 1214
		private static readonly ReflectionProbe.get_renderDynamicObjectsDelegate get_renderDynamicObjectsDelegateField;

		// Token: 0x040004BF RID: 1215
		private static readonly ReflectionProbe.set_renderDynamicObjectsDelegate set_renderDynamicObjectsDelegateField;

		// Token: 0x040004C0 RID: 1216
		private static readonly ReflectionProbe.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x040004C1 RID: 1217
		private static readonly ReflectionProbe.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x040004C2 RID: 1218
		private static readonly ReflectionProbe.get_resolutionDelegate get_resolutionDelegateField;

		// Token: 0x040004C3 RID: 1219
		private static readonly ReflectionProbe.set_resolutionDelegate set_resolutionDelegateField;

		// Token: 0x040004C4 RID: 1220
		private static readonly ReflectionProbe.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x040004C5 RID: 1221
		private static readonly ReflectionProbe.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x040004C6 RID: 1222
		private static readonly ReflectionProbe.get_clearFlagsDelegate get_clearFlagsDelegateField;

		// Token: 0x040004C7 RID: 1223
		private static readonly ReflectionProbe.set_clearFlagsDelegate set_clearFlagsDelegateField;

		// Token: 0x040004C8 RID: 1224
		private static readonly ReflectionProbe.get_blendDistanceDelegate get_blendDistanceDelegateField;

		// Token: 0x040004C9 RID: 1225
		private static readonly ReflectionProbe.set_blendDistanceDelegate set_blendDistanceDelegateField;

		// Token: 0x040004CA RID: 1226
		private static readonly ReflectionProbe.get_boxProjectionDelegate get_boxProjectionDelegateField;

		// Token: 0x040004CB RID: 1227
		private static readonly ReflectionProbe.set_boxProjectionDelegate set_boxProjectionDelegateField;

		// Token: 0x040004CC RID: 1228
		private static readonly ReflectionProbe.get_modeDelegate get_modeDelegateField;

		// Token: 0x040004CD RID: 1229
		private static readonly ReflectionProbe.set_modeDelegate set_modeDelegateField;

		// Token: 0x040004CE RID: 1230
		private static readonly ReflectionProbe.get_importanceDelegate get_importanceDelegateField;

		// Token: 0x040004CF RID: 1231
		private static readonly ReflectionProbe.set_importanceDelegate set_importanceDelegateField;

		// Token: 0x040004D0 RID: 1232
		private static readonly ReflectionProbe.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x040004D1 RID: 1233
		private static readonly ReflectionProbe.set_timeSlicingModeDelegate set_timeSlicingModeDelegateField;

		// Token: 0x040004D2 RID: 1234
		private static readonly ReflectionProbe.get_bakedTextureDelegate get_bakedTextureDelegateField;

		// Token: 0x040004D3 RID: 1235
		private static readonly ReflectionProbe.set_bakedTextureDelegate set_bakedTextureDelegateField;

		// Token: 0x040004D4 RID: 1236
		private static readonly ReflectionProbe.get_customBakedTextureDelegate get_customBakedTextureDelegateField;

		// Token: 0x040004D5 RID: 1237
		private static readonly ReflectionProbe.set_customBakedTextureDelegate set_customBakedTextureDelegateField;

		// Token: 0x040004D6 RID: 1238
		private static readonly ReflectionProbe.get_realtimeTextureDelegate get_realtimeTextureDelegateField;

		// Token: 0x040004D7 RID: 1239
		private static readonly ReflectionProbe.set_realtimeTextureDelegate set_realtimeTextureDelegateField;

		// Token: 0x040004D8 RID: 1240
		private static readonly ReflectionProbe.get_textureDelegate get_textureDelegateField;

		// Token: 0x040004D9 RID: 1241
		private static readonly ReflectionProbe.ResetDelegate ResetDelegateField;

		// Token: 0x040004DA RID: 1242
		private static readonly ReflectionProbe.IsFinishedRenderingDelegate IsFinishedRenderingDelegateField;

		// Token: 0x040004DB RID: 1243
		private static readonly ReflectionProbe.BlendCubemapDelegate BlendCubemapDelegateField;

		// Token: 0x040004DC RID: 1244
		private static readonly ReflectionProbe.UpdateCachedStateDelegate UpdateCachedStateDelegateField;

		// Token: 0x040004DD RID: 1245
		private static readonly ReflectionProbe.get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;

		// Token: 0x040004DE RID: 1246
		private static readonly ReflectionProbe.get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;

		// Token: 0x040004DF RID: 1247
		private static readonly ReflectionProbe.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x040004E0 RID: 1248
		private static readonly ReflectionProbe.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x040004E1 RID: 1249
		private static readonly ReflectionProbe.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x040004E2 RID: 1250
		private static readonly ReflectionProbe.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x040004E3 RID: 1251
		private static readonly ReflectionProbe.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x040004E4 RID: 1252
		private static readonly ReflectionProbe.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x040004E5 RID: 1253
		private static readonly ReflectionProbe.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x040004E6 RID: 1254
		private static readonly ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x02000497 RID: 1175
		[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeEvent")]
		public enum ReflectionProbeEvent
		{
			// Token: 0x04002A5F RID: 10847
			ReflectionProbeAdded,
			// Token: 0x04002A60 RID: 10848
			ReflectionProbeRemoved
		}

		// Token: 0x02000498 RID: 1176
		public sealed class <>c__DisplayClass95_0
		{
		}

		// Token: 0x02000499 RID: 1177
		public sealed class <>c__DisplayClass98_0
		{
		}

		// Token: 0x0200049A RID: 1178
		// (Invoke) Token: 0x060031D4 RID: 12756
		private delegate UnityEngine.Rendering.ReflectionProbeType get_typeDelegate(IntPtr @this);

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x060031D6 RID: 12758
		private delegate void set_typeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeType value);

		// Token: 0x0200049C RID: 1180
		// (Invoke) Token: 0x060031D8 RID: 12760
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x0200049D RID: 1181
		// (Invoke) Token: 0x060031DA RID: 12762
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x0200049E RID: 1182
		// (Invoke) Token: 0x060031DC RID: 12764
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x0200049F RID: 1183
		// (Invoke) Token: 0x060031DE RID: 12766
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020004A0 RID: 1184
		// (Invoke) Token: 0x060031E0 RID: 12768
		private delegate float get_intensityDelegate(IntPtr @this);

		// Token: 0x020004A1 RID: 1185
		// (Invoke) Token: 0x060031E2 RID: 12770
		private delegate void set_intensityDelegate(IntPtr @this, float value);

		// Token: 0x020004A2 RID: 1186
		// (Invoke) Token: 0x060031E4 RID: 12772
		private delegate bool get_hdrDelegate(IntPtr @this);

		// Token: 0x020004A3 RID: 1187
		// (Invoke) Token: 0x060031E6 RID: 12774
		private delegate void set_hdrDelegate(IntPtr @this, bool value);

		// Token: 0x020004A4 RID: 1188
		// (Invoke) Token: 0x060031E8 RID: 12776
		private delegate bool get_renderDynamicObjectsDelegate(IntPtr @this);

		// Token: 0x020004A5 RID: 1189
		// (Invoke) Token: 0x060031EA RID: 12778
		private delegate void set_renderDynamicObjectsDelegate(IntPtr @this, bool value);

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x060031EC RID: 12780
		private delegate float get_shadowDistanceDelegate(IntPtr @this);

		// Token: 0x020004A7 RID: 1191
		// (Invoke) Token: 0x060031EE RID: 12782
		private delegate void set_shadowDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020004A8 RID: 1192
		// (Invoke) Token: 0x060031F0 RID: 12784
		private delegate int get_resolutionDelegate(IntPtr @this);

		// Token: 0x020004A9 RID: 1193
		// (Invoke) Token: 0x060031F2 RID: 12786
		private delegate void set_resolutionDelegate(IntPtr @this, int value);

		// Token: 0x020004AA RID: 1194
		// (Invoke) Token: 0x060031F4 RID: 12788
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x020004AB RID: 1195
		// (Invoke) Token: 0x060031F6 RID: 12790
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x060031F8 RID: 12792
		private delegate UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlagsDelegate(IntPtr @this);

		// Token: 0x020004AD RID: 1197
		// (Invoke) Token: 0x060031FA RID: 12794
		private delegate void set_clearFlagsDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeClearFlags value);

		// Token: 0x020004AE RID: 1198
		// (Invoke) Token: 0x060031FC RID: 12796
		private delegate float get_blendDistanceDelegate(IntPtr @this);

		// Token: 0x020004AF RID: 1199
		// (Invoke) Token: 0x060031FE RID: 12798
		private delegate void set_blendDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020004B0 RID: 1200
		// (Invoke) Token: 0x06003200 RID: 12800
		private delegate bool get_boxProjectionDelegate(IntPtr @this);

		// Token: 0x020004B1 RID: 1201
		// (Invoke) Token: 0x06003202 RID: 12802
		private delegate void set_boxProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x020004B2 RID: 1202
		// (Invoke) Token: 0x06003204 RID: 12804
		private delegate UnityEngine.Rendering.ReflectionProbeMode get_modeDelegate(IntPtr @this);

		// Token: 0x020004B3 RID: 1203
		// (Invoke) Token: 0x06003206 RID: 12806
		private delegate void set_modeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeMode value);

		// Token: 0x020004B4 RID: 1204
		// (Invoke) Token: 0x06003208 RID: 12808
		private delegate int get_importanceDelegate(IntPtr @this);

		// Token: 0x020004B5 RID: 1205
		// (Invoke) Token: 0x0600320A RID: 12810
		private delegate void set_importanceDelegate(IntPtr @this, int value);

		// Token: 0x020004B6 RID: 1206
		// (Invoke) Token: 0x0600320C RID: 12812
		private delegate void set_refreshModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeRefreshMode value);

		// Token: 0x020004B7 RID: 1207
		// (Invoke) Token: 0x0600320E RID: 12814
		private delegate void set_timeSlicingModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value);

		// Token: 0x020004B8 RID: 1208
		// (Invoke) Token: 0x06003210 RID: 12816
		private delegate IntPtr get_bakedTextureDelegate(IntPtr @this);

		// Token: 0x020004B9 RID: 1209
		// (Invoke) Token: 0x06003212 RID: 12818
		private delegate void set_bakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004BA RID: 1210
		// (Invoke) Token: 0x06003214 RID: 12820
		private delegate IntPtr get_customBakedTextureDelegate(IntPtr @this);

		// Token: 0x020004BB RID: 1211
		// (Invoke) Token: 0x06003216 RID: 12822
		private delegate void set_customBakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004BC RID: 1212
		// (Invoke) Token: 0x06003218 RID: 12824
		private delegate IntPtr get_realtimeTextureDelegate(IntPtr @this);

		// Token: 0x020004BD RID: 1213
		// (Invoke) Token: 0x0600321A RID: 12826
		private delegate void set_realtimeTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004BE RID: 1214
		// (Invoke) Token: 0x0600321C RID: 12828
		private delegate IntPtr get_textureDelegate(IntPtr @this);

		// Token: 0x020004BF RID: 1215
		// (Invoke) Token: 0x0600321E RID: 12830
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x020004C0 RID: 1216
		// (Invoke) Token: 0x06003220 RID: 12832
		private delegate bool IsFinishedRenderingDelegate(IntPtr @this, int renderId);

		// Token: 0x020004C1 RID: 1217
		// (Invoke) Token: 0x06003222 RID: 12834
		private delegate bool BlendCubemapDelegate(IntPtr src, IntPtr dst, float blend, IntPtr target);

		// Token: 0x020004C2 RID: 1218
		// (Invoke) Token: 0x06003224 RID: 12836
		private delegate void UpdateCachedStateDelegate();

		// Token: 0x020004C3 RID: 1219
		// (Invoke) Token: 0x06003226 RID: 12838
		private delegate int get_minBakedCubemapResolutionDelegate();

		// Token: 0x020004C4 RID: 1220
		// (Invoke) Token: 0x06003228 RID: 12840
		private delegate int get_maxBakedCubemapResolutionDelegate();

		// Token: 0x020004C5 RID: 1221
		// (Invoke) Token: 0x0600322A RID: 12842
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020004C6 RID: 1222
		// (Invoke) Token: 0x0600322C RID: 12844
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004C7 RID: 1223
		// (Invoke) Token: 0x0600322E RID: 12846
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020004C8 RID: 1224
		// (Invoke) Token: 0x06003230 RID: 12848
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004C9 RID: 1225
		// (Invoke) Token: 0x06003232 RID: 12850
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020004CA RID: 1226
		// (Invoke) Token: 0x06003234 RID: 12852
		private delegate void get_backgroundColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020004CB RID: 1227
		// (Invoke) Token: 0x06003236 RID: 12854
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020004CC RID: 1228
		// (Invoke) Token: 0x06003238 RID: 12856
		private delegate void get_textureHDRDecodeValues_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
