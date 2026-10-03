using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine.Audio;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000470 RID: 1136
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x0600667C RID: 26236 RVA: 0x001DE2C0 File Offset: 0x001DC4C0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioManager()
		{
			Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
			AudioManager.NativeFieldInfoPtr_MinGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MinGameVolume");
			AudioManager.NativeFieldInfoPtr_MaxGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MaxGameVolume");
			AudioManager.NativeFieldInfoPtr_GameVolumeLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "GameVolumeLerpSpeed");
			AudioManager.NativeFieldInfoPtr_onVolumeSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "onVolumeSettingsChanged");
			AudioManager.NativeFieldInfoPtr__MainGameMixer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<MainGameMixer>k__BackingField");
			AudioManager.NativeFieldInfoPtr__MenuMixer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<MenuMixer>k__BackingField");
			AudioManager.NativeFieldInfoPtr__MusicMixer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<MusicMixer>k__BackingField");
			AudioManager.NativeFieldInfoPtr__defaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_defaultSnapshot");
			AudioManager.NativeFieldInfoPtr__distortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_distortedSnapshot");
			AudioManager.NativeFieldInfoPtr__masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_masterVolume");
			AudioManager.NativeFieldInfoPtr__ambientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_ambientVolume");
			AudioManager.NativeFieldInfoPtr__footstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_footstepsVolume");
			AudioManager.NativeFieldInfoPtr__fxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_fxVolume");
			AudioManager.NativeFieldInfoPtr__uiVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_uiVolume");
			AudioManager.NativeFieldInfoPtr__musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_musicVolume");
			AudioManager.NativeFieldInfoPtr__voiceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_voiceVolume");
			AudioManager.NativeFieldInfoPtr__weatherVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_weatherVolume");
			AudioManager.NativeFieldInfoPtr__currentMainMixerVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "_currentMainMixerVolume");
			AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676715);
			AudioManager.NativeMethodInfoPtr_get_MainGameMixer_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676716);
			AudioManager.NativeMethodInfoPtr_set_MainGameMixer_Private_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676717);
			AudioManager.NativeMethodInfoPtr_get_MenuMixer_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676718);
			AudioManager.NativeMethodInfoPtr_set_MenuMixer_Private_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676719);
			AudioManager.NativeMethodInfoPtr_get_MusicMixer_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676720);
			AudioManager.NativeMethodInfoPtr_set_MusicMixer_Private_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676721);
			AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676722);
			AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676723);
			AudioManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676724);
			AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676725);
			AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676726);
			AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676727);
			AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676728);
			AudioManager.NativeMethodInfoPtr_SetMainMixerVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676729);
			AudioManager.NativeMethodInfoPtr_ValueToVolume_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676730);
			AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676731);
			AudioManager.NativeMethodInfoPtr__Start_b__30_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676732);
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x001DE5C0 File Offset: 0x001DC7C0
		public unsafe float MasterVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x0600667E RID: 26238 RVA: 0x001DE5FC File Offset: 0x001DC7FC
		// (set) Token: 0x0600667F RID: 26239 RVA: 0x001DE63C File Offset: 0x001DC83C
		public unsafe AudioMixerGroup MainGameMixer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MainGameMixer_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_MainGameMixer_Private_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x001DE680 File Offset: 0x001DC880
		// (set) Token: 0x06006681 RID: 26241 RVA: 0x001DE6C0 File Offset: 0x001DC8C0
		public unsafe AudioMixerGroup MenuMixer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MenuMixer_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_MenuMixer_Private_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06006682 RID: 26242 RVA: 0x001DE704 File Offset: 0x001DC904
		// (set) Token: 0x06006683 RID: 26243 RVA: 0x001DE744 File Offset: 0x001DC944
		public unsafe AudioMixerGroup MusicMixer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MusicMixer_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_MusicMixer_Private_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x001DE788 File Offset: 0x001DC988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213893, XrefRangeEnd = 213911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x001DE7C4 File Offset: 0x001DC9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213911, XrefRangeEnd = 213938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x001DE800 File Offset: 0x001DCA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213938, XrefRangeEnd = 213944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x001DE834 File Offset: 0x001DCA34
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 213947, RefRangeEnd = 213957, XrefRangeStart = 213944, XrefRangeEnd = 213947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x001DE880 File Offset: 0x001DCA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213960, RefRangeEnd = 213961, XrefRangeStart = 213957, XrefRangeEnd = 213960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVolume(EAudioType audioType, bool scaled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref audioType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x001DE8D8 File Offset: 0x001DCAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213962, RefRangeEnd = 213963, XrefRangeStart = 213961, XrefRangeEnd = 213962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMasterVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x001DE918 File Offset: 0x001DCB18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 213970, RefRangeEnd = 213977, XrefRangeStart = 213963, XrefRangeEnd = 213970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(EAudioType type, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001DE964 File Offset: 0x001DCB64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213985, RefRangeEnd = 213987, XrefRangeStart = 213977, XrefRangeEnd = 213985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainMixerVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMainMixerVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x001DE9A4 File Offset: 0x001DCBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213987, XrefRangeEnd = 213989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ValueToVolume(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_ValueToVolume_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x001DE9E4 File Offset: 0x001DCBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213989, XrefRangeEnd = 213997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x001DEA20 File Offset: 0x001DCC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213997, XrefRangeEnd = 213999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__30_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__Start_b__30_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00030481 File Offset: 0x0002E681
		public AudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x001DEA54 File Offset: 0x001DCC54
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x0003048A File Offset: 0x0002E68A
		public unsafe static float MinGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MinGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MinGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x001DEA70 File Offset: 0x001DCC70
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x00030498 File Offset: 0x0002E698
		public unsafe static float MaxGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MaxGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MaxGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x001DEA8C File Offset: 0x001DCC8C
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x000304A6 File Offset: 0x0002E6A6
		public unsafe static float GameVolumeLerpSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_GameVolumeLerpSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_GameVolumeLerpSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x001DEAA8 File Offset: 0x001DCCA8
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public unsafe PreallocatedAction onVolumeSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onVolumeSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreallocatedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onVolumeSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x001DEAD8 File Offset: 0x001DCCD8
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x000304D3 File Offset: 0x0002E6D3
		public unsafe AudioMixerGroup _MainGameMixer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MainGameMixer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MainGameMixer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x001DEB08 File Offset: 0x001DCD08
		// (set) Token: 0x0600669B RID: 26267 RVA: 0x000304F2 File Offset: 0x0002E6F2
		public unsafe AudioMixerGroup _MenuMixer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MenuMixer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MenuMixer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x001DEB38 File Offset: 0x001DCD38
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x00030511 File Offset: 0x0002E711
		public unsafe AudioMixerGroup _MusicMixer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MusicMixer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__MusicMixer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x001DEB68 File Offset: 0x001DCD68
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x00030530 File Offset: 0x0002E730
		public unsafe AudioMixerSnapshot _defaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__defaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__defaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x001DEB98 File Offset: 0x001DCD98
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x0003054F File Offset: 0x0002E74F
		public unsafe AudioMixerSnapshot _distortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__distortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__distortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x001DEBC8 File Offset: 0x001DCDC8
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x0003056E File Offset: 0x0002E76E
		public unsafe float _masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__masterVolume)) = value;
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x001DEBF0 File Offset: 0x001DCDF0
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00030589 File Offset: 0x0002E789
		public unsafe float _ambientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__ambientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__ambientVolume)) = value;
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x001DEC18 File Offset: 0x001DCE18
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x000305A4 File Offset: 0x0002E7A4
		public unsafe float _footstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__footstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__footstepsVolume)) = value;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x001DEC40 File Offset: 0x001DCE40
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x000305BF File Offset: 0x0002E7BF
		public unsafe float _fxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__fxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__fxVolume)) = value;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x001DEC68 File Offset: 0x001DCE68
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x000305DA File Offset: 0x0002E7DA
		public unsafe float _uiVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__uiVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__uiVolume)) = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x001DEC90 File Offset: 0x001DCE90
		// (set) Token: 0x060066AD RID: 26285 RVA: 0x000305F5 File Offset: 0x0002E7F5
		public unsafe float _musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__musicVolume)) = value;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x001DECB8 File Offset: 0x001DCEB8
		// (set) Token: 0x060066AF RID: 26287 RVA: 0x00030610 File Offset: 0x0002E810
		public unsafe float _voiceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__voiceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__voiceVolume)) = value;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x001DECE0 File Offset: 0x001DCEE0
		// (set) Token: 0x060066B1 RID: 26289 RVA: 0x0003062B File Offset: 0x0002E82B
		public unsafe float _weatherVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__weatherVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__weatherVolume)) = value;
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x001DED08 File Offset: 0x001DCF08
		// (set) Token: 0x060066B3 RID: 26291 RVA: 0x00030646 File Offset: 0x0002E846
		public unsafe float _currentMainMixerVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__currentMainMixerVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__currentMainMixerVolume)) = value;
			}
		}

		// Token: 0x04004690 RID: 18064
		private static readonly IntPtr NativeFieldInfoPtr_MinGameVolume;

		// Token: 0x04004691 RID: 18065
		private static readonly IntPtr NativeFieldInfoPtr_MaxGameVolume;

		// Token: 0x04004692 RID: 18066
		private static readonly IntPtr NativeFieldInfoPtr_GameVolumeLerpSpeed;

		// Token: 0x04004693 RID: 18067
		private static readonly IntPtr NativeFieldInfoPtr_onVolumeSettingsChanged;

		// Token: 0x04004694 RID: 18068
		private static readonly IntPtr NativeFieldInfoPtr__MainGameMixer_k__BackingField;

		// Token: 0x04004695 RID: 18069
		private static readonly IntPtr NativeFieldInfoPtr__MenuMixer_k__BackingField;

		// Token: 0x04004696 RID: 18070
		private static readonly IntPtr NativeFieldInfoPtr__MusicMixer_k__BackingField;

		// Token: 0x04004697 RID: 18071
		private static readonly IntPtr NativeFieldInfoPtr__defaultSnapshot;

		// Token: 0x04004698 RID: 18072
		private static readonly IntPtr NativeFieldInfoPtr__distortedSnapshot;

		// Token: 0x04004699 RID: 18073
		private static readonly IntPtr NativeFieldInfoPtr__masterVolume;

		// Token: 0x0400469A RID: 18074
		private static readonly IntPtr NativeFieldInfoPtr__ambientVolume;

		// Token: 0x0400469B RID: 18075
		private static readonly IntPtr NativeFieldInfoPtr__footstepsVolume;

		// Token: 0x0400469C RID: 18076
		private static readonly IntPtr NativeFieldInfoPtr__fxVolume;

		// Token: 0x0400469D RID: 18077
		private static readonly IntPtr NativeFieldInfoPtr__uiVolume;

		// Token: 0x0400469E RID: 18078
		private static readonly IntPtr NativeFieldInfoPtr__musicVolume;

		// Token: 0x0400469F RID: 18079
		private static readonly IntPtr NativeFieldInfoPtr__voiceVolume;

		// Token: 0x040046A0 RID: 18080
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolume;

		// Token: 0x040046A1 RID: 18081
		private static readonly IntPtr NativeFieldInfoPtr__currentMainMixerVolume;

		// Token: 0x040046A2 RID: 18082
		private static readonly IntPtr NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0;

		// Token: 0x040046A3 RID: 18083
		private static readonly IntPtr NativeMethodInfoPtr_get_MainGameMixer_Public_get_AudioMixerGroup_0;

		// Token: 0x040046A4 RID: 18084
		private static readonly IntPtr NativeMethodInfoPtr_set_MainGameMixer_Private_set_Void_AudioMixerGroup_0;

		// Token: 0x040046A5 RID: 18085
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuMixer_Public_get_AudioMixerGroup_0;

		// Token: 0x040046A6 RID: 18086
		private static readonly IntPtr NativeMethodInfoPtr_set_MenuMixer_Private_set_Void_AudioMixerGroup_0;

		// Token: 0x040046A7 RID: 18087
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicMixer_Public_get_AudioMixerGroup_0;

		// Token: 0x040046A8 RID: 18088
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicMixer_Private_set_Void_AudioMixerGroup_0;

		// Token: 0x040046A9 RID: 18089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040046AA RID: 18090
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040046AB RID: 18091
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040046AC RID: 18092
		private static readonly IntPtr NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x040046AD RID: 18093
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0;

		// Token: 0x040046AE RID: 18094
		private static readonly IntPtr NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0;

		// Token: 0x040046AF RID: 18095
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0;

		// Token: 0x040046B0 RID: 18096
		private static readonly IntPtr NativeMethodInfoPtr_SetMainMixerVolume_Private_Void_Single_0;

		// Token: 0x040046B1 RID: 18097
		private static readonly IntPtr NativeMethodInfoPtr_ValueToVolume_Private_Static_Single_Single_0;

		// Token: 0x040046B2 RID: 18098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046B3 RID: 18099
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__30_0_Private_Void_0;
	}
}
