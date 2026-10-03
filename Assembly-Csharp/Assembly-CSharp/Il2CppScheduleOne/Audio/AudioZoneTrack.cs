using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000474 RID: 1140
	[Serializable]
	public class AudioZoneTrack : Object
	{
		// Token: 0x0600671A RID: 26394 RVA: 0x001E02F8 File Offset: 0x001DE4F8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZoneTrack()
		{
			Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZoneTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr);
			AudioZoneTrack.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "Source");
			AudioZoneTrack.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "Volume");
			AudioZoneTrack.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "StartTime");
			AudioZoneTrack.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "EndTime");
			AudioZoneTrack.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "FadeTime");
			AudioZoneTrack.NativeFieldInfoPtr_timeVolMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "timeVolMultiplier");
			AudioZoneTrack.NativeFieldInfoPtr_fadeInStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeInStart");
			AudioZoneTrack.NativeFieldInfoPtr_fadeInEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeInEnd");
			AudioZoneTrack.NativeFieldInfoPtr_fadeOutStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeOutStart");
			AudioZoneTrack.NativeFieldInfoPtr_fadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeOutEnd");
			AudioZoneTrack.NativeFieldInfoPtr_fadeInStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeInStartMinSum");
			AudioZoneTrack.NativeFieldInfoPtr_fadeInEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeInEndMinSum");
			AudioZoneTrack.NativeFieldInfoPtr_fadeOutStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeOutStartMinSum");
			AudioZoneTrack.NativeFieldInfoPtr_fadeOutEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, "fadeOutEndMinSum");
			AudioZoneTrack.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, 100676792);
			AudioZoneTrack.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, 100676793);
			AudioZoneTrack.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, 100676794);
			AudioZoneTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr, 100676795);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x001E0490 File Offset: 0x001DE690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214857, XrefRangeEnd = 214868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneTrack.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x001E04C4 File Offset: 0x001DE6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214868, XrefRangeEnd = 214871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneTrack.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x001E0504 File Offset: 0x001DE704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214871, XrefRangeEnd = 214883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeMultiplier(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneTrack.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x001E0544 File Offset: 0x001DE744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214883, XrefRangeEnd = 214884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZoneTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x000308EB File Offset: 0x0002EAEB
		public AudioZoneTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x001E0580 File Offset: 0x001DE780
		// (set) Token: 0x06006721 RID: 26401 RVA: 0x000308F4 File Offset: 0x0002EAF4
		public unsafe AudioSourceController Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06006722 RID: 26402 RVA: 0x001E05B0 File Offset: 0x001DE7B0
		// (set) Token: 0x06006723 RID: 26403 RVA: 0x00030913 File Offset: 0x0002EB13
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x001E05D8 File Offset: 0x001DE7D8
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x0003092E File Offset: 0x0002EB2E
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x001E0600 File Offset: 0x001DE800
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x00030949 File Offset: 0x0002EB49
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x001E0628 File Offset: 0x001DE828
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x00030964 File Offset: 0x0002EB64
		public unsafe int FadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_FadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_FadeTime)) = value;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x001E0650 File Offset: 0x001DE850
		// (set) Token: 0x0600672B RID: 26411 RVA: 0x0003097F File Offset: 0x0002EB7F
		public unsafe float timeVolMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_timeVolMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_timeVolMultiplier)) = value;
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x001E0678 File Offset: 0x001DE878
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x0003099A File Offset: 0x0002EB9A
		public unsafe int fadeInStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInStart)) = value;
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x001E06A0 File Offset: 0x001DE8A0
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x000309B5 File Offset: 0x0002EBB5
		public unsafe int fadeInEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInEnd)) = value;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x001E06C8 File Offset: 0x001DE8C8
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x000309D0 File Offset: 0x0002EBD0
		public unsafe int fadeOutStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutStart)) = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x001E06F0 File Offset: 0x001DE8F0
		// (set) Token: 0x06006733 RID: 26419 RVA: 0x000309EB File Offset: 0x0002EBEB
		public unsafe int fadeOutEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutEnd)) = value;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x001E0718 File Offset: 0x001DE918
		// (set) Token: 0x06006735 RID: 26421 RVA: 0x00030A06 File Offset: 0x0002EC06
		public unsafe int fadeInStartMinSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInStartMinSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInStartMinSum)) = value;
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x001E0740 File Offset: 0x001DE940
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x00030A21 File Offset: 0x0002EC21
		public unsafe int fadeInEndMinSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInEndMinSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeInEndMinSum)) = value;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06006738 RID: 26424 RVA: 0x001E0768 File Offset: 0x001DE968
		// (set) Token: 0x06006739 RID: 26425 RVA: 0x00030A3C File Offset: 0x0002EC3C
		public unsafe int fadeOutStartMinSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutStartMinSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutStartMinSum)) = value;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x001E0790 File Offset: 0x001DE990
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x00030A57 File Offset: 0x0002EC57
		public unsafe int fadeOutEndMinSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutEndMinSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneTrack.NativeFieldInfoPtr_fadeOutEndMinSum)) = value;
			}
		}

		// Token: 0x040046FD RID: 18173
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040046FE RID: 18174
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x040046FF RID: 18175
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04004700 RID: 18176
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04004701 RID: 18177
		private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

		// Token: 0x04004702 RID: 18178
		private static readonly IntPtr NativeFieldInfoPtr_timeVolMultiplier;

		// Token: 0x04004703 RID: 18179
		private static readonly IntPtr NativeFieldInfoPtr_fadeInStart;

		// Token: 0x04004704 RID: 18180
		private static readonly IntPtr NativeFieldInfoPtr_fadeInEnd;

		// Token: 0x04004705 RID: 18181
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutStart;

		// Token: 0x04004706 RID: 18182
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutEnd;

		// Token: 0x04004707 RID: 18183
		private static readonly IntPtr NativeFieldInfoPtr_fadeInStartMinSum;

		// Token: 0x04004708 RID: 18184
		private static readonly IntPtr NativeFieldInfoPtr_fadeInEndMinSum;

		// Token: 0x04004709 RID: 18185
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutStartMinSum;

		// Token: 0x0400470A RID: 18186
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutEndMinSum;

		// Token: 0x0400470B RID: 18187
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x0400470C RID: 18188
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

		// Token: 0x0400470D RID: 18189
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0;

		// Token: 0x0400470E RID: 18190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
