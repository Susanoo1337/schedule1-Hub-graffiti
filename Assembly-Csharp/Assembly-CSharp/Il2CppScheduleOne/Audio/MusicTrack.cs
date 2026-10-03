using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200047B RID: 1147
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x06006783 RID: 26499 RVA: 0x001E157C File Offset: 0x001DF77C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicTrack()
		{
			Il2CppClassPointerStore<MusicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr);
			MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "<IsPlaying>k__BackingField");
			MusicTrack.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Enabled");
			MusicTrack.NativeFieldInfoPtr__trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_trackName");
			MusicTrack.NativeFieldInfoPtr__priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_priority");
			MusicTrack.NativeFieldInfoPtr__volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_volumeMultiplier");
			MusicTrack.NativeFieldInfoPtr__fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_fadeInTime");
			MusicTrack.NativeFieldInfoPtr__fadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_fadeOutTime");
			MusicTrack.NativeFieldInfoPtr__autoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_autoFadeOut");
			MusicTrack.NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_audioSource");
			MusicTrack.NativeFieldInfoPtr__fadeVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "_fadeVolumeMultiplier");
			MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676831);
			MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676832);
			MusicTrack.NativeMethodInfoPtr_get_TrackName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676833);
			MusicTrack.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676834);
			MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676835);
			MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676836);
			MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676837);
			MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676838);
			MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676839);
			MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676840);
			MusicTrack.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676841);
			MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676842);
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06006784 RID: 26500 RVA: 0x001E1764 File Offset: 0x001DF964
		// (set) Token: 0x06006785 RID: 26501 RVA: 0x001E17A0 File Offset: 0x001DF9A0
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x001E17E0 File Offset: 0x001DF9E0
		public unsafe string TrackName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_TrackName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x001E1818 File Offset: 0x001DFA18
		public unsafe int Priority
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x001E1854 File Offset: 0x001DFA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215192, XrefRangeEnd = 215196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x001E1890 File Offset: 0x001DFA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215196, XrefRangeEnd = 215204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x001E18C4 File Offset: 0x001DFAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215204, RefRangeEnd = 215206, XrefRangeStart = 215204, XrefRangeEnd = 215204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x001E18F8 File Offset: 0x001DFAF8
		[CallerCount(0)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x001E192C File Offset: 0x001DFB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215206, XrefRangeEnd = 215207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x001E1968 File Offset: 0x001DFB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194677, RefRangeEnd = 194678, XrefRangeStart = 194677, XrefRangeEnd = 194678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x001E19A4 File Offset: 0x001DFBA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215213, RefRangeEnd = 215216, XrefRangeStart = 215207, XrefRangeEnd = 215213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x001E19E0 File Offset: 0x001DFBE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215221, RefRangeEnd = 215224, XrefRangeStart = 215216, XrefRangeEnd = 215221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x00030CAA File Offset: 0x0002EEAA
		public MusicTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x001E1A1C File Offset: 0x001DFC1C
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x00030CB3 File Offset: 0x0002EEB3
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x001E1A44 File Offset: 0x001DFC44
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x00030CCE File Offset: 0x0002EECE
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06006795 RID: 26517 RVA: 0x001E1A6C File Offset: 0x001DFC6C
		// (set) Token: 0x06006796 RID: 26518 RVA: 0x00030CE9 File Offset: 0x0002EEE9
		public unsafe string _trackName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__trackName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__trackName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06006797 RID: 26519 RVA: 0x001E1A94 File Offset: 0x001DFC94
		// (set) Token: 0x06006798 RID: 26520 RVA: 0x00030D08 File Offset: 0x0002EF08
		public unsafe int _priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__priority)) = value;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x001E1ABC File Offset: 0x001DFCBC
		// (set) Token: 0x0600679A RID: 26522 RVA: 0x00030D23 File Offset: 0x0002EF23
		public unsafe float _volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__volumeMultiplier)) = value;
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x001E1AE4 File Offset: 0x001DFCE4
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x00030D3E File Offset: 0x0002EF3E
		public unsafe float _fadeInTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeInTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeInTime)) = value;
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x0600679D RID: 26525 RVA: 0x001E1B0C File Offset: 0x001DFD0C
		// (set) Token: 0x0600679E RID: 26526 RVA: 0x00030D59 File Offset: 0x0002EF59
		public unsafe float _fadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeOutTime)) = value;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x001E1B34 File Offset: 0x001DFD34
		// (set) Token: 0x060067A0 RID: 26528 RVA: 0x00030D74 File Offset: 0x0002EF74
		public unsafe bool _autoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__autoFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__autoFadeOut)) = value;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x001E1B5C File Offset: 0x001DFD5C
		// (set) Token: 0x060067A2 RID: 26530 RVA: 0x00030D8F File Offset: 0x0002EF8F
		public unsafe AudioSourceController _audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x001E1B8C File Offset: 0x001DFD8C
		// (set) Token: 0x060067A4 RID: 26532 RVA: 0x00030DAE File Offset: 0x0002EFAE
		public unsafe float _fadeVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__fadeVolumeMultiplier)) = value;
			}
		}

		// Token: 0x0400473A RID: 18234
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x0400473B RID: 18235
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x0400473C RID: 18236
		private static readonly IntPtr NativeFieldInfoPtr__trackName;

		// Token: 0x0400473D RID: 18237
		private static readonly IntPtr NativeFieldInfoPtr__priority;

		// Token: 0x0400473E RID: 18238
		private static readonly IntPtr NativeFieldInfoPtr__volumeMultiplier;

		// Token: 0x0400473F RID: 18239
		private static readonly IntPtr NativeFieldInfoPtr__fadeInTime;

		// Token: 0x04004740 RID: 18240
		private static readonly IntPtr NativeFieldInfoPtr__fadeOutTime;

		// Token: 0x04004741 RID: 18241
		private static readonly IntPtr NativeFieldInfoPtr__autoFadeOut;

		// Token: 0x04004742 RID: 18242
		private static readonly IntPtr NativeFieldInfoPtr__audioSource;

		// Token: 0x04004743 RID: 18243
		private static readonly IntPtr NativeFieldInfoPtr__fadeVolumeMultiplier;

		// Token: 0x04004744 RID: 18244
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004745 RID: 18245
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004746 RID: 18246
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackName_Public_get_String_0;

		// Token: 0x04004747 RID: 18247
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_get_Int32_0;

		// Token: 0x04004748 RID: 18248
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004749 RID: 18249
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400474A RID: 18250
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x0400474B RID: 18251
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400474C RID: 18252
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x0400474D RID: 18253
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x0400474E RID: 18254
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400474F RID: 18255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
