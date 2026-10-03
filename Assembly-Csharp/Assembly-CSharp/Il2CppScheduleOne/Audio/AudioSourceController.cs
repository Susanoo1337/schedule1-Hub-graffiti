using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000471 RID: 1137
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x060066B4 RID: 26292 RVA: 0x001DED30 File Offset: 0x001DCF30
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSourceController()
		{
			Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr);
			AudioSourceController.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_id");
			AudioSourceController.NativeFieldInfoPtr__audioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_audioType");
			AudioSourceController.NativeFieldInfoPtr__defaultBaseVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_defaultBaseVolume");
			AudioSourceController.NativeFieldInfoPtr__volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_volumeMultiplier");
			AudioSourceController.NativeFieldInfoPtr__defaultBasePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_defaultBasePitch");
			AudioSourceController.NativeFieldInfoPtr__pitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_pitchMultiplier");
			AudioSourceController.NativeFieldInfoPtr__randomizePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_randomizePitch");
			AudioSourceController.NativeFieldInfoPtr__minRandomPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_minRandomPitch");
			AudioSourceController.NativeFieldInfoPtr__maxRandomPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_maxRandomPitch");
			AudioSourceController.NativeFieldInfoPtr__lowPassFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_lowPassFilter");
			AudioSourceController.NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_audioSource");
			AudioSourceController.NativeFieldInfoPtr__baseVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_baseVolume");
			AudioSourceController.NativeFieldInfoPtr__basePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "_basePitch");
			AudioSourceController.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676733);
			AudioSourceController.NativeMethodInfoPtr_get_Time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676734);
			AudioSourceController.NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676735);
			AudioSourceController.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676736);
			AudioSourceController.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676737);
			AudioSourceController.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676738);
			AudioSourceController.NativeMethodInfoPtr_get_PitchMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676739);
			AudioSourceController.NativeMethodInfoPtr_set_PitchMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676740);
			AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676741);
			AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676742);
			AudioSourceController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676743);
			AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676744);
			AudioSourceController.NativeMethodInfoPtr_ApplyMixer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676745);
			AudioSourceController.NativeMethodInfoPtr_OnPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676746);
			AudioSourceController.NativeMethodInfoPtr_OnUnpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676747);
			AudioSourceController.NativeMethodInfoPtr_SetBaseVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676748);
			AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676749);
			AudioSourceController.NativeMethodInfoPtr_SetBasePitch_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676750);
			AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676751);
			AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676752);
			AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676753);
			AudioSourceController.NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676754);
			AudioSourceController.NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676755);
			AudioSourceController.NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Virtual_New_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676756);
			AudioSourceController.NativeMethodInfoPtr_Delay_Protected_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676757);
			AudioSourceController.NativeMethodInfoPtr_DelayIE_Protected_IEnumerator_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676758);
			AudioSourceController.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettingsWrapper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676759);
			AudioSourceController.NativeMethodInfoPtr_ExtractAudioSettings_Public_AudioSettingsWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676760);
			AudioSourceController.NativeMethodInfoPtr_SetTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676761);
			AudioSourceController.NativeMethodInfoPtr_SetClip_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676762);
			AudioSourceController.NativeMethodInfoPtr_SetLoop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676763);
			AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676764);
			AudioSourceController.NativeMethodInfoPtr_SetSpacialBlend_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676765);
			AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676766);
			AudioSourceController.NativeMethodInfoPtr__PlayOneShotDelayed_b__40_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676767);
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x060066B5 RID: 26293 RVA: 0x001DF120 File Offset: 0x001DD320
		public unsafe bool IsPlaying
		{
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 214014, RefRangeEnd = 214066, XrefRangeStart = 214009, XrefRangeEnd = 214014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x001DF15C File Offset: 0x001DD35C
		public unsafe float Time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 214071, RefRangeEnd = 214075, XrefRangeStart = 214066, XrefRangeEnd = 214071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x060066B7 RID: 26295 RVA: 0x001DF198 File Offset: 0x001DD398
		public unsafe AudioClip Clip
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 214080, RefRangeEnd = 214087, XrefRangeStart = 214075, XrefRangeEnd = 214080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x001DF1D8 File Offset: 0x001DD3D8
		public unsafe string Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x001DF210 File Offset: 0x001DD410
		// (set) Token: 0x060066BA RID: 26298 RVA: 0x001DF24C File Offset: 0x001DD44C
		public unsafe float VolumeMultiplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 214088, RefRangeEnd = 214146, XrefRangeStart = 214087, XrefRangeEnd = 214088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060066BB RID: 26299 RVA: 0x001DF28C File Offset: 0x001DD48C
		// (set) Token: 0x060066BC RID: 26300 RVA: 0x001DF2C8 File Offset: 0x001DD4C8
		public unsafe float PitchMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_PitchMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 214147, RefRangeEnd = 214168, XrefRangeStart = 214146, XrefRangeEnd = 214147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_set_PitchMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x001DF308 File Offset: 0x001DD508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214168, XrefRangeEnd = 214181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x001DF33C File Offset: 0x001DD53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214181, XrefRangeEnd = 214220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x001DF370 File Offset: 0x001DD570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214220, XrefRangeEnd = 214222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x001DF3A4 File Offset: 0x001DD5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214222, XrefRangeEnd = 214261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x001DF3D8 File Offset: 0x001DD5D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214268, RefRangeEnd = 214270, XrefRangeStart = 214261, XrefRangeEnd = 214268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyMixer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x001DF40C File Offset: 0x001DD60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214270, XrefRangeEnd = 214272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x001DF440 File Offset: 0x001DD640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214272, XrefRangeEnd = 214275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnpause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnUnpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x001DF474 File Offset: 0x001DD674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214275, XrefRangeEnd = 214276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseVolume(float baseVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref baseVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetBaseVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x001DF4B4 File Offset: 0x001DD6B4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 214304, RefRangeEnd = 214333, XrefRangeStart = 214276, XrefRangeEnd = 214304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x001DF4E8 File Offset: 0x001DD6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214333, XrefRangeEnd = 214334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBasePitch(float basePitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref basePitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetBasePitch_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x001DF528 File Offset: 0x001DD728
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 214339, RefRangeEnd = 214350, XrefRangeStart = 214334, XrefRangeEnd = 214339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x001DF55C File Offset: 0x001DD75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214350, XrefRangeEnd = 214367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x001DF598 File Offset: 0x001DD798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214367, XrefRangeEnd = 214373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayOneShot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x001DF5D4 File Offset: 0x001DD7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214385, RefRangeEnd = 214386, XrefRangeStart = 214373, XrefRangeEnd = 214385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShotDelayed(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x001DF614 File Offset: 0x001DD814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214386, RefRangeEnd = 214388, XrefRangeStart = 214386, XrefRangeEnd = 214386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DuplicateAndPlayOneShot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x001DF648 File Offset: 0x001DD848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214388, XrefRangeEnd = 214421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DuplicateAndPlayOneShot(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Virtual_New_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x001DF698 File Offset: 0x001DD898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214421, XrefRangeEnd = 214427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delay(float delay, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Delay_Protected_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x001DF6E8 File Offset: 0x001DD8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214427, XrefRangeEnd = 214432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayIE(float delay, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_DelayIE_Protected_IEnumerator_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x001DF748 File Offset: 0x001DD948
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214443, RefRangeEnd = 214447, XrefRangeStart = 214432, XrefRangeEnd = 214443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioSettings(AudioSettingsWrapper settings, bool excludeClip = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeClip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettingsWrapper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x001DF798 File Offset: 0x001DD998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214458, RefRangeEnd = 214460, XrefRangeStart = 214447, XrefRangeEnd = 214458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettingsWrapper ExtractAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ExtractAudioSettings_Public_AudioSettingsWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSettingsWrapper>(intPtr3) : null;
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x001DF7D8 File Offset: 0x001DD9D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214473, RefRangeEnd = 214476, XrefRangeStart = 214460, XrefRangeEnd = 214473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x001DF818 File Offset: 0x001DDA18
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 214489, RefRangeEnd = 214504, XrefRangeStart = 214476, XrefRangeEnd = 214489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClip(AudioClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetClip_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x001DF85C File Offset: 0x001DDA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214517, RefRangeEnd = 214520, XrefRangeStart = 214504, XrefRangeEnd = 214517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLoop(bool loop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetLoop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x001DF89C File Offset: 0x001DDA9C
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 214525, RefRangeEnd = 214572, XrefRangeStart = 214520, XrefRangeEnd = 214525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x001DF8D0 File Offset: 0x001DDAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214577, RefRangeEnd = 214579, XrefRangeStart = 214572, XrefRangeEnd = 214577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpacialBlend(float spacialBlend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spacialBlend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetSpacialBlend_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x001DF910 File Offset: 0x001DDB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214579, XrefRangeEnd = 214580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x001DF94C File Offset: 0x001DDB4C
		[CallerCount(0)]
		public unsafe void _PlayOneShotDelayed_b__40_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr__PlayOneShotDelayed_b__40_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00030661 File Offset: 0x0002E861
		public AudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x060066D9 RID: 26329 RVA: 0x001DF980 File Offset: 0x001DDB80
		// (set) Token: 0x060066DA RID: 26330 RVA: 0x0003066A File Offset: 0x0002E86A
		public unsafe string _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x001DF9A8 File Offset: 0x001DDBA8
		// (set) Token: 0x060066DC RID: 26332 RVA: 0x00030689 File Offset: 0x0002E889
		public unsafe EAudioType _audioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__audioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__audioType)) = value;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x001DF9D0 File Offset: 0x001DDBD0
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x000306A4 File Offset: 0x0002E8A4
		public unsafe float _defaultBaseVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__defaultBaseVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__defaultBaseVolume)) = value;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x001DF9F8 File Offset: 0x001DDBF8
		// (set) Token: 0x060066E0 RID: 26336 RVA: 0x000306BF File Offset: 0x0002E8BF
		public unsafe float _volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__volumeMultiplier)) = value;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x060066E1 RID: 26337 RVA: 0x001DFA20 File Offset: 0x001DDC20
		// (set) Token: 0x060066E2 RID: 26338 RVA: 0x000306DA File Offset: 0x0002E8DA
		public unsafe float _defaultBasePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__defaultBasePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__defaultBasePitch)) = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x060066E3 RID: 26339 RVA: 0x001DFA48 File Offset: 0x001DDC48
		// (set) Token: 0x060066E4 RID: 26340 RVA: 0x000306F5 File Offset: 0x0002E8F5
		public unsafe float _pitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__pitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__pitchMultiplier)) = value;
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x060066E5 RID: 26341 RVA: 0x001DFA70 File Offset: 0x001DDC70
		// (set) Token: 0x060066E6 RID: 26342 RVA: 0x00030710 File Offset: 0x0002E910
		public unsafe bool _randomizePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__randomizePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__randomizePitch)) = value;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x001DFA98 File Offset: 0x001DDC98
		// (set) Token: 0x060066E8 RID: 26344 RVA: 0x0003072B File Offset: 0x0002E92B
		public unsafe float _minRandomPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__minRandomPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__minRandomPitch)) = value;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x060066E9 RID: 26345 RVA: 0x001DFAC0 File Offset: 0x001DDCC0
		// (set) Token: 0x060066EA RID: 26346 RVA: 0x00030746 File Offset: 0x0002E946
		public unsafe float _maxRandomPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__maxRandomPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__maxRandomPitch)) = value;
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x060066EB RID: 26347 RVA: 0x001DFAE8 File Offset: 0x001DDCE8
		// (set) Token: 0x060066EC RID: 26348 RVA: 0x00030761 File Offset: 0x0002E961
		public unsafe AudioLowPassFilter _lowPassFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__lowPassFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioLowPassFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__lowPassFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x060066ED RID: 26349 RVA: 0x001DFB18 File Offset: 0x001DDD18
		// (set) Token: 0x060066EE RID: 26350 RVA: 0x00030780 File Offset: 0x0002E980
		public unsafe AudioSource _audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x060066EF RID: 26351 RVA: 0x001DFB48 File Offset: 0x001DDD48
		// (set) Token: 0x060066F0 RID: 26352 RVA: 0x0003079F File Offset: 0x0002E99F
		public unsafe float _baseVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__baseVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__baseVolume)) = value;
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x060066F1 RID: 26353 RVA: 0x001DFB70 File Offset: 0x001DDD70
		// (set) Token: 0x060066F2 RID: 26354 RVA: 0x000307BA File Offset: 0x0002E9BA
		public unsafe float _basePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__basePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__basePitch)) = value;
			}
		}

		// Token: 0x040046B4 RID: 18100
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040046B5 RID: 18101
		private static readonly IntPtr NativeFieldInfoPtr__audioType;

		// Token: 0x040046B6 RID: 18102
		private static readonly IntPtr NativeFieldInfoPtr__defaultBaseVolume;

		// Token: 0x040046B7 RID: 18103
		private static readonly IntPtr NativeFieldInfoPtr__volumeMultiplier;

		// Token: 0x040046B8 RID: 18104
		private static readonly IntPtr NativeFieldInfoPtr__defaultBasePitch;

		// Token: 0x040046B9 RID: 18105
		private static readonly IntPtr NativeFieldInfoPtr__pitchMultiplier;

		// Token: 0x040046BA RID: 18106
		private static readonly IntPtr NativeFieldInfoPtr__randomizePitch;

		// Token: 0x040046BB RID: 18107
		private static readonly IntPtr NativeFieldInfoPtr__minRandomPitch;

		// Token: 0x040046BC RID: 18108
		private static readonly IntPtr NativeFieldInfoPtr__maxRandomPitch;

		// Token: 0x040046BD RID: 18109
		private static readonly IntPtr NativeFieldInfoPtr__lowPassFilter;

		// Token: 0x040046BE RID: 18110
		private static readonly IntPtr NativeFieldInfoPtr__audioSource;

		// Token: 0x040046BF RID: 18111
		private static readonly IntPtr NativeFieldInfoPtr__baseVolume;

		// Token: 0x040046C0 RID: 18112
		private static readonly IntPtr NativeFieldInfoPtr__basePitch;

		// Token: 0x040046C1 RID: 18113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040046C2 RID: 18114
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Single_0;

		// Token: 0x040046C3 RID: 18115
		private static readonly IntPtr NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0;

		// Token: 0x040046C4 RID: 18116
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x040046C5 RID: 18117
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0;

		// Token: 0x040046C6 RID: 18118
		private static readonly IntPtr NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0;

		// Token: 0x040046C7 RID: 18119
		private static readonly IntPtr NativeMethodInfoPtr_get_PitchMultiplier_Public_get_Single_0;

		// Token: 0x040046C8 RID: 18120
		private static readonly IntPtr NativeMethodInfoPtr_set_PitchMultiplier_Public_set_Void_Single_0;

		// Token: 0x040046C9 RID: 18121
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040046CA RID: 18122
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040046CB RID: 18123
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040046CC RID: 18124
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040046CD RID: 18125
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMixer_Private_Void_0;

		// Token: 0x040046CE RID: 18126
		private static readonly IntPtr NativeMethodInfoPtr_OnPause_Private_Void_0;

		// Token: 0x040046CF RID: 18127
		private static readonly IntPtr NativeMethodInfoPtr_OnUnpause_Private_Void_0;

		// Token: 0x040046D0 RID: 18128
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseVolume_Public_Void_Single_0;

		// Token: 0x040046D1 RID: 18129
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVolume_Protected_Void_0;

		// Token: 0x040046D2 RID: 18130
		private static readonly IntPtr NativeMethodInfoPtr_SetBasePitch_Public_Void_Single_0;

		// Token: 0x040046D3 RID: 18131
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPitch_Private_Void_0;

		// Token: 0x040046D4 RID: 18132
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x040046D5 RID: 18133
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_0;

		// Token: 0x040046D6 RID: 18134
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_0;

		// Token: 0x040046D7 RID: 18135
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Void_0;

		// Token: 0x040046D8 RID: 18136
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateAndPlayOneShot_Public_Virtual_New_Void_Transform_0;

		// Token: 0x040046D9 RID: 18137
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Protected_Void_Single_Action_0;

		// Token: 0x040046DA RID: 18138
		private static readonly IntPtr NativeMethodInfoPtr_DelayIE_Protected_IEnumerator_Single_Action_0;

		// Token: 0x040046DB RID: 18139
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettingsWrapper_Boolean_0;

		// Token: 0x040046DC RID: 18140
		private static readonly IntPtr NativeMethodInfoPtr_ExtractAudioSettings_Public_AudioSettingsWrapper_0;

		// Token: 0x040046DD RID: 18141
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Single_0;

		// Token: 0x040046DE RID: 18142
		private static readonly IntPtr NativeMethodInfoPtr_SetClip_Public_Void_AudioClip_0;

		// Token: 0x040046DF RID: 18143
		private static readonly IntPtr NativeMethodInfoPtr_SetLoop_Public_Void_Boolean_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly IntPtr NativeMethodInfoPtr_SetSpacialBlend_Public_Void_Single_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046E3 RID: 18147
		private static readonly IntPtr NativeMethodInfoPtr__PlayOneShotDelayed_b__40_0_Private_Void_0;

		// Token: 0x02000B47 RID: 2887
		[ObfuscatedName("ScheduleOne.Audio.AudioSourceController+<DelayIE>d__44")]
		public sealed class _DelayIE_d__44 : Il2CppSystem.Object
		{
			// Token: 0x0600E71E RID: 59166 RVA: 0x00385AB0 File Offset: 0x00383CB0
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayIE_d__44()
			{
				Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "<DelayIE>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr);
				AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, "<>1__state");
				AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, "<>2__current");
				AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, "delay");
				AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, "callback");
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676768);
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676769);
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676770);
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676771);
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676772);
				AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr, 100676773);
			}

			// Token: 0x0600E71F RID: 59167 RVA: 0x00385BA4 File Offset: 0x00383DA4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayIE_d__44(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSourceController._DelayIE_d__44>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E720 RID: 59168 RVA: 0x00385BEC File Offset: 0x00383DEC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E721 RID: 59169 RVA: 0x00385C20 File Offset: 0x00383E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213999, XrefRangeEnd = 214004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004627 RID: 17959
			// (get) Token: 0x0600E722 RID: 59170 RVA: 0x00385C5C File Offset: 0x00383E5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E723 RID: 59171 RVA: 0x00385C9C File Offset: 0x00383E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214004, XrefRangeEnd = 214009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004628 RID: 17960
			// (get) Token: 0x0600E724 RID: 59172 RVA: 0x00385CD0 File Offset: 0x00383ED0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController._DelayIE_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E725 RID: 59173 RVA: 0x0006D048 File Offset: 0x0006B248
			public _DelayIE_d__44(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004623 RID: 17955
			// (get) Token: 0x0600E726 RID: 59174 RVA: 0x00385D10 File Offset: 0x00383F10
			// (set) Token: 0x0600E727 RID: 59175 RVA: 0x0006D051 File Offset: 0x0006B251
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004624 RID: 17956
			// (get) Token: 0x0600E728 RID: 59176 RVA: 0x00385D38 File Offset: 0x00383F38
			// (set) Token: 0x0600E729 RID: 59177 RVA: 0x0006D06C File Offset: 0x0006B26C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004625 RID: 17957
			// (get) Token: 0x0600E72A RID: 59178 RVA: 0x00385D68 File Offset: 0x00383F68
			// (set) Token: 0x0600E72B RID: 59179 RVA: 0x0006D08B File Offset: 0x0006B28B
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004626 RID: 17958
			// (get) Token: 0x0600E72C RID: 59180 RVA: 0x00385D90 File Offset: 0x00383F90
			// (set) Token: 0x0600E72D RID: 59181 RVA: 0x0006D0A6 File Offset: 0x0006B2A6
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController._DelayIE_d__44.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CE8 RID: 40168
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009CE9 RID: 40169
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CEA RID: 40170
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04009CEB RID: 40171
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009CEC RID: 40172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CED RID: 40173
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CEE RID: 40174
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CEF RID: 40175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CF0 RID: 40176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CF1 RID: 40177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
