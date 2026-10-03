using System;
using Il2CppFishNet.Transporting;
using Il2CppFishNet.Transporting.Yak;
using Il2CppFishySteamworks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using Il2CppScheduleOne.Persistence.ItemLoaders;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B0 RID: 432
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x06002AE0 RID: 10976 RVA: 0x00108F90 File Offset: 0x00107190
		// Note: this type is marked as 'beforefieldinit'.
		static LoadManager()
		{
			Il2CppClassPointerStore<LoadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager>.NativeClassPtr);
			LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOADS_PER_FRAME");
			LoadManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "DEBUG");
			LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOAD_ERROR_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NETWORK_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_LoadHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LoadHistory");
			LoadManager.NativeFieldInfoPtr_SaveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "SaveGames");
			LoadManager.NativeFieldInfoPtr_LastPlayedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LastPlayedGame");
			LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsLoading>k__BackingField");
			LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<TimeSinceGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<DebugMode>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadStatus>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadedGameFolderPath>k__BackingField");
			LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<ActiveSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<StoredSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr_loadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "loadRequests");
			LoadManager.NativeFieldInfoPtr_ItemLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ItemLoaders");
			LoadManager.NativeFieldInfoPtr_ObjectLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ObjectLoaders");
			LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LegacyNPCLoaders");
			LoadManager.NativeFieldInfoPtr_NPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NPCLoaders");
			LoadManager.NativeFieldInfoPtr_onPreSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreSceneChange");
			LoadManager.NativeFieldInfoPtr_onSceneChangeDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onSceneChangeDone");
			LoadManager.NativeFieldInfoPtr_OnLocalSaveLoadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "OnLocalSaveLoadStart");
			LoadManager.NativeFieldInfoPtr_onLoadConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onLoadConfigurations");
			LoadManager.NativeFieldInfoPtr_onPreLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreLoad");
			LoadManager.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onLoadComplete");
			LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onSaveInfoLoaded");
			LoadManager.NativeFieldInfoPtr_staggeredReplicators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "staggeredReplicators");
			LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668785);
			LoadManager.NativeMethodInfoPtr_get_IsInGameScene_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668786);
			LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668787);
			LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668788);
			LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668789);
			LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668790);
			LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668791);
			LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668792);
			LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668793);
			LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668794);
			LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668795);
			LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668796);
			LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668797);
			LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668798);
			LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668799);
			LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668800);
			LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668801);
			LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668802);
			LoadManager.NativeMethodInfoPtr_add_onLoadConfigurations_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668803);
			LoadManager.NativeMethodInfoPtr_remove_onLoadConfigurations_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668804);
			LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668805);
			LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668806);
			LoadManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668807);
			LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668808);
			LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668809);
			LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668810);
			LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668811);
			LoadManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668812);
			LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668813);
			LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668814);
			LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668815);
			LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668816);
			LoadManager.NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668817);
			LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668818);
			LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668819);
			LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668820);
			LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668821);
			LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668822);
			LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668823);
			LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668824);
			LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668825);
			LoadManager.NativeMethodInfoPtr_CleanUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668826);
			LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668827);
			LoadManager.NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668828);
			LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668829);
			LoadManager.NativeMethodInfoPtr_AddStaggeredReplicator_Public_Void_IStaggeredReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668830);
			LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668831);
			LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668833);
			LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668834);
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x001095C4 File Offset: 0x001077C4
		public unsafe string DefaultTutorialSaveFolder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126079, RefRangeEnd = 126080, XrefRangeStart = 126069, XrefRangeEnd = 126079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x001095FC File Offset: 0x001077FC
		public unsafe bool IsInGameScene
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126080, XrefRangeEnd = 126089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsInGameScene_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x00109638 File Offset: 0x00107838
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00109674 File Offset: 0x00107874
		public unsafe bool IsGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x001096B4 File Offset: 0x001078B4
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x001096F0 File Offset: 0x001078F0
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00109730 File Offset: 0x00107930
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x0010976C File Offset: 0x0010796C
		public unsafe float TimeSinceGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x001097AC File Offset: 0x001079AC
		// (set) Token: 0x06002AEA RID: 10986 RVA: 0x001097E8 File Offset: 0x001079E8
		public unsafe bool DebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x00109828 File Offset: 0x00107A28
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x00109864 File Offset: 0x00107A64
		public unsafe LoadManager.ELoadStatus LoadStatus
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 41326, RefRangeEnd = 41452, XrefRangeStart = 41326, XrefRangeEnd = 41452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x001098A4 File Offset: 0x00107AA4
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x001098DC File Offset: 0x00107ADC
		public unsafe string LoadedGameFolderPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x00109920 File Offset: 0x00107B20
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x00109960 File Offset: 0x00107B60
		public unsafe SaveInfo ActiveSaveInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x001099A4 File Offset: 0x00107BA4
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x001099E4 File Offset: 0x00107BE4
		public unsafe SaveInfo StoredSaveInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00109A28 File Offset: 0x00107C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126102, RefRangeEnd = 126103, XrefRangeStart = 126091, XrefRangeEnd = 126102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onLoadConfigurations(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_add_onLoadConfigurations_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00109A60 File Offset: 0x00107C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126103, XrefRangeEnd = 126114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onLoadConfigurations(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_remove_onLoadConfigurations_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00109A98 File Offset: 0x00107C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126114, XrefRangeEnd = 126117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00109AD4 File Offset: 0x00107CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126117, XrefRangeEnd = 126263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00109B10 File Offset: 0x00107D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126263, XrefRangeEnd = 126267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00109B44 File Offset: 0x00107D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126317, RefRangeEnd = 126318, XrefRangeStart = 126267, XrefRangeEnd = 126317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bananas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00109B78 File Offset: 0x00107D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126318, XrefRangeEnd = 126366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeItemLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00109BAC File Offset: 0x00107DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126458, RefRangeEnd = 126459, XrefRangeStart = 126366, XrefRangeEnd = 126458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeObjectLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00109BE0 File Offset: 0x00107DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126459, XrefRangeEnd = 126507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeNPCLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00109C14 File Offset: 0x00107E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126507, XrefRangeEnd = 126548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00109C48 File Offset: 0x00107E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126554, RefRangeEnd = 126555, XrefRangeStart = 126548, XrefRangeEnd = 126554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00109C8C File Offset: 0x00107E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126559, RefRangeEnd = 126560, XrefRangeStart = 126555, XrefRangeEnd = 126559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00109CD0 File Offset: 0x00107ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126560, XrefRangeEnd = 126581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader GetItemLoader(string itemType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00109D20 File Offset: 0x00107F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126602, RefRangeEnd = 126605, XrefRangeStart = 126581, XrefRangeEnd = 126602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader GetObjectLoader(string objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00109D70 File Offset: 0x00107F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126626, RefRangeEnd = 126627, XrefRangeStart = 126605, XrefRangeEnd = 126626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyNPCLoader GetLegacyNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LegacyNPCLoader>(intPtr3) : null;
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00109DC0 File Offset: 0x00107FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126648, RefRangeEnd = 126650, XrefRangeStart = 126627, XrefRangeEnd = 126648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader GetNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCLoader>(intPtr3) : null;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00109E10 File Offset: 0x00108010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126663, RefRangeEnd = 126664, XrefRangeStart = 126650, XrefRangeEnd = 126663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLoadStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00109E48 File Offset: 0x00108048
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126721, RefRangeEnd = 126725, XrefRangeStart = 126664, XrefRangeEnd = 126721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(SaveInfo info, bool allowLoadStacking = false, bool allowSaveBackup = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLoadStacking;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSaveBackup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00109EA8 File Offset: 0x001080A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126725, XrefRangeEnd = 126740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTutorialAsClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00109EDC File Offset: 0x001080DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126756, RefRangeEnd = 126758, XrefRangeStart = 126740, XrefRangeEnd = 126756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00109F20 File Offset: 0x00108120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126764, RefRangeEnd = 126765, XrefRangeStart = 126758, XrefRangeEnd = 126764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoadErrorAutosubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00109F54 File Offset: 0x00108154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126765, RefRangeEnd = 126766, XrefRangeStart = 126765, XrefRangeEnd = 126765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitingForHostLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00109F88 File Offset: 0x00108188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126766, XrefRangeEnd = 126769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLastSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00109FBC File Offset: 0x001081BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126874, RefRangeEnd = 126877, XrefRangeStart = 126769, XrefRangeEnd = 126874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_CleanUp_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00109FE4 File Offset: 0x001081E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 126946, RefRangeEnd = 126953, XrefRangeStart = 126877, XrefRangeEnd = 126946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoLoadSave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainMenuPopup);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preventLeaveLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x0010A048 File Offset: 0x00108248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127101, RefRangeEnd = 127103, XrefRangeStart = 126953, XrefRangeEnd = 127101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out SaveInfo saveInfo, bool requireGameFile = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveSlotIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireGameFile;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			saveInfo = ((intPtr4 == 0) ? null : new SaveInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0010A0C8 File Offset: 0x001082C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 127155, RefRangeEnd = 127158, XrefRangeStart = 127103, XrefRangeEnd = 127155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSaveInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0010A0FC File Offset: 0x001082FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127158, XrefRangeEnd = 127171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStaggeredReplicator(IStaggeredReplicator replicator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_AddStaggeredReplicator_Public_Void_IStaggeredReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0010A140 File Offset: 0x00108340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127171, XrefRangeEnd = 127212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0010A17C File Offset: 0x0010837C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127212, XrefRangeEnd = 127238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0010A1A4 File Offset: 0x001083A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127238, XrefRangeEnd = 127243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00016485 File Offset: 0x00014685
		public LoadManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x0010A1E4 File Offset: 0x001083E4
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x0001648E File Offset: 0x0001468E
		public unsafe static int LOADS_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x0010A200 File Offset: 0x00108400
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x0001649C File Offset: 0x0001469C
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x0010A21C File Offset: 0x0010841C
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x000164AA File Offset: 0x000146AA
		public unsafe static float LOAD_ERROR_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x0010A238 File Offset: 0x00108438
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x000164B8 File Offset: 0x000146B8
		public unsafe static float NETWORK_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x0010A254 File Offset: 0x00108454
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x000164C6 File Offset: 0x000146C6
		public unsafe static List<string> LoadHistory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LoadHistory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LoadHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x0010A27C File Offset: 0x0010847C
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x000164D8 File Offset: 0x000146D8
		public unsafe static Il2CppReferenceArray<SaveInfo> SaveGames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_SaveGames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SaveInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_SaveGames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0010A2A4 File Offset: 0x001084A4
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x000164EA File Offset: 0x000146EA
		public unsafe static SaveInfo LastPlayedGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x0010A2CC File Offset: 0x001084CC
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x000164FC File Offset: 0x000146FC
		public unsafe bool _IsGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0010A2F4 File Offset: 0x001084F4
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x00016517 File Offset: 0x00014717
		public unsafe bool _IsLoading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0010A31C File Offset: 0x0010851C
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00016532 File Offset: 0x00014732
		public unsafe float _TimeSinceGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x0010A344 File Offset: 0x00108544
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x0001654D File Offset: 0x0001474D
		public unsafe bool _DebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x0010A36C File Offset: 0x0010856C
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00016568 File Offset: 0x00014768
		public unsafe LoadManager.ELoadStatus _LoadStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x0010A394 File Offset: 0x00108594
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x00016583 File Offset: 0x00014783
		public unsafe string _LoadedGameFolderPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x0010A3BC File Offset: 0x001085BC
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x000165A2 File Offset: 0x000147A2
		public unsafe SaveInfo _ActiveSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x0010A3EC File Offset: 0x001085EC
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x000165C1 File Offset: 0x000147C1
		public unsafe SaveInfo _StoredSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0010A41C File Offset: 0x0010861C
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x000165E0 File Offset: 0x000147E0
		public unsafe List<LoadRequest> loadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoadRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x0010A44C File Offset: 0x0010864C
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x000165FF File Offset: 0x000147FF
		public unsafe List<ItemLoader> ItemLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x0010A47C File Offset: 0x0010867C
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0001661E File Offset: 0x0001481E
		public unsafe List<BuildableItemLoader> ObjectLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x0010A4AC File Offset: 0x001086AC
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x0001663D File Offset: 0x0001483D
		public unsafe List<LegacyNPCLoader> LegacyNPCLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LegacyNPCLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x0010A4DC File Offset: 0x001086DC
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x0001665C File Offset: 0x0001485C
		public unsafe List<NPCLoader> NPCLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0010A50C File Offset: 0x0010870C
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0001667B File Offset: 0x0001487B
		public unsafe UnityEvent onPreSceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0010A53C File Offset: 0x0010873C
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0001669A File Offset: 0x0001489A
		public unsafe UnityEvent onSceneChangeDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSceneChangeDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSceneChangeDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0010A56C File Offset: 0x0010876C
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x000166B9 File Offset: 0x000148B9
		public unsafe Action<string> OnLocalSaveLoadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_OnLocalSaveLoadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_OnLocalSaveLoadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x0010A59C File Offset: 0x0010879C
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x000166D8 File Offset: 0x000148D8
		public unsafe static Action onLoadConfigurations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_onLoadConfigurations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_onLoadConfigurations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x0010A5C4 File Offset: 0x001087C4
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x000166EA File Offset: 0x000148EA
		public unsafe UnityEvent onPreLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x0010A5F4 File Offset: 0x001087F4
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x00016709 File Offset: 0x00014909
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x0010A624 File Offset: 0x00108824
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x00016728 File Offset: 0x00014928
		public unsafe UnityEvent onSaveInfoLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x0010A654 File Offset: 0x00108854
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x00016747 File Offset: 0x00014947
		public unsafe static List<IStaggeredReplicator> staggeredReplicators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_staggeredReplicators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IStaggeredReplicator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_staggeredReplicators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeFieldInfoPtr_LOADS_PER_FRAME;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeFieldInfoPtr_NETWORK_TIMEOUT;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeFieldInfoPtr_LoadHistory;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeFieldInfoPtr_SaveGames;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedGame;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeFieldInfoPtr__IsGameLoaded_k__BackingField;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr__IsLoading_k__BackingField;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr__DebugMode_k__BackingField;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeFieldInfoPtr__LoadStatus_k__BackingField;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeFieldInfoPtr__StoredSaveInfo_k__BackingField;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeFieldInfoPtr_loadRequests;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeFieldInfoPtr_ItemLoaders;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeFieldInfoPtr_ObjectLoaders;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeFieldInfoPtr_LegacyNPCLoaders;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeFieldInfoPtr_NPCLoaders;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeFieldInfoPtr_onPreSceneChange;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeFieldInfoPtr_onSceneChangeDone;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeFieldInfoPtr_OnLocalSaveLoadStart;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeFieldInfoPtr_onLoadConfigurations;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeFieldInfoPtr_onPreLoad;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeFieldInfoPtr_onSaveInfoLoaded;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeFieldInfoPtr_staggeredReplicators;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInGameScene_Public_get_Boolean_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_add_onLoadConfigurations_Public_Static_add_Void_Action_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_remove_onLoadConfigurations_Public_Static_rem_Void_Action_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_Bananas_Private_Void_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadStatusText_Public_String_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_Boolean_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_LoadLastSave_Public_Void_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Static_Void_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_AddStaggeredReplicator_Public_Void_IStaggeredReplicator_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009A6 RID: 2470
		[OriginalName("Assembly-CSharp.dll", "", "ELoadStatus")]
		public enum ELoadStatus
		{
			// Token: 0x0400958C RID: 38284
			None,
			// Token: 0x0400958D RID: 38285
			LoadingScene,
			// Token: 0x0400958E RID: 38286
			Initializing,
			// Token: 0x0400958F RID: 38287
			LoadingData,
			// Token: 0x04009590 RID: 38288
			SpawningPlayer,
			// Token: 0x04009591 RID: 38289
			WaitingForHost,
			// Token: 0x04009592 RID: 38290
			WaitingForAuth
		}

		// Token: 0x020009A7 RID: 2471
		[OriginalName("Assembly-CSharp.dll", "", "EAuthOutcome")]
		public enum EAuthOutcome
		{
			// Token: 0x04009594 RID: 38292
			Waiting,
			// Token: 0x04009595 RID: 38293
			Success,
			// Token: 0x04009596 RID: 38294
			Failure
		}

		// Token: 0x020009A8 RID: 2472
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<<StartLoadErrorAutosubmit>g__Wait|78_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DAE9 RID: 56041 RVA: 0x00363BEC File Offset: 0x00361DEC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique()
			{
				Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<<StartLoadErrorAutosubmit>g__Wait|78_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<t>5__2");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668835);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668836);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668837);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668838);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668839);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668840);
			}

			// Token: 0x0600DAEA RID: 56042 RVA: 0x00363CE0 File Offset: 0x00361EE0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEB RID: 56043 RVA: 0x00363D28 File Offset: 0x00361F28
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEC RID: 56044 RVA: 0x00363D5C File Offset: 0x00361F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124995, XrefRangeEnd = 125002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00363D98 File Offset: 0x00361F98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAEE RID: 56046 RVA: 0x00363DD8 File Offset: 0x00361FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125002, XrefRangeEnd = 125007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600DAEF RID: 56047 RVA: 0x00363E0C File Offset: 0x0036200C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAF0 RID: 56048 RVA: 0x00066EF3 File Offset: 0x000650F3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D2 RID: 17106
			// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x00363E4C File Offset: 0x0036204C
			// (set) Token: 0x0600DAF2 RID: 56050 RVA: 0x00066EFC File Offset: 0x000650FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042D3 RID: 17107
			// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x00363E74 File Offset: 0x00362074
			// (set) Token: 0x0600DAF4 RID: 56052 RVA: 0x00066F17 File Offset: 0x00065117
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D4 RID: 17108
			// (get) Token: 0x0600DAF5 RID: 56053 RVA: 0x00363EA4 File Offset: 0x003620A4
			// (set) Token: 0x0600DAF6 RID: 56054 RVA: 0x00066F36 File Offset: 0x00065136
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D5 RID: 17109
			// (get) Token: 0x0600DAF7 RID: 56055 RVA: 0x00363ED4 File Offset: 0x003620D4
			// (set) Token: 0x0600DAF8 RID: 56056 RVA: 0x00066F55 File Offset: 0x00065155
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x04009597 RID: 38295
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009598 RID: 38296
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009599 RID: 38297
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400959A RID: 38298
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x0400959B RID: 38299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400959C RID: 38300
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400959D RID: 38301
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400959E RID: 38302
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400959F RID: 38303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095A0 RID: 38304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009A9 RID: 2473
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DAF9 RID: 56057 RVA: 0x00363EFC File Offset: 0x003620FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr);
				LoadManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9");
				LoadManager.__c.NativeFieldInfoPtr___9__75_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__75_5");
				LoadManager.__c.NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__75_1");
				LoadManager.__c.NativeFieldInfoPtr___9__75_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__75_2");
				LoadManager.__c.NativeFieldInfoPtr___9__75_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__75_3");
				LoadManager.__c.NativeFieldInfoPtr___9__76_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__76_2");
				LoadManager.__c.NativeFieldInfoPtr___9__76_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__76_3");
				LoadManager.__c.NativeFieldInfoPtr___9__76_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__76_4");
				LoadManager.__c.NativeFieldInfoPtr___9__77_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__77_4");
				LoadManager.__c.NativeFieldInfoPtr___9__77_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__77_5");
				LoadManager.__c.NativeFieldInfoPtr___9__77_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__77_6");
				LoadManager.__c.NativeFieldInfoPtr___9__77_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__77_7");
				LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668842);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668843);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668844);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668845);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_3_Internal_Int32_IBaseSaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668846);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668847);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668848);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668849);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668850);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668851);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668852);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_7_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668853);
			}

			// Token: 0x0600DAFA RID: 56058 RVA: 0x00364108 File Offset: 0x00362308
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAFB RID: 56059 RVA: 0x00364144 File Offset: 0x00362344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125007, XrefRangeEnd = 125008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__75_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAFC RID: 56060 RVA: 0x00364180 File Offset: 0x00362380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125008, XrefRangeEnd = 125011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__75_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAFD RID: 56061 RVA: 0x003641BC File Offset: 0x003623BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125011, XrefRangeEnd = 125019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__75_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAFE RID: 56062 RVA: 0x003641F8 File Offset: 0x003623F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125019, XrefRangeEnd = 125023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _StartGame_b__75_3(IBaseSaveable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__75_3_Internal_Int32_IBaseSaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAFF RID: 56063 RVA: 0x00364248 File Offset: 0x00362448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__76_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB00 RID: 56064 RVA: 0x00364284 File Offset: 0x00362484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__76_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB01 RID: 56065 RVA: 0x003642C0 File Offset: 0x003624C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125023, XrefRangeEnd = 125031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__76_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__76_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB02 RID: 56066 RVA: 0x003642FC File Offset: 0x003624FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125031, XrefRangeEnd = 125039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__77_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB03 RID: 56067 RVA: 0x00364338 File Offset: 0x00362538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125039, XrefRangeEnd = 125047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__77_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB04 RID: 56068 RVA: 0x00364374 File Offset: 0x00362574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125047, XrefRangeEnd = 125051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__77_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB05 RID: 56069 RVA: 0x003643B0 File Offset: 0x003625B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125051, XrefRangeEnd = 125055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__77_7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__77_7_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB06 RID: 56070 RVA: 0x00066F70 File Offset: 0x00065170
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x003643EC File Offset: 0x003625EC
			// (set) Token: 0x0600DB08 RID: 56072 RVA: 0x00066F79 File Offset: 0x00065179
			public unsafe static LoadManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600DB09 RID: 56073 RVA: 0x00364414 File Offset: 0x00362614
			// (set) Token: 0x0600DB0A RID: 56074 RVA: 0x00066F8B File Offset: 0x0006518B
			public unsafe static Func<bool> __9__75_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__75_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__75_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600DB0B RID: 56075 RVA: 0x0036443C File Offset: 0x0036263C
			// (set) Token: 0x0600DB0C RID: 56076 RVA: 0x00066F9D File Offset: 0x0006519D
			public unsafe static Func<bool> __9__75_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__75_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600DB0D RID: 56077 RVA: 0x00364464 File Offset: 0x00362664
			// (set) Token: 0x0600DB0E RID: 56078 RVA: 0x00066FAF File Offset: 0x000651AF
			public unsafe static Func<bool> __9__75_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__75_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__75_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600DB0F RID: 56079 RVA: 0x0036448C File Offset: 0x0036268C
			// (set) Token: 0x0600DB10 RID: 56080 RVA: 0x00066FC1 File Offset: 0x000651C1
			public unsafe static Func<IBaseSaveable, int> __9__75_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__75_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IBaseSaveable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__75_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600DB11 RID: 56081 RVA: 0x003644B4 File Offset: 0x003626B4
			// (set) Token: 0x0600DB12 RID: 56082 RVA: 0x00066FD3 File Offset: 0x000651D3
			public unsafe static Func<bool> __9__76_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__76_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__76_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600DB13 RID: 56083 RVA: 0x003644DC File Offset: 0x003626DC
			// (set) Token: 0x0600DB14 RID: 56084 RVA: 0x00066FE5 File Offset: 0x000651E5
			public unsafe static Func<bool> __9__76_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__76_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__76_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600DB15 RID: 56085 RVA: 0x00364504 File Offset: 0x00362704
			// (set) Token: 0x0600DB16 RID: 56086 RVA: 0x00066FF7 File Offset: 0x000651F7
			public unsafe static Func<bool> __9__76_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__76_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__76_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600DB17 RID: 56087 RVA: 0x0036452C File Offset: 0x0036272C
			// (set) Token: 0x0600DB18 RID: 56088 RVA: 0x00067009 File Offset: 0x00065209
			public unsafe static Func<bool> __9__77_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__77_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__77_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600DB19 RID: 56089 RVA: 0x00364554 File Offset: 0x00362754
			// (set) Token: 0x0600DB1A RID: 56090 RVA: 0x0006701B File Offset: 0x0006521B
			public unsafe static Func<bool> __9__77_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__77_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__77_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E2 RID: 17122
			// (get) Token: 0x0600DB1B RID: 56091 RVA: 0x0036457C File Offset: 0x0036277C
			// (set) Token: 0x0600DB1C RID: 56092 RVA: 0x0006702D File Offset: 0x0006522D
			public unsafe static Func<bool> __9__77_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__77_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__77_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E3 RID: 17123
			// (get) Token: 0x0600DB1D RID: 56093 RVA: 0x003645A4 File Offset: 0x003627A4
			// (set) Token: 0x0600DB1E RID: 56094 RVA: 0x0006703F File Offset: 0x0006523F
			public unsafe static Func<bool> __9__77_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__77_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__77_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095A1 RID: 38305
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095A2 RID: 38306
			private static readonly IntPtr NativeFieldInfoPtr___9__75_5;

			// Token: 0x040095A3 RID: 38307
			private static readonly IntPtr NativeFieldInfoPtr___9__75_1;

			// Token: 0x040095A4 RID: 38308
			private static readonly IntPtr NativeFieldInfoPtr___9__75_2;

			// Token: 0x040095A5 RID: 38309
			private static readonly IntPtr NativeFieldInfoPtr___9__75_3;

			// Token: 0x040095A6 RID: 38310
			private static readonly IntPtr NativeFieldInfoPtr___9__76_2;

			// Token: 0x040095A7 RID: 38311
			private static readonly IntPtr NativeFieldInfoPtr___9__76_3;

			// Token: 0x040095A8 RID: 38312
			private static readonly IntPtr NativeFieldInfoPtr___9__76_4;

			// Token: 0x040095A9 RID: 38313
			private static readonly IntPtr NativeFieldInfoPtr___9__77_4;

			// Token: 0x040095AA RID: 38314
			private static readonly IntPtr NativeFieldInfoPtr___9__77_5;

			// Token: 0x040095AB RID: 38315
			private static readonly IntPtr NativeFieldInfoPtr___9__77_6;

			// Token: 0x040095AC RID: 38316
			private static readonly IntPtr NativeFieldInfoPtr___9__77_7;

			// Token: 0x040095AD RID: 38317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095AE RID: 38318
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__75_5_Internal_Boolean_0;

			// Token: 0x040095AF RID: 38319
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__75_1_Internal_Boolean_0;

			// Token: 0x040095B0 RID: 38320
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__75_2_Internal_Boolean_0;

			// Token: 0x040095B1 RID: 38321
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__75_3_Internal_Int32_IBaseSaveable_0;

			// Token: 0x040095B2 RID: 38322
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__76_2_Internal_Boolean_0;

			// Token: 0x040095B3 RID: 38323
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__76_3_Internal_Boolean_0;

			// Token: 0x040095B4 RID: 38324
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__76_4_Internal_Boolean_0;

			// Token: 0x040095B5 RID: 38325
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__77_4_Internal_Boolean_0;

			// Token: 0x040095B6 RID: 38326
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__77_5_Internal_Boolean_0;

			// Token: 0x040095B7 RID: 38327
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__77_6_Internal_Boolean_0;

			// Token: 0x040095B8 RID: 38328
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__77_7_Internal_Boolean_0;
		}

		// Token: 0x020009AA RID: 2474
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB1F RID: 56095 RVA: 0x003645CC File Offset: 0x003627CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "itemType");
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668854);
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668855);
			}

			// Token: 0x0600DB20 RID: 56096 RVA: 0x00364634 File Offset: 0x00362834
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB21 RID: 56097 RVA: 0x00364670 File Offset: 0x00362870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125055, XrefRangeEnd = 125057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetItemLoader_b__0(ItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB22 RID: 56098 RVA: 0x00067051 File Offset: 0x00065251
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E4 RID: 17124
			// (get) Token: 0x0600DB23 RID: 56099 RVA: 0x003646C0 File Offset: 0x003628C0
			// (set) Token: 0x0600DB24 RID: 56100 RVA: 0x0006705A File Offset: 0x0006525A
			public unsafe string itemType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_itemType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_itemType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095B9 RID: 38329
			private static readonly IntPtr NativeFieldInfoPtr_itemType;

			// Token: 0x040095BA RID: 38330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095BB RID: 38331
			private static readonly IntPtr NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0;
		}

		// Token: 0x020009AB RID: 2475
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB25 RID: 56101 RVA: 0x003646E8 File Offset: 0x003628E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass71_0.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr, "objectType");
				LoadManager.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr, 100668856);
				LoadManager.__c__DisplayClass71_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr, 100668857);
			}

			// Token: 0x0600DB26 RID: 56102 RVA: 0x00364750 File Offset: 0x00362950
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB27 RID: 56103 RVA: 0x0036478C File Offset: 0x0036298C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125057, XrefRangeEnd = 125059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetObjectLoader_b__0(BuildableItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass71_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB28 RID: 56104 RVA: 0x00067079 File Offset: 0x00065279
			public __c__DisplayClass71_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E5 RID: 17125
			// (get) Token: 0x0600DB29 RID: 56105 RVA: 0x003647DC File Offset: 0x003629DC
			// (set) Token: 0x0600DB2A RID: 56106 RVA: 0x00067082 File Offset: 0x00065282
			public unsafe string objectType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass71_0.NativeFieldInfoPtr_objectType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass71_0.NativeFieldInfoPtr_objectType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095BC RID: 38332
			private static readonly IntPtr NativeFieldInfoPtr_objectType;

			// Token: 0x040095BD RID: 38333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095BE RID: 38334
			private static readonly IntPtr NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0;
		}

		// Token: 0x020009AC RID: 2476
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB2B RID: 56107 RVA: 0x00364804 File Offset: 0x00362A04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, 100668858);
				LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, 100668859);
			}

			// Token: 0x0600DB2C RID: 56108 RVA: 0x0036486C File Offset: 0x00362A6C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x003648A8 File Offset: 0x00362AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLegacyNPCLoader_b__0(LegacyNPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x000670A1 File Offset: 0x000652A1
			public __c__DisplayClass72_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E6 RID: 17126
			// (get) Token: 0x0600DB2F RID: 56111 RVA: 0x003648F8 File Offset: 0x00362AF8
			// (set) Token: 0x0600DB30 RID: 56112 RVA: 0x000670AA File Offset: 0x000652AA
			public unsafe string npcType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095BF RID: 38335
			private static readonly IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x040095C0 RID: 38336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095C1 RID: 38337
			private static readonly IntPtr NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0;
		}

		// Token: 0x020009AD RID: 2477
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB31 RID: 56113 RVA: 0x00364920 File Offset: 0x00362B20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass73_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr, 100668860);
				LoadManager.__c__DisplayClass73_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr, 100668861);
			}

			// Token: 0x0600DB32 RID: 56114 RVA: 0x00364988 File Offset: 0x00362B88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB33 RID: 56115 RVA: 0x003649C4 File Offset: 0x00362BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetNPCLoader_b__0(NPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass73_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB34 RID: 56116 RVA: 0x000670C9 File Offset: 0x000652C9
			public __c__DisplayClass73_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E7 RID: 17127
			// (get) Token: 0x0600DB35 RID: 56117 RVA: 0x00364A14 File Offset: 0x00362C14
			// (set) Token: 0x0600DB36 RID: 56118 RVA: 0x000670D2 File Offset: 0x000652D2
			public unsafe string npcType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass73_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass73_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095C2 RID: 38338
			private static readonly IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x040095C3 RID: 38339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095C4 RID: 38340
			private static readonly IntPtr NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0;
		}

		// Token: 0x020009AE RID: 2478
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB37 RID: 56119 RVA: 0x00364A3C File Offset: 0x00362C3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr, "info");
				LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr, 100668862);
				LoadManager.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr, 100668863);
			}

			// Token: 0x0600DB38 RID: 56120 RVA: 0x00364AB8 File Offset: 0x00362CB8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB39 RID: 56121 RVA: 0x00364AF4 File Offset: 0x00362CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125504, XrefRangeEnd = 125509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB3A RID: 56122 RVA: 0x000670F1 File Offset: 0x000652F1
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E8 RID: 17128
			// (get) Token: 0x0600DB3B RID: 56123 RVA: 0x00364B34 File Offset: 0x00362D34
			// (set) Token: 0x0600DB3C RID: 56124 RVA: 0x000670FA File Offset: 0x000652FA
			public unsafe SaveInfo info
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr_info);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E9 RID: 17129
			// (get) Token: 0x0600DB3D RID: 56125 RVA: 0x00364B64 File Offset: 0x00362D64
			// (set) Token: 0x0600DB3E RID: 56126 RVA: 0x00067119 File Offset: 0x00065319
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095C5 RID: 38341
			private static readonly IntPtr NativeFieldInfoPtr_info;

			// Token: 0x040095C6 RID: 38342
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095C7 RID: 38343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095C8 RID: 38344
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DB7 RID: 3511
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass75_0+<<StartGame>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FDC1 RID: 64961 RVA: 0x003C6964 File Offset: 0x003C4B64
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0>.NativeClassPtr, "<<StartGame>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__playingTutorial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<playingTutorial>5__2");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__asyncLoad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<asyncLoad>5__3");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__transport_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, "<transport>5__4");
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668864);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668865);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668866);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668867);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668868);
					LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr, 100668869);
				}

				// Token: 0x0600FDC2 RID: 64962 RVA: 0x003C6A80 File Offset: 0x003C4C80
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDC3 RID: 64963 RVA: 0x003C6AC8 File Offset: 0x003C4CC8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDC4 RID: 64964 RVA: 0x003C6AFC File Offset: 0x003C4CFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125059, XrefRangeEnd = 125499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D2B RID: 19755
				// (get) Token: 0x0600FDC5 RID: 64965 RVA: 0x003C6B38 File Offset: 0x003C4D38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDC6 RID: 64966 RVA: 0x003C6B78 File Offset: 0x003C4D78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125499, XrefRangeEnd = 125504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D2C RID: 19756
				// (get) Token: 0x0600FDC7 RID: 64967 RVA: 0x003C6BAC File Offset: 0x003C4DAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDC8 RID: 64968 RVA: 0x00078371 File Offset: 0x00076571
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D25 RID: 19749
				// (get) Token: 0x0600FDC9 RID: 64969 RVA: 0x003C6BEC File Offset: 0x003C4DEC
				// (set) Token: 0x0600FDCA RID: 64970 RVA: 0x0007837A File Offset: 0x0007657A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D26 RID: 19750
				// (get) Token: 0x0600FDCB RID: 64971 RVA: 0x003C6C14 File Offset: 0x003C4E14
				// (set) Token: 0x0600FDCC RID: 64972 RVA: 0x00078395 File Offset: 0x00076595
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D27 RID: 19751
				// (get) Token: 0x0600FDCD RID: 64973 RVA: 0x003C6C44 File Offset: 0x003C4E44
				// (set) Token: 0x0600FDCE RID: 64974 RVA: 0x000783B4 File Offset: 0x000765B4
				public unsafe LoadManager.__c__DisplayClass75_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass75_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D28 RID: 19752
				// (get) Token: 0x0600FDCF RID: 64975 RVA: 0x003C6C74 File Offset: 0x003C4E74
				// (set) Token: 0x0600FDD0 RID: 64976 RVA: 0x000783D3 File Offset: 0x000765D3
				public unsafe bool _playingTutorial_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__playingTutorial_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__playingTutorial_5__2)) = value;
					}
				}

				// Token: 0x17004D29 RID: 19753
				// (get) Token: 0x0600FDD1 RID: 64977 RVA: 0x003C6C9C File Offset: 0x003C4E9C
				// (set) Token: 0x0600FDD2 RID: 64978 RVA: 0x000783EE File Offset: 0x000765EE
				public unsafe AsyncOperation _asyncLoad_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__asyncLoad_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__asyncLoad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D2A RID: 19754
				// (get) Token: 0x0600FDD3 RID: 64979 RVA: 0x003C6CCC File Offset: 0x003C4ECC
				// (set) Token: 0x0600FDD4 RID: 64980 RVA: 0x0007840D File Offset: 0x0007660D
				public unsafe Transport _transport_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__transport_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transport>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsTrObObUnique.NativeFieldInfoPtr__transport_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB0F RID: 43791
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB10 RID: 43792
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB11 RID: 43793
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB12 RID: 43794
				private static readonly IntPtr NativeFieldInfoPtr__playingTutorial_5__2;

				// Token: 0x0400AB13 RID: 43795
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__3;

				// Token: 0x0400AB14 RID: 43796
				private static readonly IntPtr NativeFieldInfoPtr__transport_5__4;

				// Token: 0x0400AB15 RID: 43797
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB16 RID: 43798
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB17 RID: 43799
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB18 RID: 43800
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB19 RID: 43801
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB1A RID: 43802
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009AF RID: 2479
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass75_1")]
		public sealed class __c__DisplayClass75_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DB3F RID: 56127 RVA: 0x00364B94 File Offset: 0x00362D94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass75_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_fishy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr, "fishy");
				LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr, "port");
				LoadManager.__c__DisplayClass75_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr, 100668870);
				LoadManager.__c__DisplayClass75_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr, 100668871);
			}

			// Token: 0x0600DB40 RID: 56128 RVA: 0x00364C10 File Offset: 0x00362E10
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass75_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB41 RID: 56129 RVA: 0x00364C4C File Offset: 0x00362E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125509, XrefRangeEnd = 125549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ServerConnectionStateArgs_PDM_0(ServerConnectionStateArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref args;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass75_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB42 RID: 56130 RVA: 0x00067138 File Offset: 0x00065338
			public __c__DisplayClass75_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EA RID: 17130
			// (get) Token: 0x0600DB43 RID: 56131 RVA: 0x00364C8C File Offset: 0x00362E8C
			// (set) Token: 0x0600DB44 RID: 56132 RVA: 0x00067141 File Offset: 0x00065341
			public unsafe FishySteamworks fishy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_fishy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishySteamworks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_fishy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EB RID: 17131
			// (get) Token: 0x0600DB45 RID: 56133 RVA: 0x00364CBC File Offset: 0x00362EBC
			// (set) Token: 0x0600DB46 RID: 56134 RVA: 0x00067160 File Offset: 0x00065360
			public unsafe ushort port
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_port);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass75_1.NativeFieldInfoPtr_port)) = value;
				}
			}

			// Token: 0x040095C9 RID: 38345
			private static readonly IntPtr NativeFieldInfoPtr_fishy;

			// Token: 0x040095CA RID: 38346
			private static readonly IntPtr NativeFieldInfoPtr_port;

			// Token: 0x040095CB RID: 38347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095CC RID: 38348
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0;
		}

		// Token: 0x020009B0 RID: 2480
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB47 RID: 56135 RVA: 0x00364CE4 File Offset: 0x00362EE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, 100668872);
				LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, 100668873);
				LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, 100668874);
			}

			// Token: 0x0600DB48 RID: 56136 RVA: 0x00364D74 File Offset: 0x00362F74
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB49 RID: 56137 RVA: 0x00364DB0 File Offset: 0x00362FB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125823, RefRangeEnd = 125824, XrefRangeStart = 125818, XrefRangeEnd = 125823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB4A RID: 56138 RVA: 0x00364DF0 File Offset: 0x00362FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125824, XrefRangeEnd = 125826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB4B RID: 56139 RVA: 0x0006717B File Offset: 0x0006537B
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EC RID: 17132
			// (get) Token: 0x0600DB4C RID: 56140 RVA: 0x00364E2C File Offset: 0x0036302C
			// (set) Token: 0x0600DB4D RID: 56141 RVA: 0x00067184 File Offset: 0x00065384
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x170042ED RID: 17133
			// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x00364E54 File Offset: 0x00363054
			// (set) Token: 0x0600DB4F RID: 56143 RVA: 0x0006719F File Offset: 0x0006539F
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095CD RID: 38349
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040095CE RID: 38350
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095CF RID: 38351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095D0 RID: 38352
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040095D1 RID: 38353
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0;

			// Token: 0x02000DB8 RID: 3512
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass76_0+<<LoadTutorialAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FDD5 RID: 64981 RVA: 0x003C6CFC File Offset: 0x003C4EFC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<yak>5__3");
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668875);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668876);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668877);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668878);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668879);
					LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668880);
				}

				// Token: 0x0600FDD6 RID: 64982 RVA: 0x003C6E04 File Offset: 0x003C5004
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDD7 RID: 64983 RVA: 0x003C6E4C File Offset: 0x003C504C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDD8 RID: 64984 RVA: 0x003C6E80 File Offset: 0x003C5080
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125549, XrefRangeEnd = 125813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D32 RID: 19762
				// (get) Token: 0x0600FDD9 RID: 64985 RVA: 0x003C6EBC File Offset: 0x003C50BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDDA RID: 64986 RVA: 0x003C6EFC File Offset: 0x003C50FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125813, XrefRangeEnd = 125818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D33 RID: 19763
				// (get) Token: 0x0600FDDB RID: 64987 RVA: 0x003C6F30 File Offset: 0x003C5130
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDDC RID: 64988 RVA: 0x0007842C File Offset: 0x0007662C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D2D RID: 19757
				// (get) Token: 0x0600FDDD RID: 64989 RVA: 0x003C6F70 File Offset: 0x003C5170
				// (set) Token: 0x0600FDDE RID: 64990 RVA: 0x00078435 File Offset: 0x00076635
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D2E RID: 19758
				// (get) Token: 0x0600FDDF RID: 64991 RVA: 0x003C6F98 File Offset: 0x003C5198
				// (set) Token: 0x0600FDE0 RID: 64992 RVA: 0x00078450 File Offset: 0x00076650
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D2F RID: 19759
				// (get) Token: 0x0600FDE1 RID: 64993 RVA: 0x003C6FC8 File Offset: 0x003C51C8
				// (set) Token: 0x0600FDE2 RID: 64994 RVA: 0x0007846F File Offset: 0x0007666F
				public unsafe LoadManager.__c__DisplayClass76_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass76_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D30 RID: 19760
				// (get) Token: 0x0600FDE3 RID: 64995 RVA: 0x003C6FF8 File Offset: 0x003C51F8
				// (set) Token: 0x0600FDE4 RID: 64996 RVA: 0x0007848E File Offset: 0x0007668E
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D31 RID: 19761
				// (get) Token: 0x0600FDE5 RID: 64997 RVA: 0x003C7028 File Offset: 0x003C5228
				// (set) Token: 0x0600FDE6 RID: 64998 RVA: 0x000784AD File Offset: 0x000766AD
				public unsafe Yak _yak_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass76_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB1B RID: 43803
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB1C RID: 43804
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB1D RID: 43805
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB1E RID: 43806
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400AB1F RID: 43807
				private static readonly IntPtr NativeFieldInfoPtr__yak_5__3;

				// Token: 0x0400AB20 RID: 43808
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB21 RID: 43809
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB22 RID: 43810
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB23 RID: 43811
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB24 RID: 43812
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB25 RID: 43813
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009B1 RID: 2481
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB50 RID: 56144 RVA: 0x00364E84 File Offset: 0x00363084
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_steamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, "steamId64");
				LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, 100668881);
				LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, 100668882);
				LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, 100668883);
				LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr_Method_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, 100668884);
			}

			// Token: 0x0600DB51 RID: 56145 RVA: 0x00364F3C File Offset: 0x0036313C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB52 RID: 56146 RVA: 0x00364F78 File Offset: 0x00363178
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125978, RefRangeEnd = 125979, XrefRangeStart = 125973, XrefRangeEnd = 125978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB53 RID: 56147 RVA: 0x00364FB8 File Offset: 0x003631B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125979, XrefRangeEnd = 125981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB54 RID: 56148 RVA: 0x00364FF4 File Offset: 0x003631F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126008, RefRangeEnd = 126009, XrefRangeStart = 125981, XrefRangeEnd = 126008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_String_0(string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.NativeMethodInfoPtr_Method_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB55 RID: 56149 RVA: 0x000671BE File Offset: 0x000653BE
			public __c__DisplayClass77_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EE RID: 17134
			// (get) Token: 0x0600DB56 RID: 56150 RVA: 0x00365038 File Offset: 0x00363238
			// (set) Token: 0x0600DB57 RID: 56151 RVA: 0x000671C7 File Offset: 0x000653C7
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x170042EF RID: 17135
			// (get) Token: 0x0600DB58 RID: 56152 RVA: 0x00365060 File Offset: 0x00363260
			// (set) Token: 0x0600DB59 RID: 56153 RVA: 0x000671E2 File Offset: 0x000653E2
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F0 RID: 17136
			// (get) Token: 0x0600DB5A RID: 56154 RVA: 0x00365090 File Offset: 0x00363290
			// (set) Token: 0x0600DB5B RID: 56155 RVA: 0x00067201 File Offset: 0x00065401
			public unsafe string steamId64
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_steamId64);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.NativeFieldInfoPtr_steamId64), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095D2 RID: 38354
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040095D3 RID: 38355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095D4 RID: 38356
			private static readonly IntPtr NativeFieldInfoPtr_steamId64;

			// Token: 0x040095D5 RID: 38357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095D6 RID: 38358
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040095D7 RID: 38359
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0;

			// Token: 0x040095D8 RID: 38360
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_String_0;

			// Token: 0x02000DB9 RID: 3513
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass77_0+<<LoadAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FDE7 RID: 64999 RVA: 0x003C7058 File Offset: 0x003C5258
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0>.NativeClassPtr, "<<LoadAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>8__1");
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668885);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668886);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668887);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668888);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668889);
					LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668890);
				}

				// Token: 0x0600FDE8 RID: 65000 RVA: 0x003C714C File Offset: 0x003C534C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDE9 RID: 65001 RVA: 0x003C7194 File Offset: 0x003C5394
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDEA RID: 65002 RVA: 0x003C71C8 File Offset: 0x003C53C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125826, XrefRangeEnd = 125968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D38 RID: 19768
				// (get) Token: 0x0600FDEB RID: 65003 RVA: 0x003C7204 File Offset: 0x003C5404
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDEC RID: 65004 RVA: 0x003C7244 File Offset: 0x003C5444
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125968, XrefRangeEnd = 125973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D39 RID: 19769
				// (get) Token: 0x0600FDED RID: 65005 RVA: 0x003C7278 File Offset: 0x003C5478
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDEE RID: 65006 RVA: 0x000784CC File Offset: 0x000766CC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D34 RID: 19764
				// (get) Token: 0x0600FDEF RID: 65007 RVA: 0x003C72B8 File Offset: 0x003C54B8
				// (set) Token: 0x0600FDF0 RID: 65008 RVA: 0x000784D5 File Offset: 0x000766D5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D35 RID: 19765
				// (get) Token: 0x0600FDF1 RID: 65009 RVA: 0x003C72E0 File Offset: 0x003C54E0
				// (set) Token: 0x0600FDF2 RID: 65010 RVA: 0x000784F0 File Offset: 0x000766F0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D36 RID: 19766
				// (get) Token: 0x0600FDF3 RID: 65011 RVA: 0x003C7310 File Offset: 0x003C5510
				// (set) Token: 0x0600FDF4 RID: 65012 RVA: 0x0007850F File Offset: 0x0007670F
				public unsafe LoadManager.__c__DisplayClass77_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass77_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D37 RID: 19767
				// (get) Token: 0x0600FDF5 RID: 65013 RVA: 0x003C7340 File Offset: 0x003C5540
				// (set) Token: 0x0600FDF6 RID: 65014 RVA: 0x0007852E File Offset: 0x0007672E
				public unsafe LoadManager.__c__DisplayClass77_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass77_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB26 RID: 43814
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB27 RID: 43815
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB28 RID: 43816
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB29 RID: 43817
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400AB2A RID: 43818
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB2B RID: 43819
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB2C RID: 43820
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB2D RID: 43821
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB2E RID: 43822
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB2F RID: 43823
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009B2 RID: 2482
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass77_1")]
		public sealed class __c__DisplayClass77_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DB5C RID: 56156 RVA: 0x003650B8 File Offset: 0x003632B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass77_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass77_1.NativeFieldInfoPtr_authOutcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr, "authOutcome");
				LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr, 100668891);
				LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr_Method_Internal_Void_ClientConnectionStateArgs_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr, 100668892);
				LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr__LoadAsClient_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr, 100668893);
			}

			// Token: 0x0600DB5D RID: 56157 RVA: 0x00365134 File Offset: 0x00363334
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB5E RID: 56158 RVA: 0x00365170 File Offset: 0x00363370
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_ClientConnectionStateArgs_PDM_0(ClientConnectionStateArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref args;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr_Method_Internal_Void_ClientConnectionStateArgs_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB5F RID: 56159 RVA: 0x003651B0 File Offset: 0x003633B0
			[CallerCount(0)]
			public unsafe bool _LoadAsClient_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_1.NativeMethodInfoPtr__LoadAsClient_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB60 RID: 56160 RVA: 0x00067220 File Offset: 0x00065420
			public __c__DisplayClass77_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F1 RID: 17137
			// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x003651EC File Offset: 0x003633EC
			// (set) Token: 0x0600DB62 RID: 56162 RVA: 0x00067229 File Offset: 0x00065429
			public unsafe LoadManager.EAuthOutcome authOutcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_1.NativeFieldInfoPtr_authOutcome);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_1.NativeFieldInfoPtr_authOutcome)) = value;
				}
			}

			// Token: 0x040095D9 RID: 38361
			private static readonly IntPtr NativeFieldInfoPtr_authOutcome;

			// Token: 0x040095DA RID: 38362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095DB RID: 38363
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ClientConnectionStateArgs_PDM_0;

			// Token: 0x040095DC RID: 38364
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__3_Internal_Boolean_0;
		}

		// Token: 0x020009B3 RID: 2483
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass77_2")]
		public sealed class __c__DisplayClass77_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DB63 RID: 56163 RVA: 0x00365214 File Offset: 0x00363414
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_2()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass77_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr);
				LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_authenticator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr, "authenticator");
				LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_field_Public___c__DisplayClass77_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr, "CS$<>8__locals1");
				LoadManager.__c__DisplayClass77_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr, 100668894);
				LoadManager.__c__DisplayClass77_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr, 100668895);
			}

			// Token: 0x0600DB64 RID: 56164 RVA: 0x00365290 File Offset: 0x00363490
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass77_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB65 RID: 56165 RVA: 0x003652CC File Offset: 0x003634CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126009, XrefRangeEnd = 126016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool passed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref passed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass77_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB66 RID: 56166 RVA: 0x00067244 File Offset: 0x00065444
			public __c__DisplayClass77_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F2 RID: 17138
			// (get) Token: 0x0600DB67 RID: 56167 RVA: 0x0036530C File Offset: 0x0036350C
			// (set) Token: 0x0600DB68 RID: 56168 RVA: 0x0006724D File Offset: 0x0006544D
			public unsafe FishNetSteamAuthenticator authenticator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_authenticator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishNetSteamAuthenticator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_authenticator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F3 RID: 17139
			// (get) Token: 0x0600DB69 RID: 56169 RVA: 0x0036533C File Offset: 0x0036353C
			// (set) Token: 0x0600DB6A RID: 56170 RVA: 0x0006726C File Offset: 0x0006546C
			public unsafe LoadManager.__c__DisplayClass77_1 field_Public___c__DisplayClass77_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_field_Public___c__DisplayClass77_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass77_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass77_2.NativeFieldInfoPtr_field_Public___c__DisplayClass77_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095DD RID: 38365
			private static readonly IntPtr NativeFieldInfoPtr_authenticator;

			// Token: 0x040095DE RID: 38366
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass77_1_0;

			// Token: 0x040095DF RID: 38367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E0 RID: 38368
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}

		// Token: 0x020009B4 RID: 2484
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB6B RID: 56171 RVA: 0x0036536C File Offset: 0x0036356C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_autoLoadSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, "autoLoadSave");
				LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_mainMenuPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, "mainMenuPopup");
				LoadManager.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, 100668896);
				LoadManager.__c__DisplayClass82_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, 100668897);
			}

			// Token: 0x0600DB6C RID: 56172 RVA: 0x003653FC File Offset: 0x003635FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB6D RID: 56173 RVA: 0x00365438 File Offset: 0x00363638
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126064, RefRangeEnd = 126065, XrefRangeStart = 126059, XrefRangeEnd = 126064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB6E RID: 56174 RVA: 0x0006728B File Offset: 0x0006548B
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F4 RID: 17140
			// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x00365478 File Offset: 0x00363678
			// (set) Token: 0x0600DB70 RID: 56176 RVA: 0x00067294 File Offset: 0x00065494
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F5 RID: 17141
			// (get) Token: 0x0600DB71 RID: 56177 RVA: 0x003654A8 File Offset: 0x003636A8
			// (set) Token: 0x0600DB72 RID: 56178 RVA: 0x000672B3 File Offset: 0x000654B3
			public unsafe SaveInfo autoLoadSave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_autoLoadSave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_autoLoadSave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F6 RID: 17142
			// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x003654D8 File Offset: 0x003636D8
			// (set) Token: 0x0600DB74 RID: 56180 RVA: 0x000672D2 File Offset: 0x000654D2
			public unsafe MainMenuPopup.Data mainMenuPopup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_mainMenuPopup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPopup.Data>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.NativeFieldInfoPtr_mainMenuPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095E1 RID: 38369
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095E2 RID: 38370
			private static readonly IntPtr NativeFieldInfoPtr_autoLoadSave;

			// Token: 0x040095E3 RID: 38371
			private static readonly IntPtr NativeFieldInfoPtr_mainMenuPopup;

			// Token: 0x040095E4 RID: 38372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E5 RID: 38373
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DBA RID: 3514
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass82_0+<<ExitToMenu>g__Load|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FDF7 RID: 65015 RVA: 0x003C7370 File Offset: 0x003C5570
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0>.NativeClassPtr, "<<ExitToMenu>g__Load|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668898);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668899);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668900);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668901);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668902);
					LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668903);
				}

				// Token: 0x0600FDF8 RID: 65016 RVA: 0x003C7464 File Offset: 0x003C5664
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDF9 RID: 65017 RVA: 0x003C74AC File Offset: 0x003C56AC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FDFA RID: 65018 RVA: 0x003C74E0 File Offset: 0x003C56E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126016, XrefRangeEnd = 126054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D3E RID: 19774
				// (get) Token: 0x0600FDFB RID: 65019 RVA: 0x003C751C File Offset: 0x003C571C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDFC RID: 65020 RVA: 0x003C755C File Offset: 0x003C575C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126054, XrefRangeEnd = 126059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D3F RID: 19775
				// (get) Token: 0x0600FDFD RID: 65021 RVA: 0x003C7590 File Offset: 0x003C5790
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FDFE RID: 65022 RVA: 0x0007854D File Offset: 0x0007674D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D3A RID: 19770
				// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x003C75D0 File Offset: 0x003C57D0
				// (set) Token: 0x0600FE00 RID: 65024 RVA: 0x00078556 File Offset: 0x00076756
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D3B RID: 19771
				// (get) Token: 0x0600FE01 RID: 65025 RVA: 0x003C75F8 File Offset: 0x003C57F8
				// (set) Token: 0x0600FE02 RID: 65026 RVA: 0x00078571 File Offset: 0x00076771
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D3C RID: 19772
				// (get) Token: 0x0600FE03 RID: 65027 RVA: 0x003C7628 File Offset: 0x003C5828
				// (set) Token: 0x0600FE04 RID: 65028 RVA: 0x00078590 File Offset: 0x00076790
				public unsafe LoadManager.__c__DisplayClass82_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass82_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D3D RID: 19773
				// (get) Token: 0x0600FE05 RID: 65029 RVA: 0x003C7658 File Offset: 0x003C5858
				// (set) Token: 0x0600FE06 RID: 65030 RVA: 0x000785AF File Offset: 0x000767AF
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB30 RID: 43824
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB31 RID: 43825
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB32 RID: 43826
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB33 RID: 43827
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400AB34 RID: 43828
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB35 RID: 43829
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB36 RID: 43830
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB37 RID: 43831
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB38 RID: 43832
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB39 RID: 43833
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009B5 RID: 2485
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass82_1")]
		public sealed class __c__DisplayClass82_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DB75 RID: 56181 RVA: 0x00365508 File Offset: 0x00363708
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass82_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_timeOnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr, "timeOnWaitStart");
				LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_maxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr, "maxWait");
				LoadManager.__c__DisplayClass82_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr, 100668904);
				LoadManager.__c__DisplayClass82_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr, 100668905);
			}

			// Token: 0x0600DB76 RID: 56182 RVA: 0x00365584 File Offset: 0x00363784
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass82_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB77 RID: 56183 RVA: 0x003655C0 File Offset: 0x003637C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126065, XrefRangeEnd = 126069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExitToMenu_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass82_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB78 RID: 56184 RVA: 0x000672F1 File Offset: 0x000654F1
			public __c__DisplayClass82_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F7 RID: 17143
			// (get) Token: 0x0600DB79 RID: 56185 RVA: 0x003655FC File Offset: 0x003637FC
			// (set) Token: 0x0600DB7A RID: 56186 RVA: 0x000672FA File Offset: 0x000654FA
			public unsafe float timeOnWaitStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_timeOnWaitStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_timeOnWaitStart)) = value;
				}
			}

			// Token: 0x170042F8 RID: 17144
			// (get) Token: 0x0600DB7B RID: 56187 RVA: 0x00365624 File Offset: 0x00363824
			// (set) Token: 0x0600DB7C RID: 56188 RVA: 0x00067315 File Offset: 0x00065515
			public unsafe float maxWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_maxWait);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass82_1.NativeFieldInfoPtr_maxWait)) = value;
				}
			}

			// Token: 0x040095E6 RID: 38374
			private static readonly IntPtr NativeFieldInfoPtr_timeOnWaitStart;

			// Token: 0x040095E7 RID: 38375
			private static readonly IntPtr NativeFieldInfoPtr_maxWait;

			// Token: 0x040095E8 RID: 38376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E9 RID: 38377
			private static readonly IntPtr NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0;
		}
	}
}
