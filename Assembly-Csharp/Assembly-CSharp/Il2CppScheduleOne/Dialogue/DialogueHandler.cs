using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Framework;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C9 RID: 969
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x06005733 RID: 22323 RVA: 0x001A93A8 File Offset: 0x001A75A8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler()
		{
			Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr);
			DialogueHandler.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TimePerChar");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMinDuration");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMaxDuration");
			DialogueHandler.NativeFieldInfoPtr__ActiveDialogue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<ActiveDialogue>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr__ActiveDialogueNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<ActiveDialogueNode>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr__IsDialogueInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<IsDialogueInProgress>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr__Database_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<Database>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr__RuntimeModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<RuntimeModules>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_OnDialogueEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "OnDialogueEnd");
			DialogueHandler.NativeFieldInfoPtr_LookPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "LookPosition");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceRend");
			DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<NPC>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_CurrentChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "CurrentChoices");
			DialogueHandler.NativeFieldInfoPtr_DialogueEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "DialogueEvents");
			DialogueHandler.NativeFieldInfoPtr_onConversationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onConversationStart");
			DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueNodeDisplayed");
			DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueChoiceChosen");
			DialogueHandler.NativeFieldInfoPtr_dialogueContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "dialogueContainers");
			DialogueHandler.NativeFieldInfoPtr_tempLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "tempLinks");
			DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "skipNextDialogueBehaviourEnd");
			DialogueHandler.NativeFieldInfoPtr_finalChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "finalChoices");
			DialogueHandler.NativeFieldInfoPtr_passChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "passChecked");
			DialogueHandler.NativeMethodInfoPtr_get_ActiveDialogue_Public_Static_get_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674740);
			DialogueHandler.NativeMethodInfoPtr_set_ActiveDialogue_Private_Static_set_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674741);
			DialogueHandler.NativeMethodInfoPtr_get_ActiveDialogueNode_Public_Static_get_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674742);
			DialogueHandler.NativeMethodInfoPtr_set_ActiveDialogueNode_Private_Static_set_Void_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674743);
			DialogueHandler.NativeMethodInfoPtr_get_IsDialogueInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674744);
			DialogueHandler.NativeMethodInfoPtr_set_IsDialogueInProgress_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674745);
			DialogueHandler.NativeMethodInfoPtr_get_Database_Public_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674746);
			DialogueHandler.NativeMethodInfoPtr_set_Database_Protected_set_Void_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674747);
			DialogueHandler.NativeMethodInfoPtr_get_RuntimeModules_Public_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674748);
			DialogueHandler.NativeMethodInfoPtr_set_RuntimeModules_Private_set_Void_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674749);
			DialogueHandler.NativeMethodInfoPtr_add_OnDialogueEnd_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674750);
			DialogueHandler.NativeMethodInfoPtr_remove_OnDialogueEnd_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674751);
			DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674752);
			DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674753);
			DialogueHandler.NativeMethodInfoPtr_get_canvas_Protected_get_DialogueCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674754);
			DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674755);
			DialogueHandler.NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674756);
			DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674757);
			DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674758);
			DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674759);
			DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674760);
			DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674761);
			DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674762);
			DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674763);
			DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674764);
			DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674765);
			DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674766);
			DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674767);
			DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674768);
			DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674769);
			DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674770);
			DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674771);
			DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674772);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674773);
			DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674774);
			DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674775);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674776);
			DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674777);
			DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674778);
			DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674779);
			DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674780);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674781);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674782);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674783);
			DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674784);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674785);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674786);
			DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100674787);
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x001A9950 File Offset: 0x001A7B50
		// (set) Token: 0x06005735 RID: 22325 RVA: 0x001A9984 File Offset: 0x001A7B84
		public unsafe static DialogueContainer ActiveDialogue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191791, XrefRangeEnd = 191793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_ActiveDialogue_Public_Static_get_DialogueContainer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191793, XrefRangeEnd = 191797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_ActiveDialogue_Private_Static_set_Void_DialogueContainer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06005736 RID: 22326 RVA: 0x001A99BC File Offset: 0x001A7BBC
		// (set) Token: 0x06005737 RID: 22327 RVA: 0x001A99F0 File Offset: 0x001A7BF0
		public unsafe static DialogueNodeData ActiveDialogueNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191797, XrefRangeEnd = 191799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_ActiveDialogueNode_Public_Static_get_DialogueNodeData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191799, XrefRangeEnd = 191803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_ActiveDialogueNode_Private_Static_set_Void_DialogueNodeData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06005738 RID: 22328 RVA: 0x001A9A28 File Offset: 0x001A7C28
		// (set) Token: 0x06005739 RID: 22329 RVA: 0x001A9A64 File Offset: 0x001A7C64
		public unsafe bool IsDialogueInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_IsDialogueInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_IsDialogueInProgress_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x0600573A RID: 22330 RVA: 0x001A9AA4 File Offset: 0x001A7CA4
		// (set) Token: 0x0600573B RID: 22331 RVA: 0x001A9AE4 File Offset: 0x001A7CE4
		public unsafe DialogueDatabase Database
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_Database_Public_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_Database_Protected_set_Void_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x0600573C RID: 22332 RVA: 0x001A9B28 File Offset: 0x001A7D28
		// (set) Token: 0x0600573D RID: 22333 RVA: 0x001A9B68 File Offset: 0x001A7D68
		public unsafe List<DialogueModule> RuntimeModules
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_RuntimeModules_Public_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_RuntimeModules_Private_set_Void_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x001A9BAC File Offset: 0x001A7DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191807, RefRangeEnd = 191808, XrefRangeStart = 191803, XrefRangeEnd = 191807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDialogueEnd(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_add_OnDialogueEnd_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x001A9BF0 File Offset: 0x001A7DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191812, RefRangeEnd = 191814, XrefRangeStart = 191808, XrefRangeEnd = 191812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDialogueEnd(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_remove_OnDialogueEnd_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06005740 RID: 22336 RVA: 0x001A9C34 File Offset: 0x001A7E34
		// (set) Token: 0x06005741 RID: 22337 RVA: 0x001A9C74 File Offset: 0x001A7E74
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x001A9CB8 File Offset: 0x001A7EB8
		public unsafe DialogueCanvas canvas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191814, XrefRangeEnd = 191817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_canvas_Protected_get_DialogueCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr3) : null;
			}
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x001A9CF8 File Offset: 0x001A7EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191817, XrefRangeEnd = 191825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x001A9D34 File Offset: 0x001A7F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191871, RefRangeEnd = 191872, XrefRangeStart = 191825, XrefRangeEnd = 191871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(NPCData npcData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x001A9D78 File Offset: 0x001A7F78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191875, RefRangeEnd = 191877, XrefRangeStart = 191872, XrefRangeEnd = 191875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x001A9DBC File Offset: 0x001A7FBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191918, RefRangeEnd = 191921, XrefRangeStart = 191877, XrefRangeEnd = 191918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogueContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x001A9E20 File Offset: 0x001A8020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191943, RefRangeEnd = 191944, XrefRangeStart = 191921, XrefRangeEnd = 191943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueContainerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StartDialogue_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x001A9E84 File Offset: 0x001A8084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191944, XrefRangeEnd = 191950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideShownDialogue(string _overrideText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_overrideText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x001A9EC8 File Offset: 0x001A80C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191950, XrefRangeEnd = 191956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x001A9EFC File Offset: 0x001A80FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191956, XrefRangeEnd = 191974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x001A9F38 File Offset: 0x001A8138
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191974, RefRangeEnd = 191979, XrefRangeStart = 191974, XrefRangeEnd = 191974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipNextDialogueBehaviourEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x001A9F6C File Offset: 0x001A816C
		[CallerCount(0)]
		public unsafe virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x001A9FC8 File Offset: 0x001A81C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192033, RefRangeEnd = 192039, XrefRangeStart = 191979, XrefRangeEnd = 192033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowNode(DialogueNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x001AA00C File Offset: 0x001A820C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192063, RefRangeEnd = 192065, XrefRangeStart = 192039, XrefRangeEnd = 192063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateBranch(BranchNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x001AA050 File Offset: 0x001A8250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192083, RefRangeEnd = 192084, XrefRangeStart = 192065, XrefRangeEnd = 192083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x001AA090 File Offset: 0x001A8290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192089, RefRangeEnd = 192090, XrefRangeStart = 192084, XrefRangeEnd = 192089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueSubmitted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x001AA0C4 File Offset: 0x001A82C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192090, XrefRangeEnd = 192097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x001AA138 File Offset: 0x001A8338
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x001AA190 File Offset: 0x001A8390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192097, XrefRangeEnd = 192115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x001AA1E8 File Offset: 0x001A83E8
		[CallerCount(0)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x001AA250 File Offset: 0x001A8450
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x001AA2B8 File Offset: 0x001A84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192115, XrefRangeEnd = 192118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x001AA308 File Offset: 0x001A8508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192131, RefRangeEnd = 192132, XrefRangeStart = 192118, XrefRangeEnd = 192131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DialogueCallback(string dialogueLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x001AA358 File Offset: 0x001A8558
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x001AA3CC File Offset: 0x001A85CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192132, XrefRangeEnd = 192145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseNodeGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseOptionGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x001AA434 File Offset: 0x001A8634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192162, RefRangeEnd = 192165, XrefRangeStart = 192145, XrefRangeEnd = 192162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x001AA484 File Offset: 0x001A8684
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x001AA4C0 File Offset: 0x001A86C0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x001AA4FC File Offset: 0x001A86FC
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Local(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x001AA54C File Offset: 0x001A874C
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Networked(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x001AA59C File Offset: 0x001A879C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192165, XrefRangeEnd = 192171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayReaction(string key, float duration, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x001AA608 File Offset: 0x001A8808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192171, XrefRangeEnd = 192173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideWorldspaceDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x001AA644 File Offset: 0x001A8844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192173, XrefRangeEnd = 192175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowWorldspaceDialogue(string text, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x001AA6A0 File Offset: 0x001A88A0
		[CallerCount(0)]
		public unsafe virtual void ShowWorldspaceDialogue_5s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x001AA6F0 File Offset: 0x001A88F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192209, RefRangeEnd = 192212, XrefRangeStart = 192175, XrefRangeEnd = 192209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x00029312 File Offset: 0x00027512
		public DialogueHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x001AA72C File Offset: 0x001A892C
		// (set) Token: 0x06005766 RID: 22374 RVA: 0x0002931B File Offset: 0x0002751B
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06005767 RID: 22375 RVA: 0x001AA748 File Offset: 0x001A8948
		// (set) Token: 0x06005768 RID: 22376 RVA: 0x00029329 File Offset: 0x00027529
		public unsafe static float WorldspaceDialogueMinDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&value));
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06005769 RID: 22377 RVA: 0x001AA764 File Offset: 0x001A8964
		// (set) Token: 0x0600576A RID: 22378 RVA: 0x00029337 File Offset: 0x00027537
		public unsafe static float WorldspaceDialogueMaxDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&value));
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x001AA780 File Offset: 0x001A8980
		// (set) Token: 0x0600576C RID: 22380 RVA: 0x00029345 File Offset: 0x00027545
		public unsafe static DialogueContainer _ActiveDialogue_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr__ActiveDialogue_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr__ActiveDialogue_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x001AA7A8 File Offset: 0x001A89A8
		// (set) Token: 0x0600576E RID: 22382 RVA: 0x00029357 File Offset: 0x00027557
		public unsafe static DialogueNodeData _ActiveDialogueNode_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr__ActiveDialogueNode_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr__ActiveDialogueNode_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600576F RID: 22383 RVA: 0x001AA7D0 File Offset: 0x001A89D0
		// (set) Token: 0x06005770 RID: 22384 RVA: 0x00029369 File Offset: 0x00027569
		public unsafe bool _IsDialogueInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsDialogueInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsDialogueInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x001AA7F8 File Offset: 0x001A89F8
		// (set) Token: 0x06005772 RID: 22386 RVA: 0x00029384 File Offset: 0x00027584
		public unsafe DialogueDatabase _Database_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__Database_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__Database_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06005773 RID: 22387 RVA: 0x001AA828 File Offset: 0x001A8A28
		// (set) Token: 0x06005774 RID: 22388 RVA: 0x000293A3 File Offset: 0x000275A3
		public unsafe List<DialogueModule> _RuntimeModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__RuntimeModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__RuntimeModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x001AA858 File Offset: 0x001A8A58
		// (set) Token: 0x06005776 RID: 22390 RVA: 0x000293C2 File Offset: 0x000275C2
		public unsafe Action OnDialogueEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_OnDialogueEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_OnDialogueEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06005777 RID: 22391 RVA: 0x001AA888 File Offset: 0x001A8A88
		// (set) Token: 0x06005778 RID: 22392 RVA: 0x000293E1 File Offset: 0x000275E1
		public unsafe Transform LookPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x001AA8B8 File Offset: 0x001A8AB8
		// (set) Token: 0x0600577A RID: 22394 RVA: 0x00029400 File Offset: 0x00027600
		public unsafe WorldspaceDialogueRenderer WorldspaceRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x001AA8E8 File Offset: 0x001A8AE8
		// (set) Token: 0x0600577C RID: 22396 RVA: 0x0002941F File Offset: 0x0002761F
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x001AA918 File Offset: 0x001A8B18
		// (set) Token: 0x0600577E RID: 22398 RVA: 0x0002943E File Offset: 0x0002763E
		public unsafe List<DialogueChoiceData> CurrentChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x001AA948 File Offset: 0x001A8B48
		// (set) Token: 0x06005780 RID: 22400 RVA: 0x0002945D File Offset: 0x0002765D
		public unsafe Il2CppReferenceArray<DialogueEvent> DialogueEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06005781 RID: 22401 RVA: 0x001AA978 File Offset: 0x001A8B78
		// (set) Token: 0x06005782 RID: 22402 RVA: 0x0002947C File Offset: 0x0002767C
		public unsafe UnityEvent onConversationStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06005783 RID: 22403 RVA: 0x001AA9A8 File Offset: 0x001A8BA8
		// (set) Token: 0x06005784 RID: 22404 RVA: 0x0002949B File Offset: 0x0002769B
		public unsafe UnityEvent<string> onDialogueNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x001AA9D8 File Offset: 0x001A8BD8
		// (set) Token: 0x06005786 RID: 22406 RVA: 0x000294BA File Offset: 0x000276BA
		public unsafe UnityEvent<string> onDialogueChoiceChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x001AAA08 File Offset: 0x001A8C08
		// (set) Token: 0x06005788 RID: 22408 RVA: 0x000294D9 File Offset: 0x000276D9
		public unsafe List<DialogueContainer> dialogueContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x001AAA38 File Offset: 0x001A8C38
		// (set) Token: 0x0600578A RID: 22410 RVA: 0x000294F8 File Offset: 0x000276F8
		public unsafe List<NodeLinkData> tempLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_tempLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_tempLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600578B RID: 22411 RVA: 0x001AAA68 File Offset: 0x001A8C68
		// (set) Token: 0x0600578C RID: 22412 RVA: 0x00029517 File Offset: 0x00027717
		public unsafe bool skipNextDialogueBehaviourEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd)) = value;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x001AAA90 File Offset: 0x001A8C90
		// (set) Token: 0x0600578E RID: 22414 RVA: 0x00029532 File Offset: 0x00027732
		public unsafe List<DialogueChoiceData> finalChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_finalChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_finalChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x001AAAC0 File Offset: 0x001A8CC0
		// (set) Token: 0x06005790 RID: 22416 RVA: 0x00029551 File Offset: 0x00027751
		public unsafe bool passChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked)) = value;
			}
		}

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMinDuration;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMaxDuration;

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDialogue_k__BackingField;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDialogueNode_k__BackingField;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeFieldInfoPtr__IsDialogueInProgress_k__BackingField;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeFieldInfoPtr__Database_k__BackingField;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeFieldInfoPtr__RuntimeModules_k__BackingField;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeFieldInfoPtr_OnDialogueEnd;

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeFieldInfoPtr_LookPosition;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceRend;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeFieldInfoPtr_CurrentChoices;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEvents;

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeFieldInfoPtr_onConversationStart;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueNodeDisplayed;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueChoiceChosen;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeFieldInfoPtr_dialogueContainers;

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeFieldInfoPtr_tempLinks;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeFieldInfoPtr_skipNextDialogueBehaviourEnd;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeFieldInfoPtr_finalChoices;

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeFieldInfoPtr_passChecked;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDialogue_Public_Static_get_DialogueContainer_0;

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDialogue_Private_Static_set_Void_DialogueContainer_0;

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDialogueNode_Public_Static_get_DialogueNodeData_0;

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDialogueNode_Private_Static_set_Void_DialogueNodeData_0;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDialogueInProgress_Public_get_Boolean_0;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDialogueInProgress_Private_set_Void_Boolean_0;

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_get_DialogueDatabase_0;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeMethodInfoPtr_set_Database_Protected_set_Void_DialogueDatabase_0;

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeModules_Public_get_List_1_DialogueModule_0;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeMethodInfoPtr_set_RuntimeModules_Private_set_Void_List_1_DialogueModule_0;

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDialogueEnd_Public_add_Void_Action_0;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDialogueEnd_Public_rem_Void_Action_0;

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Protected_get_DialogueCanvas_0;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0;

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_0;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Public_Void_DialogueContainer_Boolean_String_0;

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Public_Void_String_Boolean_String_0;

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeMethodInfoPtr_StopOverride_Public_Void_0;

		// Token: 0x04003C2F RID: 15407
		private static readonly IntPtr NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0;

		// Token: 0x04003C30 RID: 15408
		private static readonly IntPtr NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0;

		// Token: 0x04003C31 RID: 15409
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0;

		// Token: 0x04003C32 RID: 15410
		private static readonly IntPtr NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0;

		// Token: 0x04003C33 RID: 15411
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0;

		// Token: 0x04003C34 RID: 15412
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x04003C35 RID: 15413
		private static readonly IntPtr NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0;

		// Token: 0x04003C36 RID: 15414
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x04003C37 RID: 15415
		private static readonly IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04003C38 RID: 15416
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0;

		// Token: 0x04003C39 RID: 15417
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04003C3A RID: 15418
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04003C3D RID: 15421
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04003C3E RID: 15422
		private static readonly IntPtr NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0;

		// Token: 0x04003C3F RID: 15423
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0;

		// Token: 0x04003C40 RID: 15424
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04003C41 RID: 15425
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04003C42 RID: 15426
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0;

		// Token: 0x04003C43 RID: 15427
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0;

		// Token: 0x04003C44 RID: 15428
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0;

		// Token: 0x04003C45 RID: 15429
		private static readonly IntPtr NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0;

		// Token: 0x04003C46 RID: 15430
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0;

		// Token: 0x04003C47 RID: 15431
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0;

		// Token: 0x04003C48 RID: 15432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC8 RID: 2760
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E410 RID: 58384 RVA: 0x0037D07C File Offset: 0x0037B27C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, "npc");
				DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_dialogueContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, "dialogueContainer");
				DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_entryNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, "entryNodeLabel");
				DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, 100674788);
				DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, 100674789);
				DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, 100674790);
			}

			// Token: 0x0600E411 RID: 58385 RVA: 0x0037D134 File Offset: 0x0037B334
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E412 RID: 58386 RVA: 0x0037D170 File Offset: 0x0037B370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191756, XrefRangeEnd = 191761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E413 RID: 58387 RVA: 0x0037D1B0 File Offset: 0x0037B3B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 191785, RefRangeEnd = 191786, XrefRangeStart = 191761, XrefRangeEnd = 191785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E414 RID: 58388 RVA: 0x0006B8B9 File Offset: 0x00069AB9
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004561 RID: 17761
			// (get) Token: 0x0600E415 RID: 58389 RVA: 0x0037D1E4 File Offset: 0x0037B3E4
			// (set) Token: 0x0600E416 RID: 58390 RVA: 0x0006B8C2 File Offset: 0x00069AC2
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004562 RID: 17762
			// (get) Token: 0x0600E417 RID: 58391 RVA: 0x0037D214 File Offset: 0x0037B414
			// (set) Token: 0x0600E418 RID: 58392 RVA: 0x0006B8E1 File Offset: 0x00069AE1
			public unsafe DialogueHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004563 RID: 17763
			// (get) Token: 0x0600E419 RID: 58393 RVA: 0x0037D244 File Offset: 0x0037B444
			// (set) Token: 0x0600E41A RID: 58394 RVA: 0x0006B900 File Offset: 0x00069B00
			public unsafe DialogueContainer dialogueContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_dialogueContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_dialogueContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004564 RID: 17764
			// (get) Token: 0x0600E41B RID: 58395 RVA: 0x0037D274 File Offset: 0x0037B474
			// (set) Token: 0x0600E41C RID: 58396 RVA: 0x0006B91F File Offset: 0x00069B1F
			public unsafe string entryNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_entryNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.NativeFieldInfoPtr_entryNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009AF2 RID: 39666
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04009AF3 RID: 39667
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009AF4 RID: 39668
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainer;

			// Token: 0x04009AF5 RID: 39669
			private static readonly IntPtr NativeFieldInfoPtr_entryNodeLabel;

			// Token: 0x04009AF6 RID: 39670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AF7 RID: 39671
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009AF8 RID: 39672
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000DD1 RID: 3537
			[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass46_0+<<StartDialogue>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF4A RID: 65354 RVA: 0x003CB664 File Offset: 0x003C9864
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0>.NativeClassPtr, "<<StartDialogue>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674791);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674792);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674793);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674794);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674795);
					DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674796);
				}

				// Token: 0x0600FF4B RID: 65355 RVA: 0x003CB744 File Offset: 0x003C9944
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF4C RID: 65356 RVA: 0x003CB78C File Offset: 0x003C998C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF4D RID: 65357 RVA: 0x003CB7C0 File Offset: 0x003C99C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191746, XrefRangeEnd = 191751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DB5 RID: 19893
				// (get) Token: 0x0600FF4E RID: 65358 RVA: 0x003CB7FC File Offset: 0x003C99FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF4F RID: 65359 RVA: 0x003CB83C File Offset: 0x003C9A3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191751, XrefRangeEnd = 191756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DB6 RID: 19894
				// (get) Token: 0x0600FF50 RID: 65360 RVA: 0x003CB870 File Offset: 0x003C9A70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF51 RID: 65361 RVA: 0x00078F35 File Offset: 0x00077135
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DB2 RID: 19890
				// (get) Token: 0x0600FF52 RID: 65362 RVA: 0x003CB8B0 File Offset: 0x003C9AB0
				// (set) Token: 0x0600FF53 RID: 65363 RVA: 0x00078F3E File Offset: 0x0007713E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DB3 RID: 19891
				// (get) Token: 0x0600FF54 RID: 65364 RVA: 0x003CB8D8 File Offset: 0x003C9AD8
				// (set) Token: 0x0600FF55 RID: 65365 RVA: 0x00078F59 File Offset: 0x00077159
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DB4 RID: 19892
				// (get) Token: 0x0600FF56 RID: 65366 RVA: 0x003CB908 File Offset: 0x003C9B08
				// (set) Token: 0x0600FF57 RID: 65367 RVA: 0x00078F78 File Offset: 0x00077178
				public unsafe DialogueHandler.__c__DisplayClass46_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler.__c__DisplayClass46_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC04 RID: 44036
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC05 RID: 44037
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC06 RID: 44038
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC07 RID: 44039
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC08 RID: 44040
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC09 RID: 44041
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC0A RID: 44042
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC0B RID: 44043
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC0C RID: 44044
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AC9 RID: 2761
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E41D RID: 58397 RVA: 0x0037D29C File Offset: 0x0037B49C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass47_0.NativeFieldInfoPtr_dialogueContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr, "dialogueContainerName");
				DialogueHandler.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr, 100674797);
				DialogueHandler.__c__DisplayClass47_0.NativeMethodInfoPtr__StartDialogue_b__0_Internal_Boolean_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr, 100674798);
			}

			// Token: 0x0600E41E RID: 58398 RVA: 0x0037D304 File Offset: 0x0037B504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E41F RID: 58399 RVA: 0x0037D340 File Offset: 0x0037B540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191786, XrefRangeEnd = 191791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartDialogue_b__0(DialogueContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass47_0.NativeMethodInfoPtr__StartDialogue_b__0_Internal_Boolean_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E420 RID: 58400 RVA: 0x0006B93E File Offset: 0x00069B3E
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004565 RID: 17765
			// (get) Token: 0x0600E421 RID: 58401 RVA: 0x0037D390 File Offset: 0x0037B590
			// (set) Token: 0x0600E422 RID: 58402 RVA: 0x0006B947 File Offset: 0x00069B47
			public unsafe string dialogueContainerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass47_0.NativeFieldInfoPtr_dialogueContainerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass47_0.NativeFieldInfoPtr_dialogueContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009AF9 RID: 39673
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainerName;

			// Token: 0x04009AFA RID: 39674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AFB RID: 39675
			private static readonly IntPtr NativeMethodInfoPtr__StartDialogue_b__0_Internal_Boolean_DialogueContainer_0;
		}

		// Token: 0x02000ACA RID: 2762
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E423 RID: 58403 RVA: 0x0037D3B8 File Offset: 0x0037B5B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass67_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueHandler.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr, 100674799);
				DialogueHandler.__c__DisplayClass67_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr, 100674800);
			}

			// Token: 0x0600E424 RID: 58404 RVA: 0x0037D420 File Offset: 0x0037B620
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E425 RID: 58405 RVA: 0x0037D45C File Offset: 0x0037B65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass67_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E426 RID: 58406 RVA: 0x0006B966 File Offset: 0x00069B66
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004566 RID: 17766
			// (get) Token: 0x0600E427 RID: 58407 RVA: 0x0037D4AC File Offset: 0x0037B6AC
			// (set) Token: 0x0600E428 RID: 58408 RVA: 0x0006B96F File Offset: 0x00069B6F
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass67_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass67_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009AFC RID: 39676
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04009AFD RID: 39677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AFE RID: 39678
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}
	}
}
