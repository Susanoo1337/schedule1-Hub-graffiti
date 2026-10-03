using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public class MSGConversation : Il2CppSystem.Object
	{
		// Token: 0x06003399 RID: 13209 RVA: 0x00126CE4 File Offset: 0x00124EE4
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversation()
		{
			Il2CppClassPointerStore<MSGConversation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MSGConversation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr);
			MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "MAX_MESSAGE_HISTORY");
			MSGConversation.NativeFieldInfoPtr_contactName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "contactName");
			MSGConversation.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sender");
			MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<IsSenderKnown>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_messageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageHistory");
			MSGConversation.NativeFieldInfoPtr_messageChainHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageChainHistory");
			MSGConversation.NativeFieldInfoPtr_bubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbles");
			MSGConversation.NativeFieldInfoPtr_Sendables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Sendables");
			MSGConversation.NativeFieldInfoPtr__Read_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<Read>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<index>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<isOpen>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<rollingOut>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<EntryVisible>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Categories");
			MSGConversation.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entry");
			MSGConversation.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "container");
			MSGConversation.NativeFieldInfoPtr_bubbleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbleContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRectContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRect");
			MSGConversation.NativeFieldInfoPtr_entryPreviewText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entryPreviewText");
			MSGConversation.NativeFieldInfoPtr_unreadDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "unreadDot");
			MSGConversation.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "slider");
			MSGConversation.NativeFieldInfoPtr_sliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sliderFill");
			MSGConversation.NativeFieldInfoPtr_responseContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseContainer");
			MSGConversation.NativeFieldInfoPtr_senderInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "senderInterface");
			MSGConversation.NativeFieldInfoPtr_uiSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "uiSelectable");
			MSGConversation.NativeFieldInfoPtr_dialogueScreenUIPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "dialogueScreenUIPanel");
			MSGConversation.NativeFieldInfoPtr_uiCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "uiCreated");
			MSGConversation.NativeFieldInfoPtr_onMessageRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onMessageRendered");
			MSGConversation.NativeFieldInfoPtr_onLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onLoaded");
			MSGConversation.NativeFieldInfoPtr_onResponsesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onResponsesShown");
			MSGConversation.NativeFieldInfoPtr_onConversationOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onConversationOpened");
			MSGConversation.NativeFieldInfoPtr_currentResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "currentResponses");
			MSGConversation.NativeFieldInfoPtr_responseRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseRects");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<HasChanged>k__BackingField");
			MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669804);
			MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669805);
			MSGConversation.NativeMethodInfoPtr_get_Read_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669806);
			MSGConversation.NativeMethodInfoPtr_set_Read_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669807);
			MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669808);
			MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669809);
			MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669810);
			MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669811);
			MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669812);
			MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669813);
			MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669814);
			MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669815);
			MSGConversation.NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669816);
			MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669817);
			MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669818);
			MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669819);
			MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669820);
			MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669821);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669822);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669823);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669824);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669825);
			MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669826);
			MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669827);
			MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669828);
			MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669829);
			MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669830);
			MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669831);
			MSGConversation.NativeMethodInfoPtr_ShouldReplicate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669832);
			MSGConversation.NativeMethodInfoPtr_GetReplicationByteSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669833);
			MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669834);
			MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669835);
			MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669836);
			MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669837);
			MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669838);
			MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669839);
			MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669840);
			MSGConversation.NativeMethodInfoPtr_DisplayRelationshipInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669841);
			MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669842);
			MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669843);
			MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669844);
			MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669845);
			MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669846);
			MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669847);
			MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669848);
			MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669849);
			MSGConversation.NativeMethodInfoPtr_ResetConversation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669850);
			MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669851);
			MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669852);
			MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669853);
			MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669854);
			MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669855);
			MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669856);
			MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669857);
			MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669858);
			MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669859);
			MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669860);
			MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669861);
			MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669862);
			MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669863);
			MSGConversation.NativeMethodInfoPtr__CreateUI_b__82_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669864);
			MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100669865);
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x001274D0 File Offset: 0x001256D0
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x0012750C File Offset: 0x0012570C
		public unsafe bool IsSenderKnown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x0012754C File Offset: 0x0012574C
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00127588 File Offset: 0x00125788
		public unsafe bool Read
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_Read_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_Read_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x001275C8 File Offset: 0x001257C8
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x00127604 File Offset: 0x00125804
		public unsafe int index
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 44533, RefRangeEnd = 44544, XrefRangeStart = 44533, XrefRangeEnd = 44544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 44544, RefRangeEnd = 44553, XrefRangeStart = 44544, XrefRangeEnd = 44553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00127644 File Offset: 0x00125844
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x00127680 File Offset: 0x00125880
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x001276C0 File Offset: 0x001258C0
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x001276FC File Offset: 0x001258FC
		public unsafe bool rollingOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x0012773C File Offset: 0x0012593C
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x00127778 File Offset: 0x00125978
		public unsafe bool EntryVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x001277B8 File Offset: 0x001259B8
		public unsafe UISelectable UISelectable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x001277F8 File Offset: 0x001259F8
		public unsafe bool AreResponsesActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138689, XrefRangeEnd = 138690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x00127834 File Offset: 0x00125A34
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138690, XrefRangeEnd = 138692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x0012786C File Offset: 0x00125A6C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138692, XrefRangeEnd = 138694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x001278A4 File Offset: 0x00125AA4
		public unsafe virtual Loader Loader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x001278E4 File Offset: 0x00125AE4
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x00127920 File Offset: 0x00125B20
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x00127960 File Offset: 0x00125B60
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x001279A4 File Offset: 0x00125BA4
		// (set) Token: 0x060033AF RID: 13231 RVA: 0x001279E4 File Offset: 0x00125BE4
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x00127A28 File Offset: 0x00125C28
		// (set) Token: 0x060033B1 RID: 13233 RVA: 0x00127A64 File Offset: 0x00125C64
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00127AA4 File Offset: 0x00125CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138774, RefRangeEnd = 138775, XrefRangeStart = 138694, XrefRangeEnd = 138774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation(NPC _npc, string _contactName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_contactName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00127B04 File Offset: 0x00125D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138775, XrefRangeEnd = 138781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00127B40 File Offset: 0x00125D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategories(List<EConversationCategory> cat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00127B84 File Offset: 0x00125D84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138798, RefRangeEnd = 138801, XrefRangeStart = 138781, XrefRangeEnd = 138798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00127BB8 File Offset: 0x00125DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138803, RefRangeEnd = 138804, XrefRangeStart = 138801, XrefRangeEnd = 138803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldReplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ShouldReplicate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00127BF4 File Offset: 0x00125DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138806, RefRangeEnd = 138807, XrefRangeStart = 138804, XrefRangeEnd = 138806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetReplicationByteSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetReplicationByteSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00127C30 File Offset: 0x00125E30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 138949, RefRangeEnd = 138955, XrefRangeStart = 138807, XrefRangeEnd = 138949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00127C64 File Offset: 0x00125E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138955, XrefRangeEnd = 138956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureUIExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00127C98 File Offset: 0x00125E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138964, RefRangeEnd = 138967, XrefRangeStart = 138956, XrefRangeEnd = 138964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPreviewText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00127CCC File Offset: 0x00125ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138979, RefRangeEnd = 138981, XrefRangeStart = 138967, XrefRangeEnd = 138979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00127D00 File Offset: 0x00125F00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139005, RefRangeEnd = 139008, XrefRangeStart = 138981, XrefRangeEnd = 139005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsKnown(bool known)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref known;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00127D40 File Offset: 0x00125F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139008, XrefRangeEnd = 139009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00127D74 File Offset: 0x00125F74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139132, RefRangeEnd = 139136, XrefRangeStart = 139009, XrefRangeEnd = 139132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00127DB4 File Offset: 0x00125FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139177, RefRangeEnd = 139179, XrefRangeStart = 139136, XrefRangeEnd = 139177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayRelationshipInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_DisplayRelationshipInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00127DE8 File Offset: 0x00125FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139179, XrefRangeEnd = 139253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RenderMessage(Message m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00127E38 File Offset: 0x00126038
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139262, RefRangeEnd = 139266, XrefRangeStart = 139253, XrefRangeEnd = 139262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryVisibility(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00127E78 File Offset: 0x00126078
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 139297, RefRangeEnd = 139306, XrefRangeStart = 139266, XrefRangeEnd = 139297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRead(bool r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00127EB8 File Offset: 0x001260B8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 139350, RefRangeEnd = 139359, XrefRangeStart = 139306, XrefRangeEnd = 139350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message message, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00127F18 File Offset: 0x00126118
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 139392, RefRangeEnd = 139424, XrefRangeStart = 139359, XrefRangeEnd = 139392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00127F84 File Offset: 0x00126184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139480, RefRangeEnd = 139482, XrefRangeStart = 139424, XrefRangeEnd = 139480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr3) : null;
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00127FC4 File Offset: 0x001261C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139482, XrefRangeEnd = 139484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00128008 File Offset: 0x00126208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139484, XrefRangeEnd = 139536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00128058 File Offset: 0x00126258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139557, RefRangeEnd = 139558, XrefRangeStart = 139536, XrefRangeEnd = 139557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ResetConversation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x0012808C File Offset: 0x0012628C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139564, RefRangeEnd = 139566, XrefRangeStart = 139558, XrefRangeEnd = 139564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValue(float value, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x001280D8 File Offset: 0x001262D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139581, RefRangeEnd = 139582, XrefRangeStart = 139566, XrefRangeEnd = 139581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response GetResponse(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Response>(intPtr3) : null;
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00128128 File Offset: 0x00126328
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139609, RefRangeEnd = 139613, XrefRangeStart = 139582, XrefRangeEnd = 139609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_responses);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showResponseDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00128188 File Offset: 0x00126388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139664, RefRangeEnd = 139665, XrefRangeStart = 139613, XrefRangeEnd = 139664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResponseUI(Response r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x001281CC File Offset: 0x001263CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139678, RefRangeEnd = 139682, XrefRangeStart = 139665, XrefRangeEnd = 139678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponseUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00128200 File Offset: 0x00126400
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 139711, RefRangeEnd = 139717, XrefRangeStart = 139682, XrefRangeEnd = 139711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResponseContainerVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00128240 File Offset: 0x00126440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139730, RefRangeEnd = 139732, XrefRangeStart = 139717, XrefRangeEnd = 139730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseChosen(Response r, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00128290 File Offset: 0x00126490
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 139742, RefRangeEnd = 139748, XrefRangeStart = 139732, XrefRangeEnd = 139742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x001282D0 File Offset: 0x001264D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 139767, RefRangeEnd = 139772, XrefRangeStart = 139748, XrefRangeEnd = 139767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage CreateSendableMessage(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr3) : null;
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00128320 File Offset: 0x00126520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139782, RefRangeEnd = 139783, XrefRangeStart = 139772, XrefRangeEnd = 139782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x0012837C File Offset: 0x0012657C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139783, XrefRangeEnd = 139788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderPlayerMessage(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x001283C0 File Offset: 0x001265C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139788, XrefRangeEnd = 139800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSendLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x001283F4 File Offset: 0x001265F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139819, RefRangeEnd = 139822, XrefRangeStart = 139800, XrefRangeEnd = 139819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSendNewMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00128430 File Offset: 0x00126630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139822, XrefRangeEnd = 139823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateUI_b__82_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__CreateUI_b__82_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00128464 File Offset: 0x00126664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139823, XrefRangeEnd = 139828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x0001A4D0 File Offset: 0x000186D0
		public MSGConversation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x001284A4 File Offset: 0x001266A4
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x0001A4D9 File Offset: 0x000186D9
		public unsafe static int MAX_MESSAGE_HISTORY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&value));
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x001284C0 File Offset: 0x001266C0
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x0001A4E7 File Offset: 0x000186E7
		public unsafe string contactName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x001284E8 File Offset: 0x001266E8
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x0001A506 File Offset: 0x00018706
		public unsafe NPC sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x00128518 File Offset: 0x00126718
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x0001A525 File Offset: 0x00018725
		public unsafe bool _IsSenderKnown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField)) = value;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x00128540 File Offset: 0x00126740
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x0001A540 File Offset: 0x00018740
		public unsafe List<Message> messageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00128570 File Offset: 0x00126770
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x0001A55F File Offset: 0x0001875F
		public unsafe List<MessageChain> messageChainHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x001285A0 File Offset: 0x001267A0
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x0001A57E File Offset: 0x0001877E
		public unsafe List<MessageBubble> bubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x001285D0 File Offset: 0x001267D0
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x0001A59D File Offset: 0x0001879D
		public unsafe List<SendableMessage> Sendables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00128600 File Offset: 0x00126800
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x0001A5BC File Offset: 0x000187BC
		public unsafe bool _Read_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__Read_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__Read_k__BackingField)) = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00128628 File Offset: 0x00126828
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x0001A5D7 File Offset: 0x000187D7
		public unsafe int _index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x00128650 File Offset: 0x00126850
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x0001A5F2 File Offset: 0x000187F2
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00128678 File Offset: 0x00126878
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x0001A60D File Offset: 0x0001880D
		public unsafe bool _rollingOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField)) = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x001286A0 File Offset: 0x001268A0
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x0001A628 File Offset: 0x00018828
		public unsafe bool _EntryVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x001286C8 File Offset: 0x001268C8
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x0001A643 File Offset: 0x00018843
		public unsafe List<EConversationCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x001286F8 File Offset: 0x001268F8
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x0001A662 File Offset: 0x00018862
		public unsafe RectTransform entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x00128728 File Offset: 0x00126928
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x0001A681 File Offset: 0x00018881
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x00128758 File Offset: 0x00126958
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x0001A6A0 File Offset: 0x000188A0
		public unsafe RectTransform bubbleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x00128788 File Offset: 0x00126988
		// (set) Token: 0x060033FC RID: 13308 RVA: 0x0001A6BF File Offset: 0x000188BF
		public unsafe RectTransform scrollRectContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x060033FD RID: 13309 RVA: 0x001287B8 File Offset: 0x001269B8
		// (set) Token: 0x060033FE RID: 13310 RVA: 0x0001A6DE File Offset: 0x000188DE
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060033FF RID: 13311 RVA: 0x001287E8 File Offset: 0x001269E8
		// (set) Token: 0x06003400 RID: 13312 RVA: 0x0001A6FD File Offset: 0x000188FD
		public unsafe Text entryPreviewText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x00128818 File Offset: 0x00126A18
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x0001A71C File Offset: 0x0001891C
		public unsafe RectTransform unreadDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x00128848 File Offset: 0x00126A48
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x0001A73B File Offset: 0x0001893B
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x00128878 File Offset: 0x00126A78
		// (set) Token: 0x06003406 RID: 13318 RVA: 0x0001A75A File Offset: 0x0001895A
		public unsafe Image sliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x001288A8 File Offset: 0x00126AA8
		// (set) Token: 0x06003408 RID: 13320 RVA: 0x0001A779 File Offset: 0x00018979
		public unsafe RectTransform responseContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x001288D8 File Offset: 0x00126AD8
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x0001A798 File Offset: 0x00018998
		public unsafe MessageSenderInterface senderInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x00128908 File Offset: 0x00126B08
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x0001A7B7 File Offset: 0x000189B7
		public unsafe UISelectable uiSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x00128938 File Offset: 0x00126B38
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x0001A7D6 File Offset: 0x000189D6
		public unsafe UIPanel dialogueScreenUIPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_dialogueScreenUIPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_dialogueScreenUIPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x00128968 File Offset: 0x00126B68
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x0001A7F5 File Offset: 0x000189F5
		public unsafe bool uiCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated)) = value;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x00128990 File Offset: 0x00126B90
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x0001A810 File Offset: 0x00018A10
		public unsafe Action onMessageRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x001289C0 File Offset: 0x00126BC0
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x0001A82F File Offset: 0x00018A2F
		public unsafe Action onLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x001289F0 File Offset: 0x00126BF0
		// (set) Token: 0x06003416 RID: 13334 RVA: 0x0001A84E File Offset: 0x00018A4E
		public unsafe Action onResponsesShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x00128A20 File Offset: 0x00126C20
		// (set) Token: 0x06003418 RID: 13336 RVA: 0x0001A86D File Offset: 0x00018A6D
		public unsafe Action onConversationOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onConversationOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onConversationOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x00128A50 File Offset: 0x00126C50
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x0001A88C File Offset: 0x00018A8C
		public unsafe List<Response> currentResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00128A80 File Offset: 0x00126C80
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x0001A8AB File Offset: 0x00018AAB
		public unsafe List<RectTransform> responseRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x00128AB0 File Offset: 0x00126CB0
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x0001A8CA File Offset: 0x00018ACA
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x00128AE0 File Offset: 0x00126CE0
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x0001A8E9 File Offset: 0x00018AE9
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x00128B10 File Offset: 0x00126D10
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x0001A908 File Offset: 0x00018B08
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGE_HISTORY;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_contactName;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr__IsSenderKnown_k__BackingField;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr_messageHistory;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_messageChainHistory;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr_bubbles;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr_Sendables;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeFieldInfoPtr__Read_k__BackingField;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeFieldInfoPtr__rollingOut_k__BackingField;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeFieldInfoPtr__EntryVisible_k__BackingField;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeFieldInfoPtr_bubbleContainer;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeFieldInfoPtr_scrollRectContainer;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeFieldInfoPtr_entryPreviewText;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeFieldInfoPtr_unreadDot;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeFieldInfoPtr_sliderFill;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeFieldInfoPtr_responseContainer;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeFieldInfoPtr_senderInterface;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeFieldInfoPtr_uiSelectable;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeFieldInfoPtr_dialogueScreenUIPanel;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeFieldInfoPtr_uiCreated;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeFieldInfoPtr_onMessageRendered;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeFieldInfoPtr_onLoaded;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeFieldInfoPtr_onResponsesShown;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeFieldInfoPtr_onConversationOpened;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeFieldInfoPtr_currentResponses;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeFieldInfoPtr_responseRects;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_get_Read_Public_get_Boolean_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_set_Read_Private_set_Void_Boolean_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_MoveToTop_Public_Void_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReplicate_Public_Boolean_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_GetReplicationByteSize_Public_Int32_0;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Protected_Void_0;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUIExists_Public_Void_0;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntry_Public_Void_0;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_EntryClicked_Public_Void_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr_DisplayRelationshipInfo_Public_Void_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_ResetConversation_Public_Void_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Response_String_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_CheckSendLoop_Private_Void_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__82_0_Private_Void_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A02 RID: 2562
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<<CheckSendLoop>g__Loop|110_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD6D RID: 56685 RVA: 0x0036A958 File Offset: 0x00368B58
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique()
			{
				Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<<CheckSendLoop>g__Loop|110_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>1__state");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>2__current");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>4__this");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669866);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669867);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669868);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669869);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669870);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100669871);
			}

			// Token: 0x0600DD6E RID: 56686 RVA: 0x0036AA38 File Offset: 0x00368C38
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6F RID: 56687 RVA: 0x0036AA80 File Offset: 0x00368C80
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD70 RID: 56688 RVA: 0x0036AAB4 File Offset: 0x00368CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138602, XrefRangeEnd = 138615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004370 RID: 17264
			// (get) Token: 0x0600DD71 RID: 56689 RVA: 0x0036AAF0 File Offset: 0x00368CF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD72 RID: 56690 RVA: 0x0036AB30 File Offset: 0x00368D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138615, XrefRangeEnd = 138620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004371 RID: 17265
			// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x0036AB64 File Offset: 0x00368D64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD74 RID: 56692 RVA: 0x000683BD File Offset: 0x000665BD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x0036ABA4 File Offset: 0x00368DA4
			// (set) Token: 0x0600DD76 RID: 56694 RVA: 0x000683C6 File Offset: 0x000665C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700436E RID: 17262
			// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x0036ABCC File Offset: 0x00368DCC
			// (set) Token: 0x0600DD78 RID: 56696 RVA: 0x000683E1 File Offset: 0x000665E1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436F RID: 17263
			// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x0036ABFC File Offset: 0x00368DFC
			// (set) Token: 0x0600DD7A RID: 56698 RVA: 0x00068400 File Offset: 0x00066600
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096F3 RID: 38643
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040096F4 RID: 38644
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040096F5 RID: 38645
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096F6 RID: 38646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040096F7 RID: 38647
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040096F8 RID: 38648
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040096F9 RID: 38649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040096FA RID: 38650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040096FB RID: 38651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A03 RID: 2563
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DD7B RID: 56699 RVA: 0x0036AC2C File Offset: 0x00368E2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr);
				MSGConversation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9");
				MSGConversation.__c.NativeFieldInfoPtr___9__111_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9__111_0");
				MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100669873);
				MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__111_0_Internal_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100669874);
			}

			// Token: 0x0600DD7C RID: 56700 RVA: 0x0036ACA8 File Offset: 0x00368EA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD7D RID: 56701 RVA: 0x0036ACE4 File Offset: 0x00368EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138620, XrefRangeEnd = 138621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSendNewMessage_b__111_0(SendableMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__111_0_Internal_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD7E RID: 56702 RVA: 0x0006841F File Offset: 0x0006661F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004372 RID: 17266
			// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x0036AD34 File Offset: 0x00368F34
			// (set) Token: 0x0600DD80 RID: 56704 RVA: 0x00068428 File Offset: 0x00066628
			public unsafe static MSGConversation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004373 RID: 17267
			// (get) Token: 0x0600DD81 RID: 56705 RVA: 0x0036AD5C File Offset: 0x00368F5C
			// (set) Token: 0x0600DD82 RID: 56706 RVA: 0x0006843A File Offset: 0x0006663A
			public unsafe static Func<SendableMessage, bool> __9__111_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9__111_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SendableMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9__111_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096FC RID: 38652
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096FD RID: 38653
			private static readonly IntPtr NativeFieldInfoPtr___9__111_0;

			// Token: 0x040096FE RID: 38654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096FF RID: 38655
			private static readonly IntPtr NativeMethodInfoPtr__CanSendNewMessage_b__111_0_Internal_Boolean_SendableMessage_0;
		}

		// Token: 0x02000A04 RID: 2564
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass100_0")]
		public sealed class __c__DisplayClass100_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD83 RID: 56707 RVA: 0x0036AD84 File Offset: 0x00368F84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass100_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass100_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass100_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr, "label");
				MSGConversation.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr, 100669875);
				MSGConversation.__c__DisplayClass100_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr, 100669876);
			}

			// Token: 0x0600DD84 RID: 56708 RVA: 0x0036ADEC File Offset: 0x00368FEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass100_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass100_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD85 RID: 56709 RVA: 0x0036AE28 File Offset: 0x00369028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResponse_b__0(Response x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass100_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD86 RID: 56710 RVA: 0x0006844C File Offset: 0x0006664C
			public __c__DisplayClass100_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x0036AE78 File Offset: 0x00369078
			// (set) Token: 0x0600DD88 RID: 56712 RVA: 0x00068455 File Offset: 0x00066655
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass100_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass100_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009700 RID: 38656
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009701 RID: 38657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009702 RID: 38658
			private static readonly IntPtr NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0;
		}

		// Token: 0x02000A05 RID: 2565
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD89 RID: 56713 RVA: 0x0036AEA0 File Offset: 0x003690A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr_showResponseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr, "showResponseDelay");
				MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr, 100669877);
				MSGConversation.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr, 100669878);
			}

			// Token: 0x0600DD8A RID: 56714 RVA: 0x0036AF1C File Offset: 0x0036911C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8B RID: 56715 RVA: 0x0036AF58 File Offset: 0x00369158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138631, XrefRangeEnd = 138636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD8C RID: 56716 RVA: 0x00068474 File Offset: 0x00066674
			public __c__DisplayClass101_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004375 RID: 17269
			// (get) Token: 0x0600DD8D RID: 56717 RVA: 0x0036AF98 File Offset: 0x00369198
			// (set) Token: 0x0600DD8E RID: 56718 RVA: 0x0006847D File Offset: 0x0006667D
			public unsafe float showResponseDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr_showResponseDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr_showResponseDelay)) = value;
				}
			}

			// Token: 0x17004376 RID: 17270
			// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x0036AFC0 File Offset: 0x003691C0
			// (set) Token: 0x0600DD90 RID: 56720 RVA: 0x00068498 File Offset: 0x00066698
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009703 RID: 38659
			private static readonly IntPtr NativeFieldInfoPtr_showResponseDelay;

			// Token: 0x04009704 RID: 38660
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009705 RID: 38661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009706 RID: 38662
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DC0 RID: 3520
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass101_0+<<ShowResponses>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FE51 RID: 65105 RVA: 0x003C852C File Offset: 0x003C672C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0>.NativeClassPtr, "<<ShowResponses>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669879);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669880);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669881);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669882);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669883);
					MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669884);
				}

				// Token: 0x0600FE52 RID: 65106 RVA: 0x003C860C File Offset: 0x003C680C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE53 RID: 65107 RVA: 0x003C8654 File Offset: 0x003C6854
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE54 RID: 65108 RVA: 0x003C8688 File Offset: 0x003C6888
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138621, XrefRangeEnd = 138626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D5E RID: 19806
				// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x003C86C4 File Offset: 0x003C68C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE56 RID: 65110 RVA: 0x003C8704 File Offset: 0x003C6904
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138626, XrefRangeEnd = 138631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D5F RID: 19807
				// (get) Token: 0x0600FE57 RID: 65111 RVA: 0x003C8738 File Offset: 0x003C6938
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE58 RID: 65112 RVA: 0x000787F2 File Offset: 0x000769F2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D5B RID: 19803
				// (get) Token: 0x0600FE59 RID: 65113 RVA: 0x003C8778 File Offset: 0x003C6978
				// (set) Token: 0x0600FE5A RID: 65114 RVA: 0x000787FB File Offset: 0x000769FB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D5C RID: 19804
				// (get) Token: 0x0600FE5B RID: 65115 RVA: 0x003C87A0 File Offset: 0x003C69A0
				// (set) Token: 0x0600FE5C RID: 65116 RVA: 0x00078816 File Offset: 0x00076A16
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D5D RID: 19805
				// (get) Token: 0x0600FE5D RID: 65117 RVA: 0x003C87D0 File Offset: 0x003C69D0
				// (set) Token: 0x0600FE5E RID: 65118 RVA: 0x00078835 File Offset: 0x00076A35
				public unsafe MSGConversation.__c__DisplayClass101_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass101_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass101_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB69 RID: 43881
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB6A RID: 43882
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB6B RID: 43883
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB6C RID: 43884
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB6D RID: 43885
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB6E RID: 43886
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB6F RID: 43887
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB70 RID: 43888
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB71 RID: 43889
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A06 RID: 2566
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass102_0")]
		public sealed class __c__DisplayClass102_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD91 RID: 56721 RVA: 0x0036AFF0 File Offset: 0x003691F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass102_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass102_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr, "r");
				MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr, "network");
				MSGConversation.__c__DisplayClass102_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr, 100669885);
				MSGConversation.__c__DisplayClass102_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr, 100669886);
			}

			// Token: 0x0600DD92 RID: 56722 RVA: 0x0036B080 File Offset: 0x00369280
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass102_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass102_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass102_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD93 RID: 56723 RVA: 0x0036B0BC File Offset: 0x003692BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138636, XrefRangeEnd = 138638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateResponseUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass102_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD94 RID: 56724 RVA: 0x000684B7 File Offset: 0x000666B7
			public __c__DisplayClass102_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004377 RID: 17271
			// (get) Token: 0x0600DD95 RID: 56725 RVA: 0x0036B0F0 File Offset: 0x003692F0
			// (set) Token: 0x0600DD96 RID: 56726 RVA: 0x000684C0 File Offset: 0x000666C0
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004378 RID: 17272
			// (get) Token: 0x0600DD97 RID: 56727 RVA: 0x0036B120 File Offset: 0x00369320
			// (set) Token: 0x0600DD98 RID: 56728 RVA: 0x000684DF File Offset: 0x000666DF
			public unsafe Response r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_r);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Response>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_r), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004379 RID: 17273
			// (get) Token: 0x0600DD99 RID: 56729 RVA: 0x0036B150 File Offset: 0x00369350
			// (set) Token: 0x0600DD9A RID: 56730 RVA: 0x000684FE File Offset: 0x000666FE
			public unsafe bool network
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_network);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass102_0.NativeFieldInfoPtr_network)) = value;
				}
			}

			// Token: 0x04009707 RID: 38663
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009708 RID: 38664
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x04009709 RID: 38665
			private static readonly IntPtr NativeFieldInfoPtr_network;

			// Token: 0x0400970A RID: 38666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400970B RID: 38667
			private static readonly IntPtr NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0;
		}

		// Token: 0x02000A07 RID: 2567
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD9B RID: 56731 RVA: 0x0036B178 File Offset: 0x00369378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass93_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr, "message");
				MSGConversation.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr, 100669887);
				MSGConversation.__c__DisplayClass93_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr, 100669888);
			}

			// Token: 0x0600DD9C RID: 56732 RVA: 0x0036B1E0 File Offset: 0x003693E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD9D RID: 56733 RVA: 0x0036B21C File Offset: 0x0036941C
			[CallerCount(0)]
			public unsafe bool _SendMessage_b__0(Message x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass93_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD9E RID: 56734 RVA: 0x00068519 File Offset: 0x00066719
			public __c__DisplayClass93_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437A RID: 17274
			// (get) Token: 0x0600DD9F RID: 56735 RVA: 0x0036B26C File Offset: 0x0036946C
			// (set) Token: 0x0600DDA0 RID: 56736 RVA: 0x00068522 File Offset: 0x00066722
			public unsafe Message message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass93_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass93_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400970C RID: 38668
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x0400970D RID: 38669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400970E RID: 38670
			private static readonly IntPtr NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0;
		}

		// Token: 0x02000A08 RID: 2568
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDA1 RID: 56737 RVA: 0x0036B29C File Offset: 0x0036949C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, "messages");
				MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_notify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, "notify");
				MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, 100669889);
				MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, 100669890);
				MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, 100669891);
			}

			// Token: 0x0600DDA2 RID: 56738 RVA: 0x0036B340 File Offset: 0x00369540
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA3 RID: 56739 RVA: 0x0036B37C File Offset: 0x0036957C
			[CallerCount(0)]
			public unsafe bool _SendMessageChain_b__0(MessageChain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDA4 RID: 56740 RVA: 0x0036B3CC File Offset: 0x003695CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138683, XrefRangeEnd = 138689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_MessageChain_Single_PDM_0(MessageChain messageChain, float initialDelay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DDA5 RID: 56741 RVA: 0x00068541 File Offset: 0x00066741
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437B RID: 17275
			// (get) Token: 0x0600DDA6 RID: 56742 RVA: 0x0036B42C File Offset: 0x0036962C
			// (set) Token: 0x0600DDA7 RID: 56743 RVA: 0x0006854A File Offset: 0x0006674A
			public unsafe MessageChain messages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_messages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437C RID: 17276
			// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x0036B45C File Offset: 0x0036965C
			// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x00068569 File Offset: 0x00066769
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437D RID: 17277
			// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x0036B48C File Offset: 0x0036968C
			// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x00068588 File Offset: 0x00066788
			public unsafe bool notify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_notify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.NativeFieldInfoPtr_notify)) = value;
				}
			}

			// Token: 0x0400970F RID: 38671
			private static readonly IntPtr NativeFieldInfoPtr_messages;

			// Token: 0x04009710 RID: 38672
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009711 RID: 38673
			private static readonly IntPtr NativeFieldInfoPtr_notify;

			// Token: 0x04009712 RID: 38674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009713 RID: 38675
			private static readonly IntPtr NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0;

			// Token: 0x04009714 RID: 38676
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0;

			// Token: 0x02000DC1 RID: 3521
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass94_0+<<SendMessageChain>g__Routine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FE5F RID: 65119 RVA: 0x003C8800 File Offset: 0x003C6A00
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0>.NativeClassPtr, "<<SendMessageChain>g__Routine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "messageChain");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "initialDelay");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<messageClasses>5__2");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<i>5__3");
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669892);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669893);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669894);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669895);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669896);
					MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100669897);
				}

				// Token: 0x0600FE60 RID: 65120 RVA: 0x003C8930 File Offset: 0x003C6B30
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE61 RID: 65121 RVA: 0x003C8978 File Offset: 0x003C6B78
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE62 RID: 65122 RVA: 0x003C89AC File Offset: 0x003C6BAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138638, XrefRangeEnd = 138678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D67 RID: 19815
				// (get) Token: 0x0600FE63 RID: 65123 RVA: 0x003C89E8 File Offset: 0x003C6BE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE64 RID: 65124 RVA: 0x003C8A28 File Offset: 0x003C6C28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138678, XrefRangeEnd = 138683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D68 RID: 19816
				// (get) Token: 0x0600FE65 RID: 65125 RVA: 0x003C8A5C File Offset: 0x003C6C5C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE66 RID: 65126 RVA: 0x00078854 File Offset: 0x00076A54
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D60 RID: 19808
				// (get) Token: 0x0600FE67 RID: 65127 RVA: 0x003C8A9C File Offset: 0x003C6C9C
				// (set) Token: 0x0600FE68 RID: 65128 RVA: 0x0007885D File Offset: 0x00076A5D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D61 RID: 19809
				// (get) Token: 0x0600FE69 RID: 65129 RVA: 0x003C8AC4 File Offset: 0x003C6CC4
				// (set) Token: 0x0600FE6A RID: 65130 RVA: 0x00078878 File Offset: 0x00076A78
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D62 RID: 19810
				// (get) Token: 0x0600FE6B RID: 65131 RVA: 0x003C8AF4 File Offset: 0x003C6CF4
				// (set) Token: 0x0600FE6C RID: 65132 RVA: 0x00078897 File Offset: 0x00076A97
				public unsafe MSGConversation.__c__DisplayClass94_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D63 RID: 19811
				// (get) Token: 0x0600FE6D RID: 65133 RVA: 0x003C8B24 File Offset: 0x003C6D24
				// (set) Token: 0x0600FE6E RID: 65134 RVA: 0x000788B6 File Offset: 0x00076AB6
				public unsafe MessageChain messageChain
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D64 RID: 19812
				// (get) Token: 0x0600FE6F RID: 65135 RVA: 0x003C8B54 File Offset: 0x003C6D54
				// (set) Token: 0x0600FE70 RID: 65136 RVA: 0x000788D5 File Offset: 0x00076AD5
				public unsafe float initialDelay
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay)) = value;
					}
				}

				// Token: 0x17004D65 RID: 19813
				// (get) Token: 0x0600FE71 RID: 65137 RVA: 0x003C8B7C File Offset: 0x003C6D7C
				// (set) Token: 0x0600FE72 RID: 65138 RVA: 0x000788F0 File Offset: 0x00076AF0
				public unsafe List<Message> _messageClasses_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D66 RID: 19814
				// (get) Token: 0x0600FE73 RID: 65139 RVA: 0x003C8BAC File Offset: 0x003C6DAC
				// (set) Token: 0x0600FE74 RID: 65140 RVA: 0x0007890F File Offset: 0x00076B0F
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AB72 RID: 43890
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB73 RID: 43891
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB74 RID: 43892
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB75 RID: 43893
				private static readonly IntPtr NativeFieldInfoPtr_messageChain;

				// Token: 0x0400AB76 RID: 43894
				private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

				// Token: 0x0400AB77 RID: 43895
				private static readonly IntPtr NativeFieldInfoPtr__messageClasses_5__2;

				// Token: 0x0400AB78 RID: 43896
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AB79 RID: 43897
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB7A RID: 43898
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB7B RID: 43899
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB7C RID: 43900
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB7D RID: 43901
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB7E RID: 43902
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
