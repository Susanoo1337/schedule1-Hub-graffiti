using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000598 RID: 1432
	public class JukeboxInterface : MonoBehaviour
	{
		// Token: 0x0600822F RID: 33327 RVA: 0x0023A748 File Offset: 0x00238948
		// Note: this type is marked as 'beforefieldinit'.
		static JukeboxInterface()
		{
			Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "JukeboxInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr);
			JukeboxInterface.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "OpenTime");
			JukeboxInterface.NativeFieldInfoPtr_Fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "Fov");
			JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			JukeboxInterface.NativeFieldInfoPtr_Jukebox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "Jukebox");
			JukeboxInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "Canvas");
			JukeboxInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "CameraPosition");
			JukeboxInterface.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "IntObj");
			JukeboxInterface.NativeFieldInfoPtr_PausePlayImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PausePlayImage");
			JukeboxInterface.NativeFieldInfoPtr_ShuffleButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "ShuffleButton");
			JukeboxInterface.NativeFieldInfoPtr_RepeatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatButton");
			JukeboxInterface.NativeFieldInfoPtr_SyncButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SyncButton");
			JukeboxInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "EntryContainer");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplayContainer");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplaySongLabel");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplayTimeLabel");
			JukeboxInterface.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "State");
			JukeboxInterface.NativeFieldInfoPtr_PlaySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PlaySprite");
			JukeboxInterface.NativeFieldInfoPtr_PauseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PauseSprite");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPlaySprite");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPauseSprite");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_None");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_Track");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_Queue");
			JukeboxInterface.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "DeselectedColor");
			JukeboxInterface.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SelectedColor");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPrefab");
			JukeboxInterface.NativeFieldInfoPtr_songEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "songEntries");
			JukeboxInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680047);
			JukeboxInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680048);
			JukeboxInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680049);
			JukeboxInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680050);
			JukeboxInterface.NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680051);
			JukeboxInterface.NativeMethodInfoPtr_SetupSongEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680052);
			JukeboxInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680053);
			JukeboxInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680054);
			JukeboxInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680055);
			JukeboxInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680056);
			JukeboxInterface.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680057);
			JukeboxInterface.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680058);
			JukeboxInterface.NativeMethodInfoPtr_PlayPausePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680059);
			JukeboxInterface.NativeMethodInfoPtr_BackPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680060);
			JukeboxInterface.NativeMethodInfoPtr_NextPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680061);
			JukeboxInterface.NativeMethodInfoPtr_ShufflePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680062);
			JukeboxInterface.NativeMethodInfoPtr_RepeatPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680063);
			JukeboxInterface.NativeMethodInfoPtr_SyncPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680064);
			JukeboxInterface.NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680065);
			JukeboxInterface.NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680066);
			JukeboxInterface.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680067);
			JukeboxInterface.NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680068);
			JukeboxInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100680069);
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x0023AB60 File Offset: 0x00238D60
		// (set) Token: 0x06008231 RID: 33329 RVA: 0x0023AB9C File Offset: 0x00238D9C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x0023ABDC File Offset: 0x00238DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246311, XrefRangeEnd = 246361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x0023AC10 File Offset: 0x00238E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246361, XrefRangeEnd = 246362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x0023AC44 File Offset: 0x00238E44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246407, RefRangeEnd = 246410, XrefRangeStart = 246362, XrefRangeEnd = 246407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAmbientDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x0023AC78 File Offset: 0x00238E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246460, RefRangeEnd = 246461, XrefRangeStart = 246410, XrefRangeEnd = 246460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSongEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SetupSongEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x0023ACAC File Offset: 0x00238EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246461, XrefRangeEnd = 246475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x0023ACE0 File Offset: 0x00238EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246501, RefRangeEnd = 246502, XrefRangeStart = 246475, XrefRangeEnd = 246501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x0023AD14 File Offset: 0x00238F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246502, XrefRangeEnd = 246504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x0023AD48 File Offset: 0x00238F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246504, XrefRangeEnd = 246521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x0023AD7C File Offset: 0x00238F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246521, XrefRangeEnd = 246522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x0023ADB0 File Offset: 0x00238FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246522, XrefRangeEnd = 246523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x0023ADE4 File Offset: 0x00238FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246523, XrefRangeEnd = 246525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPausePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_PlayPausePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x0023AE18 File Offset: 0x00239018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246525, XrefRangeEnd = 246527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_BackPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0023AE4C File Offset: 0x0023904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246527, XrefRangeEnd = 246529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_NextPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x0023AE80 File Offset: 0x00239080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246529, XrefRangeEnd = 246531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShufflePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_ShufflePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x0023AEB4 File Offset: 0x002390B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246531, XrefRangeEnd = 246533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepeatPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RepeatPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x0023AEE8 File Offset: 0x002390E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246533, XrefRangeEnd = 246535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SyncPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x0023AF1C File Offset: 0x0023911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246535, XrefRangeEnd = 246543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SongEntryClicked(RectTransform entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x0023AF60 File Offset: 0x00239160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246564, RefRangeEnd = 246565, XrefRangeStart = 246543, XrefRangeEnd = 246564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSongEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x0023AF94 File Offset: 0x00239194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246579, RefRangeEnd = 246581, XrefRangeStart = 246565, XrefRangeEnd = 246579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x0023AFC8 File Offset: 0x002391C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246587, RefRangeEnd = 246588, XrefRangeStart = 246581, XrefRangeEnd = 246587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAmbientDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x0023AFFC File Offset: 0x002391FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246588, XrefRangeEnd = 246596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JukeboxInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x0003DC9D File Offset: 0x0003BE9D
		public JukeboxInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x06008248 RID: 33352 RVA: 0x0023B038 File Offset: 0x00239238
		// (set) Token: 0x06008249 RID: 33353 RVA: 0x0003DCA6 File Offset: 0x0003BEA6
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(JukeboxInterface.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JukeboxInterface.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600824A RID: 33354 RVA: 0x0023B054 File Offset: 0x00239254
		// (set) Token: 0x0600824B RID: 33355 RVA: 0x0003DCB4 File Offset: 0x0003BEB4
		public unsafe static float Fov
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(JukeboxInterface.NativeFieldInfoPtr_Fov, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JukeboxInterface.NativeFieldInfoPtr_Fov, (void*)(&value));
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600824C RID: 33356 RVA: 0x0023B070 File Offset: 0x00239270
		// (set) Token: 0x0600824D RID: 33357 RVA: 0x0003DCC2 File Offset: 0x0003BEC2
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600824E RID: 33358 RVA: 0x0023B098 File Offset: 0x00239298
		// (set) Token: 0x0600824F RID: 33359 RVA: 0x0003DCDD File Offset: 0x0003BEDD
		public unsafe Jukebox Jukebox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Jukebox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Jukebox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x06008250 RID: 33360 RVA: 0x0023B0C8 File Offset: 0x002392C8
		// (set) Token: 0x06008251 RID: 33361 RVA: 0x0003DCFC File Offset: 0x0003BEFC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x0023B0F8 File Offset: 0x002392F8
		// (set) Token: 0x06008253 RID: 33363 RVA: 0x0003DD1B File Offset: 0x0003BF1B
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x0023B128 File Offset: 0x00239328
		// (set) Token: 0x06008255 RID: 33365 RVA: 0x0003DD3A File Offset: 0x0003BF3A
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06008256 RID: 33366 RVA: 0x0023B158 File Offset: 0x00239358
		// (set) Token: 0x06008257 RID: 33367 RVA: 0x0003DD59 File Offset: 0x0003BF59
		public unsafe Image PausePlayImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PausePlayImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PausePlayImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06008258 RID: 33368 RVA: 0x0023B188 File Offset: 0x00239388
		// (set) Token: 0x06008259 RID: 33369 RVA: 0x0003DD78 File Offset: 0x0003BF78
		public unsafe Button ShuffleButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_ShuffleButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_ShuffleButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x0023B1B8 File Offset: 0x002393B8
		// (set) Token: 0x0600825B RID: 33371 RVA: 0x0003DD97 File Offset: 0x0003BF97
		public unsafe Button RepeatButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x0023B1E8 File Offset: 0x002393E8
		// (set) Token: 0x0600825D RID: 33373 RVA: 0x0003DDB6 File Offset: 0x0003BFB6
		public unsafe Button SyncButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SyncButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SyncButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x0023B218 File Offset: 0x00239418
		// (set) Token: 0x0600825F RID: 33375 RVA: 0x0003DDD5 File Offset: 0x0003BFD5
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x0023B248 File Offset: 0x00239448
		// (set) Token: 0x06008261 RID: 33377 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
		public unsafe GameObject AmbientDisplayContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x06008262 RID: 33378 RVA: 0x0023B278 File Offset: 0x00239478
		// (set) Token: 0x06008263 RID: 33379 RVA: 0x0003DE13 File Offset: 0x0003C013
		public unsafe TextMeshPro AmbientDisplaySongLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06008264 RID: 33380 RVA: 0x0023B2A8 File Offset: 0x002394A8
		// (set) Token: 0x06008265 RID: 33381 RVA: 0x0003DE32 File Offset: 0x0003C032
		public unsafe TextMeshPro AmbientDisplayTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06008266 RID: 33382 RVA: 0x0023B2D8 File Offset: 0x002394D8
		// (set) Token: 0x06008267 RID: 33383 RVA: 0x0003DE51 File Offset: 0x0003C051
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x06008268 RID: 33384 RVA: 0x0023B308 File Offset: 0x00239508
		// (set) Token: 0x06008269 RID: 33385 RVA: 0x0003DE70 File Offset: 0x0003C070
		public unsafe Sprite PlaySprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PlaySprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PlaySprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600826A RID: 33386 RVA: 0x0023B338 File Offset: 0x00239538
		// (set) Token: 0x0600826B RID: 33387 RVA: 0x0003DE8F File Offset: 0x0003C08F
		public unsafe Sprite PauseSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PauseSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PauseSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600826C RID: 33388 RVA: 0x0023B368 File Offset: 0x00239568
		// (set) Token: 0x0600826D RID: 33389 RVA: 0x0003DEAE File Offset: 0x0003C0AE
		public unsafe Sprite SongEntryPlaySprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x0023B398 File Offset: 0x00239598
		// (set) Token: 0x0600826F RID: 33391 RVA: 0x0003DECD File Offset: 0x0003C0CD
		public unsafe Sprite SongEntryPauseSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x06008270 RID: 33392 RVA: 0x0023B3C8 File Offset: 0x002395C8
		// (set) Token: 0x06008271 RID: 33393 RVA: 0x0003DEEC File Offset: 0x0003C0EC
		public unsafe Sprite RepeatModeSprite_None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x06008272 RID: 33394 RVA: 0x0023B3F8 File Offset: 0x002395F8
		// (set) Token: 0x06008273 RID: 33395 RVA: 0x0003DF0B File Offset: 0x0003C10B
		public unsafe Sprite RepeatModeSprite_Track
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x0023B428 File Offset: 0x00239628
		// (set) Token: 0x06008275 RID: 33397 RVA: 0x0003DF2A File Offset: 0x0003C12A
		public unsafe Sprite RepeatModeSprite_Queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06008276 RID: 33398 RVA: 0x0023B458 File Offset: 0x00239658
		// (set) Token: 0x06008277 RID: 33399 RVA: 0x0003DF49 File Offset: 0x0003C149
		public unsafe Color DeselectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x06008278 RID: 33400 RVA: 0x0023B480 File Offset: 0x00239680
		// (set) Token: 0x06008279 RID: 33401 RVA: 0x0003DF64 File Offset: 0x0003C164
		public unsafe Color SelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x0023B4A8 File Offset: 0x002396A8
		// (set) Token: 0x0600827B RID: 33403 RVA: 0x0003DF7F File Offset: 0x0003C17F
		public unsafe GameObject SongEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x0023B4D8 File Offset: 0x002396D8
		// (set) Token: 0x0600827D RID: 33405 RVA: 0x0003DF9E File Offset: 0x0003C19E
		public unsafe List<RectTransform> songEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_songEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_songEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040058C8 RID: 22728
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x040058C9 RID: 22729
		private static readonly IntPtr NativeFieldInfoPtr_Fov;

		// Token: 0x040058CA RID: 22730
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040058CB RID: 22731
		private static readonly IntPtr NativeFieldInfoPtr_Jukebox;

		// Token: 0x040058CC RID: 22732
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040058CD RID: 22733
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040058CE RID: 22734
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040058CF RID: 22735
		private static readonly IntPtr NativeFieldInfoPtr_PausePlayImage;

		// Token: 0x040058D0 RID: 22736
		private static readonly IntPtr NativeFieldInfoPtr_ShuffleButton;

		// Token: 0x040058D1 RID: 22737
		private static readonly IntPtr NativeFieldInfoPtr_RepeatButton;

		// Token: 0x040058D2 RID: 22738
		private static readonly IntPtr NativeFieldInfoPtr_SyncButton;

		// Token: 0x040058D3 RID: 22739
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040058D4 RID: 22740
		private static readonly IntPtr NativeFieldInfoPtr_AmbientDisplayContainer;

		// Token: 0x040058D5 RID: 22741
		private static readonly IntPtr NativeFieldInfoPtr_AmbientDisplaySongLabel;

		// Token: 0x040058D6 RID: 22742
		private static readonly IntPtr NativeFieldInfoPtr_AmbientDisplayTimeLabel;

		// Token: 0x040058D7 RID: 22743
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040058D8 RID: 22744
		private static readonly IntPtr NativeFieldInfoPtr_PlaySprite;

		// Token: 0x040058D9 RID: 22745
		private static readonly IntPtr NativeFieldInfoPtr_PauseSprite;

		// Token: 0x040058DA RID: 22746
		private static readonly IntPtr NativeFieldInfoPtr_SongEntryPlaySprite;

		// Token: 0x040058DB RID: 22747
		private static readonly IntPtr NativeFieldInfoPtr_SongEntryPauseSprite;

		// Token: 0x040058DC RID: 22748
		private static readonly IntPtr NativeFieldInfoPtr_RepeatModeSprite_None;

		// Token: 0x040058DD RID: 22749
		private static readonly IntPtr NativeFieldInfoPtr_RepeatModeSprite_Track;

		// Token: 0x040058DE RID: 22750
		private static readonly IntPtr NativeFieldInfoPtr_RepeatModeSprite_Queue;

		// Token: 0x040058DF RID: 22751
		private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x040058E0 RID: 22752
		private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x040058E1 RID: 22753
		private static readonly IntPtr NativeFieldInfoPtr_SongEntryPrefab;

		// Token: 0x040058E2 RID: 22754
		private static readonly IntPtr NativeFieldInfoPtr_songEntries;

		// Token: 0x040058E3 RID: 22755
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040058E4 RID: 22756
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040058E5 RID: 22757
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040058E6 RID: 22758
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040058E7 RID: 22759
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0;

		// Token: 0x040058E8 RID: 22760
		private static readonly IntPtr NativeMethodInfoPtr_SetupSongEntries_Private_Void_0;

		// Token: 0x040058E9 RID: 22761
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040058EA RID: 22762
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040058EB RID: 22763
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040058EC RID: 22764
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x040058ED RID: 22765
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x040058EE RID: 22766
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040058EF RID: 22767
		private static readonly IntPtr NativeMethodInfoPtr_PlayPausePressed_Public_Void_0;

		// Token: 0x040058F0 RID: 22768
		private static readonly IntPtr NativeMethodInfoPtr_BackPressed_Public_Void_0;

		// Token: 0x040058F1 RID: 22769
		private static readonly IntPtr NativeMethodInfoPtr_NextPressed_Public_Void_0;

		// Token: 0x040058F2 RID: 22770
		private static readonly IntPtr NativeMethodInfoPtr_ShufflePressed_Public_Void_0;

		// Token: 0x040058F3 RID: 22771
		private static readonly IntPtr NativeMethodInfoPtr_RepeatPressed_Public_Void_0;

		// Token: 0x040058F4 RID: 22772
		private static readonly IntPtr NativeMethodInfoPtr_SyncPressed_Public_Void_0;

		// Token: 0x040058F5 RID: 22773
		private static readonly IntPtr NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0;

		// Token: 0x040058F6 RID: 22774
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0;

		// Token: 0x040058F7 RID: 22775
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x040058F8 RID: 22776
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0;

		// Token: 0x040058F9 RID: 22777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF3 RID: 3059
		[ObfuscatedName("ScheduleOne.ObjectScripts.JukeboxInterface+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ED05 RID: 60677 RVA: 0x003969C0 File Offset: 0x00394BC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr);
				JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr, "entry");
				JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				JukeboxInterface.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr, 100680070);
				JukeboxInterface.__c__DisplayClass33_0.NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr, 100680071);
			}

			// Token: 0x0600ED06 RID: 60678 RVA: 0x00396A3C File Offset: 0x00394C3C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED07 RID: 60679 RVA: 0x00396A78 File Offset: 0x00394C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246300, XrefRangeEnd = 246311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSongEntries_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.__c__DisplayClass33_0.NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED08 RID: 60680 RVA: 0x0006FD86 File Offset: 0x0006DF86
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047DE RID: 18398
			// (get) Token: 0x0600ED09 RID: 60681 RVA: 0x00396AAC File Offset: 0x00394CAC
			// (set) Token: 0x0600ED0A RID: 60682 RVA: 0x0006FD8F File Offset: 0x0006DF8F
			public unsafe GameObject entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047DF RID: 18399
			// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x00396ADC File Offset: 0x00394CDC
			// (set) Token: 0x0600ED0C RID: 60684 RVA: 0x0006FDAE File Offset: 0x0006DFAE
			public unsafe JukeboxInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JukeboxInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A06C RID: 41068
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400A06D RID: 41069
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A06E RID: 41070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A06F RID: 41071
			private static readonly IntPtr NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0;
		}
	}
}
