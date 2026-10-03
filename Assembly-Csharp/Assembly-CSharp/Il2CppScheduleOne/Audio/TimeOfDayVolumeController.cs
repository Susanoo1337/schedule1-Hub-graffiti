using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000486 RID: 1158
	public class TimeOfDayVolumeController : MonoBehaviour
	{
		// Token: 0x06006835 RID: 26677 RVA: 0x001E36C4 File Offset: 0x001E18C4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeOfDayVolumeController()
		{
			Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "TimeOfDayVolumeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr);
			TimeOfDayVolumeController.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "MinVolume");
			TimeOfDayVolumeController.NativeFieldInfoPtr_FadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "FadeSpeed");
			TimeOfDayVolumeController.NativeFieldInfoPtr__timeOfDayVolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "_timeOfDayVolumeCurve");
			TimeOfDayVolumeController.NativeFieldInfoPtr__reduceVolumeWhenSoundtrackPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "_reduceVolumeWhenSoundtrackPlaying");
			TimeOfDayVolumeController.NativeFieldInfoPtr__audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "_audioSourceController");
			TimeOfDayVolumeController.NativeFieldInfoPtr__volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, "_volumeMultiplier");
			TimeOfDayVolumeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, 100676924);
			TimeOfDayVolumeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, 100676925);
			TimeOfDayVolumeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr, 100676926);
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x001E37A8 File Offset: 0x001E19A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215901, XrefRangeEnd = 215905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayVolumeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x001E37DC File Offset: 0x001E19DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215905, XrefRangeEnd = 215925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayVolumeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x001E3810 File Offset: 0x001E1A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215925, XrefRangeEnd = 215926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeOfDayVolumeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayVolumeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayVolumeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00031193 File Offset: 0x0002F393
		public TimeOfDayVolumeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x001E384C File Offset: 0x001E1A4C
		// (set) Token: 0x0600683B RID: 26683 RVA: 0x0003119C File Offset: 0x0002F39C
		public unsafe static float MinVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TimeOfDayVolumeController.NativeFieldInfoPtr_MinVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeOfDayVolumeController.NativeFieldInfoPtr_MinVolume, (void*)(&value));
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x001E3868 File Offset: 0x001E1A68
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x000311AA File Offset: 0x0002F3AA
		public unsafe static float FadeSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TimeOfDayVolumeController.NativeFieldInfoPtr_FadeSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeOfDayVolumeController.NativeFieldInfoPtr_FadeSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x001E3884 File Offset: 0x001E1A84
		// (set) Token: 0x0600683F RID: 26687 RVA: 0x000311B8 File Offset: 0x0002F3B8
		public unsafe AnimationCurve _timeOfDayVolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__timeOfDayVolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__timeOfDayVolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x001E38B4 File Offset: 0x001E1AB4
		// (set) Token: 0x06006841 RID: 26689 RVA: 0x000311D7 File Offset: 0x0002F3D7
		public unsafe bool _reduceVolumeWhenSoundtrackPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__reduceVolumeWhenSoundtrackPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__reduceVolumeWhenSoundtrackPlaying)) = value;
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06006842 RID: 26690 RVA: 0x001E38DC File Offset: 0x001E1ADC
		// (set) Token: 0x06006843 RID: 26691 RVA: 0x000311F2 File Offset: 0x0002F3F2
		public unsafe AudioSourceController _audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06006844 RID: 26692 RVA: 0x001E390C File Offset: 0x001E1B0C
		// (set) Token: 0x06006845 RID: 26693 RVA: 0x00031211 File Offset: 0x0002F411
		public unsafe float _volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayVolumeController.NativeFieldInfoPtr__volumeMultiplier)) = value;
			}
		}

		// Token: 0x040047A8 RID: 18344
		private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

		// Token: 0x040047A9 RID: 18345
		private static readonly IntPtr NativeFieldInfoPtr_FadeSpeed;

		// Token: 0x040047AA RID: 18346
		private static readonly IntPtr NativeFieldInfoPtr__timeOfDayVolumeCurve;

		// Token: 0x040047AB RID: 18347
		private static readonly IntPtr NativeFieldInfoPtr__reduceVolumeWhenSoundtrackPlaying;

		// Token: 0x040047AC RID: 18348
		private static readonly IntPtr NativeFieldInfoPtr__audioSourceController;

		// Token: 0x040047AD RID: 18349
		private static readonly IntPtr NativeFieldInfoPtr__volumeMultiplier;

		// Token: 0x040047AE RID: 18350
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040047AF RID: 18351
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040047B0 RID: 18352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
