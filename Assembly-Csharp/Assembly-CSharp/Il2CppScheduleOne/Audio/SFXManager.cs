using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Configuration;
using Il2CppScheduleOne.Core;
using Il2CppScheduleOne.Core.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000483 RID: 1155
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x060067F3 RID: 26611 RVA: 0x001E2B0C File Offset: 0x001E0D0C
		// Note: this type is marked as 'beforefieldinit'.
		static SFXManager()
		{
			Il2CppClassPointerStore<SFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager>.NativeClassPtr);
			SFXManager.NativeFieldInfoPtr_ImpactSoundMaxRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactSoundMaxRangeSquared");
			SFXManager.NativeFieldInfoPtr__soundPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "_soundPool");
			SFXManager.NativeFieldInfoPtr__soundsInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "_soundsInUse");
			SFXManager.NativeFieldInfoPtr__configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "_configuration");
			SFXManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676892);
			SFXManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676893);
			SFXManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676894);
			SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EImpactSound_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676895);
			SFXManager.NativeMethodInfoPtr_PlayFootstepSound_Public_Void_EMaterialType_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676896);
			SFXManager.NativeMethodInfoPtr_SetConfiguration_Public_Void_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676897);
			SFXManager.NativeMethodInfoPtr_SetupSoundPool_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676898);
			SFXManager.NativeMethodInfoPtr_TryPullAudioSource_Private_Boolean_byref_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676899);
			SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676900);
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x001E2C40 File Offset: 0x001E0E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215567, XrefRangeEnd = 215584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SFXManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x001E2C7C File Offset: 0x001E0E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215584, XrefRangeEnd = 215603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SFXManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x001E2CB8 File Offset: 0x001E0EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215603, XrefRangeEnd = 215620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x001E2CEC File Offset: 0x001E0EEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215663, RefRangeEnd = 215666, XrefRangeStart = 215620, XrefRangeEnd = 215663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpactSound(EImpactSound material, Vector3 position, float momentum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref material;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref momentum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EImpactSound_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x001E2D48 File Offset: 0x001E0F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215693, RefRangeEnd = 215694, XrefRangeStart = 215666, XrefRangeEnd = 215693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayFootstepSound(EMaterialType materialType, float volume, Vector3 position, float spatialBlend = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref materialType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spatialBlend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_PlayFootstepSound_Public_Void_EMaterialType_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x001E2DB0 File Offset: 0x001E0FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215694, XrefRangeEnd = 215712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConfiguration(BaseConfiguration baseConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseConfiguration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_SetConfiguration_Public_Void_BaseConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x001E2DF4 File Offset: 0x001E0FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215778, RefRangeEnd = 215779, XrefRangeStart = 215712, XrefRangeEnd = 215778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSoundPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_SetupSoundPool_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x001E2E28 File Offset: 0x001E1028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215792, RefRangeEnd = 215794, XrefRangeStart = 215779, XrefRangeEnd = 215792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPullAudioSource(out AudioSourceController source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_TryPullAudioSource_Private_Boolean_byref_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new AudioSourceController(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x001E2E88 File Offset: 0x001E1088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215794, XrefRangeEnd = 215809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00030F86 File Offset: 0x0002F186
		public SFXManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x060067FE RID: 26622 RVA: 0x001E2EC4 File Offset: 0x001E10C4
		// (set) Token: 0x060067FF RID: 26623 RVA: 0x00030F8F File Offset: 0x0002F18F
		public unsafe static float ImpactSoundMaxRangeSquared
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_ImpactSoundMaxRangeSquared, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_ImpactSoundMaxRangeSquared, (void*)(&value));
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x001E2EE0 File Offset: 0x001E10E0
		// (set) Token: 0x06006801 RID: 26625 RVA: 0x00030F9D File Offset: 0x0002F19D
		public unsafe List<AudioSourceController> _soundPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__soundPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__soundPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x001E2F10 File Offset: 0x001E1110
		// (set) Token: 0x06006803 RID: 26627 RVA: 0x00030FBC File Offset: 0x0002F1BC
		public unsafe List<AudioSourceController> _soundsInUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__soundsInUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__soundsInUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06006804 RID: 26628 RVA: 0x001E2F40 File Offset: 0x001E1140
		// (set) Token: 0x06006805 RID: 26629 RVA: 0x00030FDB File Offset: 0x0002F1DB
		public unsafe SFXConfiguration _configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__configuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SFXConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr__configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004780 RID: 18304
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSoundMaxRangeSquared;

		// Token: 0x04004781 RID: 18305
		private static readonly IntPtr NativeFieldInfoPtr__soundPool;

		// Token: 0x04004782 RID: 18306
		private static readonly IntPtr NativeFieldInfoPtr__soundsInUse;

		// Token: 0x04004783 RID: 18307
		private static readonly IntPtr NativeFieldInfoPtr__configuration;

		// Token: 0x04004784 RID: 18308
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004785 RID: 18309
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04004786 RID: 18310
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004787 RID: 18311
		private static readonly IntPtr NativeMethodInfoPtr_PlayImpactSound_Public_Void_EImpactSound_Vector3_Single_0;

		// Token: 0x04004788 RID: 18312
		private static readonly IntPtr NativeMethodInfoPtr_PlayFootstepSound_Public_Void_EMaterialType_Single_Vector3_Single_0;

		// Token: 0x04004789 RID: 18313
		private static readonly IntPtr NativeMethodInfoPtr_SetConfiguration_Public_Void_BaseConfiguration_0;

		// Token: 0x0400478A RID: 18314
		private static readonly IntPtr NativeMethodInfoPtr_SetupSoundPool_Private_Void_0;

		// Token: 0x0400478B RID: 18315
		private static readonly IntPtr NativeMethodInfoPtr_TryPullAudioSource_Private_Boolean_byref_AudioSourceController_0;

		// Token: 0x0400478C RID: 18316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
