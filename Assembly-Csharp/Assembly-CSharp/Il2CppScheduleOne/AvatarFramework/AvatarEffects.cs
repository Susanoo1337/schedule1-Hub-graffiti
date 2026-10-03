using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000495 RID: 1173
	public class AvatarEffects : MonoBehaviour
	{
		// Token: 0x06006AB9 RID: 27321 RVA: 0x001ECDE0 File Offset: 0x001EAFE0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEffects()
		{
			Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr);
			AvatarEffects.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "Avatar");
			AvatarEffects.NativeFieldInfoPtr_StinkParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "StinkParticles");
			AvatarEffects.NativeFieldInfoPtr_VomitParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitParticles");
			AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadPoofParticles");
			AvatarEffects.NativeFieldInfoPtr_FartParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartParticles");
			AvatarEffects.NativeFieldInfoPtr_AntiGravParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AntiGravParticles");
			AvatarEffects.NativeFieldInfoPtr_FireParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireParticles");
			AvatarEffects.NativeFieldInfoPtr_FireLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireLight");
			AvatarEffects.NativeFieldInfoPtr_FoggyEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FoggyEffects");
			AvatarEffects.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadBone");
			AvatarEffects.NativeFieldInfoPtr_NeckBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckBone");
			AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "MirrorEffectsTo");
			AvatarEffects.NativeFieldInfoPtr_ZapParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapParticles");
			AvatarEffects.NativeFieldInfoPtr_CountdownExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "CountdownExplosion");
			AvatarEffects.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ObjectsToCull");
			AvatarEffects.NativeFieldInfoPtr_DisableHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "DisableHead");
			AvatarEffects.NativeFieldInfoPtr_GurgleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "GurgleSound");
			AvatarEffects.NativeFieldInfoPtr_VomitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitSound");
			AvatarEffects.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "PoofSound");
			AvatarEffects.NativeFieldInfoPtr_FartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartSound");
			AvatarEffects.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireSound");
			AvatarEffects.NativeFieldInfoPtr_ZapSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapSound");
			AvatarEffects.NativeFieldInfoPtr_ZapLoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapLoopSound");
			AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalWeightController");
			AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalGenderController");
			AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "SkinColorSmoother");
			AvatarEffects.NativeFieldInfoPtr_laxativeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "laxativeEnabled");
			AvatarEffects.NativeFieldInfoPtr_currentEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "currentEmission");
			AvatarEffects.NativeFieldInfoPtr_targetEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "targetEmission");
			AvatarEffects.NativeFieldInfoPtr_isCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "isCulled");
			AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677270);
			AvatarEffects.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677271);
			AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677272);
			AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677273);
			AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677274);
			AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677275);
			AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677276);
			AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677277);
			AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677278);
			AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677279);
			AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677280);
			AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677281);
			AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677282);
			AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677283);
			AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677284);
			AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677285);
			AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677286);
			AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677287);
			AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677288);
			AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677289);
			AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677290);
			AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677291);
			AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677292);
			AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677293);
			AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677294);
			AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677295);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677296);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677297);
			AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677298);
			AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677299);
			AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677300);
			AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677301);
			AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677302);
			AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677303);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677304);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100677305);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x001ED360 File Offset: 0x001EB560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219983, XrefRangeEnd = 220006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x001ED394 File Offset: 0x001EB594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220006, XrefRangeEnd = 220050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x001ED3C8 File Offset: 0x001EB5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220050, XrefRangeEnd = 220052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffectsCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x001ED408 File Offset: 0x001EB608
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220058, RefRangeEnd = 220063, XrefRangeStart = 220052, XrefRangeEnd = 220058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStinkParticlesActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x001ED454 File Offset: 0x001EB654
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 220073, RefRangeEnd = 220080, XrefRangeStart = 220063, XrefRangeEnd = 220073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSick(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x001ED494 File Offset: 0x001EB694
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220086, RefRangeEnd = 220091, XrefRangeStart = 220080, XrefRangeEnd = 220086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAntiGrav(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x001ED4E0 File Offset: 0x001EB6E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220097, RefRangeEnd = 220102, XrefRangeStart = 220091, XrefRangeEnd = 220097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoggy(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x001ED52C File Offset: 0x001EB72C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220110, RefRangeEnd = 220113, XrefRangeStart = 220102, XrefRangeEnd = 220110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VanishHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x001ED56C File Offset: 0x001EB76C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220124, RefRangeEnd = 220130, XrefRangeStart = 220113, XrefRangeEnd = 220124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZapped(bool zapped, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zapped;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x001ED5B8 File Offset: 0x001EB7B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220138, RefRangeEnd = 220141, XrefRangeStart = 220130, XrefRangeEnd = 220138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x001ED5F8 File Offset: 0x001EB7F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220158, RefRangeEnd = 220161, XrefRangeStart = 220141, XrefRangeEnd = 220158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001ED644 File Offset: 0x001EB844
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220165, RefRangeEnd = 220168, XrefRangeStart = 220161, XrefRangeEnd = 220165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x001ED684 File Offset: 0x001EB884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220172, RefRangeEnd = 220176, XrefRangeStart = 220168, XrefRangeEnd = 220172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x001ED6E0 File Offset: 0x001EB8E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220180, RefRangeEnd = 220186, XrefRangeStart = 220176, XrefRangeEnd = 220180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x001ED720 File Offset: 0x001EB920
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220190, RefRangeEnd = 220195, XrefRangeStart = 220186, XrefRangeEnd = 220190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x001ED77C File Offset: 0x001EB97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220209, RefRangeEnd = 220212, XrefRangeStart = 220195, XrefRangeEnd = 220209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x001ED7BC File Offset: 0x001EB9BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220214, RefRangeEnd = 220217, XrefRangeStart = 220212, XrefRangeEnd = 220214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x001ED7FC File Offset: 0x001EB9FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220224, RefRangeEnd = 220229, XrefRangeStart = 220217, XrefRangeEnd = 220224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFireActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x001ED848 File Offset: 0x001EBA48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220237, RefRangeEnd = 220242, XrefRangeStart = 220229, XrefRangeEnd = 220237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBigHeadActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x001ED894 File Offset: 0x001EBA94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220254, RefRangeEnd = 220259, XrefRangeStart = 220242, XrefRangeEnd = 220254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGiraffeActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x001ED8E0 File Offset: 0x001EBAE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220272, RefRangeEnd = 220277, XrefRangeStart = 220259, XrefRangeEnd = 220272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x001ED92C File Offset: 0x001EBB2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220290, RefRangeEnd = 220295, XrefRangeStart = 220277, XrefRangeEnd = 220290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSicklySkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x001ED96C File Offset: 0x001EBB6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220302, RefRangeEnd = 220305, XrefRangeStart = 220295, XrefRangeEnd = 220302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultSkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x001ED9AC File Offset: 0x001EBBAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220315, RefRangeEnd = 220320, XrefRangeStart = 220305, XrefRangeEnd = 220315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGenderInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x001ED9F8 File Offset: 0x001EBBF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220323, RefRangeEnd = 220326, XrefRangeStart = 220320, XrefRangeEnd = 220323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x001EDA64 File Offset: 0x001EBC64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220329, RefRangeEnd = 220332, XrefRangeStart = 220326, XrefRangeEnd = 220329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x001EDAB4 File Offset: 0x001EBCB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220334, RefRangeEnd = 220337, XrefRangeStart = 220332, XrefRangeEnd = 220334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOn(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x001EDB00 File Offset: 0x001EBD00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220339, RefRangeEnd = 220342, XrefRangeStart = 220337, XrefRangeEnd = 220339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOff(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x001EDB40 File Offset: 0x001EBD40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220345, RefRangeEnd = 220348, XrefRangeStart = 220342, XrefRangeEnd = 220345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x001EDB80 File Offset: 0x001EBD80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220351, RefRangeEnd = 220354, XrefRangeStart = 220348, XrefRangeEnd = 220351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x001EDBC0 File Offset: 0x001EBDC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220373, RefRangeEnd = 220378, XrefRangeStart = 220354, XrefRangeEnd = 220373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCyclopean(bool enabled, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x001EDC0C File Offset: 0x001EBE0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220403, RefRangeEnd = 220408, XrefRangeStart = 220378, XrefRangeEnd = 220403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZombified(bool zombified, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zombified;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x001EDC58 File Offset: 0x001EBE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220408, XrefRangeEnd = 220409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x001EDC94 File Offset: 0x001EBE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220409, XrefRangeEnd = 220410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x001EDCC8 File Offset: 0x001EBEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220410, XrefRangeEnd = 220415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x001EDD08 File Offset: 0x001EBF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220415, XrefRangeEnd = 220420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x0003230C File Offset: 0x0003050C
		public AvatarEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06006ADF RID: 27359 RVA: 0x001EDD48 File Offset: 0x001EBF48
		// (set) Token: 0x06006AE0 RID: 27360 RVA: 0x00032315 File Offset: 0x00030515
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06006AE1 RID: 27361 RVA: 0x001EDD78 File Offset: 0x001EBF78
		// (set) Token: 0x06006AE2 RID: 27362 RVA: 0x00032334 File Offset: 0x00030534
		public unsafe Il2CppReferenceArray<ParticleSystem> StinkParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06006AE3 RID: 27363 RVA: 0x001EDDA8 File Offset: 0x001EBFA8
		// (set) Token: 0x06006AE4 RID: 27364 RVA: 0x00032353 File Offset: 0x00030553
		public unsafe ParticleSystem VomitParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x001EDDD8 File Offset: 0x001EBFD8
		// (set) Token: 0x06006AE6 RID: 27366 RVA: 0x00032372 File Offset: 0x00030572
		public unsafe ParticleSystem HeadPoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06006AE7 RID: 27367 RVA: 0x001EDE08 File Offset: 0x001EC008
		// (set) Token: 0x06006AE8 RID: 27368 RVA: 0x00032391 File Offset: 0x00030591
		public unsafe ParticleSystem FartParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06006AE9 RID: 27369 RVA: 0x001EDE38 File Offset: 0x001EC038
		// (set) Token: 0x06006AEA RID: 27370 RVA: 0x000323B0 File Offset: 0x000305B0
		public unsafe ParticleSystem AntiGravParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x001EDE68 File Offset: 0x001EC068
		// (set) Token: 0x06006AEC RID: 27372 RVA: 0x000323CF File Offset: 0x000305CF
		public unsafe ParticleSystem FireParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x001EDE98 File Offset: 0x001EC098
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x000323EE File Offset: 0x000305EE
		public unsafe OptimizedLight FireLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x001EDEC8 File Offset: 0x001EC0C8
		// (set) Token: 0x06006AF0 RID: 27376 RVA: 0x0003240D File Offset: 0x0003060D
		public unsafe ParticleSystem FoggyEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x001EDEF8 File Offset: 0x001EC0F8
		// (set) Token: 0x06006AF2 RID: 27378 RVA: 0x0003242C File Offset: 0x0003062C
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x001EDF28 File Offset: 0x001EC128
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x0003244B File Offset: 0x0003064B
		public unsafe Transform NeckBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x001EDF58 File Offset: 0x001EC158
		// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x0003246A File Offset: 0x0003066A
		public unsafe Il2CppReferenceArray<AvatarEffects> MirrorEffectsTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarEffects>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x001EDF88 File Offset: 0x001EC188
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x00032489 File Offset: 0x00030689
		public unsafe ParticleSystem ZapParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x001EDFB8 File Offset: 0x001EC1B8
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x000324A8 File Offset: 0x000306A8
		public unsafe CountdownExplosion CountdownExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x001EDFE8 File Offset: 0x001EC1E8
		// (set) Token: 0x06006AFC RID: 27388 RVA: 0x000324C7 File Offset: 0x000306C7
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x001EE018 File Offset: 0x001EC218
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x000324E6 File Offset: 0x000306E6
		public unsafe bool DisableHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead)) = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x001EE040 File Offset: 0x001EC240
		// (set) Token: 0x06006B00 RID: 27392 RVA: 0x00032501 File Offset: 0x00030701
		public unsafe AudioSourceController GurgleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x001EE070 File Offset: 0x001EC270
		// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00032520 File Offset: 0x00030720
		public unsafe AudioSourceController VomitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006B03 RID: 27395 RVA: 0x001EE0A0 File Offset: 0x001EC2A0
		// (set) Token: 0x06006B04 RID: 27396 RVA: 0x0003253F File Offset: 0x0003073F
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x001EE0D0 File Offset: 0x001EC2D0
		// (set) Token: 0x06006B06 RID: 27398 RVA: 0x0003255E File Offset: 0x0003075E
		public unsafe AudioSourceController FartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06006B07 RID: 27399 RVA: 0x001EE100 File Offset: 0x001EC300
		// (set) Token: 0x06006B08 RID: 27400 RVA: 0x0003257D File Offset: 0x0003077D
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x001EE130 File Offset: 0x001EC330
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x0003259C File Offset: 0x0003079C
		public unsafe AudioSourceController ZapSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x001EE160 File Offset: 0x001EC360
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x000325BB File Offset: 0x000307BB
		public unsafe AudioSourceController ZapLoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x001EE190 File Offset: 0x001EC390
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x000325DA File Offset: 0x000307DA
		public unsafe FloatSmoother AdditionalWeightController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x001EE1C0 File Offset: 0x001EC3C0
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x000325F9 File Offset: 0x000307F9
		public unsafe FloatSmoother AdditionalGenderController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x001EE1F0 File Offset: 0x001EC3F0
		// (set) Token: 0x06006B12 RID: 27410 RVA: 0x00032618 File Offset: 0x00030818
		public unsafe FloatSmoother HeadSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06006B13 RID: 27411 RVA: 0x001EE220 File Offset: 0x001EC420
		// (set) Token: 0x06006B14 RID: 27412 RVA: 0x00032637 File Offset: 0x00030837
		public unsafe FloatSmoother NeckSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x001EE250 File Offset: 0x001EC450
		// (set) Token: 0x06006B16 RID: 27414 RVA: 0x00032656 File Offset: 0x00030856
		public unsafe ColorSmoother SkinColorSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06006B17 RID: 27415 RVA: 0x001EE280 File Offset: 0x001EC480
		// (set) Token: 0x06006B18 RID: 27416 RVA: 0x00032675 File Offset: 0x00030875
		public unsafe bool laxativeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled)) = value;
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06006B19 RID: 27417 RVA: 0x001EE2A8 File Offset: 0x001EC4A8
		// (set) Token: 0x06006B1A RID: 27418 RVA: 0x00032690 File Offset: 0x00030890
		public unsafe Color currentEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission)) = value;
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x001EE2D0 File Offset: 0x001EC4D0
		// (set) Token: 0x06006B1C RID: 27420 RVA: 0x000326AB File Offset: 0x000308AB
		public unsafe Color targetEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission)) = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x001EE2F8 File Offset: 0x001EC4F8
		// (set) Token: 0x06006B1E RID: 27422 RVA: 0x000326C6 File Offset: 0x000308C6
		public unsafe bool isCulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled)) = value;
			}
		}

		// Token: 0x0400496F RID: 18799
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04004970 RID: 18800
		private static readonly IntPtr NativeFieldInfoPtr_StinkParticles;

		// Token: 0x04004971 RID: 18801
		private static readonly IntPtr NativeFieldInfoPtr_VomitParticles;

		// Token: 0x04004972 RID: 18802
		private static readonly IntPtr NativeFieldInfoPtr_HeadPoofParticles;

		// Token: 0x04004973 RID: 18803
		private static readonly IntPtr NativeFieldInfoPtr_FartParticles;

		// Token: 0x04004974 RID: 18804
		private static readonly IntPtr NativeFieldInfoPtr_AntiGravParticles;

		// Token: 0x04004975 RID: 18805
		private static readonly IntPtr NativeFieldInfoPtr_FireParticles;

		// Token: 0x04004976 RID: 18806
		private static readonly IntPtr NativeFieldInfoPtr_FireLight;

		// Token: 0x04004977 RID: 18807
		private static readonly IntPtr NativeFieldInfoPtr_FoggyEffects;

		// Token: 0x04004978 RID: 18808
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04004979 RID: 18809
		private static readonly IntPtr NativeFieldInfoPtr_NeckBone;

		// Token: 0x0400497A RID: 18810
		private static readonly IntPtr NativeFieldInfoPtr_MirrorEffectsTo;

		// Token: 0x0400497B RID: 18811
		private static readonly IntPtr NativeFieldInfoPtr_ZapParticles;

		// Token: 0x0400497C RID: 18812
		private static readonly IntPtr NativeFieldInfoPtr_CountdownExplosion;

		// Token: 0x0400497D RID: 18813
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x0400497E RID: 18814
		private static readonly IntPtr NativeFieldInfoPtr_DisableHead;

		// Token: 0x0400497F RID: 18815
		private static readonly IntPtr NativeFieldInfoPtr_GurgleSound;

		// Token: 0x04004980 RID: 18816
		private static readonly IntPtr NativeFieldInfoPtr_VomitSound;

		// Token: 0x04004981 RID: 18817
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04004982 RID: 18818
		private static readonly IntPtr NativeFieldInfoPtr_FartSound;

		// Token: 0x04004983 RID: 18819
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04004984 RID: 18820
		private static readonly IntPtr NativeFieldInfoPtr_ZapSound;

		// Token: 0x04004985 RID: 18821
		private static readonly IntPtr NativeFieldInfoPtr_ZapLoopSound;

		// Token: 0x04004986 RID: 18822
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalWeightController;

		// Token: 0x04004987 RID: 18823
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalGenderController;

		// Token: 0x04004988 RID: 18824
		private static readonly IntPtr NativeFieldInfoPtr_HeadSizeBoost;

		// Token: 0x04004989 RID: 18825
		private static readonly IntPtr NativeFieldInfoPtr_NeckSizeBoost;

		// Token: 0x0400498A RID: 18826
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorSmoother;

		// Token: 0x0400498B RID: 18827
		private static readonly IntPtr NativeFieldInfoPtr_laxativeEnabled;

		// Token: 0x0400498C RID: 18828
		private static readonly IntPtr NativeFieldInfoPtr_currentEmission;

		// Token: 0x0400498D RID: 18829
		private static readonly IntPtr NativeFieldInfoPtr_targetEmission;

		// Token: 0x0400498E RID: 18830
		private static readonly IntPtr NativeFieldInfoPtr_isCulled;

		// Token: 0x0400498F RID: 18831
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004990 RID: 18832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04004991 RID: 18833
		private static readonly IntPtr NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0;

		// Token: 0x04004992 RID: 18834
		private static readonly IntPtr NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004993 RID: 18835
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0;

		// Token: 0x04004994 RID: 18836
		private static readonly IntPtr NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004995 RID: 18837
		private static readonly IntPtr NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004996 RID: 18838
		private static readonly IntPtr NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0;

		// Token: 0x04004997 RID: 18839
		private static readonly IntPtr NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004998 RID: 18840
		private static readonly IntPtr NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0;

		// Token: 0x04004999 RID: 18841
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0;

		// Token: 0x0400499A RID: 18842
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0;

		// Token: 0x0400499B RID: 18843
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x0400499C RID: 18844
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0;

		// Token: 0x0400499D RID: 18845
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0;

		// Token: 0x0400499E RID: 18846
		private static readonly IntPtr NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0;

		// Token: 0x0400499F RID: 18847
		private static readonly IntPtr NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0;

		// Token: 0x040049A0 RID: 18848
		private static readonly IntPtr NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049A1 RID: 18849
		private static readonly IntPtr NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049A2 RID: 18850
		private static readonly IntPtr NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049A3 RID: 18851
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049A4 RID: 18852
		private static readonly IntPtr NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0;

		// Token: 0x040049A5 RID: 18853
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0;

		// Token: 0x040049A6 RID: 18854
		private static readonly IntPtr NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049A7 RID: 18855
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0;

		// Token: 0x040049A8 RID: 18856
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0;

		// Token: 0x040049A9 RID: 18857
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0;

		// Token: 0x040049AA RID: 18858
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0;

		// Token: 0x040049AB RID: 18859
		private static readonly IntPtr NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x040049AC RID: 18860
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x040049AD RID: 18861
		private static readonly IntPtr NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049AE RID: 18862
		private static readonly IntPtr NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0;

		// Token: 0x040049AF RID: 18863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049B0 RID: 18864
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Void_0;

		// Token: 0x040049B1 RID: 18865
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040049B2 RID: 18866
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<EnableLaxative>g__Routine|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600E821 RID: 59425 RVA: 0x00388A5C File Offset: 0x00386C5C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<EnableLaxative>g__Routine|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677306);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677307);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677308);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677309);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677310);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100677311);
			}

			// Token: 0x0600E822 RID: 59426 RVA: 0x00388B3C File Offset: 0x00386D3C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E823 RID: 59427 RVA: 0x00388B84 File Offset: 0x00386D84
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E824 RID: 59428 RVA: 0x00388BB8 File Offset: 0x00386DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219959, XrefRangeEnd = 219967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004671 RID: 18033
			// (get) Token: 0x0600E825 RID: 59429 RVA: 0x00388BF4 File Offset: 0x00386DF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E826 RID: 59430 RVA: 0x00388C34 File Offset: 0x00386E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219967, XrefRangeEnd = 219972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004672 RID: 18034
			// (get) Token: 0x0600E827 RID: 59431 RVA: 0x00388C68 File Offset: 0x00386E68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E828 RID: 59432 RVA: 0x0006D78C File Offset: 0x0006B98C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700466E RID: 18030
			// (get) Token: 0x0600E829 RID: 59433 RVA: 0x00388CA8 File Offset: 0x00386EA8
			// (set) Token: 0x0600E82A RID: 59434 RVA: 0x0006D795 File Offset: 0x0006B995
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700466F RID: 18031
			// (get) Token: 0x0600E82B RID: 59435 RVA: 0x00388CD0 File Offset: 0x00386ED0
			// (set) Token: 0x0600E82C RID: 59436 RVA: 0x0006D7B0 File Offset: 0x0006B9B0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004670 RID: 18032
			// (get) Token: 0x0600E82D RID: 59437 RVA: 0x00388D00 File Offset: 0x00386F00
			// (set) Token: 0x0600E82E RID: 59438 RVA: 0x0006D7CF File Offset: 0x0006B9CF
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D7A RID: 40314
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D7B RID: 40315
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D7C RID: 40316
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D7D RID: 40317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D7E RID: 40318
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D7F RID: 40319
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D80 RID: 40320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D81 RID: 40321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D82 RID: 40322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B61 RID: 2913
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<TriggerSick>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600E82F RID: 59439 RVA: 0x00388D30 File Offset: 0x00386F30
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<TriggerSick>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677312);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677313);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677314);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677315);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677316);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100677317);
			}

			// Token: 0x0600E830 RID: 59440 RVA: 0x00388E10 File Offset: 0x00387010
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E831 RID: 59441 RVA: 0x00388E58 File Offset: 0x00387058
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E832 RID: 59442 RVA: 0x00388E8C File Offset: 0x0038708C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219972, XrefRangeEnd = 219978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004676 RID: 18038
			// (get) Token: 0x0600E833 RID: 59443 RVA: 0x00388EC8 File Offset: 0x003870C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E834 RID: 59444 RVA: 0x00388F08 File Offset: 0x00387108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219978, XrefRangeEnd = 219983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004677 RID: 18039
			// (get) Token: 0x0600E835 RID: 59445 RVA: 0x00388F3C File Offset: 0x0038713C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E836 RID: 59446 RVA: 0x0006D7EE File Offset: 0x0006B9EE
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004673 RID: 18035
			// (get) Token: 0x0600E837 RID: 59447 RVA: 0x00388F7C File Offset: 0x0038717C
			// (set) Token: 0x0600E838 RID: 59448 RVA: 0x0006D7F7 File Offset: 0x0006B9F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004674 RID: 18036
			// (get) Token: 0x0600E839 RID: 59449 RVA: 0x00388FA4 File Offset: 0x003871A4
			// (set) Token: 0x0600E83A RID: 59450 RVA: 0x0006D812 File Offset: 0x0006BA12
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004675 RID: 18037
			// (get) Token: 0x0600E83B RID: 59451 RVA: 0x00388FD4 File Offset: 0x003871D4
			// (set) Token: 0x0600E83C RID: 59452 RVA: 0x0006D831 File Offset: 0x0006BA31
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D83 RID: 40323
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D84 RID: 40324
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D85 RID: 40325
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D86 RID: 40326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D87 RID: 40327
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D88 RID: 40328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D89 RID: 40329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D8A RID: 40330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D8B RID: 40331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
