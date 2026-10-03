using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000597 RID: 1431
	public class Jukebox : GridItem
	{
		// Token: 0x060081ED RID: 33261 RVA: 0x002394B0 File Offset: 0x002376B0
		// Note: this type is marked as 'beforefieldinit'.
		static Jukebox()
		{
			Il2CppClassPointerStore<Jukebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Jukebox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox>.NativeClassPtr);
			Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "MUSIC_FADE_MULTIPLIER");
			Jukebox.NativeFieldInfoPtr_TRACK_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "TRACK_COUNT");
			Jukebox.NativeFieldInfoPtr__jukeboxState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "_jukeboxState");
			Jukebox.NativeFieldInfoPtr_TrackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "TrackList");
			Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "VolumeIndicatorBars");
			Jukebox.NativeFieldInfoPtr_AudioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "AudioSourceController");
			Jukebox.NativeFieldInfoPtr_onStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "onStateChanged");
			Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted");
			Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted");
			Jukebox.NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100679999);
			Jukebox.NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680000);
			Jukebox.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680001);
			Jukebox.NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680002);
			Jukebox.NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680003);
			Jukebox.NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680004);
			Jukebox.NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680005);
			Jukebox.NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680006);
			Jukebox.NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680007);
			Jukebox.NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680008);
			Jukebox.NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680009);
			Jukebox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680010);
			Jukebox.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680011);
			Jukebox.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680012);
			Jukebox.NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680013);
			Jukebox.NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680014);
			Jukebox.NativeMethodInfoPtr_TogglePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680015);
			Jukebox.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680016);
			Jukebox.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680017);
			Jukebox.NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680018);
			Jukebox.NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680019);
			Jukebox.NativeMethodInfoPtr_ToggleShuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680020);
			Jukebox.NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680021);
			Jukebox.NativeMethodInfoPtr_ToggleSync_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680022);
			Jukebox.NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680023);
			Jukebox.NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680024);
			Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680025);
			Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680026);
			Jukebox.NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680027);
			Jukebox.NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680028);
			Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680029);
			Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680030);
			Jukebox.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680031);
			Jukebox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680032);
			Jukebox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680033);
			Jukebox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680034);
			Jukebox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680035);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680036);
			Jukebox.NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680037);
			Jukebox.NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680038);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680039);
			Jukebox.NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680040);
			Jukebox.NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680041);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680042);
			Jukebox.NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680043);
			Jukebox.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100680044);
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x060081EE RID: 33262 RVA: 0x0023992C File Offset: 0x00237B2C
		public unsafe int CurrentVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245866, RefRangeEnd = 245867, XrefRangeStart = 245866, XrefRangeEnd = 245866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x00239968 File Offset: 0x00237B68
		public unsafe float NormalizedVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x002399A4 File Offset: 0x00237BA4
		public unsafe bool IsPlaying
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 245867, RefRangeEnd = 245872, XrefRangeStart = 245867, XrefRangeEnd = 245867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x002399E0 File Offset: 0x00237BE0
		public unsafe float CurrentTrackTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245872, RefRangeEnd = 245873, XrefRangeStart = 245872, XrefRangeEnd = 245872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x060081F2 RID: 33266 RVA: 0x00239A1C File Offset: 0x00237C1C
		public unsafe Il2CppStructArray<int> TrackOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x060081F3 RID: 33267 RVA: 0x00239A5C File Offset: 0x00237C5C
		public unsafe int CurrentTrackOrderIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x060081F4 RID: 33268 RVA: 0x00239A98 File Offset: 0x00237C98
		public unsafe bool Shuffle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245873, RefRangeEnd = 245874, XrefRangeStart = 245873, XrefRangeEnd = 245873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x060081F5 RID: 33269 RVA: 0x00239AD4 File Offset: 0x00237CD4
		public unsafe Jukebox.ERepeatMode RepeatMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 245874, RefRangeEnd = 245876, XrefRangeStart = 245874, XrefRangeEnd = 245874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x060081F6 RID: 33270 RVA: 0x00239B10 File Offset: 0x00237D10
		public unsafe bool Sync
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245876, RefRangeEnd = 245877, XrefRangeStart = 245876, XrefRangeEnd = 245876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x060081F7 RID: 33271 RVA: 0x00239B4C File Offset: 0x00237D4C
		public unsafe Jukebox.Track currentTrack
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 245879, RefRangeEnd = 245884, XrefRangeStart = 245877, XrefRangeEnd = 245879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Jukebox.Track>(intPtr3) : null;
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x00239B8C File Offset: 0x00237D8C
		public unsafe AudioClip currentClip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245884, XrefRangeEnd = 245885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00239BCC File Offset: 0x00237DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245885, XrefRangeEnd = 245886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x00239C08 File Offset: 0x00237E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245886, XrefRangeEnd = 245889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00239C3C File Offset: 0x00237E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245889, XrefRangeEnd = 245892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00239C8C File Offset: 0x00237E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245892, XrefRangeEnd = 245894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeVolume(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x00239CCC File Offset: 0x00237ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245900, RefRangeEnd = 245903, XrefRangeStart = 245894, XrefRangeEnd = 245900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(int volume, bool replicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x00239D18 File Offset: 0x00237F18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245906, RefRangeEnd = 245909, XrefRangeStart = 245903, XrefRangeEnd = 245906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TogglePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_TogglePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x00239D4C File Offset: 0x00237F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245913, RefRangeEnd = 245914, XrefRangeStart = 245909, XrefRangeEnd = 245913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x00239D80 File Offset: 0x00237F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245917, RefRangeEnd = 245918, XrefRangeStart = 245914, XrefRangeEnd = 245917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x00239DB4 File Offset: 0x00237FB4
		[CallerCount(0)]
		public unsafe int GetPreviousTrackOrderIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x00239DF0 File Offset: 0x00237FF0
		[CallerCount(0)]
		public unsafe int GetNextTrackOrderIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00239E2C File Offset: 0x0023802C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245948, RefRangeEnd = 245949, XrefRangeStart = 245918, XrefRangeEnd = 245948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleShuffle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleShuffle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00239E60 File Offset: 0x00238060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245952, RefRangeEnd = 245953, XrefRangeStart = 245949, XrefRangeEnd = 245952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleRepeatMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00239E94 File Offset: 0x00238094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245956, RefRangeEnd = 245957, XrefRangeStart = 245953, XrefRangeEnd = 245956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleSync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleSync_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00239EC8 File Offset: 0x002380C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245988, RefRangeEnd = 245990, XrefRangeStart = 245957, XrefRangeEnd = 245988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(int trackID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trackID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00239F08 File Offset: 0x00238108
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 246013, RefRangeEnd = 246022, XrefRangeStart = 245990, XrefRangeEnd = 246013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJukeboxState(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00239F68 File Offset: 0x00238168
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 246065, RefRangeEnd = 246072, XrefRangeStart = 246022, XrefRangeEnd = 246065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetJukeboxState(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00239FD8 File Offset: 0x002381D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246124, RefRangeEnd = 246128, XrefRangeStart = 246072, XrefRangeEnd = 246124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetJukeboxState(Jukebox.JukeboxState state, bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x0023A028 File Offset: 0x00238228
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246131, RefRangeEnd = 246135, XrefRangeStart = 246128, XrefRangeEnd = 246131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jukebox.Track GetTrack(int orderIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Jukebox.Track>(intPtr3) : null;
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x0023A074 File Offset: 0x00238274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246135, XrefRangeEnd = 246156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateQueue(Il2CppStructArray<int> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0023A0C4 File Offset: 0x002382C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246156, XrefRangeEnd = 246157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStateToOtherClients(bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setTrackTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x0023A104 File Offset: 0x00238304
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 246179, RefRangeEnd = 246186, XrefRangeStart = 246157, XrefRangeEnd = 246179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStateToOtherJukeboxes(bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setTrackTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0023A144 File Offset: 0x00238344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246186, XrefRangeEnd = 246190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0023A190 File Offset: 0x00238390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jukebox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x0023A1CC File Offset: 0x002383CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246190, XrefRangeEnd = 246220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x0023A208 File Offset: 0x00238408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246220, XrefRangeEnd = 246221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x0023A244 File Offset: 0x00238444
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x0023A280 File Offset: 0x00238480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246233, RefRangeEnd = 246234, XrefRangeStart = 246221, XrefRangeEnd = 246233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x0023A2E0 File Offset: 0x002384E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246234, XrefRangeEnd = 246235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x0023A340 File Offset: 0x00238540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246235, XrefRangeEnd = 246239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJukeboxState_1728100027(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x0023A3A4 File Offset: 0x002385A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246239, XrefRangeEnd = 246251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x0023A414 File Offset: 0x00238614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246251, XrefRangeEnd = 246252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x0023A484 File Offset: 0x00238684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246252, XrefRangeEnd = 246256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x0023A4D4 File Offset: 0x002386D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246256, XrefRangeEnd = 246268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setSync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0023A544 File Offset: 0x00238744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246268, XrefRangeEnd = 246272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x0023A594 File Offset: 0x00238794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246299, RefRangeEnd = 246300, XrefRangeStart = 246272, XrefRangeEnd = 246299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0003DBA7 File Offset: 0x0003BDA7
		public Jukebox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600821D RID: 33309 RVA: 0x0023A5D0 File Offset: 0x002387D0
		// (set) Token: 0x0600821E RID: 33310 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		public unsafe static float MUSIC_FADE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600821F RID: 33311 RVA: 0x0023A5EC File Offset: 0x002387EC
		// (set) Token: 0x06008220 RID: 33312 RVA: 0x0003DBBE File Offset: 0x0003BDBE
		public unsafe static int TRACK_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Jukebox.NativeFieldInfoPtr_TRACK_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Jukebox.NativeFieldInfoPtr_TRACK_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06008221 RID: 33313 RVA: 0x0023A608 File Offset: 0x00238808
		// (set) Token: 0x06008222 RID: 33314 RVA: 0x0003DBCC File Offset: 0x0003BDCC
		public unsafe Jukebox.JukeboxState _jukeboxState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr__jukeboxState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox.JukeboxState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr__jukeboxState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x06008223 RID: 33315 RVA: 0x0023A638 File Offset: 0x00238838
		// (set) Token: 0x06008224 RID: 33316 RVA: 0x0003DBEB File Offset: 0x0003BDEB
		public unsafe Il2CppReferenceArray<Jukebox.Track> TrackList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_TrackList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Jukebox.Track>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_TrackList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x06008225 RID: 33317 RVA: 0x0023A668 File Offset: 0x00238868
		// (set) Token: 0x06008226 RID: 33318 RVA: 0x0003DC0A File Offset: 0x0003BE0A
		public unsafe Il2CppReferenceArray<GameObject> VolumeIndicatorBars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x06008227 RID: 33319 RVA: 0x0023A698 File Offset: 0x00238898
		// (set) Token: 0x06008228 RID: 33320 RVA: 0x0003DC29 File Offset: 0x0003BE29
		public unsafe AudioSourceController AudioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_AudioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_AudioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06008229 RID: 33321 RVA: 0x0023A6C8 File Offset: 0x002388C8
		// (set) Token: 0x0600822A RID: 33322 RVA: 0x0003DC48 File Offset: 0x0003BE48
		public unsafe Action onStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_onStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_onStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600822B RID: 33323 RVA: 0x0023A6F8 File Offset: 0x002388F8
		// (set) Token: 0x0600822C RID: 33324 RVA: 0x0003DC67 File Offset: 0x0003BE67
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600822D RID: 33325 RVA: 0x0023A720 File Offset: 0x00238920
		// (set) Token: 0x0600822E RID: 33326 RVA: 0x0003DC82 File Offset: 0x0003BE82
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005891 RID: 22673
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER;

		// Token: 0x04005892 RID: 22674
		private static readonly IntPtr NativeFieldInfoPtr_TRACK_COUNT;

		// Token: 0x04005893 RID: 22675
		private static readonly IntPtr NativeFieldInfoPtr__jukeboxState;

		// Token: 0x04005894 RID: 22676
		private static readonly IntPtr NativeFieldInfoPtr_TrackList;

		// Token: 0x04005895 RID: 22677
		private static readonly IntPtr NativeFieldInfoPtr_VolumeIndicatorBars;

		// Token: 0x04005896 RID: 22678
		private static readonly IntPtr NativeFieldInfoPtr_AudioSourceController;

		// Token: 0x04005897 RID: 22679
		private static readonly IntPtr NativeFieldInfoPtr_onStateChanged;

		// Token: 0x04005898 RID: 22680
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005899 RID: 22681
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400589A RID: 22682
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0;

		// Token: 0x0400589B RID: 22683
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0;

		// Token: 0x0400589C RID: 22684
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x0400589D RID: 22685
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0;

		// Token: 0x0400589E RID: 22686
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400589F RID: 22687
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0;

		// Token: 0x040058A0 RID: 22688
		private static readonly IntPtr NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0;

		// Token: 0x040058A1 RID: 22689
		private static readonly IntPtr NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0;

		// Token: 0x040058A2 RID: 22690
		private static readonly IntPtr NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0;

		// Token: 0x040058A3 RID: 22691
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0;

		// Token: 0x040058A4 RID: 22692
		private static readonly IntPtr NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0;

		// Token: 0x040058A5 RID: 22693
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040058A6 RID: 22694
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040058A7 RID: 22695
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040058A8 RID: 22696
		private static readonly IntPtr NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0;

		// Token: 0x040058A9 RID: 22697
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0;

		// Token: 0x040058AA RID: 22698
		private static readonly IntPtr NativeMethodInfoPtr_TogglePlay_Public_Void_0;

		// Token: 0x040058AB RID: 22699
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x040058AC RID: 22700
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x040058AD RID: 22701
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0;

		// Token: 0x040058AE RID: 22702
		private static readonly IntPtr NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0;

		// Token: 0x040058AF RID: 22703
		private static readonly IntPtr NativeMethodInfoPtr_ToggleShuffle_Public_Void_0;

		// Token: 0x040058B0 RID: 22704
		private static readonly IntPtr NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0;

		// Token: 0x040058B1 RID: 22705
		private static readonly IntPtr NativeMethodInfoPtr_ToggleSync_Public_Void_0;

		// Token: 0x040058B2 RID: 22706
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0;

		// Token: 0x040058B3 RID: 22707
		private static readonly IntPtr NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058B4 RID: 22708
		private static readonly IntPtr NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058B5 RID: 22709
		private static readonly IntPtr NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0;

		// Token: 0x040058B6 RID: 22710
		private static readonly IntPtr NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0;

		// Token: 0x040058B7 RID: 22711
		private static readonly IntPtr NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0;

		// Token: 0x040058B8 RID: 22712
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0;

		// Token: 0x040058B9 RID: 22713
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0;

		// Token: 0x040058BA RID: 22714
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x040058BB RID: 22715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040058BC RID: 22716
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040058BD RID: 22717
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040058BE RID: 22718
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040058BF RID: 22719
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058C0 RID: 22720
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058C1 RID: 22721
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040058C2 RID: 22722
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058C3 RID: 22723
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058C4 RID: 22724
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0;

		// Token: 0x040058C5 RID: 22725
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x040058C6 RID: 22726
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0;

		// Token: 0x040058C7 RID: 22727
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BF0 RID: 3056
		[Serializable]
		public class Track : Il2CppSystem.Object
		{
			// Token: 0x0600ECE9 RID: 60649 RVA: 0x00396624 File Offset: 0x00394824
			// Note: this type is marked as 'beforefieldinit'.
			static Track()
			{
				Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "Track");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr);
				Jukebox.Track.NativeFieldInfoPtr_TrackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "TrackName");
				Jukebox.Track.NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "Clip");
				Jukebox.Track.NativeFieldInfoPtr_ArtistName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "ArtistName");
				Jukebox.Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, 100680045);
			}

			// Token: 0x0600ECEA RID: 60650 RVA: 0x003966A0 File Offset: 0x003948A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245858, XrefRangeEnd = 245863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Track() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECEB RID: 60651 RVA: 0x0006FC3B File Offset: 0x0006DE3B
			public Track(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D3 RID: 18387
			// (get) Token: 0x0600ECEC RID: 60652 RVA: 0x003966DC File Offset: 0x003948DC
			// (set) Token: 0x0600ECED RID: 60653 RVA: 0x0006FC44 File Offset: 0x0006DE44
			public unsafe string TrackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_TrackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_TrackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170047D4 RID: 18388
			// (get) Token: 0x0600ECEE RID: 60654 RVA: 0x00396704 File Offset: 0x00394904
			// (set) Token: 0x0600ECEF RID: 60655 RVA: 0x0006FC63 File Offset: 0x0006DE63
			public unsafe AudioClip Clip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_Clip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D5 RID: 18389
			// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x00396734 File Offset: 0x00394934
			// (set) Token: 0x0600ECF1 RID: 60657 RVA: 0x0006FC82 File Offset: 0x0006DE82
			public unsafe string ArtistName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_ArtistName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_ArtistName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A05B RID: 41051
			private static readonly IntPtr NativeFieldInfoPtr_TrackName;

			// Token: 0x0400A05C RID: 41052
			private static readonly IntPtr NativeFieldInfoPtr_Clip;

			// Token: 0x0400A05D RID: 41053
			private static readonly IntPtr NativeFieldInfoPtr_ArtistName;

			// Token: 0x0400A05E RID: 41054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BF1 RID: 3057
		[Serializable]
		public class JukeboxState : Il2CppSystem.Object
		{
			// Token: 0x0600ECF2 RID: 60658 RVA: 0x0039675C File Offset: 0x0039495C
			// Note: this type is marked as 'beforefieldinit'.
			static JukeboxState()
			{
				Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "JukeboxState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr);
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentVolume");
				Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "IsPlaying");
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentTrackTime");
				Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "TrackOrder");
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentTrackOrderIndex");
				Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "Shuffle");
				Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "RepeatMode");
				Jukebox.JukeboxState.NativeFieldInfoPtr_Sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "Sync");
				Jukebox.JukeboxState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, 100680046);
			}

			// Token: 0x0600ECF3 RID: 60659 RVA: 0x0039683C File Offset: 0x00394A3C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 245864, RefRangeEnd = 245866, XrefRangeStart = 245863, XrefRangeEnd = 245864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JukeboxState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.JukeboxState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECF4 RID: 60660 RVA: 0x0006FCA1 File Offset: 0x0006DEA1
			public JukeboxState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D6 RID: 18390
			// (get) Token: 0x0600ECF5 RID: 60661 RVA: 0x00396878 File Offset: 0x00394A78
			// (set) Token: 0x0600ECF6 RID: 60662 RVA: 0x0006FCAA File Offset: 0x0006DEAA
			public unsafe int CurrentVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume)) = value;
				}
			}

			// Token: 0x170047D7 RID: 18391
			// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x003968A0 File Offset: 0x00394AA0
			// (set) Token: 0x0600ECF8 RID: 60664 RVA: 0x0006FCC5 File Offset: 0x0006DEC5
			public unsafe bool IsPlaying
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying)) = value;
				}
			}

			// Token: 0x170047D8 RID: 18392
			// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x003968C8 File Offset: 0x00394AC8
			// (set) Token: 0x0600ECFA RID: 60666 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
			public unsafe float CurrentTrackTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime)) = value;
				}
			}

			// Token: 0x170047D9 RID: 18393
			// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x003968F0 File Offset: 0x00394AF0
			// (set) Token: 0x0600ECFC RID: 60668 RVA: 0x0006FCFB File Offset: 0x0006DEFB
			public unsafe Il2CppStructArray<int> TrackOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047DA RID: 18394
			// (get) Token: 0x0600ECFD RID: 60669 RVA: 0x00396920 File Offset: 0x00394B20
			// (set) Token: 0x0600ECFE RID: 60670 RVA: 0x0006FD1A File Offset: 0x0006DF1A
			public unsafe int CurrentTrackOrderIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex)) = value;
				}
			}

			// Token: 0x170047DB RID: 18395
			// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x00396948 File Offset: 0x00394B48
			// (set) Token: 0x0600ED00 RID: 60672 RVA: 0x0006FD35 File Offset: 0x0006DF35
			public unsafe bool Shuffle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle)) = value;
				}
			}

			// Token: 0x170047DC RID: 18396
			// (get) Token: 0x0600ED01 RID: 60673 RVA: 0x00396970 File Offset: 0x00394B70
			// (set) Token: 0x0600ED02 RID: 60674 RVA: 0x0006FD50 File Offset: 0x0006DF50
			public unsafe Jukebox.ERepeatMode RepeatMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode)) = value;
				}
			}

			// Token: 0x170047DD RID: 18397
			// (get) Token: 0x0600ED03 RID: 60675 RVA: 0x00396998 File Offset: 0x00394B98
			// (set) Token: 0x0600ED04 RID: 60676 RVA: 0x0006FD6B File Offset: 0x0006DF6B
			public unsafe bool Sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Sync)) = value;
				}
			}

			// Token: 0x0400A05F RID: 41055
			private static readonly IntPtr NativeFieldInfoPtr_CurrentVolume;

			// Token: 0x0400A060 RID: 41056
			private static readonly IntPtr NativeFieldInfoPtr_IsPlaying;

			// Token: 0x0400A061 RID: 41057
			private static readonly IntPtr NativeFieldInfoPtr_CurrentTrackTime;

			// Token: 0x0400A062 RID: 41058
			private static readonly IntPtr NativeFieldInfoPtr_TrackOrder;

			// Token: 0x0400A063 RID: 41059
			private static readonly IntPtr NativeFieldInfoPtr_CurrentTrackOrderIndex;

			// Token: 0x0400A064 RID: 41060
			private static readonly IntPtr NativeFieldInfoPtr_Shuffle;

			// Token: 0x0400A065 RID: 41061
			private static readonly IntPtr NativeFieldInfoPtr_RepeatMode;

			// Token: 0x0400A066 RID: 41062
			private static readonly IntPtr NativeFieldInfoPtr_Sync;

			// Token: 0x0400A067 RID: 41063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BF2 RID: 3058
		[OriginalName("Assembly-CSharp.dll", "", "ERepeatMode")]
		public enum ERepeatMode
		{
			// Token: 0x0400A069 RID: 41065
			None,
			// Token: 0x0400A06A RID: 41066
			RepeatQueue,
			// Token: 0x0400A06B RID: 41067
			RepeatTrack
		}
	}
}
