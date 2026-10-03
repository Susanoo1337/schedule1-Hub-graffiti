using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200047D RID: 1149
	public class PursuitMusicTrack : MusicTrack
	{
		// Token: 0x060067AF RID: 26543 RVA: 0x001E1E0C File Offset: 0x001E000C
		// Note: this type is marked as 'beforefieldinit'.
		static PursuitMusicTrack()
		{
			Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "PursuitMusicTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr);
			PursuitMusicTrack.NativeFieldInfoPtr_OutOfSightTimeToDipMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, "OutOfSightTimeToDipMusic");
			PursuitMusicTrack.NativeFieldInfoPtr_MinMusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, "MinMusicVolume");
			PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, "MusicChangeRate_Down");
			PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, "MusicChangeRate_Up");
			PursuitMusicTrack.NativeFieldInfoPtr__pursuitLevelToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, "_pursuitLevelToActivate");
			PursuitMusicTrack.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676855);
			PursuitMusicTrack.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676856);
			PursuitMusicTrack.NativeMethodInfoPtr_RegisterEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676857);
			PursuitMusicTrack.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676858);
			PursuitMusicTrack.NativeMethodInfoPtr_PursuitLevelChange_Private_Void_EPursuitLevel_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676859);
			PursuitMusicTrack.NativeMethodInfoPtr_GetNewVolume_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676860);
			PursuitMusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr, 100676861);
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x001E1F2C File Offset: 0x001E012C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215278, XrefRangeEnd = 215291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitMusicTrack.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x001E1F68 File Offset: 0x001E0168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215344, RefRangeEnd = 215345, XrefRangeStart = 215291, XrefRangeEnd = 215344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitMusicTrack.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x001E1F9C File Offset: 0x001E019C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215345, XrefRangeEnd = 215371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitMusicTrack.NativeMethodInfoPtr_RegisterEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x001E1FD0 File Offset: 0x001E01D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215371, XrefRangeEnd = 215386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitMusicTrack.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x001E200C File Offset: 0x001E020C
		[CallerCount(0)]
		public unsafe void PursuitLevelChange(PlayerCrimeData.EPursuitLevel oldLevel, PlayerCrimeData.EPursuitLevel newLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitMusicTrack.NativeMethodInfoPtr_PursuitLevelChange_Private_Void_EPursuitLevel_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x001E2058 File Offset: 0x001E0258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215386, XrefRangeEnd = 215400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNewVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitMusicTrack.NativeMethodInfoPtr_GetNewVolume_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x001E2094 File Offset: 0x001E0294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PursuitMusicTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitMusicTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitMusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x00030DF1 File Offset: 0x0002EFF1
		public PursuitMusicTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x001E20D0 File Offset: 0x001E02D0
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x00030DFA File Offset: 0x0002EFFA
		public unsafe static float OutOfSightTimeToDipMusic
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitMusicTrack.NativeFieldInfoPtr_OutOfSightTimeToDipMusic, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitMusicTrack.NativeFieldInfoPtr_OutOfSightTimeToDipMusic, (void*)(&value));
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x001E20EC File Offset: 0x001E02EC
		// (set) Token: 0x060067BB RID: 26555 RVA: 0x00030E08 File Offset: 0x0002F008
		public unsafe static float MinMusicVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitMusicTrack.NativeFieldInfoPtr_MinMusicVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitMusicTrack.NativeFieldInfoPtr_MinMusicVolume, (void*)(&value));
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x001E2108 File Offset: 0x001E0308
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x00030E16 File Offset: 0x0002F016
		public unsafe static float MusicChangeRate_Down
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Down, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Down, (void*)(&value));
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x001E2124 File Offset: 0x001E0324
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x00030E24 File Offset: 0x0002F024
		public unsafe static float MusicChangeRate_Up
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Up, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitMusicTrack.NativeFieldInfoPtr_MusicChangeRate_Up, (void*)(&value));
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x001E2140 File Offset: 0x001E0340
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x00030E32 File Offset: 0x0002F032
		public unsafe PlayerCrimeData.EPursuitLevel _pursuitLevelToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitMusicTrack.NativeFieldInfoPtr__pursuitLevelToActivate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitMusicTrack.NativeFieldInfoPtr__pursuitLevelToActivate)) = value;
			}
		}

		// Token: 0x04004757 RID: 18263
		private static readonly IntPtr NativeFieldInfoPtr_OutOfSightTimeToDipMusic;

		// Token: 0x04004758 RID: 18264
		private static readonly IntPtr NativeFieldInfoPtr_MinMusicVolume;

		// Token: 0x04004759 RID: 18265
		private static readonly IntPtr NativeFieldInfoPtr_MusicChangeRate_Down;

		// Token: 0x0400475A RID: 18266
		private static readonly IntPtr NativeFieldInfoPtr_MusicChangeRate_Up;

		// Token: 0x0400475B RID: 18267
		private static readonly IntPtr NativeFieldInfoPtr__pursuitLevelToActivate;

		// Token: 0x0400475C RID: 18268
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400475D RID: 18269
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x0400475E RID: 18270
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvent_Private_Void_0;

		// Token: 0x0400475F RID: 18271
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004760 RID: 18272
		private static readonly IntPtr NativeMethodInfoPtr_PursuitLevelChange_Private_Void_EPursuitLevel_EPursuitLevel_0;

		// Token: 0x04004761 RID: 18273
		private static readonly IntPtr NativeMethodInfoPtr_GetNewVolume_Private_Single_0;

		// Token: 0x04004762 RID: 18274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
