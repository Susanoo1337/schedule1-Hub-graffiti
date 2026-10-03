using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000140 RID: 320
	[Serializable]
	public class Quest : MonoBehaviour
	{
		// Token: 0x06001FDD RID: 8157 RVA: 0x000E36B4 File Offset: 0x000E18B4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest()
		{
			Il2CppClassPointerStore<Quest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest>.NativeClassPtr);
			Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "MAX_HUD_ENTRY_LABELS");
			Quest.NativeFieldInfoPtr_CriticalExpiryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CriticalExpiryThreshold");
			Quest.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Quests");
			Quest.NativeFieldInfoPtr_HoveredQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "HoveredQuest");
			Quest.NativeFieldInfoPtr_ActiveQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ActiveQuests");
			Quest.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<State>k__BackingField");
			Quest.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<GUID>k__BackingField");
			Quest.NativeFieldInfoPtr__IsTracked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<IsTracked>k__BackingField");
			Quest.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "title");
			Quest.NativeFieldInfoPtr_Subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Subtitle");
			Quest.NativeFieldInfoPtr_onSubtitleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onSubtitleChanged");
			Quest.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Description");
			Quest.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "StaticGUID");
			Quest.NativeFieldInfoPtr_TrackOnBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "TrackOnBegin");
			Quest.NativeFieldInfoPtr_ExpiryVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ExpiryVisibility");
			Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoCompleteOnAllEntriesComplete");
			Quest.NativeFieldInfoPtr_PlayQuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PlayQuestCompleteSound");
			Quest.NativeFieldInfoPtr_CompletionXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CompletionXP");
			Quest.NativeFieldInfoPtr__Expires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expires>k__BackingField");
			Quest.NativeFieldInfoPtr__Expiry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expiry>k__BackingField");
			Quest.NativeFieldInfoPtr_AutoStartFirstEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoStartFirstEntry");
			Quest.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Entries");
			Quest.NativeFieldInfoPtr_IconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "IconPrefab");
			Quest.NativeFieldInfoPtr_PoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PoIPrefab");
			Quest.NativeFieldInfoPtr_onQuestBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestBegin");
			Quest.NativeFieldInfoPtr_onQuestEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestEnd");
			Quest.NativeFieldInfoPtr_onActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onActiveState");
			Quest.NativeFieldInfoPtr_onTrackChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onTrackChange");
			Quest.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onComplete");
			Quest.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onInitialComplete");
			Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiryReminder");
			Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiredNotification");
			Quest.NativeFieldInfoPtr_journalEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "journalEntry");
			Quest.NativeFieldInfoPtr_entryTitleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTitleRect");
			Quest.NativeFieldInfoPtr_trackedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "trackedRect");
			Quest.NativeFieldInfoPtr_entryTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTimeLabel");
			Quest.NativeFieldInfoPtr_criticalTimeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "criticalTimeBackground");
			Quest.NativeFieldInfoPtr_detailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "detailPanel");
			Quest.NativeFieldInfoPtr__hudUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<hudUI>k__BackingField");
			Quest.NativeFieldInfoPtr_onHudUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onHudUICreated");
			Quest.NativeFieldInfoPtr_expiryReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "expiryReminderSent");
			Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Quest.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<HasChanged>k__BackingField");
			Quest.NativeFieldInfoPtr_autoInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "autoInitialize");
			Quest.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667419);
			Quest.NativeMethodInfoPtr_set_State_Protected_set_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667420);
			Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667421);
			Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667422);
			Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667423);
			Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667424);
			Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667425);
			Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667426);
			Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667427);
			Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667428);
			Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667429);
			Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667430);
			Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667431);
			Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667432);
			Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667433);
			Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667434);
			Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667435);
			Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667436);
			Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667437);
			Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667438);
			Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667439);
			Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667440);
			Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667441);
			Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667442);
			Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667443);
			Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667444);
			Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667445);
			Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667446);
			Quest.NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667447);
			Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667448);
			Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667449);
			Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667450);
			Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667451);
			Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667452);
			Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667453);
			Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667454);
			Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667455);
			Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667456);
			Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667457);
			Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667458);
			Quest.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667459);
			Quest.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667460);
			Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667461);
			Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667462);
			Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667463);
			Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667464);
			Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667465);
			Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667466);
			Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667467);
			Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667468);
			Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667469);
			Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667470);
			Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667471);
			Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667472);
			Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667473);
			Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667474);
			Quest.NativeMethodInfoPtr_SetupHUDUI_Public_Virtual_New_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667475);
			Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667476);
			Quest.NativeMethodInfoPtr_DestroyHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667477);
			Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667478);
			Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667479);
			Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667480);
			Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667481);
			Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667482);
			Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667483);
			Quest.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667484);
			Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667485);
			Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667486);
			Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667487);
			Quest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667488);
			Quest.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667490);
			Quest.NativeMethodInfoPtr__SetupJournalEntry_b__111_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667491);
			Quest.NativeMethodInfoPtr__SetupJournalEntry_b__111_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667492);
			Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667493);
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000E4030 File Offset: 0x000E2230
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x000E406C File Offset: 0x000E226C
		public unsafe EQuestState State
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_State_Protected_set_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000E40AC File Offset: 0x000E22AC
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x000E40E8 File Offset: 0x000E22E8
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000E4128 File Offset: 0x000E2328
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x000E4164 File Offset: 0x000E2364
		public unsafe bool IsTracked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000E41A4 File Offset: 0x000E23A4
		public unsafe int ActiveEntryCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107606, RefRangeEnd = 107607, XrefRangeStart = 107588, XrefRangeEnd = 107606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000E41E0 File Offset: 0x000E23E0
		public unsafe string Title
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 107607, RefRangeEnd = 107609, XrefRangeStart = 107607, XrefRangeEnd = 107607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000E4218 File Offset: 0x000E2418
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x000E4254 File Offset: 0x000E2454
		public unsafe bool Expires
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x000E4294 File Offset: 0x000E2494
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x000E42D0 File Offset: 0x000E24D0
		public unsafe GameDateTime Expiry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000E4310 File Offset: 0x000E2510
		public unsafe bool hudUIExists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107609, XrefRangeEnd = 107613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000E434C File Offset: 0x000E254C
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x000E438C File Offset: 0x000E258C
		public unsafe QuestHUDUI hudUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000E43D0 File Offset: 0x000E25D0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107613, XrefRangeEnd = 107618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000E4408 File Offset: 0x000E2608
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107618, XrefRangeEnd = 107623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x000E4440 File Offset: 0x000E2640
		public unsafe virtual Loader Loader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x000E4480 File Offset: 0x000E2680
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x000E44BC File Offset: 0x000E26BC
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x000E44FC File Offset: 0x000E26FC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107623, XrefRangeEnd = 107624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000E4540 File Offset: 0x000E2740
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x000E4580 File Offset: 0x000E2780
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107624, XrefRangeEnd = 107625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x000E45C4 File Offset: 0x000E27C4
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x000E4600 File Offset: 0x000E2800
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000E4640 File Offset: 0x000E2840
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000E467C File Offset: 0x000E287C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 107664, RefRangeEnd = 107672, XrefRangeStart = 107625, XrefRangeEnd = 107664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000E46B8 File Offset: 0x000E28B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107738, RefRangeEnd = 107739, XrefRangeStart = 107672, XrefRangeEnd = 107738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeQuest(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000E473C File Offset: 0x000E293C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldQuestShowUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000E4784 File Offset: 0x000E2984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107739, XrefRangeEnd = 107745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000E47C0 File Offset: 0x000E29C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107745, RefRangeEnd = 107746, XrefRangeStart = 107745, XrefRangeEnd = 107745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expires;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000E480C File Offset: 0x000E2A0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 107757, RefRangeEnd = 107761, XrefRangeStart = 107746, XrefRangeEnd = 107757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000E4858 File Offset: 0x000E2A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107780, RefRangeEnd = 107781, XrefRangeStart = 107761, XrefRangeEnd = 107780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000E48A4 File Offset: 0x000E2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107781, XrefRangeEnd = 107787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fail(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000E48F0 File Offset: 0x000E2AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107787, XrefRangeEnd = 107792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Expire(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000E493C File Offset: 0x000E2B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107792, XrefRangeEnd = 107798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000E4988 File Offset: 0x000E2B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107845, RefRangeEnd = 107847, XrefRangeStart = 107798, XrefRangeEnd = 107845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000E49C4 File Offset: 0x000E2BC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107895, RefRangeEnd = 107900, XrefRangeStart = 107847, XrefRangeEnd = 107895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000E4A1C File Offset: 0x000E2C1C
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000E4A64 File Offset: 0x000E2C64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107911, RefRangeEnd = 107913, XrefRangeStart = 107900, XrefRangeEnd = 107911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000E4ACC File Offset: 0x000E2CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107913, XrefRangeEnd = 107924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000E4B08 File Offset: 0x000E2D08
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000E4B44 File Offset: 0x000E2D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107924, XrefRangeEnd = 107926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000E4B80 File Offset: 0x000E2D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107926, XrefRangeEnd = 107931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAutoComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000E4BB4 File Offset: 0x000E2DB4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000E4BFC File Offset: 0x000E2DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107931, XrefRangeEnd = 107942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000E4C38 File Offset: 0x000E2E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107942, XrefRangeEnd = 107953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000E4C74 File Offset: 0x000E2E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107953, XrefRangeEnd = 107957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000E4CB4 File Offset: 0x000E2EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107958, RefRangeEnd = 107960, XrefRangeStart = 107957, XrefRangeEnd = 107958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubtitle(string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000E4CF8 File Offset: 0x000E2EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107960, XrefRangeEnd = 107984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsTracked(bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000E4D44 File Offset: 0x000E2F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107984, XrefRangeEnd = 108096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000E4D80 File Offset: 0x000E2F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108096, XrefRangeEnd = 108105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000E4DB4 File Offset: 0x000E2FB4
		[CallerCount(0)]
		public unsafe void JournalEntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000E4DE8 File Offset: 0x000E2FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108105, XrefRangeEnd = 108111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JournalEntryHoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000E4E1C File Offset: 0x000E301C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 108117, RefRangeEnd = 108125, XrefRangeStart = 108111, XrefRangeEnd = 108117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinsUntilExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000E4E58 File Offset: 0x000E3058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108131, RefRangeEnd = 108133, XrefRangeStart = 108125, XrefRangeEnd = 108131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExpiryText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000E4E90 File Offset: 0x000E3090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108133, XrefRangeEnd = 108158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual QuestHUDUI SetupHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupHUDUI_Public_Virtual_New_QuestHUDUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000E4EDC File Offset: 0x000E30DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108158, XrefRangeEnd = 108159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000E4F10 File Offset: 0x000E3110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108159, XrefRangeEnd = 108160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000E4F44 File Offset: 0x000E3144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108160, XrefRangeEnd = 108165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000E4F78 File Offset: 0x000E3178
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetQuestTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000E4FBC File Offset: 0x000E31BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108172, RefRangeEnd = 108174, XrefRangeStart = 108165, XrefRangeEnd = 108172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry GetFirstActiveEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr3) : null;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000E4FFC File Offset: 0x000E31FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108174, XrefRangeEnd = 108295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000E5058 File Offset: 0x000E3258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108305, RefRangeEnd = 108307, XrefRangeStart = 108295, XrefRangeEnd = 108305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDetailDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000E508C File Offset: 0x000E328C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000E50D4 File Offset: 0x000E32D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108307, XrefRangeEnd = 108339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000E5120 File Offset: 0x000E3320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108339, XrefRangeEnd = 108340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000E5158 File Offset: 0x000E3358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108340, XrefRangeEnd = 108362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(QuestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000E51A8 File Offset: 0x000E33A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 108381, RefRangeEnd = 108386, XrefRangeStart = 108362, XrefRangeEnd = 108381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quest GetQuest(string questName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000E51EC File Offset: 0x000E33EC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 108415, RefRangeEnd = 108440, XrefRangeStart = 108386, XrefRangeEnd = 108415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000E5228 File Offset: 0x000E3428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108479, RefRangeEnd = 108480, XrefRangeStart = 108440, XrefRangeEnd = 108479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000E525C File Offset: 0x000E345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108480, XrefRangeEnd = 108486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupJournalEntry_b__111_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__SetupJournalEntry_b__111_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000E52A0 File Offset: 0x000E34A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupJournalEntry_b__111_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__SetupJournalEntry_b__111_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000E52E4 File Offset: 0x000E34E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108486, XrefRangeEnd = 108515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00011319 File Offset: 0x0000F519
		public Quest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x000E5318 File Offset: 0x000E3518
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x00011322 File Offset: 0x0000F522
		public unsafe static int MAX_HUD_ENTRY_LABELS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&value));
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x000E5334 File Offset: 0x000E3534
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x00011330 File Offset: 0x0000F530
		public unsafe static int CriticalExpiryThreshold
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x000E5350 File Offset: 0x000E3550
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x0001133E File Offset: 0x0000F53E
		public unsafe static List<Quest> Quests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_Quests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_Quests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x000E5378 File Offset: 0x000E3578
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x00011350 File Offset: 0x0000F550
		public unsafe static Quest HoveredQuest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_HoveredQuest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_HoveredQuest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x000E53A0 File Offset: 0x000E35A0
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x00011362 File Offset: 0x0000F562
		public unsafe static List<Quest> ActiveQuests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_ActiveQuests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_ActiveQuests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x000E53C8 File Offset: 0x000E35C8
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x00011374 File Offset: 0x0000F574
		public unsafe EQuestState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x000E53F0 File Offset: 0x000E35F0
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0001138F File Offset: 0x0000F58F
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x000E5418 File Offset: 0x000E3618
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x000113AA File Offset: 0x0000F5AA
		public unsafe bool _IsTracked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x000E5440 File Offset: 0x000E3640
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x000113C5 File Offset: 0x0000F5C5
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x000E5468 File Offset: 0x000E3668
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x000113E4 File Offset: 0x0000F5E4
		public unsafe string Subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x000E5490 File Offset: 0x000E3690
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x00011403 File Offset: 0x0000F603
		public unsafe Action onSubtitleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x000E54C0 File Offset: 0x000E36C0
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x00011422 File Offset: 0x0000F622
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x000E54E8 File Offset: 0x000E36E8
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x00011441 File Offset: 0x0000F641
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x000E5510 File Offset: 0x000E3710
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x00011460 File Offset: 0x0000F660
		public unsafe bool TrackOnBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x000E5538 File Offset: 0x000E3738
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x0001147B File Offset: 0x0000F67B
		public unsafe EExpiryVisibility ExpiryVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility)) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x000E5560 File Offset: 0x000E3760
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x00011496 File Offset: 0x0000F696
		public unsafe bool AutoCompleteOnAllEntriesComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete)) = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x000E5588 File Offset: 0x000E3788
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x000114B1 File Offset: 0x0000F6B1
		public unsafe bool PlayQuestCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound)) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x000E55B0 File Offset: 0x000E37B0
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x000114CC File Offset: 0x0000F6CC
		public unsafe int CompletionXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP)) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000E55D8 File Offset: 0x000E37D8
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x000114E7 File Offset: 0x0000F6E7
		public unsafe bool _Expires_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000E5600 File Offset: 0x000E3800
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00011502 File Offset: 0x0000F702
		public unsafe GameDateTime _Expiry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000E5628 File Offset: 0x000E3828
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x0001151D File Offset: 0x0000F71D
		public unsafe bool AutoStartFirstEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x000E5650 File Offset: 0x000E3850
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00011538 File Offset: 0x0000F738
		public unsafe List<QuestEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x000E5680 File Offset: 0x000E3880
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00011557 File Offset: 0x0000F757
		public unsafe RectTransform IconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x000E56B0 File Offset: 0x000E38B0
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00011576 File Offset: 0x0000F776
		public unsafe GameObject PoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x000E56E0 File Offset: 0x000E38E0
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00011595 File Offset: 0x0000F795
		public unsafe UnityEvent onQuestBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000E5710 File Offset: 0x000E3910
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x000115B4 File Offset: 0x0000F7B4
		public unsafe UnityEvent<EQuestState> onQuestEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuestState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x000E5740 File Offset: 0x000E3940
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x000115D3 File Offset: 0x0000F7D3
		public unsafe UnityEvent onActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x000E5770 File Offset: 0x000E3970
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x000115F2 File Offset: 0x0000F7F2
		public unsafe UnityEvent<bool> onTrackChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x000E57A0 File Offset: 0x000E39A0
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00011611 File Offset: 0x0000F811
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x000E57D0 File Offset: 0x000E39D0
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00011630 File Offset: 0x0000F830
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000E5800 File Offset: 0x000E3A00
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0001164F File Offset: 0x0000F84F
		public unsafe bool ShouldSendExpiryReminder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder)) = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x000E5828 File Offset: 0x000E3A28
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x0001166A File Offset: 0x0000F86A
		public unsafe bool ShouldSendExpiredNotification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification)) = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x000E5850 File Offset: 0x000E3A50
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00011685 File Offset: 0x0000F885
		public unsafe RectTransform journalEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x000E5880 File Offset: 0x000E3A80
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x000116A4 File Offset: 0x0000F8A4
		public unsafe RectTransform entryTitleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x000E58B0 File Offset: 0x000E3AB0
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x000116C3 File Offset: 0x0000F8C3
		public unsafe RectTransform trackedRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x000E58E0 File Offset: 0x000E3AE0
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x000116E2 File Offset: 0x0000F8E2
		public unsafe Text entryTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x000E5910 File Offset: 0x000E3B10
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00011701 File Offset: 0x0000F901
		public unsafe Image criticalTimeBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000E5940 File Offset: 0x000E3B40
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00011720 File Offset: 0x0000F920
		public unsafe RectTransform detailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x000E5970 File Offset: 0x000E3B70
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0001173F File Offset: 0x0000F93F
		public unsafe QuestHUDUI _hudUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x000E59A0 File Offset: 0x000E3BA0
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0001175E File Offset: 0x0000F95E
		public unsafe Action onHudUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000E59D0 File Offset: 0x000E3BD0
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0001177D File Offset: 0x0000F97D
		public unsafe bool expiryReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x000E59F8 File Offset: 0x000E3BF8
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00011798 File Offset: 0x0000F998
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x000E5A28 File Offset: 0x000E3C28
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x000117B7 File Offset: 0x0000F9B7
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x000E5A58 File Offset: 0x000E3C58
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x000117D6 File Offset: 0x0000F9D6
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x000E5A80 File Offset: 0x000E3C80
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x000117F1 File Offset: 0x0000F9F1
		public unsafe bool autoInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize)) = value;
			}
		}

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeFieldInfoPtr_CriticalExpiryThreshold;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeFieldInfoPtr_HoveredQuest;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeFieldInfoPtr_ActiveQuests;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr__IsTracked_k__BackingField;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_Subtitle;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_onSubtitleChanged;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr_TrackOnBegin;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryVisibility;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_PlayQuestCompleteSound;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_CompletionXP;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr__Expires_k__BackingField;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr__Expiry_k__BackingField;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_AutoStartFirstEntry;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_IconPrefab;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr_PoIPrefab;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr_onQuestBegin;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr_onQuestEnd;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_onActiveState;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_onTrackChange;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiryReminder;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiredNotification;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_journalEntry;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_entryTitleRect;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_trackedRect;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeFieldInfoPtr_entryTimeLabel;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeFieldInfoPtr_criticalTimeBackground;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeFieldInfoPtr_detailPanel;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeFieldInfoPtr__hudUI_k__BackingField;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_onHudUICreated;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeFieldInfoPtr_expiryReminderSent;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeFieldInfoPtr_autoInitialize;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EQuestState_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EQuestState_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_GetExpiryText_Public_String_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_SetupHUDUI_Public_Virtual_New_QuestHUDUI_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHUDUI_Public_Void_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_BopHUDUI_Public_Void_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr__SetupJournalEntry_b__111_0_Private_Void_BaseEventData_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr__SetupJournalEntry_b__111_1_Private_Void_BaseEventData_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000969 RID: 2409
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D94A RID: 55626 RVA: 0x0035EFD4 File Offset: 0x0035D1D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr);
				Quest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9");
				Quest.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9__18_0");
				Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667495);
				Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667496);
			}

			// Token: 0x0600D94B RID: 55627 RVA: 0x0035F050 File Offset: 0x0035D250
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D94C RID: 55628 RVA: 0x0035F08C File Offset: 0x0035D28C
			[CallerCount(0)]
			public unsafe bool _get_ActiveEntryCount_b__18_0(QuestEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D94D RID: 55629 RVA: 0x000662F9 File Offset: 0x000644F9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425D RID: 16989
			// (get) Token: 0x0600D94E RID: 55630 RVA: 0x0035F0DC File Offset: 0x0035D2DC
			// (set) Token: 0x0600D94F RID: 55631 RVA: 0x00066302 File Offset: 0x00064502
			public unsafe static Quest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425E RID: 16990
			// (get) Token: 0x0600D950 RID: 55632 RVA: 0x0035F104 File Offset: 0x0035D304
			// (set) Token: 0x0600D951 RID: 55633 RVA: 0x00066314 File Offset: 0x00064514
			public unsafe static Func<QuestEntry, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009452 RID: 37970
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009453 RID: 37971
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04009454 RID: 37972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009455 RID: 37973
			private static readonly IntPtr NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0;
		}

		// Token: 0x0200096A RID: 2410
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c__DisplayClass129_0")]
		public sealed class __c__DisplayClass129_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D952 RID: 55634 RVA: 0x0035F12C File Offset: 0x0035D32C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass129_0()
			{
				Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c__DisplayClass129_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr);
				Quest.__c__DisplayClass129_0.NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr, "questName");
				Quest.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr, 100667497);
				Quest.__c__DisplayClass129_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr, 100667498);
			}

			// Token: 0x0600D953 RID: 55635 RVA: 0x0035F194 File Offset: 0x0035D394
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass129_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c__DisplayClass129_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D954 RID: 55636 RVA: 0x0035F1D0 File Offset: 0x0035D3D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107584, XrefRangeEnd = 107588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetQuest_b__0(Quest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass129_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D955 RID: 55637 RVA: 0x00066326 File Offset: 0x00064526
			public __c__DisplayClass129_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425F RID: 16991
			// (get) Token: 0x0600D956 RID: 55638 RVA: 0x0035F220 File Offset: 0x0035D420
			// (set) Token: 0x0600D957 RID: 55639 RVA: 0x0006632F File Offset: 0x0006452F
			public unsafe string questName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass129_0.NativeFieldInfoPtr_questName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass129_0.NativeFieldInfoPtr_questName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009456 RID: 37974
			private static readonly IntPtr NativeFieldInfoPtr_questName;

			// Token: 0x04009457 RID: 37975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009458 RID: 37976
			private static readonly IntPtr NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0;
		}
	}
}
