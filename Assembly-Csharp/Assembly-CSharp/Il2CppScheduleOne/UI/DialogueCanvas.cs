using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072C RID: 1836
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x0600B123 RID: 45347 RVA: 0x002E43F8 File Offset: 0x002E25F8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueCanvas()
		{
			Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr);
			DialogueCanvas.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "TimePerChar");
			DialogueCanvas.NativeFieldInfoPtr__SkipNextRollout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<SkipNextRollout>k__BackingField");
			DialogueCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "canvas");
			DialogueCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "Container");
			DialogueCanvas.NativeFieldInfoPtr_dialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueText");
			DialogueCanvas.NativeFieldInfoPtr_dialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueChoices");
			DialogueCanvas.NativeFieldInfoPtr_continueChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "continueChoice");
			DialogueCanvas.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "state");
			DialogueCanvas.NativeFieldInfoPtr_continueActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "continueActions");
			DialogueCanvas.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "uiScreen");
			DialogueCanvas.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "uiPanel");
			DialogueCanvas.NativeFieldInfoPtr_currentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentHandler");
			DialogueCanvas.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentNode");
			DialogueCanvas.NativeFieldInfoPtr_dialogueRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueRoutine");
			DialogueCanvas.NativeFieldInfoPtr__continuePressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "_continuePressed");
			DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "hasChoiceBeenSelected");
			DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "choiceSelectionResidualCoroutine");
			DialogueCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686581);
			DialogueCanvas.NativeMethodInfoPtr_get_SkipNextRollout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686582);
			DialogueCanvas.NativeMethodInfoPtr_set_SkipNextRollout_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686583);
			DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686584);
			DialogueCanvas.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686585);
			DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686586);
			DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686587);
			DialogueCanvas.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686588);
			DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686589);
			DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686590);
			DialogueCanvas.NativeMethodInfoPtr_SelectPanel_Private_IEnumerator_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686591);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686592);
			DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686593);
			DialogueCanvas.NativeMethodInfoPtr_OnStateDeactivated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686594);
			DialogueCanvas.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686595);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686596);
			DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686597);
			DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686598);
			DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__27_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100686599);
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600B124 RID: 45348 RVA: 0x002E46F8 File Offset: 0x002E28F8
		public unsafe bool IsOpen
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 300636, RefRangeEnd = 300641, XrefRangeStart = 300632, XrefRangeEnd = 300636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600B125 RID: 45349 RVA: 0x002E4734 File Offset: 0x002E2934
		// (set) Token: 0x0600B126 RID: 45350 RVA: 0x002E4770 File Offset: 0x002E2970
		public unsafe bool SkipNextRollout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_get_SkipNextRollout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_set_SkipNextRollout_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x002E47B0 File Offset: 0x002E29B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300641, XrefRangeEnd = 300721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x002E47EC File Offset: 0x002E29EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300721, XrefRangeEnd = 300746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueCanvas.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x002E4828 File Offset: 0x002E2A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300762, RefRangeEnd = 300763, XrefRangeStart = 300746, XrefRangeEnd = 300762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<DialogueChoiceData> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(diag);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_DialogueChoiceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x002E48A4 File Offset: 0x002E2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300763, XrefRangeEnd = 300770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x002E48D8 File Offset: 0x002E2AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300788, RefRangeEnd = 300789, XrefRangeStart = 300770, XrefRangeEnd = 300788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceChanged(GameInput.InputDeviceType newDeviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newDeviceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x002E4918 File Offset: 0x002E2B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300789, XrefRangeEnd = 300798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x002E495C File Offset: 0x002E2B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300798, XrefRangeEnd = 300805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RolloutDialogue(string text, List<DialogueChoiceData> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_DialogueChoiceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x002E49C0 File Offset: 0x002E2BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300805, XrefRangeEnd = 300811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectPanel(UISelectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_SelectPanel_Private_IEnumerator_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x002E4A10 File Offset: 0x002E2C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300817, RefRangeEnd = 300818, XrefRangeStart = 300811, XrefRangeEnd = 300817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x002E4A70 File Offset: 0x002E2C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300880, RefRangeEnd = 300881, XrefRangeStart = 300818, XrefRangeEnd = 300880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x002E4AB4 File Offset: 0x002E2CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300881, XrefRangeEnd = 300885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStateDeactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OnStateDeactivated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x002E4AE8 File Offset: 0x002E2CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300885, XrefRangeEnd = 300927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x002E4B1C File Offset: 0x002E2D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300953, RefRangeEnd = 300954, XrefRangeStart = 300927, XrefRangeEnd = 300953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x002E4B5C File Offset: 0x002E2D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300954, XrefRangeEnd = 300961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceValid(int choiceIndex, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x002E4BC0 File Offset: 0x002E2DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300961, XrefRangeEnd = 300971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x002E4BFC File Offset: 0x002E2DFC
		[CallerCount(0)]
		public unsafe bool _RolloutDialogue_b__27_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__27_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x00051673 File Offset: 0x0004F873
		public DialogueCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600B138 RID: 45368 RVA: 0x002E4C38 File Offset: 0x002E2E38
		// (set) Token: 0x0600B139 RID: 45369 RVA: 0x0005167C File Offset: 0x0004F87C
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueCanvas.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueCanvas.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600B13A RID: 45370 RVA: 0x002E4C54 File Offset: 0x002E2E54
		// (set) Token: 0x0600B13B RID: 45371 RVA: 0x0005168A File Offset: 0x0004F88A
		public unsafe bool _SkipNextRollout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr__SkipNextRollout_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr__SkipNextRollout_k__BackingField)) = value;
			}
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600B13C RID: 45372 RVA: 0x002E4C7C File Offset: 0x002E2E7C
		// (set) Token: 0x0600B13D RID: 45373 RVA: 0x000516A5 File Offset: 0x0004F8A5
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600B13E RID: 45374 RVA: 0x002E4CAC File Offset: 0x002E2EAC
		// (set) Token: 0x0600B13F RID: 45375 RVA: 0x000516C4 File Offset: 0x0004F8C4
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600B140 RID: 45376 RVA: 0x002E4CDC File Offset: 0x002E2EDC
		// (set) Token: 0x0600B141 RID: 45377 RVA: 0x000516E3 File Offset: 0x0004F8E3
		public unsafe TextMeshProUGUI dialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600B142 RID: 45378 RVA: 0x002E4D0C File Offset: 0x002E2F0C
		// (set) Token: 0x0600B143 RID: 45379 RVA: 0x00051702 File Offset: 0x0004F902
		public unsafe List<DialogueChoiceEntry> dialogueChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600B144 RID: 45380 RVA: 0x002E4D3C File Offset: 0x002E2F3C
		// (set) Token: 0x0600B145 RID: 45381 RVA: 0x00051721 File Offset: 0x0004F921
		public unsafe DialogueChoiceEntry continueChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continueChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChoiceEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continueChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600B146 RID: 45382 RVA: 0x002E4D6C File Offset: 0x002E2F6C
		// (set) Token: 0x0600B147 RID: 45383 RVA: 0x00051740 File Offset: 0x0004F940
		public unsafe MonoState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600B148 RID: 45384 RVA: 0x002E4D9C File Offset: 0x002E2F9C
		// (set) Token: 0x0600B149 RID: 45385 RVA: 0x0005175F File Offset: 0x0004F95F
		public unsafe Il2CppReferenceArray<InputActionReference> continueActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continueActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continueActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x002E4DCC File Offset: 0x002E2FCC
		// (set) Token: 0x0600B14B RID: 45387 RVA: 0x0005177E File Offset: 0x0004F97E
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600B14C RID: 45388 RVA: 0x002E4DFC File Offset: 0x002E2FFC
		// (set) Token: 0x0600B14D RID: 45389 RVA: 0x0005179D File Offset: 0x0004F99D
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600B14E RID: 45390 RVA: 0x002E4E2C File Offset: 0x002E302C
		// (set) Token: 0x0600B14F RID: 45391 RVA: 0x000517BC File Offset: 0x0004F9BC
		public unsafe DialogueHandler currentHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x002E4E5C File Offset: 0x002E305C
		// (set) Token: 0x0600B151 RID: 45393 RVA: 0x000517DB File Offset: 0x0004F9DB
		public unsafe DialogueNodeData currentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x002E4E8C File Offset: 0x002E308C
		// (set) Token: 0x0600B153 RID: 45395 RVA: 0x000517FA File Offset: 0x0004F9FA
		public unsafe Coroutine dialogueRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600B154 RID: 45396 RVA: 0x002E4EBC File Offset: 0x002E30BC
		// (set) Token: 0x0600B155 RID: 45397 RVA: 0x00051819 File Offset: 0x0004FA19
		public unsafe bool _continuePressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr__continuePressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr__continuePressed)) = value;
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600B156 RID: 45398 RVA: 0x002E4EE4 File Offset: 0x002E30E4
		// (set) Token: 0x0600B157 RID: 45399 RVA: 0x00051834 File Offset: 0x0004FA34
		public unsafe bool hasChoiceBeenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected)) = value;
			}
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600B158 RID: 45400 RVA: 0x002E4F0C File Offset: 0x002E310C
		// (set) Token: 0x0600B159 RID: 45401 RVA: 0x0005184F File Offset: 0x0004FA4F
		public unsafe Coroutine choiceSelectionResidualCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A11 RID: 31249
		private static readonly IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x04007A12 RID: 31250
		private static readonly IntPtr NativeFieldInfoPtr__SkipNextRollout_k__BackingField;

		// Token: 0x04007A13 RID: 31251
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007A14 RID: 31252
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007A15 RID: 31253
		private static readonly IntPtr NativeFieldInfoPtr_dialogueText;

		// Token: 0x04007A16 RID: 31254
		private static readonly IntPtr NativeFieldInfoPtr_dialogueChoices;

		// Token: 0x04007A17 RID: 31255
		private static readonly IntPtr NativeFieldInfoPtr_continueChoice;

		// Token: 0x04007A18 RID: 31256
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04007A19 RID: 31257
		private static readonly IntPtr NativeFieldInfoPtr_continueActions;

		// Token: 0x04007A1A RID: 31258
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x04007A1B RID: 31259
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04007A1C RID: 31260
		private static readonly IntPtr NativeFieldInfoPtr_currentHandler;

		// Token: 0x04007A1D RID: 31261
		private static readonly IntPtr NativeFieldInfoPtr_currentNode;

		// Token: 0x04007A1E RID: 31262
		private static readonly IntPtr NativeFieldInfoPtr_dialogueRoutine;

		// Token: 0x04007A1F RID: 31263
		private static readonly IntPtr NativeFieldInfoPtr__continuePressed;

		// Token: 0x04007A20 RID: 31264
		private static readonly IntPtr NativeFieldInfoPtr_hasChoiceBeenSelected;

		// Token: 0x04007A21 RID: 31265
		private static readonly IntPtr NativeFieldInfoPtr_choiceSelectionResidualCoroutine;

		// Token: 0x04007A22 RID: 31266
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007A23 RID: 31267
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipNextRollout_Public_get_Boolean_0;

		// Token: 0x04007A24 RID: 31268
		private static readonly IntPtr NativeMethodInfoPtr_set_SkipNextRollout_Public_set_Void_Boolean_0;

		// Token: 0x04007A25 RID: 31269
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A26 RID: 31270
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007A27 RID: 31271
		private static readonly IntPtr NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_DialogueChoiceData_0;

		// Token: 0x04007A28 RID: 31272
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007A29 RID: 31273
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04007A2A RID: 31274
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007A2B RID: 31275
		private static readonly IntPtr NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_DialogueChoiceData_0;

		// Token: 0x04007A2C RID: 31276
		private static readonly IntPtr NativeMethodInfoPtr_SelectPanel_Private_IEnumerator_UISelectable_0;

		// Token: 0x04007A2D RID: 31277
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0;

		// Token: 0x04007A2E RID: 31278
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0;

		// Token: 0x04007A2F RID: 31279
		private static readonly IntPtr NativeMethodInfoPtr_OnStateDeactivated_Private_Void_0;

		// Token: 0x04007A30 RID: 31280
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007A31 RID: 31281
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Private_Void_Int32_0;

		// Token: 0x04007A32 RID: 31282
		private static readonly IntPtr NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0;

		// Token: 0x04007A33 RID: 31283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007A34 RID: 31284
		private static readonly IntPtr NativeMethodInfoPtr__RolloutDialogue_b__27_0_Private_Boolean_0;

		// Token: 0x02000CC0 RID: 3264
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F45D RID: 62557 RVA: 0x003AC278 File Offset: 0x003AA478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr);
				DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr, "index");
				DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DialogueCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr, 100686600);
				DialogueCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr, 100686601);
			}

			// Token: 0x0600F45E RID: 62558 RVA: 0x003AC2F4 File Offset: 0x003AA4F4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F45F RID: 62559 RVA: 0x003AC330 File Offset: 0x003AA530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300547, XrefRangeEnd = 300549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F460 RID: 62560 RVA: 0x000736D5 File Offset: 0x000718D5
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A31 RID: 18993
			// (get) Token: 0x0600F461 RID: 62561 RVA: 0x003AC364 File Offset: 0x003AA564
			// (set) Token: 0x0600F462 RID: 62562 RVA: 0x000736DE File Offset: 0x000718DE
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004A32 RID: 18994
			// (get) Token: 0x0600F463 RID: 62563 RVA: 0x003AC38C File Offset: 0x003AA58C
			// (set) Token: 0x0600F464 RID: 62564 RVA: 0x000736F9 File Offset: 0x000718F9
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A56F RID: 42351
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A570 RID: 42352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A571 RID: 42353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A572 RID: 42354
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000CC1 RID: 3265
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<ChoiceSelectionResidual>d__30")]
		public sealed class _ChoiceSelectionResidual_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600F465 RID: 62565 RVA: 0x003AC3BC File Offset: 0x003AA5BC
			// Note: this type is marked as 'beforefieldinit'.
			static _ChoiceSelectionResidual_d__30()
			{
				Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<ChoiceSelectionResidual>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "<>1__state");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "<>2__current");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "fadeTime");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "choice");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "<>4__this");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__realFadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "<realFadeTime>5__2");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, "<i>5__3");
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686602);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686603);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686604);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686605);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686606);
				DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr, 100686607);
			}

			// Token: 0x0600F466 RID: 62566 RVA: 0x003AC4EC File Offset: 0x003AA6EC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChoiceSelectionResidual_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F467 RID: 62567 RVA: 0x003AC534 File Offset: 0x003AA734
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F468 RID: 62568 RVA: 0x003AC568 File Offset: 0x003AA768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300549, XrefRangeEnd = 300561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A3A RID: 19002
			// (get) Token: 0x0600F469 RID: 62569 RVA: 0x003AC5A4 File Offset: 0x003AA7A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F46A RID: 62570 RVA: 0x003AC5E4 File Offset: 0x003AA7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300561, XrefRangeEnd = 300566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A3B RID: 19003
			// (get) Token: 0x0600F46B RID: 62571 RVA: 0x003AC618 File Offset: 0x003AA818
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F46C RID: 62572 RVA: 0x00073718 File Offset: 0x00071918
			public _ChoiceSelectionResidual_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A33 RID: 18995
			// (get) Token: 0x0600F46D RID: 62573 RVA: 0x003AC658 File Offset: 0x003AA858
			// (set) Token: 0x0600F46E RID: 62574 RVA: 0x00073721 File Offset: 0x00071921
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A34 RID: 18996
			// (get) Token: 0x0600F46F RID: 62575 RVA: 0x003AC680 File Offset: 0x003AA880
			// (set) Token: 0x0600F470 RID: 62576 RVA: 0x0007373C File Offset: 0x0007193C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A35 RID: 18997
			// (get) Token: 0x0600F471 RID: 62577 RVA: 0x003AC6B0 File Offset: 0x003AA8B0
			// (set) Token: 0x0600F472 RID: 62578 RVA: 0x0007375B File Offset: 0x0007195B
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17004A36 RID: 18998
			// (get) Token: 0x0600F473 RID: 62579 RVA: 0x003AC6D8 File Offset: 0x003AA8D8
			// (set) Token: 0x0600F474 RID: 62580 RVA: 0x00073776 File Offset: 0x00071976
			public unsafe DialogueChoiceEntry choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChoiceEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A37 RID: 18999
			// (get) Token: 0x0600F475 RID: 62581 RVA: 0x003AC708 File Offset: 0x003AA908
			// (set) Token: 0x0600F476 RID: 62582 RVA: 0x00073795 File Offset: 0x00071995
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A38 RID: 19000
			// (get) Token: 0x0600F477 RID: 62583 RVA: 0x003AC738 File Offset: 0x003AA938
			// (set) Token: 0x0600F478 RID: 62584 RVA: 0x000737B4 File Offset: 0x000719B4
			public unsafe float _realFadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__realFadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__realFadeTime_5__2)) = value;
				}
			}

			// Token: 0x17004A39 RID: 19001
			// (get) Token: 0x0600F479 RID: 62585 RVA: 0x003AC760 File Offset: 0x003AA960
			// (set) Token: 0x0600F47A RID: 62586 RVA: 0x000737CF File Offset: 0x000719CF
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__30.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A573 RID: 42355
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A574 RID: 42356
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A575 RID: 42357
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x0400A576 RID: 42358
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x0400A577 RID: 42359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A578 RID: 42360
			private static readonly IntPtr NativeFieldInfoPtr__realFadeTime_5__2;

			// Token: 0x0400A579 RID: 42361
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A57A RID: 42362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A57B RID: 42363
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A57C RID: 42364
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A57D RID: 42365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A57E RID: 42366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A57F RID: 42367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CC2 RID: 3266
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<RolloutDialogue>d__27")]
		public sealed class _RolloutDialogue_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600F47B RID: 62587 RVA: 0x003AC788 File Offset: 0x003AA988
			// Note: this type is marked as 'beforefieldinit'.
			static _RolloutDialogue_d__27()
			{
				Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<RolloutDialogue>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr);
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<>1__state");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<>2__current");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "text");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<>4__this");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "choices");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__activeDialogueChoices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<activeDialogueChoices>5__2");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__rolloutTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<rolloutTime>5__3");
				DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, "<i>5__4");
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686608);
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686609);
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686610);
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686611);
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686612);
				DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr, 100686613);
			}

			// Token: 0x0600F47C RID: 62588 RVA: 0x003AC8CC File Offset: 0x003AAACC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RolloutDialogue_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F47D RID: 62589 RVA: 0x003AC914 File Offset: 0x003AAB14
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F47E RID: 62590 RVA: 0x003AC948 File Offset: 0x003AAB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300566, XrefRangeEnd = 300621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A44 RID: 19012
			// (get) Token: 0x0600F47F RID: 62591 RVA: 0x003AC984 File Offset: 0x003AAB84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F480 RID: 62592 RVA: 0x003AC9C4 File Offset: 0x003AABC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300621, XrefRangeEnd = 300626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A45 RID: 19013
			// (get) Token: 0x0600F481 RID: 62593 RVA: 0x003AC9F8 File Offset: 0x003AABF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F482 RID: 62594 RVA: 0x000737EA File Offset: 0x000719EA
			public _RolloutDialogue_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A3C RID: 19004
			// (get) Token: 0x0600F483 RID: 62595 RVA: 0x003ACA38 File Offset: 0x003AAC38
			// (set) Token: 0x0600F484 RID: 62596 RVA: 0x000737F3 File Offset: 0x000719F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A3D RID: 19005
			// (get) Token: 0x0600F485 RID: 62597 RVA: 0x003ACA60 File Offset: 0x003AAC60
			// (set) Token: 0x0600F486 RID: 62598 RVA: 0x0007380E File Offset: 0x00071A0E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A3E RID: 19006
			// (get) Token: 0x0600F487 RID: 62599 RVA: 0x003ACA90 File Offset: 0x003AAC90
			// (set) Token: 0x0600F488 RID: 62600 RVA: 0x0007382D File Offset: 0x00071A2D
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A3F RID: 19007
			// (get) Token: 0x0600F489 RID: 62601 RVA: 0x003ACAB8 File Offset: 0x003AACB8
			// (set) Token: 0x0600F48A RID: 62602 RVA: 0x0007384C File Offset: 0x00071A4C
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A40 RID: 19008
			// (get) Token: 0x0600F48B RID: 62603 RVA: 0x003ACAE8 File Offset: 0x003AACE8
			// (set) Token: 0x0600F48C RID: 62604 RVA: 0x0007386B File Offset: 0x00071A6B
			public unsafe List<DialogueChoiceData> choices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_choices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A41 RID: 19009
			// (get) Token: 0x0600F48D RID: 62605 RVA: 0x003ACB18 File Offset: 0x003AAD18
			// (set) Token: 0x0600F48E RID: 62606 RVA: 0x0007388A File Offset: 0x00071A8A
			public unsafe List<int> _activeDialogueChoices_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__activeDialogueChoices_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__activeDialogueChoices_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A42 RID: 19010
			// (get) Token: 0x0600F48F RID: 62607 RVA: 0x003ACB48 File Offset: 0x003AAD48
			// (set) Token: 0x0600F490 RID: 62608 RVA: 0x000738A9 File Offset: 0x00071AA9
			public unsafe float _rolloutTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__rolloutTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__rolloutTime_5__3)) = value;
				}
			}

			// Token: 0x17004A43 RID: 19011
			// (get) Token: 0x0600F491 RID: 62609 RVA: 0x003ACB70 File Offset: 0x003AAD70
			// (set) Token: 0x0600F492 RID: 62610 RVA: 0x000738C4 File Offset: 0x00071AC4
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__27.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400A580 RID: 42368
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A581 RID: 42369
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A582 RID: 42370
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x0400A583 RID: 42371
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A584 RID: 42372
			private static readonly IntPtr NativeFieldInfoPtr_choices;

			// Token: 0x0400A585 RID: 42373
			private static readonly IntPtr NativeFieldInfoPtr__activeDialogueChoices_5__2;

			// Token: 0x0400A586 RID: 42374
			private static readonly IntPtr NativeFieldInfoPtr__rolloutTime_5__3;

			// Token: 0x0400A587 RID: 42375
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400A588 RID: 42376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A589 RID: 42377
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A58A RID: 42378
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A58B RID: 42379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A58C RID: 42380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A58D RID: 42381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CC3 RID: 3267
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<SelectPanel>d__28")]
		public sealed class _SelectPanel_d__28 : Il2CppSystem.Object
		{
			// Token: 0x0600F493 RID: 62611 RVA: 0x003ACB98 File Offset: 0x003AAD98
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectPanel_d__28()
			{
				Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<SelectPanel>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr);
				DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, "<>1__state");
				DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, "<>2__current");
				DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, "<>4__this");
				DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, "selectable");
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686614);
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686615);
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686616);
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686617);
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686618);
				DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr, 100686619);
			}

			// Token: 0x0600F494 RID: 62612 RVA: 0x003ACC8C File Offset: 0x003AAE8C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectPanel_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._SelectPanel_d__28>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F495 RID: 62613 RVA: 0x003ACCD4 File Offset: 0x003AAED4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F496 RID: 62614 RVA: 0x003ACD08 File Offset: 0x003AAF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300626, XrefRangeEnd = 300627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A4A RID: 19018
			// (get) Token: 0x0600F497 RID: 62615 RVA: 0x003ACD44 File Offset: 0x003AAF44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F498 RID: 62616 RVA: 0x003ACD84 File Offset: 0x003AAF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300627, XrefRangeEnd = 300632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A4B RID: 19019
			// (get) Token: 0x0600F499 RID: 62617 RVA: 0x003ACDB8 File Offset: 0x003AAFB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._SelectPanel_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F49A RID: 62618 RVA: 0x000738DF File Offset: 0x00071ADF
			public _SelectPanel_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A46 RID: 19014
			// (get) Token: 0x0600F49B RID: 62619 RVA: 0x003ACDF8 File Offset: 0x003AAFF8
			// (set) Token: 0x0600F49C RID: 62620 RVA: 0x000738E8 File Offset: 0x00071AE8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A47 RID: 19015
			// (get) Token: 0x0600F49D RID: 62621 RVA: 0x003ACE20 File Offset: 0x003AB020
			// (set) Token: 0x0600F49E RID: 62622 RVA: 0x00073903 File Offset: 0x00071B03
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A48 RID: 19016
			// (get) Token: 0x0600F49F RID: 62623 RVA: 0x003ACE50 File Offset: 0x003AB050
			// (set) Token: 0x0600F4A0 RID: 62624 RVA: 0x00073922 File Offset: 0x00071B22
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A49 RID: 19017
			// (get) Token: 0x0600F4A1 RID: 62625 RVA: 0x003ACE80 File Offset: 0x003AB080
			// (set) Token: 0x0600F4A2 RID: 62626 RVA: 0x00073941 File Offset: 0x00071B41
			public unsafe UISelectable selectable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr_selectable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._SelectPanel_d__28.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A58E RID: 42382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A58F RID: 42383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A590 RID: 42384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A591 RID: 42385
			private static readonly IntPtr NativeFieldInfoPtr_selectable;

			// Token: 0x0400A592 RID: 42386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A593 RID: 42387
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A594 RID: 42388
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A595 RID: 42389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A596 RID: 42390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A597 RID: 42391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
