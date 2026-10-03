using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200046F RID: 1135
	public class AudioClipListPlayer : MonoBehaviour
	{
		// Token: 0x0600666D RID: 26221 RVA: 0x001DE020 File Offset: 0x001DC220
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClipListPlayer()
		{
			Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioClipListPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr);
			AudioClipListPlayer.NativeFieldInfoPtr__clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, "_clips");
			AudioClipListPlayer.NativeFieldInfoPtr__shuffleOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, "_shuffleOnAwake");
			AudioClipListPlayer.NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, "_audioSource");
			AudioClipListPlayer.NativeFieldInfoPtr__currentClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, "_currentClipIndex");
			AudioClipListPlayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, 100676710);
			AudioClipListPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, 100676711);
			AudioClipListPlayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, 100676712);
			AudioClipListPlayer.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, 100676713);
			AudioClipListPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr, 100676714);
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x001DE104 File Offset: 0x001DC304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213841, XrefRangeEnd = 213851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipListPlayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x001DE138 File Offset: 0x001DC338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213851, XrefRangeEnd = 213864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipListPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x001DE16C File Offset: 0x001DC36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213864, XrefRangeEnd = 213879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipListPlayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x001DE1A0 File Offset: 0x001DC3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213879, XrefRangeEnd = 213885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipListPlayer.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x001DE1D4 File Offset: 0x001DC3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213885, XrefRangeEnd = 213893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClipListPlayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClipListPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipListPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x00030404 File Offset: 0x0002E604
		public AudioClipListPlayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06006674 RID: 26228 RVA: 0x001DE210 File Offset: 0x001DC410
		// (set) Token: 0x06006675 RID: 26229 RVA: 0x0003040D File Offset: 0x0002E60D
		public unsafe List<AudioClip> _clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x001DE240 File Offset: 0x001DC440
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x0003042C File Offset: 0x0002E62C
		public unsafe bool _shuffleOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__shuffleOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__shuffleOnAwake)) = value;
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x001DE268 File Offset: 0x001DC468
		// (set) Token: 0x06006679 RID: 26233 RVA: 0x00030447 File Offset: 0x0002E647
		public unsafe AudioSourceController _audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600667A RID: 26234 RVA: 0x001DE298 File Offset: 0x001DC498
		// (set) Token: 0x0600667B RID: 26235 RVA: 0x00030466 File Offset: 0x0002E666
		public unsafe int _currentClipIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__currentClipIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipListPlayer.NativeFieldInfoPtr__currentClipIndex)) = value;
			}
		}

		// Token: 0x04004687 RID: 18055
		private static readonly IntPtr NativeFieldInfoPtr__clips;

		// Token: 0x04004688 RID: 18056
		private static readonly IntPtr NativeFieldInfoPtr__shuffleOnAwake;

		// Token: 0x04004689 RID: 18057
		private static readonly IntPtr NativeFieldInfoPtr__audioSource;

		// Token: 0x0400468A RID: 18058
		private static readonly IntPtr NativeFieldInfoPtr__currentClipIndex;

		// Token: 0x0400468B RID: 18059
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400468C RID: 18060
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400468D RID: 18061
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400468E RID: 18062
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x0400468F RID: 18063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
