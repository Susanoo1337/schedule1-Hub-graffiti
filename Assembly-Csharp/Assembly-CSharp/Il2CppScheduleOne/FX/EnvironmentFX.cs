using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppVolumetricFogAndMist2;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000386 RID: 902
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x06004F98 RID: 20376 RVA: 0x0018D7A8 File Offset: 0x0018B9A8
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentFX()
		{
			Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "EnvironmentFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr);
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFog");
			EnvironmentFX.NativeFieldInfoPtr_SunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "SunLight");
			EnvironmentFX.NativeFieldInfoPtr_MoonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "MoonLight");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogColor");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogDirectionalIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogSaturationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogSaturationMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "godRayIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_contrastCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contrastCurve");
			EnvironmentFX.NativeFieldInfoPtr_contractMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contractMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_saturationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationCurve");
			EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_grassMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassMat");
			EnvironmentFX.NativeFieldInfoPtr_grassColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeMat");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeColorCurve");
			EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "environmentalBrightnessCurve");
			EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "bloomThreshholdCurve");
			EnvironmentFX.NativeFieldInfoPtr__environmentScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_environmentScrollSpeed");
			EnvironmentFX.NativeFieldInfoPtr__testPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_testPercentage");
			EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "FogEndDistanceController");
			EnvironmentFX.NativeFieldInfoPtr__scrollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_scrollTime");
			EnvironmentFX.NativeFieldInfoPtr__scrollValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_scrollValue");
			EnvironmentFX.NativeFieldInfoPtr__scrollTActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_scrollTActive");
			EnvironmentFX.NativeFieldInfoPtr__defaultDistantTreeMatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_defaultDistantTreeMatColor");
			EnvironmentFX.NativeFieldInfoPtr__defaultGrassMatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "_defaultGrassMatColor");
			EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673663);
			EnvironmentFX.NativeMethodInfoPtr_get_FogEndDistanceMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673664);
			EnvironmentFX.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673665);
			EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673666);
			EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673667);
			EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673668);
			EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673669);
			EnvironmentFX.NativeMethodInfoPtr_SetEnvironmentScrollingActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673670);
			EnvironmentFX.NativeMethodInfoPtr_SetEnvironmentScrollingSpeedByPercentage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673671);
			EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673672);
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x0018DAF8 File Offset: 0x0018BCF8
		public unsafe float normalizedEnvironmentalBrightness
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 178454, RefRangeEnd = 178457, XrefRangeStart = 178447, XrefRangeEnd = 178454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x0018DB34 File Offset: 0x0018BD34
		public unsafe float FogEndDistanceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_get_FogEndDistanceMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x0018DB70 File Offset: 0x0018BD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178457, XrefRangeEnd = 178480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x0018DBAC File Offset: 0x0018BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178480, XrefRangeEnd = 178484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x0018DBE8 File Offset: 0x0018BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178484, XrefRangeEnd = 178487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x0018DC24 File Offset: 0x0018BE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178487, XrefRangeEnd = 178491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x0018DC58 File Offset: 0x0018BE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178558, RefRangeEnd = 178559, XrefRangeStart = 178491, XrefRangeEnd = 178558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x0018DC8C File Offset: 0x0018BE8C
		[CallerCount(0)]
		public unsafe void SetEnvironmentScrollingActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_SetEnvironmentScrollingActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x0018DCCC File Offset: 0x0018BECC
		[CallerCount(0)]
		public unsafe void SetEnvironmentScrollingSpeedByPercentage(float percentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_SetEnvironmentScrollingSpeedByPercentage_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x0018DD0C File Offset: 0x0018BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178559, XrefRangeEnd = 178562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00025F7C File Offset: 0x0002417C
		public EnvironmentFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0018DD48 File Offset: 0x0018BF48
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x00025F85 File Offset: 0x00024185
		public unsafe VolumetricFog VolumetricFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x0018DD78 File Offset: 0x0018BF78
		// (set) Token: 0x06004FA7 RID: 20391 RVA: 0x00025FA4 File Offset: 0x000241A4
		public unsafe Light SunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x0018DDA8 File Offset: 0x0018BFA8
		// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x00025FC3 File Offset: 0x000241C3
		public unsafe Light MoonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06004FAA RID: 20394 RVA: 0x0018DDD8 File Offset: 0x0018BFD8
		// (set) Token: 0x06004FAB RID: 20395 RVA: 0x00025FE2 File Offset: 0x000241E2
		public unsafe Gradient HeightFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06004FAC RID: 20396 RVA: 0x0018DE08 File Offset: 0x0018C008
		// (set) Token: 0x06004FAD RID: 20397 RVA: 0x00026001 File Offset: 0x00024201
		public unsafe AnimationCurve HeightFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x0018DE38 File Offset: 0x0018C038
		// (set) Token: 0x06004FAF RID: 20399 RVA: 0x00026020 File Offset: 0x00024220
		public unsafe float HeightFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x0018DE60 File Offset: 0x0018C060
		// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x0002603B File Offset: 0x0002423B
		public unsafe AnimationCurve HeightFogDirectionalIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x0018DE90 File Offset: 0x0018C090
		// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x0002605A File Offset: 0x0002425A
		public unsafe AnimationCurve VolumetricFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x0018DEC0 File Offset: 0x0018C0C0
		// (set) Token: 0x06004FB5 RID: 20405 RVA: 0x00026079 File Offset: 0x00024279
		public unsafe float VolumetricFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x0018DEE8 File Offset: 0x0018C0E8
		// (set) Token: 0x06004FB7 RID: 20407 RVA: 0x00026094 File Offset: 0x00024294
		public unsafe float VolumetricFogSaturationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogSaturationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogSaturationMultiplier)) = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x0018DF10 File Offset: 0x0018C110
		// (set) Token: 0x06004FB9 RID: 20409 RVA: 0x000260AF File Offset: 0x000242AF
		public unsafe float fogEndDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier)) = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x0018DF38 File Offset: 0x0018C138
		// (set) Token: 0x06004FBB RID: 20411 RVA: 0x000260CA File Offset: 0x000242CA
		public unsafe AnimationCurve godRayIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x0018DF68 File Offset: 0x0018C168
		// (set) Token: 0x06004FBD RID: 20413 RVA: 0x000260E9 File Offset: 0x000242E9
		public unsafe AnimationCurve contrastCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x0018DF98 File Offset: 0x0018C198
		// (set) Token: 0x06004FBF RID: 20415 RVA: 0x00026108 File Offset: 0x00024308
		public unsafe float contractMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier)) = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x0018DFC0 File Offset: 0x0018C1C0
		// (set) Token: 0x06004FC1 RID: 20417 RVA: 0x00026123 File Offset: 0x00024323
		public unsafe AnimationCurve saturationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06004FC2 RID: 20418 RVA: 0x0018DFF0 File Offset: 0x0018C1F0
		// (set) Token: 0x06004FC3 RID: 20419 RVA: 0x00026142 File Offset: 0x00024342
		public unsafe float saturationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier)) = value;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x0018E018 File Offset: 0x0018C218
		// (set) Token: 0x06004FC5 RID: 20421 RVA: 0x0002615D File Offset: 0x0002435D
		public unsafe Material grassMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x0018E048 File Offset: 0x0018C248
		// (set) Token: 0x06004FC7 RID: 20423 RVA: 0x0002617C File Offset: 0x0002437C
		public unsafe Gradient grassColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x0018E078 File Offset: 0x0018C278
		// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x0002619B File Offset: 0x0002439B
		public unsafe Material distanceTreeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x0018E0A8 File Offset: 0x0018C2A8
		// (set) Token: 0x06004FCB RID: 20427 RVA: 0x000261BA File Offset: 0x000243BA
		public unsafe AnimationCurve distanceTreeColorCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x0018E0D8 File Offset: 0x0018C2D8
		// (set) Token: 0x06004FCD RID: 20429 RVA: 0x000261D9 File Offset: 0x000243D9
		public unsafe AnimationCurve environmentalBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x0018E108 File Offset: 0x0018C308
		// (set) Token: 0x06004FCF RID: 20431 RVA: 0x000261F8 File Offset: 0x000243F8
		public unsafe AnimationCurve bloomThreshholdCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x0018E138 File Offset: 0x0018C338
		// (set) Token: 0x06004FD1 RID: 20433 RVA: 0x00026217 File Offset: 0x00024417
		public unsafe float _environmentScrollSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__environmentScrollSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__environmentScrollSpeed)) = value;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x0018E160 File Offset: 0x0018C360
		// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x00026232 File Offset: 0x00024432
		public unsafe float _testPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__testPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__testPercentage)) = value;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x0018E188 File Offset: 0x0018C388
		// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x0002624D File Offset: 0x0002444D
		public unsafe FloatSmoother FogEndDistanceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x0018E1B8 File Offset: 0x0018C3B8
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x0002626C File Offset: 0x0002446C
		public unsafe float _scrollTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollTime)) = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x0018E1E0 File Offset: 0x0018C3E0
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x00026287 File Offset: 0x00024487
		public unsafe float _scrollValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollValue)) = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x0018E208 File Offset: 0x0018C408
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x000262A2 File Offset: 0x000244A2
		public unsafe bool _scrollTActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollTActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__scrollTActive)) = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0018E230 File Offset: 0x0018C430
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x000262BD File Offset: 0x000244BD
		public unsafe Color _defaultDistantTreeMatColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__defaultDistantTreeMatColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__defaultDistantTreeMatColor)) = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x0018E258 File Offset: 0x0018C458
		// (set) Token: 0x06004FDF RID: 20447 RVA: 0x000262D8 File Offset: 0x000244D8
		public unsafe Color _defaultGrassMatColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__defaultGrassMatColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr__defaultGrassMatColor)) = value;
			}
		}

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFog;

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeFieldInfoPtr_SunLight;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeFieldInfoPtr_MoonLight;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogColor;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityCurve;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityMultiplier;

		// Token: 0x040036A1 RID: 13985
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve;

		// Token: 0x040036A2 RID: 13986
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityCurve;

		// Token: 0x040036A3 RID: 13987
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityMultiplier;

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogSaturationMultiplier;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceMultiplier;

		// Token: 0x040036A6 RID: 13990
		private static readonly IntPtr NativeFieldInfoPtr_godRayIntensityCurve;

		// Token: 0x040036A7 RID: 13991
		private static readonly IntPtr NativeFieldInfoPtr_contrastCurve;

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeFieldInfoPtr_contractMultiplier;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeFieldInfoPtr_saturationCurve;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeFieldInfoPtr_saturationMultiplier;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeFieldInfoPtr_grassMat;

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeFieldInfoPtr_grassColorGradient;

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeMat;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeColorCurve;

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeFieldInfoPtr_environmentalBrightnessCurve;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeFieldInfoPtr_bloomThreshholdCurve;

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeFieldInfoPtr__environmentScrollSpeed;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeFieldInfoPtr__testPercentage;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeFieldInfoPtr_FogEndDistanceController;

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeFieldInfoPtr__scrollTime;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeFieldInfoPtr__scrollValue;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeFieldInfoPtr__scrollTActive;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeFieldInfoPtr__defaultDistantTreeMatColor;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeFieldInfoPtr__defaultGrassMatColor;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeMethodInfoPtr_get_FogEndDistanceMultiplier_Public_get_Single_0;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeMethodInfoPtr_SetEnvironmentScrollingActive_Public_Void_Boolean_0;

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeMethodInfoPtr_SetEnvironmentScrollingSpeedByPercentage_Public_Void_Single_0;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
