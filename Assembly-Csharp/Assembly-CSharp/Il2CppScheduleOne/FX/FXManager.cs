using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000387 RID: 903
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x06004FE0 RID: 20448 RVA: 0x0018E280 File Offset: 0x0018C480
		// Note: this type is marked as 'beforefieldinit'.
		static FXManager()
		{
			Il2CppClassPointerStore<FXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "FXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager>.NativeClassPtr);
			FXManager.NativeFieldInfoPtr_BulletTrailPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "BulletTrailPoolSize");
			FXManager.NativeFieldInfoPtr_PunchImpactsClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchImpactsClips");
			FXManager.NativeFieldInfoPtr_SlashImpactClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "SlashImpactClips");
			FXManager.NativeFieldInfoPtr_ImpactSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "ImpactSources");
			FXManager.NativeFieldInfoPtr_PunchParticlePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "PunchParticlePrefab");
			FXManager.NativeFieldInfoPtr_BulletTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "BulletTrail");
			FXManager.NativeFieldInfoPtr_bulletTrailPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "bulletTrailPool");
			FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673673);
			FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_IDamageable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673674);
			FXManager.NativeMethodInfoPtr_TryGetBulletTrail_Private_Boolean_byref_TrailRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673675);
			FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673676);
			FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673677);
			FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673678);
			FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_IDamageable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673679);
			FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_IDamageable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673680);
			FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673681);
			FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673682);
			FXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager>.NativeClassPtr, 100673683);
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x0018E418 File Offset: 0x0018C618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178615, XrefRangeEnd = 178635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FXManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x0018E454 File Offset: 0x0018C654
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178665, RefRangeEnd = 178668, XrefRangeStart = 178635, XrefRangeEnd = 178665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateImpactFX(Impact impact, IDamageable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_IDamageable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x0018E4A8 File Offset: 0x0018C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178668, XrefRangeEnd = 178698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetBulletTrail(out TrailRenderer trail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_TryGetBulletTrail_Private_Boolean_byref_TrailRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			trail = ((intPtr4 == 0) ? null : new TrailRenderer(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x0018E508 File Offset: 0x0018C708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178741, RefRangeEnd = 178742, XrefRangeStart = 178698, XrefRangeEnd = 178741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x0018E580 File Offset: 0x0018C780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178775, RefRangeEnd = 178776, XrefRangeStart = 178742, XrefRangeEnd = 178775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x0018E5E0 File Offset: 0x0018C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178776, XrefRangeEnd = 178783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x0018E640 File Offset: 0x0018C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178783, XrefRangeEnd = 178788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetImpactSound(Impact impact, IDamageable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_IDamageable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x0018E6A4 File Offset: 0x0018C8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178788, XrefRangeEnd = 178792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetImpactParticles(Impact impact, IDamageable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_IDamageable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x0018E708 File Offset: 0x0018C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178792, XrefRangeEnd = 178810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x0018E748 File Offset: 0x0018C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178810, XrefRangeEnd = 178811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip GetRandomClip(Il2CppReferenceArray<AudioClip> clips)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x0018E78C File Offset: 0x0018C98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178811, XrefRangeEnd = 178821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x000262F3 File Offset: 0x000244F3
		public FXManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0018E7C8 File Offset: 0x0018C9C8
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x000262FC File Offset: 0x000244FC
		public unsafe static int BulletTrailPoolSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FXManager.NativeFieldInfoPtr_BulletTrailPoolSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FXManager.NativeFieldInfoPtr_BulletTrailPoolSize, (void*)(&value));
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x0018E7E4 File Offset: 0x0018C9E4
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0002630A File Offset: 0x0002450A
		public unsafe Il2CppReferenceArray<AudioClip> PunchImpactsClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchImpactsClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x0018E814 File Offset: 0x0018CA14
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x00026329 File Offset: 0x00024529
		public unsafe Il2CppReferenceArray<AudioClip> SlashImpactClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_SlashImpactClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x0018E844 File Offset: 0x0018CA44
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x00026348 File Offset: 0x00024548
		public unsafe Il2CppReferenceArray<AudioSourceController> ImpactSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_ImpactSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x0018E874 File Offset: 0x0018CA74
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x00026367 File Offset: 0x00024567
		public unsafe GameObject PunchParticlePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_PunchParticlePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x0018E8A4 File Offset: 0x0018CAA4
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x00026386 File Offset: 0x00024586
		public unsafe TrailRenderer BulletTrail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_BulletTrail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x0018E8D4 File Offset: 0x0018CAD4
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x000263A5 File Offset: 0x000245A5
		public unsafe List<TrailRenderer> bulletTrailPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_bulletTrailPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrailRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.NativeFieldInfoPtr_bulletTrailPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeFieldInfoPtr_BulletTrailPoolSize;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeFieldInfoPtr_PunchImpactsClips;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeFieldInfoPtr_SlashImpactClips;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSources;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeFieldInfoPtr_PunchParticlePrefab;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeFieldInfoPtr_BulletTrail;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeFieldInfoPtr_bulletTrailPool;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpactFX_Public_Void_Impact_IDamageable_0;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBulletTrail_Private_Boolean_byref_TrailRenderer_0;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeMethodInfoPtr_CreateBulletTrail_Public_Void_Vector3_Vector3_Single_Single_LayerMask_0;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeMethodInfoPtr_PlayImpact_Private_Void_AudioClip_Vector3_Single_0;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeMethodInfoPtr_PlayParticles_Private_Void_GameObject_Vector3_Quaternion_0;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeMethodInfoPtr_GetImpactSound_Private_AudioClip_Impact_IDamageable_0;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeMethodInfoPtr_GetImpactParticles_Private_GameObject_Impact_IDamageable_0;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Private_Static_AudioClip_Il2CppReferenceArray_1_AudioClip_0;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A8E RID: 2702
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E207 RID: 57863 RVA: 0x00377740 File Offset: 0x00375940
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr);
				FXManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9");
				FXManager.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9__9_0");
				FXManager.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, "<>9__15_0");
				FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100673685);
				FXManager.__c.NativeMethodInfoPtr__TryGetBulletTrail_b__9_0_Internal_Boolean_TrailRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100673686);
				FXManager.__c.NativeMethodInfoPtr__GetSource_b__15_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr, 100673687);
			}

			// Token: 0x0600E208 RID: 57864 RVA: 0x003777E4 File Offset: 0x003759E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E209 RID: 57865 RVA: 0x00377820 File Offset: 0x00375A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178562, XrefRangeEnd = 178564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetBulletTrail_b__9_0(TrailRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__TryGetBulletTrail_b__9_0_Internal_Boolean_TrailRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E20A RID: 57866 RVA: 0x00377870 File Offset: 0x00375A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178564, XrefRangeEnd = 178565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSource_b__15_0(AudioSourceController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c.NativeMethodInfoPtr__GetSource_b__15_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E20B RID: 57867 RVA: 0x0006A85B File Offset: 0x00068A5B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C9 RID: 17609
			// (get) Token: 0x0600E20C RID: 57868 RVA: 0x003778C0 File Offset: 0x00375AC0
			// (set) Token: 0x0600E20D RID: 57869 RVA: 0x0006A864 File Offset: 0x00068A64
			public unsafe static FXManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CA RID: 17610
			// (get) Token: 0x0600E20E RID: 57870 RVA: 0x003778E8 File Offset: 0x00375AE8
			// (set) Token: 0x0600E20F RID: 57871 RVA: 0x0006A876 File Offset: 0x00068A76
			public unsafe static Func<TrailRenderer, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrailRenderer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CB RID: 17611
			// (get) Token: 0x0600E210 RID: 57872 RVA: 0x00377910 File Offset: 0x00375B10
			// (set) Token: 0x0600E211 RID: 57873 RVA: 0x0006A888 File Offset: 0x00068A88
			public unsafe static Func<AudioSourceController, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FXManager.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FXManager.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099D1 RID: 39377
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099D2 RID: 39378
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040099D3 RID: 39379
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040099D4 RID: 39380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099D5 RID: 39381
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBulletTrail_b__9_0_Internal_Boolean_TrailRenderer_0;

			// Token: 0x040099D6 RID: 39382
			private static readonly IntPtr NativeMethodInfoPtr__GetSource_b__15_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x02000A8F RID: 2703
		[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E212 RID: 57874 RVA: 0x00377938 File Offset: 0x00375B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr);
				FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "trail");
				FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "speed");
				FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "start");
				FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "maxDistance");
				FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				FXManager.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, 100673688);
				FXManager.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, 100673689);
			}

			// Token: 0x0600E213 RID: 57875 RVA: 0x003779F0 File Offset: 0x00375BF0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E214 RID: 57876 RVA: 0x00377A2C File Offset: 0x00375C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178610, XrefRangeEnd = 178615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E215 RID: 57877 RVA: 0x0006A89A File Offset: 0x00068A9A
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044CC RID: 17612
			// (get) Token: 0x0600E216 RID: 57878 RVA: 0x00377A6C File Offset: 0x00375C6C
			// (set) Token: 0x0600E217 RID: 57879 RVA: 0x0006A8A3 File Offset: 0x00068AA3
			public unsafe TrailRenderer trail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CD RID: 17613
			// (get) Token: 0x0600E218 RID: 57880 RVA: 0x00377A9C File Offset: 0x00375C9C
			// (set) Token: 0x0600E219 RID: 57881 RVA: 0x0006A8C2 File Offset: 0x00068AC2
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x170044CE RID: 17614
			// (get) Token: 0x0600E21A RID: 57882 RVA: 0x00377AC4 File Offset: 0x00375CC4
			// (set) Token: 0x0600E21B RID: 57883 RVA: 0x0006A8DD File Offset: 0x00068ADD
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170044CF RID: 17615
			// (get) Token: 0x0600E21C RID: 57884 RVA: 0x00377AEC File Offset: 0x00375CEC
			// (set) Token: 0x0600E21D RID: 57885 RVA: 0x0006A8F8 File Offset: 0x00068AF8
			public unsafe float maxDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_maxDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr_maxDistance)) = value;
				}
			}

			// Token: 0x170044D0 RID: 17616
			// (get) Token: 0x0600E21E RID: 57886 RVA: 0x00377B14 File Offset: 0x00375D14
			// (set) Token: 0x0600E21F RID: 57887 RVA: 0x0006A913 File Offset: 0x00068B13
			public unsafe FXManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099D7 RID: 39383
			private static readonly IntPtr NativeFieldInfoPtr_trail;

			// Token: 0x040099D8 RID: 39384
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x040099D9 RID: 39385
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040099DA RID: 39386
			private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

			// Token: 0x040099DB RID: 39387
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099DC RID: 39388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099DD RID: 39389
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DCA RID: 3530
			[ObfuscatedName("ScheduleOne.FX.FXManager+<>c__DisplayClass10_0+<<CreateBulletTrail>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FEF5 RID: 65269 RVA: 0x003CA454 File Offset: 0x003C8654
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0>.NativeClassPtr, "<<CreateBulletTrail>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673690);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673691);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673692);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673693);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673694);
					FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673695);
				}

				// Token: 0x0600FEF6 RID: 65270 RVA: 0x003CA534 File Offset: 0x003C8734
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEF7 RID: 65271 RVA: 0x003CA57C File Offset: 0x003C877C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEF8 RID: 65272 RVA: 0x003CA5B0 File Offset: 0x003C87B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178565, XrefRangeEnd = 178605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D9C RID: 19868
				// (get) Token: 0x0600FEF9 RID: 65273 RVA: 0x003CA5EC File Offset: 0x003C87EC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEFA RID: 65274 RVA: 0x003CA62C File Offset: 0x003C882C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178605, XrefRangeEnd = 178610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D9D RID: 19869
				// (get) Token: 0x0600FEFB RID: 65275 RVA: 0x003CA660 File Offset: 0x003C8860
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEFC RID: 65276 RVA: 0x00078D12 File Offset: 0x00076F12
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D99 RID: 19865
				// (get) Token: 0x0600FEFD RID: 65277 RVA: 0x003CA6A0 File Offset: 0x003C88A0
				// (set) Token: 0x0600FEFE RID: 65278 RVA: 0x00078D1B File Offset: 0x00076F1B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D9A RID: 19866
				// (get) Token: 0x0600FEFF RID: 65279 RVA: 0x003CA6C8 File Offset: 0x003C88C8
				// (set) Token: 0x0600FF00 RID: 65280 RVA: 0x00078D36 File Offset: 0x00076F36
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D9B RID: 19867
				// (get) Token: 0x0600FF01 RID: 65281 RVA: 0x003CA6F8 File Offset: 0x003C88F8
				// (set) Token: 0x0600FF02 RID: 65282 RVA: 0x00078D55 File Offset: 0x00076F55
				public unsafe FXManager.__c__DisplayClass10_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXManager.__c__DisplayClass10_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXManager.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABCF RID: 43983
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABD0 RID: 43984
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABD1 RID: 43985
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABD2 RID: 43986
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABD3 RID: 43987
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABD4 RID: 43988
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABD5 RID: 43989
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABD6 RID: 43990
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABD7 RID: 43991
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
