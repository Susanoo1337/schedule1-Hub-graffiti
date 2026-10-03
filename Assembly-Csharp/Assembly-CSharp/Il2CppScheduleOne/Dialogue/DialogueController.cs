using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003BD RID: 957
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x0600569C RID: 22172 RVA: 0x001A71CC File Offset: 0x001A53CC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController()
		{
			Il2CppClassPointerStore<DialogueController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController>.NativeClassPtr);
			DialogueController.NativeFieldInfoPtr_GreetingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingCooldown");
			DialogueController.NativeFieldInfoPtr_RainyGreetingThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "RainyGreetingThreshold");
			DialogueController.NativeFieldInfoPtr_RainyGreetingChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "RainyGreetingChance");
			DialogueController.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "IntObj");
			DialogueController.NativeFieldInfoPtr_GenericDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GenericDialogue");
			DialogueController.NativeFieldInfoPtr_DialogueEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueEnabled");
			DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "UseDialogueBehaviour");
			DialogueController.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "Choices");
			DialogueController.NativeFieldInfoPtr_GreetingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverrides");
			DialogueController.NativeFieldInfoPtr_OverrideContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "OverrideContainer");
			DialogueController.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "npc");
			DialogueController.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "handler");
			DialogueController.NativeFieldInfoPtr_lastGreetingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "lastGreetingTime");
			DialogueController.NativeFieldInfoPtr_shownChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "shownChoices");
			DialogueController.NativeFieldInfoPtr_cachedGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "cachedGreeting");
			DialogueController.NativeFieldInfoPtr__timeOnDialogueStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "_timeOnDialogueStart");
			DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674661);
			DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674662);
			DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674663);
			DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674664);
			DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674665);
			DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674666);
			DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674667);
			DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674668);
			DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674669);
			DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674670);
			DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674671);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674672);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674673);
			DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674674);
			DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674675);
			DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674676);
			DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674677);
			DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674678);
			DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674679);
			DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100674680);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x001A74CC File Offset: 0x001A56CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 190940, RefRangeEnd = 190949, XrefRangeStart = 190921, XrefRangeEnd = 190940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x001A7508 File Offset: 0x001A5708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190949, XrefRangeEnd = 190960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x001A753C File Offset: 0x001A573C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190963, RefRangeEnd = 190965, XrefRangeStart = 190960, XrefRangeEnd = 190963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGenericDialogue(bool allowExit = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowExit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x001A757C File Offset: 0x001A577C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190977, RefRangeEnd = 190978, XrefRangeStart = 190965, XrefRangeEnd = 190977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x001A75B0 File Offset: 0x001A57B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190996, RefRangeEnd = 190997, XrefRangeStart = 190978, XrefRangeEnd = 190996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &playVO;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x001A7604 File Offset: 0x001A5804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191039, RefRangeEnd = 191041, XrefRangeStart = 190997, XrefRangeEnd = 191039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr3) : null;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x001A7644 File Offset: 0x001A5844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191041, XrefRangeEnd = 191056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &playVO;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			greeting = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x001A76C4 File Offset: 0x001A58C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191056, XrefRangeEnd = 191062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x001A772C File Offset: 0x001A592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191062, XrefRangeEnd = 191068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x001A7784 File Offset: 0x001A5984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191082, RefRangeEnd = 191083, XrefRangeStart = 191068, XrefRangeEnd = 191082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x001A77CC File Offset: 0x001A59CC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 191092, RefRangeEnd = 191103, XrefRangeStart = 191083, XrefRangeEnd = 191092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x001A7834 File Offset: 0x001A5A34
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x001A789C File Offset: 0x001A5A9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191134, RefRangeEnd = 191138, XrefRangeStart = 191103, XrefRangeEnd = 191134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x001A7910 File Offset: 0x001A5B10
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 191161, RefRangeEnd = 191170, XrefRangeStart = 191138, XrefRangeEnd = 191161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x001A7960 File Offset: 0x001A5B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191170, XrefRangeEnd = 191190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x001A79D4 File Offset: 0x001A5BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideContainer(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x001A7A18 File Offset: 0x001A5C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191190, XrefRangeEnd = 191191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrideContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x001A7A4C File Offset: 0x001A5C4C
		[CallerCount(0)]
		public unsafe virtual bool DecideBranch(string branchLabel, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x001A7AB4 File Offset: 0x001A5CB4
		[CallerCount(0)]
		public unsafe void SetDialogueEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x001A7AF4 File Offset: 0x001A5CF4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 191214, RefRangeEnd = 191228, XrefRangeStart = 191191, XrefRangeEnd = 191214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00028EF7 File Offset: 0x000270F7
		public DialogueController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x001A7B30 File Offset: 0x001A5D30
		// (set) Token: 0x060056B3 RID: 22195 RVA: 0x00028F00 File Offset: 0x00027100
		public unsafe static float GreetingCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_GreetingCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_GreetingCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x060056B4 RID: 22196 RVA: 0x001A7B4C File Offset: 0x001A5D4C
		// (set) Token: 0x060056B5 RID: 22197 RVA: 0x00028F0E File Offset: 0x0002710E
		public unsafe static float RainyGreetingThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_RainyGreetingThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_RainyGreetingThreshold, (void*)(&value));
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x060056B6 RID: 22198 RVA: 0x001A7B68 File Offset: 0x001A5D68
		// (set) Token: 0x060056B7 RID: 22199 RVA: 0x00028F1C File Offset: 0x0002711C
		public unsafe static float RainyGreetingChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_RainyGreetingChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_RainyGreetingChance, (void*)(&value));
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x001A7B84 File Offset: 0x001A5D84
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x00028F2A File Offset: 0x0002712A
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x001A7BB4 File Offset: 0x001A5DB4
		// (set) Token: 0x060056BB RID: 22203 RVA: 0x00028F49 File Offset: 0x00027149
		public unsafe DialogueContainer GenericDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x001A7BE4 File Offset: 0x001A5DE4
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x00028F68 File Offset: 0x00027168
		public unsafe bool DialogueEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled)) = value;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x001A7C0C File Offset: 0x001A5E0C
		// (set) Token: 0x060056BF RID: 22207 RVA: 0x00028F83 File Offset: 0x00027183
		public unsafe bool UseDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour)) = value;
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x001A7C34 File Offset: 0x001A5E34
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x00028F9E File Offset: 0x0002719E
		public unsafe List<DialogueController.DialogueChoice> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x001A7C64 File Offset: 0x001A5E64
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x00028FBD File Offset: 0x000271BD
		public unsafe List<DialogueController.GreetingOverride> GreetingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.GreetingOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x001A7C94 File Offset: 0x001A5E94
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x00028FDC File Offset: 0x000271DC
		public unsafe DialogueContainer OverrideContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x001A7CC4 File Offset: 0x001A5EC4
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x00028FFB File Offset: 0x000271FB
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x001A7CF4 File Offset: 0x001A5EF4
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x0002901A File Offset: 0x0002721A
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x001A7D24 File Offset: 0x001A5F24
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x00029039 File Offset: 0x00027239
		public unsafe float lastGreetingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime)) = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x001A7D4C File Offset: 0x001A5F4C
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x00029054 File Offset: 0x00027254
		public unsafe List<DialogueController.DialogueChoice> shownChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x001A7D7C File Offset: 0x001A5F7C
		// (set) Token: 0x060056CF RID: 22223 RVA: 0x00029073 File Offset: 0x00027273
		public unsafe string cachedGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x001A7DA4 File Offset: 0x001A5FA4
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x00029092 File Offset: 0x00027292
		public unsafe float _timeOnDialogueStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr__timeOnDialogueStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr__timeOnDialogueStart)) = value;
			}
		}

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_GreetingCooldown;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_RainyGreetingThreshold;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_RainyGreetingChance;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogue;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEnabled;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr_UseDialogueBehaviour;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeFieldInfoPtr_GreetingOverrides;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeFieldInfoPtr_OverrideContainer;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_lastGreetingTime;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeFieldInfoPtr_shownChoices;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeFieldInfoPtr_cachedGreeting;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeFieldInfoPtr__timeOnDialogueStart;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC4 RID: 2756
		[Serializable]
		public class DialogueChoice : Il2CppSystem.Object
		{
			// Token: 0x0600E3E2 RID: 58338 RVA: 0x0037C954 File Offset: 0x0037AB54
			// Note: this type is marked as 'beforefieldinit'.
			static DialogueChoice()
			{
				Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueChoice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr);
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Enabled");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ChoiceText");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_ShowWorldspaceDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ShowWorldspaceDialogue");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Conversation");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "onChoosen");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "shouldShowCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "isValidCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Priority");
				DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100674681);
				DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100674682);
				DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100674683);
			}

			// Token: 0x0600E3E3 RID: 58339 RVA: 0x0037CA5C File Offset: 0x0037AC5C
			[CallerCount(0)]
			public unsafe bool ShouldShow()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3E4 RID: 58340 RVA: 0x0037CA98 File Offset: 0x0037AC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190891, XrefRangeEnd = 190894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid(out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600E3E5 RID: 58341 RVA: 0x0037CAF0 File Offset: 0x0037ACF0
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 190900, RefRangeEnd = 190919, XrefRangeStart = 190894, XrefRangeEnd = 190900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DialogueChoice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3E6 RID: 58342 RVA: 0x0006B6FA File Offset: 0x000698FA
			public DialogueChoice(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004552 RID: 17746
			// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x0037CB2C File Offset: 0x0037AD2C
			// (set) Token: 0x0600E3E8 RID: 58344 RVA: 0x0006B703 File Offset: 0x00069903
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x17004553 RID: 17747
			// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x0037CB54 File Offset: 0x0037AD54
			// (set) Token: 0x0600E3EA RID: 58346 RVA: 0x0006B71E File Offset: 0x0006991E
			public unsafe string ChoiceText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004554 RID: 17748
			// (get) Token: 0x0600E3EB RID: 58347 RVA: 0x0037CB7C File Offset: 0x0037AD7C
			// (set) Token: 0x0600E3EC RID: 58348 RVA: 0x0006B73D File Offset: 0x0006993D
			public unsafe bool ShowWorldspaceDialogue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ShowWorldspaceDialogue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ShowWorldspaceDialogue)) = value;
				}
			}

			// Token: 0x17004555 RID: 17749
			// (get) Token: 0x0600E3ED RID: 58349 RVA: 0x0037CBA4 File Offset: 0x0037ADA4
			// (set) Token: 0x0600E3EE RID: 58350 RVA: 0x0006B758 File Offset: 0x00069958
			public unsafe DialogueContainer Conversation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004556 RID: 17750
			// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x0037CBD4 File Offset: 0x0037ADD4
			// (set) Token: 0x0600E3F0 RID: 58352 RVA: 0x0006B777 File Offset: 0x00069977
			public unsafe UnityEvent onChoosen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004557 RID: 17751
			// (get) Token: 0x0600E3F1 RID: 58353 RVA: 0x0037CC04 File Offset: 0x0037AE04
			// (set) Token: 0x0600E3F2 RID: 58354 RVA: 0x0006B796 File Offset: 0x00069996
			public unsafe DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.ShouldShowCheck>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004558 RID: 17752
			// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x0037CC34 File Offset: 0x0037AE34
			// (set) Token: 0x0600E3F4 RID: 58356 RVA: 0x0006B7B5 File Offset: 0x000699B5
			public unsafe DialogueController.DialogueChoice.IsChoiceValid isValidCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.IsChoiceValid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004559 RID: 17753
			// (get) Token: 0x0600E3F5 RID: 58357 RVA: 0x0037CC64 File Offset: 0x0037AE64
			// (set) Token: 0x0600E3F6 RID: 58358 RVA: 0x0006B7D4 File Offset: 0x000699D4
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04009ADB RID: 39643
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04009ADC RID: 39644
			private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

			// Token: 0x04009ADD RID: 39645
			private static readonly IntPtr NativeFieldInfoPtr_ShowWorldspaceDialogue;

			// Token: 0x04009ADE RID: 39646
			private static readonly IntPtr NativeFieldInfoPtr_Conversation;

			// Token: 0x04009ADF RID: 39647
			private static readonly IntPtr NativeFieldInfoPtr_onChoosen;

			// Token: 0x04009AE0 RID: 39648
			private static readonly IntPtr NativeFieldInfoPtr_shouldShowCheck;

			// Token: 0x04009AE1 RID: 39649
			private static readonly IntPtr NativeFieldInfoPtr_isValidCheck;

			// Token: 0x04009AE2 RID: 39650
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04009AE3 RID: 39651
			private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Boolean_0;

			// Token: 0x04009AE4 RID: 39652
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0;

			// Token: 0x04009AE5 RID: 39653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000DCF RID: 3535
			public sealed class ShouldShowCheck : MulticastDelegate
			{
				// Token: 0x0600FF3B RID: 65339 RVA: 0x003CB278 File Offset: 0x003C9478
				// Note: this type is marked as 'beforefieldinit'.
				static ShouldShowCheck()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ShouldShowCheck");
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100674684);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100674685);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100674686);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100674687);
				}

				// Token: 0x0600FF3C RID: 65340 RVA: 0x003CB2EC File Offset: 0x003C94EC
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 190846, RefRangeEnd = 190862, XrefRangeStart = 190843, XrefRangeEnd = 190846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ShouldShowCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF3D RID: 65341 RVA: 0x003CB348 File Offset: 0x003C9548
				[CallerCount(0)]
				public unsafe bool Invoke(bool enabled)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FF3E RID: 65342 RVA: 0x003CB394 File Offset: 0x003C9594
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190862, XrefRangeEnd = 190866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(bool enabled, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600FF3F RID: 65343 RVA: 0x003CB404 File Offset: 0x003C9604
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FF40 RID: 65344 RVA: 0x00078EFC File Offset: 0x000770FC
				public ShouldShowCheck(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600FF41 RID: 65345 RVA: 0x00078F05 File Offset: 0x00077105
				public static implicit operator DialogueController.DialogueChoice.ShouldShowCheck(Func<bool, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<DialogueController.DialogueChoice.ShouldShowCheck>(A_0);
				}

				// Token: 0x0600FF42 RID: 65346 RVA: 0x00078F0D File Offset: 0x0007710D
				public static DialogueController.DialogueChoice.ShouldShowCheck operator +(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
				}

				// Token: 0x0600FF43 RID: 65347 RVA: 0x00078F1B File Offset: 0x0007711B
				public static DialogueController.DialogueChoice.ShouldShowCheck operator -(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					Delegate result;
					Delegate @delegate = result = Delegate.Remove(A_0, A_1);
					if (@delegate != null)
					{
						result = @delegate.Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
					}
					return result;
				}

				// Token: 0x0400ABFC RID: 44028
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400ABFD RID: 44029
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0;

				// Token: 0x0400ABFE RID: 44030
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

				// Token: 0x0400ABFF RID: 44031
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000DD0 RID: 3536
			public sealed class IsChoiceValid : MulticastDelegate
			{
				// Token: 0x0600FF44 RID: 65348 RVA: 0x003CB454 File Offset: 0x003C9654
				// Note: this type is marked as 'beforefieldinit'.
				static IsChoiceValid()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "IsChoiceValid");
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100674688);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100674689);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100674690);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100674691);
				}

				// Token: 0x0600FF45 RID: 65349 RVA: 0x003CB4C8 File Offset: 0x003C96C8
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 190870, RefRangeEnd = 190890, XrefRangeStart = 190866, XrefRangeEnd = 190870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsChoiceValid(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF46 RID: 65350 RVA: 0x003CB524 File Offset: 0x003C9724
				[CallerCount(0)]
				public unsafe bool Invoke(out string invalidReason)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600FF47 RID: 65351 RVA: 0x003CB57C File Offset: 0x003C977C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190890, XrefRangeEnd = 190891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(out string invalidReason, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
				}

				// Token: 0x0600FF48 RID: 65352 RVA: 0x003CB5FC File Offset: 0x003C97FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600FF49 RID: 65353 RVA: 0x00078F2C File Offset: 0x0007712C
				public IsChoiceValid(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400AC00 RID: 44032
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400AC01 RID: 44033
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0;

				// Token: 0x0400AC02 RID: 44034
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0;

				// Token: 0x0400AC03 RID: 44035
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
			}
		}

		// Token: 0x02000AC5 RID: 2757
		[Serializable]
		public class GreetingOverride : Il2CppSystem.Object
		{
			// Token: 0x0600E3F7 RID: 58359 RVA: 0x0037CC8C File Offset: 0x0037AE8C
			// Note: this type is marked as 'beforefieldinit'.
			static GreetingOverride()
			{
				Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr);
				DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "Greeting");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "ShouldShow");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "PlayVO");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "VOType");
				DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, 100674692);
			}

			// Token: 0x0600E3F8 RID: 58360 RVA: 0x0037CD1C File Offset: 0x0037AF1C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreetingOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3F9 RID: 58361 RVA: 0x0006B7EF File Offset: 0x000699EF
			public GreetingOverride(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455A RID: 17754
			// (get) Token: 0x0600E3FA RID: 58362 RVA: 0x0037CD58 File Offset: 0x0037AF58
			// (set) Token: 0x0600E3FB RID: 58363 RVA: 0x0006B7F8 File Offset: 0x000699F8
			public unsafe string Greeting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700455B RID: 17755
			// (get) Token: 0x0600E3FC RID: 58364 RVA: 0x0037CD80 File Offset: 0x0037AF80
			// (set) Token: 0x0600E3FD RID: 58365 RVA: 0x0006B817 File Offset: 0x00069A17
			public unsafe bool ShouldShow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow)) = value;
				}
			}

			// Token: 0x1700455C RID: 17756
			// (get) Token: 0x0600E3FE RID: 58366 RVA: 0x0037CDA8 File Offset: 0x0037AFA8
			// (set) Token: 0x0600E3FF RID: 58367 RVA: 0x0006B832 File Offset: 0x00069A32
			public unsafe bool PlayVO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO)) = value;
				}
			}

			// Token: 0x1700455D RID: 17757
			// (get) Token: 0x0600E400 RID: 58368 RVA: 0x0037CDD0 File Offset: 0x0037AFD0
			// (set) Token: 0x0600E401 RID: 58369 RVA: 0x0006B84D File Offset: 0x00069A4D
			public unsafe EVOLineType VOType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType)) = value;
				}
			}

			// Token: 0x04009AE6 RID: 39654
			private static readonly IntPtr NativeFieldInfoPtr_Greeting;

			// Token: 0x04009AE7 RID: 39655
			private static readonly IntPtr NativeFieldInfoPtr_ShouldShow;

			// Token: 0x04009AE8 RID: 39656
			private static readonly IntPtr NativeFieldInfoPtr_PlayVO;

			// Token: 0x04009AE9 RID: 39657
			private static readonly IntPtr NativeFieldInfoPtr_VOType;

			// Token: 0x04009AEA RID: 39658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC6 RID: 2758
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E402 RID: 58370 RVA: 0x0037CDF8 File Offset: 0x0037AFF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr);
				DialogueController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9");
				DialogueController.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9__23_0");
				DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100674694);
				DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100674695);
			}

			// Token: 0x0600E403 RID: 58371 RVA: 0x0037CE74 File Offset: 0x0037B074
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E404 RID: 58372 RVA: 0x0037CEB0 File Offset: 0x0037B0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190919, XrefRangeEnd = 190921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActiveChoices_b__23_0(DialogueController.DialogueChoice a, DialogueController.DialogueChoice b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E405 RID: 58373 RVA: 0x0006B868 File Offset: 0x00069A68
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0600E406 RID: 58374 RVA: 0x0037CF10 File Offset: 0x0037B110
			// (set) Token: 0x0600E407 RID: 58375 RVA: 0x0006B871 File Offset: 0x00069A71
			public unsafe static DialogueController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0600E408 RID: 58376 RVA: 0x0037CF38 File Offset: 0x0037B138
			// (set) Token: 0x0600E409 RID: 58377 RVA: 0x0006B883 File Offset: 0x00069A83
			public unsafe static Comparison<DialogueController.DialogueChoice> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DialogueController.DialogueChoice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AEB RID: 39659
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AEC RID: 39660
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04009AED RID: 39661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AEE RID: 39662
			private static readonly IntPtr NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0;
		}
	}
}
