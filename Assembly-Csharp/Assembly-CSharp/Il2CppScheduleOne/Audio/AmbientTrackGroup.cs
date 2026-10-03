using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200046E RID: 1134
	public class AmbientTrackGroup : MonoBehaviour
	{
		// Token: 0x0600664F RID: 26191 RVA: 0x001DDBAC File Offset: 0x001DBDAC
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientTrackGroup()
		{
			Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientTrackGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr);
			AmbientTrackGroup.NativeFieldInfoPtr_AmbientTrackCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "AmbientTrackCooldown");
			AmbientTrackGroup.NativeFieldInfoPtr_TimeOnLastAmbientTrackStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "TimeOnLastAmbientTrackStart");
			AmbientTrackGroup.NativeFieldInfoPtr_LastPlayedTrackGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "LastPlayedTrackGroup");
			AmbientTrackGroup.NativeFieldInfoPtr_IsAnyTrackGroupQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "IsAnyTrackGroupQueued");
			AmbientTrackGroup.NativeFieldInfoPtr__trackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_trackList");
			AmbientTrackGroup.NativeFieldInfoPtr__windowStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_windowStartTime");
			AmbientTrackGroup.NativeFieldInfoPtr__windowEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_windowEndTime");
			AmbientTrackGroup.NativeFieldInfoPtr__chanceToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_chanceToPlay");
			AmbientTrackGroup.NativeFieldInfoPtr__startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_startTime");
			AmbientTrackGroup.NativeFieldInfoPtr__playTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_playTrack");
			AmbientTrackGroup.NativeFieldInfoPtr__trackRandomized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, "_trackRandomized");
			AmbientTrackGroup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676704);
			AmbientTrackGroup.NativeMethodInfoPtr_ForcePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676705);
			AmbientTrackGroup.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676706);
			AmbientTrackGroup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676707);
			AmbientTrackGroup.NativeMethodInfoPtr_CanPlayNow_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676708);
			AmbientTrackGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr, 100676709);
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x001DDD30 File Offset: 0x001DBF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213673, XrefRangeEnd = 213686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrackGroup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x001DDD64 File Offset: 0x001DBF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213686, XrefRangeEnd = 213708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForcePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrackGroup.NativeMethodInfoPtr_ForcePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x001DDD98 File Offset: 0x001DBF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213708, XrefRangeEnd = 213714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrackGroup.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x001DDDCC File Offset: 0x001DBFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213714, XrefRangeEnd = 213795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrackGroup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001DDE00 File Offset: 0x001DC000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213795, XrefRangeEnd = 213833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPlayNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmbientTrackGroup.NativeMethodInfoPtr_CanPlayNow_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x001DDE48 File Offset: 0x001DC048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213833, XrefRangeEnd = 213841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientTrackGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientTrackGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrackGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x000302FE File Offset: 0x0002E4FE
		public AmbientTrackGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x001DDE84 File Offset: 0x001DC084
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x00030307 File Offset: 0x0002E507
		public unsafe static float AmbientTrackCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrackGroup.NativeFieldInfoPtr_AmbientTrackCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrackGroup.NativeFieldInfoPtr_AmbientTrackCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x001DDEA0 File Offset: 0x001DC0A0
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x00030315 File Offset: 0x0002E515
		public unsafe static float TimeOnLastAmbientTrackStart
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrackGroup.NativeFieldInfoPtr_TimeOnLastAmbientTrackStart, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrackGroup.NativeFieldInfoPtr_TimeOnLastAmbientTrackStart, (void*)(&value));
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x001DDEBC File Offset: 0x001DC0BC
		// (set) Token: 0x0600665C RID: 26204 RVA: 0x00030323 File Offset: 0x0002E523
		public unsafe static AmbientTrackGroup LastPlayedTrackGroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrackGroup.NativeFieldInfoPtr_LastPlayedTrackGroup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientTrackGroup>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrackGroup.NativeFieldInfoPtr_LastPlayedTrackGroup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x001DDEE4 File Offset: 0x001DC0E4
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x00030335 File Offset: 0x0002E535
		public unsafe static bool IsAnyTrackGroupQueued
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrackGroup.NativeFieldInfoPtr_IsAnyTrackGroupQueued, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrackGroup.NativeFieldInfoPtr_IsAnyTrackGroupQueued, (void*)(&value));
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x001DDF00 File Offset: 0x001DC100
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x00030343 File Offset: 0x0002E543
		public unsafe List<MusicTrack> _trackList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__trackList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__trackList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x001DDF30 File Offset: 0x001DC130
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x00030362 File Offset: 0x0002E562
		public unsafe int _windowStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__windowStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__windowStartTime)) = value;
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06006663 RID: 26211 RVA: 0x001DDF58 File Offset: 0x001DC158
		// (set) Token: 0x06006664 RID: 26212 RVA: 0x0003037D File Offset: 0x0002E57D
		public unsafe int _windowEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__windowEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__windowEndTime)) = value;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x001DDF80 File Offset: 0x001DC180
		// (set) Token: 0x06006666 RID: 26214 RVA: 0x00030398 File Offset: 0x0002E598
		public unsafe float _chanceToPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__chanceToPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__chanceToPlay)) = value;
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06006667 RID: 26215 RVA: 0x001DDFA8 File Offset: 0x001DC1A8
		// (set) Token: 0x06006668 RID: 26216 RVA: 0x000303B3 File Offset: 0x0002E5B3
		public unsafe int _startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__startTime)) = value;
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06006669 RID: 26217 RVA: 0x001DDFD0 File Offset: 0x001DC1D0
		// (set) Token: 0x0600666A RID: 26218 RVA: 0x000303CE File Offset: 0x0002E5CE
		public unsafe bool _playTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__playTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__playTrack)) = value;
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600666B RID: 26219 RVA: 0x001DDFF8 File Offset: 0x001DC1F8
		// (set) Token: 0x0600666C RID: 26220 RVA: 0x000303E9 File Offset: 0x0002E5E9
		public unsafe bool _trackRandomized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__trackRandomized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrackGroup.NativeFieldInfoPtr__trackRandomized)) = value;
			}
		}

		// Token: 0x04004676 RID: 18038
		private static readonly IntPtr NativeFieldInfoPtr_AmbientTrackCooldown;

		// Token: 0x04004677 RID: 18039
		private static readonly IntPtr NativeFieldInfoPtr_TimeOnLastAmbientTrackStart;

		// Token: 0x04004678 RID: 18040
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedTrackGroup;

		// Token: 0x04004679 RID: 18041
		private static readonly IntPtr NativeFieldInfoPtr_IsAnyTrackGroupQueued;

		// Token: 0x0400467A RID: 18042
		private static readonly IntPtr NativeFieldInfoPtr__trackList;

		// Token: 0x0400467B RID: 18043
		private static readonly IntPtr NativeFieldInfoPtr__windowStartTime;

		// Token: 0x0400467C RID: 18044
		private static readonly IntPtr NativeFieldInfoPtr__windowEndTime;

		// Token: 0x0400467D RID: 18045
		private static readonly IntPtr NativeFieldInfoPtr__chanceToPlay;

		// Token: 0x0400467E RID: 18046
		private static readonly IntPtr NativeFieldInfoPtr__startTime;

		// Token: 0x0400467F RID: 18047
		private static readonly IntPtr NativeFieldInfoPtr__playTrack;

		// Token: 0x04004680 RID: 18048
		private static readonly IntPtr NativeFieldInfoPtr__trackRandomized;

		// Token: 0x04004681 RID: 18049
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004682 RID: 18050
		private static readonly IntPtr NativeMethodInfoPtr_ForcePlay_Public_Void_0;

		// Token: 0x04004683 RID: 18051
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04004684 RID: 18052
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004685 RID: 18053
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayNow_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004686 RID: 18054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
