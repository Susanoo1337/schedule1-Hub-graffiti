using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A8 RID: 168
	public sealed class RenderSettings : Object
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x0003AEEC File Offset: 0x000390EC
		// Note: this type is marked as 'beforefieldinit'.
		static RenderSettings()
		{
			Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
			RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664414);
			RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664415);
			RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664416);
			RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664417);
			RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664418);
			RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664419);
			RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664420);
			RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664421);
			RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664422);
			RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664423);
			RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664424);
			RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664425);
			RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664426);
			RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664427);
			RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664428);
			RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664429);
			RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664430);
			RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664431);
			RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664432);
			RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664433);
			RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664434);
			RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664435);
			RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664436);
			RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664437);
			RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664438);
			RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664439);
			RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664440);
			RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664441);
			RenderSettings.get_fogStartDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogStartDistanceDelegate>("UnityEngine.RenderSettings::get_fogStartDistance");
			RenderSettings.set_fogStartDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogStartDistanceDelegate>("UnityEngine.RenderSettings::set_fogStartDistance");
			RenderSettings.get_fogEndDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogEndDistanceDelegate>("UnityEngine.RenderSettings::get_fogEndDistance");
			RenderSettings.set_fogEndDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogEndDistanceDelegate>("UnityEngine.RenderSettings::set_fogEndDistance");
			RenderSettings.get_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogModeDelegate>("UnityEngine.RenderSettings::get_fogMode");
			RenderSettings.set_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogModeDelegate>("UnityEngine.RenderSettings::set_fogMode");
			RenderSettings.get_fogDensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogDensityDelegate>("UnityEngine.RenderSettings::get_fogDensity");
			RenderSettings.set_fogDensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogDensityDelegate>("UnityEngine.RenderSettings::set_fogDensity");
			RenderSettings.get_ambientModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientModeDelegate>("UnityEngine.RenderSettings::get_ambientMode");
			RenderSettings.set_ambientIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientIntensityDelegate>("UnityEngine.RenderSettings::set_ambientIntensity");
			RenderSettings.set_skyboxDelegateField = IL2CPP.ResolveICall<RenderSettings.set_skyboxDelegate>("UnityEngine.RenderSettings::set_skybox");
			RenderSettings.get_customReflectionTextureDelegateField = IL2CPP.ResolveICall<RenderSettings.get_customReflectionTextureDelegate>("UnityEngine.RenderSettings::get_customReflectionTexture");
			RenderSettings.set_customReflectionTextureDelegateField = IL2CPP.ResolveICall<RenderSettings.set_customReflectionTextureDelegate>("UnityEngine.RenderSettings::set_customReflectionTexture");
			RenderSettings.set_reflectionIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionIntensityDelegate>("UnityEngine.RenderSettings::set_reflectionIntensity");
			RenderSettings.get_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.get_reflectionBouncesDelegate>("UnityEngine.RenderSettings::get_reflectionBounces");
			RenderSettings.set_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionBouncesDelegate>("UnityEngine.RenderSettings::set_reflectionBounces");
			RenderSettings.get_defaultReflectionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionDelegate>("UnityEngine.RenderSettings::get_defaultReflection");
			RenderSettings.get_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::get_defaultReflectionMode");
			RenderSettings.set_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::set_defaultReflectionMode");
			RenderSettings.get_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::get_defaultReflectionResolution");
			RenderSettings.set_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::set_defaultReflectionResolution");
			RenderSettings.get_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_haloStrengthDelegate>("UnityEngine.RenderSettings::get_haloStrength");
			RenderSettings.set_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_haloStrengthDelegate>("UnityEngine.RenderSettings::set_haloStrength");
			RenderSettings.get_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareStrengthDelegate>("UnityEngine.RenderSettings::get_flareStrength");
			RenderSettings.set_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareStrengthDelegate>("UnityEngine.RenderSettings::set_flareStrength");
			RenderSettings.get_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::get_flareFadeSpeed");
			RenderSettings.set_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::set_flareFadeSpeed");
			RenderSettings.GetRenderSettingsDelegateField = IL2CPP.ResolveICall<RenderSettings.GetRenderSettingsDelegate>("UnityEngine.RenderSettings::GetRenderSettings");
			RenderSettings.ResetDelegateField = IL2CPP.ResolveICall<RenderSettings.ResetDelegate>("UnityEngine.RenderSettings::Reset");
			RenderSettings.get_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::get_fogColor_Injected");
			RenderSettings.set_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::set_fogColor_Injected");
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::set_subtractiveShadowColor_Injected");
			RenderSettings.set_ambientProbe_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientProbe_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientProbe_Injected");
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003B33C File Offset: 0x0003953C
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0003B36C File Offset: 0x0003956C
		public unsafe static bool fog
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235511, RefRangeEnd = 1235512, XrefRangeStart = 1235509, XrefRangeEnd = 1235511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235514, RefRangeEnd = 1235515, XrefRangeStart = 1235512, XrefRangeEnd = 1235514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00007A41 File Offset: 0x00005C41
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0003B3A0 File Offset: 0x000395A0
		public unsafe static UnityEngine.Rendering.AmbientMode ambientMode
		{
			get
			{
				return RenderSettings.get_ambientModeDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235517, RefRangeEnd = 1235519, XrefRangeStart = 1235515, XrefRangeEnd = 1235517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003B3D4 File Offset: 0x000395D4
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0003B404 File Offset: 0x00039604
		public unsafe static Color ambientSkyColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235521, RefRangeEnd = 1235522, XrefRangeStart = 1235519, XrefRangeEnd = 1235521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235524, RefRangeEnd = 1235525, XrefRangeStart = 1235522, XrefRangeEnd = 1235524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0003B438 File Offset: 0x00039638
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0003B468 File Offset: 0x00039668
		public unsafe static Color ambientEquatorColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235527, RefRangeEnd = 1235528, XrefRangeStart = 1235525, XrefRangeEnd = 1235527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235530, RefRangeEnd = 1235531, XrefRangeStart = 1235528, XrefRangeEnd = 1235530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003B49C File Offset: 0x0003969C
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0003B4CC File Offset: 0x000396CC
		public unsafe static Color ambientGroundColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235533, RefRangeEnd = 1235534, XrefRangeStart = 1235531, XrefRangeEnd = 1235533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235536, RefRangeEnd = 1235537, XrefRangeStart = 1235534, XrefRangeEnd = 1235536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003B500 File Offset: 0x00039700
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00007A4D File Offset: 0x00005C4D
		public unsafe static float ambientIntensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235539, RefRangeEnd = 1235540, XrefRangeStart = 1235537, XrefRangeEnd = 1235539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_ambientIntensityDelegateField(value);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0003B530 File Offset: 0x00039730
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0003B560 File Offset: 0x00039760
		public unsafe static Color ambientLight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235542, RefRangeEnd = 1235543, XrefRangeStart = 1235540, XrefRangeEnd = 1235542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235545, RefRangeEnd = 1235546, XrefRangeStart = 1235543, XrefRangeEnd = 1235545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003B594 File Offset: 0x00039794
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00007A5A File Offset: 0x00005C5A
		public unsafe static Color subtractiveShadowColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235548, RefRangeEnd = 1235549, XrefRangeStart = 1235546, XrefRangeEnd = 1235548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_subtractiveShadowColor_Injected(ref value);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0003B5C4 File Offset: 0x000397C4
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00007A63 File Offset: 0x00005C63
		public unsafe static Material skybox
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1235551, RefRangeEnd = 1235556, XrefRangeStart = 1235549, XrefRangeEnd = 1235551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			set
			{
				RenderSettings.set_skyboxDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003B5F8 File Offset: 0x000397F8
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0003B62C File Offset: 0x0003982C
		public unsafe static Light sun
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235558, RefRangeEnd = 1235559, XrefRangeStart = 1235556, XrefRangeEnd = 1235558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235561, RefRangeEnd = 1235563, XrefRangeStart = 1235559, XrefRangeEnd = 1235561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003B664 File Offset: 0x00039864
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00007A75 File Offset: 0x00005C75
		public unsafe static UnityEngine.Rendering.SphericalHarmonicsL2 ambientProbe
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235565, RefRangeEnd = 1235567, XrefRangeStart = 1235563, XrefRangeEnd = 1235565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_ambientProbe_Injected(ref value);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003B694 File Offset: 0x00039894
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00007A99 File Offset: 0x00005C99
		public unsafe static float reflectionIntensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235569, RefRangeEnd = 1235570, XrefRangeStart = 1235567, XrefRangeEnd = 1235569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_reflectionIntensityDelegateField(value);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0003B6C4 File Offset: 0x000398C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235570, XrefRangeEnd = 1235572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientSkyColor_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0003B6F8 File Offset: 0x000398F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235572, XrefRangeEnd = 1235574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientSkyColor_Injected(ref Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0003B72C File Offset: 0x0003992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235574, XrefRangeEnd = 1235576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientEquatorColor_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0003B760 File Offset: 0x00039960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235576, XrefRangeEnd = 1235578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientEquatorColor_Injected(ref Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0003B794 File Offset: 0x00039994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235578, XrefRangeEnd = 1235580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientGroundColor_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003B7C8 File Offset: 0x000399C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235580, XrefRangeEnd = 1235582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientGroundColor_Injected(ref Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003B7FC File Offset: 0x000399FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235582, XrefRangeEnd = 1235584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientLight_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003B830 File Offset: 0x00039A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235584, XrefRangeEnd = 1235586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientLight_Injected(ref Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003B864 File Offset: 0x00039A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235586, XrefRangeEnd = 1235588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0003B898 File Offset: 0x00039A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235588, XrefRangeEnd = 1235590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientProbe_Injected(out UnityEngine.Rendering.SphericalHarmonicsL2 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000079C1 File Offset: 0x00005BC1
		public RenderSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0003B8CC File Offset: 0x00039ACC
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x000079CA File Offset: 0x00005BCA
		public static float ambientSkyboxAmount
		{
			get
			{
				return RenderSettings.ambientIntensity;
			}
			set
			{
				RenderSettings.ambientIntensity = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000079D4 File Offset: 0x00005BD4
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x000079E0 File Offset: 0x00005BE0
		public static float fogStartDistance
		{
			get
			{
				return RenderSettings.get_fogStartDistanceDelegateField();
			}
			set
			{
				RenderSettings.set_fogStartDistanceDelegateField(value);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000079ED File Offset: 0x00005BED
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000079F9 File Offset: 0x00005BF9
		public static float fogEndDistance
		{
			get
			{
				return RenderSettings.get_fogEndDistanceDelegateField();
			}
			set
			{
				RenderSettings.set_fogEndDistanceDelegateField(value);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00007A06 File Offset: 0x00005C06
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00007A12 File Offset: 0x00005C12
		public static FogMode fogMode
		{
			get
			{
				return RenderSettings.get_fogModeDelegateField();
			}
			set
			{
				RenderSettings.set_fogModeDelegateField(value);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00007A1F File Offset: 0x00005C1F
		public static Color fogColor
		{
			get
			{
				Color result;
				RenderSettings.get_fogColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_fogColor_Injected(ref value);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00007A28 File Offset: 0x00005C28
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00007A34 File Offset: 0x00005C34
		public static float fogDensity
		{
			get
			{
				return RenderSettings.get_fogDensityDelegateField();
			}
			set
			{
				RenderSettings.set_fogDensityDelegateField(value);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0003B8FC File Offset: 0x00039AFC
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00007A7E File Offset: 0x00005C7E
		public static Cubemap customReflection
		{
			get
			{
				Cubemap cubemap = RenderSettings.customReflectionTexture.TryCast<Cubemap>();
				bool flag = cubemap == null;
				if (flag)
				{
					throw new ArgumentException("RenderSettings.customReflection is currently not referencing a cubemap.");
				}
				return cubemap;
			}
			set
			{
				RenderSettings.customReflectionTexture = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003B934 File Offset: 0x00039B34
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00007A87 File Offset: 0x00005C87
		public static Texture customReflectionTexture
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_customReflectionTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_customReflectionTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00007AA6 File Offset: 0x00005CA6
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00007AB2 File Offset: 0x00005CB2
		public static int reflectionBounces
		{
			get
			{
				return RenderSettings.get_reflectionBouncesDelegateField();
			}
			set
			{
				RenderSettings.set_reflectionBouncesDelegateField(value);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0003B95C File Offset: 0x00039B5C
		public static Cubemap defaultReflection
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_defaultReflectionDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00007ABF File Offset: 0x00005CBF
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00007ACB File Offset: 0x00005CCB
		public static UnityEngine.Rendering.DefaultReflectionMode defaultReflectionMode
		{
			get
			{
				return RenderSettings.get_defaultReflectionModeDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionModeDelegateField(value);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00007AD8 File Offset: 0x00005CD8
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public static int defaultReflectionResolution
		{
			get
			{
				return RenderSettings.get_defaultReflectionResolutionDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionResolutionDelegateField(value);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00007AF1 File Offset: 0x00005CF1
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007AFD File Offset: 0x00005CFD
		public static float haloStrength
		{
			get
			{
				return RenderSettings.get_haloStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_haloStrengthDelegateField(value);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00007B0A File Offset: 0x00005D0A
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00007B16 File Offset: 0x00005D16
		public static float flareStrength
		{
			get
			{
				return RenderSettings.get_flareStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_flareStrengthDelegateField(value);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00007B23 File Offset: 0x00005D23
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00007B2F File Offset: 0x00005D2F
		public static float flareFadeSpeed
		{
			get
			{
				return RenderSettings.get_flareFadeSpeedDelegateField();
			}
			set
			{
				RenderSettings.set_flareFadeSpeedDelegateField(value);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003B984 File Offset: 0x00039B84
		public static Object GetRenderSettings()
		{
			IntPtr intPtr = RenderSettings.GetRenderSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00007B3C File Offset: 0x00005D3C
		public static void Reset()
		{
			RenderSettings.ResetDelegateField();
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00007B48 File Offset: 0x00005D48
		public static void get_fogColor_Injected(out Color ret)
		{
			RenderSettings.get_fogColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00007B55 File Offset: 0x00005D55
		public static void set_fogColor_Injected(ref Color value)
		{
			RenderSettings.set_fogColor_InjectedDelegateField(ref value);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00007B62 File Offset: 0x00005D62
		public static void set_subtractiveShadowColor_Injected(ref Color value)
		{
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField(ref value);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00007B6F File Offset: 0x00005D6F
		public static void set_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 value)
		{
			RenderSettings.set_ambientProbe_InjectedDelegateField(ref value);
		}

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;

		// Token: 0x04000934 RID: 2356
		private static readonly RenderSettings.get_fogStartDistanceDelegate get_fogStartDistanceDelegateField;

		// Token: 0x04000935 RID: 2357
		private static readonly RenderSettings.set_fogStartDistanceDelegate set_fogStartDistanceDelegateField;

		// Token: 0x04000936 RID: 2358
		private static readonly RenderSettings.get_fogEndDistanceDelegate get_fogEndDistanceDelegateField;

		// Token: 0x04000937 RID: 2359
		private static readonly RenderSettings.set_fogEndDistanceDelegate set_fogEndDistanceDelegateField;

		// Token: 0x04000938 RID: 2360
		private static readonly RenderSettings.get_fogModeDelegate get_fogModeDelegateField;

		// Token: 0x04000939 RID: 2361
		private static readonly RenderSettings.set_fogModeDelegate set_fogModeDelegateField;

		// Token: 0x0400093A RID: 2362
		private static readonly RenderSettings.get_fogDensityDelegate get_fogDensityDelegateField;

		// Token: 0x0400093B RID: 2363
		private static readonly RenderSettings.set_fogDensityDelegate set_fogDensityDelegateField;

		// Token: 0x0400093C RID: 2364
		private static readonly RenderSettings.get_ambientModeDelegate get_ambientModeDelegateField;

		// Token: 0x0400093D RID: 2365
		private static readonly RenderSettings.set_ambientIntensityDelegate set_ambientIntensityDelegateField;

		// Token: 0x0400093E RID: 2366
		private static readonly RenderSettings.set_skyboxDelegate set_skyboxDelegateField;

		// Token: 0x0400093F RID: 2367
		private static readonly RenderSettings.get_customReflectionTextureDelegate get_customReflectionTextureDelegateField;

		// Token: 0x04000940 RID: 2368
		private static readonly RenderSettings.set_customReflectionTextureDelegate set_customReflectionTextureDelegateField;

		// Token: 0x04000941 RID: 2369
		private static readonly RenderSettings.set_reflectionIntensityDelegate set_reflectionIntensityDelegateField;

		// Token: 0x04000942 RID: 2370
		private static readonly RenderSettings.get_reflectionBouncesDelegate get_reflectionBouncesDelegateField;

		// Token: 0x04000943 RID: 2371
		private static readonly RenderSettings.set_reflectionBouncesDelegate set_reflectionBouncesDelegateField;

		// Token: 0x04000944 RID: 2372
		private static readonly RenderSettings.get_defaultReflectionDelegate get_defaultReflectionDelegateField;

		// Token: 0x04000945 RID: 2373
		private static readonly RenderSettings.get_defaultReflectionModeDelegate get_defaultReflectionModeDelegateField;

		// Token: 0x04000946 RID: 2374
		private static readonly RenderSettings.set_defaultReflectionModeDelegate set_defaultReflectionModeDelegateField;

		// Token: 0x04000947 RID: 2375
		private static readonly RenderSettings.get_defaultReflectionResolutionDelegate get_defaultReflectionResolutionDelegateField;

		// Token: 0x04000948 RID: 2376
		private static readonly RenderSettings.set_defaultReflectionResolutionDelegate set_defaultReflectionResolutionDelegateField;

		// Token: 0x04000949 RID: 2377
		private static readonly RenderSettings.get_haloStrengthDelegate get_haloStrengthDelegateField;

		// Token: 0x0400094A RID: 2378
		private static readonly RenderSettings.set_haloStrengthDelegate set_haloStrengthDelegateField;

		// Token: 0x0400094B RID: 2379
		private static readonly RenderSettings.get_flareStrengthDelegate get_flareStrengthDelegateField;

		// Token: 0x0400094C RID: 2380
		private static readonly RenderSettings.set_flareStrengthDelegate set_flareStrengthDelegateField;

		// Token: 0x0400094D RID: 2381
		private static readonly RenderSettings.get_flareFadeSpeedDelegate get_flareFadeSpeedDelegateField;

		// Token: 0x0400094E RID: 2382
		private static readonly RenderSettings.set_flareFadeSpeedDelegate set_flareFadeSpeedDelegateField;

		// Token: 0x0400094F RID: 2383
		private static readonly RenderSettings.GetRenderSettingsDelegate GetRenderSettingsDelegateField;

		// Token: 0x04000950 RID: 2384
		private static readonly RenderSettings.ResetDelegate ResetDelegateField;

		// Token: 0x04000951 RID: 2385
		private static readonly RenderSettings.get_fogColor_InjectedDelegate get_fogColor_InjectedDelegateField;

		// Token: 0x04000952 RID: 2386
		private static readonly RenderSettings.set_fogColor_InjectedDelegate set_fogColor_InjectedDelegateField;

		// Token: 0x04000953 RID: 2387
		private static readonly RenderSettings.set_subtractiveShadowColor_InjectedDelegate set_subtractiveShadowColor_InjectedDelegateField;

		// Token: 0x04000954 RID: 2388
		private static readonly RenderSettings.set_ambientProbe_InjectedDelegate set_ambientProbe_InjectedDelegateField;

		// Token: 0x0200066E RID: 1646
		// (Invoke) Token: 0x06003596 RID: 13718
		private delegate float get_fogStartDistanceDelegate();

		// Token: 0x0200066F RID: 1647
		// (Invoke) Token: 0x06003598 RID: 13720
		private delegate void set_fogStartDistanceDelegate(float value);

		// Token: 0x02000670 RID: 1648
		// (Invoke) Token: 0x0600359A RID: 13722
		private delegate float get_fogEndDistanceDelegate();

		// Token: 0x02000671 RID: 1649
		// (Invoke) Token: 0x0600359C RID: 13724
		private delegate void set_fogEndDistanceDelegate(float value);

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x0600359E RID: 13726
		private delegate FogMode get_fogModeDelegate();

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x060035A0 RID: 13728
		private delegate void set_fogModeDelegate(FogMode value);

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x060035A2 RID: 13730
		private delegate float get_fogDensityDelegate();

		// Token: 0x02000675 RID: 1653
		// (Invoke) Token: 0x060035A4 RID: 13732
		private delegate void set_fogDensityDelegate(float value);

		// Token: 0x02000676 RID: 1654
		// (Invoke) Token: 0x060035A6 RID: 13734
		private delegate UnityEngine.Rendering.AmbientMode get_ambientModeDelegate();

		// Token: 0x02000677 RID: 1655
		// (Invoke) Token: 0x060035A8 RID: 13736
		private delegate void set_ambientIntensityDelegate(float value);

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x060035AA RID: 13738
		private delegate void set_skyboxDelegate(IntPtr value);

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x060035AC RID: 13740
		private delegate IntPtr get_customReflectionTextureDelegate();

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x060035AE RID: 13742
		private delegate void set_customReflectionTextureDelegate(IntPtr value);

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x060035B0 RID: 13744
		private delegate void set_reflectionIntensityDelegate(float value);

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x060035B2 RID: 13746
		private delegate int get_reflectionBouncesDelegate();

		// Token: 0x0200067D RID: 1661
		// (Invoke) Token: 0x060035B4 RID: 13748
		private delegate void set_reflectionBouncesDelegate(int value);

		// Token: 0x0200067E RID: 1662
		// (Invoke) Token: 0x060035B6 RID: 13750
		private delegate IntPtr get_defaultReflectionDelegate();

		// Token: 0x0200067F RID: 1663
		// (Invoke) Token: 0x060035B8 RID: 13752
		private delegate UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionModeDelegate();

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x060035BA RID: 13754
		private delegate void set_defaultReflectionModeDelegate(UnityEngine.Rendering.DefaultReflectionMode value);

		// Token: 0x02000681 RID: 1665
		// (Invoke) Token: 0x060035BC RID: 13756
		private delegate int get_defaultReflectionResolutionDelegate();

		// Token: 0x02000682 RID: 1666
		// (Invoke) Token: 0x060035BE RID: 13758
		private delegate void set_defaultReflectionResolutionDelegate(int value);

		// Token: 0x02000683 RID: 1667
		// (Invoke) Token: 0x060035C0 RID: 13760
		private delegate float get_haloStrengthDelegate();

		// Token: 0x02000684 RID: 1668
		// (Invoke) Token: 0x060035C2 RID: 13762
		private delegate void set_haloStrengthDelegate(float value);

		// Token: 0x02000685 RID: 1669
		// (Invoke) Token: 0x060035C4 RID: 13764
		private delegate float get_flareStrengthDelegate();

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x060035C6 RID: 13766
		private delegate void set_flareStrengthDelegate(float value);

		// Token: 0x02000687 RID: 1671
		// (Invoke) Token: 0x060035C8 RID: 13768
		private delegate float get_flareFadeSpeedDelegate();

		// Token: 0x02000688 RID: 1672
		// (Invoke) Token: 0x060035CA RID: 13770
		private delegate void set_flareFadeSpeedDelegate(float value);

		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x060035CC RID: 13772
		private delegate IntPtr GetRenderSettingsDelegate();

		// Token: 0x0200068A RID: 1674
		// (Invoke) Token: 0x060035CE RID: 13774
		private delegate void ResetDelegate();

		// Token: 0x0200068B RID: 1675
		// (Invoke) Token: 0x060035D0 RID: 13776
		private delegate void get_fogColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200068C RID: 1676
		// (Invoke) Token: 0x060035D2 RID: 13778
		private delegate void set_fogColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200068D RID: 1677
		// (Invoke) Token: 0x060035D4 RID: 13780
		private delegate void set_subtractiveShadowColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200068E RID: 1678
		// (Invoke) Token: 0x060035D6 RID: 13782
		private delegate void set_ambientProbe_InjectedDelegate(IntPtr value);
	}
}
