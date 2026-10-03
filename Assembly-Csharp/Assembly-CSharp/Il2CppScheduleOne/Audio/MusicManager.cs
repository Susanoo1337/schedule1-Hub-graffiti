using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Audio;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000479 RID: 1145
	public class MusicManager : PersistentSingleton<MusicManager>
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x001E0F34 File Offset: 0x001DF134
		// Note: this type is marked as 'beforefieldinit'.
		static MusicManager()
		{
			Il2CppClassPointerStore<MusicManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager>.NativeClassPtr);
			MusicManager.NativeFieldInfoPtr_TrackUpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "TrackUpdateInterval");
			MusicManager.NativeFieldInfoPtr__defaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "_defaultSnapshot");
			MusicManager.NativeFieldInfoPtr__distortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "_distortedSnapshot");
			MusicManager.NativeFieldInfoPtr__tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "_tracks");
			MusicManager.NativeFieldInfoPtr__currentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "_currentTrack");
			MusicManager.NativeMethodInfoPtr_get_IsAnyTrackPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676811);
			MusicManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676812);
			MusicManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676813);
			MusicManager.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676814);
			MusicManager.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676815);
			MusicManager.NativeMethodInfoPtr_TryGetTrack_Public_Boolean_String_byref_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676816);
			MusicManager.NativeMethodInfoPtr_StopTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676817);
			MusicManager.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676818);
			MusicManager.NativeMethodInfoPtr_UpdateTracks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676819);
			MusicManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676820);
			MusicManager.NativeMethodInfoPtr__Start_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, 100676821);
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x001E10A4 File Offset: 0x001DF2A4
		public unsafe bool IsAnyTrackPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214958, XrefRangeEnd = 214962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_get_IsAnyTrackPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x001E10E0 File Offset: 0x001DF2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214962, XrefRangeEnd = 214993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x001E111C File Offset: 0x001DF31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214993, XrefRangeEnd = 215008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x001E1158 File Offset: 0x001DF358
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 215011, RefRangeEnd = 215021, XrefRangeStart = 215008, XrefRangeEnd = 215011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x001E11A4 File Offset: 0x001DF3A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 215041, RefRangeEnd = 215048, XrefRangeStart = 215021, XrefRangeEnd = 215041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrackEnabled(string trackName, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x001E11F4 File Offset: 0x001DF3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215068, RefRangeEnd = 215070, XrefRangeStart = 215048, XrefRangeEnd = 215068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTrack(string trackName, out MusicTrack track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_TryGetTrack_Public_Boolean_String_byref_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			track = ((intPtr4 == 0) ? null : new MusicTrack(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x001E1264 File Offset: 0x001DF464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215096, RefRangeEnd = 215097, XrefRangeStart = 215070, XrefRangeEnd = 215096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_StopTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x001E12A8 File Offset: 0x001DF4A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215111, RefRangeEnd = 215114, XrefRangeStart = 215097, XrefRangeEnd = 215111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAndDisableTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x001E12DC File Offset: 0x001DF4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215114, XrefRangeEnd = 215150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr_UpdateTracks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x001E1310 File Offset: 0x001DF510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215150, XrefRangeEnd = 215160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x001E134C File Offset: 0x001DF54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215160, XrefRangeEnd = 215162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__8_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.NativeMethodInfoPtr__Start_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00030C0E File Offset: 0x0002EE0E
		public MusicManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x001E1380 File Offset: 0x001DF580
		// (set) Token: 0x06006775 RID: 26485 RVA: 0x00030C17 File Offset: 0x0002EE17
		public unsafe static float TrackUpdateInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicManager.NativeFieldInfoPtr_TrackUpdateInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicManager.NativeFieldInfoPtr_TrackUpdateInterval, (void*)(&value));
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x001E139C File Offset: 0x001DF59C
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x00030C25 File Offset: 0x0002EE25
		public unsafe AudioMixerSnapshot _defaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__defaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__defaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x001E13CC File Offset: 0x001DF5CC
		// (set) Token: 0x06006779 RID: 26489 RVA: 0x00030C44 File Offset: 0x0002EE44
		public unsafe AudioMixerSnapshot _distortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__distortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__distortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x001E13FC File Offset: 0x001DF5FC
		// (set) Token: 0x0600677B RID: 26491 RVA: 0x00030C63 File Offset: 0x0002EE63
		public unsafe List<MusicTrack> _tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x001E142C File Offset: 0x001DF62C
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x00030C82 File Offset: 0x0002EE82
		public unsafe MusicTrack _currentTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__currentTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.NativeFieldInfoPtr__currentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004727 RID: 18215
		private static readonly IntPtr NativeFieldInfoPtr_TrackUpdateInterval;

		// Token: 0x04004728 RID: 18216
		private static readonly IntPtr NativeFieldInfoPtr__defaultSnapshot;

		// Token: 0x04004729 RID: 18217
		private static readonly IntPtr NativeFieldInfoPtr__distortedSnapshot;

		// Token: 0x0400472A RID: 18218
		private static readonly IntPtr NativeFieldInfoPtr__tracks;

		// Token: 0x0400472B RID: 18219
		private static readonly IntPtr NativeFieldInfoPtr__currentTrack;

		// Token: 0x0400472C RID: 18220
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnyTrackPlaying_Public_get_Boolean_0;

		// Token: 0x0400472D RID: 18221
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400472E RID: 18222
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400472F RID: 18223
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004730 RID: 18224
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0;

		// Token: 0x04004731 RID: 18225
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTrack_Public_Boolean_String_byref_MusicTrack_0;

		// Token: 0x04004732 RID: 18226
		private static readonly IntPtr NativeMethodInfoPtr_StopTrack_Public_Void_String_0;

		// Token: 0x04004733 RID: 18227
		private static readonly IntPtr NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0;

		// Token: 0x04004734 RID: 18228
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTracks_Private_Void_0;

		// Token: 0x04004735 RID: 18229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004736 RID: 18230
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Void_0;

		// Token: 0x02000B4A RID: 2890
		[ObfuscatedName("ScheduleOne.Audio.MusicManager+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600E73C RID: 59196 RVA: 0x00386030 File Offset: 0x00384230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr);
				MusicManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr, "trackName");
				MusicManager.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr, 100676822);
				MusicManager.__c__DisplayClass10_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr, 100676823);
			}

			// Token: 0x0600E73D RID: 59197 RVA: 0x00386098 File Offset: 0x00384298
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E73E RID: 59198 RVA: 0x003860D4 File Offset: 0x003842D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetTrackEnabled_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass10_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E73F RID: 59199 RVA: 0x0006D11A File Offset: 0x0006B31A
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462C RID: 17964
			// (get) Token: 0x0600E740 RID: 59200 RVA: 0x00386124 File Offset: 0x00384324
			// (set) Token: 0x0600E741 RID: 59201 RVA: 0x0006D123 File Offset: 0x0006B323
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass10_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009CF9 RID: 40185
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04009CFA RID: 40186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CFB RID: 40187
			private static readonly IntPtr NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0;
		}

		// Token: 0x02000B4B RID: 2891
		[ObfuscatedName("ScheduleOne.Audio.MusicManager+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600E742 RID: 59202 RVA: 0x0038614C File Offset: 0x0038434C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr);
				MusicManager.__c__DisplayClass11_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr, "trackName");
				MusicManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr, 100676824);
				MusicManager.__c__DisplayClass11_0.NativeMethodInfoPtr__TryGetTrack_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr, 100676825);
			}

			// Token: 0x0600E743 RID: 59203 RVA: 0x003861B4 File Offset: 0x003843B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E744 RID: 59204 RVA: 0x003861F0 File Offset: 0x003843F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetTrack_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass11_0.NativeMethodInfoPtr__TryGetTrack_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E745 RID: 59205 RVA: 0x0006D142 File Offset: 0x0006B342
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462D RID: 17965
			// (get) Token: 0x0600E746 RID: 59206 RVA: 0x00386240 File Offset: 0x00384440
			// (set) Token: 0x0600E747 RID: 59207 RVA: 0x0006D14B File Offset: 0x0006B34B
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass11_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass11_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009CFC RID: 40188
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04009CFD RID: 40189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CFE RID: 40190
			private static readonly IntPtr NativeMethodInfoPtr__TryGetTrack_b__0_Internal_Boolean_MusicTrack_0;
		}

		// Token: 0x02000B4C RID: 2892
		[ObfuscatedName("ScheduleOne.Audio.MusicManager+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600E748 RID: 59208 RVA: 0x00386268 File Offset: 0x00384468
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicManager>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr);
				MusicManager.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr, "trackName");
				MusicManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr, 100676826);
				MusicManager.__c__DisplayClass12_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr, 100676827);
			}

			// Token: 0x0600E749 RID: 59209 RVA: 0x003862D0 File Offset: 0x003844D0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicManager.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E74A RID: 59210 RVA: 0x0038630C File Offset: 0x0038450C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopTrack_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicManager.__c__DisplayClass12_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E74B RID: 59211 RVA: 0x0006D16A File Offset: 0x0006B36A
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462E RID: 17966
			// (get) Token: 0x0600E74C RID: 59212 RVA: 0x0038635C File Offset: 0x0038455C
			// (set) Token: 0x0600E74D RID: 59213 RVA: 0x0006D173 File Offset: 0x0006B373
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicManager.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009CFF RID: 40191
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04009D00 RID: 40192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D01 RID: 40193
			private static readonly IntPtr NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0;
		}
	}
}
