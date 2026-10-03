using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007BB RID: 1979
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x0600C18C RID: 49548 RVA: 0x00315954 File Offset: 0x00313B54
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesApp()
		{
			Il2CppClassPointerStore<MessagesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessagesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr);
			MessagesApp.NativeFieldInfoPtr_Conversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "Conversations");
			MessagesApp.NativeFieldInfoPtr_ActiveConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ActiveConversations");
			MessagesApp.NativeFieldInfoPtr_categoryInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "categoryInfos");
			MessagesApp.NativeFieldInfoPtr_conversationEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryContainer");
			MessagesApp.NativeFieldInfoPtr_conversationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainer");
			MessagesApp.NativeFieldInfoPtr_homePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "homePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePageNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePageNameText");
			MessagesApp.NativeFieldInfoPtr_relationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipContainer");
			MessagesApp.NativeFieldInfoPtr_relationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipScrollbar");
			MessagesApp.NativeFieldInfoPtr_relationshipTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipTooltip");
			MessagesApp.NativeFieldInfoPtr_debtContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "debtContainer");
			MessagesApp.NativeFieldInfoPtr_debtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "debtLabel");
			MessagesApp.NativeFieldInfoPtr_standardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsContainer");
			MessagesApp.NativeFieldInfoPtr_standardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsStar");
			MessagesApp.NativeFieldInfoPtr_standardsTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsTooltip");
			MessagesApp.NativeFieldInfoPtr_iconContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconContainerRect");
			MessagesApp.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconImage");
			MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "BlankAvatarSprite");
			MessagesApp.NativeFieldInfoPtr_DealWindowSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "DealWindowSelector");
			MessagesApp.NativeFieldInfoPtr_PhoneShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "PhoneShopInterface");
			MessagesApp.NativeFieldInfoPtr_CounterofferInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CounterofferInterface");
			MessagesApp.NativeFieldInfoPtr_ClearFilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ClearFilterButton");
			MessagesApp.NativeFieldInfoPtr_CategoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryButtons");
			MessagesApp.NativeFieldInfoPtr_MessageReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageReceivedSound");
			MessagesApp.NativeFieldInfoPtr_MessageSentSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageSentSound");
			MessagesApp.NativeFieldInfoPtr_ConfirmationPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ConfirmationPopup");
			MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryPrefab");
			MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainerPrefab");
			MessagesApp.NativeFieldInfoPtr_messageBubblePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "messageBubblePrefab");
			MessagesApp.NativeFieldInfoPtr_unreadConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "unreadConversations");
			MessagesApp.NativeFieldInfoPtr_mainMessagesUIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "mainMessagesUIScreen");
			MessagesApp.NativeFieldInfoPtr_mainMessagesUIPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "mainMessagesUIPanel");
			MessagesApp.NativeFieldInfoPtr_dialogueMainUIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialogueMainUIScreen");
			MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<currentConversation>k__BackingField");
			MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688478);
			MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688479);
			MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688480);
			MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688481);
			MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688482);
			MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688483);
			MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688484);
			MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688485);
			MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688486);
			MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688487);
			MessagesApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688488);
			MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688489);
			MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688490);
			MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688491);
			MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688492);
			MessagesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688493);
			MessagesApp.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688494);
			MessagesApp.NativeMethodInfoPtr_SelectMessageSelectable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688495);
			MessagesApp.NativeMethodInfoPtr_DelaySelectCurrentSelectedSelectable_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688496);
			MessagesApp.NativeMethodInfoPtr_DelaySelect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688497);
			MessagesApp.NativeMethodInfoPtr_SelectDialogueUIPanel_Public_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688498);
			MessagesApp.NativeMethodInfoPtr_DelaySelectDialogueUIPanel_Private_IEnumerator_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688499);
			MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100688500);
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600C18D RID: 49549 RVA: 0x00315E0C File Offset: 0x0031400C
		// (set) Token: 0x0600C18E RID: 49550 RVA: 0x00315E4C File Offset: 0x0031404C
		public unsafe MSGConversation currentConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x00315E90 File Offset: 0x00314090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321110, XrefRangeEnd = 321152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x00315ECC File Offset: 0x003140CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321152, XrefRangeEnd = 321172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x00315F08 File Offset: 0x00314108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321172, XrefRangeEnd = 321203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x00315F3C File Offset: 0x0031413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321203, XrefRangeEnd = 321211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x00315F70 File Offset: 0x00314170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321304, RefRangeEnd = 321305, XrefRangeStart = 321211, XrefRangeEnd = 321304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			entry = ((intPtr5 == 0) ? null : new RectTransform(intPtr5));
			IntPtr intPtr6 = intPtr2;
			container = ((intPtr6 == 0) ? null : new RectTransform(intPtr6));
		}

		// Token: 0x0600C194 RID: 49556 RVA: 0x00315FF8 File Offset: 0x003141F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321326, RefRangeEnd = 321329, XrefRangeStart = 321305, XrefRangeEnd = 321326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x0031602C File Offset: 0x0031422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321329, XrefRangeEnd = 321330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C196 RID: 49558 RVA: 0x00316060 File Offset: 0x00314260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321341, RefRangeEnd = 321342, XrefRangeStart = 321330, XrefRangeEnd = 321341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C197 RID: 49559 RVA: 0x00316094 File Offset: 0x00314294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321342, XrefRangeEnd = 321348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x003160E4 File Offset: 0x003142E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321350, RefRangeEnd = 321352, XrefRangeStart = 321348, XrefRangeEnd = 321350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentConversation(MSGConversation conversation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00316128 File Offset: 0x00314328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321352, XrefRangeEnd = 321366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessagesApp.CategoryInfo>(intPtr3) : null;
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x00316174 File Offset: 0x00314374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321366, XrefRangeEnd = 321391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterByCategory(int category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x003161B4 File Offset: 0x003143B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321391, XrefRangeEnd = 321410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x003161E8 File Offset: 0x003143E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321410, XrefRangeEnd = 321414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x00316234 File Offset: 0x00314434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321414, XrefRangeEnd = 321419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x00316270 File Offset: 0x00314470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321433, RefRangeEnd = 321435, XrefRangeStart = 321419, XrefRangeEnd = 321433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectMessageSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SelectMessageSelectable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x003162A4 File Offset: 0x003144A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321435, XrefRangeEnd = 321440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectCurrentSelectedSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_DelaySelectCurrentSelectedSelectable_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x003162E4 File Offset: 0x003144E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321440, XrefRangeEnd = 321445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_DelaySelect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x00316324 File Offset: 0x00314524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321445, XrefRangeEnd = 321452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectDialogueUIPanel(UIPanel uIPanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uIPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SelectDialogueUIPanel_Public_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1A2 RID: 49570 RVA: 0x00316368 File Offset: 0x00314568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321452, XrefRangeEnd = 321458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectDialogueUIPanel(UIPanel uIPanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uIPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_DelaySelectDialogueUIPanel_Private_IEnumerator_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x003163B8 File Offset: 0x003145B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321458, XrefRangeEnd = 321471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x0005AD47 File Offset: 0x00058F47
		public MessagesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x003163F4 File Offset: 0x003145F4
		// (set) Token: 0x0600C1A6 RID: 49574 RVA: 0x0005AD50 File Offset: 0x00058F50
		public unsafe static List<MSGConversation> Conversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_Conversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_Conversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x0031641C File Offset: 0x0031461C
		// (set) Token: 0x0600C1A8 RID: 49576 RVA: 0x0005AD62 File Offset: 0x00058F62
		public unsafe static List<MSGConversation> ActiveConversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600C1A9 RID: 49577 RVA: 0x00316444 File Offset: 0x00314644
		// (set) Token: 0x0600C1AA RID: 49578 RVA: 0x0005AD74 File Offset: 0x00058F74
		public unsafe List<MessagesApp.CategoryInfo> categoryInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessagesApp.CategoryInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x00316474 File Offset: 0x00314674
		// (set) Token: 0x0600C1AC RID: 49580 RVA: 0x0005AD93 File Offset: 0x00058F93
		public unsafe RectTransform conversationEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x003164A4 File Offset: 0x003146A4
		// (set) Token: 0x0600C1AE RID: 49582 RVA: 0x0005ADB2 File Offset: 0x00058FB2
		public unsafe RectTransform conversationContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600C1AF RID: 49583 RVA: 0x003164D4 File Offset: 0x003146D4
		// (set) Token: 0x0600C1B0 RID: 49584 RVA: 0x0005ADD1 File Offset: 0x00058FD1
		public unsafe GameObject homePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600C1B1 RID: 49585 RVA: 0x00316504 File Offset: 0x00314704
		// (set) Token: 0x0600C1B2 RID: 49586 RVA: 0x0005ADF0 File Offset: 0x00058FF0
		public unsafe GameObject dialoguePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600C1B3 RID: 49587 RVA: 0x00316534 File Offset: 0x00314734
		// (set) Token: 0x0600C1B4 RID: 49588 RVA: 0x0005AE0F File Offset: 0x0005900F
		public unsafe Text dialoguePageNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600C1B5 RID: 49589 RVA: 0x00316564 File Offset: 0x00314764
		// (set) Token: 0x0600C1B6 RID: 49590 RVA: 0x0005AE2E File Offset: 0x0005902E
		public unsafe RectTransform relationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600C1B7 RID: 49591 RVA: 0x00316594 File Offset: 0x00314794
		// (set) Token: 0x0600C1B8 RID: 49592 RVA: 0x0005AE4D File Offset: 0x0005904D
		public unsafe Scrollbar relationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x003165C4 File Offset: 0x003147C4
		// (set) Token: 0x0600C1BA RID: 49594 RVA: 0x0005AE6C File Offset: 0x0005906C
		public unsafe Tooltip relationshipTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600C1BB RID: 49595 RVA: 0x003165F4 File Offset: 0x003147F4
		// (set) Token: 0x0600C1BC RID: 49596 RVA: 0x0005AE8B File Offset: 0x0005908B
		public unsafe RectTransform debtContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_debtContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_debtContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600C1BD RID: 49597 RVA: 0x00316624 File Offset: 0x00314824
		// (set) Token: 0x0600C1BE RID: 49598 RVA: 0x0005AEAA File Offset: 0x000590AA
		public unsafe Text debtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_debtLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_debtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600C1BF RID: 49599 RVA: 0x00316654 File Offset: 0x00314854
		// (set) Token: 0x0600C1C0 RID: 49600 RVA: 0x0005AEC9 File Offset: 0x000590C9
		public unsafe RectTransform standardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600C1C1 RID: 49601 RVA: 0x00316684 File Offset: 0x00314884
		// (set) Token: 0x0600C1C2 RID: 49602 RVA: 0x0005AEE8 File Offset: 0x000590E8
		public unsafe Image standardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600C1C3 RID: 49603 RVA: 0x003166B4 File Offset: 0x003148B4
		// (set) Token: 0x0600C1C4 RID: 49604 RVA: 0x0005AF07 File Offset: 0x00059107
		public unsafe Tooltip standardsTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x003166E4 File Offset: 0x003148E4
		// (set) Token: 0x0600C1C6 RID: 49606 RVA: 0x0005AF26 File Offset: 0x00059126
		public unsafe RectTransform iconContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600C1C7 RID: 49607 RVA: 0x00316714 File Offset: 0x00314914
		// (set) Token: 0x0600C1C8 RID: 49608 RVA: 0x0005AF45 File Offset: 0x00059145
		public unsafe Image iconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600C1C9 RID: 49609 RVA: 0x00316744 File Offset: 0x00314944
		// (set) Token: 0x0600C1CA RID: 49610 RVA: 0x0005AF64 File Offset: 0x00059164
		public unsafe Sprite BlankAvatarSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600C1CB RID: 49611 RVA: 0x00316774 File Offset: 0x00314974
		// (set) Token: 0x0600C1CC RID: 49612 RVA: 0x0005AF83 File Offset: 0x00059183
		public unsafe DealWindowSelector DealWindowSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0600C1CD RID: 49613 RVA: 0x003167A4 File Offset: 0x003149A4
		// (set) Token: 0x0600C1CE RID: 49614 RVA: 0x0005AFA2 File Offset: 0x000591A2
		public unsafe PhoneShopInterface PhoneShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x003167D4 File Offset: 0x003149D4
		// (set) Token: 0x0600C1D0 RID: 49616 RVA: 0x0005AFC1 File Offset: 0x000591C1
		public unsafe CounterofferInterface CounterofferInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterofferInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x00316804 File Offset: 0x00314A04
		// (set) Token: 0x0600C1D2 RID: 49618 RVA: 0x0005AFE0 File Offset: 0x000591E0
		public unsafe RectTransform ClearFilterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x00316834 File Offset: 0x00314A34
		// (set) Token: 0x0600C1D4 RID: 49620 RVA: 0x0005AFFF File Offset: 0x000591FF
		public unsafe Il2CppReferenceArray<Button> CategoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600C1D5 RID: 49621 RVA: 0x00316864 File Offset: 0x00314A64
		// (set) Token: 0x0600C1D6 RID: 49622 RVA: 0x0005B01E File Offset: 0x0005921E
		public unsafe AudioSourceController MessageReceivedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600C1D7 RID: 49623 RVA: 0x00316894 File Offset: 0x00314A94
		// (set) Token: 0x0600C1D8 RID: 49624 RVA: 0x0005B03D File Offset: 0x0005923D
		public unsafe AudioSourceController MessageSentSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600C1D9 RID: 49625 RVA: 0x003168C4 File Offset: 0x00314AC4
		// (set) Token: 0x0600C1DA RID: 49626 RVA: 0x0005B05C File Offset: 0x0005925C
		public unsafe ConfirmationPopup ConfirmationPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ConfirmationPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmationPopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ConfirmationPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600C1DB RID: 49627 RVA: 0x003168F4 File Offset: 0x00314AF4
		// (set) Token: 0x0600C1DC RID: 49628 RVA: 0x0005B07B File Offset: 0x0005927B
		public unsafe GameObject conversationEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600C1DD RID: 49629 RVA: 0x00316924 File Offset: 0x00314B24
		// (set) Token: 0x0600C1DE RID: 49630 RVA: 0x0005B09A File Offset: 0x0005929A
		public unsafe GameObject conversationContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600C1DF RID: 49631 RVA: 0x00316954 File Offset: 0x00314B54
		// (set) Token: 0x0600C1E0 RID: 49632 RVA: 0x0005B0B9 File Offset: 0x000592B9
		public unsafe GameObject messageBubblePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x00316984 File Offset: 0x00314B84
		// (set) Token: 0x0600C1E2 RID: 49634 RVA: 0x0005B0D8 File Offset: 0x000592D8
		public unsafe List<MSGConversation> unreadConversations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600C1E3 RID: 49635 RVA: 0x003169B4 File Offset: 0x00314BB4
		// (set) Token: 0x0600C1E4 RID: 49636 RVA: 0x0005B0F7 File Offset: 0x000592F7
		public unsafe UIScreen mainMessagesUIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_mainMessagesUIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_mainMessagesUIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600C1E5 RID: 49637 RVA: 0x003169E4 File Offset: 0x00314BE4
		// (set) Token: 0x0600C1E6 RID: 49638 RVA: 0x0005B116 File Offset: 0x00059316
		public unsafe UIPanel mainMessagesUIPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_mainMessagesUIPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_mainMessagesUIPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600C1E7 RID: 49639 RVA: 0x00316A14 File Offset: 0x00314C14
		// (set) Token: 0x0600C1E8 RID: 49640 RVA: 0x0005B135 File Offset: 0x00059335
		public unsafe UIScreen dialogueMainUIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialogueMainUIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialogueMainUIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600C1E9 RID: 49641 RVA: 0x00316A44 File Offset: 0x00314C44
		// (set) Token: 0x0600C1EA RID: 49642 RVA: 0x0005B154 File Offset: 0x00059354
		public unsafe MSGConversation _currentConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400845F RID: 33887
		private static readonly IntPtr NativeFieldInfoPtr_Conversations;

		// Token: 0x04008460 RID: 33888
		private static readonly IntPtr NativeFieldInfoPtr_ActiveConversations;

		// Token: 0x04008461 RID: 33889
		private static readonly IntPtr NativeFieldInfoPtr_categoryInfos;

		// Token: 0x04008462 RID: 33890
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryContainer;

		// Token: 0x04008463 RID: 33891
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainer;

		// Token: 0x04008464 RID: 33892
		private static readonly IntPtr NativeFieldInfoPtr_homePage;

		// Token: 0x04008465 RID: 33893
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePage;

		// Token: 0x04008466 RID: 33894
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePageNameText;

		// Token: 0x04008467 RID: 33895
		private static readonly IntPtr NativeFieldInfoPtr_relationshipContainer;

		// Token: 0x04008468 RID: 33896
		private static readonly IntPtr NativeFieldInfoPtr_relationshipScrollbar;

		// Token: 0x04008469 RID: 33897
		private static readonly IntPtr NativeFieldInfoPtr_relationshipTooltip;

		// Token: 0x0400846A RID: 33898
		private static readonly IntPtr NativeFieldInfoPtr_debtContainer;

		// Token: 0x0400846B RID: 33899
		private static readonly IntPtr NativeFieldInfoPtr_debtLabel;

		// Token: 0x0400846C RID: 33900
		private static readonly IntPtr NativeFieldInfoPtr_standardsContainer;

		// Token: 0x0400846D RID: 33901
		private static readonly IntPtr NativeFieldInfoPtr_standardsStar;

		// Token: 0x0400846E RID: 33902
		private static readonly IntPtr NativeFieldInfoPtr_standardsTooltip;

		// Token: 0x0400846F RID: 33903
		private static readonly IntPtr NativeFieldInfoPtr_iconContainerRect;

		// Token: 0x04008470 RID: 33904
		private static readonly IntPtr NativeFieldInfoPtr_iconImage;

		// Token: 0x04008471 RID: 33905
		private static readonly IntPtr NativeFieldInfoPtr_BlankAvatarSprite;

		// Token: 0x04008472 RID: 33906
		private static readonly IntPtr NativeFieldInfoPtr_DealWindowSelector;

		// Token: 0x04008473 RID: 33907
		private static readonly IntPtr NativeFieldInfoPtr_PhoneShopInterface;

		// Token: 0x04008474 RID: 33908
		private static readonly IntPtr NativeFieldInfoPtr_CounterofferInterface;

		// Token: 0x04008475 RID: 33909
		private static readonly IntPtr NativeFieldInfoPtr_ClearFilterButton;

		// Token: 0x04008476 RID: 33910
		private static readonly IntPtr NativeFieldInfoPtr_CategoryButtons;

		// Token: 0x04008477 RID: 33911
		private static readonly IntPtr NativeFieldInfoPtr_MessageReceivedSound;

		// Token: 0x04008478 RID: 33912
		private static readonly IntPtr NativeFieldInfoPtr_MessageSentSound;

		// Token: 0x04008479 RID: 33913
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmationPopup;

		// Token: 0x0400847A RID: 33914
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryPrefab;

		// Token: 0x0400847B RID: 33915
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainerPrefab;

		// Token: 0x0400847C RID: 33916
		private static readonly IntPtr NativeFieldInfoPtr_messageBubblePrefab;

		// Token: 0x0400847D RID: 33917
		private static readonly IntPtr NativeFieldInfoPtr_unreadConversations;

		// Token: 0x0400847E RID: 33918
		private static readonly IntPtr NativeFieldInfoPtr_mainMessagesUIScreen;

		// Token: 0x0400847F RID: 33919
		private static readonly IntPtr NativeFieldInfoPtr_mainMessagesUIPanel;

		// Token: 0x04008480 RID: 33920
		private static readonly IntPtr NativeFieldInfoPtr_dialogueMainUIScreen;

		// Token: 0x04008481 RID: 33921
		private static readonly IntPtr NativeFieldInfoPtr__currentConversation_k__BackingField;

		// Token: 0x04008482 RID: 33922
		private static readonly IntPtr NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0;

		// Token: 0x04008483 RID: 33923
		private static readonly IntPtr NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0;

		// Token: 0x04008484 RID: 33924
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04008485 RID: 33925
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04008486 RID: 33926
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04008487 RID: 33927
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04008488 RID: 33928
		private static readonly IntPtr NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0;

		// Token: 0x04008489 RID: 33929
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntries_Public_Void_0;

		// Token: 0x0400848A RID: 33930
		private static readonly IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x0400848B RID: 33931
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotifications_Public_Void_0;

		// Token: 0x0400848C RID: 33932
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x0400848D RID: 33933
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0;

		// Token: 0x0400848E RID: 33934
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0;

		// Token: 0x0400848F RID: 33935
		private static readonly IntPtr NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0;

		// Token: 0x04008490 RID: 33936
		private static readonly IntPtr NativeMethodInfoPtr_ClearFilter_Public_Void_0;

		// Token: 0x04008491 RID: 33937
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04008492 RID: 33938
		private static readonly IntPtr NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_Void_0;

		// Token: 0x04008493 RID: 33939
		private static readonly IntPtr NativeMethodInfoPtr_SelectMessageSelectable_Private_Void_0;

		// Token: 0x04008494 RID: 33940
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectCurrentSelectedSelectable_Private_IEnumerator_0;

		// Token: 0x04008495 RID: 33941
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelect_Private_IEnumerator_0;

		// Token: 0x04008496 RID: 33942
		private static readonly IntPtr NativeMethodInfoPtr_SelectDialogueUIPanel_Public_Void_UIPanel_0;

		// Token: 0x04008497 RID: 33943
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectDialogueUIPanel_Private_IEnumerator_UIPanel_0;

		// Token: 0x04008498 RID: 33944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D44 RID: 3396
		[Serializable]
		public class CategoryInfo : Il2CppSystem.Object
		{
			// Token: 0x0600F9C7 RID: 63943 RVA: 0x003BBAF4 File Offset: 0x003B9CF4
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInfo()
			{
				Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr);
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Category");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Name");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Color");
				MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, 100688502);
			}

			// Token: 0x0600F9C8 RID: 63944 RVA: 0x003BBB70 File Offset: 0x003B9D70
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9C9 RID: 63945 RVA: 0x0007625A File Offset: 0x0007445A
			public CategoryInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BEE RID: 19438
			// (get) Token: 0x0600F9CA RID: 63946 RVA: 0x003BBBAC File Offset: 0x003B9DAC
			// (set) Token: 0x0600F9CB RID: 63947 RVA: 0x00076263 File Offset: 0x00074463
			public unsafe EConversationCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x17004BEF RID: 19439
			// (get) Token: 0x0600F9CC RID: 63948 RVA: 0x003BBBD4 File Offset: 0x003B9DD4
			// (set) Token: 0x0600F9CD RID: 63949 RVA: 0x0007627E File Offset: 0x0007447E
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BF0 RID: 19440
			// (get) Token: 0x0600F9CE RID: 63950 RVA: 0x003BBBFC File Offset: 0x003B9DFC
			// (set) Token: 0x0600F9CF RID: 63951 RVA: 0x0007629D File Offset: 0x0007449D
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x0400A8AE RID: 43182
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x0400A8AF RID: 43183
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x0400A8B0 RID: 43184
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x0400A8B1 RID: 43185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D45 RID: 3397
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F9D0 RID: 63952 RVA: 0x003BBC24 File Offset: 0x003B9E24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr);
				MessagesApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9");
				MessagesApp.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9__41_0");
				MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100688504);
				MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__41_0_Internal_Int32_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100688505);
			}

			// Token: 0x0600F9D1 RID: 63953 RVA: 0x003BBCA0 File Offset: 0x003B9EA0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9D2 RID: 63954 RVA: 0x003BBCDC File Offset: 0x003B9EDC
			[CallerCount(0)]
			public unsafe int _Loaded_b__41_0(MSGConversation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__41_0_Internal_Int32_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F9D3 RID: 63955 RVA: 0x000762B8 File Offset: 0x000744B8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BF1 RID: 19441
			// (get) Token: 0x0600F9D4 RID: 63956 RVA: 0x003BBD2C File Offset: 0x003B9F2C
			// (set) Token: 0x0600F9D5 RID: 63957 RVA: 0x000762C1 File Offset: 0x000744C1
			public unsafe static MessagesApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BF2 RID: 19442
			// (get) Token: 0x0600F9D6 RID: 63958 RVA: 0x003BBD54 File Offset: 0x003B9F54
			// (set) Token: 0x0600F9D7 RID: 63959 RVA: 0x000762D3 File Offset: 0x000744D3
			public unsafe static Func<MSGConversation, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MSGConversation, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8B2 RID: 43186
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A8B3 RID: 43187
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400A8B4 RID: 43188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8B5 RID: 43189
			private static readonly IntPtr NativeMethodInfoPtr__Loaded_b__41_0_Internal_Int32_MSGConversation_0;
		}

		// Token: 0x02000D46 RID: 3398
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F9D8 RID: 63960 RVA: 0x003BBD7C File Offset: 0x003B9F7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr);
				MessagesApp.__c__DisplayClass49_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr, "category");
				MessagesApp.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr, 100688506);
				MessagesApp.__c__DisplayClass49_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr, 100688507);
			}

			// Token: 0x0600F9D9 RID: 63961 RVA: 0x003BBDE4 File Offset: 0x003B9FE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9DA RID: 63962 RVA: 0x003BBE20 File Offset: 0x003BA020
			[CallerCount(0)]
			public unsafe bool _GetCategoryInfo_b__0(MessagesApp.CategoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass49_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F9DB RID: 63963 RVA: 0x000762E5 File Offset: 0x000744E5
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BF3 RID: 19443
			// (get) Token: 0x0600F9DC RID: 63964 RVA: 0x003BBE70 File Offset: 0x003BA070
			// (set) Token: 0x0600F9DD RID: 63965 RVA: 0x000762EE File Offset: 0x000744EE
			public unsafe EConversationCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass49_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass49_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x0400A8B6 RID: 43190
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400A8B7 RID: 43191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8B8 RID: 43192
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0;
		}

		// Token: 0x02000D47 RID: 3399
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<DelaySelect>d__56")]
		public sealed class _DelaySelect_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600F9DE RID: 63966 RVA: 0x003BBE98 File Offset: 0x003BA098
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelect_d__56()
			{
				Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<DelaySelect>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr);
				MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, "<>1__state");
				MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, "<>2__current");
				MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, "<>4__this");
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688508);
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688509);
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688510);
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688511);
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688512);
				MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr, 100688513);
			}

			// Token: 0x0600F9DF RID: 63967 RVA: 0x003BBF78 File Offset: 0x003BA178
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelect_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp._DelaySelect_d__56>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9E0 RID: 63968 RVA: 0x003BBFC0 File Offset: 0x003BA1C0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9E1 RID: 63969 RVA: 0x003BBFF4 File Offset: 0x003BA1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321060, XrefRangeEnd = 321093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BF7 RID: 19447
			// (get) Token: 0x0600F9E2 RID: 63970 RVA: 0x003BC030 File Offset: 0x003BA230
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9E3 RID: 63971 RVA: 0x003BC070 File Offset: 0x003BA270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321093, XrefRangeEnd = 321098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BF8 RID: 19448
			// (get) Token: 0x0600F9E4 RID: 63972 RVA: 0x003BC0A4 File Offset: 0x003BA2A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelect_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9E5 RID: 63973 RVA: 0x00076309 File Offset: 0x00074509
			public _DelaySelect_d__56(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BF4 RID: 19444
			// (get) Token: 0x0600F9E6 RID: 63974 RVA: 0x003BC0E4 File Offset: 0x003BA2E4
			// (set) Token: 0x0600F9E7 RID: 63975 RVA: 0x00076312 File Offset: 0x00074512
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BF5 RID: 19445
			// (get) Token: 0x0600F9E8 RID: 63976 RVA: 0x003BC10C File Offset: 0x003BA30C
			// (set) Token: 0x0600F9E9 RID: 63977 RVA: 0x0007632D File Offset: 0x0007452D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BF6 RID: 19446
			// (get) Token: 0x0600F9EA RID: 63978 RVA: 0x003BC13C File Offset: 0x003BA33C
			// (set) Token: 0x0600F9EB RID: 63979 RVA: 0x0007634C File Offset: 0x0007454C
			public unsafe MessagesApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelect_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8B9 RID: 43193
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A8BA RID: 43194
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A8BB RID: 43195
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8BC RID: 43196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A8BD RID: 43197
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8BE RID: 43198
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A8BF RID: 43199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A8C0 RID: 43200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8C1 RID: 43201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D48 RID: 3400
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<DelaySelectCurrentSelectedSelectable>d__55")]
		public sealed class _DelaySelectCurrentSelectedSelectable_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600F9EC RID: 63980 RVA: 0x003BC16C File Offset: 0x003BA36C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectCurrentSelectedSelectable_d__55()
			{
				Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<DelaySelectCurrentSelectedSelectable>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, "<>1__state");
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, "<>2__current");
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, "<>4__this");
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688514);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688515);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688516);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688517);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688518);
				MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr, 100688519);
			}

			// Token: 0x0600F9ED RID: 63981 RVA: 0x003BC24C File Offset: 0x003BA44C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectCurrentSelectedSelectable_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp._DelaySelectCurrentSelectedSelectable_d__55>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9EE RID: 63982 RVA: 0x003BC294 File Offset: 0x003BA494
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9EF RID: 63983 RVA: 0x003BC2C8 File Offset: 0x003BA4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321098, XrefRangeEnd = 321099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BFC RID: 19452
			// (get) Token: 0x0600F9F0 RID: 63984 RVA: 0x003BC304 File Offset: 0x003BA504
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9F1 RID: 63985 RVA: 0x003BC344 File Offset: 0x003BA544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321099, XrefRangeEnd = 321104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BFD RID: 19453
			// (get) Token: 0x0600F9F2 RID: 63986 RVA: 0x003BC378 File Offset: 0x003BA578
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9F3 RID: 63987 RVA: 0x0007636B File Offset: 0x0007456B
			public _DelaySelectCurrentSelectedSelectable_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BF9 RID: 19449
			// (get) Token: 0x0600F9F4 RID: 63988 RVA: 0x003BC3B8 File Offset: 0x003BA5B8
			// (set) Token: 0x0600F9F5 RID: 63989 RVA: 0x00076374 File Offset: 0x00074574
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BFA RID: 19450
			// (get) Token: 0x0600F9F6 RID: 63990 RVA: 0x003BC3E0 File Offset: 0x003BA5E0
			// (set) Token: 0x0600F9F7 RID: 63991 RVA: 0x0007638F File Offset: 0x0007458F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BFB RID: 19451
			// (get) Token: 0x0600F9F8 RID: 63992 RVA: 0x003BC410 File Offset: 0x003BA610
			// (set) Token: 0x0600F9F9 RID: 63993 RVA: 0x000763AE File Offset: 0x000745AE
			public unsafe MessagesApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectCurrentSelectedSelectable_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8C2 RID: 43202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A8C3 RID: 43203
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A8C4 RID: 43204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8C5 RID: 43205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A8C6 RID: 43206
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8C7 RID: 43207
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A8C8 RID: 43208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A8C9 RID: 43209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8CA RID: 43210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D49 RID: 3401
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<DelaySelectDialogueUIPanel>d__58")]
		public sealed class _DelaySelectDialogueUIPanel_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600F9FA RID: 63994 RVA: 0x003BC440 File Offset: 0x003BA640
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectDialogueUIPanel_d__58()
			{
				Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<DelaySelectDialogueUIPanel>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, "<>1__state");
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, "<>2__current");
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, "<>4__this");
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr_uIPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, "uIPanel");
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688520);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688521);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688522);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688523);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688524);
				MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr, 100688525);
			}

			// Token: 0x0600F9FB RID: 63995 RVA: 0x003BC534 File Offset: 0x003BA734
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectDialogueUIPanel_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp._DelaySelectDialogueUIPanel_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9FC RID: 63996 RVA: 0x003BC57C File Offset: 0x003BA77C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9FD RID: 63997 RVA: 0x003BC5B0 File Offset: 0x003BA7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321104, XrefRangeEnd = 321105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C02 RID: 19458
			// (get) Token: 0x0600F9FE RID: 63998 RVA: 0x003BC5EC File Offset: 0x003BA7EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9FF RID: 63999 RVA: 0x003BC62C File Offset: 0x003BA82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321105, XrefRangeEnd = 321110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C03 RID: 19459
			// (get) Token: 0x0600FA00 RID: 64000 RVA: 0x003BC660 File Offset: 0x003BA860
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FA01 RID: 64001 RVA: 0x000763CD File Offset: 0x000745CD
			public _DelaySelectDialogueUIPanel_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BFE RID: 19454
			// (get) Token: 0x0600FA02 RID: 64002 RVA: 0x003BC6A0 File Offset: 0x003BA8A0
			// (set) Token: 0x0600FA03 RID: 64003 RVA: 0x000763D6 File Offset: 0x000745D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BFF RID: 19455
			// (get) Token: 0x0600FA04 RID: 64004 RVA: 0x003BC6C8 File Offset: 0x003BA8C8
			// (set) Token: 0x0600FA05 RID: 64005 RVA: 0x000763F1 File Offset: 0x000745F1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C00 RID: 19456
			// (get) Token: 0x0600FA06 RID: 64006 RVA: 0x003BC6F8 File Offset: 0x003BA8F8
			// (set) Token: 0x0600FA07 RID: 64007 RVA: 0x00076410 File Offset: 0x00074610
			public unsafe MessagesApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C01 RID: 19457
			// (get) Token: 0x0600FA08 RID: 64008 RVA: 0x003BC728 File Offset: 0x003BA928
			// (set) Token: 0x0600FA09 RID: 64009 RVA: 0x0007642F File Offset: 0x0007462F
			public unsafe UIPanel uIPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr_uIPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp._DelaySelectDialogueUIPanel_d__58.NativeFieldInfoPtr_uIPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8CB RID: 43211
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A8CC RID: 43212
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A8CD RID: 43213
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8CE RID: 43214
			private static readonly IntPtr NativeFieldInfoPtr_uIPanel;

			// Token: 0x0400A8CF RID: 43215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A8D0 RID: 43216
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8D1 RID: 43217
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A8D2 RID: 43218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A8D3 RID: 43219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8D4 RID: 43220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
