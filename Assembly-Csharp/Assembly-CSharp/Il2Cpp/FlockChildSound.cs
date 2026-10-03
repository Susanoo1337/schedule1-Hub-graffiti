using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000030 RID: 48
	public class FlockChildSound : MonoBehaviour
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00083558 File Offset: 0x00081758
		// Note: this type is marked as 'beforefieldinit'.
		static FlockChildSound()
		{
			Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockChildSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr);
			FlockChildSound.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "controller");
			FlockChildSound.NativeFieldInfoPtr__idleSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSounds");
			FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__flightSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSounds");
			FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__scareSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_scareSounds");
			FlockChildSound.NativeFieldInfoPtr__pitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMin");
			FlockChildSound.NativeFieldInfoPtr__pitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMax");
			FlockChildSound.NativeFieldInfoPtr__volumeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMin");
			FlockChildSound.NativeFieldInfoPtr__volumeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMax");
			FlockChildSound.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flockChild");
			FlockChildSound.NativeFieldInfoPtr__audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_audio");
			FlockChildSound.NativeFieldInfoPtr__hasLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_hasLanded");
			FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663591);
			FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663592);
			FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663593);
			FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663594);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000836DC File Offset: 0x000818DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67807, XrefRangeEnd = 67822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00083710 File Offset: 0x00081910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67822, XrefRangeEnd = 67832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRandomSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00083744 File Offset: 0x00081944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67832, XrefRangeEnd = 67841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00083778 File Offset: 0x00081978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67841, XrefRangeEnd = 67842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockChildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000035E0 File Offset: 0x000017E0
		public FlockChildSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000837B4 File Offset: 0x000819B4
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000035E9 File Offset: 0x000017E9
		public unsafe AudioSourceController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000837E4 File Offset: 0x000819E4
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003608 File Offset: 0x00001808
		public unsafe Il2CppReferenceArray<AudioClip> _idleSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00083814 File Offset: 0x00081A14
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003627 File Offset: 0x00001827
		public unsafe float _idleSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0008383C File Offset: 0x00081A3C
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003642 File Offset: 0x00001842
		public unsafe Il2CppReferenceArray<AudioClip> _flightSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0008386C File Offset: 0x00081A6C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003661 File Offset: 0x00001861
		public unsafe float _flightSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00083894 File Offset: 0x00081A94
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000367C File Offset: 0x0000187C
		public unsafe Il2CppReferenceArray<AudioClip> _scareSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000838C4 File Offset: 0x00081AC4
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000369B File Offset: 0x0000189B
		public unsafe float _pitchMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000838EC File Offset: 0x00081AEC
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000036B6 File Offset: 0x000018B6
		public unsafe float _pitchMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00083914 File Offset: 0x00081B14
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000036D1 File Offset: 0x000018D1
		public unsafe float _volumeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0008393C File Offset: 0x00081B3C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000036EC File Offset: 0x000018EC
		public unsafe float _volumeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00083964 File Offset: 0x00081B64
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00003707 File Offset: 0x00001907
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00083994 File Offset: 0x00081B94
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00003726 File Offset: 0x00001926
		public unsafe AudioSource _audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000839C4 File Offset: 0x00081BC4
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003745 File Offset: 0x00001945
		public unsafe bool _hasLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded)) = value;
			}
		}

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr__idleSounds;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr__idleSoundRandomChance;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr__flightSounds;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr__flightSoundRandomChance;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr__scareSounds;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr__pitchMin;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr__pitchMax;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr__volumeMin;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr__volumeMax;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr__audio;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr__hasLanded;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_PlayRandomSound_Public_Void_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_ScareSound_Public_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
