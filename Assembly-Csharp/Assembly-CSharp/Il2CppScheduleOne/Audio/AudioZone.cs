using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000472 RID: 1138
	public class AudioZone : PolygonalZone
	{
		// Token: 0x060066F3 RID: 26355 RVA: 0x001DFB98 File Offset: 0x001DDD98
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZone()
		{
			Il2CppClassPointerStore<AudioZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone>.NativeClassPtr);
			AudioZone.NativeFieldInfoPtr_VolumeChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "VolumeChangeRate");
			AudioZone.NativeFieldInfoPtr_UpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "UpdateInterval");
			AudioZone.NativeFieldInfoPtr__maximumAudibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "_maximumAudibleDistance");
			AudioZone.NativeFieldInfoPtr__tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "_tracks");
			AudioZone.NativeFieldInfoPtr__localCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "_localCameraDistance");
			AudioZone.NativeFieldInfoPtr__currentVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "_currentVolume");
			AudioZone.NativeFieldInfoPtr__modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "_modifiers");
			AudioZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676774);
			AudioZone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676775);
			AudioZone.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676776);
			AudioZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676777);
			AudioZone.NativeMethodInfoPtr_GetModifierMultiplier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676778);
			AudioZone.NativeMethodInfoPtr_RecalculateCameraDistance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676779);
			AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_IAudioZoneModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676780);
			AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_IAudioZoneModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676781);
			AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676782);
			AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676783);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x001DFD1C File Offset: 0x001DDF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214580, XrefRangeEnd = 214585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x001DFD58 File Offset: 0x001DDF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214585, XrefRangeEnd = 214622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x001DFD8C File Offset: 0x001DDF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214622, XrefRangeEnd = 214654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x001DFDC0 File Offset: 0x001DDFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214654, XrefRangeEnd = 214678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x001DFDF4 File Offset: 0x001DDFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214696, RefRangeEnd = 214697, XrefRangeStart = 214678, XrefRangeEnd = 214696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetModifierMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetModifierMultiplier_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x001DFE30 File Offset: 0x001DE030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214697, XrefRangeEnd = 214707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCameraDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_RecalculateCameraDistance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x001DFE64 File Offset: 0x001DE064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214707, XrefRangeEnd = 214720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(IAudioZoneModifier modifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_IAudioZoneModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x001DFEA8 File Offset: 0x001DE0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214720, XrefRangeEnd = 214726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveModifier(IAudioZoneModifier modifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_IAudioZoneModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x001DFEEC File Offset: 0x001DE0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214726, XrefRangeEnd = 214727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFalloffFactor(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x001DFF38 File Offset: 0x001DE138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214727, XrefRangeEnd = 214742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x000307D5 File Offset: 0x0002E9D5
		public AudioZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x001DFF74 File Offset: 0x001DE174
		// (set) Token: 0x06006700 RID: 26368 RVA: 0x000307DE File Offset: 0x0002E9DE
		public unsafe static float VolumeChangeRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_VolumeChangeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_VolumeChangeRate, (void*)(&value));
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x001DFF90 File Offset: 0x001DE190
		// (set) Token: 0x06006702 RID: 26370 RVA: 0x000307EC File Offset: 0x0002E9EC
		public unsafe static float UpdateInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_UpdateInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_UpdateInterval, (void*)(&value));
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06006703 RID: 26371 RVA: 0x001DFFAC File Offset: 0x001DE1AC
		// (set) Token: 0x06006704 RID: 26372 RVA: 0x000307FA File Offset: 0x0002E9FA
		public unsafe float _maximumAudibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__maximumAudibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__maximumAudibleDistance)) = value;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06006705 RID: 26373 RVA: 0x001DFFD4 File Offset: 0x001DE1D4
		// (set) Token: 0x06006706 RID: 26374 RVA: 0x00030815 File Offset: 0x0002EA15
		public unsafe List<AudioZoneTrack> _tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZoneTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x001E0004 File Offset: 0x001DE204
		// (set) Token: 0x06006708 RID: 26376 RVA: 0x00030834 File Offset: 0x0002EA34
		public unsafe float _localCameraDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__localCameraDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__localCameraDistance)) = value;
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06006709 RID: 26377 RVA: 0x001E002C File Offset: 0x001DE22C
		// (set) Token: 0x0600670A RID: 26378 RVA: 0x0003084F File Offset: 0x0002EA4F
		public unsafe float _currentVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__currentVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__currentVolume)) = value;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x001E0054 File Offset: 0x001DE254
		// (set) Token: 0x0600670C RID: 26380 RVA: 0x0003086A File Offset: 0x0002EA6A
		public unsafe List<IAudioZoneModifier> _modifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__modifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAudioZoneModifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__modifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046E4 RID: 18148
		private static readonly IntPtr NativeFieldInfoPtr_VolumeChangeRate;

		// Token: 0x040046E5 RID: 18149
		private static readonly IntPtr NativeFieldInfoPtr_UpdateInterval;

		// Token: 0x040046E6 RID: 18150
		private static readonly IntPtr NativeFieldInfoPtr__maximumAudibleDistance;

		// Token: 0x040046E7 RID: 18151
		private static readonly IntPtr NativeFieldInfoPtr__tracks;

		// Token: 0x040046E8 RID: 18152
		private static readonly IntPtr NativeFieldInfoPtr__localCameraDistance;

		// Token: 0x040046E9 RID: 18153
		private static readonly IntPtr NativeFieldInfoPtr__currentVolume;

		// Token: 0x040046EA RID: 18154
		private static readonly IntPtr NativeFieldInfoPtr__modifiers;

		// Token: 0x040046EB RID: 18155
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040046EC RID: 18156
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040046ED RID: 18157
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0;

		// Token: 0x040046EE RID: 18158
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040046EF RID: 18159
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierMultiplier_Private_Single_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCameraDistance_Private_Void_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Public_Void_IAudioZoneModifier_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly IntPtr NativeMethodInfoPtr_RemoveModifier_Public_Void_IAudioZoneModifier_0;

		// Token: 0x040046F3 RID: 18163
		private static readonly IntPtr NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0;

		// Token: 0x040046F4 RID: 18164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
